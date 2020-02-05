namespace PrinterStateTool
{
    partial class FormPrinterStateTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxAvailablePrinters = new System.Windows.Forms.ComboBox();
            this.GroupBoxPrinter = new System.Windows.Forms.GroupBox();
            this.LabelState = new System.Windows.Forms.Label();
            this.LabelAvailablePrinters = new System.Windows.Forms.Label();
            this.GroupBoxQueue = new System.Windows.Forms.GroupBox();
            this.TextBoxQueue = new System.Windows.Forms.TextBox();
            this.GroupBoxProperties = new System.Windows.Forms.GroupBox();
            this.TextBoxProperties = new System.Windows.Forms.TextBox();
            this.GroupBoxPrinter.SuspendLayout();
            this.GroupBoxQueue.SuspendLayout();
            this.GroupBoxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxAvailablePrinters
            // 
            this.ComboBoxAvailablePrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAvailablePrinters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxAvailablePrinters.FormattingEnabled = true;
            this.ComboBoxAvailablePrinters.Location = new System.Drawing.Point(131, 16);
            this.ComboBoxAvailablePrinters.Name = "ComboBoxAvailablePrinters";
            this.ComboBoxAvailablePrinters.Size = new System.Drawing.Size(352, 21);
            this.ComboBoxAvailablePrinters.TabIndex = 0;
            this.ComboBoxAvailablePrinters.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAvailablePrinters_SelectedIndexChanged);
            // 
            // GroupBoxPrinter
            // 
            this.GroupBoxPrinter.Controls.Add(this.LabelState);
            this.GroupBoxPrinter.Controls.Add(this.LabelAvailablePrinters);
            this.GroupBoxPrinter.Controls.Add(this.ComboBoxAvailablePrinters);
            this.GroupBoxPrinter.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxPrinter.Name = "GroupBoxPrinter";
            this.GroupBoxPrinter.Size = new System.Drawing.Size(555, 70);
            this.GroupBoxPrinter.TabIndex = 1;
            this.GroupBoxPrinter.TabStop = false;
            this.GroupBoxPrinter.Text = "Printer";
            // 
            // LabelState
            // 
            this.LabelState.AutoSize = true;
            this.LabelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelState.Location = new System.Drawing.Point(257, 44);
            this.LabelState.Name = "LabelState";
            this.LabelState.Size = new System.Drawing.Size(0, 15);
            this.LabelState.TabIndex = 2;
            // 
            // LabelAvailablePrinters
            // 
            this.LabelAvailablePrinters.AutoSize = true;
            this.LabelAvailablePrinters.Location = new System.Drawing.Point(26, 19);
            this.LabelAvailablePrinters.Name = "LabelAvailablePrinters";
            this.LabelAvailablePrinters.Size = new System.Drawing.Size(88, 13);
            this.LabelAvailablePrinters.TabIndex = 1;
            this.LabelAvailablePrinters.Text = "Available Printers";
            // 
            // GroupBoxQueue
            // 
            this.GroupBoxQueue.Controls.Add(this.TextBoxQueue);
            this.GroupBoxQueue.Location = new System.Drawing.Point(13, 89);
            this.GroupBoxQueue.Name = "GroupBoxQueue";
            this.GroupBoxQueue.Size = new System.Drawing.Size(554, 221);
            this.GroupBoxQueue.TabIndex = 2;
            this.GroupBoxQueue.TabStop = false;
            this.GroupBoxQueue.Text = "Queue";
            // 
            // TextBoxQueue
            // 
            this.TextBoxQueue.BackColor = System.Drawing.Color.White;
            this.TextBoxQueue.Location = new System.Drawing.Point(13, 19);
            this.TextBoxQueue.Multiline = true;
            this.TextBoxQueue.Name = "TextBoxQueue";
            this.TextBoxQueue.ReadOnly = true;
            this.TextBoxQueue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxQueue.Size = new System.Drawing.Size(526, 196);
            this.TextBoxQueue.TabIndex = 0;
            // 
            // GroupBoxProperties
            // 
            this.GroupBoxProperties.Controls.Add(this.TextBoxProperties);
            this.GroupBoxProperties.Location = new System.Drawing.Point(13, 316);
            this.GroupBoxProperties.Name = "GroupBoxProperties";
            this.GroupBoxProperties.Size = new System.Drawing.Size(554, 114);
            this.GroupBoxProperties.TabIndex = 3;
            this.GroupBoxProperties.TabStop = false;
            this.GroupBoxProperties.Text = "Properties";
            // 
            // TextBoxProperties
            // 
            this.TextBoxProperties.BackColor = System.Drawing.Color.White;
            this.TextBoxProperties.Location = new System.Drawing.Point(13, 19);
            this.TextBoxProperties.Multiline = true;
            this.TextBoxProperties.Name = "TextBoxProperties";
            this.TextBoxProperties.ReadOnly = true;
            this.TextBoxProperties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxProperties.Size = new System.Drawing.Size(526, 89);
            this.TextBoxProperties.TabIndex = 1;
            // 
            // FormPrinterStateTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 446);
            this.Controls.Add(this.GroupBoxProperties);
            this.Controls.Add(this.GroupBoxQueue);
            this.Controls.Add(this.GroupBoxPrinter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPrinterStateTool";
            this.Text = "Printer State Tool";
            this.Load += new System.EventHandler(this.FormPrinterStateTool_Load);
            this.GroupBoxPrinter.ResumeLayout(false);
            this.GroupBoxPrinter.PerformLayout();
            this.GroupBoxQueue.ResumeLayout(false);
            this.GroupBoxQueue.PerformLayout();
            this.GroupBoxProperties.ResumeLayout(false);
            this.GroupBoxProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxAvailablePrinters;
        private System.Windows.Forms.GroupBox GroupBoxPrinter;
        private System.Windows.Forms.Label LabelAvailablePrinters;
        private System.Windows.Forms.GroupBox GroupBoxQueue;
        private System.Windows.Forms.GroupBox GroupBoxProperties;
        private System.Windows.Forms.TextBox TextBoxQueue;
        private System.Windows.Forms.TextBox TextBoxProperties;
        private System.Windows.Forms.Label LabelState;
    }
}

