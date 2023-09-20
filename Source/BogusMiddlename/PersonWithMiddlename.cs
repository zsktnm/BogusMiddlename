namespace BogusMiddlename
{
    public class PersonWithMiddlename : Person
    {
        public string? MiddleName;

        public PersonWithMiddlename(string locale = "en") : base(locale)
        {
        }

        protected override void Populate()
        {
            base.Populate();
            MiddleName = DsName.Middlename(Gender);
            FullName = $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
