using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Core
{
    public static class Caesar
    {
        public static string Decipher(string raw)
        {
            StringBuilder newMessage = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                string c = "";
                string result = Method(c);
                if (result != null)
                newMessage.Append(result);
            }
            return newMessage.ToString();
        }

        static string Method(string c)
        {
            if ("A".Contains(c))
                return "B";
            else if ("B".Contains(c))
                return "C";
            else if ("C".Contains(c))
                return "D";
            else if ("D".Contains(c))
                return "E";
            else if ("E".Contains(c))
                return "F";
            else if ("F".Contains(c))
                return "G";
            else if ("G".Contains(c))
                return "H";
            else if ("H".Contains(c))
                return "I";
            else if ("I".Contains(c))
                return "J";
            else if ("J".Contains(c))
                return "K";
            else if ("K".Contains(c))
                return "L";
            else if ("L".Contains(c))
                return "M";
            else if ("M".Contains(c))
                return "N";
            else if ("N".Contains(c))
                return "O";
            else if ("O".Contains(c))
                return "P";
            else if ("P".Contains(c))
                return "Q";
            else if ("Q".Contains(c))
                return "R";
            else if ("R".Contains(c))
                return "S";
            else if ("S".Contains(c))
                return "T";
            else if ("T".Contains(c))
                return "U";
            else if ("U".Contains(c))
                return "V";
            else if ("V".Contains(c))
                return "W";
            else if ("W".Contains(c))
                return "X";
            else if ("X".Contains(c))
                return "Y";
            else if ("Y".Contains(c))
                return "Z";
            else if ("Z".Contains(c))
                return "A";
            return null;
        }
    }
}