using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCard
{
    public class Game<T> : Player<T>
    {
        public int CardsCount { get; set; }

        public void ShowCard(T[] cards, string[] suit, int crd)
        {
                cardsNumber = new T[cards.Length];
                suits = new string[suit.Length];

                deck = new int[suit.Length, cards.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    for (int j = 0; j < suit.Length; j++)
                    {
                        cardsNumber[i] = cards[i];
                        suits[j] = suit[j];
                        deck[j, i] = crd;
                        crd++;
                    }
                }
                for (int i = 0; i < cards.Length; i++)
                {
                    for (int j = 0; j < suit.Length; j++)
                    {
                        Console.WriteLine("{0} {1}  - {2}", cardsNumber[i], $"'{suits[j]}'", deck[j, i]);
                    }
                    Console.WriteLine();
                }
            }

        public void RandomizerCards(T[] cards, string[] suit, int crd)
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < suit.Length; j++)
                {
                    cardsNumber[i] = cards[i];
                    suits[j] = suit[j];
                    deck[j, i] = crd;
                    crd++;
                }
            }
            for (int i = 0; i < cards.Length; i++)
            {
                int rnd1 = rand.Next(0, suit.Length);
                int rnd2 = rand.Next(0, cards.Length);
                int temp = 0;

                Console.WriteLine();
                for (int j = 0; j < suit.Length; j++)
                {
                    temp = deck[j, i];
                    deck[j, i] = deck[rnd1, rnd2];
                    deck[rnd1, rnd2] = temp;
                    Console.WriteLine("{0} {1}  - {2}", cardsNumber[i], $"'{suits[j]}'", deck[j, i]);
                }
                Console.WriteLine();
            }
        }


        public void Razd(int player, int cntCard, T[] cards, string[] suit)
        {
            players = new int[player];
            CardsCount = cntCard;
            int cardsPlayers = CardsCount / player;
            int cnt = 1;
            for (int card = 1; card < cntCard; card++)
            {
                if (card % cardsPlayers == 0)
                {
                    cnt++;
                    Console.Write("--");
                }
                else
                {
                    Console.Write("--");
                }
                for (int i = 0; i < cards.Length; i++)
                {
                    for (int j = 0; j < suit.Length; j++)
                    {
                        if (deck[j, i] == card)
                            Console.Write("{0} {1}", cardsNumber[i], $"'{suits[j]}'");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }


        public T Return(int player, int cntCard, T[] cards, string[] suit)
        {
            int card = 1;
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < suit.Length; j++)
                {
                    if (deck[j, i] == card)
                        return cardsNumber[i];
                    card++;
                }
                Console.WriteLine();
            }
         return cardsNumber[0];       
        }


        //public void GamePlayer(int players)
        //{
        //    int cardsPlayers = CardsCount / players;
        //    int cnt = 1;
        //    Console.WriteLine($"{cnt} " + " player's cards = ");
        //    for (int card = 1; card <= 36; card++)
        //    {
        //        if (card % (cardsPlayers) == 0)
        //        {
        //            cnt++;
        //            Console.WriteLine("\n");
        //            Console.WriteLine($"{cnt} " + " player's cards = ");
        //            Console.WriteLine("\n");
        //        }
        //        else
        //        {
        //            Console.Write("--");
        //        }
        //        for (int i = 0; i < 4; i++)
        //        {

        //            for (int j = 0; j < 9; j++)
        //            {
        //                int max = 0;
        //                int preobraz = 1;
        //                int.TryParse(cardsNumber[j], out preobraz);

        //            }
        //        }
        //    }
        //}
    }
}
