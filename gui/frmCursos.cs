using appEstudiantes.bean;
using appEstudiantes.clsBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEstudiantes
{
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }
        private void verTabla()
        {
            DataTable datos = daoCursos.listar();
            if (datos == null)
            {
                MessageBox.Show("No se pueden mostrar los datos.");
            }
            else
            {
                dgvcursos.DataSource = datos.DefaultView;
            }
        }
        private void limpiarCampos()
        {
            txtid.Text = "";
            txtcom.Text = "";
            txtmat.Text = "";
            txthis.Text = "";
            txtrel.Text = "";
            txtcie.Text = "";
            txtciv.Text = "";
            txtpsi.Text = "";
            txttotal.Text = "";
            txtobs.Text = "";
            txtbuscar2.Text = "";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            verTabla();
        }
        bool consultado = false;
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar2.Text.Trim() == "")
            {
                MessageBox.Show("Antes de buscar las notas de un estudiante debe colocar su id.");
            }
            else
            {
                cursos cur = daoCursos.buscar(int.Parse(txtbuscar2.Text.Trim()));
                if (cur == null)
                {
                    MessageBox.Show("No existe el estudiante con id: " + txtbuscar2.Text);
                    limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtid.Text = cur.IdEstudiante.ToString();
                    txtmat.Text = cur.Matematicas1.ToString();
                    txtcom.Text = cur.Comunicacion1.ToString();
                    txtrel.Text = cur.Religion1.ToString();
                    txthis.Text = cur.Historia1.ToString();
                    txtcie.Text = cur.Ciencias1.ToString();
                    txtciv.Text = cur.Civica1.ToString();
                    txtpsi.Text = cur.Psicologia1.ToString();
                    txttotal.Text = cur.Total1.ToString();
                    txtobs.Text = cur.Observaciones1;
                    consultado = true;
                }
            }
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Antes de actualizar debe buscar al estudiante por medio de su id.");
            }
            else if (txtid.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un id valido.");
            }
            else if (txtmat.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
            else if (txtcom.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
            else if (txtrel.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
            else if (txthis.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
            else if (txtcie.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
            else if (txtciv.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
            else if (txtpsi.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un valor valido.");
            }
            else if (txttotal.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese una descripcion valida.");
            }
            else if (txtobs.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese una descripcion valida.");
            }
            else
            {
                try
                {
                    cursos cur = new cursos();
                    cur.IdEstudiante = int.Parse(txtid.Text.Trim());
                    cur.Matematicas1 = int.Parse(txtmat.Text.Trim());
                    cur.Comunicacion1 = int.Parse(txtcom.Text.Trim());
                    cur.Religion1 = int.Parse(txtrel.Text.Trim());
                    cur.Historia1 = int.Parse(txthis.Text.Trim());
                    cur.Ciencias1 = int.Parse(txtcie.Text.Trim());
                    cur.Civica1 = int.Parse(txtciv.Text.Trim());
                    cur.Psicologia1 = int.Parse(txtpsi.Text.Trim());
                    cur.Total1 = int.Parse(txttotal.Text.Trim());
                    cur.Observaciones1 = txtobs.Text.Trim();

                    if (daoCursos.Actualizar(cur))
                    {
                        verTabla();
                        limpiarCampos();
                        MessageBox.Show("Notas de estudiante actualizado correctamente.");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar notas de estudiante.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
