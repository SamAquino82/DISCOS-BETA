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
            cbocampo.Items.Clear();
            cbocampo.Items.Add("Numero");
            cbocampo.Items.Add("Nombre");
            cbocampo.Items.Add("Descripcion");
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
                dgv1.Columns["Activo"].Visible=false;
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Close();
            }
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv1 != null)
            {
                Discos seleccionado = (Discos)dgv1.CurrentRow.DataBoundItem;
                cargarimagen(seleccionado.imagen);

            }
           
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

        private void btneliminarfisica_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        private void btneliminarlogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        public void eliminar(bool logica = false)
        {
            try
            {
                NegocioDiscos negocio = new NegocioDiscos();
                Discos seleccionado = new Discos();
                seleccionado = (Discos)dgv1.CurrentRow.DataBoundItem;
                DialogResult resultado = MessageBox.Show("Estas seguro de eliminar el Disco" + seleccionado.Nombre.ToString(), "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    if (logica) {
                        negocio.eliminarlogica(seleccionado.id);
                    }
                    else 
                    {
                        negocio.eliminar(seleccionado);
                    }

                    refresh();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            NegocioDiscos negocio=new NegocioDiscos();
            try
            {
            string campo=cbocampo.SelectedItem.ToString();
            string criterio=cbocriterio.SelectedItem.ToString();
                string filtro = txtfiltroavanzado.Text;
            dgv1.DataSource = negocio.filtrar(campo,criterio,filtro);

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void txtfiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Discos> listafiltrada;
            string filtrar = txtfiltrar.Text;
            if (filtrar != "")
            {
                listafiltrada = discos.FindAll(x => x.Nombre.ToUpper().Contains(filtrar.ToUpper()));

            }
            else
            {
                listafiltrada = discos;

            }

            dgv1.DataSource = null;
            dgv1.DataSource = listafiltrada;
        }

        private void cbocampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion=cbocampo.SelectedItem.ToString();
            if (opcion == "Numero") {
            cbocriterio.Items.Clear();
                cbocriterio.Items.Add("Mayor a");
                cbocriterio.Items.Add("Menor a");
                cbocriterio.Items.Add("Igual a");
            }
            else
            { 
                cbocriterio.Items.Clear();
                cbocriterio.Items.Add("Comienza con");
                cbocriterio.Items.Add("Termina con");
                cbocriterio.Items.Add("Contiene a");
            }
        }

        private void txtfiltroavanzado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
