using System;
using System.Threading;

namespace Project2
{
    public delegate void Price_Cut_Event(Int32 pr);
    
    class Park
    {
        static Random rand_num = new Random(); //Random for Park Wait
        public static Thread park_thread; //Create a park thread
        private static Int32 ticket_price = 190; //Start ticket price at (max + min) / 2
        private static Int32 counter = 0; //Tracks n price cuts that have occurred
        public static event Price_Cut_Event price_cut;
        Multi_Cell_Buffer buffer; //Create buffer to hold items

        public void Run_Park() //Runs the regular Park functionality
        {
            buffer = new Multi_Cell_Buffer(); //Create the Park order buffer

            while (counter < 20) //Run until 20 price cuts have occurred
            {
                Thread.Sleep(rand_num.Next(300,500)); //Wait

                Int32 price = Pricing_Model();
                Park.Price_Updated(price);
                Order order = buffer.Get_One_Cell(); //Collects an order from the buffer

                if (order != null) //If an order exists
                {
                    Order_Processing order_process = new Order_Processing(order);
                    Thread order_processing = new Thread(new ThreadStart(order_process.Create_Order));
                    order_processing.Start();
                    order_processing.Join();
                }
            }
            //Shut down the Park functionality
            Console.WriteLine("PARK THREAD ENDING");
            Console.WriteLine(counter + " Price cuts have occurred");
        }

        public Int32 Pricing_Model() //Returns a new price when the thread is run
        {
            return rand_num.Next(80, 300);
        }

        public Int32 Get_Price() //Returns the current price
        {
            return ticket_price;
        }

        public static void Price_Updated(Int32 p) //Updates the price from the Pricing Model
        {
            if (p < ticket_price) //If Price is lowered
            {
                if (price_cut != null) //Price Cut has occurred
                {
                    Park.ticket_price = p;
                    Console.WriteLine("\nThe new ticket price after the price cut is: $" + ticket_price);
                    price_cut(p);
                    counter++; //Udpate counter on price cut
                }
            }
            else //If price is higher
            {
                Park.ticket_price = p;
                Console.WriteLine("The new ticket price is: $" + ticket_price);
            }
        }
    }

    public class Order_Processing
    {
        //Ticket Costs
        Int32 unit_price, num_of_tickets, tax_rate, location_charge;
        //Card Handlers
        Int32 card_number;
        Int32 card_max = 9000;
        Int32 card_min = 3000;
        //Sender & Receiver ID
        string sender_ID;
        string receiver_ID;

        public Order_Processing(Order order) //Constructor for Order
        {
            this.unit_price = order.Get_Unit_Price();
            this.num_of_tickets = order.Get_Num_Tickets();
            this.tax_rate = 6;
            this.location_charge = 5;
            this.card_number = order.Get_Card_Number();
            this.sender_ID = order.Get_Sender_ID();
            this.receiver_ID = order.Get_Receiver_ID();
        }

        public void Create_Order() //Checks if Order can be processed
        {
            //Determine the Charge
            Int32 taxable_amount = unit_price * num_of_tickets;
            Int32 totalPrice = taxable_amount + ((taxable_amount * tax_rate) / 100) + location_charge;

            //Validate the Card
            Boolean isCardVerified = Verify_Card(card_number);

            //Order Fulfillment
            if (isCardVerified)
            {
                Console.WriteLine("\n");
                Console.WriteLine("-----------ORDER PLACED-----------");
                Console.WriteLine("SENDER ID: " + sender_ID);
                Console.WriteLine("RECEIVER ID: " + receiver_ID);
                Console.WriteLine("NO. OF TICKETS: " + num_of_tickets);
                Console.WriteLine("TICKET PRICE: $" + unit_price);
                Console.WriteLine("TOTAL PRICE: $" + totalPrice);
                Console.WriteLine("CARD CHARGED: " + card_number);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("\n");
            }
            else //Bad Card
            {
                Console.WriteLine("\nThe order cannot be placed due to an invalid card number\n");
            }
        }

        private Boolean Verify_Card(Int32 cardnumber) //Validates card on order with card in processing
        {
            if (cardnumber <= card_max && cardnumber >= card_min) //Check if card is valid
            {
                return true;
            }
            return false;
        }
    }

    public class Ticket_Agency
    {
        static Random rand_num = new Random();
        Multi_Cell_Buffer buffer;
        string thread_name;

        public void Run_Agency() //Runs Ticket Threads while Park Thread is Running
        {
            Park park = new Park();
            while (Park.park_thread.IsAlive) //Park is Running
            {
                thread_name = Thread.CurrentThread.Name;
                Thread.Sleep(rand_num.Next(500,2000)); //Wait until called
                Int32 p = park.Get_Price();
            }
        }

        public void Tickets_On_Sale(Int32 price) //Event Handler for Ticket Thread
        {
            Console.WriteLine(thread_name + " has tickets that are on sale");
            Console.WriteLine("The new price is: $" + price);

            Int32 unit_price = price;
            Int32 need = rand_num.Next(2, 10);
            Int32 card_num = rand_num.Next(1000, 9999);
            string sender_ID = thread_name;
            string receiver_ID = "Park Thread";

            Int32 standard_order = 400;
            Int32 current_order = unit_price * need;
            Boolean place_order = ((current_order > standard_order) || (need > 3));

            if (place_order) //Check if order can be placed
            {
                Order order = new Order();
                order.Set_Unit_Price(unit_price);
                order.Set_Num_Tickets(need);
                order.Set_Card_Number(card_num);
                order.Set_Sender_ID(sender_ID);
                order.Set_Receiver_ID(receiver_ID);
                buffer = new Multi_Cell_Buffer();
                buffer.Set_One_Cell(order);
            }
            else //Order did not meet demand
            {
                Console.WriteLine("\n" + thread_name + " did not place order");
                Console.WriteLine("Not enough demand (only " + need + " tickets needed)\n");
            }
        }
    }

