#include <stdio.h>

void hiFromProxyFunc() // Called by C# through a function pointer.
{
    printf("Hi from C# through C!\n");
}

typedef void (*hiFromProxyFuncPtrType)();
extern __stdcall int Hi(hiFromProxyFuncPtrType); // Declared in Program.cs

int main() {
    Hi(&hiFromProxyFunc);
    printf("Hello, world!\n");
    return 0;
}
