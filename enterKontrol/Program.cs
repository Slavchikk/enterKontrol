using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterKontrol
{
    class Program
    {

        public void TaskOne()
        {
            Console.WriteLine("введите первое положительное число: ");
            double firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе положительное число: ");
            double secondNum = Convert.ToInt32(Console.ReadLine());
            double itog = Math.Log(firstNum, secondNum);
            Console.WriteLine("Логарифм первого числа по основанию второго: " + itog);
        }


        public void TaskTwo()
        {
            Console.WriteLine("введите координаты первой точки через enter ");
            int firstCoorx = Convert.ToInt32(Console.ReadLine());
            int firstCoory = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите координаты второй точки через enter ");
            int secondCoorx = Convert.ToInt32(Console.ReadLine());
            int secondCoory = Convert.ToInt32(Console.ReadLine());
            int firstNum = Math.Abs(firstCoorx - firstCoory);
            int secondNum =Math.Abs(secondCoorx - secondCoory);
            Console.WriteLine($"Периметр равен {2 * (firstNum + secondNum)} площадь равна {firstNum * secondNum}");
        }


        public void TaskThree()
        {
            Console.WriteLine("введите  число: ");
            double firstNum = Convert.ToInt32(Console.ReadLine());
            double devThree = firstNum % 3;
            double devFour = firstNum % 4;
            if (devThree == devFour) Console.WriteLine("данное число дает одинаковый остаток при делении на 3 и на 4");
            else Console.WriteLine("данное число НЕ дает одинаковый остаток при делении на 3 и на 4");
        }

        public void TaskFour()
        {
            Console.WriteLine("введите  число: ");
            long firstNum = long.Parse(Console.ReadLine());

            do
            {
                long num = firstNum % 10;
                Console.WriteLine(num);
                firstNum = firstNum/ 10;
            } while (firstNum > 0);
        }

        public void TaskFive()
        {
            Console.WriteLine("введите X: ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите Y: ");
            double y = Convert.ToInt32(Console.ReadLine());

           double result = (Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + Math.Pow(y, 2)));


        }
        
        public void TaskSix()
        {
            Console.WriteLine("Введите количество первых n чисел");

            int x = Convert.ToInt32(Console.ReadLine());
            int n1 = 1;
            int n2 = 1;
            int nx = 0;
            for(int i = 0; x != nx; i++)
            {
                var n3 = n1 + n2;
                if (i % 2 != 0)
                {
                    Console.WriteLine($"Index - {i} number -  {n3}");
                    nx++;
                }
                n1 = n2;
                n2 = n3;
            }

        }
        public void TaskSeven()
        {
            Console.WriteLine("Введите количество первых n чисел");
            int x = Convert.ToInt32(Console.ReadLine());
            int n1 = 1;
            int n2 = 2;
            double sum = 0;
            for(int i =0; i< x;i++)
            {
                sum += n1 / n2;
                n1++;
                n2++;
            }
            Console.WriteLine("Сумма равна: " + sum);
        }
        public void TaskEight()
        {
            Console.WriteLine("введите первое  число: ");
            double firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе  число: ");
            double secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите третье  число: ");
            double thirdNum = Convert.ToInt32(Console.ReadLine());

            if (firstNum + secondNum < 0) Console.WriteLine("Сумма первого и второго числа отрицательна");
            else if (firstNum + thirdNum < 0) Console.WriteLine("Сумма первого и третьего числа отрицательна");
            else if (secondNum + thirdNum < 0) Console.WriteLine("Сумма второго и третьего числа отрицательна");
            else Console.WriteLine("Нет отрицательной суммы из каких-либо двух чисел");

        }
        static void Main()
        {
            Program obj = new Program();
            Console.WriteLine("Введите номер задачи:  ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch(n)
            {
                case 1:                   
                    obj.TaskOne();
                    break;


                case 2:
                    obj.TaskTwo();
                    break;

                case 3:
                    obj.TaskThree();
                    break;
                case 4:
                    obj.TaskFour();
                    break;
                case 5:
                    obj.TaskFive();
                    break;
                case 6:
                    obj.TaskSix();
                    break;
                case 7:
                    obj.TaskSeven();
                    break;
                case 8:
                    obj.TaskEight();
                    break;
                default:
                    Console.WriteLine("Нету задачи с таким номером");
                    break;

            }
            
        }



    }

}
