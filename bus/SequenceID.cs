using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Tech_Products_Library.bus
{
    public class SequenceID
    {
        private static int prod_id = 1;

        public static int getProd_id()
        {
            return SequenceID.prod_id++;
        }
        public static void setProd_id(int prod_id)
        {
            SequenceID.prod_id = prod_id;
        }
    }
}
