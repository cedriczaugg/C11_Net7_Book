﻿using CallStackExceptionHandlingLib;
using static System.Console;

WriteLine("In Main.");

Alpha();

void Alpha()
{
    WriteLine("In Alpha.");
    Beta();

    void Beta()
    {
        WriteLine("In Beta.");
        Calculator.Gamma();
    }
}