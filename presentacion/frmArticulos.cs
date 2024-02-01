using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public frmArticulos()
        {
            InitializeComponent();
        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");

        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dtgArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dtgArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dtgArticulos.Columns["ImagenUrl"].Visible = false;
            dtgArticulos.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAcciones alta = new frmAcciones();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (dtgArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo en el listado.");
            }
            else
            {
                seleccionado = (Articulo)dtgArticulos.CurrentRow.DataBoundItem;

                frmAcciones modificar = new frmAcciones(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar(bool logico = false)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            if (dtgArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo en el listado.");
            }
            else
            {
                try
                {
                    DialogResult respuesta = MessageBox.Show("¿Querés eliminar el articulo? No hay marcha atras.", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dtgArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);

                        cargar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }        

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(esDecimal(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico, utilice punto para colocar decimales.");
                    return true;
                }

            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private bool esDecimal(string cadena)
        {
            decimal resultado;
            if (decimal.TryParse(cadena, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out resultado))
            //if (decimal.TryParse(cadena, NumberStyles.Number, CultureInfo.GetCultureInfo("es-ES"), out resultado))
            //if (decimal.TryParse(cadena, out resultado))
            {
                //MessageBox.Show(Convert.ToString(resultado) + "true"); //sale con coma pero la consulta da ok
                return true;
            }
            //MessageBox.Show(Convert.ToString(resultado) + "false"); 
            return false;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dtgArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dtgArticulos.DataSource = null;
            dtgArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnRecarga_Click(object sender, EventArgs e)
        {
            cargar();
        }
        private void dtgArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la columna actual es la columna que deseas formatear
            if (dtgArticulos.Columns[e.ColumnIndex].Name == "Precio")
            {
                if (e.Value != null)
                {
                    // Convertir el valor de la celda a un decimal
                    decimal valorDecimal;
                    if (decimal.TryParse(e.Value.ToString(), out valorDecimal))
                    {
                        // Aplicar el formato deseado
                        e.Value = valorDecimal.ToString("#,0.00", System.Globalization.CultureInfo.InvariantCulture);
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        // Si no se puede convertir a decimal, deja el valor sin formato
                        e.FormattingApplied = false;
                    }
                }
            }
        }
    }
}
