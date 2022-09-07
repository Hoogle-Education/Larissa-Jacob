using Car_Rental_Service.Domain;
using Car_Rental_Service.Services;
using System.Globalization;

namespace Car_Rental_Service {
    public class Program {
        public static void Main() {
            Vehicle v = new Vehicle("Ford");

            DateTime start = DateTime.ParseExact("01/01/22 14:30", "dd/MM/yy HH:mm", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact("02/01/22 16:40", "dd/MM/yy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, end, v);

            RentalService rentalService = new RentalService(20.0, 60.0, new BrasilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine(carRental.Invoice.TotalPayment);
        }
    }
}