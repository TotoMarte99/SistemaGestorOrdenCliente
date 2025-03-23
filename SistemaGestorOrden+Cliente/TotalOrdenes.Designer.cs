namespace SistemaGestorOrden_Cliente
{
    partial class TotalOrdenes
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
            dgvTotalOrdenes = new DataGridView();
            txtBuscarOrden = new TextBox();
            btnPDF = new Button();
            btnCargar0 = new Button();
            cmbOrdenes = new ComboBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTotalOrdenes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTotalOrdenes
            // 
            dgvTotalOrdenes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTotalOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTotalOrdenes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTotalOrdenes.BackgroundColor = SystemColors.Control;
            dgvTotalOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalOrdenes.Location = new Point(12, 167);
            dgvTotalOrdenes.Name = "dgvTotalOrdenes";
            dgvTotalOrdenes.RowHeadersWidth = 51;
            dgvTotalOrdenes.Size = new Size(1361, 431);
            dgvTotalOrdenes.TabIndex = 0;
            dgvTotalOrdenes.CellValueChanged += dgvTotalOrdenes_CellValueChanged;
            // 
            // txtBuscarOrden
            // 
            txtBuscarOrden.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscarOrden.Location = new Point(204, 56);
            txtBuscarOrden.Name = "txtBuscarOrden";
            txtBuscarOrden.Size = new Size(134, 27);
            txtBuscarOrden.TabIndex = 2;
            txtBuscarOrden.TextChanged += txtBuscarOrden_TextChanged;
            // 
            // btnPDF
            // 
            btnPDF.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPDF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPDF.Location = new Point(15, 98);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(193, 39);
            btnPDF.TabIndex = 3;
            btnPDF.Text = "Generar PDF de Orden";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnCargar0
            // 
            btnCargar0.BackColor = Color.Crimson;
            btnCargar0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar0.ForeColor = Color.WhiteSmoke;
            btnCargar0.Location = new Point(12, 132);
            btnCargar0.Name = "btnCargar0";
            btnCargar0.Size = new Size(36, 29);
            btnCargar0.TabIndex = 6;
            btnCargar0.Text = "X";
            btnCargar0.UseVisualStyleBackColor = false;
            btnCargar0.Click += btnCargar0_Click;
            // 
            // cmbOrdenes
            // 
            cmbOrdenes.FormattingEnabled = true;
            cmbOrdenes.Location = new Point(15, 55);
            cmbOrdenes.Name = "cmbOrdenes";
            cmbOrdenes.Size = new Size(151, 28);
            cmbOrdenes.TabIndex = 7;
            cmbOrdenes.SelectedIndexChanged += cmbOrdenes_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbOrdenes);
            groupBox1.Controls.Add(btnPDF);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBuscarOrden);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1001, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 149);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 35);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 25;
            label4.Text = "¿Que dato buscar?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 35);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 24;
            label2.Text = "Ingresar:";
            // 
            // TotalOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1385, 610);
            Controls.Add(groupBox1);
            Controls.Add(btnCargar0);
            Controls.Add(dgvTotalOrdenes);
            Name = "TotalOrdenes";
            Text = "TotalOrdenes";
            Load += TotalOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTotalOrdenes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTotalOrdenes;
        private TextBox txtBuscarOrden;
        private Button btnPDF;
        private Button btnCargar0;
        private ComboBox cmbOrdenes;
        private GroupBox groupBox1;
        private Label label4;
        private Label label2;
    }
}