using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Register
    {
        public void CheckIn()
        {
            Start start = new Start();
            Console.WriteLine("Имя первого игрока:");
            Players Player1 = new Players(Console.ReadLine(), 0); /*(Console.ReadLine());*/
            Console.WriteLine("Имя второго игрока:");
            Players Player2 = new Players(Console.ReadLine(), 0);
            //FileStream file1 = new FileStream("E:\\Name\\" + Name + ".txt", FileMode.OpenOrCreate); //создаем файловый поток
            //StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
            //writer.Write(width /*fieldSize*/); //записываем в файл
            //writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
            Console.WriteLine("Для возвращения в меню нажмите любую клавишу..");
            Console.ReadKey(true);
            Console.Clear();
            start.InitialScreen();
        }
        public void Options()
        {
            Play play = new Play();
            Start start = new Start();
            Console.WriteLine("Выберите размер поля");
            PlayingField.Width1 = PlayingField.Height1 = Helper.UserInput()[0];
            Console.WriteLine("Для возвращения в меню нажмите любую клавишу...");
            Console.ReadKey(true);
            Console.Clear();
            start.InitialScreen();
        }
    }
}
