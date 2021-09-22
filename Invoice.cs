using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace InvoiceMarket
{
    class Invoice
    {
        // A hardware store invoice for a client .

        // public variables :
        public string Partnumber { get; set; }
        public string descriptions { get; set; }

        // privates variable :
        private int ItemQuantity;
        private decimal pricePerItem;

        public Invoice(string partnumber, string descriptions, int itemQuantity, decimal pricePerItem)
        {
            Partnumber = partnumber;
            this.descriptions = descriptions;
            qty = ItemQuantity;
            Price = pricePerItem;

        }

        public int qty
        {
            get { return ItemQuantity; }
            set
            {
                if (value > 0)
                    ItemQuantity = value;
                else
                    ItemQuantity = 1;
            }
        }

        public decimal Price
        {
            get { return pricePerItem; }
            set
            {
                if (value > 0)
                    pricePerItem = value;
                else
                    pricePerItem = 1;
            }
        }

        public decimal GetInvoiceAmount()
        {
            return Price * qty;
        }
    }
}
