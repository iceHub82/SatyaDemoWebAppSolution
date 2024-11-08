namespace SatyaDemoWebApp;

public static class DashboardApiExtension
{
    public static void MinimalApis(this WebApplication app)
    {
        app.MapGet("/api/htmx", () =>
        {
            return Results.Content("Hi Satya with HTMX", "text/html");

        });

        app.MapGet("/api/jquery", () =>
        {
            return Results.Content("Hi Satya with jquery", "text/html");

        });
    }
}
