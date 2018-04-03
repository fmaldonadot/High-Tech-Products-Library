using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace High_Tech_Products_Library.bus
{
    public class DataCollection
    {
        private List<Product> prodList;

        public List<Product> getProdList()
        {
            return prodList;
        }
        public void setEmpList(List<Product> prodList)
        {
            this.prodList = prodList;
        }

        public DataCollection()
        {
            this.prodList = new List<Product>();
        }
        public DataCollection(Product prod)
        {
            this.prodList.Add(prod);
        }

        //****************** Methods *********************
        // For use of Comparator
        public List<Product> ReturnList()
        {
            return this.prodList;
        }
        // Add Methods
        public void add(Product prod)
        {
            this.prodList.Add(prod);
        }

        //Remove Methods
        public void remove(Product prod) //Current element
        {
            this.prodList.Remove(prod);
        }

        public int remove(String sn) //By Serial Number
        {
            foreach (Product curr in this.prodList)
            {
                if (curr.SerialNumber == sn)
                {
                    this.prodList.Remove(curr);
                    return this.prodList.Capacity;
                }
            }

            return -1;

        }

        public int remove(int id) //By Item
        {
            foreach (Product curr in this.prodList)
            {
                if (curr.Item == id)
                {
                    this.prodList.Remove(curr);
                    return this.prodList.Capacity;
                }
            }

            return -1;

        }

        // Search Methods
        // Search by Serial Number	
        public Product search(String sn)
        {

            foreach (Product curr in prodList)
            {
                if (curr.SerialNumber == sn)
                    return curr;
            }
            return null;
        }

        // Search by Item	
        public Product search(int item)
        {

            foreach (Product curr in prodList)
            {
                if (curr.Item == item)
                    return curr;
            }
            return null;
        }
            
        // Modify List
        public void modify(Product emp, String sn)
        {
            int index = this.getIndex(sn);

            this.prodList[index]= emp;
        }

        // Get index
        public int getIndex(String sn)
        {
            int index = 0;

            foreach (Product emp in this.prodList)
            {
                if (emp.SerialNumber == sn )
                    return index;
                index++;
            }
            return -1;
        }
        // Get Size of list
        public int getSize()
        {
            return prodList.Capacity;
        }

        // Check Unique Serial Number
        public bool isUnique(String sn)
        {
            if (this.search(sn) == null)
                return true;
            else
                return false;
        }

        // Only to show in a listbox
        public String ShowListInBox(Product prod)
        {
            string[] columns;
            string strshow = "";

            strshow = "";
            columns = prod.ToString().Split('|');

            for (int i = 0; i < columns.Length; i++)
            {
                strshow += columns[i] + "\t";
            }
            return strshow;
        }

        // ToString
        public String toString()
        {
            String state = "";

            foreach (Product curr in prodList)
            {
                state += curr + "\n";
            }

            return state;
        }

    }
}
