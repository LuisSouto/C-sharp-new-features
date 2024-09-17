using System;

namespace CSharpFeaturesExample
{
   // 1. Interface with default implementations
   public interface IShape
   {
      double Area { get; }
      string Description => $"Shape with area {Area}";

      // Default method implementation
      void Display()
      {
         Console.WriteLine(Description);
      }
   }

   // 2. Standard implementation of the interface
   public class Circle : IShape
   {
      public double Radius { get; set; }
      public double Area => Math.PI * Radius * Radius;
      public string Description => $"Circle with radius {Radius} and area {Area}";
   }

   public class Rectangle : IShape
   {
      public double Width { get; set; }
      public double Height { get; set; }
      public double Area => Width * Height;
      public string Description => $"Rectangle with width {Width}, height {Height}, and area {Area}";
   }

   // 3. Record with primary constructor
   public record Triangle(double Base, double Height) : IShape
   {
      public double Area => 0.5 * Base * Height;
      public string Description => $"Triangle with base {Base}, height {Height}, and area {Area}";
   }

   static class RunExamples
   {
      static void Main()
      {
         Console.WriteLine("C# Features Example:");

         // 4. Using ??= syntax for null-coalescing assignment
         IShape shape = null;
         shape ??= new Circle { Radius = 5 };
         shape.Display();
         Console.WriteLine($"Area: {shape.Area}");

         shape = null;
         shape ??= new Rectangle { Width = 4, Height = 6 };
         shape.Display();
         Console.WriteLine($"Area: {shape.Area}");

         shape = null;
         shape ??= new Triangle(3, 4);
         shape.Display();
         Console.WriteLine($"Area: {shape.Area}");
      }
   }
}