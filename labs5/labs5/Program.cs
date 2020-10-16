using System;
using System.Threading;

namespace NewNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите до кого числа факториал");
            int maxNunber = EnterAndCheck();

            long maxFactorial = FindFactorial(maxNunber);
            string factorialMaxNum = Convert.ToString(maxFactorial);
            int maxSymInMaxFactorial = factorialMaxNum.Length + 2;

            string maxNunberString = Convert.ToString(maxNunber);
            int maxSymInMaxNumber = maxNunberString.Length + 2;

            
            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;

                Thread.Sleep(1000);
                ConclusionTablet(maxSymInMaxNumber, maxSymInMaxFactorial, maxNunber);
                Console.WriteLine(" ");
                Thread.Sleep(1000);
            } while (true);

            
        }

        static int EnterAndCheck()
        {
            do
            {
                int maxNunber = Convert.ToInt32(Console.ReadLine());

                if (maxNunber >= 0)        //Надо ли ввыводить проверку в отдельный метод?
                    return maxNunber;

                else
                    Console.WriteLine("Вы неверно ввели число");

            } while (true);
        }

        static long FindFactorial(int number) 
        {
            long factorial = 1;

            if (number==0) 
            {
                return 0; 
            }
            else
            {
                for (int j = 1; j <= number; j++)
                {
                    factorial *=  j  ;
                }
                return factorial;
            }
        }

        public static void WriteBoxLine(int maxSymInMaxNumber, int maxSymInMaxFactorial, char oneSym, char twoSym, char thirdSym, char fourthSym)
        {
            Console.Write(oneSym);

            for (int a = 0; a < maxSymInMaxNumber; a++) //Нужно ли вывести это в отдельный метод ? Не знаю можно ли это назвать повторение кода   
                Console.Write(twoSym);                    

            Console.Write(thirdSym);

            for (int b = 0; b < maxSymInMaxFactorial; b++) 
                Console.Write(twoSym);

            Console.WriteLine(fourthSym);
        }

         static void WriteBoxLine(int maxSymInMaxNumber, int maxSymInMaxFactorial, char oneSym, char twoSym, char thirdSym, char fourthSym, string number ,string factorial)
         {  //Не знаю правильным ли будет разбить  этот метод на ещё один, что бы не было повторения кода, ибо слишком много переменных переносить
            Console.Write(oneSym);

            Filling(maxSymInMaxNumber, twoSym, thirdSym, fourthSym, number);
            Filling(maxSymInMaxFactorial, twoSym, thirdSym, fourthSym, factorial);
            Console.WriteLine("");
         }

        static void Filling(int maxSymInMaxFactorialAndMaxNumber, char twoSym, char thirdSym, char fourthSym,string numberOrFactorial)
        {
            Console.Write(twoSym);
            Console.Write(numberOrFactorial);
            int output = maxSymInMaxFactorialAndMaxNumber - numberOrFactorial.Length - 1;

            for (int j = 0; j < output; j++)
                Console.Write(twoSym);

            Console.Write(fourthSym);
        }

        static void ConclusionTablet(int maxSymInMaxNumber, int maxSymInMaxFactorial, int maxNunber)
        {
            

            WriteBoxLine(maxSymInMaxNumber, maxSymInMaxFactorial, '╔', '═', '╦', '╗');
            WriteBoxLine(maxSymInMaxNumber, maxSymInMaxFactorial, '║', ' ', '║', '║');
            for (int number = 0; number <= maxNunber; number++)
            {
                long factorial = FindFactorial(number);
                WriteBoxLine(maxSymInMaxNumber, maxSymInMaxFactorial, '║', ' ', ' ', '║', Convert.ToString(number), Convert.ToString(factorial));
            }
            WriteBoxLine(maxSymInMaxNumber, maxSymInMaxFactorial, '║', ' ', '║', '║');
            WriteBoxLine(maxSymInMaxNumber, maxSymInMaxFactorial, '╚', '═', '╩', '╝');
        }

    }
}