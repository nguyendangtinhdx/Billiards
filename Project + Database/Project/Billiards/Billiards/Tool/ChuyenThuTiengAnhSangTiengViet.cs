using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.Tool
{
    public class ChuyenThuTiengAnhSangTiengViet
    {
        public static string Change(string english)
        {
            string tiengviet = "";
            if (english.Equals("Monday"))
            {
                tiengviet = "Thứ 2";
            }
            else if (english.Equals("Tuesday"))
            {
                tiengviet = "Thứ 3";
            }
            else if (english.Equals("Wednesday"))
            {
                tiengviet = "Thứ 4";
            }
            else if (english.Equals("Thursday"))
            {
                tiengviet = "Thứ 5";
            }
            else if (english.Equals("Friday"))
            {
                tiengviet = "Thứ 6";
            }
            else if (english.Equals("Saturday"))
            {
                tiengviet = "Thứ 7";
            }
            else if (english.Equals("Sunday"))
            {
                tiengviet = "Chủ nhật";
            }
            else
                tiengviet = "";
            return tiengviet;
        }
    }
}
