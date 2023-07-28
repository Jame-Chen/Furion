using Furion;
using System.Reflection;

namespace Furion.Web.Entry;

public class SingleFilePublish : ISingleFilePublish
{
    public Assembly[] IncludeAssemblies()
    {
        return Array.Empty<Assembly>();
    }

    public string[] IncludeAssemblyNames()
    {
        return new[]
        {
            "Furion.Application",
            "Furion.Core",
            "Furion.EntityFramework.Core",
            "Furion.Web.Core"
        };
    }
}