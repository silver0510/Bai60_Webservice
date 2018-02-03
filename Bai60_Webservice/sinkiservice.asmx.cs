using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Bai60_Webservice
{
    /// <summary>
    /// Summary description for sinkiservice
    /// </summary>
    [WebService(Namespace = "http://sinki.com.vn/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class sinkiservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<String>GetDanhSach()
        {
            List<String> ds = new List<string>();
            ds.Add("Topica");
            ds.Add("Edumall");
            ds.Add("Native");
            return ds;
        }
        [WebMethod]
        public String GiaiPhuongTrinhBac1(int a,int b)
        {
            if (a == 0 && b == 0)
                return "Vô số nghiệm";
            if (a == 0 && b != 0)
                return "Vô nghiệm";
            return "x=" + (-b * 1.0 / a);
        }
        
        [WebMethod]
        public Contact GetDetail(int ma)
        {
            return new Contact() { Ma = ma, Ten = "Sinki Boss", Phone = "0905236498" };
        }
        [WebMethod]
        public List<Contact> Lay5Contact()
        {
            List<Contact> dsContact = new List<Contact>();
            dsContact.Add(new Contact { Ma = 1, Ten = "An", Phone = "0905456852" });
            dsContact.Add(new Contact { Ma = 2, Ten = "Bình", Phone = "0905536852" });
            dsContact.Add(new Contact { Ma = 3, Ten = "Tâm", Phone = "0996356852" });
            dsContact.Add(new Contact { Ma = 4, Ten = "Long", Phone = "0905458402" });
            dsContact.Add(new Contact { Ma = 5, Ten = "Trí", Phone = "023694852" });
            return dsContact;
        }
    }
}
