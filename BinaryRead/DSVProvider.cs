using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BinaryRead
{
    class DSVProvider
    {
        public byte[] DsvBytes { get; set; }
        private string _dsvPath { get; set; }

        public DSVProvider(string dsvPath)
        {
            if (String.IsNullOrEmpty(dsvPath)) { throw new ArgumentException();}
            if(!File.Exists(dsvPath)) { throw new ArgumentException(); }

            _dsvPath = dsvPath;
            DsvBytes = ReadDSVFile(_dsvPath); 
        }

        private byte[] ReadDSVFile(string dsvPath)
        {
            byte[] dsvByte;

            using(var dsvFile = File.OpenRead(dsvPath))
            {
                byte[] tmp = new byte[dsvFile.Length];
                dsvFile.Read(tmp, 0, (int)dsvFile.Length);
                dsvByte = tmp;
            }
            return dsvByte;
        }
    }
}
