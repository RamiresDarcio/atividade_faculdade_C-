// See https://aka.ms/new-console-template for more information


try
{
 int divisor = 0;
 int resultado = 10 / divisor;
 Console.WriteLine("resultado"+resultado);

}
catch (DivideByZeroException e)
{
 Console.WriteLine($"erro matematica:{e.Message}");
}

    