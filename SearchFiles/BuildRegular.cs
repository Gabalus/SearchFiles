using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchFiles
{
    class BuildRegular
    {
        string findStr;
        int crSearch;

        public BuildRegular(string findStr, int crSearch)
        {
            this.findStr = findStr;
            this.crSearch = crSearch;
        }

        public Regex BuildReg()
        {
            Regex reg = new Regex("");
            ParseStr();
            switch (crSearch)
            {
                case 0:
                    reg = new Regex($@"\w*{findStr}\w*",RegexOptions.IgnoreCase);
                    break;

                case 1:
                    reg = new Regex($@"\w*{findStr}\w*");
                    break;

                        case 10:
                    reg = new Regex($@"\b{findStr}\b", RegexOptions.IgnoreCase);
                    break;

                case 100:
                    reg = new Regex($@"\w*{findStr}\b", RegexOptions.IgnoreCase);
                    break;

                case 1000:
                    reg = new Regex($@"\b{findStr}\w*", RegexOptions.IgnoreCase);
                    break;

                case 1001:
                    reg = new Regex($@"\b{findStr}\w*");
                    break;

                case 101:
                    reg = new Regex($@"\w*{findStr}\b");
                    break;

                case 11:
                    reg = new Regex($@"\b{findStr}\b");
                    break;

            }



            return reg;
        }
     
        private void ParseStr ()
        {
            if (findStr.Contains(":") || findStr.Contains("/") || findStr.Contains("\\") || findStr.Contains("|") || findStr.Contains("?") || findStr.Contains("<") || findStr.Contains(">"))
            {
                throw new ExtraSymbolsException();
            }
            if (findStr.Contains("*"))
            {
                findStr = findStr.Replace("*", @"\w");
            }
        }
    }
    
}
