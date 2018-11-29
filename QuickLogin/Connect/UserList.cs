using System.Collections.Generic;
using DataMaping;
using DataMaping.Attributes;
using DataMaping.Config;

namespace QuickLogin.Connect
{
    public class UserList
    {
        public User DefaultUser;
        public List<User> AllUser;
        public UserList()
        {
            DefaultUser = null;
            AllUser = null;
            var defUser = new ParameterConfig<Config>(Config.DefaultUser);
            var list = new User().GetList<User>();
            if (list != null && list.Count > 0)
            {
                AllUser = new List<User>();
                foreach (User us in list)
                {
                    User _user = new User();
                    _user.UserName = us.UserName;
                    _user.PassWord = Comm.DecryptDES(us.PassWord);
                    _user.WorldName = us.WorldName;
                    if (_user.UserName == defUser?.sValue)
                    {
                        DefaultUser = _user;
                    }
                    AllUser.Add(_user);
                }
            }
        }

        public void Save(string strCmd)
        {
            User _user = new User();
            _user.UserName = DefaultUser.UserName;
            _user.PassWord = Comm.EncryptDES(DefaultUser.PassWord);
            _user.WorldName = DefaultUser.WorldName;
            var defUser = new ParameterConfig<Config>(Config.DefaultUser);
            defUser.sValue = _user.UserName;
            defUser.sValue2 = strCmd;
            _user.Save();
            defUser.Save();
        }

    }
    public class User : MBase
    {
        [Key]
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
