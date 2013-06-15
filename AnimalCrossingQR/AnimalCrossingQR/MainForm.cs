﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalCrossingQR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Test Data
            byte[] rawData =
            {
                0x40, 0x26, 0xC4, 0x90, 0x07, 0x30, 0x06, 0x10, 0x06, 0x20, 0x06, 0x50, 0x06, 0xC0, 0x06, 0xC0, 
                0x06, 0x50, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x07, 0x19, 0x04, 0xE0, 
                0x06, 0x90, 0x06, 0xE0, 0x07, 0x40, 0x06, 0x50, 0x06, 0xE0, 0x06, 0x40, 0x06, 0xF0, 0x00, 0x00, 
                0x00, 0x00, 0x0B, 0x7E, 0xA4, 0xE0, 0x06, 0x90, 0x06, 0xE0, 0x07, 0x40, 0x06, 0x50, 0x06, 0xE0, 
                0x06, 0x40, 0x06, 0xF0, 0x00, 0x00, 0x00, 0x10, 0x03, 0x10, 0x07, 0x17, 0x52, 0x37, 0x04, 0xF2, 
                0x16, 0x11, 0x46, 0x3A, 0x12, 0x41, 0x30, 0xF6, 0x36, 0x2C, 0x40, 0xA0, 0x90, 0x00, 0x01, 0x99, 
                0x19, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x91, 0x91, 0x19, 0x99, 
                0x99, 0x99, 0x99, 0x99, 0x92, 0x22, 0x29, 0x29, 0x99, 0x99, 0x99, 0x99, 0x91, 0x91, 0x19, 0x99, 
                0x99, 0x99, 0x99, 0x92, 0x92, 0x22, 0x26, 0x29, 0x99, 0x99, 0x99, 0x99, 0x91, 0x91, 0x19, 0x9A, 
                0x99, 0xA9, 0x99, 0x92, 0x90, 0x20, 0x02, 0x22, 0x69, 0x29, 0x99, 0x99, 0x91, 0x91, 0x19, 0x9A, 
                0x99, 0xAA, 0xA9, 0x92, 0x90, 0x00, 0x02, 0x02, 0x22, 0x29, 0x99, 0x99, 0x99, 0x99, 0x9A, 0x9A, 
                0xA9, 0xAA, 0xA9, 0x91, 0x90, 0x00, 0x02, 0x00, 0x02, 0x09, 0x90, 0x99, 0x09, 0x99, 0x9A, 0x99, 
                0xA9, 0x9A, 0xA9, 0x91, 0x90, 0x00, 0x00, 0x00, 0x01, 0x09, 0x90, 0x99, 0x09, 0x99, 0x99, 0x99, 
                0x99, 0x99, 0x99, 0x99, 0x90, 0x10, 0x00, 0x00, 0x09, 0x10, 0x90, 0x09, 0x00, 0x09, 0x99, 0x9A, 
                0x9A, 0xA9, 0x99, 0x99, 0x99, 0x91, 0x11, 0x11, 0x19, 0x90, 0x99, 0x09, 0x90, 0x09, 0x99, 0x9A, 
                0x9A, 0xA9, 0x99, 0x99, 0x9C, 0x9B, 0x4B, 0xB9, 0xB9, 0x90, 0x99, 0x09, 0x90, 0x09, 0x99, 0x9A, 
                0x9A, 0xA9, 0x99, 0x99, 0x94, 0x97, 0x47, 0x79, 0x79, 0x99, 0x90, 0x90, 0x09, 0x99, 0x99, 0x99, 
                0x99, 0x99, 0x99, 0x90, 0x50, 0x00, 0x00, 0x00, 0x05, 0x09, 0x90, 0x90, 0x09, 0x99, 0x99, 0x99, 
                0x99, 0x99, 0x90, 0x50, 0x00, 0x00, 0x00, 0x00, 0x00, 0x05, 0x00, 0x90, 0x09, 0x99, 0x99, 0x99, 
                0x99, 0x92, 0x90, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x09, 0x29, 0x99, 0x99, 0x99, 0x99, 
                0x99, 0x90, 0x20, 0x00, 0x00, 0x01, 0x10, 0x10, 0x00, 0x10, 0x02, 0x09, 0x99, 0x99, 0x99, 0x99, 
                0x92, 0x90, 0x21, 0x00, 0x01, 0x00, 0x11, 0x10, 0x01, 0x10, 0x02, 0x09, 0x29, 0x99, 0x99, 0x99, 
                0x92, 0x20, 0x21, 0x10, 0x01, 0x10, 0x01, 0x00, 0x11, 0x10, 0x12, 0x02, 0x29, 0x99, 0x99, 0x96, 
                0x92, 0x21, 0x20, 0x11, 0x10, 0x10, 0x00, 0x01, 0x10, 0x11, 0x12, 0x12, 0x29, 0x69, 0x99, 0x92, 
                0x62, 0x22, 0x20, 0x0D, 0xD0, 0x00, 0x00, 0x00, 0x0D, 0xE0, 0x02, 0x22, 0x26, 0x29, 0x99, 0x92, 
                0x22, 0x22, 0x2E, 0x0E, 0xC0, 0x00, 0x00, 0x00, 0x0E, 0xC0, 0xD2, 0x22, 0x22, 0x29, 0x96, 0x92, 
                0x22, 0x26, 0x20, 0x0E, 0xE0, 0x00, 0x00, 0x00, 0x0E, 0xE0, 0x02, 0x22, 0x22, 0x29, 0x66, 0x92, 
                0x22, 0x26, 0x20, 0x0D, 0xE0, 0x0C, 0xCC, 0xC0, 0xCD, 0xE0, 0x02, 0xA2, 0x22, 0x29, 0x62, 0x92, 
                0x22, 0x20, 0x60, 0x00, 0x0C, 0x0E, 0xCC, 0xE0, 0xC0, 0x00, 0x0A, 0x02, 0x22, 0x29, 0x22, 0x92, 
                0x22, 0x2A, 0x00, 0xAC, 0x0C, 0xCD, 0xCC, 0xDC, 0xC0, 0x0A, 0x00, 0xA2, 0x22, 0x29, 0x26, 0x92, 
                0x22, 0x20, 0x00, 0x0C, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xC0, 0x00, 0x02, 0x22, 0x29, 0x69, 0x92, 
                0x62, 0x20, 0x00, 0x0C, 0xC8, 0xCC, 0xCC, 0xCC, 0x8C, 0xC0, 0x00, 0x02, 0x26, 0x29, 0x99, 0x99, 
                0x96, 0x60, 0x00, 0x0C, 0xCC, 0xCC, 0xEE, 0xCC, 0xCC, 0xC0, 0xC0, 0x06, 0x69, 0x99, 0x99, 0x99, 
                0x99, 0x90, 0x10, 0x0C, 0xCC, 0xCE, 0xCC, 0xEC, 0xCC, 0xC0, 0xC1, 0x09, 0x99, 0x99, 0x99, 0x19, 
                0x99, 0x91, 0x90, 0x0C, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xC0, 0xC9, 0x19, 0x99, 0x91, 0x99, 0x19, 
                0x99, 0x99, 0x91, 0x93, 0x03, 0x33, 0x33, 0x33, 0x33, 0x39, 0x19, 0x99, 0x91, 0x11, 0x99, 0x19, 
                0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x91, 0x11, 0x91, 0x99, 
                0x19, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x99, 0x90, 0xEC, 
                0x11, 0xEC, 0x11
            };

            byte[] rawData2 = {
                0x40, 0x26, 0xC5, 0x00, 0x06, 0xC0, 0x06, 0x10, 0x07, 0x90, 0x07, 0x30, 0x07, 0x40, 0x06, 0x10, 
                0x07, 0x40, 0x06, 0x90, 0x06, 0xF0, 0x06, 0xE0, 0x02, 0x00, 0x06, 0x60, 0x06, 0xC0, 0x06, 0x10, 
                0x06, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xAD, 0xB4, 0xD0, 
                0x07, 0x20, 0x04, 0x30, 0x07, 0x20, 0x06, 0xF0, 0x07, 0x30, 0x07, 0x30, 0x06, 0x10, 0x00, 0x00, 
                0x00, 0x00, 0x08, 0xAA, 0x85, 0x40, 0x06, 0x50, 0x07, 0x50, 0x04, 0x60, 0x06, 0xF0, 0x07, 0x20, 
                0x07, 0x40, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x03, 0x10, 0x03, 0x42, 0x41, 0x47, 0x4B, 0x4A, 
                0x4D, 0x4C, 0x49, 0x44, 0x14, 0x46, 0x40, 0xF7, 0xFE, 0xFC, 0x70, 0xA0, 0x90, 0x00, 0x0E, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x22, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x22, 0x22, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x22, 0x2E, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x22, 0xE2, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x22, 0xE2, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x22, 0xE2, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x22, 0xE2, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x22, 0xE2, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x22, 0xE2, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x22, 0xE2, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xE5, 0xEE, 0x62, 0x2E, 0x22, 0xE2, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xE5, 0xE6, 0x6E, 0x62, 0x2E, 0x22, 0xEE, 0x2E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xE6, 0x66, 0x6E, 0x52, 0x2E, 0x26, 0xE6, 0x66, 0x6E, 0x6E, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xE3, 0x35, 0x3E, 0x5E, 0xE2, 0x26, 0x26, 0x66, 0x66, 0x66, 0x6E, 0x6E, 0xEE, 0xEE, 0xEE, 
                0xE3, 0xE3, 0x3E, 0x3E, 0xEE, 0xE2, 0x26, 0x26, 0x6E, 0xEE, 0xE6, 0x6E, 0x6E, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xE3, 0x33, 0x33, 0x33, 0x32, 0x2E, 0x2E, 0xE6, 0xE6, 0x66, 0x6E, 0x6E, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xE3, 0x33, 0x3E, 0x32, 0x2E, 0x2E, 0xE6, 0x66, 0x6E, 0x6E, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x2E, 0x26, 0x66, 0x6E, 0x6E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE2, 0x23, 0x26, 0x3E, 0x6E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE3, 0x2E, 0x3E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 
                0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xE0, 0xEC, 
                0x11, 0xEC, 0x11
            };

            byte[] rawData3 = {
                0x40, 0x26, 0xC6, 0xB0, 0x06, 0xF0, 0x07, 0x40, 0x06, 0x10, 0x06, 0xB0, 0x07, 0x50, 0x00, 0x00, 
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0B, 0x6E, 0xA6, 0x90, 
                0x06, 0xD0, 0x06, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0x00, 0x00, 0x02, 0x6D, 0xB6, 0x90, 0x06, 0xD0, 0x06, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x07, 0x17, 0x47, 0x81, 0x11, 0x40, 
                0x7B, 0x6A, 0x4A, 0x63, 0x23, 0x43, 0x60, 0xFD, 0x46, 0x7C, 0x20, 0x00, 0x90, 0x00, 0x05, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x51, 0x55, 0x15, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x5E, 0x55, 0x15, 0x55, 0x52, 0x11, 
                0x15, 0x51, 0x15, 0xE5, 0x55, 0x55, 0x55, 0x55, 0x55, 0x5E, 0x51, 0xE5, 0x15, 0x51, 0x12, 0x11, 
                0x11, 0xEE, 0x11, 0xE1, 0x12, 0x11, 0x12, 0x11, 0x1E, 0x1E, 0x11, 0x15, 0xEE, 0x52, 0x2E, 0xE1, 
                0x1E, 0xEE, 0xEE, 0xEE, 0xEE, 0x1E, 0xEE, 0xEE, 0xEE, 0x1E, 0x1E, 0xE1, 0xE1, 0xEE, 0xEE, 0x51, 
                0x11, 0x1E, 0x11, 0x2E, 0xEE, 0x11, 0xE1, 0xE2, 0x1E, 0x11, 0x1E, 0x11, 0xE1, 0xE5, 0x55, 0x51, 
                0x11, 0xEE, 0x11, 0x2E, 0xEE, 0x11, 0xE1, 0xEE, 0xEE, 0x1E, 0x11, 0x11, 0xE1, 0xE5, 0x55, 0x51, 
                0x1E, 0xE1, 0x11, 0xE1, 0x1E, 0x11, 0xE1, 0xE1, 0x1E, 0x1E, 0x11, 0xE1, 0x11, 0x15, 0x55, 0x52, 
                0x1E, 0xE1, 0x1E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0x25, 0xE5, 0x55, 0x5E, 
                0xEE, 0xE1, 0xE5, 0x15, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x5E, 0xE5, 0xE5, 0x55, 0x55, 0x55, 
                0x5E, 0x52, 0xE5, 0x15, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x5E, 0xE5, 0xE5, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 
                0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x50, 0xEC, 
                0x11, 0xEC, 0x11
            };
            #endregion

            MemoryStream ms = new MemoryStream(rawData2);
            BinaryReader br = new BinaryReader(ms);

            Pattern p = new Pattern(br);

            testBox.Image = RenderPattern(p, 8);
        }

        private System.Drawing.Color FromPaletteColor(Color color)
        {
            return System.Drawing.Color.FromArgb(color.Red, color.Green, color.Blue);
        }

        private Image RenderPattern(Pattern pattern, int scale)
        {
            Bitmap bitmap = new Bitmap(Pattern.Width * scale, Pattern.Height * scale);
            
            for (int i = 0; i < Pattern.Width; i++)
                for (int j = 0; j < Pattern.Height; j++)
                {
                    Color c = pattern.GetPixel(i, j);

                    for (int x = 0; x < scale; x++)
                        for (int y = 0; y < scale; y++)
                            bitmap.SetPixel(scale * i + x, scale * j + y, FromPaletteColor(c));
                }

            return bitmap;
        }
    }
}
