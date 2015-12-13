﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeppySpartanMIDIConverter
{
    public partial class Informations : Form
    {
        public Informations()
        {
            InitializeComponent();
        }

        private void Informations_Load(object sender, EventArgs e)
        {
            // STUFF
            if (IntPtr.Size == 8)
            {
                Versionlabel.Text = "Compiled for 64-bit systems, optimized for SSE2 ready CPUs.";
            }
            else if (IntPtr.Size == 4)
            {
                Versionlabel.Text = "Compiled for 32-bit systems, optimized for MMX ready CPUs.";
            }
            KeppyVer.Text = "Keppy's MIDI Converter " + Application.ProductVersion + ", by Keppy Studios";

            // OTHER STUFF
            FileVersionInfo basslibver = FileVersionInfo.GetVersionInfo("bass.dll");
            FileVersionInfo bassmidilibver = FileVersionInfo.GetVersionInfo("bassmidi.dll");
            FileVersionInfo bassenclibver = FileVersionInfo.GetVersionInfo("bassenc.dll");

            // Print the file name and version number.
            BASSINFO.Text = basslibver.FileDescription + ": " + basslibver.FileVersion + "." + basslibver.FilePrivatePart + "\n" +
                bassmidilibver.FileDescription + ": " + bassmidilibver.FileVersion + "." + bassmidilibver.FilePrivatePart + "\n" +
                bassenclibver.FileDescription + ": " + bassenclibver.FileVersion + "." + bassenclibver.FilePrivatePart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.un4seen.com");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad.exe", "license.rtf");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://keppystudios.com/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KaleidonKep99/Keppys-MIDI-Converter");
        }
    }
}
