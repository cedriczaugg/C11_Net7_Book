// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

namespace Packt.Shared;

public class PersonException : Exception
{
    public PersonException()
    {
    }

    public PersonException(string message) : base(message)
    {
    }

    public PersonException(string message, Exception innerException) : base(message, innerException)
    {
    }
}