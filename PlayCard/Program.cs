using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Сколько игроков?");
            int cntplayer = int.Parse(Console.ReadLine());
            string[] suit = { "C", "D", "S", "H"  };
            int[] cardInt = new int[] { 6, 7, 8, 9, 10 };
            string[] cardString = new string[] { "J", "Q", "K", "A" };
            Game<int> game1 = new Game<int>();
            Game<string> game2 = new Game<string>();
            int cntCard = 1;
            game1.ShowCard(cardInt, suit, cntCard);
            game1.RandomizerCards(cardInt, suit, cntCard);
            cntCard = 21;
            game2.ShowCard(cardString, suit, cntCard);
            game2.RandomizerCards(cardString, suit, cntCard);
            Console.ReadLine();
            Console.Clear();
            Game<int>[] players = new Game<int>[cntplayer];
            Game<string>[] players1 = new Game<string>[cntplayer];
            for (int i = 0; i < cntplayer; i++)
            {
                Console.WriteLine($"{i + 1}-players cards = ");
                players[i].NumberCards[];
                players1[i].Razd(cntplayer, 7, cardString, suit);
            }
            
        }
    }
}
