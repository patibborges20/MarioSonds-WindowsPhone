using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mario2
{
    using System;
    using System.Collections.Generic;
    using System.IO.IsolatedStorage;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ExemploReview
    {
        class SettingsManager
        {
            public void SetValue(string settingName, int value)
            {
                settingName = settingName.ToLower();
                if (IsolatedStorageSettings.ApplicationSettings.Contains(settingName))
                {
                    IsolatedStorageSettings.ApplicationSettings[settingName] = value;
                }
                else
                {
                    IsolatedStorageSettings.ApplicationSettings.Add(settingName, value);
                }

            }

            public int GetValue(string settingName, int defaultValue)
            {
                settingName = settingName.ToLower();
                if (IsolatedStorageSettings.ApplicationSettings.Contains(settingName))
                {
                    return (int)IsolatedStorageSettings.ApplicationSettings[settingName];
                }
                else
                {
                    return defaultValue;
                }
            }
        }
    }

}
