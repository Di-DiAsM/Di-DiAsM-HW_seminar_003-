// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();

// 1й способ***************************************************************

// Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine();

// if (number.Length == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"Число {number} - является ПАЛИНДРОМОМ");
//     }
//     else
//     {
//         Console.WriteLine($"Число {number} - Не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("ввели неверное число");
// }

//2й способ****************************************************************
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine(); 

void Sravnenie(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Число {number} - является ПАЛИНДРОМОМ");
    }
    else
     {
         Console.WriteLine($"Число {number} - Не является палиндромом");
     }
}



if (number?.Length == 5)
{
    Sravnenie(number);
}
else
{
    Console.WriteLine("ввели неверное число");
}

//3й способ****************************************************************
// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int number = ReadInt("Введите пятизначное число: ");
// int firstDigit = number / 10000;
// int lastDigit = number % 10;
// int secondGigit = (number / 1000) % 10;
// int fourDigit = (number / 10) % 10;

// if(firstDigit == lastDigit && secondGigit == fourDigit)
// {
//     Console.WriteLine($"Число {number} является палиндромом");
// } 
// else if (number > 99999 || number < 10000)
// {
//     Console.WriteLine("ввели неверное число");
// }
// else
// {
//     Console.WriteLine($"Число {number} не является палиндромом");
// } 
