using Bogus;
using BogusMiddlename;

var people = new Faker<GenerateFullnameExample.Person>("ru")
    .RuleFor(person => person.Fullname, f => f.PersonWithMiddlename().FullName)
    .RuleFor(person => person.Age, f => f.Random.Number(18, 90))
    .Generate(25);

foreach (var person in people)
{
    Console.WriteLine($"{person.Fullname};{person.Age}");
}