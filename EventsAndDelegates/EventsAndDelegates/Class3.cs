using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class FileEventArgs : EventArgs
    {
        public string FileName { get; }
        public FileEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }

    // Publisher
    public class FileUploader
    {
        // Step 2: Declare event with EventHandler<T>
        public event EventHandler<FileEventArgs> FileUploaded;

        // Step 3: Raise event
        public void Upload(string fileName)
        {
            Console.WriteLine($"Uploading {fileName}...");

            // Step 4: Invoke event safely
            FileUploaded?.Invoke(this, new FileEventArgs(fileName));
        }
    }

    // Subscriber
    public class Logger
    {
        public void OnFileUploaded(object sender, FileEventArgs e)
        {
            Console.WriteLine($"[Logger] File uploaded: {e.FileName}");
        }
    }

    public class Program
    {
        public static void Main()
        {
            FileUploader uploader = new FileUploader();
            Logger logger = new Logger();

            // Subscribe
            uploader.FileUploaded += logger.OnFileUploaded;

            // Trigger event
            uploader.Upload("report.pdf");
            Console.ReadLine();
        }
    }
}
