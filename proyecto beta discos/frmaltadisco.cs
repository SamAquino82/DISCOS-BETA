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
using Negocio;


namespace proyecto_beta_discos
{
    public partial class frmaltadisco : Form
    {
        public frmaltadisco()
        {
            InitializeComponent();
        }

        private void bttncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnaceptar_Click(object sender, EventArgs e)
        {
            Discos disco = new Discos();
            NegocioDiscos negocio = new NegocioDiscos();
            try
            {
                disco.Nombre=txttitulo.Text;
                disco.lanzamiento=DateTime.Parse(txtfecha.Text);
                disco.ventas = int.Parse(txtventas.Text);
                disco.Tipo= (Estilo)cboestilo.SelectedItem;
                disco.Form=(Formato)cboformato.SelectedItem;

                negocio.agregar(disco);
                MessageBox.Show("agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmaltadisco_Load(object sender, EventArgs e)
        {
            negocioformato formato =new negocioformato();
            NegocioEstilo estilo = new NegocioEstilo();
            try
            {
                cboestilo.DataSource = estilo.Listar();
                cboformato.DataSource = formato.Listar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
