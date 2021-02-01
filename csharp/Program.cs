using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public unsafe static class Program
{
  public delegate void HiFromProxyCallDelegate();

  [UnmanagedCallersOnly(EntryPoint = "Hi")]
  public static void Hi(IntPtr hiFromProxyCallFuncPtr)
  {
    Console.WriteLine("Hi from C#");
    HiFromProxyCallDelegate func = Marshal.GetDelegateForFunctionPointer<HiFromProxyCallDelegate>(hiFromProxyCallFuncPtr);
    func();
  }
}
