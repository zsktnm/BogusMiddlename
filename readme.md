# BogusMiddlename

Provides extension methods for [Bogus](https://link-url-here.org) library to generate middlenames. Uses internal Bogus datasets. 
For locals which doesn't contains data for middlenames, firstnames will used as middlenames.

# Install

You can obtain this package by **[Nuget](https://www.nuget.org/packages/BogusMiddlename)** 

# Usage

## Single values

You can use the `Name` property with extension method `Middlename`:
```csharp
var faker = new Faker("ru");
Console.WriteLine(faker.Name.Middlename());
```

## Generate person

You can use `PersonWithMiddlename` extension method.  

With single values:
```csharp
var faker = new Faker<User>("ru")
    .RuleFor(user => user.Firstname, f => f.PersonWithMiddlename().FirstName)
    .RuleFor(user => user.Lastname, f => f.PersonWithMiddlename().LastName)
    .RuleFor(user => user.Middlename, f => f.PersonWithMiddlename().MiddleName);

foreach (User user in faker.Generate(25))
{
    Console.WriteLine($"{user.Firstname} {user.Middlename} {user.Lastname}");
}
```
With fullname:
```csharp
var faker = new Faker<User>("ru")
    .RuleFor(user => user.Fullname, f => f.PersonWithMiddlename().FullName);

foreach (User user in faker.Generate(25))
{
    Console.WriteLine(user.Fullname);
}
```
