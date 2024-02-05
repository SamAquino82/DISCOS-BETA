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
        private Discos disco = null;
        public frmaltadisco()
        {
            InitializeComponent();
        }
        public frmaltadisco(Discos disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar pokemon";
        }

        private void bttncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnaceptar_Click(object sender, EventArgs e)
        {
            NegocioDiscos negocio = new NegocioDiscos();
            try
            {
                if(disco==null)
                 disco = new Discos();

                disco.Nombre=txttitulo.Text;
                disco.lanzamiento=DateTime.Parse(txtfecha.Text);
                disco.ventas = int.Parse(txtventas.Text);
                disco.Tipo= (Estilo)cboestilo.SelectedItem;
                disco.Form=(Formato)cboformato.SelectedItem;

                if(disco.id!=0) {
                 negocio.modificar(disco);
                MessageBox.Show("modificado exitosamente");
                }
                else
                {
                negocio.agregar(disco);
                MessageBox.Show("agregado exitosamente");
                }
               

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
                cboestilo.ValueMember = "id";
                cboestilo.DisplayMember = "Descripcion";
                cboformato.DataSource = formato.Listar();
                cboformato.ValueMember = "id";
                cboformato.DisplayMember = "TipoDisc";

                if (disco != null) {
                    txttitulo.Text = disco.Nombre;
                    txtfecha.Text = disco.lanzamiento.ToString();
                    txtUrl.Text = disco.imagen;
                    txtventas.Text= disco.ventas.ToString();
                    cargarimagen(disco.imagen);
                    cboestilo.SelectedValue = disco.Tipo.id;
                    cboformato.SelectedValue=disco.Form.id;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarimagen(txtUrl.Text);
        }
        private void cargarimagen(string imagen)
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
    }
}
