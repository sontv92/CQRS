using CleanArchitecture.Application.CQRS.Product.RequestModel;
using CleanArchitecture.Application.CQRS.Product.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.CQRS.Handler
{
    public class ProductCommandHandler : IRequestHandler<ProductCommand, ProductCommandResponseModel>
    {
        private readonly IMediator _mediator;
        public ProductCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<ProductCommandResponseModel> Handle(ProductCommand request, CancellationToken cancellationToken)
        {
            var result = new ProductCommandResponseModel();
            result.IsSuccess = true;
            // Your logic here
           
            return result;
        }
    }
}
