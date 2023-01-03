using System.Diagnostics;
using Microsoft.Extensions.Configuration;

var logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

WriteLine($"Write log to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));

Trace.Listeners.Add(logFile);

Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says: I am watching!");

WriteLine("Reading from appsettings.json in {0}", Directory.GetCurrentDirectory());

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json", true, true);

var configutation = builder.Build();

TraceSwitch ts = new(
    "PacktSwitch",
    "This switch is set via a JSON config.");

configutation.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLine(ts.TraceError, "Trace error");
Trace.WriteLine(ts.TraceWarning, "Trace warning");
Trace.WriteLine(ts.TraceInfo, "Trace information");
Trace.WriteLine(ts.TraceVerbose, "Trace verbose");

Console.ReadLine();