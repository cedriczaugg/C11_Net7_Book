// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.NetworkInformation;

Write("Enter a valid web address (or press Enter): ");
var url = ReadLine();
if (string.IsNullOrWhiteSpace(url)) // if they enter nothing...
    // ... set a default URL
    url = "http://etach-scqptestadmin.swatchgroup.net/";
// url = "https://stackoverflow.com/search?q=securestring";
Uri uri = new(url);
WriteLine($"URL: {url}");
WriteLine($"Scheme: {uri.Scheme}");
WriteLine($"Port: {uri.Port}");
WriteLine($"Host: {uri.Host}");
WriteLine($"Path: {uri.AbsolutePath}");
WriteLine($"Query: {uri.Query}");

var entry = Dns.GetHostEntry(uri.Host);
WriteLine($"{entry.HostName} has the following IP addressed:");
foreach (var address in entry.AddressList) WriteLine($"   {address} ({address.AddressFamily})");

try
{
    Ping ping = new();
    WriteLine("Pinging server. Please wait...");
    var reply = ping.Send(uri.Host);
    WriteLine($"{uri.Host} was pinged and replied: {reply.Status}.");
    if (reply.Status == IPStatus.Success)
        WriteLine("Reply from {0} took {1:N0}ms",
            reply.Address,
            reply.RoundtripTime);
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}