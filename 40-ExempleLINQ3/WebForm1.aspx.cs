using System;
using System.IO;
using System.Linq;

namespace _40_ExempleLINQ3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            var query = from item in Directory.GetFiles(@"C:\Windows\System32")
                        let fileName = Path.GetFileName(item)
                        let extension = Path.GetExtension(item).ToUpper()

                        orderby fileName, extension descending
                        
                        select new
                        {
                            FileName = fileName,
                            Extension = extension
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();

                
        }
    }
}