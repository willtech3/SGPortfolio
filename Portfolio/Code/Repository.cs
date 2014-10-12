using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Ajax.Utilities;
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
            inquiry.DateTime = DateTime.Now;
            _dbContext.Entry(inquiry).State = inquiry.InquiryID == 0 ? EntityState.Added : EntityState.Modified;
            _dbContext.Inquiries.Add(inquiry);
            _dbContext.SaveChanges();
        }
    }
}