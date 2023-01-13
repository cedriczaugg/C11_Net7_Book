// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

// namespace WorkingWithJson;

using System.Text.Json.Serialization;

public class Book
{
    public Book(string title)
    {
        Title = title;
    }

    // Properties
    public string Title { get; set; }
    public string? Author { get; set; }
    
    // Fields
    [JsonInclude] public DateTime PublishDate;
    [JsonInclude] public DateTimeOffset Created;

    public ushort Pages;
}