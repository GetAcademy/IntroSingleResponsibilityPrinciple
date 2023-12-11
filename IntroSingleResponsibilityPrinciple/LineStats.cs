namespace IntroSingleResponsibilityPrinciple
{
    internal class LineStats
    {
        public string Word { get; }
        public int MatchingLineCount { get; }
        public int TotalLineCount { get; }

        public LineStats(string word, int matchingLineCount, int totalLineCount)
        {
            Word = word;
            MatchingLineCount = matchingLineCount;
            TotalLineCount = totalLineCount;
        }

        public string GetDescription()
        {
            return $"{MatchingLineCount} av {TotalLineCount} linjer inneholdt ordet \"{Word}\"";
        }
    }
}
