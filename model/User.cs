using System;

public class User
{
    private long id;
    private string firstname;
    private int age;

    private static int idTemp = 0;

    public User() { }

    public User(string firstname, int age)
    {
        idTemp++;
        this.id = idTemp;
        this.firstname = firstname;
        this.age = age;
    }

    public void introducingMyself()
    {
        Console.WriteLine("Hello, my Id is {0}. My name is {1} and my age is {2}", this.id, this.firstname, this.age);
    }
}
