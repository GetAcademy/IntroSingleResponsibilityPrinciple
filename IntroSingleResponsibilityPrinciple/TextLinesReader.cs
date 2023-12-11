namespace IntroSingleResponsibilityPrinciple
{
    internal class TextLinesReader
    {
        private readonly StreamReader _streamReader;
        public TextLinesReader(string filename)
        {
            _streamReader = new StreamReader(filename);
        }

        public string GetLine()
        {
            var line = _streamReader.ReadLine();
            if (line == null)
            {
                _streamReader.Close();
            }

            return line;
        }
    }
}
