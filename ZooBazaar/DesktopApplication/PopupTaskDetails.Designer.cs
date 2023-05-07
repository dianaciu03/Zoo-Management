namespace DesktopApplication
{
    partial class PopupTaskDetails
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
            btnCloseDetails = new Button();
            SuspendLayout();
            // 
            // btnCloseDetails
            // 
            btnCloseDetails.Location = new Point(28, 657);
            btnCloseDetails.Name = "btnCloseDetails";
            btnCloseDetails.Size = new Size(204, 37);
            btnCloseDetails.TabIndex = 10;
            btnCloseDetails.Text = "Close";
            btnCloseDetails.UseVisualStyleBackColor = true;
            btnCloseDetails.Click += btnCloseDetails_Click;
            // 
            // PopupTaskDetails
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 706);
            Controls.Add(btnCloseDetails);
            Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "PopupTaskDetails";
            Text = "PopupTaskDetails";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnCloseDetails;
    }
}