using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace GT5_SaveEditor.Properties
{
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = (Settings)Synchronized(new Settings());

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("True")]
        [DebuggerNonUserCode]
        public bool FetchThumbs
        {
            get
            {
                return (bool)this["FetchThumbs"];
            }
            set
            {
                this["FetchThumbs"] = false;
                //this["FetchThumbs"] = (object) (bool) (value ? 1 : 0);
            }
        }

        static Settings()
        {
        }
    }
}
