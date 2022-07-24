Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
string str = n.ToString();
if (str.Length > 2)
{
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


