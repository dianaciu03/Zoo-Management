namespace DesktopApplication
{
    partial class Check_in_out
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
            this.textBoxBarcodeString = new System.Windows.Forms.TextBox();
            this.labelCheckInOut = new System.Windows.Forms.Label();
            this.panelValidTicket = new System.Windows.Forms.Panel();
            this.ValidTicket = new System.Windows.Forms.Label();
            this.panelInvalidTicket = new System.Windows.Forms.Panel();
            this.labelInvalidTicket = new System.Windows.Forms.Label();
            this.panelValidTicket.SuspendLayout();
            this.panelInvalidTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBarcodeString
            // 
            this.textBoxBarcodeString.Location = new System.Drawing.Point(730, 240);
            this.textBoxBarcodeString.Name = "textBoxBarcodeString";
            this.textBoxBarcodeString.Size = new System.Drawing.Size(460, 23);
            this.textBoxBarcodeString.TabIndex = 0;
            this.textBoxBarcodeString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarcodeString_KeyDown);
            // 
            // labelCheckInOut
            // 
            this.labelCheckInOut.AutoSize = true;
            this.labelCheckInOut.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCheckInOut.Location = new System.Drawing.Point(769, 200);
            this.labelCheckInOut.Name = "labelCheckInOut";
            this.labelCheckInOut.Size = new System.Drawing.Size(382, 40);
            this.labelCheckInOut.TabIndex = 1;
            this.labelCheckInOut.Text = "Zoo Check-in and Check-out";
            // 
            // panelValidTicket
            // 
            this.panelValidTicket.BackColor = System.Drawing.Color.PaleGreen;
            this.panelValidTicket.Controls.Add(this.ValidTicket);
            this.panelValidTicket.Location = new System.Drawing.Point(60, 320);
            this.panelValidTicket.Name = "panelValidTicket";
            this.panelValidTicket.Size = new System.Drawing.Size(1800, 700);
            this.panelValidTicket.TabIndex = 2;
            // 
            // ValidTicket
            // 
            this.ValidTicket.AutoSize = true;
            this.ValidTicket.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValidTicket.Location = new System.Drawing.Point(633, 286);
            this.ValidTicket.Name = "ValidTicket";
            this.ValidTicket.Size = new System.Drawing.Size(533, 128);
            this.ValidTicket.TabIndex = 0;
            this.ValidTicket.Text = "Valid Ticket";
            // 
            // panelInvalidTicket
            // 
            this.panelInvalidTicket.BackColor = System.Drawing.Color.Crimson;
            this.panelInvalidTicket.Controls.Add(this.labelInvalidTicket);
            this.panelInvalidTicket.Location = new System.Drawing.Point(57, 320);
            this.panelInvalidTicket.Name = "panelInvalidTicket";
            this.panelInvalidTicket.Size = new System.Drawing.Size(1800, 700);
            this.panelInvalidTicket.TabIndex = 3;
            // 
            // labelInvalidTicket
            // 
            this.labelInvalidTicket.AutoSize = true;
            this.labelInvalidTicket.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInvalidTicket.Location = new System.Drawing.Point(612, 286);
            this.labelInvalidTicket.Name = "labelInvalidTicket";
            this.labelInvalidTicket.Size = new System.Drawing.Size(606, 128);
            this.labelInvalidTicket.TabIndex = 0;
            this.labelInvalidTicket.Text = "Invalid Ticket";
            // 
            // Check_in_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelInvalidTicket);
            this.Controls.Add(this.panelValidTicket);
            this.Controls.Add(this.labelCheckInOut);
            this.Controls.Add(this.textBoxBarcodeString);
            this.Name = "Check_in_out";
            this.Text = "Check_in_out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelValidTicket.ResumeLayout(false);
            this.panelValidTicket.PerformLayout();
            this.panelInvalidTicket.ResumeLayout(false);
            this.panelInvalidTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxBarcodeString;
        private Label labelCheckInOut;
        private Panel panelValidTicket;
        private Panel panelInvalidTicket;
        private Label labelInvalidTicket;
        private Label ValidTicket;
    }
}