using System;
using System.Runtime.InteropServices;

public unsafe static class Program
{
    public delegate void HiFromProxyCallDelegate();

    [UnmanagedCallersOnly(EntryPoint = "Hi")]
    public static void Hi(IntPtr hiFromProxyCallFuncPtr)
    {
        Console.WriteLine("Hi from C#");

        // Convert the C function pointer to a callable C# delegate.
        HiFromProxyCallDelegate func = Marshal.GetDelegateForFunctionPointer<HiFromProxyCallDelegate>(hiFromProxyCallFuncPtr);
        func();
    }
}
