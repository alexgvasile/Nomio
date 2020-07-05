namespace Nomio.Components
{
    public class Preset
    {
        public string PresetName { get; set; }
        public string PresetDescription { get; set; }
        public string RegexSingleEpisode { get; set; }
        public string RegexMultiEpisode { get; set; }
        public string RegexSeasonOnly { get; set; }
        public string RegexEpisodeOnly { get; set; }

        public Preset(string presetName, string regexSingleEpisode, string regexMultiEpisode, string regexSeasonOnly, string regexEpisodeOnly)
        {
            PresetName = presetName;
            RegexSingleEpisode = regexSingleEpisode;
            RegexMultiEpisode = regexMultiEpisode;
            RegexSeasonOnly = regexSeasonOnly;
            RegexEpisodeOnly = regexEpisodeOnly;
        }
    }
}
