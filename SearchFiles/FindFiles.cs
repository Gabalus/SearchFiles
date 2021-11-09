using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace SearchFiles
{
    class FindFiles
    {
        Regex regex;
        string path;
        List<string> subDirs = new List<string>();
        List<string> targetFiles = new List<string>();
        


        public FindFiles(string findStr, string path,int crSearch)
        {
            
            this.path = path;
           
            TargetFiles();
            regex = new BuildRegular(findStr, crSearch).BuildReg();
        }




        private void TargetFiles()
        {
          ProcessDirectory(path);
            var file = Directory.GetFiles(path);
            targetFiles.AddRange(file);
            foreach (var item in subDirs)
            {
                targetFiles.AddRange(Directory.GetFiles(item));
            }
        }




        public List<string> Search()
        {
           
            

            List<string> result = new List<string>();
            foreach (var item in targetFiles)
            {
                string fileName = Path.GetFileName(item);
                if (regex.IsMatch(fileName))
                {

                    result.Add(item);
                }
            }
            return result;

            
        }





        private void ProcessDirectory(string targetDirectory)
        {

            
            DirectoryInfo directoryInfo = new DirectoryInfo(targetDirectory);

            foreach (var item in directoryInfo.GetDirectories())
            {
                try
                {
                    subDirs.Add(item.FullName);
                    ProcessDirectory(item.FullName);
                }
                catch(UnauthorizedAccessException)
                {
                    continue;
                }
                
            }
            
        }

        
 
    }
}
