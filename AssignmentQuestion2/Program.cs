/* Prompt the user for a comma separated list of strings (e.g. daisy, dairy, darts, dais, dame).
Validate that the input is of the correct type
Provide feedback and re-prompt the user if the type is incorrect
Find the longest common prefix shared among all of the strings in the argument, or an empty string if there is none and show the result to the user
For example, ({daisy, dairy, darts, dais, dame}) returns "da". */

using System.Text;

Console.WriteLine("Enter a comma-separated list of strings: ");
bool validInput = true;

string inputString = Console.ReadLine();
List<string> inputs = inputString.Split(',').ToList();

// {"test", "do es"}

do
{
    // must assume correct at each iteration start
    validInput = true;

    foreach (string input in inputs)
    {
        // using a method for verifying all letter inputs from this Stack discussion: https://stackoverflow.com/a/1181488
        string word = input.Trim();
        if (!word.All(Char.IsLetter))
        {
            validInput = false;
            Console.WriteLine("Sorry, only enter comma-separated strings");
        }
    }

    if (!validInput)
    {
        inputString = Console.ReadLine();
        inputs = inputString.Split(',').ToList();
    }
} while (!validInput);

// find longest common prefix shared among all of the strings in the argument
StringBuilder commonPrefix = new StringBuilder();

int shortestWordLength = inputs.First().Trim().Length;
// get the shortest word
foreach(string input in inputs)
{
    if(input.Trim().Length < shortestWordLength)
    {
        shortestWordLength = input.Trim().Length;
    }
}

//{daisy, dairy, darts, dais, dame}) returns "da".
for (int i = 0; i < shortestWordLength; i++)
{
    char currentCharacter = inputs.First().Trim()[i];
    bool allMatch = true;

    foreach(string s in inputs)
    {
        string word = s.Trim();
        if (word[i] != currentCharacter)
        {
            allMatch = false;
        }
    }

    if (allMatch)
    {
        commonPrefix.Append(currentCharacter);
    } else
    {
        // break out of for loop at first non-matching value
        i = shortestWordLength;
    }
}

Console.WriteLine(commonPrefix.ToString());