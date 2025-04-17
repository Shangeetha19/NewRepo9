using System;
using Insurance.dao;
using Insurance.entity;
using Insurance.exception;

namespace Insurance.main
{
    // Entry point of the Insurance Management System
    public class MainModule
    {
        // Interface reference to service implementation
        private static IPolicyService service = new InsuranceServiceImpl();

        public static void Main(string[] args)
        {
            Console.WriteLine("=== Insurance Management System ===");
            bool running = true;

            // Menu-driven loop
            while (running)
            {
                Console.WriteLine("\n1. Add Client\n2. View All Clients\n3. Get Client By ID\n4. Update Client\n5. Delete Client\n6. Exit");
                Console.Write("Choice: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        AddClient(); // Add new client
                        break;
                    case "2":
                        foreach (var c in service.GetAllPolicies())
                            Console.WriteLine(c); // Display all clients
                        break;
                    case "3":
                        Console.Write("Client ID: ");
                        try
                        {
                            Console.WriteLine(service.GetPolicy(int.Parse(Console.ReadLine()))); // Get client by ID
                        }
                        catch (PolicyNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message); // Handle custom exception
                        }
                        break;
                    case "4":
                        UpdateClient(); // Update client info
                        break;
                    case "5":
                        Console.Write("Client ID: ");
                        service.DeletePolicy(int.Parse(Console.ReadLine())); // Delete client
                        break;
                    case "6":
                        running = false; // Exit loop
                        break;
                }
            }
        }

        // Handles input and adds a client
        private static void AddClient()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Contact: ");
            string contact = Console.ReadLine();
            Console.Write("Policy: ");
            string policy = Console.ReadLine();
            service.CreatePolicy(new Client { ClientName = name, ContactInfo = contact, Policy = policy });
        }

        // Handles input and updates a client
        private static void UpdateClient()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("New Name: ");
            string name = Console.ReadLine();
            Console.Write("New Contact: ");
            string contact = Console.ReadLine();
            Console.Write("New Policy: ");
            string policy = Console.ReadLine();
            service.UpdatePolicy(new Client(id, name, contact, policy));
        }
    }
}