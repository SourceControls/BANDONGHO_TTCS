
namespace BANDONGHO_TTCS
{
    partial class UCRestore
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
            this.btnRestoreDF = new System.Windows.Forms.Button();
            this.btnRestoreLog = new System.Windows.Forms.Button();
            this.btnRestoreFull = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnThoat);
            this.panelControl1.Controls.Add(this.btnRestoreDF);
            this.panelControl1.Controls.Add(this.btnRestoreLog);
            this.panelControl1.Controls.Add(this.btnRestoreFull);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1005, 409);
            this.panelControl1.TabIndex = 1;
            // 
            // btnRestoreDF
            // 
            this.btnRestoreDF.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDF.Location = new System.Drawing.Point(299, 168);
            this.btnRestoreDF.Name = "btnRestoreDF";
            this.btnRestoreDF.Size = new System.Drawing.Size(252, 62);
            this.btnRestoreDF.TabIndex = 2;
            this.btnRestoreDF.Text = "Restore From Differential Backup";
            this.btnRestoreDF.UseVisualStyleBackColor = true;
            this.btnRestoreDF.Click += new System.EventHandler(this.btnRestoreDF_Click);
            // 
            // btnRestoreLog
            // 
            this.btnRestoreLog.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreLog.Location = new System.Drawing.Point(608, 168);
            this.btnRestoreLog.Name = "btnRestoreLog";
            this.btnRestoreLog.Size = new System.Drawing.Size(173, 62);
            this.btnRestoreLog.TabIndex = 1;
            this.btnRestoreLog.Text = "Restore From Log Backup";
            this.btnRestoreLog.UseVisualStyleBackColor = true;
            this.btnRestoreLog.Click += new System.EventHandler(this.btnRestoreLog_Click);
            // 
            // btnRestoreFull
            // 
            this.btnRestoreFull.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreFull.Location = new System.Drawing.Point(23, 168);
            this.btnRestoreFull.Name = "btnRestoreFull";
            this.btnRestoreFull.Size = new System.Drawing.Size(243, 62);
            this.btnRestoreFull.TabIndex = 0;
            this.btnRestoreFull.Text = "Restore From Full Backup";
            this.btnRestoreFull.UseVisualStyleBackColor = true;
            this.btnRestoreFull.Click += new System.EventHandler(this.btnRestoreFull_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(832, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 62);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // UCRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UCRestore";
            this.Size = new System.Drawing.Size(1005, 409);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnRestoreDF;
        private System.Windows.Forms.Button btnRestoreLog;
        private System.Windows.Forms.Button btnRestoreFull;
        private System.Windows.Forms.Button btnThoat;
    }
}
