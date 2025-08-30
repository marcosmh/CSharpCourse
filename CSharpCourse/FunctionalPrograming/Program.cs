
Operation mySum = Functions.Sum;

//Console.WriteLine(mySum(10, 20));
mySum = Functions.Mul;
//Console.WriteLine(mySum(2, 3));


//Show show = Functions.ConsoleShow;
Show cw = Console.WriteLine;
//cw += Functions.ConsoleShow;
//cw("Hola Mundo");

//Functions.Some("Anakin", "Skywalker",cw);

#region Action

/*
string hi = "Hola";
Action<string> showMessage = Console.WriteLine;
Action<string, string> ShowMessage2 = (a, b) =>
{
    Console.WriteLine($"{hi} {a} {b}");
};

Action<string, string, string> ShowMessage3 = (a, b, c)
    => Console.WriteLine($"{a} {b} {c}");


ShowMessage2("Han", "Solo");
ShowMessage3("Luke", "Skywalker", "Jedi");
Functions.SomeAction("Esra", "Bridger", (a) =>
{
    Console.WriteLine("Soy una expresion lambda " + a);
});
*/

//showMessage("Hola Dev");
//Functions.SomeAction("Luke","Skywalker",showMessage);

#endregion


#region Func

Func<int> numberRandom = () => new Random().Next(0, 30);
Func<int, int> numberRandomLimit = (limit) => new Random().Next(0, limit);
Func<int, string> numberRandomLimit2 = (limit) => new Random().Next(0, limit).ToString();

//Console.WriteLine(numberRandom());
//Console.WriteLine(numberRandomLimit(90));

#endregion

#region Predicate

Predicate<string> hasSpaceOrA = (word) => word.Contains(" ") || word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceOrA("Hola Mundo"));
Console.WriteLine(hasSpaceOrA("p ati to"));

var words = new List<string>()
{
    "beer",
    "patito",
    "sandia",
    "Hola Mundo",
    "c#"
};


var wordsNew = words.FindAll(hasSpaceOrA);
var wordsNew2 = words.FindAll( (w) => !hasSpaceOrA(w));

foreach (var w in wordsNew) Console.WriteLine(w);
Console.WriteLine("----------------------");
foreach (var w in wordsNew2) Console.WriteLine(w);


#endregion

// Delegados
#region Delegados
delegate int Operation(int a, int b);
public delegate void Show(string message);
#endregion

public class Functions
{
    public static int Sum(int x, int y) => x + y;

    public static int Mul(int num1, int num2) => num1 * num2;

    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("Hago algo  al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo  al final");
    }

    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Hago algo  al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo  al final");
    }

}