using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InventoryNumber
{
    public static class Helper
    {
        public static string MakeCode(int code, int count, int seed = 0)
        {
            StringBuilder sb = new StringBuilder();
            if (code < 10)
            {
                sb.Append(string.Format("0{0}-", code));
            }
            else sb.Append(string.Format("{0}-", code));

            var rnd = new Random(seed);
            var year = rnd.Next(1979, 2022);
            sb.Append(string.Format("{0}-", year));

            if (count < 10)
            {
                sb.Append(string.Format("0{0}-", count));
            }
            else sb.Append(string.Format("{0}-", count));

            var id = rnd.Next(99999, 1000000);
            sb.Append(string.Format("{0}", id));
            return sb.ToString();
        }
    }
}
