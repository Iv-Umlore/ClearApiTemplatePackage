namespace cleanApi.Infrastrucure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructuresServices(
        this IServiceCollection Services,
        IConfiguration configuration
    )
    {
        return Services;
    }
}
