using IO = System.Console;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketChild;
            double ticketAdult;
            double ticketSenior;

            double smallSoda = 3.50;
            double largeSoda = 5.99;
            double hotDog = 3.99;
            double popCorn = 4.50;
            double candy = 1.99;

            string option = "0";
            while (option != "1" && option != "2")
            {
                listoption();
                Userinput();
                option = IO.ReadLine();
            }

            if (option == "1")
            {
                ticketChild = 3.99;
                ticketAdult = 5.99;
                ticketSenior = 4.50;
            }

            else
            {
                ticketChild = 6.99;
                ticketAdult = 10.99;
                ticketSenior = 8.50;
            }

            IO.Write("     * How many Children?    ");
            int numChild = int.Parse((IO.ReadLine()));
            IO.Write("     * How many Adults?      ");
            int numAdult = int.Parse(IO.ReadLine());
            IO.Write("     * How many Seniors?     ");
            int numSenior = int.Parse(IO.ReadLine());

            IO.Write("     * How many Small Soda?  ");
            int numSmallSoda = int.Parse(IO.ReadLine());
            IO.Write("     * How many Large Soda?  ");
            int numLargeSoda = int.Parse(IO.ReadLine());
            IO.Write("     * How many Hot Dogs?    ");
            int numHotDog = int.Parse(IO.ReadLine());
            IO.Write("     * How many Pop Corns?   ");
            int numPopCorn = int.Parse(IO.ReadLine());
            IO.Write("     * How many Candies?     ");
            int numCandy = int.Parse(IO.ReadLine());

            double totalPrice = 0;
            double totalTicket = 0;
            totalTicket = totalTicket + (numChild * ticketChild);
            totalTicket = totalTicket + (numAdult * ticketAdult);
            totalTicket = totalTicket + (numSenior * ticketSenior);

            totalPrice = totalPrice + (numSmallSoda * smallSoda);
            totalPrice = totalPrice + (numLargeSoda * largeSoda);
            totalPrice = totalPrice + (numHotDog * hotDog);
            totalPrice = totalPrice + (numPopCorn * popCorn);
            totalPrice = totalPrice + (numCandy * candy);

            int ticketDiscount = 0;
            if (numPopCorn >= 1 && numLargeSoda >= 1)
            {
                if (numPopCorn <= numLargeSoda)
                {
                    ticketDiscount = numPopCorn * 2;
                }
                else
                {
                    ticketDiscount = numLargeSoda * 2;
                }




                IO.WriteLine("     today You got " + ticketDiscount + " dollar discount on your tickets");
            }

            totalTicket = totalTicket - ticketDiscount;
            totalPrice = totalPrice + totalTicket;

            int totalPeople = numChild + numAdult + numSenior;
            if (option == "2" && totalPeople >= 3)
            {
                IO.WriteLine("         with your puchase you got 1 free bag of popcorn");
            }

            if (numCandy >= 3)
            {
                int freeCandy = (int)(numCandy / 3);
                if (freeCandy == 1)
                {
                    IO.WriteLine("     with your purchase you got " + freeCandy + " free candy");
                }
                else {
                    IO.WriteLine("     with your puchase you got " + freeCandy + " free candies");
                }
            }
            IO.WriteLine();
            IO.WriteLine();
            IO.WriteLine("     Total Tickets Price = " + totalTicket);
            IO.WriteLine("     Gran Total          = " + totalPrice);
            IO.ReadKey();






            void listoption()
            {

                IO.Clear();
                IO.WriteLine();
                IO.WriteLine(" ======================================================= ");
                IO.WriteLine("        What time do you want to watch the movie ?       ");
                IO.WriteLine(" ======================================================= ");
                IO.WriteLine();
                IO.WriteLine("                  (1) - Matinee                          ");
                IO.WriteLine("                  (2) - Evening                          ");
                IO.WriteLine();
                IO.WriteLine(" ======================================================= ");
            }





            void Userinput()
            {
                IO.WriteLine();
                IO.Write("              ---> ");
            }

        }
    }
    
}
