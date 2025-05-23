using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public interface Document
    {
        string fileName { get; set; }
        void generate();
    }

    public class WordDocument : Document 
    {
        public string fileName { get; set; }
        public void generate() 
        {
            Console.WriteLine("Generating a Word document: " + fileName + ".docx");
        }
    }
    public class PDFDocument : Document
    {
        public string fileName { get; set; }
        public void generate()
        {
            Console.WriteLine("Generating a PDF document: " + fileName + ".pdf");
        }
    }
    public class TextDocument : Document
    {
        public string fileName { get; set; }
        public void generate()
        {
            Console.WriteLine("Generating a Text document: " + fileName + ".txt");
        }
    }
    public class HTMLDocument : Document
    {
        public string fileName { get; set; }
        public void generate()
        {
            Console.WriteLine("Generating an HTML document: " + fileName + ".html");
        }
    }

    public abstract class DocumentFactory
    {
        public abstract Document createDocument();
        public void produceDocument(String fileName)
        {
            Document document = createDocument();
            document.fileName = fileName;
            document.generate();
        }
    }

    public class WordDocumentFactory : DocumentFactory
    {
        public override Document createDocument()
        {
            return new WordDocument();
        }
    }

    public class PDFDocumentFactory : DocumentFactory
    {
        public override Document createDocument()
        {
            return new PDFDocument();
        }
    }

    public class TextDocumentFactory : DocumentFactory
    {
        public override Document createDocument()
        {
            return new TextDocument();
        }
    }

    public class HTMLDocumentFactory : DocumentFactory
    {
        public override Document createDocument()
        {
            return new HTMLDocument();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method Document Demo:\n");

            new WordDocumentFactory().produceDocument("report");
            Console.WriteLine("\n");
            new PDFDocumentFactory().produceDocument("report");
            Console.WriteLine("\n");
            new TextDocumentFactory().produceDocument("report");
            Console.WriteLine("\n");
            new HTMLDocumentFactory().produceDocument("report");
        }
    }
}
