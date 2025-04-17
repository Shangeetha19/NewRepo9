using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Insurance.entity;
using Insurance.exception;
using Insurance.util;

namespace Insurance.dao
{
    // Implementation of the IPolicyService interface for handling client/policy-related DB operations
    public class InsuranceServiceImpl : IPolicyService
    {
        // Establish a database connection using the utility class
        private SqlConnection conn = DBConnUtil.GetConnection();

        /// <summary>
        /// Adds a new client record to the Clients table.
        /// </summary>
        public bool CreatePolicy(Client client)
        {
            string query = "INSERT INTO Clients (ClientName, ContactInfo, Policy) VALUES (@name, @contact, @policy)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", client.ClientName);
            cmd.Parameters.AddWithValue("@contact", client.ContactInfo);
            cmd.Parameters.AddWithValue("@policy", client.Policy);
            return cmd.ExecuteNonQuery() > 0; // Returns true if insert is successful
        }

        /// <summary>
        /// Retrieves a client based on their ClientId.
        /// </summary>
        public Client GetPolicy(int clientId)
        {
            string query = "SELECT * FROM Clients WHERE ClientId = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", clientId);
            SqlDataReader reader = cmd.ExecuteReader();

            // If a client record is found, create a Client object and return it
            if (reader.Read())
            {
                Client client = new Client(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                );
                reader.Close();
                return client;
            }

            reader.Close();
            // If not found, throw a custom exception
            throw new PolicyNotFoundException($"Policy with ID {clientId} not found.");
        }

        /// <summary>
        /// Retrieves all client records from the Clients table.
        /// </summary>
        public List<Client> GetAllPolicies()
        {
            List<Client> clients = new List<Client>();
            string query = "SELECT * FROM Clients";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                clients.Add(new Client(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                ));
            }

            reader.Close();
            return clients;
        }

        /// <summary>
        /// Updates an existing client record in the Clients table.
        /// </summary>
        public bool UpdatePolicy(Client client)
        {
            string query = "UPDATE Clients SET ClientName=@name, ContactInfo=@contact, Policy=@policy WHERE ClientId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", client.ClientId);
            cmd.Parameters.AddWithValue("@name", client.ClientName);
            cmd.Parameters.AddWithValue("@contact", client.ContactInfo);
            cmd.Parameters.AddWithValue("@policy", client.Policy);
            return cmd.ExecuteNonQuery() > 0; // Returns true if update is successful
        }

        /// <summary>
        /// Deletes a client from the Clients table by ClientId.
        /// </summary>
        public bool DeletePolicy(int clientId)
        {
            string query = "DELETE FROM Clients WHERE ClientId=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", clientId);
            return cmd.ExecuteNonQuery() > 0; // Returns true if deletion is successful
        }
    }
}
