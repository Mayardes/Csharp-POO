using System;

namespace _26_MultiplesInterfaces
{
    public interface IStoreable
    {
        void ToRead();
        void ToWrite();
    }
    public interface ICompressible
    {
        void ToCompress();
        void ToUnzip();
    }
    public abstract class Properties
    {
        public string Name { get; set; }
    }
    public class Document : Properties, IStoreable, ICompressible
    {
        public void ToCompress()
        {
            Console.WriteLine("Compressing file..." + Name);
        }

        public void ToRead()
        {
            Console.WriteLine("Reading file..." + Name);
        }

        public void ToUnzip()
        {
            Console.WriteLine("unziping file...");
        }

        public void ToWrite()
        {
            Console.WriteLine("Writing file...");
        }
    }
    public class Image : Properties, IStoreable
    {
        public void ToRead()
        {
            Console.WriteLine("Reading file..." + Name);
        }
        public void ToWrite()
        {
            Console.WriteLine("Writing file..." + Name);
        }
    }

    public class FileDisk
    {
        public void Info()
        {
            Console.WriteLine("Information about my FileDisk");
        }
    }
    public class File : Properties, ICompressible, IStoreable
    {
        //C# don't support multiples inheritance. In this case, can use black box;
        //by delegation, we can call method from another class

        private FileDisk fileDisk;
        public File()
        {
            this.fileDisk = new FileDisk();
            fileDisk.Info();
        }
        public void ToCompress()
        {
            Console.WriteLine("Compressing file..." + Name);
        }

        public void ToRead()
        {
            Console.WriteLine("Reading a file..." + Name);
        }

        public void ToUnzip()
        {
            Console.WriteLine("ToUnziping a file..." + Name);
        }

        public void ToWrite()
        {
            Console.WriteLine("ToUnzip a Writing..." + Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document() { Name = "Article.docx" };
            doc.ToRead();
            doc.ToWrite();

            Image image = new Image();
            image.ToRead();
            image.ToWrite();

            var file = new File() { Name ="curriculo vitar"};
            file.ToRead();
            file.ToWrite();
        }
    }
}
