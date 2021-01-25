using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqX1
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               where r.ToUpper().Contains("I")
                               orderby s
                               select new { Suit = s, Rank = r, CountR= r.Length }
                               ;

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }
            Console.ReadKey();
        }

        static IEnumerable<string> Suits()
        {
            yield return "hearts";
            yield return "clubs";
            yield return "diamonds";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
