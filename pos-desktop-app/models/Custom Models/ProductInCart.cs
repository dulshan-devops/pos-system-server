using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_desktop_app.models.Custom_Models
{
    public class ProductInCart
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }

        // Read-only properties to format Price and Total as currency

        public string PriceFormatted
        {
            get
            {
                CultureInfo sriLankanCulture = new CultureInfo("si-LK");
                return Price.ToString("C", sriLankanCulture);
            }
        }

        public string TotalFormatted
        {
            get
            {
                CultureInfo sriLankanCulture = new CultureInfo("si-LK");
                return Total.ToString("C", sriLankanCulture);
            }
        }
    }
}
