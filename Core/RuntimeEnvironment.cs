using System.Runtime.InteropServices;

namespace PayPalServer.Core;

internal static class RuntimeEnvironment
{
    public static string Os { get; } = $"{RuntimeInformation.OSDescription} {RuntimeInformation.OSArchitecture}";

    public static string Runtime { get; } = RuntimeInformation.FrameworkDescription;
}
