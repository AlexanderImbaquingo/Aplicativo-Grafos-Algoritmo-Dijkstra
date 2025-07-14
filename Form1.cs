using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aplicativo.Dijkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtNumNodos.TextChanged += TxtNumNodos_TextChanged;
            btnCalcular.Click += BtnCalcular_Click;
        }

        private void TxtNumNodos_TextChanged(object sender, EventArgs e)
        {
            cmbNodoInicial.Items.Clear();
            int numNodos;
            if (int.TryParse(txtNumNodos.Text, out numNodos) && numNodos > 0)
            {
                for (int i = 1; i <= numNodos; i++)
                {
                    cmbNodoInicial.Items.Add(i);
                }
                if (cmbNodoInicial.Items.Count > 0)
                    cmbNodoInicial.SelectedIndex = 0;
            }
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int numNodos;
            if (!int.TryParse(txtNumNodos.Text, out numNodos) || numNodos <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de nodos.");
                return;
            }

            if (cmbNodoInicial.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el nodo inicial.");
                return;
            }

            int nodoInicial = Convert.ToInt32(cmbNodoInicial.SelectedItem);

            Grafo grafo = new Grafo(numNodos);

            // Leer aristas del DataGridView
            foreach (DataGridViewRow row in dgvAristas.Rows)
            {
                if (row.IsNewRow) continue;
                int origen, destino, peso;
                if (int.TryParse(row.Cells["Origen"].Value?.ToString(), out origen) &&
                    int.TryParse(row.Cells["Destino"].Value?.ToString(), out destino) &&
                    int.TryParse(row.Cells["Peso"].Value?.ToString(), out peso))
                {
                    grafo.AgregarArista(origen, destino, peso);
                }
            }

            var resultados = SolucionDijkstra.Calcular(grafo, nodoInicial);

            dgvResultados.Rows.Clear();
            foreach (var resultado in resultados)
            {
                string caminoStr = resultado.Camino.Count > 0 ? string.Join(" → ", resultado.Camino) : "No hay camino";
                string pesoStr = resultado.PesoTotal == int.MaxValue ? "∞" : resultado.PesoTotal.ToString();
                dgvResultados.Rows.Add(resultado.Destino, caminoStr, pesoStr);
            }
        }

        private void dgvAristas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
