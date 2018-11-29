using System;
using DataMaping.Attributes;

namespace DataMaping.Config
{
    public class ParameterConfig<T> : MBase
    {
        [Key]
        public T Name { get; set; }
        public string Des { get; set; }
        public string sValue { get; set; }
        public string sValue2 { get; set; }
        public int iValue { get; set; }
        public int iValue2 { get; set; }
        public float fValue { get; set; }
        public float fValue2 { get; set; }
        public DateTime tValue { get; set; }
        public DateTime tValue2 { get; set; }
        [DefaultValue(DefaultValue.DateTimeDefaultNow)]
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public ParameterConfig(T ParameterName)
        {
            Name = ParameterName;
            GetModel();
        }
    }
}
