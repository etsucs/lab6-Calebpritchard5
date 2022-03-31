/**       
 *--------------------------------------------------------------------
 * 	   File name: {Lab6CP}
 * 	Project name: {Methods}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Caleb Pritchard  Pritchardc1@etsu.edu}				
 *          Course-Section: {CSCI-1250-002}
 *           Creation Date:	 {3/24/2022}		
 * -------------------------------------------------------------------
 */

////////    Method 1    ////////////////


Console.WriteLine("Please enter a word: ");
string Word = Console.ReadLine();

Console.WriteLine("Please enter a number: ");
var num = Convert.ToInt32(Console.ReadLine());

// call
ShowCharacter(Word,num);


//declaration
static void ShowCharacter(String str, int num)
{
    System.Console.WriteLine($"Character {num} in {str} is {str[num-1]}");
}

///////////   Method 2   ///////////////


System.Console.WriteLine("Please enter item's wholesale cost: ");
var numW = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Please enter item's markup percentage: ");
var numP = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"The total markup cost is {CalculateRetail(numW, numP)}");

static double CalculateRetail(double num1, double num2)
{
    double Total = (num1 * (num2/100.0) + num1);
    return Total;
}


/////////////   Method 3   ////////////////


///Call
for(int i = 80; i <= 100; i++)
{
   System.Console.WriteLine(Celcius(i)); 
}

///Declaration
//C = 5/9 * (F - 32)

static double Celcius(double FTemp)
{
    var cTemp = (5.0/9.0) * (FTemp -32);
    return cTemp;
}


//----------------------------------------------------------------//


Console.WriteLine("Please enter any number: ");
int numPP = Convert.ToInt32(Console.ReadLine());


static bool IsPrime(int numPP)
{
    var xCount = 0;

    var OCount = 0;

        if(numPP/numPP == 1)
        {
            return true;
            Console.WriteLine("True");
        }
        else
        {
            return false;
            Console.WriteLine("False");
        }
}