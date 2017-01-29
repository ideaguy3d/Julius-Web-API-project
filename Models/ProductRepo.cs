using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json; 
using System.Web.Hosting; 

namespace WebApp1.Models
{
    /// <summary>
    /// This class will store data in a local json file.
    /// </summary>
    public class ProductRepo
    {
        /// <summary>
        /// This function will create a new Product w/default vals.  
        /// </summary>
        /// <returns></returns>
        internal Product Create()
        {
            var product = new Product { ReleaseDate = DateTime.Now };
            return product; 
        }

        internal List<Product> Retrieve()
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/product.json");
            var json = System.IO.File.ReadAllText(filePath);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products; 
        }
    }
}