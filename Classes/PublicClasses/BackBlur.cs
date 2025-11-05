using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApplication.Classes.PublicClasses
{
    internal class BackBlur
    {
        public struct AccentPolicy
        {
            public int AccentState;
            public int AccentFlags;
            public int GradiantColor;
            public int AnimationID;
        }

        [StructLayout(LayoutKind.Sequential)]


        public struct WindowCompositionAttributeData
        {
            public int Attribute;
            public IntPtr Data;
            public int SizeofData;
        }

        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        public void SetBlurBack(Form form)
        {
            form.BackColor = Color.Black;
            form.Load += (s, e) => EnableBlur(form);
        }

        public void EnableBlur(Form form)
        {
            var accent = new AccentPolicy();
            accent.AccentState = 3;
            accent.GradiantColor = (180 << 24) | (0x00 << 16) | (0x00 << 8) | 0x00;
            var accentStructSize = Marshal.SizeOf(accent);
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);
            var data = new WindowCompositionAttributeData();
            data.Attribute = 19;
            data.SizeofData = accentStructSize;
            data.Data = accentPtr;

            SetWindowCompositionAttribute(form.Handle, ref data);
            Marshal.FreeHGlobal(accentPtr);
        }

    }
}



