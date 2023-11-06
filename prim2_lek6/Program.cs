// See https://aka.ms/new-console-template for more information
using prim2_lek6.Class;

var dog = new Dog("Рада", "рижа", new DateOnly(2019,3,9));
var cat = new Cat("Барсик", "білий та рижий", new DateOnly(2020, 12, 5));
Console.WriteLine(dog.info()+ " \n" + dog.run()+ "\n "
    +  dog.speak()+ "\n " + dog.guard());
Console.WriteLine(cat.info() + " \n" + cat.run() + "\n "
    + cat.speak() + "\n " + cat.bringMouse());
Pet pet = new Cat("Барон", "білий ", new DateOnly(2020, 12, 5));
pet.run();