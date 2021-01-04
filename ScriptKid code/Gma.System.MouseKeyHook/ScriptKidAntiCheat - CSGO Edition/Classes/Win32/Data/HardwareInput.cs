using System.Runtime.InteropServices;

namespace ScriptKidAntiCheat.Win32.Data
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/windows/win32/api/winuser/ns-winuser-hardwareinput
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct HardwareInput
    {
        public int uMsg;
        public short wParamL;
        public short wParamH;
    }
}
