using Garanti.Application.Commands;
using Garanti.Application.Service;
using Garanti.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Application.CommandHandler
{
    public class AdminUserCommandHandler : IRequestHandler<AdminUserLoginCommand, string>
    {

        private readonly AuthenticationService _authenticationService;
        private readonly IUnitOfWork _unitOfWork;

        public AdminUserCommandHandler( IUnitOfWork unitOfWork)
        {
            _authenticationService = new AuthenticationService();
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(AdminUserLoginCommand request, CancellationToken cancellationToken)
        {
            var user = _unitOfWork.AdminUserRepository.Get(x => x.Email == request.Email && x.Password == request.Password);

            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadı");
            }

            var token = _authenticationService.GenerateToken(user.Email);

            return token;


        }
    }
}
