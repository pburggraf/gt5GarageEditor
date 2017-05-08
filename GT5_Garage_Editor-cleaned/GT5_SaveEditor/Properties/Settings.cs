// Type: GT5_SaveEditor.Properties.Settings
// Assembly: GT5_Garage_Editor, Version=1.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: DD0589A9-C36F-4C8C-A8E4-5B0E29CADD76
// Assembly location: C:\Users\shalpin\Downloads\GT5_Garage_Editor_v131_slim355_q-k (2)\Release\GT5_Garage_Editor-cleaned.exe

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
