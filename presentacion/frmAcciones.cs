﻿using System;
using dominio;
using negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
using System.Globalization;

namespace presentacion
{
    public partial class frmAcciones : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAcciones()
        {
            InitializeComponent();
        }
        public frmAcciones(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmAcciones_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString("#0.00", System.Globalization.CultureInfo.InvariantCulture);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al cargar ventana.");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarArticulo()
        {
            if (cboMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione la marca del articulo.");
                return true;
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione la categoria del articulo.");
                return true;
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debes cargar el Código.");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debes cargar el Nombre.");
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debes cargar el Precio.");
                return true;
            }
            if (!(esDecimal(txtPrecio.Text)))
            {
                MessageBox.Show("Solo nros son admitidos en el precio, utilice punto para colocar decimales.");
                return true;
            }            
            return false;
        }
        private bool esDecimal(string cadena)
        {
            decimal resultado;
            if (decimal.TryParse(cadena, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out resultado))
            {
                return true;
            }
            return false;
        }
        private decimal pasarADecimal(string cadena)
        {
            decimal resultado;
            if (decimal.TryParse(cadena, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out resultado))
            {
                return resultado;
            }
            return -1;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarArticulo())
                    return;
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Precio = pasarADecimal(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                //Guardo imagen si la levantó localmente:
                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al guardar/modificar. Intente nuevamente.");
            }
        }


        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
