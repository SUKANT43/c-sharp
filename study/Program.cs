using System;
public class Program
{
    static void Main(string[] args)
    {
        /* data types:
         DataTypes a = new DataTypes();
         a.print();
         */

        //  string demo
        // StringDemo b = new StringDemo();
        // b.print();


        // numbers demo
        // NumbersDemo c = new NumbersDemo();
        // c.print();

        // user input demo
        // UserInput d = new UserInput();
        // d.print();

        // arrays demo
        // ArraysDemo e = new ArraysDemo();
        // e.print();

        // exception handling demo
        // ExceptionHandlingDemo f = new ExceptionHandlingDemo();
        // f.print();

        // class and object demo
        // ClassAndObjectDemo sukant = new ClassAndObjectDemo("Sukant", "Intel i7", "NVIDIA RTX 3080", 16, 512);
        // sukant.pc();

        Chef demo = new Chef();
        demo.MakeChicken();
        demo.MakeSalad();
        demo.MakeSpecialDish();
        ItalianChef it = new ItalianChef();
        it.MakeChicken();
        it.MakeSalad();
        it.MakeSpecialDish();

    }
}