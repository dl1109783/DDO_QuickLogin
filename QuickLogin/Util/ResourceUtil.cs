using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QuickLogin.Util
{
    public class ResourceUtil
    {
        public static Image GetImage(string resourceName)
        {
            object obj = Properties.Resources.ResourceManager.GetObject(resourceName, Properties.Resources.Culture);
            return (Image)obj;
        }
    }
}
