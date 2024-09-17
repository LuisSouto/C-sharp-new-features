using System;

namespace SwitchExpressionExample
{
   public static class DayTypeHelper
   {
      public static string GetDayTypeWithStatement(DayOfWeek day)
      {
         switch (day)
         {
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
               return "Weekend";
            case DayOfWeek.Monday:
            case DayOfWeek.Tuesday:
            case DayOfWeek.Wednesday:
            case DayOfWeek.Thursday:
            case DayOfWeek.Friday:
               return "Weekday";
            default:
               throw new ArgumentOutOfRangeException(nameof(day), $"Not expected day value: {day}");
         }
      }

      public static string GetDayType(DayOfWeek day) => day switch
      {
         DayOfWeek.Saturday => "Weekend",
         DayOfWeek.Sunday => "Weekend",
         DayOfWeek.Monday => "Weekday",
         DayOfWeek.Tuesday => "Weekday",
         DayOfWeek.Wednesday => "Weekday",
         DayOfWeek.Thursday => "Weekday",
         DayOfWeek.Friday => "Weekday",
         _ => throw new ArgumentOutOfRangeException(nameof(day), $"Not expected day value: {day}")
      };
   }
}