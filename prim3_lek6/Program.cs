// See https://aka.ms/new-console-template for more information
using prim3_lek6.Class;

var dog = new Dog("Рада", "рижа", new DateOnly(2019, 3, 9));
var cat = new Cat("Барсик", "білий та рижий", new DateOnly(2020, 12, 5));
var fish=new Fish("Семен", "золотий", new DateOnly(2023, 12, 5));
var parrot = new Parrot("Попка", "червоний", new DateOnly(2023, 11, 15));
Console.WriteLine(dog.info() + " \n" + dog.run() + "\n "
    + dog.speak() + "\n " + dog.guard());
Console.WriteLine(cat.info() + " \n" + cat.run() + "\n "
    + cat.speak() + "\n " + cat.bringMouse());
Console.WriteLine(fish.info() + " \n" + fish.sweam());
    Console.WriteLine(parrot.info() + " \n" + parrot.fly() + "\n "
    + parrot.speak() );
Pet pet = new Cat("Барон", "білий ", new DateOnly(2020, 12, 5));
pet.info();
