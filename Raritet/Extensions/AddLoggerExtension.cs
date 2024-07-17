using Serilog;

namespace Raritet.Extensions;

internal static class AddLoggerExtension
{
    public static void AddLogger(this IHostBuilder hostBuilder)
    {
        hostBuilder.UseSerilog((context, configuration) =>
            configuration.ReadFrom.Configuration(context.Configuration));
    }
}