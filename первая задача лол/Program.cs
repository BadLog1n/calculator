using System;

namespace первая_задача_лол
{

    class Program
    {
        static void Main(string[] args)
        {
            const string probel = " ";
            string probel1 = " ";
            string palochka = "_";
            int c1, c2, c3 = 0;
            int deistvie = 0;
            Console.WriteLine("Введите первый элемент:");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второй элемент:");
            c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление");
            Console.WriteLine();
            deistvie = Convert.ToInt32(Console.ReadLine());
            switch (deistvie)
            {
                case 1:
                    Slogenie(c1, c2);
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Slogenie(c1, c2);
        }
        static void Slogenie(int c1, int c2)
        {
            const string probel = " ";
            string probel1 = " ";
            string palochka = "_";
            int c3 = 0;
            c3 = c1 + c2;

            int CountC1 = (int)Math.Log10(c1) + 1;
            int CountC2 = (int)Math.Log10(c2) + 1;
            int CountC3 = (int)Math.Log10(c3) + 1;
            bool proverka = false;
            string c1str = Convert.ToString(c1), c2str = Convert.ToString(c2), c3str = Convert.ToString(c3);
            if ((CountC3 > CountC1) && (CountC3 > CountC2))
            {
                proverka = true;

            }
            if (CountC2 == CountC1)
            {
                c1str = probel + c1;
                c2str = probel + c2;
            }
            else if (CountC2 > CountC1)
            {

                while (CountC2 > CountC1)
                {
                    probel1 += probel;
                    CountC2--;
                }

                c1str = probel1 + c1;
                c2str = probel + c2;
            }
            else if (CountC1 > CountC2)
            {
                while (CountC1 > CountC2)
                {
                    probel1 += probel;

                    CountC1--;
                }
                c1str = probel + c1;
                c2str = probel1 + c2;
            }

            Console.Clear();
            Console.Write(c1str);
            Console.WriteLine();
            Console.Write("+");
            Console.WriteLine();
            Console.Write(c2str);
            Console.WriteLine();
            if (proverka == false)
            {
                Console.Write(probel);
            }

            for (int i = 0; i<CountC3; i++)
            {
                Console.Write(palochka);
            }
Console.WriteLine();
            if (proverka == true)
            {

                Console.WriteLine(c3);
            }
            else
            {

                Console.Write(probel);
                Console.WriteLine(c3);

            }


            Console.ReadKey();
        }
    }

}
