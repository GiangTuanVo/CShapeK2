using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace BuildClass.SolidDesignPrinciples
{
    
    /*
     Single Responsibility Principle
        - A class should only have one reason to change
        - Separation of concerns - different classes handling different, independent
    */
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
        //public void Save(string filename)
        //{
        //    File.WriteAllText(filename, ToString());
        //}
        //public static Journal Load(string filename)
        //{

        //}
        //public void Load(Uri uri)
        //{

        //}
    }

    public class Persistence
    {
        public void SaveToFile(Journal j, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
            {
                File.WriteAllText(filename, j.ToString());
            }
        }
    }

    /*
      Open_Close Principle
        - Classes should be open for extension but closed for modification
     */
    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public enum Size
    {
        Small,
        Medium,
        Large,
        Yuge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if (name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }

            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
                if (p.Size == size && p.Color == color)
                    yield return p;
        }

        //Different ways
        public List<Product> FilterBySize(List<Product> products, Color color, Size size)
        {
            List<Product> product = new List<Product>();
            foreach (var item in products)
                if (item.Size == size)
                    product.Add(item);
            return product;
        }
    }

    //New method
    public interface ISpeccification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpeccification<T> spec);
    }

    public class ColorSpecification : ISpeccification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }

    public class SizeSpecification : ISpeccification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }

    public class AndSpecification<T> : ISpeccification<T>
    {
        private ISpeccification<T> first, second;

        public AndSpecification(ISpeccification<T> first, ISpeccification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpeccification<Product> spec)
        {
            foreach (var item in items)
                if (spec.IsSatisfied(item))
                    yield return item;
        }
    }

    /*
      Liskov substitution principle(Nguyên tắc thay thế )
        - You should be able to substitute a base type for a subtype
     */
    public class Rectang
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public Rectang()
        {
        }

        public Rectang(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    public class Square : Rectang
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
    /*
      Interface Segregation Principle
        - Don't put too much in to interface; split into separate interface
        - YAGNI - You Ain't Going to Need it
     */
    public class Document
    {


    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultiFuntionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //
        }

        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }

    public class OldFlasionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            //
        }

        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScaner
    {
        void Scan(Document d);
    }

    public class Photocopier : IPrinter, IScaner
    {
        public void Print(Document d)
        {
            //
        }

        public void Scan(Document d)
        {
            //
        }
    }

    public interface IMultiFuntionDevice : IScaner, IPrinter
    {

    }

    public class MultiFuntionMachine : IMultiFuntionDevice
    {
        private IPrinter printer;
        private IScaner scaner;

        public MultiFuntionMachine(IPrinter printer, IScaner scaner)
        {
            this.printer = printer ?? throw new ArgumentNullException(nameof(printer));
            this.scaner = scaner ?? throw new ArgumentNullException(nameof(scaner));
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scaner.Scan(d);
        }//decorator
    }

    /*
      Dependency Inversion Principle
        - High-Level modules should not depend upon low-level ones, use abstractions
     */
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Persons
    {
        public string Name;
        //public DateTime DateOfBirth;
    }

    public interface IRelationshipBrowser
    {
        IEnumerable<Persons> FindAllChildren(string name);
    }
    //public class Relationships:IRelationshipBrowser
    //{
    //    private List<(Persons, Relationship, Persons)> relations =
    //        new List<(Persons, Relationship, Persons)>();

    //    public void AddParentAndChild(Persons parent, Persons child)
    //    {
    //        relations.Add((parent,Relationship.Parent,child));
    //        relations.Add((child,Relationship.Child,parent));
    //    }
    //    //Different Ways
    //    public IEnumerable<Persons> FindAllChildren(string name)
    //    {
    //        foreach (var r in relations.Where(x => x.Item1.Name == name &&
    //                                               x.Item2 == Relationship.Parent))
    //        {
    //            yield return r.Item3;
    //        }
    //    }

    //    //public List<(Persosn, Relationship, Persosn)> Relations => relations;
    //}
    class Program
    {
        //public Program(Relationships relationships)
        //{
        //    var relations = relationships.Relations;
        //    foreach (var r in relations.Where(x=>x.Item1.Name=="John" &&
        //                                         x.Item2==Relationship.Parent))
        //    {
        //        WriteLine($"John has a child called {r.Item3.Name}");
        //    }
        //}
        public Program(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildren("John"))
            {
                WriteLine($"John has a child called {p.Name}");
            }
        }

        static public int Area(Rectang r) => r.Width * r.Height;

        //static void Main(string[] args)
        //{
        //    //var j = new Journal();
        //    //j.AddEntry("I sad today");
        //    //j.AddEntry("I bored today");
        //    //Console.WriteLine(j);

        //    //string path = Environment.CurrentDirectory + "\\journal.txt";
        //    //var p = new Persistence();
        //    //p.SaveToFile(j, path, true);
        //    //Process.Start(path);

        //    //var apple = new Product("Apple", Color.Green, Size.Small);
        //    //var tree = new Product("Tree", Color.Green, Size.Large);
        //    //var house = new Product("House", Color.Blue, Size.Large);
        //    //Product[] products = { apple, tree, house };
        //    //var pf = new ProductFilter();
        //    //WriteLine("Green products (old):");
        //    //foreach (var item in pf.FilterByColor(products, Color.Green))
        //    //{
        //    //    WriteLine($"- {item.Name} is green");
        //    //}

        //    //var bf = new BetterFilter();
        //    //WriteLine("Green products (new):");
        //    //foreach (var item in bf.Filter(products,new ColorSpecification(Color.Green)))
        //    //{
        //    //    WriteLine($"- {item.Name} is green");
        //    //}

        //    //WriteLine("Large blue items:");
        //    //foreach (var item in bf.Filter(products,
        //    //    new AndSpecification<Product>(new ColorSpecification(Color.Blue),new SizeSpecification(Size.Large))))
        //    //{
        //    //    WriteLine($"- {item.Name} is big and blue");
        //    //}

        //    //Rectang rc = new Rectang(3, 4);
        //    //WriteLine($"{rc} has area {Area(rc)}");
        //    //Square sq = new Square();
        //    //sq.Width = 4;
        //    //WriteLine($"{sq} has area {Area(sq)}");
            
        //    var parent = new Persons { Name = "John" };
        //    var child1 = new Persons { Name = "Chris" };
        //    var child2 = new Persons { Name = "Mary" };

        //    var relationships = new Relationships();
        //    relationships.AddParentAndChild(parent,child1);
        //    relationships.AddParentAndChild(parent, child2);
        //    new Program(relationships);
        //    ReadKey();
        //}
    }
}