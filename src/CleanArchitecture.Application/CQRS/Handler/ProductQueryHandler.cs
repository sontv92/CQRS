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
    public class ProductQueryHandler : IRequestHandler<ProductQuery, ProductQueryResponseModel>
    {

        private readonly IMediator _mediator;
        public ProductQueryHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<ProductQueryResponseModel> Handle(ProductQuery request, CancellationToken cancellationToken)
        {
            return new ProductQueryResponseModel();
        }

    }
}
