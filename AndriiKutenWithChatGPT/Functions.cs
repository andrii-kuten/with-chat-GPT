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
    }
}
