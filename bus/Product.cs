using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Tech_Products_Library.bus
{
    abstract public class Product
    {
        private int item = SequenceID.getProd_id();            //Pos 0
        private String serialNumber;                           //Pos 1
        private EnumProdType type = EnumProdType.Undefined;    //Pos 2
        private String titname;                                //Pos 3
        private String author;                                 //Pos 4
        private Double price;                                  //Pos 5
        private Date ed_pubDate;                               //Pos 6 - 7 - 8
        private int stock;                                     //Pos 9
        
        public int Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }

            set
            {
                serialNumber = value;
            }
        }
        public EnumProdType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        public string Titname
        {
            get
            {
                return titname;
            }

            set
            {
                titname = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }
        public Double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public Date Ed_pubDate
        {
            get
            {
                return ed_pubDate;
            }

            set
            {
                ed_pubDate = value;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public Product() { }
        public Product(int item, string serialNumber, EnumProdType type, 
                       string titname, string author, Double price, Date ed_pubDate,
                       int stock)
        {
            this.item = item;
            this.serialNumber = serialNumber;
            this.type = type;
            this.titname = titname;
            this.author = author;
            this.price = price;
            this.ed_pubDate = ed_pubDate;
            this.stock = stock;
        }
        // This Constructor is used for FileFandler
        public Product(String item, String serialNumber, String type,
                       String titname, String author, String price, Date ed_pubDate,
                       String stock)
        {
            this.item = Convert.ToInt16(item);
            this.serialNumber = serialNumber;
            this.type = (EnumProdType)Enum.Parse(typeof(EnumProdType), type);
            this.titname = titname;
            this.author = author;
            this.price = Convert.ToDouble(price);
            this.ed_pubDate = ed_pubDate;
            this.stock = Convert.ToInt16(stock);
        }

        public override string ToString()
        {
            return this.item.ToString() + "|" + this.serialNumber + "|" +
                this.type.ToString() + "|" + this.titname + "|" + 
                this.author + "|" + this.price.ToString("##.##") + "|" +
                this.ed_pubDate.ToString() + "|" + this.stock.ToString();

        }
    }
}
