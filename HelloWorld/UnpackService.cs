using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace helloWorld
{
    class UnpackService
    {
        //public delegate void Handler(object source, FileEventArgs args);        
        public event EventHandler<FileEventArgs> FileUnpacked;
        protected virtual void OnFileUnpacked(FileEventArgs file)
        {
            FileUnpacked?.Invoke(this, new FileEventArgs() { File = file.File });
            //another way to do the trigger

            //we use "new FileEventArgs() { File = file.File }" in order to 
            //assign the file.File property (which is a File obj) to 
            //the new File property of FileEventArgs() which requires a File obj
        }

        public void OnFileDownloaded(object source, FileEventArgs file)
        {
            Console.WriteLine("Unpacking file '{0}'...", file.File.Title);
            Thread.Sleep(2000);
                        
            OnFileUnpacked(file);
        }
    }
}
