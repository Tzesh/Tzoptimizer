using System;
using Microsoft.Win32;

namespace Tzoptimizer
{
        public class RegistryManager
        {
            public RegistryKey key { get; set; }
            public string name { get; set; }
            public int value { get; set; }

        public static void SetRegistry(RegistryKey key, string name, object value)
            {
                if (key != null)
                {
                    key.SetValue(name, value);
                    Console.WriteLine(key.ToString() + " has been set to new value.");
                }
            }

        public static void SetRegistry(RegistryKey key, string name, object value, bool dword)
        {
            if (dword == true) {
            if (key != null)
            {
                key.SetValue(name, value, RegistryValueKind.DWord);
                Console.WriteLine(key.ToString() + " has been set to new value.");
            }
            }
        }

        public static void DisableNablesAlgorithm(RegistryKey key)
        {
            foreach (string subkey in key.GetSubKeyNames())
            {
                key.CreateSubKey(subkey).SetValue("TcpAckFrequency", 1);
                key.CreateSubKey(subkey).SetValue("TCPNoDelay", 1);
                key.CreateSubKey(subkey).SetValue("TcpDelAckTicks", 0);
            }
        }


    }
}