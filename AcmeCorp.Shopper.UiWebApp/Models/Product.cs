using System.Text.Json.Serialization;

namespace AcmeCorp.Shopper.UiWebApp
{
    public class Product
    {
        [JsonPropertyName("Product_Id")]
        public string? ProductId { get; set; }

        [JsonPropertyName("Product_Name")]
        public string? ProductName { get; set; }

        [JsonPropertyName("Product_Price")]
        public decimal ProductPrice { get; set; }

        public override string ToString()
        {
            return $"Product [ id={ProductId}, name={ProductName}, price={ProductPrice.ToString()} ]";
        }
    }


}