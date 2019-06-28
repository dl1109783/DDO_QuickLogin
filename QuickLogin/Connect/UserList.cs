using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace QuickLogin.Connect
{
    public class UserList
    {
        /// <summary>
        /// 默认显示的用户
        /// </summary>
        public User DefaultUser;
        /// <summary>
        /// 保存的所有用户
        /// </summary>
        public List<User> AllUser;

        public UserList()
        {
            try
            {
                DefaultUser = null;
                AllUser = null;
                XDocument xml = XDocument.Load(Program.XML_FILE_PATH);
                //获得用户列表
                AllUser = (from item in xml.Descendants("User")
                           select new User()
                           {
                               PassWord = Comm.DecryptDES(GetVal(item.Attribute("Password"))),
                               UserName = GetVal(item.Attribute("Username")),
                               WorldName = GetVal(item.Attribute("World")),
                           }
                   ).ToList();
                //获得默认显示的用户
                var defUser = xml.Descendants("Users").First().Attribute("DefaultUser").Value;
                if (!string.IsNullOrEmpty(defUser) && AllUser != null && AllUser.Count > 0)
                {
                    DefaultUser = AllUser.FirstOrDefault(u => u.UserName.Equals(defUser));
                    if (DefaultUser == null) DefaultUser = AllUser[0];
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }

        public void Save()
        {
            try
            {
                XDocument xd = XDocument.Load(Program.XML_FILE_PATH);
                if (!xd.Descendants("User").Any(m => m.Attribute("Username").Value == DefaultUser.UserName))
                {
                    xd.Element("Users").Add(
                   new XElement("User",
                       new XAttribute("Username", DefaultUser.UserName),
                       new XAttribute("Password", Comm.EncryptDES(DefaultUser.PassWord)),
                       new XAttribute("World", DefaultUser.WorldName)
                       ));
                }
                else
                {
                    XElement ele = xd.Descendants("User").Where(p => (string)p.Attribute("Username").Value == DefaultUser.UserName).First();
                    ele.Attribute("Username").Value = DefaultUser.UserName;
                    ele.Attribute("Password").Value = Comm.EncryptDES(DefaultUser.PassWord);
                    ele.Attribute("World").Value = DefaultUser.WorldName;
                }

                xd.Descendants("Users").First().Attribute("DefaultUser").Value = DefaultUser.UserName;
                xd.Save(Program.XML_FILE_PATH);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
        }
        string GetVal(XAttribute element)
        {
            string val = string.Empty;
            try
            {
                if (element != null && !string.IsNullOrEmpty(element.Value))
                {
                    return element.Value.Trim();
                }
            }
            catch (Exception e) { Trace.WriteLine(e.ToString()); }
            return val;
        }

    }
    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string WorldName { get; set; }
        /// <summary>
        /// 服务于ComboBox控件, 否则无法显示字符
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.UserName;
        }
    }

}
