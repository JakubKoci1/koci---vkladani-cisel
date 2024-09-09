Console.WriteLine("zadejte cislo mezi 1 a 10");
int value;
while (int.TryParse(Console.ReadLine(), out value) &&  value < 0 || value > 11)
{
    

    Console.WriteLine("to není ono zkus to znova");
    
    
}
Console.WriteLine( value);
