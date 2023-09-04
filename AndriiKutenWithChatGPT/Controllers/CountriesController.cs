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
            public async Task<IActionResult> GetCountries(string country = null, int? param2 = null, string param3 = null)
            {
                var response = await _httpClient.GetAsync("https://restcountries.com/v3.1/all");

                if (response.IsSuccessStatusCode)
                {
                    var countries = await response.Content.ReadFromJsonAsync<List<Country>>() ?? new List<Country>();

                    if (string.IsNullOrEmpty(country)) 
                    {
                        return Ok(countries);
                    }

                    var filteredCountries = Functions.FilterCountries(countries, country);

                    return Ok(filteredCountries);
                }
                else
                {
                    return StatusCode((int)response.StatusCode, response.ReasonPhrase);
                }
            }
        }
    }

}
