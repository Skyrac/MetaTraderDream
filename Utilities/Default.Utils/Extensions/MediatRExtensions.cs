using MediatR.Extensions.FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Default.Utils.Extensions;

public static class MediatRExtensions
{
    public static void SetupMediatR(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddFluentValidation(new[] { Assembly.GetExecutingAssembly() });
    }

    /*
     * 
     public class GenerateInvoiceValidator : AbstractValidator<GenerateInvoiceRequest>
{
    public GenerateInvoiceValidator()
    {
        RuleFor(x => x.Month).LowerThan(13);
        // etc.
    }
}

public class GenerateInvoiceRequest : IRequest
{
    public int Month { get; set; }
}
public class GenerateInvoiceRequestHandler : IRequestHandler<GenerateInvoiceRequest>
{
    public async Task<Unit> Handle(GenerateInvoiceRequest request, CancellationToken cancellationToken)
    {
        // request data has been validated
        ...
    }
}
     * 
     */
}
