// create a program that prompts users for positive numbers UNTIL they enter a number that is odd
// Once that is done, print all of the numbers comma-separated, and print the sum of all of those numbers

// if value is positive
/*// if value is divisible by two

 * while (num divisible by two)
 *  if(input greater than zero)
     *  get new value
     *  add to list
     *or do nothing
 *  */

Console.WriteLine("Please enter a number (odd value to stop)");
int intInput = Int32.Parse(Console.ReadLine());
List<int> evenValues = new List<int>();

/*while(intInput <= 0)
{
    Console.WriteLine("Please enter a positive value");
    intInput = Int32.Parse(Console.ReadLine());
}*/

bool evenInput = true;
while (evenInput)
{
    // if greater than zero, evaluate for even/odd
    if (intInput > 0)
    {
        if (intInput % 2 == 0)
        {
            evenValues.Add(intInput);
            Console.WriteLine("Enter another value: ");
            intInput = Int32.Parse(Console.ReadLine());
        }
        else
        {
            evenInput = false;
        }
    }
    else
    {
        Console.WriteLine("Please enter a value greater than zero: ");
        intInput = Int32.Parse(Console.ReadLine());
    }
}

string numberOutputs = String.Join(", ", evenValues);
Console.WriteLine(numberOutputs);

int sum = evenValues.Sum();
Console.WriteLine(sum);



