using System;

namespace SwitchExpressionExample
{
   public static class ListPatternExample
   {
      public static string GetListDescription(int[] numbers) => numbers switch
      {
      [1, 2, 3] => "List contains exactly 1, 2, 3",
      [1, .., 3] => "List starts with 1 and ends with 3",
      [_, _, _] => "List contains exactly three elements",
      [_, ..] => "List contains at least one element",
      [] => "List is empty",
         _ => "Unknown pattern" //The pattern matching is already exaustive
      };

      static void Main()
      {
         Console.WriteLine("List Pattern Matching Example:");

         int[][] lists = new int[][]
         {
               new int[] { 1, 2, 3 },
               new int[] { 1, 4, 5, 3 },
               new int[] { 7, 8, 9 },
               new int[] { 42 },
               new int[] { }
         };

         bool isListOneTwoThree = lists[0] is [1, 2, 3];

         foreach (var list in lists)
         {
            var description = GetListDescription(list);
            Console.WriteLine($"[{string.Join(", ", list)}]: {description}");
         }
      }
   }
}