namespace IntroSingleResponsibilityPrinciple
{
    internal class ReadFileService
    {
        public string[] ReadLines(string filename)
        {
            return File.ReadAllLines(filename);
        }
    }
}
