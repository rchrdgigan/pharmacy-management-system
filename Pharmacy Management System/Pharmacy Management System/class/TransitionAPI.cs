using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    class TransitionAPI
    {
        public const int fadeIN = 0x80000;
        public const int horRight = 0X1;
        public const int horLeft = 0X2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlag);
    }
}
