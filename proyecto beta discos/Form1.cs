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
            NegocioDiscos negocio = new NegocioDiscos();
            discos = negocio.listar();
            dgv1.DataSource = discos;
            dgv1.Columns["Imagen"].Visible = false;
            


        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgv1.CurrentRow.DataBoundItem;
            cargarimagen(seleccionado);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            frmaltadisco alta = new frmaltadisco();
            alta.ShowDialog();
        }

        public void cargarimagen(Discos disc)
        {
            try
            {
                pictureBox1.Load(disc.imagen);
            }
            catch (Exception)
            {
                if (disc.imagen =="")
                {
                    pictureBox1.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg");

                }
               
            }
        }
    }
}
