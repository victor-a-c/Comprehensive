using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comprehensive.Utilities.Helper
{
    public static class EnumHelper
    {
        public static string GetDescription<T>(this T source)
        {
            var fi = source?.GetType().GetField(source.ToString() ?? string.Empty);
            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : source.ToString();
        }
    }
}
