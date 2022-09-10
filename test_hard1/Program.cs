Console.Write("Введите число: ");
string n = Console.ReadLine();
char[] num = n.ToCharArray();
int lngth = n.Length;
for (int i = n.Length - 1; i <= 0; i--)
    Console.WriteLine($"{num[i]}");
//     {
//         if (num[i] == num[lngth-1])
//         {
//             polindrom = true;
//             break;
//         }
//     }
//     if (polindrom) return $"Число {n} является полиндромом";
//     else return $"Число {n} не является полиндромом";

// try
// {
//     Console.WriteLine(Polindrom());
// }
// catch
// {
//     Console.WriteLine("Необходимо ввести именно числа");
// }

