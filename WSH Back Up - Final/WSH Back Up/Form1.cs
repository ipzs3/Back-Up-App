using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace WSH_Back_Up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        //  Exit button
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // Source Browse Button
        //    
        private void buttonSrcBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBoxSource.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //
        // Network Browse Button
        //            
        private void buttonNetworkBrowse_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                this.textBoxNetwork.Text = folderBrowserDialog2.SelectedPath;
            }
        }

        //
        // Cloud Browse Button       
        //
        private void buttonCloudBrowse_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog3.ShowDialog() == DialogResult.OK)
            {
                this.textBoxCloud.Text = folderBrowserDialog3.SelectedPath;
            }
        }

        //
        //  Back Up button
        //
        private void btnBackup_Click(object sender, EventArgs e)
        {
            // Sets strings as per textbox.text
            string source = textBoxSource.Text;
            string network = textBoxNetwork.Text;
            string cloud = textBoxCloud.Text;
            
            // Creates Destination directories as per Source unless source not chosen
            // Network
                   if (Directory.Exists(source))
                   foreach (string dirPath in Directory.GetDirectories(source, "*",
                       SearchOption.AllDirectories))
                       Directory.CreateDirectory(network + dirPath.Remove(0, source.Length));
            // Cloud
                   if (Directory.Exists(source))
                   foreach (string dirPath in Directory.GetDirectories(source, "*",
                       SearchOption.AllDirectories))
                       Directory.CreateDirectory(cloud + dirPath.Remove(0, source.Length));

            // Copies files as per Source unless destination not chosen
            // Network
                   if (Directory.Exists(network))
                   foreach (string newPath in Directory.GetFiles(source, "*.*",
                       SearchOption.AllDirectories))
                       File.Copy(newPath, network + newPath.Remove(0, source.Length), true);
            // Cloud
                   if (Directory.Exists(cloud))
                   foreach (string newPath in Directory.GetFiles(source, "*.*",
                       SearchOption.AllDirectories))
                       File.Copy(newPath, cloud + newPath.Remove(0, source.Length), true);

             


        }
            
    }
}