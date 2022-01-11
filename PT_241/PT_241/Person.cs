using System;
using System.Collections.Generic;
using System.Text;


public abstract class Person
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public void SayName()
    {
        Console.WriteLine(firstName + lastName);
    }
}


