using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;


namespace proyecto_beta_discos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Discos> discos = new List<Discos>();
        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            try
            {
                NegocioDiscos negocio = new NegocioDiscos();
                discos = negocio.listar();
                dgv1.DataSource = discos;
                dgv1.Columns["Imagen"].Visible = false;
                dgv1.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Close();
            }
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgv1.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado.imagen);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            frmaltadisco alta = new frmaltadisco();
            alta.ShowDialog();
            refresh();
        }

        public void cargarimagen(string imagen)
        {
            try
            {
                pbxDiscos.Load(imagen);
            }
            catch (Exception)
            {
                if (imagen == null || imagen == "")
                {
                    pbxDiscos.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");

                }
               
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Discos seleccionado=new Discos();
            seleccionado = (Discos)dgv1.CurrentRow.DataBoundItem;
            frmaltadisco alta = new frmaltadisco(seleccionado);
            alta.ShowDialog();
            refresh();

        }
    }
}
