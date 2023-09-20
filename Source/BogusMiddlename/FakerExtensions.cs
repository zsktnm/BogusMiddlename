namespace BogusMiddlename
{
    public static class FakerExtensions
    {
        private static int _lastIndex = -1;
        private static PersonWithMiddlename _lastPerson = null!;


        /// <summary>
        /// Gets PersonWithMiddlename with new Middlename field. 
        /// Also adds Middlename to Fullname property.
        /// Generate middlenames for locales, which includes XXX_middle_name in Bogus datasets.
        /// </summary>
        public static PersonWithMiddlename PersonWithMiddlename(this Faker faker)
        {
            if (_lastIndex == faker.IndexGlobal)
            {
                return _lastPerson;
            }

            _lastIndex = faker.IndexGlobal;
            _lastPerson = new PersonWithMiddlename(faker.Locale);

            return _lastPerson;
        }
    }
}
