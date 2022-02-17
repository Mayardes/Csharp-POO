using System;
using System.IO;
using System.Linq;

namespace _41_ExempleLINQ6
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
                        let sizeFile = infoFile.Length /1024M /1024M
                        where sizeFile > 1M && infoFile.Extension.ToUpper() == ".EXE"

                        select new
                        {
                            FileName = infoFile.Name,
                            SizeFile = sizeFile
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();
        }
    }
}