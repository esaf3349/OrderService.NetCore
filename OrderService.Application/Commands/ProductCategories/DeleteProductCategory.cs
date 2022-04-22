using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Application.Commands.ProductCategories
{
    public class DeleteProductCategory : IRequest
    {
        public int Id { get; set; }
    }
}
