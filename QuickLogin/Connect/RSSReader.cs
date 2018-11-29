using System.Collections.Generic;
using System.Xml;

namespace QuickLogin.Connect
{
    public sealed class RSSReader
    {
        public string Title = "";//channel的标题
        public string Description = "";//channel的描述
        public string Link = "";//channel的连接
        public Images Image;//channel的图像

        public List<Items> itemList = new List<Items>();//每个Item项目的集合
        XmlReader reader;
        XmlDocument xmlDoc;

        public RSSReader()
        {
            //新闻链接地址
            string RSSURL = "http://www.ddo.com/en/launcher-feed.xml";
            reader = XmlReader.Create(RSSURL);
            xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);

            XmlNode node = FoundChildNode(xmlDoc, "rss");
            XmlNode channelNode = FoundChildNode(node, "channel");

            for (int i = 0; i < channelNode.ChildNodes.Count; i++)
            {
                switch (channelNode.ChildNodes[i].Name)
                {
                    case "title":
                        this.Title = channelNode.ChildNodes[i].InnerText;
                        break;
                    case "image":
                        this.Image = GetImageDetial(channelNode.ChildNodes[i]);
                        break;
                    case "description":
                        this.Description = channelNode.ChildNodes[i].InnerText;
                        break;
                    case "item":
                        itemList.Add(GetItemsDetail(channelNode.ChildNodes[i]));
                        break;
                    default:
                        break;
                }
            }
        }

        private XmlNode FoundChildNode(XmlNode node, string name)
        {
            XmlNode childNode = null;
            for (int i = 0; i < node.ChildNodes.Count; i++)
            {
                if (node.ChildNodes[i].Name == name &&
                    node.ChildNodes[i].ChildNodes.Count > 0)
                {
                    childNode = node.ChildNodes[i];
                    return childNode;
                }
            }
            return childNode;
        }

        private Images GetImageDetial(XmlNode node)
        {
            Images image = new Images();
            foreach (XmlNode n in node.ChildNodes)
            {
                switch (n.Name)
                {
                    case "title":
                        image.Title = n.InnerText;
                        break;
                    case "link":
                        image.Link = n.InnerText;
                        break;
                    case "url":
                        image.URL = n.InnerText;
                        break;
                    default:
                        break;
                }
            }
            return image;
        }

        private Items GetItemsDetail(XmlNode node)
        {
            Items item = new Items();
            foreach (XmlNode n in node.ChildNodes)
            {
                switch (n.Name)
                {
                    case "title":
                        item.Title = n.InnerText;
                        break;
                    case "link":
                        item.Link = n.InnerText;
                        break;
                    case "description":
                        item.Description = n.InnerText;
                        break;
                    case "image":
                        item.Image = n.InnerText;
                        break;
                    case "dc:creator":
                        item.Creator = n.InnerText;
                        break;
                    case "pubDate":
                        item.PubDate = n.InnerText;
                        break;
                    default:
                        break;
                }
            }
            return item;
        }
    }

    public struct Items
    {
        public string Title;
        public string Description;
        public string Link;
        public string Image;
        public string PubDate;
        public string Creator;
    }

    public struct Images
    {
        public string URL;
        public string Title;
        public string Link;
    }
}
