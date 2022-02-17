using System;
using System.Linq;
using System.IO;

namespace _43_ExempleLINQ4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void brnQuery_Click(object sender, EventArgs e)
        {
            var query = from item in Directory.GetFiles(@"C:\Windows\System32")
                        let infoFile = new FileInfo(item)
                        group infoFile by new
                        {
                            Folder = infoFile.DirectoryName,
                            Extension = infoFile.Extension.ToUpper(),
                        }
                        into groupedByFolderAndExtension

                        let amount = groupedByFolderAndExtension.Count()
                        let sizeTotalKB = groupedByFolderAndExtension.Sum(x => x.Length)

                        orderby groupedByFolderAndExtension.Key.Folder ascending, sizeTotalKB descending

                        select new
                        {
                            Folder = groupedByFolderAndExtension.Key.Folder,
                            Amount = amount,
                            SizeTotal = sizeTotalKB,
                            Extension = groupedByFolderAndExtension.Key.Extension
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();

        }
    }
}