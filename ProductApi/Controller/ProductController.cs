using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace ProductApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            string responseData; 

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://dummyjson.com/products";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    responseData = await response.Content.ReadAsStringAsync();
                 
                }
                else
                {
                    responseData = "Yanlış bağlanma isteği";
                }
            }

            return Ok(responseData);
        }
        [HttpGet("getbyıd")]
        public async Task<IActionResult> GetAById([FromQuery]int id)
        {
            string responseData;

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://dummyjson.com/products/{id}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    responseData = await response.Content.ReadAsStringAsync();

                }
                else
                {
                    responseData = "Yanlış bağlanma isteği";
                }
            }

            return Ok(responseData);
        }
        [HttpGet("getbysearch")]
        public async Task<IActionResult> GetABySearch([FromQuery] string search)
        {
            string responseData;

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://dummyjson.com/products/search?q={search}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    responseData = await response.Content.ReadAsStringAsync();

                }
                else
                {
                    responseData = "Yanlış bağlanma isteği";
                }
            }

            return Ok(responseData);
        }
        [HttpGet("categories")]
        public async Task<IActionResult> GetAllCategory()
        {
            string responseData;

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://dummyjson.com/products/categories";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    responseData = await response.Content.ReadAsStringAsync();

                }
                else
                {
                    responseData = "Yanlış bağlanma isteği";
                }
            }

            return Ok(responseData);
        }
        [HttpGet("getbycategory")]
        public async Task<IActionResult> GetByCategory([FromQuery] string query)
        {
            string responseData;

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"https://dummyjson.com/products/category/{query}";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    responseData = await response.Content.ReadAsStringAsync();

                }
                else
                {
                    responseData = "Yanlış bağlanma isteği";
                }
            }

            return Ok(responseData);
        }
    }
}
