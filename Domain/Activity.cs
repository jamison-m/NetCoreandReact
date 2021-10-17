using System;

namespace Domain
{
    public class Activity
    {

        // public property so anyone can access getter and setter\
        // Advantage of using Guid is that if we do create the id on the client side then we dont need to wait for the DB to create the id for us and send it back.
        // Provides a layer of abstraction from database as well
        public Guid Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string City { get; set; }

        public string Venue { get; set; }
    }
}
