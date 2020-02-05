using System;
using System.Windows.Forms;
using System.Drawing;
using PrinterState;

namespace PrinterStateTool
{
    public partial class FormPrinterStateTool : Form
    {
        public FormPrinterStateTool()
        {
            InitializeComponent();
        }

        private void FormPrinterStateTool_Load(object sender, EventArgs e)
        {
            var printers = PrinterInfo.GetAllPrinters();
            foreach (var printer in printers)
            {
                ComboBoxAvailablePrinters.Items.Add(printer);
            }
        }

        private void ComboBoxAvailablePrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxQueue.Text = string.Empty;
            TextBoxProperties.Text = string.Empty;

            if (ComboBoxAvailablePrinters.SelectedIndex >= 0)
            {
                var printerName = ComboBoxAvailablePrinters.SelectedItem.ToString();
                var printerInfo = new PrinterInfo(printerName);

                SetQueueInfo(printerInfo);
                SetPropertiesInfo(printerInfo);

                if (PrinterInfo.IsOk)
                {
                    LabelState.Text = "OK";
                    LabelState.ForeColor = Color.Green;
                }
                else
                {
                    LabelState.Text = "NOT OK";
                    LabelState.ForeColor = Color.Red;
                }
            }
        }

        private void SetQueueInfo(PrinterInfo printerInfo)
        {
            try
            {
                TextBoxQueue.Text = printerInfo.GetQueueInfo();
            }
            catch (Exception ex)
            {
                TextBoxQueue.Text = ex.Message + Environment.NewLine + Environment.NewLine + ex.ToString();
            }
        }

        private void SetPropertiesInfo(PrinterInfo printerInfo)
        {
            try
            {
                TextBoxProperties.Text = printerInfo.GetProperties();
            }
            catch (Exception ex)
            {
                TextBoxProperties.Text = ex.Message + Environment.NewLine + Environment.NewLine + ex.ToString();
            }
        }
    }
}