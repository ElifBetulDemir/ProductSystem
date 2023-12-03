using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HS11PR001.Application.Contracts.Persistence.Repositories;
using HS11PR001.Domain;
using MediatR;

namespace HS11PR001.Application.Features.Products.Commands.ProductCreate;

public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, bool>
{
    private readonly IProductRepository repository;
    private readonly IMapper mapper;

    public ProductCreateCommandHandler(IProductRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }
    public async Task<bool> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
    {
        var newEntity = mapper.Map<Product>(request);
        return await repository.AddAsync(newEntity, cancellationToken);
    }
}
