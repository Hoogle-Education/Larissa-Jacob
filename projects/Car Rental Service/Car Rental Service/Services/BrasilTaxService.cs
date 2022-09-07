using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Service.Services {
    public class BrasilTaxService : ITaxService {

        public double Tax(double amount) {

            if (amount > 100.0) {
                return 0.15 * amount;
            }

            return 0.20 * amount;
        }
    }
}
