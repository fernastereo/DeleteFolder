using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DeleteFolder
{
    public class DirectoryHandler
    {
        public void DeleteDirectoryRecursively(DirectoryInfo directory)
        {
            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException();
            }

            //even though there is a native function that deletes folders recursively, 
            //I start to delete from the last found folder inside
            foreach (var dir in directory.EnumerateDirectories())
            {
                DeleteDirectoryRecursively(dir);
            }
            directory.Delete(true);
        }

        public void DeleteDirectory(DirectoryInfo directory)
        {
            if (!directory.Exists)
            {
                throw new DirectoryNotFoundException();
            }

            directory.Delete(true);
        }

    }
}
