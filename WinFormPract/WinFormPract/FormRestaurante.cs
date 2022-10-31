using System.Data;
using System.Diagnostics.Contracts;

namespace WinFormPract
{
    public partial class FormRestaurante : Form
    {
        public FormRestaurante()
        {
            InitializeComponent();
        }

        #region Ayuda

        public enum ModoEdicion
        {
            lectura, 
            crear,
            modificar
        }

        public ModoEdicion modoEdicion;

        private void FormRestaurante_Load(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.lectura;
            ModoPantallaLectura();

            CargarYConfigurarGrid();
        }

        public void ModoPantallaLectura()
        {
            txtNombre.Text = "";
            dtpFechaApertura.Value = DateTime.Now;
            txtCalle.Text = "";
            txtNumero.Text = "";
            txtOpiniones.Text = "";
            txtId.Text = "";

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnyadir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            txtNombre.Enabled = false;
            dtpFechaApertura.Enabled = false;
            txtOpiniones.Enabled = false;
            txtCalle.Enabled = false;
            txtNumero.Enabled = false;
            txtId.Enabled = false;

            dgvRestaurantes.Enabled = true;
        }

        public void ModoPantallaEdicion()
        {
            if (modoEdicion == ModoEdicion.crear)
            {
                txtNombre.Text = "";
                dtpFechaApertura.Value = DateTime.Now;
                txtCalle.Text = "";
                txtNumero.Text = "";
                txtOpiniones.Text = "";
                txtId.Text = "";

            }

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Enabled = true;
            dtpFechaApertura.Enabled = true;
            txtCalle.Enabled = true;
            txtNumero.Enabled = true;
            txtOpiniones.Enabled = true;
            txtId.Enabled = false;

            btnAnyadir.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            dgvRestaurantes.Enabled = false;


        }

        public Restaurante ObtenerInformacion()
        {
            Restaurante restaurante = new Restaurante();

            restaurante.nombre = txtNombre.Text;
            restaurante.calle = txtCalle.Text;
            restaurante.numero = Convert.ToInt32(txtNumero.Text);
            restaurante.fechaApertura = dtpFechaApertura.Value;
            restaurante.opinion = txtOpiniones.Text;

            if (!String.IsNullOrEmpty(txtId.Text))
            {
                restaurante.Id = Convert.ToInt32(txtId.Text);
            }

            return restaurante;
        }

        public void CargarYConfigurarGrid()
        {
            DataSet ds = Repository.ObtenerRestaurantes();
            dgvRestaurantes.DataSource = ds.Tables[0];

            // Tamaños columnas
            dgvRestaurantes.Columns["Id"].Width = 40;
            dgvRestaurantes.Columns["Nombre"].Width = 150;
            dgvRestaurantes.Columns["FechaApertura"].Width = 150;
            dgvRestaurantes.Columns["Calle"].Width = 120;
            dgvRestaurantes.Columns["Numero"].Width = 40;
            dgvRestaurantes.Columns["Opinion"].Width = 300;

            // Renombrado columnas
            dgvRestaurantes.Columns["FechaApertura"].HeaderText = "Fecha Apertura";

            // Formato fecha en español
            dgvRestaurantes.Columns["FechaApertura"].DefaultCellStyle.Format = "dd/MM/yyyy";

            // Seleccionamos la primera fila del grid si existe
            SeleccionarPrimeraFilaGrid();

        }

        public void SeleccionarPrimeraFilaGrid()
        {
            // Si hay alguna fila, seleccionamos la primera
            if (dgvRestaurantes.Rows.Count > 0)
            {
                dgvRestaurantes.Rows[0].Selected = true;
            }
        }

        public void CargarInfoFilaSeleccionadaFormulario(DataGridViewRow filaSeleccionada)
        {
            txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            dtpFechaApertura.Value = (DateTime)filaSeleccionada.Cells["FechaApertura"].Value;
            txtCalle.Text = filaSeleccionada.Cells["Calle"].Value.ToString();
            txtNumero.Text = filaSeleccionada.Cells["Numero"].Value.ToString();
            txtOpiniones.Text = filaSeleccionada.Cells["Opinion"].Value.ToString();

        }

        public bool InformacionObligatoriaCumplimentada()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtCalle.Text) || String.IsNullOrEmpty(txtNumero.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion 

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.crear;

            ModoPantallaEdicion();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool correcto = false;
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Restaurante r = ObtenerInformacion();
                correcto = Repository.EliminarRestaurante(r);

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acción se ha realizado correctamente.");
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acción, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modoEdicion = ModoEdicion.modificar;
            ModoPantallaEdicion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = false;

            if (InformacionObligatoriaCumplimentada())
            {
                // Rellenamos la entidad con la información
                Restaurante r = ObtenerInformacion();

                switch (modoEdicion)
                {
                    case ModoEdicion.crear:
                        correcto = Repository.CrearRestaurante(r);
                        break;
                    case ModoEdicion.modificar:
                        correcto = Repository.ModificarRestaurante(r);
                        break;
                }

                // Si todo ha ido bien, mostramos un mensaje
                if (correcto)
                {
                    MessageBox.Show("la acción se ha realizado correctamente.");
                    modoEdicion = ModoEdicion.lectura;
                    // Cambiamos el modo a lectura
                    ModoPantallaLectura();
                    // Una vez hemos hecho la acción, recargamos el grid:
                    CargarYConfigurarGrid();
                }

            }
            else
            {
                MessageBox.Show("Los campos Nombre y Teléfono son obligatorios.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir de la edición?", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                modoEdicion = ModoEdicion.lectura;
                ModoPantallaLectura();

                // Si tenemos una fila seleccionada en el grid:
                if (dgvRestaurantes.SelectedRows.Count == 1)
                {
                    // Recargamos su información en el formulario
                    CargarInfoFilaSeleccionadaFormulario(dgvRestaurantes.SelectedRows[0]);
                }
            }
        }

        private void dgvRestaurantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRestaurantes.Rows[e.RowIndex].Selected = true;
        }

        private void dgvRestaurantes_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            DataGridViewRow filaSeleccionada = e.Row;
            CargarInfoFilaSeleccionadaFormulario(filaSeleccionada);
        }
    }
}