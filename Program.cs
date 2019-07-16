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
        static int i2;
        static int p2;
        static int firstPlayerToWin;
        static int secondPlayerToWin;
        public static char[,] field;
        char Firstplaersumbol;

        static void Main(string[] args)
        {
            CreatePlayingField();
            Console.ReadKey(true);
        }
        static void CreatePlayingField()
        {
            Console.WriteLine("Привецтвую вас лUSERы");
            Console.ReadKey(true);
            Console.WriteLine("Выберите размер поля");
            a = b = UserInput();
            field = new char[a, b];
            while (true)
            {
                TwoPlayers();
                FieldCleaning(field);
                Console.WriteLine();
                CounterWins();
                Console.WriteLine();
                //PrintField(field);
            }
        }
        static int UserInput()
        {
            return int.Parse(Console.ReadLine());
        }        
        static void TwoPlayers()
        {

            while ( true)
            {                
                Console.WriteLine("ход 1 игрока");
                PrintField(field);
                PlayersStep(field,'X');               
                if (Win('X') == true)
                {
                    Console.WriteLine("Победа 1 игрока");
                    firstPlayerToWin++;
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
                }
                //Console.WriteLine("ход 2 игрока");
                //PrintField(field);
                //PlayersStep(field, 'O');
                //if (Win('O') == true)
                //{
                //    Console.WriteLine("Победа 2 игрока");
                //    secondPlayerToWin++;
                //    break;
                //}
            }
        }
        static void PlayersStep(char[,] field,char Firstplaersumbol)//Доработаю
        {
            Console.WriteLine("укажите столбик:");
            int move2 = UserInput()-1;
            Console.WriteLine("укажите ряд:");
            int move = UserInput()-1;
            field[move, move2] = Firstplaersumbol;
        }
        static void PrintField(char[,] field)//Доработаю
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
        static void FieldCleaning(char[,] field)//Доработаю
        {
            for (int t = 0; t < a; t++)
            {
                for (int y = 0; y < b; y++)
                {
                    Console.Write(field[t, y] = ' ');
                }
            }
        }
        static bool Win(char plaerSumbol)
        {

            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    i2 = i; p2 = p;
                    if (field[p, i - 2] == plaerSumbol && field[p, i - 1] == plaerSumbol && field[p, i] == plaerSumbol) { return true; }// 3 в ряд
                    i = i2; p = p2;
                    if (field[i - 2, p] == plaerSumbol && field[i - 1, p] == plaerSumbol && field[i, p] == plaerSumbol) {  return true; }// 3  по вертикали                   
                }           
                for (int p = 2; p < b; p++)
                {
                    i2 = i; p2 = p;
                    if (field[i - 2, p - 2] == plaerSumbol && field[i - 1, p - 1] == plaerSumbol && field[i, p] == plaerSumbol) { return true; }// 3  по диаганали
                    i = i2; p = p2;
                    if (field[p - 2, i] == plaerSumbol && field[p - 1, i - 1] == plaerSumbol && field[p, i - 2] == plaerSumbol) { return true; }
                }
            }
            return false;
        }
        static void CounterWins()
        {
            Console.WriteLine("Побед 1 игрока:" + firstPlayerToWin);
            Console.WriteLine("Побед 2 игрока:" + secondPlayerToWin);
        }
        //public static void Clear();
    }
}
