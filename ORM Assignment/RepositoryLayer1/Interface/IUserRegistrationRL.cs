using RepositoryLayer1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer1.Interface
{
    public interface IUserRegistrationRL
    {
        void RegisterUser(UserEntity user);
    }
}
