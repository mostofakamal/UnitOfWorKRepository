using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.LoanApplication;
using Data.LoanApplication.Models;
using Data.Models;

namespace Repository.Repositories
{
    public class LoanApplicationRespository<T>: RespositoryBase<T> where T: class,ILoan
    {
        public LoanApplicationRespository(ILoanApplicationContext context) : base((DbContext)context)
        {
        }
    }
}
