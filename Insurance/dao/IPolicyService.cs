using System.Collections.Generic;
using Insurance.entity;

namespace Insurance.dao
{
    // Interface defining operations related to insurance policies (clients)
    public interface IPolicyService
    {
        // Add a new client policy
        bool CreatePolicy(Client client);

        // Retrieve a policy by client ID
        Client GetPolicy(int clientId);

        // Get all client policies
        List<Client> GetAllPolicies();

        // Update an existing policy
        bool UpdatePolicy(Client client);

        // Delete a policy by client ID
        bool DeletePolicy(int clientId);
    }
}

