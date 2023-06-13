using IK.Application.Interfaces.Services;
using IK.Application.Repositories.Base;
using IK.Application.Repositories.Sys;
using IK.Domain.Concrete.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Sys_User> _repository;
        private readonly ISys_UserRepository _userRepository;
        public UserService(IUnitOfWork unitOfWork, IRepository<Sys_User> repository, ISys_UserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _userRepository = userRepository;
        }

        public void Add(Sys_User user, int personId)
        {
            // dönüşüm
            // automapper
            user.PersonID = personId;
            _unitOfWork.Repository<Sys_User>().Add(user);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<Sys_User>> GetAllAsync()
        {
            return _userRepository.GetAllAsync();

        }
    }

}
