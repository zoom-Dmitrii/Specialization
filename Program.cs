void Find(string[] text){

text = Array.FindAll(text, i => i.Length <= 3).ToArray();
        Console.WriteLine(String.Join(",", text));
}

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string[] arrayText = Console.ReadLine().Split(" ").ToArray();
Find(arrayText);