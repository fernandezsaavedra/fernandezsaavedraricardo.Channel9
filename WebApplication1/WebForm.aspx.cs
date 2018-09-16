using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 using fernandezsaavedraricardo.Channel9;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (RssReader rss = new RssReader())
            {
                rss.FeedUrl = "https://channel9.msdn.com/feeds/rss";
                foreach (RssItem item in rss.Execute())
                {
                    //Response.Write(item.Title + "<br />");
                    //listBox1.Items.Add(item.Title);
                    //row = new DataGridViewRow;
                    //row.Cells[1].Value = item.Title;
                    //row.Cells[2].Value = item.Description;
                    //grid.Rows.Add(item.Date, item.Title, item.Description, item.LinkFeed);
                    TableRow tRow = new TableRow();
                    TableCell tCelltitle = new TableCell();
                    tCelltitle.Text = item.Title;
                    tRow.Cells.Add(tCelltitle);
                    TableCell tCelllink = new TableCell();
                    tCelllink.Text = "<a href='"+item.LinkFeed+"'>View</a>";
                    tRow.Cells.Add(tCelllink);
                    FeedTable.Rows.Add(tRow);
                }

                //grid.Sort(this.grid.Columns["date"], ListSortDirection.Descending);
            }
        }
    }
}