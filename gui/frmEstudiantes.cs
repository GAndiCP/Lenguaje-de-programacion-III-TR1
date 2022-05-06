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
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtpnom0.Text.Trim()=="")
            {
                MessageBox.Show("Por favor ingrese un nombre valido.");
            }
            else if (txtsnom0.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un nombre valido.");
            }
            else if (txtpape0.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un apellido valido.");
            }
            else if (txtsape0.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un apellido valido.");
            }
            else if (txttel.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un numero de telefono valido.");
            }
            else if (txtcel.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un numero de celular valido.");
            }
            else if (txtdir.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese una direccion valida.");
            }
            else if (txtmail.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un Email valido.");
            }
            else if (txtfecha.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese una fecha de nacimiento valida.");
            }
            else
            {
               try
                {
                    estudiantes est = new estudiantes();
                    est.Pnombre1 = txtpnom0.Text.Trim();
                    est.Snombre1 = txtsnom0.Text.Trim();
                    est.Papellido1 = txtpape0.Text.Trim();
                    est.Sapellido1 = txtsape0.Text.Trim();
                    est.Telefono1 = txttel.Text.Trim();
                    est.Celular1 = txtcel.Text.Trim();
                    est.Direccion1 = txtdir.Text.Trim();
                    est.Email1 = txtmail.Text.Trim();
                    est.Fnacimiento1 = txtfecha.Text.Trim();

                    if(daoEstudiantes.guardar(est))
                    {
                        verTabla();
                        limpiarCampos();
                        MessageBox.Show("Estudiante guardado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un estudiante con los mismos datos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void verTabla()
        {
            DataTable datos = daoEstudiantes.listar();
            if(datos==null)
            {
                MessageBox.Show("No se pueden mostrar los datos.");
            }
            else
            {
                dgvestudiantes.DataSource = datos.DefaultView;
            }
        }
        private void limpiarCampos()
        {
            txtid0.Text = "";
            txtsnom0.Text = "";
            txtpnom0.Text = "";
            txtpape0.Text = "";
            txtsape0.Text = "";
            txttel.Text = "";
            txtcel.Text = "";
            txtdir.Text = "";
            txtmail.Text = "";
            txtfecha.Text = "";
            txtbuscar0.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            verTabla();
        }
        bool consultado=false;
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(txtbuscar0.Text.Trim()=="")
            {
                MessageBox.Show("Antes de buscar la informacion del estudiante debe colocar su primer nombre.");
            }
            else
            {
                estudiantes est= daoEstudiantes.buscar(txtbuscar0.Text.Trim());
                if(est==null)
                {
                    MessageBox.Show("No existe el estudiante con nombre: "+txtbuscar0.Text);
                    limpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtid0.Text = est.Id.ToString();
                    txtpnom0.Text = est.Pnombre1;
                    txtsnom0.Text = est.Snombre1;
                    txtpape0.Text = est.Papellido1;
                    txtsape0.Text = est.Sapellido1;
                    txttel.Text = est.Telefono1;
                    txtcel.Text = est.Celular1;
                    txtdir.Text = est.Direccion1;
                    txtmail.Text = est.Email1;
                    txtfecha.Text = est.Fnacimiento1;
                    consultado=true;
                }
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (consultado==false)
            {
                MessageBox.Show("Antes de actualizar debe buscar al estudiante por su primer nombre.");
            }
            else if (txtpnom0.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un nombre valido.");
            }
            else if (txtsnom0.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un nombre valido.");
            }
            else if (txtpape0.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un apellido valido.");
            }
            else if (txtsape0.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un apellido valido.");
            }
            else if (txttel.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un numero de telefono valido.");
            }
            else if (txtcel.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un numero de celular valido.");
            }
            else if (txtdir.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese una direccion valida.");
            }
            else if (txtmail.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un Email valido.");
            }
            else if (txtfecha.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese una fecha de nacimiento valida.");
            }
            else
            {
                try
                {
                    estudiantes est = new estudiantes();
                    est.Id=int.Parse(txtid0.Text.Trim());
                    est.Pnombre1 = txtpnom0.Text.Trim();
                    est.Snombre1 = txtsnom0.Text.Trim();
                    est.Papellido1 = txtpape0.Text.Trim();
                    est.Sapellido1 = txtsape0.Text.Trim();
                    est.Telefono1 = txttel.Text.Trim();
                    est.Celular1 = txtcel.Text.Trim();
                    est.Direccion1 = txtdir.Text.Trim();
                    est.Email1 = txtmail.Text.Trim();
                    est.Fnacimiento1 = txtfecha.Text.Trim();

                    if (daoEstudiantes.Actualizar(est))
                    {
                        verTabla();
                        limpiarCampos();
                        MessageBox.Show("Estudiante actualizado correctamente.");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar datos de estudiantes.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (consultado == false)
            {
                MessageBox.Show("Antes de eliminar debe buscar al estudiante por su primer nombre.");
            }
            else if (txtbuscar0.Text.Trim() == "")
            {
                MessageBox.Show("Por favor ingrese un nombre valido.");
            }
            else if(DialogResult.Yes==MessageBox.Show(null,"¿Realmente desea eliminar al estudiante? "+txtpnom0.Text,"Confirmar",MessageBoxButtons.YesNo))
            {
                try
                {
                    if (daoEstudiantes.Eliminar(int.Parse(txtid0.Text.Trim())))
                    {
                        verTabla();
                        limpiarCampos();
                        MessageBox.Show("Estudiante eliminado correctamente.");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar datos de estudiantes.");
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
