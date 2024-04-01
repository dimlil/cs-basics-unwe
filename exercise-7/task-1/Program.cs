using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Order
    {
        int orderID { get; set; }
        string Product { get; set; }
        double quantity { get; set; }
        double price { get; set; }
        string currency { get; set; }
        double price_bg { get; set; }

        void calc_price_bg()
        {
            double rate = 1;

            if (this.currency.Equals("EUR"))
                rate = 1.95;

            if (this.currency.Equals("USD"))
                rate = 1.89;

            this.price_bg = this.price * rate;
        }

        double calc_total_amount()
        {
            return price_bg * quantity;
        }

        static void Main(string[] args)
        {
            string answer = "";

            int order_count = 0;
            List<Order> orders = new List<Order>();
            List<Order> orders_deleted = new List<Order>();


            while (!answer.Equals("4"))
            {
                Console.WriteLine("Operation (1-add;2-list;3-delete;4-end):");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        {
                            Order o = new Order();

                            order_count++;
                            o.orderID = order_count;
                            Console.Write("Product:");
                            o.Product = Console.ReadLine();
                            Console.Write("Quantity:");
                            o.quantity = double.Parse(Console.ReadLine());

                            if (orders.Exists(s => s.Product == o.Product))
                            {
                                foreach (var row in orders.Where(w => w.Product == o.Product))
                                {
                                    row.quantity = row.quantity + o.quantity;
                                    Console.WriteLine("The quantity of product {0} is changed to {1}", row.Product, row.quantity);
                                    Console.WriteLine("Total amount {0:N2}", row.calc_total_amount());
                                }

                            }
                            else
                            {
                                Console.Write("Price:");
                                o.price = double.Parse(Console.ReadLine());
                                Console.Write("Currency:");
                                o.currency = Console.ReadLine();
                                o.calc_price_bg();
                                orders.Add(o);
                                Console.WriteLine("New order is added");
                                Console.WriteLine("Total amount {0:N2}", o.calc_total_amount());
                            }
                            break;
                        }
                    case "3":
                        {
                            int orderID;
                            Console.WriteLine("Delete order:");
                            orderID = int.Parse(Console.ReadLine());
                            orders_deleted.Add(orders.Where(c => c.orderID == orderID).FirstOrDefault());
                            orders.Remove(orders.Where(c => c.orderID == orderID).FirstOrDefault());
                            break;

                        }

                    case "2":
                        {
                            foreach (Order row in orders)
                            {
                                Console.WriteLine("OrderID {0}", row.orderID);
                                Console.WriteLine("Product {0}, Quantity {1}, Price {2}, Currency {3}, Price BGN {4} , Total Amount {5:N2}", row.Product, row.quantity, row.price, row.currency, row.price_bg, row.calc_total_amount());

                            }
                            break;
                        }
                    case "4":
                        {



                            double sum = 0;
                            foreach (Order row in orders)
                            {
                                sum = sum + row.price_bg * row.quantity;
                            }
                            Console.WriteLine("Number of orders: {0},Total amount of order: {1:N2}", orders.Count, sum);
                            Console.WriteLine("Deleted orders: {0}", orders_deleted.Count);
                            return;
                        }

                }

            }
        }
    }
}
