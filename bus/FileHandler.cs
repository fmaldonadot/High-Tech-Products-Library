using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace High_Tech_Products_Library.bus
{
    public class FileHandler
    {
        private String myfile = @"../../data/products.txt";
        private String myfolder = @"../../data";

        public String getMyfolder()
        {
            return myfolder;
        }
        public void setMyfolder(String myfolder)
        {
            this.myfolder = myfolder;
        }
        public String getMyfile()
        {
            return myfile;
        }
        public void setMyfile(String myfile)
        {
            this.myfile = myfile;
        }

        public FileHandler() { }
        public FileHandler(String myfile)
        {
            this.myfile = myfile;
        }

        public DataCollection readFile()
        {
            DataCollection list = new DataCollection();
            String str = null;
            StreamReader  myscan = null;
            String[] token = null;
            	
		    try
		    {
			    myscan = new StreamReader(this.myfile);

            }
		    catch
		    {
			    return null;
		    }
		
		    while( (str = myscan.ReadLine() ) != null )
		    {
			    token = str.Split('|');
                if (token[2].Contains("Book"))
			    {
				    Book prod = new Book(token[0], token[1], token[2], token[3],
                                            token[4], token[5],
                                            new Date ( token[6] , token[7] ,  token[8] ),
                                            token[9] , token[10] , token[11]);
                    list.add(prod);
			    }
			    else if (token[2].Contains("Software"))
			    {
                    Software prod = new Software( token[0], token[1], token[2], token[3],
                                                  token[4], token[5],
                                                  new Date( token[6] , token[7], token[8] ),
                                                  token[9] , token[10] , token[11]);
                        
                    list.add(prod);


                }
								
		    }
            myscan.Close(); ;
		    return list;
	    }


	    public void writeFile(DataCollection list)
        {
            using (StreamWriter txtstream = File.CreateText(this.myfile))
            {
                foreach (Product prod in list.ReturnList())
                {
                    txtstream.WriteLine(prod);
                }
            }                
            
	    }
		
    }
}
