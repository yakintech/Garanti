using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Application.Commands
{
    public class CreateCategoryCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }


    public class DeleteCategoryCommand : IRequest
    {
        public Guid Id { get; set; }
    }

}
