﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApi.Domain.Models;
using WebApi.Services;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        //private Product product;

        // GET api/values
        [HttpGet]
        //     public ActionResult<IEnumerable<Product>> Get()
        //     //public IEnumerable<Product> Get()
        //     {



        //         //return new Product[] { product }.ToArray();
        //         return Enumerable.Range(1, 17).Select(index => new Product
        //         {
        //             //Name = product.Name,
        //             //Context = product.Context,
        //             //CategoryId = product.CategoryId
        //         })
        //.ToArray();


        public IActionResult Get()
        {
            var model = new Product()
            {
                Name = "a",
                Context = "Test",
                CategoryId =1
            };

            return new ObjectResult(model);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]

        //public void Post([FromBody] string value)
        //{
        //    ProductServices productServices = new ProductServices();
        //productServices.abc(value);
        //}
        //public void Index([FromBody] JsonElement body)
        //{

        //    string json = System.Text.Json.JsonSerializer.Serialize(body);
        ////return Ok("hii");
        //ProductServices productServices = new ProductServices();
        //    productServices.abc(json);



        //}
        public string JsonStringBody([FromBody] JsonElement content)
        {
            //ProductServices productServices = new ProductServices();
            string json = System.Text.Json.JsonSerializer.Serialize(content);
            //productServices.abc(json);
            List<Product> product = new List<Product>();


            product.Add(new Product { Name = "ab" });
            var w = new Product() { Name = json, Context = "Hot" };
            //Console.WriteLine(JsonSerializer.Serialize<Product>(w));
            return JsonSerializer.Serialize<Product>(w);

        }
        //[HttpPost]
        //public IActionResult CreateDocument([FromBody] Product model)
        //{

        //    return new ObjectResult(model);
        //}



        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}