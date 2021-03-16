using System;
using System.Collections.Generic;
using System.Text;

namespace product_manager {
    class Software {

        public String Version { get; set; }

        public Software() { }

        public Software(string code, string desc, double price, string version) :
            base(code, desc, price) }

            this.Version = version;
        }



        public override string ToString() {
            return base.ToString() + $"Software: {Version}";
        }
    }
}
