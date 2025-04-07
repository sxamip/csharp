// create a simple class named person that contains basic information like name, age, gernder, etc 
using System;

class Person
{
    string name, gender;
    int age;

    // Constructor
    public Person(string name, string gender, int age)
    {
        this.name = name;
        this.gender = gender;
        this.age = age;
    }

    
    public void display()
    {
        Console.WriteLine($"Your name is {name}, age is {age} and gender is {gender}");
    }

    static void Main(string[] args)
    {
        Person p = new Person("Samip", "Male", 24);
        p.display();
    }
}

