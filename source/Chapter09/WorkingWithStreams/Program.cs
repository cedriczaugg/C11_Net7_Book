// See https://aka.ms/new-console-template for more information

using System.Xml;
using WorkingWithStreams;
using static System.Environment;
using static System.IO.Path;

SectionTitle("Writing to text streams");

// Define a file to write to
var textFile = Combine(CurrentDirectory, "streams.txt");

// Create a text file and return a helper writer
var text = File.CreateText(textFile);

// Enumerate the strings, writing each one to the stream on a separate line
foreach (var item in Viper.Callsigns) text.WriteLine(item);
text.Close();

// output the contents of the file
WriteLine("{0} contains {1:N0} bytes.",
    textFile,
    new FileInfo(textFile).Length);
WriteLine(File.ReadAllText(textFile));

SectionTitle("Writing to XML streams");

// Define a file path to write to
var xmlFile = Combine(CurrentDirectory, "streams.xml");

// Declare variables for the filestream and XML writer
FileStream? xmlFileStream = null;
XmlWriter? xml = null;

try
{
    // Create a file in an XML writer helper
    // and automatically ident nested elements
    xml = XmlWriter.Create(xmlFile, new XmlWriterSettings { Indent = true });

    // Write the XML declaration
    xml.WriteStartDocument();

    // Write a root element
    xml.WriteStartElement("Callsigns");

    // Enumerate the strings, writing each one to the stream
    foreach (var item in Viper.Callsigns) xml.WriteElementString("Callsign", item);

    // write the close root element
    xml.WriteEndElement();

    // Close helper and stream
    xml.Close();
    xmlFileStream.Close();
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
finally
{
    if (xml != null)
    {
        xml.Dispose();
        WriteLine("The XML writer's unmanaged resources have been disposed.");
    }

    if (xmlFileStream != null)
    {
        xmlFileStream.Dispose();
        WriteLine("The file stream's unmanaged resources have been disposed.");
    }
}

// Output all the contents of the file
WriteLine("{0} contains {1:N0} bytes.", xmlFile, new FileInfo(xmlFile).Length);
WriteLine(File.ReadAllText(xmlFile));

SectionTitle("Compressing streams");
Compress("gzip");
Compress("brotli");