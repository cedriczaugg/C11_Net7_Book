﻿// See https://aka.ms/new-console-template for more information

WriteLine("I can run everywhere!");
WriteLine($"OS Version is {Environment.OSVersion}.");
if (OperatingSystem.IsMacOS())
    WriteLine("I am macOS.");
else if (OperatingSystem.IsWindowsVersionAtLeast(10, build:
             22000))
    WriteLine("I am Windows 11.");
else if (OperatingSystem.IsWindowsVersionAtLeast(10))
    WriteLine("I am Windows 10.");
else
    WriteLine("I am some other mysterious OS.");
WriteLine("Press ENTER to stop me.");
ReadLine();