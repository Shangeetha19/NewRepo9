using System;

namespace Insurance.entity
{
    // Represents a payment made by a client
    public class Payment
    {
        // Unique ID for the payment
        public int PaymentId { get; set; }

        // Date when the payment was made
        public DateTime PaymentDate { get; set; }

        // Amount of the payment
        public double PaymentAmount { get; set; }

        // The client who made the payment
        public Client Client { get; set; }

        // Default constructor
        public Payment() { }

        // Parameterized constructor to initialize all fields
        public Payment(int paymentId, DateTime paymentDate, double paymentAmount, Client client)
        {
            PaymentId = paymentId;
            PaymentDate = paymentDate;
            PaymentAmount = paymentAmount;
            Client = client;
        }

        // Returns a string representation of the payment details
        public override string ToString() =>
            $"PaymentId: {PaymentId}, Date: {PaymentDate}, Amount: {PaymentAmount}, Client: {Client.ClientName}";
    }
}
