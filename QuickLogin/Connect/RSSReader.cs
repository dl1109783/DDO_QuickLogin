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
        /// ��������
        /// </summary>
        public List<News> NewsList;
        /// <summary>
        /// ����ؼ��֣����ۣ�ά������ʾ��ɫ
        /// </summary>
        List<string> WarningText;
        /// <summary>
        /// ȥ��Html��ǩ
        /// </summary>
        Regex rgExHtml;
        public RSSReader()
        {
            WarningText = new List<string> { "%", "Bonus", "Down", "Restart" };
            rgExHtml = new Regex("<[^>]*>", RegexOptions.IgnoreCase);
            //�������ӵ�ַ
            string RSSURL = "https://forums.ddo.com/en/launcher-feed.xml";
            //20220416 ��ַ�޸�
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
        /// ��XElement�л�ȡֵ
        /// ɾ��Html��ǩ�����з����Ʊ��
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
        /// ����WarningText�жϱ������ʾʲô��ɫ
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
    /// ����
    /// </summary>
    public struct News
    {
        /// <summary>
        /// ����
        /// </summary>
        public string Title;
        /// <summary>
        /// ��ϸ��Ϣ
        /// </summary>
        public string Description;
        /// <summary>
        /// ����
        /// </summary>
        public string Link;
        /// <summary>
        /// ������ɫ
        /// </summary>
        public Color Color;
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string Pubdate;
    }
}
