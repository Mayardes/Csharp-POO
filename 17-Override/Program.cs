using System;
using System.Collections.Generic;

namespace _17_Override
{
    public class File
    {
        public string Name;
        public int Size;

        public virtual void OpenFile()
        {
            Console.WriteLine("Opening file " + Name);
        }
    }
    public class Music : File
    {
        public override void OpenFile()
        {
            Console.WriteLine("Playing music " + Name);
        }
    }
    public class DocWord : File
    {
        public override void OpenFile()
        {
            Console.WriteLine("Opening docword " + Name);
        }
    }
    public class Image : File
    {
        public override void OpenFile()
        {
            Console.WriteLine("Viewing image " + Name);
        }
    }
    public class Txt: File
    {
        public override void OpenFile()
        {
            base.OpenFile();
        }
    }
    public class Windows
    {
        private List<File> _files;

        public Windows()
        {
            this._files = new List<File>();
        }

        public void Add(File file)
        {
            this._files.Add(file);
        }

        public void Open(File file)
        {
            file.OpenFile();
        }

        public void OpenAll()
        {
            foreach (File file in _files)
            {
                Open(file);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            File mp3 = new Music()
            {
                Name = "Dream Theater - Illumination Theory",
                Size = 152
            };
            File doc = new DocWord()
            {
                Name = ".net Magazine",
                Size = 8842
            };
            File img = new Image()
            {
                Name = "Golden Gate Bridge",
                Size = 84
            };
            File txt = new Txt()
            {
                Name = "Buy list",
                Size = 877
            };


            Windows windows = new Windows();

            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);
            windows.Add(txt);

            windows.Open(mp3);
            windows.Open(doc);
            windows.Open(img);
            windows.Open(txt);

            windows.OpenAll();


        }
    }
}
