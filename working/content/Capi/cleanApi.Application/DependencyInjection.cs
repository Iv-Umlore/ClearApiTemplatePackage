namespace clearApi.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection Services,
        IConfiguration configuration
    )
    {
        return Services;
    }
}
