using Microsoft.Extensions.Logging;
using RepositoryLayer1.Context;
using RepositoryLayer1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using RepositoryLayer1.Interface;

namespace RepositoryLayer1.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        private readonly UserContext _dbContext;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public UserRegistrationRL(UserContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void RegisterUser(UserEntity user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                logger.Info("User registered successfully: " + user.Email);
            }
            catch (Exception ex)
            {
                logger.Error("Error in RegisterUser: " + ex.Message);
                throw;
            }
        }
    }
}
