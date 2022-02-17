using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _41_ExempleLINQ1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            var query = from item in Directory.GetFiles(@"C:\Windows\System32")
                        let infoFile = new FileInfo(item)
                        let sizeFileMB = infoFile.Length / 1024M / 1024M
                        where sizeFileMB > 1M && infoFile.Extension.ToUpper() == ".EXE"
                        orderby sizeFileMB 

                        select new
                        {
                            SizeFileMB = sizeFileMB,
                            Extension = infoFile.Extension,
                            NameFile = infoFile.Name
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();
           
        }
    }
}