using Bogus;
using BogusMiddlename;
using GenerateExample;

int id = 1;
Faker<User> faker = new Faker<User>("ru")
    .RuleFor(user => user.Id, r => id++)
    .RuleFor(user => user.Name, r => r.PersonWithMiddlename().FirstName)
    .RuleFor(user => user.Surname, r => r.PersonWithMiddlename().LastName)
    .RuleFor(user => user.Patronymic, r => r.PersonWithMiddlename().MiddleName)
    .RuleFor(user => user.Email, r => r.PersonWithMiddlename().Email);

foreach (User user in faker.Generate(25))
{
    Console.WriteLine(user);
}