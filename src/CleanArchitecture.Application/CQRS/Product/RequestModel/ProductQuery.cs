using CleanArchitecture.Application.CQRS.Product.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.Product.RequestModel
{
    public class ProductQuery : IRequest<ProductQueryResponseModel>
    {
        public Guid ProductId { get; set; }
    }
}
