using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tzoptimizer.Utils
{
    internal class RegistryManager
    {
        public static void ApplyRegistry(RegistryClass reg)
        {
            string root = reg.Root;
            string path = reg.Path;
            RegistryKey rootKey;
            switch (root)
            {
                case "HKEY_LOCAL_MACHINE":
                    rootKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@path);
                    break;
                case "HKEY_CURRENT_USER":
                    rootKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64).CreateSubKey(@path);
                    break;
                default: throw new ArgumentException("Unexpected root path of registry key");
            }

            foreach (string key in reg.KeyValuePairs.Keys)
            {
                string value = reg.KeyValuePairs[key];
                bool isDword = false;
                if (value.Contains("dword:"))
                {
                    isDword = true;
                    value = value.Replace("dword:", "");
                }
                SetRegistry(rootKey, key, value, isDword, !isDword);
            }
        }


        public static void SetRegistry(RegistryKey pathKey, string key, object value, bool isDword, bool isString)
        {
            if (pathKey != null)
            {
                pathKey.SetValue(key, (isDword ? Convert.ToInt32((string)value, 16) : value), isDword && !isString ? RegistryValueKind.DWord : RegistryValueKind.String);
            }
        }


    }
}
