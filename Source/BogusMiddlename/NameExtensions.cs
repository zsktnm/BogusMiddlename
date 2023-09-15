namespace BogusMiddlename
{
    public static class NameExtensions
    {
        /// <summary>
        /// Gets middlename.         
        /// Generate middlenames for locales, which includes XXX_middle_name in Bogus datasets.
        /// Other locales gets Firstname as Middlename
        /// </summary>
        /// <param name="gender">Gender: Male or Female. Random gender, if null (default value)</param>
        /// <returns>String with person's middlename</returns>
        public static string Middlename(this Name name, Name.Gender? gender = null)
        {
            if (gender is null)
            {
                gender = name.Random.Enum<Name.Gender>();
            }

            BValue middlenames;
            if (gender == Name.Gender.Male)
            {
                middlenames = Bogus.Database.Get("name", "male_middle_name", name.Locale);
            }
            else
            {
                middlenames = Bogus.Database.Get("name", "female_middle_name", name.Locale);
            }

            if (middlenames is null)
            {
                return name.FirstName(Name.Gender.Male);
            }

            return name.Random.ArrayElement((BArray)middlenames);
        }
    }
}