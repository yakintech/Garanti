﻿using Garanti.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Application.Queries
{

    public class GetAllCategoriesQuery : IRequest<List<GetAllCategoriesResponseDto>>
    {
    }
   
}
