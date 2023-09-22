using System;
using System.IO;
using ApesVSHeliumModLoader.Menus;

namespace ApesVSHeliumModLoader.AVH
{
    public class ConfigHandler
    {
        public void CreateConfig()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\config.txt";
            var text = "GamePath = DefaultPath\nGameSavePath = DefaultPath";
            if (!File.Exists(path))
                File.WriteAllText(path, text);
        }

        public void UpdateOption(string index)
        {
            var path = $"{Directory.GetCurrentDirectory()}\\config.txt";
            if (!File.Exists(path))
            {
                CreateConfig();
                return;
            }
            var dir = File.ReadAllLines(path);

            switch (index)
            {
                case "GamePath":
                    dir[0] = $"GamePath = {ModLoaderForm.GamePath}";
                    break;
                case "GameSavePath":
                    dir[1] = $"GameSavePath = {ModLoaderForm.GameSavePath}";
                    break;
            }

            File.WriteAllLines(path, dir);
        }

        public void ReadConfig()
        {
            var path = $"{Directory.GetCurrentDirectory()}\\config.txt";
            foreach (var line in File.ReadAllLines(path))
            {
                if (!line.Contains("=")) continue;
                var removeValueNames = line.Remove(0, line.IndexOf("=", StringComparison.Ordinal) + 2);

                if (line.Contains("GamePath"))
                    ModLoaderForm.GamePath = removeValueNames;

                if (line.Contains("GameSavePath"))
                    ModLoaderForm.GameSavePath = removeValueNames;
            }
        }
    }
}
