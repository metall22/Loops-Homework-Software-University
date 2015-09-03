using System;
class PrintCardDeck
{
    static void Main()
    {
        for (int cardNum = 0; cardNum < 13; cardNum++)
        {

            for (int sign = 0; sign < 4; sign++)
            {
                switch (cardNum)
                {
                    case 0: Console.Write("{0, 2}", 2);
                        break;
                    case 1: Console.Write("{0, 2}", 3);
                        break;
                    case 2: Console.Write("{0, 2}", 4);
                        break;
                    case 3: Console.Write("{0, 2}", 5);
                        break;
                    case 4: Console.Write("{0, 2}", 6);
                        break;
                    case 5: Console.Write("{0, 2}", 7);
                        break;
                    case 6: Console.Write("{0, 2}", 8);
                        break;
                    case 7: Console.Write("{0, 2}", 9);
                        break;
                    case 8: Console.Write("{0, 2}", 10);
                        break;
                    case 9: Console.Write("{0, 2}", "J");
                        break;
                    case 10: Console.Write("{0, 2}", "Q");
                        break;
                    case 11: Console.Write("{0, 2}", "K");
                        break;
                    case 12: Console.Write("{0,2}", "A");
                        break;
                }
                switch (sign)
                {
                    case 0: Console.Write("\u2663 ");
                        break;
                    case 1: Console.Write("\u2666 ");
                        break;
                    case 2: Console.Write("\u2665 ");
                        break;
                    case 3: Console.WriteLine("\u2660 ");
                        break;
                }
            }
        }
    }
}