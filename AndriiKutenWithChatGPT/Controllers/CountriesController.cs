namespace RestCountriesApi.Controllers
{
    using System.Net.Http;
    using System.Net.Http.Json;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    namespace RestCountriesApi.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CountriesController : ControllerBase
        {
            private readonly HttpClient _httpClient;

            public CountriesController(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            [HttpGet]
            public async Task<IActionResult> GetCountries(string param1 = null, int? param2 = null, string param3 = null)
            {
                var response = await _httpClient.GetAsync("https://restcountries.com/v3.1/all");

                if (response.IsSuccessStatusCode)
                {
                    var countries = await response.Content.ReadFromJsonAsync<object[]>();
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
