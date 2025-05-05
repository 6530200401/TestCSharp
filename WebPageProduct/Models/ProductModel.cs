using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebPageProduct.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }

    public class ProductModelV2
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
}
