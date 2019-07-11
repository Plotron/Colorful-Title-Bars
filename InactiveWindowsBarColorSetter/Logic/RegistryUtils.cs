using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace RegistryUtils
{
    public static class HexUtility
    {
        /// <summary>
        /// Utility function for building lowercase hex strings from byte RGB values.
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <returns>Lowercase hex value of a given color without the "0x" prefix.</returns>
        public static string RgbToHexValue(byte red, byte green, byte blue)
        {
            return $"{HexPadding(red)}{HexPadding(green)}{HexPadding(blue)}";
        }

        public static string HexPadding(byte value)
        {
            return (value < 16 ? "0" : "") + $"{value:x}";
        }
    }

    public static class WindowCustomizationUtility
    {
        //key paths
        public const string AccentColorKeyFullPath = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM";
        public const string AccentColorKeyPath = @"SOFTWARE\Microsoft\Windows\DWM";
        public const string HighTransparencyKeyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced";
        public const string CurrentVersionKeyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
        public const string TitlebarColorPrevalenceKeyPath =
            @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\DWM";
        //key names
        public const string ActiveAccentColorKeyName = "AccentColor";
        public const string InactiveAccentColorKeyName = "AccentColorInactive";
        public const string HighTransparencyKeyName = "UseOLEDTaskbarTransparency";
        public const string WindowsNameKeyName = "ProductName";
        public const string ColorPrevalenceKeyName = "ColorPrevalence";

        /// <summary>
        /// Checks the version of Windows in registry in CurrentVersion/ProductName.
        /// </summary>
        /// <returns>True when the current OS is Windows 10, false otherwise.</returns>
        public static bool IsWindows10()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(CurrentVersionKeyPath))
            {
                string productName = (string)key.GetValue(WindowsNameKeyName);
                return productName.StartsWith("Windows 10");
            }
        }

        /// <summary>
        /// Enables or disables colorful title bars.
        /// </summary>
        /// <param name="enable">True: set registry setting value to 1, false: set to 0.</param>
        public static void SetTitlebarColorPrevalence(bool enable)
        {
            Registry.SetValue(TitlebarColorPrevalenceKeyPath, ColorPrevalenceKeyName, enable ? 1 : 0, RegistryValueKind.DWord);
        }

        /// <summary>
        /// Checks whether the current user has colorful title bars enabled.
        /// </summary>
        /// <returns></returns>
        public static bool IsTitlebarColorPrevalenceEnabled()
        {
            var value = (int)Registry.GetValue(TitlebarColorPrevalenceKeyPath, ColorPrevalenceKeyName, 0);
            return value != 0;
        }

        /// <summary>
        /// Sets the AccentColorInactive registry value according to the given hex value.
        /// </summary>
        /// <param name="bgrHexValue">Hex in the form of "BBGGRR" - blue, green, red. </param>
        private static void SetInactiveAccentColor(string bgrHexValue)
        {
            int value = int.Parse(bgrHexValue, System.Globalization.NumberStyles.HexNumber);
            Registry.SetValue(AccentColorKeyFullPath, InactiveAccentColorKeyName, value, RegistryValueKind.DWord);
        }

        /// <summary>
        /// Sets the AccentColorInactive registry value according to given RGB values.
        /// </summary>
        /// <param name="r">Red value from 0-255.</param>
        /// <param name="g">Green value from 0-255.</param>
        /// <param name="b">Blue value from 0-255.</param>
        public static void SetInactiveAccentColor(byte r, byte g, byte b)
        {
            var red = HexUtility.HexPadding(r);
            var green = HexUtility.HexPadding(g);
            var blue = HexUtility.HexPadding(b);
            SetInactiveAccentColor(blue + green + red);
        }

        /// <summary>
        /// Returns the active accent color from the registry.
        /// </summary>
        /// <returns name="rawHexValue">Raw hex value of AccentColorActive from the registry. Returns 0xffffff if not found.</returns>
        public static string GetActiveAccentColorHex()
        {
            int value = (int)Registry.GetValue(AccentColorKeyFullPath, ActiveAccentColorKeyName, Int32.MaxValue);
            return value.ToString("X");
        }

        /// <summary>
        /// Returns the inactive accent color from the registry.
        /// </summary>
        /// <returns name="rawHexValue">Raw hex value of AccentColorInactive from the registry. Returns 0xffffff if not found.</returns>
        public static string GetInactiveAccentColorHex()
        {
            int value = (int)Registry.GetValue(AccentColorKeyFullPath, InactiveAccentColorKeyName, Int32.MaxValue);
            return value.ToString("X");
        }

        /// <summary>
        /// Returns the inactive accent color from the registry as a Color object.
        /// </summary>
        /// <returns name="color">Color value of AccentColorInactive from the registry.</returns>
        public static Color GetInactiveAccentColor()
        {
            return BgrToColor(GetInactiveAccentColorHex());
        }

        /// <summary>
        /// Returns the active accent color from the registry as a Color object.
        /// </summary>
        /// <returns name="color">Color value of AccentColorActive from the registry.</returns>
        public static Color GetActiveAccentColor()
        {
            return BgrToColor(GetActiveAccentColorHex());
        }

        /// <summary>
        /// Parses 24-bit bgr (blue, green, red) hex string and returns Color object.
        /// </summary>
        /// <param name="bgrHex">24-bit hex to be parsed, leading bytes are ignored.</param>
        /// <returns>Parsed color value.</returns>
        public static Color BgrToColor(string bgrHex)
        {
            if (bgrHex.Length >= 6 && bgrHex.Length <= 8)
            {
                bgrHex = bgrHex.Substring(bgrHex.Length - 6);
            } else
            {
                throw new ArgumentException($"Provided hex has an invalid length. It must be between 6 and 8 characters long.");
            }

            int b = Convert.ToByte($"{bgrHex[0]}{bgrHex[1]}", 16);
            int g = Convert.ToByte($"{bgrHex[2]}{bgrHex[3]}", 16);  
            int r = Convert.ToByte($"{bgrHex[4]}{bgrHex[5]}", 16);

            return Color.FromArgb(r, g, b);
        }

        /// <summary>
        /// Deletes the AccentColorInactive value from the registry.
        /// </summary>
        public static void DeleteInactiveAccentColor()
        {
            using (RegistryKey baseRegKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
            using (RegistryKey key = baseRegKey.OpenSubKey(AccentColorKeyPath, true))
            {
                key.DeleteValue(InactiveAccentColorKeyName);
            }
        }

        /// <summary>
        /// Enables or disables UseOLEDTaskbarTransparency in registry.
        /// </summary>
        /// <param name="enable">True: set registry setting value to 1, false: set to 0.</param>
        [Obsolete("Experimental. Not 32-bit aware: untested under Win10 32-bit. Registry change not reflected in WOW6432Node.")]
        public static void SetHighTransparencySetting(bool enable = true)
        {
            int value = (enable ? 1 : 0);
            using (RegistryKey baseRegKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (RegistryKey key = baseRegKey.OpenSubKey(HighTransparencyKeyPath, true))
            {
                key.SetValue(HighTransparencyKeyName, value);
            }
        }

        /// <summary>
        /// Returns the high transparency setting from the registry.
        /// </summary>
        /// <returns name="enabled">True if UseOLEDTaskbarTransparency is set to 1; otherwise returns false.</returns>
        [Obsolete("Experimental. Not 32-bit aware: untested under Win10 32-bit. Registry change not reflected in WOW6432Node.")]
        public static bool GetHighTransparencySetting()
        {
            using (RegistryKey baseRegKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (RegistryKey key = baseRegKey.OpenSubKey(HighTransparencyKeyPath, true))
            {
                int value = (int)key.GetValue(HighTransparencyKeyName);
                switch (value)
                {
                    case 1:
                        return true;
                    case 0:
                        return false;
                    default:
                        return false;
                }
            }
        }
    }
}
