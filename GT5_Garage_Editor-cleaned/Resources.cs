using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace GT5_Garage_Editor
{
    [DebuggerNonUserCode]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    internal sealed class Resources
    {
        private static ResourceManager resourceManager_0;
        private static CultureInfo cultureInfo_0;

        internal Resources()
        {
        }

        internal static ResourceManager smethod_0()
        {
            if (resourceManager_0 == null)
                resourceManager_0 = new ResourceManager("GT5_SaveEditor.Properties.Resources", typeof (Resources).Assembly);
            return resourceManager_0;
        }

        internal static CultureInfo smethod_1()
        {
            return cultureInfo_0;
        }

        internal static void smethod_2(CultureInfo cultureInfo_1)
        {
            cultureInfo_0 = cultureInfo_1;
        }
    }
}
