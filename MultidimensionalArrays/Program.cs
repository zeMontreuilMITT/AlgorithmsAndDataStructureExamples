/*1.Entire Alphabet checker
If the input string does not contain all letters, print a message to the console state which letters are missing. */

// == PROMPT FOR INPUT
using System.ComponentModel;
using System.Runtime.InteropServices;

Console.WriteLine("Please enter a sentence.");
string userInput = Console.ReadLine();

while(userInput.Length < 3)
{
    Console.WriteLine("Please enter at least three characters.");
    userInput = Console.ReadLine();
}

char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

// check for missing values from a premade list against another list
// HashSets are essentially Dictionaries with only Keys
// Dictionaries are like HashSets with extra functionality
Dictionary<char, bool> charCheck = new Dictionary<char, bool>();

foreach(char c in alpha)
{
    charCheck.Add(c, false);
}

foreach (char c in userInput)
{
    if (Char.IsLetter(c))
    {
        char normalized = Char.ToUpper(c);
        charCheck[normalized] = true;
    }
}

// Does every value in our collection fulfill a certain criteria?
// assume that every element is what we're looking for until we're proven incorrect
bool hasAllEnglishCharacters = true;
List<char> missingChars = new List<char>();


// {{A:true}, {B:true}, {C: false}, {D: true}}

foreach(KeyValuePair<char, bool> pair in charCheck)
{
    //if(pair.Value == false)
    if(!pair.Value)
    {
        missingChars.Add(pair.Key);
        hasAllEnglishCharacters = false;
    }
}

if (hasAllEnglishCharacters)
{
    Console.WriteLine("String contains all characters of the english alphabet.");
}
else
{
    Console.WriteLine("String is missing characters: ");
    Console.WriteLine(String.Join(", ", missingChars)); 
}



// because all collection values are only iterated over once, our solution is ON (linear)