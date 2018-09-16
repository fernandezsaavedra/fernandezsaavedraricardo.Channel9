using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace fernandezsaavedraricardo.Channel9
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

            using (RssReader rss = new RssReader())
            {
                rss.FeedUrl = "https://channel9.msdn.com/feeds/rss";
                foreach (RssItem item in rss.Execute())
                {
                    
                    grid.Rows.Add(item.Date,item.Title, item.Description, item.LinkFeed);
                }

                grid.Sort(this.grid.Columns["date"], ListSortDirection.Descending);
            }
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            reader.Text = grid.SelectedRows[0].Cells["description"].Value.ToString();
        }

        private void btn_more_Click(object sender, EventArgs e)
        {
            string feedlink = grid.SelectedRows[0].Cells["link"].Value.ToString();
            Process.Start(feedlink);
        }
    }
}
