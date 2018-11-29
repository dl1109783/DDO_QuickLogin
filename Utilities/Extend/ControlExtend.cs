using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Utilities.Extend
{
    public static class ControlExtend
    {
        public static void InvokeSetText(this Control ctrl, string value)
        {
            Action<string> actLabel = (iValue) =>
            {
                ctrl.Text = value;
            };
            ctrl.Invoke(actLabel, value);
        }
        public static void InvokeSetEnabled(this Control ctrl, bool value)
        {
            Action<bool> actEnabled = (iValue) =>
            {
                ctrl.Enabled = value;
            };
            ctrl.Invoke(actEnabled, value);
        }
        #region ComboBox
        public static void Select(this ComboBox cbx, string item)
        {
            cbx.SelectedIndex = cbx.Items.IndexOf(item);
        }
        #endregion

        #region DataGridView
        public static void InvokeAddRow(this DataGridView dgv, List<string> value)
        {
            Action<List<string>> DataGridViewAddRow = (iValue) =>
            {
                dgv.Rows.Add(iValue.ToArray());
            };
            //List和Array转来转去,脱裤子放屁均是为了以下↓SB方法. 第二个参数(params object[] args)如果传入数组会被拆成N个参数
            dgv.Invoke(DataGridViewAddRow, value);
        }

        public static T SafeRead<T>(this DataRow dr, string fieldName, T defaultValue)
        {
            try
            {
                object obj = dr[fieldName];
                if (obj == null || obj == DBNull.Value) return defaultValue;
                else return (T)Convert.ChangeType(obj, defaultValue.GetType());
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>         
        /// 获取字符串类型数据  
        /// </summary>    
        /// <param name="dr"></param> 
        /// <param name="name"></param>     
        /// <returns></returns>     
        public static string GetString(this DataRow dr, string name)
        {

            if (dr[name] != DBNull.Value && dr[name] != null)
                return dr[name].ToString();
            return String.Empty;
        }
        /// <summary>         
        /// 获取非空类型数据        
        /// </summary>         
        /// <param name="con"></param>
        /// <param name="name"></param>
        /// <returns></returns>       
        public static DateTime GetDateTime(this DataRow dr, string name)
        {
            DateTime result = DateTime.Now;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!DateTime.TryParse(dr[name].ToString(), out result))
                    throw new Exception("日期格式数据转换失败");
            }
            return result;
        }
        /// <summary>         
        /// 获取非空类型数据        
        /// </summary>         
        /// <param name="con"></param>
        /// <param name="name"></param>
        /// <returns></returns>       
        public static string GetStrDateTime(this DataRow dr, string name, string fmtStr)
        {
            DateTime result = DateTime.Now;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!DateTime.TryParse(dr[name].ToString(), out result))
                    return "";
            }
            return result.ToString(fmtStr);
        }
        /// <summary>         
        /// 获取可空类型日期数据        
        /// </summary>         
        /// <param name="dr"></param>        
        /// <param name="name"></param>        
        /// <returns></returns>         
        public static DateTime? GetNullDateTime(this DataRow dr, string name)
        {

            DateTime? result = null;
            DateTime time = DateTime.Now;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!DateTime.TryParse(dr[name].ToString(), out time))
                    throw new Exception("日期格式数据转换失败");
                result = time;
            }
            return result;
        }

        /// <summary>         
        /// 获取guid类型数据        
        /// </summary>         
        /// <param name="dr"></param>        
        /// <param name="name"></param>        
        /// <returns></returns>         
        public static Guid GetGuid(this DataRow dr, string name)
        {
            Guid guid = Guid.Empty;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (Guid.TryParse(dr[name].ToString(), out guid))
                    throw new Exception("guid类型数据转换失败");
            }
            return guid;
        }
        /// <summary>        
        /// 获取整形数据        
        /// </summary>         
        /// <param name="dr"></param>        
        /// <param name="name"></param>        
        /// <returns></returns>        
        public static int GetInt32(this DataRow dr, string name)
        {
            int result = 0;

            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!int.TryParse(dr[name].ToString(), out result))
                    throw new Exception("整形转换失败");
            }
            return result;
        }

        /// <summary>        
        /// 获取双精度类型数据
        /// </summary>   
        /// <param name="dr"></param>  
        /// <param name="name"></param>    
        /// <returns></returns>         
        public static double GetDouble(this DataRow dr, string name)
        {
            double result = 0.00;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!double.TryParse(dr[name].ToString(), out result))
                    throw new Exception("双精度类型转换失败");
            }
            return result;
        }
        /// <summary>         
        /// 获取单精度类型数据        
        /// </summary>         
        /// <param name="dr"></param>        
        /// <param name="name"></param>        
        /// <returns></returns>         
        public static float GetSingle(this DataRow dr, string name)
        {
            float result = 0.00f;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!float.TryParse(dr[name].ToString(), out result))
                    throw new Exception("单精度类型转换失败");
            }

            return result;
        }

        /// <summary>         
        /// 获取decimal类型数据        
        /// </summary>         
        /// <param name="dr"></param> 
        /// <param name="name"></param>    
        /// <returns></returns>         
        public static decimal GetDecimal(this DataRow dr, string name)
        {
            decimal result = 0.00m;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!decimal.TryParse(dr[name].ToString(), out result))
                    throw new Exception("Decimal类型转换失败");
            }
            return result;
        }

        /// <summary>         
        /// 获取int16类型数据        
        /// </summary>         
        /// <param name="dr"></param>        
        /// <param name="name"></param>        
        /// <returns></returns>         
        public static Int16 GetInt16(this DataRow dr, string name)
        {
            short result = 0;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!short.TryParse(dr[name].ToString(), out result))
                    throw new Exception("短整形转换失败");
            }
            return result;
        }

        /// <summary>         
        /// 获取Byte类型数据        
        /// </summary>
        ///  <param name="dr"></param>        
        /// <param name="name"></param>        
        /// <returns></returns>         
        public static byte GetByte(this DataRow dr, string name)
        {
            byte result = 0;
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                if (!byte.TryParse(dr[name].ToString(), out result))
                    throw new Exception("Byte类型转换失败");
            }
            return result;
        }

        /// <summary>         
        /// 获取bool类型数据如果传值是1或者是返回true;       
        /// </summary>         
        /// <param name="con"></param>        
        /// <param name="name"></param>        
        /// <returns></returns>         
        public static bool GetBool(this DataRow dr, string name)
        {
            if (dr[name] != DBNull.Value && dr[name] != null)
            {
                return dr[name].ToString() == "1" || dr[name].ToString() == "是" || dr[name].ToString().ToLower() == "true";
            }
            return false;
        }
        #endregion

        #region ProgressBar
        public static void InvokeValue(this ProgressBar pb, int iValue)
        {
            Action<int> actProgressBar = (v) =>
            {
                pb.Value = v;
            };
            pb.Invoke(actProgressBar, iValue);
        }
        public static void InvokeStep(this ProgressBar pb, int iStep = 1)
        {
            Action<int> actProgressBar = (v) =>
            {
                pb.Value = pb.Value + v;
            };
            pb.Invoke(actProgressBar, iStep);
        }
        #endregion

        #region 扩展RichTextBox
        static Queue<string> que = new Queue<string>();
        /// <summary>
        /// 向RichTextBox中增加内容
        /// </summary>
        /// <param name="rtxt"></param>
        /// <param name="value"></param>
        public static void InvokeAppendText(this RichTextBox rtxt, string value)
        {
            Action<string> actRichTextBox = (iValue) =>
            {
                que.Enqueue(value);
                if (que.Count > 500)
                {
                    que.Dequeue();
                }
                rtxt.Lines = que.Reverse<string>().ToArray();
            };
            rtxt.Invoke(actRichTextBox, value);
        }
        /// <summary>
        /// 向RichTextBox中增加内容
        /// </summary>
        /// <param name="rtxt"></param>
        /// <param name="value"></param>
        public static void InvokeClearText(this RichTextBox rtxt, string Message = "")
        {
            Action actRichTextBox = () =>
            {
                que.Clear();
                que.Enqueue(Message);
                rtxt.Lines = que.Reverse<string>().ToArray();
            };
            rtxt.Invoke(actRichTextBox);
        }
        public static void InvokeLogTex(this RichTextBox rtxt, string value)
        {
            rtxt.InvokeAppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "\t" + value);
        }
        public static void InvokeLogClear(this RichTextBox rtxt)
        {
            rtxt.InvokeClearText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "\t================Clear================");
        }
        #endregion
    }
}
