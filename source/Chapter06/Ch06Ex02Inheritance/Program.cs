// See https://aka.ms/new-console-template for more information

using Ch06Ex02Inheritance;

var r = new Rectangle(width: 4.5, height: 3);
WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}");

var s = new Square(5);
WriteLine($"Square H: {s.Height}, W: {s.Width}, Area: {s.Area}");

Circle c = new(2.5);
WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area: {c.Area}");