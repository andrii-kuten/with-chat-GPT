namespace AndriiKutenWithChatGPT
{
    public static class Functions
    {
        public static List<Country> FilterCountries(List<Country> countries, string query)
        {
            query = query.ToLower();
            List<Country> result = new List<Country>();

            foreach (var country in countries)
            {
                if (country.Name.Common.ToLower().Contains(query))
                {
                    result.Add(country);
                }
            }

            return result;
        }

        public static List<Country> FilterCountriesByPopulation(List<Country> countries, double? populationLimit)
        {
            return countries.Where(c => !populationLimit.HasValue || c.Population < 1000000*populationLimit).ToList();
        }
    }
}
