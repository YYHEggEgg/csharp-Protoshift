using System.Runtime.InteropServices;

namespace YSFreedom.Common.Native
{
    public class IKCP
    {
        public delegate int OutputCallback([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] buffer,
                                           int len, UIntPtr kcp, UIntPtr user);

        const string LibraryPath = "ikcp.dll";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ikcp_create(uint conv, uint token, UIntPtr user);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ikcp_release(UIntPtr kcp);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ikcp_setoutput(UIntPtr kcp, OutputCallback output);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ikcp_recv(UIntPtr kcp, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] buffer, int len);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ikcp_send(UIntPtr kcp, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] buffer, int len);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ikcp_update(UIntPtr kcp, uint current);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ikcp_check(UIntPtr kcp, uint current);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ikcp_input(UIntPtr kcp, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] buffer, int len);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ikcp_flush(UIntPtr kcp);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ikcp_peeksize(UIntPtr kcp);

        // Added
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ikcp_nodelay(UIntPtr kcp, int nodelay, int interval, int resend, int nc);

        // Added
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ikcp_wndsize(UIntPtr kcp, int sndwnd, int rcvwnd);
    }
}
