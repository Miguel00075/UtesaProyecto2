using Sist_Facturacion.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sist_Facturacion.Administracion
{
    public partial class Usuario : Form
    {
        public int Idfac { get; set; }
        public int Idinv { get; set; }
        public int Idclien { get; set; }
        public int IdConf { get; set; }
        Cussuario cusuario = new Cussuario();
        Seguridad.Class.CRegistrarL registrarL = new Seguridad.Class.CRegistrarL();
        public Usuario()
        {
            InitializeComponent();
            // se crea un evento de tipo clic 
            //crear y buscar usuario.
            btnNuevo.Click +=  (sender, e) =>
            {
                DataGusuario.DataSource = cusuario.LlamarUsuario();
                for (int i = 0; i < DataGusuario.Rows.Count; i++)
                {
                    int b = i;
                    int h = ((Func<int, int, int>)((a, c) => a + c))(1,0);//variable temporal
                    txtNum.Text = (b + h).ToString();
                    Action F = () =>
                     {
                         comboBox1.DataSource = cusuario.LlamarNivel();
                         comboBox1.ValueMember = "id";
                         comboBox1.DisplayMember = "rol";
                     };
                    F();  
                };
            };
            //selecion de niveles y activacion de modulos
            comboBox1.TextChanged += (sender, e) =>
            {
                // se obtiene el valor del control         
                var value = comboBox1.SelectedValue.ToString();
                if (int.TryParse(value, out int resul))
                {
                    lbusuarioTotal.Text = resul.ToString();
                    if(value=="1")
                    {
                        checkModuloFacturacion.Checked = true;
                        checkBoxInventario.Checked = false;
                        checkBoxCliente.Checked = false;
                        checkBoxConfiguracion.Checked = false;
                    }
                    if(value=="2")
                    {
                        checkModuloFacturacion.Checked = false;
                        checkBoxInventario.Checked = true;
                        checkBoxCliente.Checked = false;
                        checkBoxConfiguracion.Checked = false;
                    }
                    if(value =="3")
                    {
                        checkBoxCliente.Checked = true;
                        checkModuloFacturacion.Checked = false;
                        checkBoxInventario.Checked = false;
                        checkBoxConfiguracion.Checked = false;
                    }
                    if (value == "4")
                    {
                        checkBoxCliente.Checked = true;
                        checkModuloFacturacion.Checked = true;
                        checkBoxInventario.Checked = true;
                        checkBoxConfiguracion.Checked = false;
                    }
                    if (value == "5")
                    {
                        checkBoxCliente.Checked = true;
                        checkModuloFacturacion.Checked = true;
                        checkBoxInventario.Checked = true;
                        checkBoxConfiguracion.Checked = true;
                    }
                }
            };
            // se inserta y modifica el valor utilizando una llave
            button1.Click += (sender, e) =>
            {
                if (txtPass.Text == "" || txtPass.Text.Length <= 4)//validar la tabla pass
                {
                    MessageBox.Show( $"Se debe colocar minimo {4} carateres ".ToUpper(), "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    registrarL.InsertarCliente(Convert.ToInt32(txtNum.Text),
                    txtNombre.Text, txtPass.Text, "81DC9BDB52D04DC20036DBD8313ED055",
                    Convert.ToInt32(lbusuarioTotal.Text), Idfac, Idinv, Idclien, IdConf);
                }
            };
            button2.Click += (sender, e) =>
            {
                  this.Close();
            };
            //evento clic del control dataGriviewer
            //al dar clic en las filas se llenan los controles de tipo text.
            DataGusuario.CellClick += (sender, e) =>
            {
                if(e.RowIndex >=0)
                { 
                    DataGridViewRow rows = DataGusuario.Rows[e.RowIndex];
                    {
                        txtNombre.Text = rows.Cells[1].Value.ToString();
                        txtNum.Text = rows.Cells[0].Value.ToString();
                    }
                }
            };
        }
        //conprueba el tipo de valor si es verdadero o falso y ejecuta una accion.
        private void CheckModuloFacturacion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModuloFacturacion.Checked == true)
            { Idfac = 1; }
           else if (checkModuloFacturacion.Checked == false) { Idfac = 0; }
        }

        private void CheckBoxInventario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInventario.Checked == true)
            { Idinv = 1; }
           else if(checkBoxInventario.Checked==false)
            { Idinv = 0; }
        }

        private void checkBoxCliente_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCliente.Checked==true)
            {
                Idclien = 1;
            }
            else if(checkBoxCliente.Checked==true)
            {
                Idclien = 0;
            }
        }

        private void checkBoxConfiguracion_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxConfiguracion.Checked==true)
            {
                IdConf = 1;
            }
            else if (checkBoxConfiguracion.Checked==false)
            {
                IdConf = 0;
            }
        }
    }
}
