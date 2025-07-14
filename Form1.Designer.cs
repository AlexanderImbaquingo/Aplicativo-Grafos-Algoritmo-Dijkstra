namespace Aplicativo.Dijkstra
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNumNodos;
        private System.Windows.Forms.TextBox txtNumNodos;
        private System.Windows.Forms.Label lblAristas;
        private System.Windows.Forms.DataGridView dgvAristas;
        private System.Windows.Forms.Label lblNodoInicial;
        private System.Windows.Forms.ComboBox cmbNodoInicial;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.DataGridView dgvResultados;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNumNodos = new System.Windows.Forms.Label();
            this.txtNumNodos = new System.Windows.Forms.TextBox();
            this.lblAristas = new System.Windows.Forms.Label();
            this.dgvAristas = new System.Windows.Forms.DataGridView();
            this.lblNodoInicial = new System.Windows.Forms.Label();
            this.cmbNodoInicial = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAristas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumNodos
            // 
            this.lblNumNodos.AutoSize = true;
            this.lblNumNodos.Location = new System.Drawing.Point(20, 20);
            this.lblNumNodos.Name = "lblNumNodos";
            this.lblNumNodos.Size = new System.Drawing.Size(99, 13);
            this.lblNumNodos.TabIndex = 0;
            this.lblNumNodos.Text = "Cantidad de nodos:";
            // 
            // txtNumNodos
            // 
            this.txtNumNodos.Location = new System.Drawing.Point(150, 17);
            this.txtNumNodos.Name = "txtNumNodos";
            this.txtNumNodos.Size = new System.Drawing.Size(50, 20);
            this.txtNumNodos.TabIndex = 1;
            // 
            // lblAristas
            // 
            this.lblAristas.AutoSize = true;
            this.lblAristas.Location = new System.Drawing.Point(20, 55);
            this.lblAristas.Name = "lblAristas";
            this.lblAristas.Size = new System.Drawing.Size(153, 13);
            this.lblAristas.TabIndex = 2;
            this.lblAristas.Text = "Aristas (Origen, Destino, Peso):";
            // 
            // dgvAristas
            // 
            this.dgvAristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAristas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvAristas.Location = new System.Drawing.Point(20, 75);
            this.dgvAristas.Name = "dgvAristas";
            this.dgvAristas.Size = new System.Drawing.Size(350, 150);
            this.dgvAristas.TabIndex = 3;
            // 
            // lblNodoInicial
            // 
            this.lblNodoInicial.AutoSize = true;
            this.lblNodoInicial.Location = new System.Drawing.Point(400, 20);
            this.lblNodoInicial.Name = "lblNodoInicial";
            this.lblNodoInicial.Size = new System.Drawing.Size(65, 13);
            this.lblNodoInicial.TabIndex = 4;
            this.lblNodoInicial.Text = "Nodo inicial:";
            // 
            // cmbNodoInicial
            // 
            this.cmbNodoInicial.Location = new System.Drawing.Point(480, 17);
            this.cmbNodoInicial.Name = "cmbNodoInicial";
            this.cmbNodoInicial.Size = new System.Drawing.Size(60, 21);
            this.cmbNodoInicial.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(400, 55);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(140, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular caminos mínimos";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(20, 240);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(92, 13);
            this.lblResultados.TabIndex = 7;
            this.lblResultados.Text = "Caminos mínimos:";
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvResultados.Location = new System.Drawing.Point(20, 260);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(520, 150);
            this.dgvResultados.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Origen";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Camino";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Peso Total";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(619, 476);
            this.Controls.Add(this.lblNumNodos);
            this.Controls.Add(this.txtNumNodos);
            this.Controls.Add(this.lblAristas);
            this.Controls.Add(this.dgvAristas);
            this.Controls.Add(this.lblNodoInicial);
            this.Controls.Add(this.cmbNodoInicial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.dgvResultados);
            this.Name = "Form1";
            this.Text = "Camino mínimo - Dijkstra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAristas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

