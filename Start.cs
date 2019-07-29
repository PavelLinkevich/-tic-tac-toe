using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Start
    {
        char Firstplaersumbol;
        public void InitialScreen()
        {
            Play play = new Play();
            Register register = new Register();
            //Start start = new Start();
            Console.WriteLine("Привецтвую вас лUSERы");
            Console.ReadKey(true);
            int initialСhoice;
            Console.WriteLine("1)Играть");
            Console.WriteLine("2)Войти");
            Console.WriteLine("3)Настройки");
            initialСhoice = Helper.UserInput()[0];
            switch (initialСhoice)
            {
                case 1:
                    play.NewGame();
                    break;
                case 2:
                    register.CheckIn();
                    break;
                case 3:
                    register.Options();
                    break;
            }
        }
    }
}
