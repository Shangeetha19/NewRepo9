using System;

namespace Insurance.entity
{
    // Represents an insurance claim made by a client
    public class Claim
    {
        // Unique identifier for the claim
        public int ClaimId { get; set; }

        // Claim number reference
        public string ClaimNumber { get; set; }

        // Date the claim was filed
        public DateTime DateFiled { get; set; }

        // Amount being claimed
        public double ClaimAmount { get; set; }

        // Current status of the claim (e.g., Pending, Approved)
        public string Status { get; set; }

        // Policy under which the claim is made
        public string Policy { get; set; }

        // Associated client who filed the claim
        public Client Client { get; set; }

        // Default constructor
        public Claim() { }

        // Parameterized constructor to initialize all fields
        public Claim(int claimId, string claimNumber, DateTime dateFiled, double claimAmount,
                     string status, string policy, Client client)
        {
            ClaimId = claimId;
            ClaimNumber = claimNumber;
            DateFiled = dateFiled;
            ClaimAmount = claimAmount;
            Status = status;
            Policy = policy;
            Client = client;
        }

        // Returns a string representation of the claim details
        public override string ToString() =>
            $"ClaimId: {ClaimId}, ClaimNumber: {ClaimNumber}, Date: {DateFiled}, Amount: {ClaimAmount}, Status: {Status}, Policy: {Policy}, Client: {Client.ClientName}";
    }
}


