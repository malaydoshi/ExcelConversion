namespace ExcelConversion
{
    partial class Form1
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
            this.lbl_target = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_selectedfiles = new System.Windows.Forms.TextBox();
            this.lbl_source = new System.Windows.Forms.Label();
            this.txt_destloc = new System.Windows.Forms.TextBox();
            this.btn_Process = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_target
            // 
            this.lbl_target.AutoSize = true;
            this.lbl_target.Location = new System.Drawing.Point(415, 63);
            this.lbl_target.Name = "lbl_target";
            this.lbl_target.Size = new System.Drawing.Size(111, 13);
            this.lbl_target.TabIndex = 1;
            this.lbl_target.Text = "Target Files Locations";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(12, 12);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(209, 23);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select Files";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_selectedfiles
            // 
            this.txt_selectedfiles.Location = new System.Drawing.Point(16, 104);
            this.txt_selectedfiles.Multiline = true;
            this.txt_selectedfiles.Name = "txt_selectedfiles";
            this.txt_selectedfiles.ReadOnly = true;
            this.txt_selectedfiles.Size = new System.Drawing.Size(362, 277);
            this.txt_selectedfiles.TabIndex = 3;
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Location = new System.Drawing.Point(13, 63);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(109, 13);
            this.lbl_source.TabIndex = 4;
            this.lbl_source.Text = "Source File Locations";
            // 
            // txt_destloc
            // 
            this.txt_destloc.Location = new System.Drawing.Point(418, 104);
            this.txt_destloc.Multiline = true;
            this.txt_destloc.Name = "txt_destloc";
            this.txt_destloc.ReadOnly = true;
            this.txt_destloc.Size = new System.Drawing.Size(359, 277);
            this.txt_destloc.TabIndex = 5;
            // 
            // btn_Process
            // 
            this.btn_Process.Location = new System.Drawing.Point(418, 12);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(212, 23);
            this.btn_Process.TabIndex = 6;
            this.btn_Process.Text = "Process Files";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 525);
            this.Controls.Add(this.btn_Process);
            this.Controls.Add(this.txt_destloc);
            this.Controls.Add(this.lbl_source);
            this.Controls.Add(this.txt_selectedfiles);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.lbl_target);
            this.Name = "Form1";
            this.Text = "Excel Convertor to .CSV Extension";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_target;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox txt_selectedfiles;
        private System.Windows.Forms.Label lbl_source;
        private System.Windows.Forms.TextBox txt_destloc;
        private System.Windows.Forms.Button btn_Process;
    }
}

