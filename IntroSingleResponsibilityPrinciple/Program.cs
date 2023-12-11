Console.Write("Skriv inn filnavn: ");
var filename = Console.ReadLine();
Console.Write("Skriv inn et ord: ");
var word = Console.ReadLine();
var wordLower = word.ToLower();
using var sr = new StreamReader(filename);
var matchingLineCount = 0;
var totalLineCount = 0;
while (true)
{
    var line = sr.ReadLine();
    if (line == null) break;
    var lineLower = line.ToLower();
    if (lineLower.Contains(wordLower)) matchingLineCount++;
    totalLineCount++;
}
Console.WriteLine($"{matchingLineCount} av {totalLineCount} linjer inneholdt ordet \"{word}\"");
