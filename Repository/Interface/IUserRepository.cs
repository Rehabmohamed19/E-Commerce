using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        object FirstOrDefault(Func<object, bool> value);
    }
}
