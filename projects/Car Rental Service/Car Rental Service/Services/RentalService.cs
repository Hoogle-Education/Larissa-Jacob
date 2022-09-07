using Car_Rental_Service.Domain;

namespace Car_Rental_Service.Services {
    public class RentalService {

        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental) {

            TimeSpan duration = carRental.End.Subtract(carRental.Start);

            double basicPayment = 0.0, taxPayment = 0.0;

            if (duration.TotalHours <= 12.0) {
                basicPayment = Math.Ceiling(duration.TotalHours) * PricePerHour;
            } else {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
            }

            taxPayment = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, taxPayment);
        }

    }
}
