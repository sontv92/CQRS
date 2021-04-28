using CleanArchitecture.Application.CQRS.Product.RequestModel;
using CleanArchitecture.Application.CQRS.Product.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.Interfaces
{
    public interface IProductCommandHandler
    {
        ProductCommandResponseModel Handle(ProductCommand request);
    }
}
