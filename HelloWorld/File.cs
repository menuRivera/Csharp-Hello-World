using System;
using System.Collections.Generic;
using System.Text;

namespace helloWorld
{
    class File
    {
        public string Title { get; set; }
    }
    class FileEventArgs : EventArgs
    {
        //Using the EventArgs class and adding the File class to it
        //So we can use a File object within the EventArgs class
        public File File { get; set; }
    }
}
