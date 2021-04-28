using CleanArchitecture.Application.CQRS.ProductType.ResponseModel;
using CleanArchitecture.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.ProductType.RequestModel
{
    public class ProductTypeCommand : IRequest<ProductTypeCommandResponseModel>
    {
        public string ProductTypeKey { get; set; }
        public string ProductTypeName { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
