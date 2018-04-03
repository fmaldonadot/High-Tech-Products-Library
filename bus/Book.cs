using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Tech_Products_Library.bus
{
    class Book : Product
    {
        private int numPages;                                   //Pos 10
        private EnumBookGenre genre = EnumBookGenre.Undefined;  //Pos 11

        public int NumPages
        {
            get
            {
                return numPages;
            }

            set
            {
                numPages = value;
            }
        }
        public EnumBookGenre Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public Book() { }
        public Book(int numPages, EnumBookGenre genre)
        {
            this.numPages = numPages;
            this.genre = genre;
        }

        public Book(int item, string serialNumber, EnumProdType type, 
                    string titname, string author, Double price, Date ed_pubDate , 
                    int stock , 
                    int numPages, EnumBookGenre genre):
                base(item, serialNumber, type, titname, author, price, 
                    ed_pubDate , stock)
        {
            this.numPages = numPages;
            this.genre = genre;
        }

        // This Constructor is used for FileFandler
        public Book(String item, String serialNumber, String type,
                    String titname, String author, String price, Date ed_pubDate, String stock ,
                    String numPages, String genre) :
            base(item, serialNumber, type, titname, author, price,
                    ed_pubDate , stock)
        {
            this.numPages = Convert.ToInt16(numPages);
            this.genre = (EnumBookGenre)Enum.Parse(typeof(EnumBookGenre), genre);
        }

        public override string ToString()
        {
            return base.ToString() + "|" + this.numPages + "|" + this.genre.ToString();
        }

    }
}
