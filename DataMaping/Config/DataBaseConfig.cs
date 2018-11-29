using System;
using DataMaping.Attributes;

namespace DataMaping.Config
{
    public class DataBaseConfig : MBase
    {
        [Key]
        public string Name { get; set; }
        public string Des { get; set; }
        public DataBaseType DataBase { get; set; }
        public string ConnStr { get; set; }
        [DefaultValue(DefaultValue.DateTimeDefaultNow)]
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool Init { get; set; }
        public DataBaseConfig(string DB_Name)
        {
            Name = DB_Name;
            GetModel();
        }
    }
}
