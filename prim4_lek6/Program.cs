// See https://aka.ms/new-console-template for more information
using System.Collections;

ArrayList list = new ArrayList();
list.Add(2.3); // заносимо до списку об'єкт типу double
list.Add(55); // заносимо до списку об'єкт типу int
//заносимо до списку об'єкт  масив рядків
list.AddRange(new string[] { "Hello", "world" }); 
Console.WriteLine("Перебор");
// перебор значень
foreach (object o in list)
{ Console.WriteLine(o); }
// видаляємо перший елемент
list.RemoveAt(0);
// реверсуємо список
list.Reverse();
// Отримання елементу за індексом
Console.WriteLine("Виведення за індексом");
Console.WriteLine(list[0]);
// перебор значень
Console.WriteLine("Перебор після видалення");
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
