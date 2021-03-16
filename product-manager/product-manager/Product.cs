using System;
using System.Collections.Generic;
using System.Text;

namespace product_manager {
    class Product {
         public String Code { get; set; }
         public String Description { get; set; }
         public double Price { get; set; }


        public Product() {

        }

        public Product(String code, String desc, double price) {
            this.Code = code;
            this.Description = desc;
            this.Price = price;
        }




        public override string ToString() {
            return $"Product: {Code}, {Description}, {Price.ToString("C")}";
        }

    }
}
