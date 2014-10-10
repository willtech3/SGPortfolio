using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Portfolio.Code
{
    public class UnitOfWork : IUnitOfWork
    {
        private InquiryContext _dbContext;

        public UnitOfWork(InquiryContext context)
        {
            _dbContext = context;
        }
        public IRepository Repository { get; set; }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}