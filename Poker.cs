using System;

namespace Poker
{
    class Poker
    {
        public static void Main(String[] args)
        {
            Card a = new Card("4", "D");
            Card b = new Card("4", "C");
            Console.WriteLine(a.facesMatch(b));
            Card[] playerHand = createHand();
            for (int i = 0; i < playerHand.Length; i++) {
                Console.Write(playerHand[i].ToString() + " ");
            }
            Console.WriteLine();
            
        }
        public static Card[] createHand()
        {
            String[] faces = {"2","3","4","5","6","7","8","9","T","J","Q","K","A"};
            String[] suits = {"C","D","H","S"};
            Random r = new Random();
            Card[] hand = new Card[5];
            for (int i = 0; i < hand.Length; i++) {
                hand[i] = new Card(faces[r.Next(0,12)],suits[r.Next(0,3)]);
            }
            return hand;
        }
        
    }
}
