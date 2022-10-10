// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondNumber(int num)

// {int result;

//     if (num < 10 || num > 1000 )
//         return 0;
//     else
//     {
//         int dec = num / 10;
//         int secondnum = dec % 10;
//         result = secondnum;
//     }
//     return result;
//    }
//    Console.Write("Input third-digit number: ");
//    int number = Convert.ToInt32(Console.ReadLine());

//    int secondNumber = SecondNumber(number);
//    Console.WriteLine($"Second number of {number} is {secondNumber}");

// 2.  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

        // int ThirdNumber(int num)
        // {
        //     int result;
        //     int thirdigit;
        //     int thirdnum;
            

        //     if (num < 100)
        //     {
        //         Console.WriteLine("третьей цифры нет");
        //         return -1;
        //     }
        
        //         while (num > 999)
        //         {
        //             num = num / 10; 
        //         }
        //             thirdigit = num;
        //             thirdnum = thirdigit % 10;
        //             result = thirdnum;
                
        //    return result;      
        // }
        
        // Console.WriteLine("Input a number: ");
        // int number = Convert.ToInt32(Console.ReadLine());

        // int thirdnum = ThirdNumber(number);
        // Console.WriteLine($"Third number of {number} is {thirdnum}");
    


// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// bool Day(int num)
// {
//     if (num >=1 && num <= 5)

//         return true;

//      else       
//          return false;
// }
// Console.WriteLine("Введите номер дня недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool Suc = Day (num);
// Console.WriteLine($"Ответ: {Suc}");


