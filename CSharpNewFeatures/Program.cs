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