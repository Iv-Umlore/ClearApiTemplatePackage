namespace clearApi;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices (
        this IServiceCollection Services,
        IConfiguration configuration
    )
    {
        Services.AddEndpointsApiExplorer();
        Services.AddSwaggerGen();

        return Services;  
    }

    public static WebApplication UseApiServises(
        this WebApplication app
    ) 
    {

        if (app.Environment.IsDevelopment())
        {
                app.UseSwagger();
                app.UseSwaggerUI();    
        }

        app.MapGet("/", () => "Hello World!");

        return app;
    }
}
