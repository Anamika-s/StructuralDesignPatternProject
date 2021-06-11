using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatternDemos
{
    // Step 1: Create an interface.
    public interface Shape
    {
        void draw();
    }

    // Step 2: Create concrete classes implementing the same interface. 
    public class Rectangle : Shape
    {
         
   public void draw()
    {
        Console.WriteLine("Rectangle::draw()");
    }
} 
public class Square : Shape
{
     
   public void draw()
{
    Console.WriteLine("Square::draw()");
}
} 
public class Circle : Shape
{

    public void draw()
{
    Console.WriteLine("Circle::draw()");
}
}
  // Step 3: Create a facade class.
    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        }
    }
    // Use the facade to draw various types of shapes.
    public class FacadePatternDemo
    {
        public static void Main(String[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
        }
    }
}
