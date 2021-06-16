namespace OrderedNotes
{
    partial class MainForm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.inSens = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTopmost = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.inSens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTopmost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Note";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(107, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(91, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // inSens
            // 
            this.inSens.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inSens.Location = new System.Drawing.Point(78, 55);
            this.inSens.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.inSens.Name = "inSens";
            this.inSens.Size = new System.Drawing.Size(149, 20);
            this.inSens.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sensitivity:";
            // 
            // btnTopmost
            // 
            this.btnTopmost.Image = global::OrderedNotes.Properties.Resources.pin_on;
            this.btnTopmost.Location = new System.Drawing.Point(204, 12);
            this.btnTopmost.Name = "btnTopmost";
            this.btnTopmost.Size = new System.Drawing.Size(23, 23);
            this.btnTopmost.TabIndex = 4;
            this.btnTopmost.TabStop = false;
            this.btnTopmost.Click += new System.EventHandler(this.btnTopmost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 87);
            this.Controls.Add(this.btnTopmost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inSens);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnNew);
            this.Name = "MainForm";
            this.Text = "Ordered Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inSens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTopmost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.NumericUpDown inSens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnTopmost;
    }
}

