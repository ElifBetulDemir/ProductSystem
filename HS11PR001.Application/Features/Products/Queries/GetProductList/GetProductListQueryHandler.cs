﻿using AutoMapper;
using HS11PR001.Application.Contracts.Persistence.Repositories;
using HS11PR001.Application.Features.Products.ViewModels;
using HS11PR001.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Application.Features.Products.Queries.GetProductList;

public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, IEnumerable<ProductVM>>
{
    private readonly IProductRepository repository;
    private readonly IMapper mapper;

    public GetProductListQueryHandler(IProductRepository repository, IMapper mapper)
    {
        this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }
    public async Task<IEnumerable<ProductVM>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        => mapper.Map<IEnumerable<ProductVM>>(await repository.GetAllAsync(f => f != null, cancellationToken));
}
