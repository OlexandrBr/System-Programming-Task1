using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class PersonBase
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        protected static extern int MessageBox(
            IntPtr hWnd,
            string text,
            string caption,
            uint type
        );

        protected void ShowInfo(string text, string title)
        {
            MessageBox(IntPtr.Zero, text, title, 0);
        }
    }
}