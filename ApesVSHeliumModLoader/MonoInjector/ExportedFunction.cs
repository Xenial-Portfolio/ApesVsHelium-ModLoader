using System;

namespace ApesVSHeliumModLoader.MonoInjector
{
    public struct ExportedFunction
    {
        public string Name;

        public IntPtr Address;

        public ExportedFunction(string name, IntPtr address)
        {
            Name = name;
            Address = address;
        }
    }
}