    public class Order //All relevant information for the Order
    {
        //Private order variables
        private string sender_ID;
        private string receiver_ID;
        private Int32 unit_price;
        private Int32 amount;
        private Int32 card_number;

        public string Get_Receiver_ID() //Returns the Receiver's ID
        {
            return this.receiver_ID;
        }
        public void Set_Receiver_ID(string value) //Sets the Receiver's ID
        {
            this.receiver_ID = value;
        }
        public string Get_Sender_ID() //Returns the Sender's ID
        {
            return this.sender_ID;
        }
        public void Set_Sender_ID(string value) //Sets the Sender's ID
        {
            this.sender_ID = value;
        }
        public Int32 Get_Unit_Price() //Returns the Unit Price
        {
            return this.unit_price;
        }
        public void Set_Unit_Price(Int32 value) //Sets the Unit Price
        {
            this.unit_price = value;
        }
        public Int32 Get_Num_Tickets() //Gets the Number of Tickets
        {
            return this.amount;
        }
        public void Set_Num_Tickets(Int32 value) //Sets the Number of Tickets
        {
            this.amount = value;
        }
        public Int32 Get_Card_Number() //Gets the Card Number
        {
            return this.card_number;
        }
        public void Set_Card_Number(Int32 value) //Sets the Card Number
        {
            this.card_number = value;
        }
    }

    public class Multi_Cell_Buffer //Handles the potential sales for the Park and Ticket Agencies
    {
        private static Int32 num_of_cells = 2;
        public static Semaphore read_semaphore = new Semaphore(0, num_of_cells);
        public static Semaphore write_semaphore = new Semaphore(num_of_cells, num_of_cells);
        static internal Order[] order_buffer = {null, null }; //Initial buffer state is empty

        public Order Get_One_Cell() //Returns the content of a cell
        {
            Order result = null;
            Boolean readable, read;
            readable = read = false;

            //Locks the Buffer to other Parks
            Monitor.Enter(order_buffer);
            while (!readable)
            {
                read_semaphore.WaitOne(5000);
                for (int i = 0; i < num_of_cells; i++)
                {
                    if (order_buffer[i] != null) //Check reading from cells (1 to num_of_cells)
                    {
                        readable = true;

                        result = order_buffer[i];
                        order_buffer[i] = null;

                        read = true;
                        break; //End For Loop
                    }
                    else if ((i + 1) == num_of_cells && order_buffer[i] == null) //None of the cells can be read from
                    {
                        readable = true; //End While Loop
                    }
                }
            }

            readable = false;
            if (read) //Open other semaphore for Ticket Agencies
                write_semaphore.Release();

            //Unlocks the Buffer to other Parks
            Monitor.Exit(order_buffer);
            return result;
        }

        public void Set_One_Cell(Order order) //Writes an order into an open cell
        {
            Boolean writable, wrote;
            writable = wrote = false;

            //Lock the Buffer to other Threads
            Monitor.Enter(order_buffer);
            while (!writable)
            {
                write_semaphore.WaitOne(5000);
                for (int i = 0; i < num_of_cells; i++)
                {
                    if (order_buffer[i] == null) //Check to write into cells (1 to num_of_cells)
                    {
                        writable = true;

                        order_buffer[i] = order;

                        wrote = true;
                        break; //End For Loop
                    }
                    else if ((i + 1) == num_of_cells && order_buffer[i] != null) //None of the cells can be written
                    {
                        writable = true; //End While Loop
                    }
                }
            }
            writable = false;
            if (wrote) //Open other semaphore for Park
            {
                read_semaphore.Release();
            }

            //Unlock the Buffer for other Threads
            Monitor.Exit(order_buffer);
        }
    }

    class Program //Drives the Program
    {
        static void Main(string[] args) //Main Thread
        {
            Int32 num_of_threads = 5;
            Console.WriteLine("Welcome to the Park Ticket Simulator!");
            Console.WriteLine("This program will run until 20 price cuts occur");

            //Create the Park and start its thread
            Park park = new Park();
            Park.park_thread = new Thread(new ThreadStart(park.Run_Park));
            Park.park_thread.Name = "Park Thread";
            Park.park_thread.Start();

            //Create the Ticket Agency threads
            Ticket_Agency t_a = new Ticket_Agency();
            Park.price_cut += new Price_Cut_Event(t_a.Tickets_On_Sale);
            Thread[] ticket_agencies = new Thread[num_of_threads];
            for (int i = 0; i < num_of_threads; i++)
            {
                ticket_agencies[i] = new Thread(new ThreadStart(t_a.Run_Agency));
                ticket_agencies[i].Name = "Ticket Agency " + (i + 1).ToString();
                ticket_agencies[i].Start();
            }
        }
    }
}
//          TO-DO
//-----------------------------
//Nothing I think

//       Done Classes
//-----------------------------
//1. Park
//2. Pricing Model
//3. Order Processing
//5. Order() Class
//6. Multi Cell Buffer
//8. Main