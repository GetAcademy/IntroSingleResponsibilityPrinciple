namespace IntroSingleResponsibilityPrinciple
{
    internal class CountWordInLinesService
    {
        public static LineStats Count(string filename, string word)
        {
            var wordLower = word.ToLower();
            //using var sr = new StreamReader(filename);
            var fileReader = new TextLinesReader(filename);
            var matchingLineCount = 0;
            var totalLineCount = 0;
            while (true)
            {
                // var line = fileReader.ReadLine();
                var line = fileReader.GetLine();
                if (line == null) break;
                var lineLower = line.ToLower();
                if (lineLower.Contains(wordLower)) matchingLineCount++;
                totalLineCount++;
            }

            return new LineStats(word, matchingLineCount, totalLineCount);
        }
    }
}
