using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TicTacToe
{
    class Program
    {
        static int a;
        static int b;
        static int i;
        public static char[,] field;
        static void Main(string[] args)
        {
            Createplayingfield();
            Console.ReadKey(true);
        }
        static void Createplayingfield()
        {
            Console.WriteLine("Привецтвую вас лUSERы");
            Console.ReadKey(true);
            Console.WriteLine("Выберите размер поля");
            a = b = Parse();
            field = new char[a, b];
            for (int t = 0; t < a; t++)
            {
                Console.Write(" |");

                for (int y = 0; y < b; y++)
                {
                    Console.Write(field[t, y] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("1 или 2 игрока?");
            int Player = Parse();
            if (Player == 1)
            {
                Oneplayer();
            }
            else { Twoplayers(); }
        }
        static int Parse() {
            return int.Parse(Console.ReadLine());
            
        }
        static void Oneplayer()
        {

        }
        static void Twoplayers()
        {
          
            while (Win() ==true || Win2() == true)
            {
                Move1(field);
                if (Win() == false || Win2() == false)
                {
                    break;
                }
                Move2(field);
                if (Win() == false || Win2() == false)
                {
                    break;
                }
            }
        }
        static void Move1(char[,] field)//Доработаю
        {
            Console.WriteLine("ход 1 игрока");
            Console.WriteLine("укажите столбик:");
            int move2 = Parse()-1;

            Console.WriteLine("укажите ряд:");
            int move = Parse()-1;

            field[move, move2] = 'X';
            Move(field);
        }
        static void Move(char[,] field)//Доработаю
        {                        
            for (int t = 0; t < a; t++)
            {
                Console.Write(" |");

                for (int y = 0; y < b; y++)
                {
                    Console.Write(field[t, y] + "|");
                }
                Console.WriteLine();
            }
        }

        static void Move2(char[,] field)//Доработаю
        {
            Console.WriteLine("ход 2 игрока");
            Console.WriteLine("укажите столбик:");
            int move2 = Parse() - 1;
            Console.WriteLine("укажите ряд:");
            int move = Parse() - 1;

            field[move, move2] = 'O';
            Move(field);
        }
        static bool Win()
        {

            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[p, i - 2] == 'X' && field[p, i - 1] == 'X' && field[p, i] == 'X') { Console.WriteLine("Победа 1 игрока"); return false; }// 3 в ряд
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[i - 2, p] == 'X' && field[i - 1, p] == 'X' && field[i, p] == 'X') { Console.WriteLine("Победа 1 игрока"); return false; }// 3  по вертикали
                }
            }

            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[i - 2, p - 2] == 'X' && field[i - 1, p - 1] == 'X' && field[i, p] == 'X') { Console.WriteLine("Победа 1 игрока"); return false; }// 3  по диаганали
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[p - 2, i] == 'X' && field[p - 1, i - 1] == 'X' && field[p, i - 2] == 'X') { Console.WriteLine("Победа 1 игрока"); return false; }
                }
            }
            return true;
        }
        static bool Win2()
        {

            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[p, i - 2] == 'O' && field[p, i - 1] == 'O' && field[p, i] == 'O') { Console.WriteLine("Победа 2 игрока"); return false; }// 3 в ряд
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[i - 2, p] == 'O' && field[i - 1, p] == 'O' && field[i, p] == 'O') { Console.WriteLine("Победа 2 игрока"); return false; }// 3  по вертикали
                }
            }

            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[i - 2, p - 2] == 'O' && field[i - 1, p - 1] == 'O' && field[i, p] == 'O') { Console.WriteLine("Победа 2 игрока"); return false; }// 3  по диаганали
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[p - 2, i] == 'O' && field[p - 1, i - 1] == 'O' && field[p, i - 2] == 'O') { Console.WriteLine("Победа 2 игрока"); return false; }
                }
            }
            return true;
        }
    }
}
