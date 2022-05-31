using System;
using System.IO;
using System.Runtime.InteropServices;

namespace BinaryRead
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string dsvPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\binary.dsv";
            string dsvPath2 = @"C:\Users\81803\Desktop\binary.dsv";

            var dsvProvider = new DSVProvider(dsvPath2);

            var hoge = dsvProvider.DsvBytes;
            GCHandle gch = GCHandle.Alloc(hoge, GCHandleType.Pinned);
            DSVEntity result = (DSVEntity)Marshal.PtrToStructure(gch.AddrOfPinnedObject(), typeof(DSVEntity));
            Console.WriteLine($"{result.D}");
            Console.WriteLine(0x01000000);
            gch.Free();
        }
    }
}
