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
            this.labelGoodBye = new System.Windows.Forms.Label();
            this.ValidTicket = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelInvalidTicket = new System.Windows.Forms.Panel();
            this.labelInvalidTicket = new System.Windows.Forms.Label();
            this.pannelWelcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelValidTicket.SuspendLayout();
            this.panelInvalidTicket.SuspendLayout();
            this.pannelWelcome.SuspendLayout();
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
            this.panelValidTicket.Controls.Add(this.labelGoodBye);
            this.panelValidTicket.Controls.Add(this.ValidTicket);
            this.panelValidTicket.Location = new System.Drawing.Point(54, 317);
            this.panelValidTicket.Name = "panelValidTicket";
            this.panelValidTicket.Size = new System.Drawing.Size(1800, 700);
            this.panelValidTicket.TabIndex = 2;
            // 
            // labelGoodBye
            // 
            this.labelGoodBye.AutoSize = true;
            this.labelGoodBye.BackColor = System.Drawing.Color.PaleGreen;
            this.labelGoodBye.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGoodBye.Location = new System.Drawing.Point(359, 414);
            this.labelGoodBye.Name = "labelGoodBye";
            this.labelGoodBye.Size = new System.Drawing.Size(1155, 89);
            this.labelGoodBye.TabIndex = 4;
            this.labelGoodBye.Text = "Goodbye, hope to see you again soon";
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
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.PaleGreen;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWelcome.Location = new System.Drawing.Point(531, 414);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(790, 89);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome, enjoy your stay";
            // 
            // panelInvalidTicket
            // 
            this.panelInvalidTicket.BackColor = System.Drawing.Color.Crimson;
            this.panelInvalidTicket.Controls.Add(this.labelInvalidTicket);
            this.panelInvalidTicket.Location = new System.Drawing.Point(57, 317);
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
            // pannelWelcome
            // 
            this.pannelWelcome.BackColor = System.Drawing.Color.PaleGreen;
            this.pannelWelcome.Controls.Add(this.labelWelcome);
            this.pannelWelcome.Controls.Add(this.label1);
            this.pannelWelcome.Location = new System.Drawing.Point(57, 317);
            this.pannelWelcome.Name = "pannelWelcome";
            this.pannelWelcome.Size = new System.Drawing.Size(1800, 700);
            this.pannelWelcome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(633, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valid Ticket";
            // 
            // Check_in_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelValidTicket);
            this.Controls.Add(this.pannelWelcome);
            this.Controls.Add(this.panelInvalidTicket);
            this.Controls.Add(this.labelCheckInOut);
            this.Controls.Add(this.textBoxBarcodeString);
            this.Name = "Check_in_out";
            this.Text = "Check_in_out";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelValidTicket.ResumeLayout(false);
            this.panelValidTicket.PerformLayout();
            this.panelInvalidTicket.ResumeLayout(false);
            this.panelInvalidTicket.PerformLayout();
            this.pannelWelcome.ResumeLayout(false);
            this.pannelWelcome.PerformLayout();
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
        private Label labelWelcome;
        private Label labelGoodBye;
        private Panel pannelWelcome;
        private Label label1;
    }
}