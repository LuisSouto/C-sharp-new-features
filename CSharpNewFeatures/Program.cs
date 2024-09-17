using CSharpNewFeatures;


#region var vs new

// Type + variableName = new(args)
var listWithVar = new List<string>() { "var" };
List<string> listWithNew = new() { "new" };

var myClassVar = new MyCustomClass();
MyCustomClass myClassNew = new();
MyCustomClass myClassWithName = new("someName");

#endregion var vs new

#region Initialization with []

List<double> emptyList = [];
List<double> nonEmptyList = [2.1, 3.3, 34544354231.1];

double[] emptyArray = [];
double[] nonEmptyArray = [1, 3, 4, 0];

Dictionary<string, double> emptyDict = [];
Dictionary<string, double> nonEmptyDict = new() { ["red"] = 10, ["blue"] = 15, ["green"] = 20 };

#endregion Initialization with []

#region Concatenation of collections

List<string> fruits = ["Apple", "Banana", "Strawberry"];
List<string> vegetables = ["Onion", "Eggplant", "Lettuce"];
List<string> groceries = [.. fruits, .. vegetables, "Chocolate"];
Console.WriteLine("Grocery list: " + string.Join(", ", groceries));

double[] gradesGroup1 = [6, 6, 7];
double[] gradesGroup2 = [8, 7, 9];
double[] totalGrades = [.. gradesGroup1, .. gradesGroup2];
double[] forgotOneGrade = [.. gradesGroup1, 10, .. gradesGroup2];
Console.WriteLine("Grades: " + string.Join(", ", forgotOneGrade));

#endregion Concatenation of collections