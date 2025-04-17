namespace Insurance.entity
{
    // Represents a client entity in the insurance system
    public class Client
    {
        // Unique ID for the client
        public int ClientId { get; set; }

        // Name of the client
        public string ClientName { get; set; }

        // Contact information (e.g., phone or email)
        public string ContactInfo { get; set; }

        // Policy information related to the client
        public string Policy { get; set; }

        // Default constructor
        public Client() { }

        // Parameterized constructor to initialize all properties
        public Client(int clientId, string clientName, string contactInfo, string policy)
        {
            ClientId = clientId;
            ClientName = clientName;
            ContactInfo = contactInfo;
            Policy = policy;
        }

        // Overrides ToString to provide a readable string representation
        public override string ToString() =>
            $"ClientId: {ClientId}, Name: {ClientName}, Contact: {ContactInfo}, Policy: {Policy}";
    }
}
