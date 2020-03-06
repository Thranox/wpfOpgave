using System;

public class Person
{
    private string name;
    private int age;
    private int weight;
    public Person(string name, int age, int weight)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
    }
    public Person(string s)
    {
        int resAge;
        int resWeight;
        String[] data = s.Split(';');
        this.name = data[0];
        int.TryParse(data[1], out resAge);
        this.age = resAge;
        int.TryParse(data[2], out resWeight);
        this.weight = resWeight;

    }
    public String Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    public override String ToString()
    {
        return $"Name: {this.name} age: {this.age} weight: {this.weight}";
    }
