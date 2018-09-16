using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections.ObjectModel;
using System.Web;

namespace fernandezsaavedraricardo.Channel9
{
    class RssReader : IDisposable
    {
        #region Constructors

        public RssReader()
        { }

        public RssReader(string feedUrl)
        {
            _FeedUrl = feedUrl;
        }

        #endregion

        #region Properties

        private string _FeedUrl;
       
        /// Gets or sets the URL of the RSS feed to parse.
        
        public string FeedUrl
        {
            get { return _FeedUrl; }
            set { _FeedUrl = value; }
        }

        private Collection<RssItem> _Items = new Collection<RssItem>();
        
        /// Gets all the items in the RSS feed.
        
        public Collection<RssItem> Items
        {
            get { return _Items; }
        }

        private string _Title;
      
        /// Gets the title of the RSS feed.
       
        public string Title
        {
            get { return _Title; }
        }

        private string _Description;
        
        /// Gets the description of the RSS feed.
       
        public string Description
        {
            get { return _Description; }
        }

        private DateTime _PubDate;
        
        /// Gets the date and time
       
        public DateTime PubDate
        {
            get { return _PubDate; }
        }

        private string _LinkFeed;
       
        /// Gets the link to item
        
        public string LinkFeed
        {
            get { return _LinkFeed; }
        }

        #endregion

        #region Methods

        
        public Collection<RssItem> Execute()
        {
            if (String.IsNullOrEmpty(FeedUrl))
                throw new ArgumentException("The feed url must be set");

            using (XmlReader reader = XmlReader.Create(FeedUrl))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);

                ParseElement(doc.SelectSingleNode("//channel"), "title", ref _Title);
                ParseElement(doc.SelectSingleNode("//channel"), "description", ref _Description);
                ParseItems(doc);
                

                return _Items;
            }
        }

      
        /// Parses the xml document in order to retrieve the RSS items.
      
        private void ParseItems(XmlDocument doc)
        {
            _Items.Clear();
            XmlNodeList nodes = doc.SelectNodes("rss/channel/item");

            foreach (XmlNode node in nodes)
            {
                RssItem item = new RssItem();
                ParseElement(node, "title", ref item.Title);
                ParseElement(node, "description", ref item.Description);
                ParseElement(node, "link", ref item.LinkFeed);

                string date = null;
                ParseElement(node, "pubDate", ref date);
                DateTime.TryParse(date, out item.Date);

                _Items.Add(item);
            }
        }

       
        /// Parses the XmlNode with the specified XPath query and assigns the value to the property parameter.
      
        private void ParseElement(XmlNode parent, string xPath, ref string property)
        {
            XmlNode node = parent.SelectSingleNode(xPath);
            if (node != null)
                property = node.InnerText;
            else
                property = "Unresolvable";
        }

        #endregion

        #region IDisposable Members

        private bool _IsDisposed;

        /// <summary>
        /// Performs the disposal.
        /// </summary>
        private void Dispose(bool disposing)
        {
            if (disposing && !_IsDisposed)
            {
                _Items.Clear();
                _FeedUrl = null;
                _Title = null;
                _Description = null;
                _LinkFeed = null;
               
            }

            _IsDisposed = true;
        }

        /// <summary>
        /// Releases the object to the garbage collector
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

    }

    #region RssItem struct

    /// Represents a RSS feed item.
    /// 
    [Serializable]
    public struct RssItem
    {
        /// The publishing date.

        public DateTime Date;


        /// The title of the item.

        public string Title;


        /// A description of the content or the content itself.

        public string Description;

        /// The link to the webpage where the item was published.

        public string LinkFeed;
    }
    #endregion
}
