using System;
using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Code
{
    public class InquiryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<InquiryContext>
    {
        protected override void Seed(InquiryContext context)
        {
            var inquiries = new List<Inquiry>()
            {
                new Inquiry()
                {
                    DateTime = DateTime.Now,
                    Description = "Test",
                    Email = "william.west.lane@gmail.com",
                    FirstName = "William",
                    LastName = "Lane"
                },
                new Inquiry()
                {
                    DateTime = DateTime.Now,
                    Description = "Test",
                    Email = "sethgardner@gmail.com",
                    FirstName = "Seth",
                    LastName = "Gardner"
                }
            };
            inquiries.ForEach(i => context.Inquiries.Add(i));
            context.SaveChanges();
        }
    }
}