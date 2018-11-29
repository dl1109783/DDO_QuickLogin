using System;
using Utilities.DataMaping;
using Utilities.DataMaping.Properties;

namespace Utilities.Config
{
    public class S_Config : MBase
    {
        [Key]
        public string Name { get; set; }
        public string sValue { get; set; }
        public string sValue2 { get; set; }
        public int iValue { get; set; }
        public int iValue2 { get; set; }
        public DateTime tValue { get; set; }
        public DateTime tValue2 { get; set; }
        public float fValue { get; set; }
        public float fValue2 { get; set; }
        public void Get<T>(T sc)
        {
            Name = sc.ToString();
            GetModel();
        }
    }
}

