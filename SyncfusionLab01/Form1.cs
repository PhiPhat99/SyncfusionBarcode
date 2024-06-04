using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Barcode;

namespace SyncfusionLab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sfBarcode1_Load(object sender, EventArgs e)
        {
            SfBarcode sfDataGrid1 = new SfBarcode();
            sfBarcode1.Text = "https://help.syncfusion.com/windowsforms/barcode";
            this.Controls.Add(sfBarcode1);
            
            this.sfBarcode1.DarkBarColor = System.Drawing.Color.FromArgb(0, 0, 0);

            Code39Setting code39Settings = new Code39Setting();
            code39Settings.BarHeight = 100;
            code39Settings.NarrowBarWidth = 1;
            this.sfBarcode1.SymbologySettings = code39Settings;


        }
    }
}
