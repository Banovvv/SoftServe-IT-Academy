using System;

namespace SoftServe_IT_Academy.Practice._Interfaces._Generics
{
    public enum ColourEnum
    {
        Red,
        Green,
        Blue
    }

    public interface IColoured
    {
        public ColourEnum Colour => ColourEnum.Red;
    }

    public interface IDocument
    {
        public static string defaultText = "Lorem ipsum";

        public int Pages { get; set; }
        public string Name { get; set; }

        public void AddPages(int number)
        {
            Pages += number;
        }
        public void Rename(string name)
        {
            Name = name;
        }
    }

    public class ColouredDocument : IColoured, IDocument
    {
        public ColouredDocument()
        {
        }
        public ColouredDocument(ColourEnum colour)
        {
            Colour = colour;
        }

        public string Name { get; set; }
        public int Pages { get; set; }
        public ColourEnum Colour { get; set; }
    }

    public class Example
    {
        public static void Do()
        {
            ColouredDocument doc1 = new ColouredDocument()
            {
                Name = "Document1"
            };

            Console.WriteLine($"{doc1.Name}");
            ((IDocument)doc1).Rename("Document2");
            Console.WriteLine($"{doc1.Name}");
        }
    }
}
