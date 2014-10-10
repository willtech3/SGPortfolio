using Portfolio.Models;

namespace Portfolio.Code
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InquiryContext : DbContext
    {
        // Your context has been configured to use a 'InquiryContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Portfolio.Code.InquiryContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'InquiryContext' 
        // connection string in the application configuration file.
        public InquiryContext()
            : base("name=InquiryContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Inquiry> Inquiries { get; set; }
    }
}