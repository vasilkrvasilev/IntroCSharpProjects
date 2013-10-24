using System;

class Playcards
{
    enum Cards                                                             //Colection of all kind of cards
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    enum Colors                                                             //Colection of all colors of cards
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    static void CardColor(int currentCard, Cards card)                      //Print all colors of current kind of card
    {
        for (int currentColor = 0; currentColor < 4; currentColor++)
        {
            Colors color = (Colors)currentColor;
            switch (currentColor)
            {
                case 0:
                    Console.Write("{0,5} of {1},", card, color);
                    break;
                case 1:
                    Console.Write("{0,10} of {1},", card, color);
                    break;
                case 2:
                    Console.Write("{0,10} of {1},", card, color);
                    break;
                case 3:
                    Console.Write("{0,10} of {1}", card, color);
                    break;
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("\t\t\t\tThe Play Cards are:\n\r");
        for (int currentCard = 0; currentCard < 13; currentCard++)          //Print all colors of all kinds of cards
        {
            Cards card = (Cards)currentCard;
            switch (currentCard)
            {
                case 0:
                    CardColor(currentCard, card);
                    break;
                case 1:
                    CardColor(currentCard, card);
                    break;
                case 2:
                    CardColor(currentCard, card);
                    break;
                case 3:
                    CardColor(currentCard, card);
                    break;
                case 4:
                    CardColor(currentCard, card);
                    break;
                case 5:
                    CardColor(currentCard, card);
                    break;
                case 6:
                    CardColor(currentCard, card);
                    break;
                case 7:
                    CardColor(currentCard, card);
                    break;
                case 8:
                    CardColor(currentCard, card);
                    break;
                case 9:
                    CardColor(currentCard, card);
                    break;
                case 10:
                    CardColor(currentCard, card);
                    break;
                case 11:
                    CardColor(currentCard, card);
                    break;
                case 12:
                    CardColor(currentCard, card);
                    break;
            }
        }
    }
}