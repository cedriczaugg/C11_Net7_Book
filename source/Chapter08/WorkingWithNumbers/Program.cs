// See https://aka.ms/new-console-template for more information

using System.Numerics;

WriteLine("Working with large integers:");
WriteLine("-----------------------------------");
var big = ulong.MaxValue;
WriteLine($"{big,40:N0}");
var bigger =
    BigInteger.Parse("123456789012345678901234567890");
WriteLine($"{bigger,40:N0}");

WriteLine("Working with complex numbers:");
Complex c1 = new(4, 2);
Complex c2 = new(3, 7);
var c3 = Complex.Add(c1, c2);
// output using default ToString implementation
WriteLine($"{c1} added to {c2} is {c3}");
// output using custom format
WriteLine("{0} + {1}i added to {2} + {3}i is {4} + {5}i",
    c1.Real, c1.Imaginary,
    c2.Real, c2.Imaginary,
    c3.Real, c3.Imaginary);

// Generating ramdom numbers
Random r = new(94875);

var rStatic = Random.Shared;

// minValue is an inclusive lower bound i.e. 1 is a possible value
// maxValue is an exclusive upper bound i.e. 7 is not a possible value
var dieRoll = r.Next(1, 7); // returns 1 to 6
var randomReal = r.NextDouble(); // returns 0.0 to less than 1.0
var arrayOfBytes = new byte[256];
r.NextBytes(arrayOfBytes); // 256 random bytes in an array