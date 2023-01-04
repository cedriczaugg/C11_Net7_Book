using Packt.Shared;

Person bob = new();
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 12);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.Children.Add(new Person { Name = "Alfred" }); // C# 3.0 and later
bob.Children.Add(new Person { Name = "Zoe" }); // C# 9.0 and later

WriteLine("{0} was born on {1:dddd, d MMMM yyyy}",
    bob.Name,
    bob.DateOfBirth);
WriteLine(
    "{0}'s favorite wonder is {1}. Its integer is {2}.",
    bob.Name,
    bob.FavoriteAncientWonder,
    (int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach (var child in bob.Children) WriteLine($"> {child.Name}");
WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");


Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new DateTime(1998, 3, 7) // C# 9.0 or later
};
WriteLine("{0} was born on {1:dd MMM yy}",
    alice.Name,
    alice.DateOfBirth);

BankAccount.InterestRate = 0.012M; // store a shared value
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;
WriteLine("{0} earned {1:C} interest.",
    jonesAccount.AccountName,
    jonesAccount.Balance * BankAccount.InterestRate);
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;
WriteLine("{0} earned {1:C} interest.",
    gerrierAccount.AccountName,
    gerrierAccount.Balance * BankAccount.InterestRate);

Person blankPerson = new();
WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    blankPerson.Name,
    blankPerson.HomePlanet,
    blankPerson.Instantiated);

// Book book = new()
// {
//     Isbn = "978-1802327800",
//     Title = "C# book"
// };

Book book = new("978-1802327800",
    "C# book")
{
    Author = "Mark J. Price",
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
    book.Isbn, book.Title, book.Author, book.PageCount);

Passenger[] passengers =
{
    new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" }
};
foreach (var passenger in passengers)
{
    var flightCost = passenger switch
    {
        // FirstClassPassenger p when p.AirMiles > 35000 => 1500M, 
        // FirstClassPassenger p when p.AirMiles > 15000 => 1750M, 
        // FirstClassPassenger _ => 2000M,
        FirstClassPassenger { AirMiles: > 35000 } => 1500,
        FirstClassPassenger { AirMiles: > 15000 } => 1750M,
        FirstClassPassenger => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}