using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nomio.Components
{
    public class Controller
    {
        public string mainDirectory { get; set; }
        public string tvShowName { get; set; }
        public string delimiter { get; set; }
        public string rxSingleEp { get; set; }
        public string rxMultiEp { get; set; }
        public string rxSeason { get; set; }
        public string rxEpisode { get; set; }
        public string rxEpisodes { get; set; }
        public List<string> removalWords { get; set; }
        public List<string> replacementOldWords { get; set; }
        public List<string> replacementNewWords { get; set; }
        public Dictionary<string, string> replacementWords { get; set; }
        public Dictionary<string, string> localBuffer { get; set; }

        public Controller()
        {
            localBuffer = new Dictionary<string, string>();
        }

        public Dictionary<string, string> PreviewRename()
        {
            rxEpisodes = !string.IsNullOrWhiteSpace(rxMultiEp) ? rxMultiEp.Substring(rxSeason.Length, rxMultiEp.Length - rxSeason.Length) : "";

            foreach (string season in Directory.EnumerateDirectories(mainDirectory))
            {
                foreach (string file in Directory.EnumerateFiles(season))
                {
                    //Extract original filename info
                    var fileDirectory = file.Substring(0, file.Length - file.Split(Path.DirectorySeparatorChar).Last().Length);
                    var fullFileName = file.Split(Path.DirectorySeparatorChar).Last();
                    var extension = "." + fullFileName.Split('.').Last();
                    var oldFileName = fullFileName.Substring(0, fullFileName.Length - extension.Length);

                    Match fullMatch = null;
                    string episodeNumbering = "";

                    if (Regex.IsMatch(oldFileName, rxSingleEp) || Regex.IsMatch(oldFileName, rxMultiEp))
                    {
                        //Get full match of episode season and number, either single or multi-episode files
                        fullMatch = !string.IsNullOrWhiteSpace(rxMultiEp) ?
                            (Regex.IsMatch(oldFileName, rxMultiEp) ? Regex.Match(oldFileName, rxMultiEp) : Regex.Match(oldFileName, rxSingleEp)) : Regex.Match(oldFileName, rxSingleEp);

                        //Parse and rebuild old season and episode information to Plex compliant format
                        episodeNumbering = GetNumbering(Regex.Match(fullMatch.Value, rxSeason).Value,
                            !string.IsNullOrWhiteSpace(rxMultiEp) ? (Regex.IsMatch(oldFileName, rxMultiEp) ? Regex.Match(fullMatch.Value, rxEpisodes).Value : Regex.Match(fullMatch.Value, rxEpisode).Value) :
                            Regex.Match(fullMatch.Value, rxEpisode).Value);

                        //Extract words before and after episode numbering information (match)
                        var preMatchWords = oldFileName.Substring(0, fullMatch.Index).Split(delimiter.ToCharArray()).ToList();
                        var postMatchWords = oldFileName.Substring(fullMatch.Index + fullMatch.Length, oldFileName.Length - (fullMatch.Index + fullMatch.Length)).Split(delimiter.ToCharArray()).ToList();

                        Sanitize(preMatchWords);
                        Sanitize(postMatchWords);

                        //Rebuild filename
                        string newFileName = "";

                        if (preMatchWords.Count == 0)
                        {
                            newFileName += tvShowName + " ";
                        }
                        else
                        {
                            foreach (string word in preMatchWords) newFileName += word + " ";
                        }

                        newFileName += episodeNumbering;

                        if (postMatchWords.Count == 0)
                        {
                            newFileName = newFileName.TrimEnd(" -".ToCharArray());
                        }
                        else
                        {
                            foreach (string word in postMatchWords) newFileName += " " + word;
                        }

                        newFileName = newFileName.TrimEnd('.');
                        var newFile = fileDirectory + newFileName + extension;

                        //Add to buffer
                        localBuffer.Add(file, newFile);
                    }
                }
            }

            return localBuffer;
        }

        public void ExecuteRename(Dictionary<string, string> confirmedFileNames)
        {
            localBuffer.Clear();
            localBuffer = confirmedFileNames;

            foreach (KeyValuePair<string, string> fileName in localBuffer)
            {
                File.Move(fileName.Key, fileName.Value);
            }
        }

        public void UndoRename()
        {
            foreach (KeyValuePair<string, string> fileName in localBuffer)
            {
                File.Move(fileName.Value, fileName.Key);
            }
        }

        private string GetNumbering(string seasonMatch, string episodeMatch)
        {
            return "- s" + GetNumber(seasonMatch) + "e" + GetNumber(episodeMatch) + " -";
        }

        private string GetNumber(string regexMatchValue)
        {
            string number = "";

            var matches = Regex.Matches(regexMatchValue, "\\d+");

            if (matches.Count == 1)
            {
                number = matches[0].Value.TrimStart('0');
                number = number.Length > 0 ? (number.Length == 1 ? "0" + number : number) : "00";
            }

            if (matches.Count > 1)
            {
                var startNo = matches[0].Value.TrimStart('0');
                var stopNo = matches[matches.Count - 1].Value.TrimStart('0');
                startNo = startNo.Length > 0 ? (startNo.Length == 1 ? "0" + startNo : startNo) : "00";
                stopNo = stopNo.Length > 0 ? (stopNo.Length == 1 ? "0" + stopNo : stopNo) : "00";
                number = startNo + "-e" + stopNo;
            }

            return number;
        }

        private void Sanitize(List<string> list)
        {
            list.RemoveAll(x => removalWords.Contains(x) || string.IsNullOrWhiteSpace(x) || x.Equals("-"));

            for (int i = 0; i < list.Count; i++)
            {
                if (replacementWords.ContainsKey(list[i]))
                {
                    list[i] = replacementWords.First(x => x.Key == list[i]).Value;
                }
            }
        }

        public void ClearProperties()
        {
            mainDirectory = "";
            tvShowName = "";
            delimiter = "";
            rxSingleEp = "";
            rxMultiEp = "";
            rxSeason = "";
            rxEpisode = "";
            rxEpisodes = "";
            removalWords = null;
            replacementOldWords = null;
            replacementNewWords = null;
            replacementWords = null;
            localBuffer.Clear();
        }
    }
}
