using System;

namespace Poker
{
    public class Card
    {
        private string face;
        private string suit;
        public Card(string f, string s)
        {
            face = f;
            suit = s;
        }
        public void setFace(string f)
        {
            face = f;
        }
        public string getFace()
        {
            return face;
        }
        public void setSuit(string s)
        {
            suit = s;
        }
        public string getSuit() {
            return suit;
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
        public override string ToString()
        {
            return (this.getFace() + this.getSuit());
        }
        public bool suitsMatch(Card b)
        {
            if (this.getSuit() == b.getSuit()) {
                return true;
            } else {
                return false;
            }
        }
        public bool facesMatch(Card b)
        {
            if (this.getFace() == b.getFace()) {
                return true;
            } else {
                return false;
            }
        }
    }
}