using System;
using System.IO;
using System.Linq;

namespace _42_ExempleLINQ9
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
                        group infoFile by infoFile.Extension.ToUpper() into g
                        let extension = g.Key
                        orderby extension ascending

                        select new
                        {
                            Extension = extension,
                            NumbersFile = g.Count(),
                            SizeTotalFiles = g.Sum(x => x.Length) /1024M,
                            SizeAverageFiles = g.Average(x => x.Length) /1024D,
                            SizeMajorFiles = g.Max(x => x.Length)/1024M,
                            SizeMinorFiles = g.Min(x => x.Length)/1024M
                        };

            GridView1.DataSource = query;
            GridView1.DataBind();
        }
    }
}