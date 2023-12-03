using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace HS11PR001.Application.Behaviors;

public class UnhandledExceptionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
{
    private readonly ILogger<TRequest> logger;

    public UnhandledExceptionBehavior(ILogger<TRequest> logger)
        => this.logger = logger ?? throw new ArgumentNullException(nameof(logger));

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        try
        {
            return await next();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, $"Application Request Unhandled Exception : {nameof(request)} {request}");
            throw;
        }
    }
}
