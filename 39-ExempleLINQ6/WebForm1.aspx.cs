using System;
using System.Linq;
using System.IO;

namespace _39_ExempleLINQ6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ToQuery_Click(object sender, EventArgs e)
        {
            var query = from file in Directory.GetFiles(@"C:\Windows\System32")
                        select new
                        {
                            FileName = Path.GetFileName(file),
                            Extension = Path.GetExtension(file)
                        };
             
            GridView1.DataSource = query;
            GridView1.DataBind();

        }
    }
}