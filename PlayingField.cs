using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{    
    public class PlayingField
    {
        public static int i = 1;
        private bool?[,] field;
        public int firstPlayerToWin;
        public int secondPlayerToWin;
        public static int Width1 { get; set; }// ?
        public static int Height1 { get; set; }
        public PlayingField(int width, int height)
        {
            Width1 = width;
            Height1 = height;
            field = new bool?[width, height];
        }
        public void PrintField()
        {
            for (int t = 0; t < Width1; t++)
            {
                Console.Write(" |");
                for (int y = 0; y < Height1; y++)
                {
                    Console.Write(field[t, y] + "|");
                }
                Console.WriteLine();
            }
        }
        public bool CheckWin(char @true)
        {
            int pastMeaningI;
            int pastMeaningP;

            for (int i = 2; i < 4; i++)
            {
                for (int p = 0; p < 4; p++)
                {
                    pastMeaningI = i; pastMeaningP = p;
                    if (field[p, i - 2] == true && field[p, i - 1] == true && field[p, i] == true) { return true; }// 3 в ряд
                    i = pastMeaningI; p = pastMeaningP;
                    if (field[i - 2, p] == true && field[i - 1, p] == true && field[i, p] == true) { return true; }// 3  по вертикали                   
                }
                for (int p = 2; p < 4; p++)
                {
                    pastMeaningI = i; pastMeaningP = p;
                    if (field[i - 2, p - 2] == true && field[i - 1, p - 1] == true && field[i, p] == true) { return true; }// 3  по диаганали
                    i = pastMeaningI; p = pastMeaningP;
                    if (field[p - 2, i] == true && field[p - 1, i - 1] == true && field[p, i - 2] == true) { return true; }
                }
            }
            for (int i = 2; i < 4; i++)
            {
                for (int p = 0; p < 4; p++)
                {
                    pastMeaningI = i; pastMeaningP = p;
                    if (field[p, i - 2] == false && field[p, i - 1] == false && field[p, i] == false) { return true; }// 3 в ряд
                    i = pastMeaningI; p = pastMeaningP;
                    if (field[i - 2, p] == false && field[i - 1, p] == false && field[i, p] == false) { return true; }// 3  по вертикали                   
                }
                for (int p = 2; p < 4; p++)
                {
                    pastMeaningI = i; pastMeaningP = p;
                    if (field[i - 2, p - 2] == false && field[i - 1, p - 1] == false && field[i, p] == false) { return true; }// 3  по диаганали
                    i = pastMeaningI; p = pastMeaningP;
                    if (field[p - 2, i] == false && field[p - 1, i - 1] == false && field[p, i - 2] == false) { return true; }
                }
            }
            return false;
        }
        public void CounterWins()
        {
            Console.WriteLine(firstPlayerToWin + " / " + secondPlayerToWin);
        }
        public void TСoordinator(char playerSymbol,int x,int y)//Принимает числа через пробел и указывает кординату x
        {
            if (Play.Step==1) { field[x, y] = true; }
            else { field[x, y] = false; }
        }
       
    }
}
