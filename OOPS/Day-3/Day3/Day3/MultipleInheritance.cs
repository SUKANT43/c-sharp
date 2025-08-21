using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    interface Ireadable
    {
        void Read();
    }

    interface Iwritable
    {
        void Write();
    }

    class File : Ireadable, Iwritable
    {
        public void Read()
        {
            Console.WriteLine("Reading from file...");
        }

        public void Write()
        {
            Console.WriteLine("Writing the file....");
        }
    }

    class Disp2
    {
        public static void disp2()
        {
            File myFile = new File();
            myFile.Read();
            myFile.Write();
        }
    }
}
