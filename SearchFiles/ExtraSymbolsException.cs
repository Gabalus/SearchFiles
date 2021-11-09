using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFiles
{
    class ExtraSymbolsException : Exception
    {
        public override string Message
        {
            get
            {
                return "Имя файла содержит не допустимые символы";
            }
        }
        


    }
}
