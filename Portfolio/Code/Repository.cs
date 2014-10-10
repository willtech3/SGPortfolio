using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Portfolio.Models;

namespace Portfolio.Code
{
    public class Repository : IRepository
    {
        private readonly InquiryContext _dbContext;
        public Repository(InquiryContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<Inquiry> GetInquiries()
        {
            return _dbContext.Inquiries;
        }

        public Inquiry GetTopInquiry()
        {
            return _dbContext.Inquiries.FirstOrDefault();
        }

        public void SaveInquiry(Inquiry inquiry)
        {
            _dbContext.Inquiries.Add(inquiry);
        }
    }
}