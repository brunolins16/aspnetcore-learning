using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.RC1.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel() : this(null)
        {}

        public ProductViewModel(Models.Product product)
        {
            if(product != null)
            {
                this.Id = product.Id;
                this.Name = product.Name;
                this.Value = product.Value;
            }
        }

        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public decimal Value { get; set; }

        public int Qty { get; set; }

        public decimal TotalCost { get { return Value * Qty; } }
    }
}
