using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Helper
{
    public class PageList<T> : List<T>
    {
        public static List<T> GetPageList(List<T> list, int page, int quantityPerPage)
        {
            return list.Skip(page - 1 * quantityPerPage).Take(quantityPerPage).ToList();
        }

        public static double GetTotalPageList(List<T> list, int quantityPerPage)
        {
            double count = list.Count;
            double totalPageList = Math.Ceiling(count / quantityPerPage);
            return totalPageList;
        }
    }
}
