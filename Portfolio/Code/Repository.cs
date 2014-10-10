using System.Collections.Generic;
using System.Linq;
using Portfolio.Models;

namespace Portfolio.Code
{
    public class Repository : IRepository
    {
        private readonly InquiryContext _context;

        public Repository(InquiryContext context)
        {
            _context = context;
        }

        public IEnumerable<Inquiry> GetInquiries()
        {
            return _context.Inquiries;
        }

        public Inquiry GetTopInquiry()
        {
            return _context.Inquiries.FirstOrDefault();
        }

        public void SaveInquiry(Inquiry inquiry)
        {
            _context.Inquiries.Add(inquiry);
            _context.SaveChanges();
        }
    }
}