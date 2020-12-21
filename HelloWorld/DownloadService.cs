using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
/// <summary>
/// Events examples
/// </summary>
namespace helloWorld
{
    class DownloadService
    {
        //step 1. create a delegate
        public delegate void FileDownloadedEventHandler(object source, FileEventArgs args); //   EventHandler<EventArgs> (son lo mismo)
        //step 2. create an event based on that delegate
        public event FileDownloadedEventHandler FileDownloaded;
        //step 3. raise the event
        protected virtual void OnFileDownloaded(File file)
        {
            if(FileDownloaded != null)
            {
                //FileDownload will not be null if there's a receiver
                //FileDownloaded(this, EventArgs.Empty); //triggers the event with (this object as source, an empty argument)
                FileDownloaded(this, new FileEventArgs() { File = file }); //Using a FileEventArgs object instead in order to pass the file Title to the receivers
            }
        }
        public void Download(File file)
        {
            Console.WriteLine("Downloading file '{0}'...",file.Title);
            Thread.Sleep(4000);

            //step 3.1
            OnFileDownloaded(file);
        }
    }
}
