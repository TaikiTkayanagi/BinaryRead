using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BinaryRead
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    class DSVEntity
    {
        public byte A;
        public byte B;
        public byte C;
        /// <summary>
        /// リトルエンディアンになって、値が入れられる
        /// </summary>
        public int D;
    }
}
