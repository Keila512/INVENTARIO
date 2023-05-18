using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_INVENTARIO
{
    public class Product
    {

        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public DateTime? entry_date;

        public DateTime? Entry_date
        {
            get { return entry_date; }
            set { entry_date = value; }
        }

        public string purchase_price;

        public string Purchase_price
        {
            get { return purchase_price; }
            set { purchase_price = value; }
        }

        public double sale_price;

        public double Sale_price
        {
            get { return sale_price; }
            set { sale_price= value; }
        }
        
        public Product()
        {
            name = string.Empty;
            code = string.Empty;
            entry_date = null;
            purchase_price = string.Empty;
            sale_price = 0;
        }
        public Product(string name, string code, DateTime? entry_date, string purchase_price, double sale_price)
        {
            this.name = name;
            this.code = code;
            this.entry_date = entry_date;
            this.purchase_price = purchase_price;
            this.sale_price = sale_price;
        }      

    }
}
