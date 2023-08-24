using Data;
using Data.Dto;
using Repository.Interface;
using System.Security.Claims;

namespace Service
{
    public class AdminService
    {
        private readonly IUnitOfWork _unitOfWork; 
        public AdminService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }
        public void AddUser(AdminDto adminDto)
        {
            User user = new User()
            {
                FullName = adminDto.FullName,
                Password = adminDto.Password,
                Email = adminDto.Email,
            };
            _unitOfWork.UserRepository.Add(user);
            _unitOfWork.SaveChanges();
        }

        public async Task<string?> GetUser(string email) {
            return (await _unitOfWork.UserRepository.Get(u => u.Email == email)).FullName;
        }

        public async void UpdateUser(AdminDto adminDto)
        {
            var data = await _unitOfWork.UserRepository.Get(x => x.Email == adminDto.Email);
            //data.FullName = adminDto.FullName;

            User user = new User()
            {
                FullName = adminDto.FullName,
                Password = adminDto.Password,
                Email = adminDto.Email,
            };
            _unitOfWork.UserRepository.Update(data);
                _unitOfWork.SaveChanges();

        }

        public async void DeleteUser (AdminDto adminDto)
        {
            var data = await _unitOfWork.UserRepository.Get(x => x.Email == adminDto.Email);
            _unitOfWork.UserRepository.Delete(data);
            _unitOfWork.SaveChanges();
        }






    }
}