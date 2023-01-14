// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

using System.Xml.Serialization;

namespace Packt.Shared;

public class Person
{
    public Person()
    {
    }

    public Person(decimal initialSalary)
    {
        Salary = initialSalary;
    }

    [XmlAttribute("fname")] public string? FirstName { get; set; }

    [XmlAttribute("lname")] public string? LastName { get; set; }

    [XmlAttribute("dob")] public DateTime DateOfBirth { get; set; }

    public HashSet<Person> Children { get; set; }
    public decimal Salary { get; set; }
}