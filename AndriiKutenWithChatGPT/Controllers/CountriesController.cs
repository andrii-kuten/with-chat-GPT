namespace RestCountriesApi.Controllers
{
    using System.Net.Http;
    using System.Net.Http.Json;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using AndriiKutenWithChatGPT;

    namespace RestCountriesApi.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CountriesController : ControllerBase
        {
            private readonly HttpClient _httpClient = new HttpClient();

            public CountriesController()
            {
            }

            [HttpGet]
            public async Task<IActionResult> GetCountries(string? country = null, int? population = null, string sortOrder = "ascend", int? limit = null)
            {
                var response = await _httpClient.GetAsync("https://restcountries.com/v3.1/all");

                if (response.IsSuccessStatusCode)
                {
                    var countries = await response.Content.ReadFromJsonAsync<List<Country>>() ?? new List<Country>();

                    if (!string.IsNullOrEmpty(country)) 
                    {
                        countries = Functions.FilterCountries(countries, country);
                    }

                    countries = Functions.FilterCountriesByPopulation(countries, population);

                    Functions.SortCountries(countries, sortOrder);

                    if (limit.HasValue) 
                    {
                        countries = Functions.GetPaginatedCountries(countries, limit.Value);
                    }

                    return Ok(countries);
                }
                else
                {
                    return StatusCode((int)response.StatusCode, response.ReasonPhrase);
                }
            }
        }
    }

}
