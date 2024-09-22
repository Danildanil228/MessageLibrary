using System;
using System.Runtime.InteropServices;

namespace MessageLibrary
{
    public static class MessageHelper
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        public static void ShowMessages()
        {
            MessageBox(IntPtr.Zero, "Сильченков Данила Константинович. Город Калиниград", "", 0);
            MessageBox(IntPtr.Zero, "Возраст: 19 лет. Студент", "", 0);
            MessageBox(IntPtr.Zero, "Профессия: Программист. КБК", "", 0);
        }
    }
}
