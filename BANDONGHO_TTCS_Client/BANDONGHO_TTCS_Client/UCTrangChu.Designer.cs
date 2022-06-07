
namespace BANDONGHO_TTCS_Client
{
    partial class UCTrangChu
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableAdapterManager = new BANDONGHO_TTCS_Client.DSetTableAdapters.TableAdapterManager();
            this.dSet = new BANDONGHO_TTCS_Client.DSet();
            this.bdsDongHo = new System.Windows.Forms.BindingSource(this.components);
            this.v_DONG_HOTableAdapter = new BANDONGHO_TTCS_Client.DSetTableAdapters.V_DONG_HOTableAdapter();
            this.btnTaiLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDongHo)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1261, 996);
            this.mainPanel.TabIndex = 14;
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
            // dSet
            // 
            this.dSet.DataSetName = "DSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDongHo
            // 
            this.bdsDongHo.DataMember = "V_DONG_HO";
            // 
            // v_DONG_HOTableAdapter
            // 
            this.v_DONG_HOTableAdapter.ClearBeforeFill = true;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiLai.Location = new System.Drawing.Point(1145, 0);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(92, 35);
            this.btnTaiLai.TabIndex = 1;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.button2_Click);
            // 
            // UCTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCTrangChu";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.Size = new System.Drawing.Size(1261, 1046);
            this.Load += new System.EventHandler(this.UCDongHo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDongHo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.BindingSource bdsDongHo;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DSet dSet;
        private DSetTableAdapters.V_DONG_HOTableAdapter v_DONG_HOTableAdapter;
        private System.Windows.Forms.Button btnTaiLai;
    }
}
