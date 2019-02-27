using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSafe
{
    public partial class FrmFileIO : Form
    {
        public FrmFileIO()
        {
            InitializeComponent();
        }

        private void MnuItemOpen_Click(object sender, EventArgs e)
        {
            FileIO.Open();
            PopulateFileBox();
        }

        private void PopulateFileBox()
        {
            List<OpenFile> openFiles = FileIO.GetOpenFiles();

            lstFiles.Items.Clear();

            foreach (OpenFile file in openFiles)
            {
                lstFiles.Items.Add(file.Name);
            }
        }

        /// <summary>
        /// Takes Save All command and passes all open files to
        /// FileIO.Save()
        /// </summary>
        private void MnuItemSaveAll_Click(object sender, EventArgs e)
        {
            List<OpenFile> openFiles = FileIO.GetOpenFiles();

            if (FileIO.Save(openFiles))
                MessageBox.Show("Save Successful.");
            else
                MessageBox.Show("Save Unsuccessful.");
        }


        /// <summary>
        /// Takes Save All Selected command and passes all selected
        /// files to FileIO.Save()
        /// </summary>
        private void MnuItemSaveAllSel_Click(object sender, EventArgs e)
        {
            if (GetAllSelected() is null)
                return;

            List<OpenFile> saveFiles = GetAllSelected();
            
            if (FileIO.Save(saveFiles))
                MessageBox.Show("Save Successful.");
            else
                MessageBox.Show("Save Unsuccessful.");
        }

        /// <summary>
        /// Takes Save Selected File command and passes selected file
        /// to FileIO.SaveAs() 
        /// </summary>
        private void MnuItemSaveSelFileAs_Click(object sender, EventArgs e)
        {
            if (GetSelectedFile() is null)
                return;

            OpenFile saveFile = GetSelectedFile();

            if (FileIO.SaveAs(saveFile))
                MessageBox.Show("Save Successful.");
            else
                MessageBox.Show("Save Unsuccessful.");
        }
        
        private void MnuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuItemDecryptSel_Click(object sender, EventArgs e)
        {
            if (GetAllSelected() is null)
                return;

            List<OpenFile> selectedFiles = GetAllSelected();

            if (FileIO.Decrypt(selectedFiles))
                MessageBox.Show("Decryption Successful.");
            else
                MessageBox.Show("Decryption Unsuccessful.");
        }

        private void MnuItemDecryptAll_Click(object sender, EventArgs e)
        {
            List<OpenFile> openFiles = FileIO.GetOpenFiles();

            if (FileIO.Decrypt(openFiles))
                MessageBox.Show("Decryption Successful.");
            else
                MessageBox.Show("Decryption Unsuccessful.");
        }

        private void MnuItemEncryptSel_Click(object sender, EventArgs e)
        {
            if (GetAllSelected() is null)
                return;

            List<OpenFile> selectedFiles = GetAllSelected();

            if (FileIO.Encrypt(selectedFiles))
                MessageBox.Show("Encryption Successful.");
            else
                MessageBox.Show("Encryption Unsuccessful.");
        }

        private void MnuItemEncryptAll_Click(object sender, EventArgs e)
        {
            List<OpenFile> openFiles = FileIO.GetOpenFiles();

            if (FileIO.Encrypt(openFiles))
                MessageBox.Show("Encryption Successful.");
            else
                MessageBox.Show("Encryption Unsuccessful.");
        }

        private List<OpenFile> GetAllSelected()
        {
            var items = lstFiles.SelectedItems;

            if (items.Count is 0)
                return null;
            
            List<OpenFile> openFiles = FileIO.GetOpenFiles();

            List<OpenFile> selectedFiles = new List<OpenFile>();

            foreach (OpenFile file in openFiles)
            {
                if (items.Contains(file.Name))
                    selectedFiles.Add(file);
            }

            return selectedFiles;
        }

        private OpenFile GetSelectedFile()
        {
             var selItem = lstFiles.SelectedItem;

            if (selItem is null)
                return null;

            List<OpenFile> openFiles = FileIO.GetOpenFiles();

            OpenFile saveFile = new OpenFile();

            foreach (OpenFile file in openFiles)
            {
                if (selItem.Equals(file.Name))
                    saveFile = file;
            }

            return saveFile;
        }
    }
}
