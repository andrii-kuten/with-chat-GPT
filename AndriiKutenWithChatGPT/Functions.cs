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

        public static void SortCountries(List<Country> countries, string sortAttribute)
        {
            if (sortAttribute.ToLower() == "ascend")
            {
                countries.Sort((x, y) => string.Compare(x.Name.Common, y.Name.Common));
            }
            else if (sortAttribute.ToLower() == "descend")
            {
                countries.Sort((x, y) => string.Compare(y.Name.Common, x.Name.Common));
            }
            else
            {
                throw new Exception("Invalid sort attribute. Please use 'ascend' or 'descend'.");
            }
        }

        public static List<Country> GetPaginatedCountries(List<Country> countries, int limit)
        {
            if (limit < 1)
            {
                throw new ArgumentException("The limit should be at least 1");
            }
            
            return countries.Count > limit ? countries.Take(limit).ToList() : countries;
        }
    }
}
