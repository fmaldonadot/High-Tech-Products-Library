using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Tech_Products_Library.bus
{
    class Software : Product 
    {
        private String capacity;        //Pos 10
        private EnumSoftType softype;   //Pos 11
                
        public string Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }

        public EnumSoftType Softype
        {
            get
            {
                return softype;
            }

            set
            {
                softype = value;
            }
        }

        public Software() { }
        public Software(string capacity , EnumSoftType softype)
        {
            this.capacity = capacity;
            this.softype = softype;
        }
        public Software(int item, string serialNumber, EnumProdType type,
                    string titname, string author, Double price, Date ed_pubDate, int stock , 
                    string capacity , EnumSoftType softype) :
            base(item, serialNumber, type, titname, author, price, 
                 ed_pubDate , stock)
        {
            this.capacity = capacity;
            this.softype = softype;
        }

        // This Constructor is used for FileFandler
        public Software(String item, String serialNumber, String type,
                    String titname, String author, String price, Date ed_pubDate, String stock ,
                    String capacity , String softype) :
            base(item, serialNumber, type, titname, author, price,
                    ed_pubDate , stock)
        {
            this.capacity = capacity;
            this.softype = (EnumSoftType)Enum.Parse(typeof(EnumSoftType), softype);
        }

        public override string ToString()
        {
            return base.ToString() + "|" + this.capacity + "|" + this.softype.ToString(); ;
        }

    }
}
