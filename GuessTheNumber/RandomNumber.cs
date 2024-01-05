using System;

class GuessTheNumber
{
    static void Main()
    {
        int UserNumber, attempts;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Вгадай число вiд 1 до 100!");

        Random random = new Random();
        int SecretNumber = random.Next(1, 101);
        
        for (attempts = 1; ; attempts++)
        {
            string numb = Console.ReadLine();
            
            if (int.TryParse(numb, out UserNumber))
            {

                if (UserNumber < SecretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Загадене число бiльше вашого");
                }
                
                else if (UserNumber > SecretNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Загадене число менше вашого");
                }
                
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Вiтаю! Ви вгадали число! 3агадане число: {SecretNumber} за {attempts} разів");
                    break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Невiрний формат введеня числа!");
            }
        }
    }
}