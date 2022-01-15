using System;
using System.Runtime.InteropServices;

namespace Kogane
{
    public static class ExeWindowFrameChanger
    {
        [DllImport( "user32.dll" )] private static extern IntPtr GetActiveWindow();

        [DllImport( "user32.dll" )]
        private static extern int SetWindowLong
        (
            IntPtr hWnd,
            int    nIndex,
            uint   dwNewLong
        );

        private const int GWL_STYLE = -16;

        private const uint WS_OVERLAPPED  = 0x00000000;
        private const uint WS_MAXIMIZEBOX = 0x00010000;
        private const uint WS_MINIMIZEBOX = 0x00020000;
        private const uint WS_THICKFRAME  = 0x00040000;
        private const uint WS_SYSMENU     = 0x00080000;
        private const uint WS_CAPTION     = 0x00C00000;
        private const uint WS_VISIBLE     = 0x10000000;
        private const uint WS_POPUP       = 0x80000000;

        private const uint WS_OVERLAPPEDWINDOW =
            WS_OVERLAPPED |
            WS_MAXIMIZEBOX |
            WS_MINIMIZEBOX |
            WS_THICKFRAME |
            WS_SYSMENU |
            WS_CAPTION;

        public static void ChangeToDefault()
        {
            var hWnd = GetActiveWindow();

            SetWindowLong
            (
                hWnd: hWnd,
                nIndex: GWL_STYLE,
                dwNewLong: WS_VISIBLE | WS_OVERLAPPEDWINDOW
            );
        }

        public static void ChangeToBorderless()
        {
            var hWnd = GetActiveWindow();

            SetWindowLong
            (
                hWnd: hWnd,
                nIndex: GWL_STYLE,
                dwNewLong: WS_POPUP | WS_VISIBLE
            );
        }
    }
}