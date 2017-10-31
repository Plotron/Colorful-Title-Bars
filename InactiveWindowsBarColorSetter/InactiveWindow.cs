using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace InactiveWindowsBarColorSetter
{
    static class WindowCustomizationUtility  
    {
        //key paths
        const string accentColorKeyFullPath = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM"; 
        const string accentColorKeyPath = @"SOFTWARE\Microsoft\Windows\DWM"; 

        const string highTransparencyKeyFullPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        const string highTransparencyKeyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        //key names
        const string activeAccentColorKeyName = "AccentColor";
        const string inactiveAccentColorKeyName = "AccentColorInactive";
        const string highTransparencyKeyName = "UseOLEDTaskbarTransparency";

        static bool IsWindows10()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            string productName = (string)key.GetValue("ProductName");
            key.Close();
            return productName.StartsWith("Windows 10");
        }

        /// <summary>
        /// Sets the AccentColorInactive registry value according to the given hex value.
        /// </summary>
        /// <param name="BGRHexValue">Hex in the form of "BBGGRR" - blue, green, red. </param>
        public static void SetInactiveAccentColor(string BGRHexValue)
        {
            int decValue = Int32.Parse(BGRHexValue, System.Globalization.NumberStyles.HexNumber);
            Registry.SetValue(accentColorKeyFullPath, inactiveAccentColorKeyName, decValue, RegistryValueKind.DWord);
        }

        /// <summary>
        /// Sets the AccentColorInactive registry value according to the given RGB values.
        /// </summary>
        /// <param name="r">Red value from 0-255.</param>
        /// <param name="g">Green value from 0-255.</param>
        /// <param name="b">Blue value from 0-255.</param>
        public static void SetInactiveAccentColor(uint r, uint g, uint b)
        {
            if (r > 255 || g > 255 || b > 255)
            {
                throw new ArgumentException("RGB values out of range!");
            }
            String red = ((r < 16) ? "0" : "") + string.Format("{0:x}", r);
            String green = ((r < 16) ? "0" : "") + string.Format("{0:x}", g);
            String blue = ((r < 16) ? "0" : "") + string.Format("{0:x}", b);
            SetInactiveAccentColor(blue + green + red);
        }

        /// <summary>
        /// Returns the active accent color from the registry.
        /// </summary>
        /// <returns name="rawHexValue">Raw hex value of AccentColorActive from the registry.</returns>
        public static string GetActiveAccentColor()
        {
            int value = (Int32)Registry.GetValue(accentColorKeyFullPath, activeAccentColorKeyName, null);
            return value.ToString("X");
        }
        /// <summary>
        /// Returns the inactive accent color from the registry.
        /// </summary>
        /// <returns name="rawHexValue">Raw hex value of AccentColorInactive from the registry.</returns>
        public static string GetInactiveAccentColor()
        {
            int value = (Int32)Registry.GetValue(accentColorKeyFullPath, inactiveAccentColorKeyName, null);
            return value.ToString("X");
        }

        /// <summary>
        /// Deletes the AccentColorInactive value from the registry.
        /// </summary>
        [Obsolete("UNTESTED!")]
        public static void DeleteInactiveAccentColor()
        {
            RegistryKey baseRegKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
            RegistryKey key = baseRegKey.OpenSubKey(accentColorKeyPath, true);
            key.DeleteValue(inactiveAccentColorKeyName);
            key.Close();
            baseRegKey.Close();
        }

        /// <summary>
        /// Enables or disables UseOLEDTaskbarTransparency in registry.
        /// </summary>
        /// <param name="enable">True: set registry setting value to 1, false: set to 0.</param>
        [Obsolete("Experimental. Not 32-bit aware: untested under Win10 32-bit. Registry change not reflected in WOW6432Node.")]
        public static void SetHighTransparencySetting(bool enable = true)
        {
            int value = (enable ? 1 : 0);
            RegistryKey baseRegKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey key = baseRegKey.OpenSubKey(highTransparencyKeyPath, true);
            key.SetValue(highTransparencyKeyName, value);
            key.Close();
            baseRegKey.Close();
        }
        /// <summary>
        /// Returns the high transparency setting from the registry.
        /// </summary>
        /// <returns name="enabled">True if UseOLEDTaskbarTransparency is set to 1; otherwise returns false.</returns>
        [Obsolete("Experimental. Not 32-bit aware: untested under Win10 32-bit. Registry change not reflected in WOW6432Node.")]
        public static bool GetHighTransparencySetting()
        {
            RegistryKey baseRegKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey key = baseRegKey.OpenSubKey(highTransparencyKeyPath, true);
            int value = (Int32)key.GetValue(highTransparencyKeyName);
            //int value = (Int32)Registry.GetValue(highTransparencyKeyPath, highTransparencyKeyName, null);
            key.Close();
            baseRegKey.Close();
            switch (value)
            {
                case 1:
                    return true;
                    break;
                case 0:
                    return false;
                    break;
                default:
                    return false;
                    break;
            }
        }
    }
}
