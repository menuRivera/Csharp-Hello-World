using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("'{0}' downloaded\n",e.File.Title);
        }
        public void OnFileUnpacked(object source, FileEventArgs e)
        {
            Console.WriteLine("'{0}' unpacked\n", e.File.Title);
        }
    }
}
