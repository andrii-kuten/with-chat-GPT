using NUnit.Framework;

namespace AndriiKutenWithChatGPT
{
    [TestFixture]
    public class CountryMethodsTests
    {
        [Test]
        public void TestFilterCountries()
        {
            // Arrange
            List<Country> countries = new List<Country>
            {
                new Country { Name = new Name { Common = "India" }, Population = 1393409038 },
                new Country { Name = new Name { Common = "Australia" }, Population = 25687041 }
            };

            string query = "au";

            // Act
            var result = Functions.FilterCountries(countries, query);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Australia", result[0].Name.Common);
        }

        [Test]
        public void TestFilterCountriesByPopulation()
        {
            // Arrange
            List<Country> countries = new List<Country>
            {
                new Country { Name = new Name { Common = "India" }, Population = 1393409038 },
                new Country { Name = new Name { Common = "Australia" }, Population = 25687041 }
            };

            double? populationLimit = 500; // 500 million

            // Act
            var result = Functions.FilterCountriesByPopulation(countries, populationLimit);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("Australia", result[0].Name.Common);
        }

        [Test]
        public void TestSortCountries()
        {
            // Arrange
            List<Country> countries = new List<Country>
            {
                new Country { Name = new Name { Common = "India" }, Population = 1393409038 },
                new Country { Name = new Name { Common = "Australia" }, Population = 25687041 }
            };

            string sortAttribute = "descend";

            // Act
            Functions.SortCountries(countries, sortAttribute);

            // Assert
            Assert.AreEqual("India", countries[0].Name.Common);
            Assert.AreEqual("Australia", countries[1].Name.Common);
        }

        [Test]
        public void TestGetPaginatedCountries()
        {
            // Arrange
            List<Country> countries = new List<Country>
            {
                new Country { Name = new Name { Common = "India" }, Population = 1393409038 },
                new Country { Name = new Name { Common = "Australia" }, Population = 25687041 },
                new Country { Name = new Name { Common = "USA" }, Population = 331893745 }
            };

            int limit = 2;

            // Act
            var result = Functions.GetPaginatedCountries(countries, limit);

            // Assert
            Assert.AreEqual(2, result.Count);
        }
    }

}
