using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Code
{
    public interface IRepository
    {
        IEnumerable<Inquiry> GetInquiries();

        Inquiry GetTopInquiry();
 
        void SaveInquiry(Inquiry inquiry);
    }
}