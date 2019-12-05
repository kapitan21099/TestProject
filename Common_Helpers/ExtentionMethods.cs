using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Helpers
{
    public static class ExtentionMethods
    {
        public static void RemoveLast<T>(this List<T> list)
        {
            if(list!=null&&list.Count!=0)
            {
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
