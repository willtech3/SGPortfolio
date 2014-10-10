using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace Portfolio.Code
{
    public interface IUnitOfWork
    {
        IRepository Repository { get; set; }
        void Save();
    }
}