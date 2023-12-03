using AutoMapper;
using HS11PR001.Application.Contracts.Persistence.Repositories;
using HS11PR001.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSystem.Application.Features.Products.Commands.ProductUpdate;

public class ProductUpdateCommandHandler : IRequestHandler<ProductUpdateCommand, ProductUpdateCommand>
{
	private readonly IProductRepository repository;
	private readonly IMapper mapper;
	public ProductUpdateCommandHandler(IProductRepository repository, IMapper mapper)
	{
		this.repository = repository;
		this.mapper = mapper;
	}
	public async Task<ProductUpdateCommand> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
	{
		var entity = mapper.Map<Product>(request);
		await repository.Update(entity, cancellationToken);
		var newEntity = mapper.Map<ProductUpdateCommand>(entity);
		return newEntity;
	}
}
