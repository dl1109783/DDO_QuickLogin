using QuickLogin.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace QuickLogin.Util
{
    public class CsvUtil
    {
        /// <summary>
        /// 将CSV文件的数据读取到DataTable中
        /// </summary>
        /// <param name="fileName">CSV文件路径</param>
        /// <returns>列行存储到字典</returns>
        public static void OpenReadCSV(List<Dictionary<string,string>> dic, string filePath)
        {
            //string path = Config.GetFilePath("Log\\NewDailyMaintenance.csv"); 
            //if (File.Exists())
            //{
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            
            //记录每次读取的一行记录
            string strLine = "";
            //记录每行记录中的各字段内容
            string[] aryLine;
            
            string[] aryFields = null;
            //标示列数
            int columnCount = 0;
            //标示是否是读取的第一行
            bool IsFirst = true;

            //逐行读取CSV中的数据
            while ((strLine = sr.ReadLine()) != null)
            {
                aryLine = strLine.Split(',');
                if (IsFirst == true)
                {
                    IsFirst = false;
                    columnCount = aryLine.Length;
                    aryFields = aryLine;
                }
                else
                {
                    Dictionary<string, string> _dic = new Dictionary<string, string>();
                    for (int j = 0; j < columnCount; j++)
                    {
                        _dic.Add(aryFields[j], aryLine[j]);
                    }
                }
            }
            sr.Close();
            fs.Close();
            //}
        }

        public static void ReadResourceCSV(List<Dictionary<string, string>> dic, string csvContent)
        {
            string[] arr = csvContent.Split('\n');

            //记录每行记录中的各字段内容
            string[] aryLine;

            string[] aryFields = null;
            //标示列数
            int columnCount = 0;
            //标示是否是读取的第一行
            bool IsFirst = true;

            foreach (string _strLine in arr)
            {
                //Console.WriteLine(_strLine);
                if (string.IsNullOrEmpty(_strLine.Trim()))
                {
                    break;
                }
                aryLine = _strLine.Split(',');
                if (IsFirst == true)
                {
                    IsFirst = false;
                    columnCount = aryLine.Length;
                    aryFields = aryLine;
                }
                else
                {
                    Dictionary<string, string> _dic = new Dictionary<string, string>();
                    for (int j = 0; j < columnCount; j++)
                    {
                        _dic.Add(aryFields[j].Trim(), aryLine[j].Trim());
                    }

                    dic.Add(_dic);
                }
            }
        }
    }
}
