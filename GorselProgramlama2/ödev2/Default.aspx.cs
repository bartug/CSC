using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Net;

namespace ödev2  //Berke Bartuğ Sevindik 2015280028
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* referanslarım :https://www.youtube.com/watch?v=qU72WThLu80
             * http://www.omercebi.com/IcerikDetay-ip-ile-ulke-ve-sehiri-bulmak-73.aspx
             * boostrap kullandım göze daha güzel gözüksün diye ,detaylandırmadım.
             * http://geoiplookup.net/xml-api/ buradan netten xml ile çekmeyi gördüm.
            */

        }

        protected void SorguButton_Click(object sender, EventArgs e)
        {
           string girdi,okunan;
           
            if(TextBox1.Text == "")
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script> alert('Lütfen Bir İP adresi giriniz.');</script>"); //ip girilmezse hata verdirttim.

            }
            else {  //girdi varsa

                XmlDocument doc = new XmlDocument();
                girdi = TextBox1.Text;    //ip adresi textboxta girilen değeri girdiye eşitledim. 

                string IP = "http://www.freegeoip.net/xml/" + girdi;      //internetteki xml dosyasından iplerden baktım.
                doc.Load(IP);
                XmlNodeList nodeLstCity = doc.GetElementsByTagName("CountryName");   //sadece ülke ismini aldım. Çünkü şehir vs de veriyordu.
                okunan = nodeLstCity[0].InnerText;  //bize verilecek çıktıyı labelin textine yazdırdım.
                UlkeYazdir.Text = okunan;
                
 
            }

            ListBox1.Items.Add(UlkeYazdir.Text );  //daha once aranan ip adreslerinden çıkan sonucları yazdırır. 
            //böylece en çok arastırılan ülkeler gözlenilebilir.
            


        }

       
    }
}