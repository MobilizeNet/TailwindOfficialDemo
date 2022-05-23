using System.Runtime.InteropServices;
using System;
using Mobilize.WebMap.Common.Attributes;

namespace TailwindPOSSupport.PInvoke.SafeNative
{

   [Observable]
   public static class kernel32
   {

   	public static int GetPrivateProfileString(dynamic lpApplicationName, string lpKeyName, dynamic lpDefault, dynamic lpReturnedString, int nSize, dynamic lpFileName)
      {
      	int result = 0;
      	IntPtr tmpPtr = Marshal.StringToHGlobalAnsi(lpKeyName);
      	try
      	{
      		result = TailwindPOSSupport.PInvoke.UnsafeNative.kernel32.GetPrivateProfileString(Mobilize.Web.ReferenceExtensions.Ref(() => lpApplicationName), tmpPtr, Mobilize.Web.ReferenceExtensions.Ref(() => lpDefault), Mobilize.Web.ReferenceExtensions.Ref(() => lpReturnedString), nSize, Mobilize.Web.ReferenceExtensions.Ref(() => lpFileName));
            lpKeyName = Marshal.PtrToStringAnsi(tmpPtr);
         }
         finally
         {
            Marshal.FreeHGlobal(tmpPtr);
         }
         return result;
      }

   }
}