namespace SwitchExpressionExample
{
   using global::SwitchExpressionExample.SwitchExpressionExample;
   using System;
   using System.Collections.Generic;

   namespace SwitchExpressionExample
   {
      public abstract class Shape
      {
         public abstract double Area { get; }
      }

      public class Circle : Shape
      {
         public double Radius { get; set; }
         public override double Area => Math.PI * Radius * Radius;
      }

      public class Rectangle : Shape
      {
         public double Width { get; set; }
         public double Height { get; set; }
         public override double Area => Width * Height;
      }

      public class Triangle : Shape
      {
         public double Base { get; set; }
         public double Height { get; set; }
         public override double Area => 0.5 * Base * Height;
      }

      public class Polygon : Shape
      {
         public List<(double X, double Y)> Vertices { get; set; }
         public override double Area
         {
            get
            {
               // Simple polygon area calculation (Shoelace formula)
               double area = 0;
               int j = Vertices.Count - 1;
               for (int i = 0; i < Vertices.Count; i++)
               {
                  area += (Vertices[j].X + Vertices[i].X) * (Vertices[j].Y - Vertices[i].Y);
                  j = i;
               }
               return Math.Abs(area / 2);
            }
         }
      }
   }

   public static class ShapeHelper
   {
      public static string GetShapeDescription(Shape shape) => shape switch
      {
         Circle { Radius: > 0 } c => $"Circle with radius {c.Radius}",
         Rectangle { Width: > 0, Height: > 0 } r => $"Rectangle with width {r.Width} and height {r.Height}",
         Triangle { Base: > 0, Height: > 0 } t => $"Triangle with base {t.Base} and height {t.Height}",
         Polygon { Vertices: { Count: > 0 } } p => $"Polygon with {p.Vertices.Count} vertices",
         _ => "Unknown shape or invalid dimensions"
      };

      public static string GetShapeType(Shape shape) => shape switch
      {
         Circle => "Circle",
         Rectangle => "Rectangle",
         Triangle => "Triangle",
         Polygon { Vertices: { Count: > 0 } } => "Polygon",
         _ => "Unknown shape"
      };
   }

   public static class PatternOrderExample
   {
      public static string GetNumberDescription(object number) => number switch
      {
         int n when n > 0 => "Positive integer",
         int n => "Integer", // This pattern makes the previous pattern unreachable
         double d when d > 0 => "Positive double",
         double d => "Double",
         _ => "Unknown type"
      };
   }
}