using System;

namespace Insurance.entity
{
    // Represents an insurance policy associated with a client
    public class Policy
    {
        // Unique ID for the policy
        public int PolicyId { get; set; }

        // Name or type of the policy (e.g., LifePlus, HealthSecure)
        public string PolicyName { get; set; }

        // Description or additional details about the policy
        public string Description { get; set; }

        // Total amount covered under the policy
        public double CoverageAmount { get; set; }

        // Date when the policy was issued
        public DateTime IssueDate { get; set; }

        // Expiry date of the policy
        public DateTime ExpiryDate { get; set; }

        // Default constructor
        public Policy() { }

        // Parameterized constructor
        public Policy(int policyId, string policyName, string description, double coverageAmount, DateTime issueDate, DateTime expiryDate)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            Description = description;
            CoverageAmount = coverageAmount;
            IssueDate = issueDate;
            ExpiryDate = expiryDate;
        }

        // String representation of the policy object
        public override string ToString()
        {
            return $"PolicyId: {PolicyId}, Name: {PolicyName}, Coverage: {CoverageAmount}, Issued: {IssueDate.ToShortDateString()}, Expires: {ExpiryDate.ToShortDateString()}";
        }
    }
}


