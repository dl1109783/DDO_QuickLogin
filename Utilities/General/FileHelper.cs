using System.IO;
using System.Text;

namespace Utilities.General
{
    public static class FileHelper
    {
        /// <summary>
        /// FileInfo扩展MoveTo方法
        /// </summary>
        /// <param name="file"></param>
        /// <param name="destFileName"></param>
        /// <param name="overwrite"></param>
        public static void MoveTo(this FileInfo file, string destFileName, bool overwrite)
        {
            if (overwrite && File.Exists(destFileName)) File.Delete(destFileName);
            file.MoveTo(destFileName);

        }
        /// <summary>
        /// 向指定文件输出内容
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static bool WriteFile(string filePath, string fileName, string msg, Encoding encoding)
        {
            try
            {
                string fileFullName = filePath + "\\" + fileName;
                if (Directory.Exists(filePath) && File.Exists(fileFullName))
                {
                    File.AppendAllText(fileFullName, msg, encoding);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public static bool WriteFile(string filePath, string fileName, string msg)
        {
            return WriteFile(filePath, fileName, msg, Encoding.UTF8);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param> 
        /// <returns></returns>
        public static string ReadFile(string filePath, string fileName, Encoding encoding)
        {
            string fileFullName = filePath + "\\" + fileName;
            if (Directory.Exists(filePath) && File.Exists(fileFullName))
            {
                return File.ReadAllText(fileFullName, encoding);
            }
            else return string.Empty;
        }
        public static string ReadFile(string filePath, string fileName)
        {
            return ReadFile(filePath, fileName, Encoding.UTF8);
        }
        /// <summary>
        /// 检查目录是否存在
        /// </summary>
        /// <param name="path"></param>
        /// <param name="isCreate">若不存在是否创建</param>
        /// <returns></returns>
        public static bool CheckDir(string path, bool isCreate = true)
        {
            if (!Directory.Exists(path))
            {
                if (isCreate) Directory.CreateDirectory(path);
                return false;
            }
            else return true;
        }
        public static bool CheckFile(string path, string fileName)
        {
            CheckDir(path);
            return File.Exists(path + fileName);
        }
        public static bool CheckFile(string fullName)
        {
            var path = fullName.Remove(fullName.LastIndexOf("\\") + 1);
            var name = fullName.Remove(0, fullName.LastIndexOf("\\") + 1);
            return CheckFile(path, name);
        } 
    }
}
