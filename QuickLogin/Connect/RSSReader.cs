using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace QuickLogin.Connect
{
    public sealed class RSSReader
    {
        /// <summary>
        /// 新闻数组
        /// </summary>
        public List<News> NewsList;
        /// <summary>
        /// 标题关键字，打折，维护等显示红色
        /// </summary>
        List<string> WarningText;
        /// <summary>
        /// 去除Html标签
        /// </summary>
        Regex rgExHtml;
        public RSSReader()
        {
            WarningText = new List<string> { "%", "Bonus", "Down", "Restart" };
            rgExHtml = new Regex("<[^>]*>", RegexOptions.IgnoreCase);
            //新闻链接地址
            string RSSURL = "https://forums.ddo.com/en/launcher-feed.xml";
            //20220416 地址修改
            //string RSSURL = "http://www.ddo.com/en/launcher-feed.xml";
            XDocument xml = XDocument.Load(RSSURL);
            NewsList = (
                from item in xml.Descendants("item")
                select new News()
                {
                    Title = GetVal(item.Element("title")),
                    Description = GetVal(item.Element("description")),
                    Link = GetVal(item.Element("link")),
                    Color = GetColor(item.Element("title")),
                    Pubdate = GetVal(item.Element("pubDate"))
                }
                     ).ToList();
        }
        /// <summary>
        /// 从XElement中获取值
        /// 删除Html标签，换行符，制表符
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        string GetVal(XElement element)
        {
            string val = string.Empty;
            try
            {
                if (element != null && !string.IsNullOrEmpty(element.Value))
                {
                    return rgExHtml.Replace(element.Value, "").Replace("\n", " ").Replace("\t", " ").Replace("\r", " ").Replace("&amp; ", "&").Replace("+0000", "").Trim();
                }
            }
            catch (Exception e) { Trace.WriteLine(e.ToString()); }
            return val;
        }
        /// <summary>
        /// 根据WarningText判断标题该显示什么颜色
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        Color GetColor(XElement element)
        {
            Color val = Color.Yellow;
            try
            {
                if (element != null && !string.IsNullOrEmpty(element.Value))
                {
                    val = WarningText.Any(txt => element.Value.Contains(txt)) ? Color.Red : Color.Yellow;
                }
            }
            catch (Exception e) { Trace.WriteLine(e.ToString()); }
            return val;
        }
    }

    /// <summary>
    /// 新闻
    /// </summary>
    public struct News
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title;
        /// <summary>
        /// 详细消息
        /// </summary>
        public string Description;
        /// <summary>
        /// 链接
        /// </summary>
        public string Link;
        /// <summary>
        /// 标题颜色
        /// </summary>
        public Color Color;
        /// <summary>
        /// 发布时间
        /// </summary>
        public string Pubdate;
    }
}
