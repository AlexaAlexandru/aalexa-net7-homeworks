// exercise 1

string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input1);
string input2 = Console.ReadLine();
int num2 = Convert.ToInt32(input2);
int addition = num1 + num2;
int substraction = num1 - num2;
int  division = num1 / num2;
int multiplication = num1 * num2;

Console.WriteLine("Addition = " + addition + " ");
Console.WriteLine();
Console.WriteLine("Subtraction = " + substraction + " ");
Console.WriteLine();
Console.WriteLine("Division = " + division + " ");
Console.WriteLine();
Console.WriteLine("Multiplication = " + multiplication + " " );

string input3 = Console.ReadLine();
double num3 = Convert.ToDouble(input3);
string input4 = Console.ReadLine();
int num4 = Convert.ToInt32(input4);
double add = num3 + num4;
double sub = num3 - num4;
double div = num3 / num4;
double mult = num3 * num4;

Console.WriteLine("Addition = " + add + " ");
Console.WriteLine("Subtraction = " + sub + " ");
Console.WriteLine("Division = " + div + " ");
Console.WriteLine("Multiplication = " + mult + " ");

//Exercise 2

string input1= Console.ReadLine();
int num1= Convert.ToInt32(input1);
string input2=Console.ReadLine();   
int num2=Convert.ToInt32(input2);
string input3=Console.ReadLine();
int num3=Convert.ToInt32(input3);

if (num1 < num2)
{
    if (num1 < num3)
    {
        Console.WriteLine("Minimum number is " + num1);
    }
    else
    {
        Console.WriteLine("Minimum number is " + num3);
    }
}
else
{
    if (num2 < num3)
    {
        Console.WriteLine("Minimum number is " + num2);
    }
    else
    {
        Console.WriteLine("Minimum number is " + num3);
    }
}

if (num1>num2)
{
	if (num1>num3)
	{
		Console.WriteLine("Maximum number is " + num1);
	}
	else
	{
		Console.WriteLine("Maximum number is " + num3);
	}
}
else
{
	if (num2>num3)
	{
		Console.WriteLine("Maximum number is" + num2);
	}
	else
	{
		Console.WriteLine("Maximum number is " + num3);
	}
}
