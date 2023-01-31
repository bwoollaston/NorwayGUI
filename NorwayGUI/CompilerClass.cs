using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace NorwayGUI
{
    public class Compiler
    {
        Process CCS = new Process();
        public Compiler()
        {

        }

        public void Open()
        {
            CCS.StartInfo.FileName = "ccstudio.exe";
            CCS.Start();
        }
    }
}
