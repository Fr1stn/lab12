Console.WriteLine("Напишите что-нибудь(желательно с цифрами):");
string Mix = Console.ReadLine();
int x = 0;
foreach  (char c in Mix)
{
    if (c >= '0' && c <= '9')
    {
        x++;
    }
}
Console.WriteLine();
Console.WriteLine($"{x} цифр в строке.");
