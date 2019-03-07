using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace nesne_odev
{
    class işlemler
    {
        public double işlemci(Stack<string> uw)
        {
            string al2 = uw.Pop();
            int say1=0, say2=0;
            if(!int.TryParse(al2, out say1))
            {
                say2++;
            }
            else { say1++; }
            


                double u, ı;
                if (!Double.TryParse(al2, out u))
                {


                    if (say1 != say2 + 1)
                    {
                        throw new IOException();
                    }
                    ı = işlemci(uw);
                    u = işlemci(uw);

                    if (al2 == "+") u += ı;
                    else if (al2 == "-") u -= ı;
                    else if (al2 == "*") u *= ı;
                    else if (al2 == "/")   u /= ı;  
                                                             // Başka girdi olursa hata yönlendirme(Double olmayan başka girdi varsa)
                }
            return u;
            /*  catch (DivideByZeroException e)
              {
                  Console.WriteLine("{0} Hatası----", e);
              }
              catch (IOException e)    // BURDA IO EXCEPTİON YAPTIM CUNKU CUSTOM EXCP. LA UGRASMAK İSTEMEDİM :D
              {
                  Console.WriteLine("Girilen sayı yada operatorlerde eksik  var");
              }*/
            
           
            
        }
        
    }
}
