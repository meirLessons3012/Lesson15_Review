using Lesson15;

// Class |  Method | Property => FirstWordAndSecondWord
// field | instance => startWithLowerCase
// Const => ONLY_UPPER_CASE
int myNum;
string numberFromUser = Console.ReadLine();
if(int.TryParse(numberFromUser, out myNum))
{

}


Car c1 = new Car(CarTypes.Toyota, true, true);

string inputFromUser = "Tesla";
CarTypes ct = (CarTypes)Enum.Parse(typeof(CarTypes), inputFromUser);
Car c = null;
CarTypes[] carTypes = { CarTypes.Toyota, CarTypes.Tesla };
Garage g = new Garage(carTypes);
g.AddCar(c);

int[] ss = { 3,14,72 };

int result = 0;
for (int i = 0; i < ss.Length; i++)
{
    result += ss[i];
}
Console.WriteLine(result);

try
{
    A(3, 1);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
}
catch (ArgumentException ex)
{

}
catch (MyCustomException ex) when (ex.N1 == 0)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.N1);
    Console.WriteLine(ex.N2);
}
catch (MyCustomException ex) when (ex.N1 == 1)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.N1);
    Console.WriteLine(ex.N2);
}
catch (MyCustomException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.N1);
    Console.WriteLine(ex.N2);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

static void A(int n1, int n2)
{
    Console.WriteLine(n1 * n2);
    B(n1,  ref n2);
}

static void B(int n1, ref int n2)
{
    try
    {
        //Connect....
        Console.WriteLine("Hello from B Method");
        if (n1 == 1 || n2 == 1)
        {
            Program p = new Program();
            throw new MyCustomException(n1, n2, $"n1 or n2 cannot be equal to 1");
        }
        Console.WriteLine(n1 / n2);
    }
    finally
    {
        Console.WriteLine("from finally");
        //Disconnect
    }
}
