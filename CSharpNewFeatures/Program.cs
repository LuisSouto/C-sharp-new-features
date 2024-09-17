using CSharpNewFeatures;


#region var vs new

// Type + variableName = new(args)
var listWithVar = new List<string>() { "var" };
List<string> listWithNew = new() { "new" };

var myClassVar = new MyCustomClass();
MyCustomClass myClassNew = new();
MyCustomClass myClassWithName = new("someName");

#endregion var vs new