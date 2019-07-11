using RegistryUtils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ColorfulTitleBars.Logic
{
    public class RegFileProcessor
    {
        private readonly String Preamble = "Windows Registry Editor Version 5.00\r\n"
            + "\r\n"
            + "; created with Colorful Title Bars application\r\n"
            + "; visit https://github.com/Plotron/Colorful-Title-Bars for more details\r\n"
            + "\r\n";

        private readonly IFileSystem _fileSystem;

        public RegFileProcessor() : this (new FileSystem()) { }

        public RegFileProcessor(IFileSystem fileSystem) {
            _fileSystem = fileSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="fileName"></param>
        public void SaveAccentColorsToRegFile(Color inactiveAccentColor, Color activeAccentColor, string fileName)
        {
            String inactiveAccentColorBgrHex = "00" + HexUtility.RgbToHexValue(inactiveAccentColor.B, inactiveAccentColor.G, inactiveAccentColor.R);
            String activeAccentColorBgrHex = "00" + HexUtility.RgbToHexValue(activeAccentColor.B, activeAccentColor.G, activeAccentColor.R);

            String textToWrite =
                Preamble
                + $"[{WindowCustomizationUtility.AccentColorKeyFullPath}]"
                + $"\r\n\"{WindowCustomizationUtility.InactiveAccentColorKeyName}\"=dword:{inactiveAccentColorBgrHex}"
                + $"\r\n\"{WindowCustomizationUtility.ActiveAccentColorKeyName}\"=dword:{activeAccentColorBgrHex}";

            _fileSystem.File.WriteAllText(fileName, textToWrite);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="fileName"></param>
        public void SaveInactiveAccentColorToRegFile(Color color, string fileName)
        {
            String bgrHex = "00" + HexUtility.RgbToHexValue(color.B, color.G, color.R);

            String textToWrite =
                Preamble
                + $"[{WindowCustomizationUtility.AccentColorKeyFullPath}]"
                + $"\r\n\"{WindowCustomizationUtility.InactiveAccentColorKeyName}\"=dword:{bgrHex}";

            _fileSystem.File.WriteAllText(fileName, textToWrite);
        }

        /// <summary>
        /// Loads inactive accent color from a given reg file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>RGB Color if AccentColorInactive value is found in a reg file, returns null otherwise.</returns>
        public Color? LoadInactiveAccentColorFromRegFile(string fileName)
        {
            Color? result = null;

            var lineFound = _fileSystem.File.ReadLines(fileName).SkipWhile(line => !line.Contains("\"AccentColorInactive\""))
                .Take(1).SingleOrDefault();
            if (lineFound != null)
            {
                Match match = Regex.Match(lineFound, "dword:([A-Fa-f0-9]{6,8})");
                if (match.Success)
                {
                    result = WindowCustomizationUtility.BgrToColor(match.Groups[1].Value);
                }
            }

            return result;
        }
    }
}
