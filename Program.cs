using System;
namespace ConsoleApp10

{
    internal class Program
    {
        private static int Octav = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Для воспроизведения ДО нажмите Q");
            Console.WriteLine("Для воспроизведения ДО диез нажмите W");
            Console.WriteLine("Для воспроизведения РЕ нажмите E");
            Console.WriteLine("Для воспроизведения РЕ диез нажмите R");
            Console.WriteLine("Для воспроизведения МИ нажмите T");
            Console.WriteLine("Для воспроизведения ФА нажмите Y");
            Console.WriteLine("Для воспроизведения ФА диез нажмите U");
            Console.WriteLine("Для воспроизведения СОЛЬ нажмите I");
            Console.WriteLine("Для воспроизведения СОЛЬ диез нажмите O");
            Console.WriteLine("Для воспроизведения ЛЯ нажмите P");
            Console.WriteLine("Для воспроизведения ЛЯ диез нажмите A");
            Console.WriteLine("Для воспроизведения СИ нажмите S");
            Octava();
        }
        
        static void Beep(double Gg)
        {
            int Ms = 500;
            Console.Beep((int)Gg, Ms);
        }
        static void Octava()
        {
            int[] nota_1 = new int[] { 261, 523, 1047 };
            int[] nota_2 = new int[] { 277, 554, 1109 };
            int[] nota_3 = new int[] { 293, 587, 1175 };
            int[] nota_4 = new int[] { 311, 622, 1245 };
            int[] nota_5 = new int[] { 329, 659, 1319 };
            int[] nota_6 = new int[] { 349, 698, 1397 };
            int[] nota_7 = new int[] { 370, 740, 1480 };
            int[] nota_8 = new int[] { 329, 784, 1568 };
            int[] nota_9 = new int[] { 415, 830, 1661 };
            int[] nota_10 = new int[] { 440, 880, 1760 };
            int[] nota_11 = new int[] { 466, 932, 1865 };
            int[] nota_12 = new int[] { 493, 987, 1976 };

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey(intercept: true);

                    if (Key.Key == ConsoleKey.Q)
                    {
                        Beep(nota_1[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.W)
                    {
                        Beep(nota_2[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.E)
                    {
                        Beep(nota_3[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.R)
                    {
                        Beep(nota_4[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.T)
                    {
                        Beep(nota_5[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.Y)
                    {
                        Beep(nota_6[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.U)
                    {
                        Beep(nota_7[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.I)
                    {
                        Beep(nota_8[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.O)
                    {
                        Beep(nota_9[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.P)
                    {
                        Beep(nota_10[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.A)
                    {
                        Beep(nota_11[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.S)
                    {
                        Beep(nota_12[Octav]);
                    }
                    else if (Key.Key == ConsoleKey.RightArrow && Octav <= 2)
                    {
                        Octav++;
                    }
                    else if (Key.Key == ConsoleKey.LeftArrow && Octav!= 0)
                    {
                        Octav--;
                    }
                }

            }
        }
    }
}




