using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace nesne_odev
{
    class Stacksnf
    {
        public void sınıfcocuk()
            {
            Console.WriteLine("buraya geldi1");
            

         
            char[] icerik = new char[] { ' ','\t' };
            int sonsuz = 1;
            while(sonsuz==1)
              {
                Console.WriteLine("DEGERLERİ GİRİNİZ");
                string al = Console.ReadLine();
                if (al == null) break;
                Stack<string> uw = new Stack<string>
                    (al.Split(icerik, StringSplitOptions.RemoveEmptyEntries));
                if (uw.Count == 0)
                {
                    continue;
                    // throw new FormatException();
                }

                try
                {
                    
                    işlemler cagır = new işlemler();
                    
                    double yzdr = cagır.işlemci(uw);
                    if(uw.Count != 0) throw new Exception();

                    Console.WriteLine(yzdr);
                   


                }  
                catch(Exception e )
                {
                    Console.WriteLine("Hatalı giriş");
               



                }

                



            }
            
            



            }
    }
}
