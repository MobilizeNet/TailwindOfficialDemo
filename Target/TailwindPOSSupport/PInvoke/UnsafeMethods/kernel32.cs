using System.Runtime.InteropServices;
using System;
using Mobilize.WebMap.Common.Attributes;

namespace TailwindPOSSupport.PInvoke.UnsafeNative
{
	[System.Security.SuppressUnmanagedCodeSecurity]
	[Observable]
	public static class kernel32
	{

		[DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
		extern public static int GetPrivateProfileString(dynamic lpApplicationName, System.IntPtr lpKeyName, dynamic lpDefault, dynamic lpReturnedString, int nSize, dynamic lpFileName);
	}
}