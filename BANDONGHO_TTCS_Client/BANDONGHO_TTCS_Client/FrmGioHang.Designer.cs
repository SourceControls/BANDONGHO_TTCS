
namespace BANDONGHO_TTCS_Client
{
    partial class FrmGioHang
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
            this.components = new System.ComponentModel.Container();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.dSet = new BANDONGHO_TTCS_Client.DSet();
            this.bdsCTGH = new System.Windows.Forms.BindingSource(this.components);
            this.v_CT_GIO_HANGTableAdapter = new BANDONGHO_TTCS_Client.DSetTableAdapters.V_CT_GIO_HANGTableAdapter();
            this.tableAdapterManager = new BANDONGHO_TTCS_Client.DSetTableAdapters.TableAdapterManager();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTGH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(354, 717);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(138, 39);
            this.btnDatHang.TabIndex = 1;
            this.btnDatHang.Text = "Đặt Hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // dSet
            // 
            this.dSet.DataSetName = "DSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCTGH
            // 
            this.bdsCTGH.DataMember = "V_CT_GIO_HANG";
            this.bdsCTGH.DataSource = this.dSet;
            // 
            // v_CT_GIO_HANGTableAdapter
            // 
            this.v_CT_GIO_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_GIOHANGTableAdapter = null;
            this.tableAdapterManager.CT_KMTableAdapter = null;
            this.tableAdapterManager.CT_PDTableAdapter = null;
            this.tableAdapterManager.CT_PNTableAdapter = null;
            this.tableAdapterManager.DONGHOTableAdapter = null;
            this.tableAdapterManager.HANGDONGHOTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIDONGHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BANDONGHO_TTCS_Client.DSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(863, 708);
            this.mainPanel.TabIndex = 15;
            // 
            // FrmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 767);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnDatHang);
            this.Name = "FrmGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ Hàng";
            this.Load += new System.EventHandler(this.FrmGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTGH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDatHang;
        private DSet dSet;
        private System.Windows.Forms.BindingSource bdsCTGH;
        private DSetTableAdapters.V_CT_GIO_HANGTableAdapter v_CT_GIO_HANGTableAdapter;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
    }
}