using System;

namespace InvoiceMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string num, des;
            int qty;
            decimal prc;

            Console.WriteLine("please sir enter a part of number \n");
            num = Console.ReadLine();

            Console.WriteLine("please sir enter the item description \n");
            des = Console.ReadLine();

            Console.WriteLine("please enter the quantity \n");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the price \n");
            prc = Convert.ToDecimal(Console.ReadLine());

            Invoice invoice = new Invoice(num, des, qty, prc);

            Console.Write("Your order : \n");
            Console.Write("Part Number : {0}\n", invoice.Partnumber);
            Console.Write("Part description : {0}\n", invoice.descriptions);
            Console.Write("Your quantity : {0}\n", invoice.qty);
            Console.Write("Your price : {0}\n", invoice.Price);

            Console.Write("Your total is : {0} $\n", invoice.GetInvoiceAmount());
        }
    }
}
