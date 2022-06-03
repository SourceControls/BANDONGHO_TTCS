
namespace BANDONGHO_TTCS
{
    partial class UCBackup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDFBK = new System.Windows.Forms.Button();
            this.btnLogBK = new System.Windows.Forms.Button();
            this.btnFullBK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnDFBK);
            this.panelControl1.Controls.Add(this.btnLogBK);
            this.panelControl1.Controls.Add(this.btnFullBK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(875, 428);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(668, 167);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 62);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDFBK
            // 
            this.btnDFBK.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFBK.Location = new System.Drawing.Point(243, 167);
            this.btnDFBK.Name = "btnDFBK";
            this.btnDFBK.Size = new System.Drawing.Size(171, 62);
            this.btnDFBK.TabIndex = 2;
            this.btnDFBK.Text = "Differential Backup";
            this.btnDFBK.UseVisualStyleBackColor = true;
            this.btnDFBK.Click += new System.EventHandler(this.btnDFBK_Click);
            // 
            // btnLogBK
            // 
            this.btnLogBK.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogBK.Location = new System.Drawing.Point(460, 167);
            this.btnLogBK.Name = "btnLogBK";
            this.btnLogBK.Size = new System.Drawing.Size(162, 62);
            this.btnLogBK.TabIndex = 1;
            this.btnLogBK.Text = "Log Backup";
            this.btnLogBK.UseVisualStyleBackColor = true;
            this.btnLogBK.Click += new System.EventHandler(this.btnLogBK_Click);
            // 
            // btnFullBK
            // 
            this.btnFullBK.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullBK.Location = new System.Drawing.Point(32, 167);
            this.btnFullBK.Name = "btnFullBK";
            this.btnFullBK.Size = new System.Drawing.Size(164, 62);
            this.btnFullBK.TabIndex = 0;
            this.btnFullBK.Text = "Full Backup";
            this.btnFullBK.UseVisualStyleBackColor = true;
            this.btnFullBK.Click += new System.EventHandler(this.btnFullBK_Click);
            // 
            // UCBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCBackup";
            this.Size = new System.Drawing.Size(875, 428);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnDFBK;
        private System.Windows.Forms.Button btnLogBK;
        private System.Windows.Forms.Button btnFullBK;
        private System.Windows.Forms.Button btnThoat;
    }
}
