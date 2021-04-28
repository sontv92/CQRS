using CleanArchitecture.Application.CQRS.ProductType.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.ProductType.RequestModel
{
    public class ProductTypeQuery : IRequest<ProductTypeQueryResponseModel>
    {
        public Guid ProductTypeId { get; set; }
    }
}
