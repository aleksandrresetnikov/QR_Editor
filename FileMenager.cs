using System;
using System.IO;

namespace Pro_code_editor
{
    class FileMenager : TestingWrites
    {
        public static string TotalRoot = @"C:\";
        public static string language = "en";
        public static bool autosaveToGalleryStatus = true;

        public static void fileStartTest()
        {
            SistemRoot();
            TestSystemPath();
            LoadFileData();
        }
        private static void SistemRoot()
        {
            TotalRoot = Path.GetPathRoot(Environment.SystemDirectory);
        }
        private static void TestSystemPath()//C:\ProgramData\Lamp\Parameters\delete parameters\colect delete vivo.txt
        {
            if (!new DirectoryInfo($@"{TotalRoot}ProgramData").Exists) { Directory.CreateDirectory($@"{TotalRoot}ProgramData"); }
            if (!new DirectoryInfo($@"{TotalRoot}ProgramData\Pro_code_editor").Exists) { Directory.CreateDirectory($@"{TotalRoot}ProgramData\Pro_code_editor"); }
            if (!new DirectoryInfo($@"{TotalRoot}ProgramData\Pro_code_editor\GalleryCollection").Exists) { Directory.CreateDirectory($@"{TotalRoot}ProgramData\Pro_code_editor\GalleryCollection"); }
            if (!new DirectoryInfo($@"{TotalRoot}ProgramData\Pro_code_editor\SystemContent").Exists) { Directory.CreateDirectory($@"{TotalRoot}ProgramData\Pro_code_editor\SystemContent"); }
            if (!new DirectoryInfo($@"{TotalRoot}ProgramData\Pro_code_editor\Parameters").Exists) { Directory.CreateDirectory($@"{TotalRoot}ProgramData\Pro_code_editor\Parameters"); }

            if (!new FileInfo($@"{TotalRoot}ProgramData\Pro_code_editor\Parameters\language.txt").Exists) { File.WriteAllText($@"{TotalRoot}ProgramData\Pro_code_editor\Parameters\language.txt", "en"); }
            if (!new FileInfo($@"{TotalRoot}ProgramData\Pro_code_editor\Parameters\autosave to gallery status.txt").Exists) { File.WriteAllText($@"{TotalRoot}ProgramData\Pro_code_editor\Parameters\autosave to gallery status.txt", "true"); }
        }
        private static void LoadFileData()
        {
            languageLoad();
            autosaveToGalleryStatusLoad();
        }
    }
    class TestingWrites
    {
        private protected static void languageLoad()
        {
            try
            {
                FileMenager.language = File.ReadAllText($@"{FileMenager.TotalRoot}ProgramData\Pro_code_editor\Parameters\language.txt").ToLower();
                switch (FileMenager.language)
                {
                    case "en": break;
                    case "ru": break;
                    default: throw new Exception(); break;
                }
            }
            catch (Exception)
            {
                File.WriteAllText($@"{FileMenager.TotalRoot}ProgramData\Pro_code_editor\Parameters\language.txt","en"); FileMenager.language = "en";
            }
        }
        private protected static void autosaveToGalleryStatusLoad()
        {
            try
            {
                string autosaveToGalleryStatusSTR = File.ReadAllText($@"{FileMenager.TotalRoot}ProgramData\Pro_code_editor\Parameters\autosave to gallery status.txt").ToLower();
                switch (autosaveToGalleryStatusSTR)
                {
                    case "true": FileMenager.autosaveToGalleryStatus = true; break;
                    case "false": FileMenager.autosaveToGalleryStatus = false; break;
                    default: throw new Exception(); break;
                }
            }
            catch (Exception)
            {
                File.WriteAllText($@"{FileMenager.TotalRoot}ProgramData\Pro_code_editor\Parameters\autosave to gallery status.txt", "true"); FileMenager.autosaveToGalleryStatus = true;
            }
        }
    }
}
