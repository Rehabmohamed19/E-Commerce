using Data;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CompanyContext context) : base(context)
        {
        }
    }
}
