using CleanArchitecture.Application.CQRS.Product.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.Product.RequestModel
{
    public class ProductCommand : IRequest<ProductCommandResponseModel>
    {
        public string ProductKey { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUri { get; set; }
        public Guid ProductTypeID { get; set; }
        public int RecordStatus { get; set; }
    }
}
