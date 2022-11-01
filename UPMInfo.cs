using System.Reflection;
using UnityEditor.PackageManager;

public class UPMInfo
{
    public static string Version => GetVersion();

    public static string GetVersion()
    {
        Assembly assembly = typeof(UPMInfo).Assembly;
        PackageInfo packageInfo = PackageInfo.FindForAssembly(assembly);
        return packageInfo.version;
    }
}
