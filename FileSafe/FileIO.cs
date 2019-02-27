using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSafe
{
    /// <summary>
    /// This application opens a txt file and encrypts or decrypts
    /// it depending on user interface commands.
    ///
    /// @author Nelson_Nyland
    /// @version 8/24/18
    /// </summary>
    public static class FileIO
    {
        /// <summary>
        /// Opens the file browser to select file to open.
        /// Once selected, the file is parsed for data into an
        /// OpenFile object.
        /// </summary>
        public static void Open()
        {
            List<OpenFile> openFiles = GetOpenFiles();
            
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter =
                "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";

            if (dialog.ShowDialog() is DialogResult.OK)
            {
                FileInfo info = new FileInfo(dialog.FileName);

                OpenFile file = new OpenFile
                {
                    Name = Path.GetFileName(dialog.FileName),
                    Path = dialog.FileName,
                    Encrypted = IsEncrypted(info),
                    Contents = File.ReadAllText(dialog.FileName)
                };
                openFiles.Add(file);
            }
        }

        /// <summary>
        /// Immediately saves all selected files. It does not
        /// impliment a file browser to save.
        /// </summary>
        /// <param name="files"></param>
        public static bool Save(List<OpenFile> files)
        {
            if (files.Count is 0)
                return false;
            
            foreach (OpenFile file in files)
                File.WriteAllText(file.Path, file.Contents);
                
            return true;
        }

        /// <summary>
        /// Saves a selected file in a selected location. Impliments
        /// a file browser to save.
        /// </summary>
        /// <param name="file"></param>
        public static bool SaveAs(OpenFile file)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter =
                "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";

            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() is DialogResult.OK)
            {
                if (file is null)
                    return false;
                
                File.WriteAllText(dialog.FileName, file.Contents);
                
                if (File.Exists(dialog.FileName))
                    return true;
            }
            
            return false;
        }

        /// <summary>
        /// Decrypts a list of open files and returns whether
        /// or not it was successful.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>bool result</returns>
        public static bool Decrypt(List<OpenFile> files)
        {
            if (files.Count is 0)
                return false;
            
            foreach (OpenFile file in files)
            {
                if (file.Encrypted)
                    File.Decrypt(file.Path);
                
                FileInfo info = new FileInfo(file.Path);
                
                if (IsEncrypted(info))
                    return false;
                else
                    file.Encrypted = false;
            }

            return true;
        }

        /// <summary>
        /// Encrypts a list of open files and returns whether
        /// or not it was successful.
        /// </summary>
        /// <param name="files"></param>
        /// <returns>bool result</returns>
        public static bool Encrypt(List<OpenFile> files)
        {
            if (files.Count is 0)
                return false;
            
            foreach (OpenFile file in files)
            {
                if (file.Encrypted is false)
                    File.Encrypt(file.Path);

                FileInfo info = new FileInfo(file.Path);

                if (!IsEncrypted(info))
                    return false;
                else
                    file.Encrypted = true;
            }

            return true;
        }

        /// <summary>
        /// Checks if file is encrypted and returns bool result.
        /// </summary>
        /// <param name="dialog"></param>
        /// <returns>bool result</returns>
        private static bool IsEncrypted(FileInfo info)
        {
            if (info.Attributes.HasFlag(FileAttributes.Encrypted))
                return true;
            else
                return false;
        }

        private static string GetMyDocumentsPath()
        {
            return Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);
        }

        public static List<OpenFile> GetOpenFiles()
        {
            if (OpenFiles is null)
                OpenFiles = new List<OpenFile>();
            
            return OpenFiles;
        }

        private static List<OpenFile> OpenFiles { get; set; }
    }
}
