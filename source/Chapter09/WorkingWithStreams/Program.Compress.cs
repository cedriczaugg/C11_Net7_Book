// <copyright file="Program.cs">
// Copyright (c)  ETA Manufacture Horlogère Suisse SA. All rights reserved.
// </copyright>

// namespace WorkingWithStreams;

// BrotliStream, GZipStream, CompressionMode
// XmlWriter, XmlReader

using System.IO.Compression;
using System.Xml;
using WorkingWithStreams;
using static System.Environment; // CurrentDirectory
using static System.IO.Path; // Combine

internal partial class Program
{
    private static void Compress(string algorithm = "gzip")
    {
        // Define a file path using algorithm as file extension
        var filePath = Combine(CurrentDirectory, $"streams.{algorithm}");

        var file = File.Create(filePath);
        Stream compressor;
        if (algorithm == "gzip")
            compressor = new GZipStream(file, CompressionMode.Compress);
        else
            compressor = new BrotliStream(file, CompressionMode.Compress);

        using (compressor)
        {
            using (var xml = XmlWriter.Create(compressor))
            {
                xml.WriteStartDocument();
                xml.WriteStartElement("callsigns");
                foreach (var item in Viper.Callsigns) xml.WriteElementString("callsign", item);
            }
        } // also closes the underlying stream

        // output all the contents of the compressed file
        WriteLine("{0} contains {1:N0} bytes.",
            filePath, new FileInfo(filePath).Length);
        WriteLine("The compressed contents:");
        WriteLine(File.ReadAllText(filePath));
        // read a compressed file
        WriteLine("Reading the compressed XML file:");
        file = File.Open(filePath, FileMode.Open);
        Stream decompressor;
        if (algorithm == "gzip")
            decompressor = new GZipStream(
                file, CompressionMode.Decompress);
        else
            decompressor = new BrotliStream(
                file, CompressionMode.Decompress);
        using (decompressor)

        using (var reader = XmlReader.Create(decompressor))

        {
            while (reader.Read())
                // check if we are on an element node named callsign
                if (reader.NodeType == XmlNodeType.Element
                    && reader.Name == "callsign")
                {
                    reader.Read(); // move to the text inside element
                    WriteLine($"{reader.Value}"); // read its value
                }
        }
    }
}