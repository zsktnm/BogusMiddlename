namespace BogusMiddlename
{
    public static class NameExtensions
    {
        /// <summary>
        /// Gets middlename.         
        /// Generate middlenames for locales, which includes XXX_middle_name in Bogus datasets.
        /// </summary>
        /// <param name="gender">Gender: Male or Female. Random gender, if null (default value)</param>
        /// <returns>String with person's middlename</returns>
        /// <exception cref="NotSupportedException">Throws when locale doesn't contains middlename data</exception>
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
                throw new NotSupportedException($"Locale {name.Locale} doesn't contains middlename data" );
            }

            return name.Random.ArrayElement((BArray)middlenames);
        }
    }
}