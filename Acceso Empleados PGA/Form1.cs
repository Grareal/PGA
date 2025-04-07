using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using System.Threading;
using Entidades;
using LogicaChecadores;

namespace Acceso_Empleados_PGA
{
    public partial class frmChecada : Form
    {
        Dictionary<string, string> Cadenas = new Dictionary<string, string>();
        Dictionary<string, string> CadenasNulas = new Dictionary<string, string>();
        Dictionary<string, string> EmpresasNomina = new Dictionary<string, string>();
        Dictionary<string, SqlConnection> Conexiones = new Dictionary<string, SqlConnection>();
        Dictionary<string, Empresa> EmpresasEmp = new Dictionary<string, Empresa>();
        int Adultos, Menores;
        ChecadorPGADAL objChecador = new ChecadorPGADAL();
        EmpleadoNomina? empleadonomina = null;
        EmpleadoPegasys? emp_pegasys = null;
        NameValueCollection? GENERICOS = null;
        int MAX_ADULTOS = 2;
        int MAX_MENORES = 4;
        bool MODO_PRUEBA = false;
        string? Equipo;
        public frmChecada()
        {
            InitializeComponent();
        }

        private void frmChecada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcesarChecada(lblTarjeta.Text);
                lblTarjeta.Text = "";
            }
            if (e.KeyChar == (char)Keys.Back) lblTarjeta.Text = "";
            else if (e.KeyChar == (char)Keys.Escape) lblTarjeta.Text = "";
            else if (e.KeyChar != (char)Keys.Enter)
            {
                lblTarjeta.Text += Convert.ToString(e.KeyChar);

            }
            e.Handled = true;
        }

        private void ProcesarChecada(string tarjeta)
        {
            string cadenaconexionempleado;
            string empresaempleado;
            Empresa? empresaemp = null;



            SqlConnection? conexionempleado = null;
            EmpleadoPegasysBOL emp_bol = new EmpleadoPegasysBOL();
            try
            {
                EmpleadoPegasys emp_peg = emp_bol.ObtenerDatosEmpleado(tarjeta);
                EmpresasBOL objempresa = new EmpresasBOL();
                if (emp_peg != null)
                {
                    string clavenomina = emp_peg.Clavenomina;
                    string empresa = emp_peg.Emp;
                    int clavenominaint;
                    if (int.TryParse(clavenomina, out clavenominaint))
                    {
                        clavenomina = clavenominaint.ToString();
                    }
                    EmpleadoNomina? empleadonom = null;
                    cadenaconexionempleado = "";
                    empresaempleado = "";

                    if (Cadenas.ContainsKey(emp_peg.Emp))
                    {
                        cadenaconexionempleado = Cadenas[emp_peg.Emp];
                        empresaempleado = EmpresasNomina[emp_peg.Emp];
                        conexionempleado = Conexiones[emp_peg.Emp];
                        empresaemp = EmpresasEmp[emp_peg.Emp];
                    }
                    else
                    {
                        if (!CadenasNulas.ContainsKey(emp_peg.Emp))
                        {

                            empresaemp = objempresa.ObtenerPorNombre(emp_peg.Emp);
                        }
                        else
                        {
                            empresaemp = null;
                        }
                        if (empresaemp != null)
                        {
                            if (empresaemp.ConexionNomina.Trim() != "")
                            {
                                cadenaconexionempleado = Crypto.SimpleDecryptWithPassword(empresaemp.ConexionNomina, Crypto.KEY);
                                //cadenaconexionempleado = Crypto.SimpleDecryptWithPassword(ConfigurationManager.ConnectionStrings["Pegasys"].ToString(), Crypto.KEY);
                                //cadenaconexionempleado = Crypto.SimpleDecryptWithPassword(ConfigurationManager.ConnectionStrings["Pegasys"].ToString(), Crypto.KEY);
                                empresaempleado = empresaemp.ClaveEmpNomina;
                                Cadenas.Add(empresaemp.ClaveEmpresa, cadenaconexionempleado);
                                EmpresasNomina.Add(empresaemp.ClaveEmpresa, empresaempleado);
                                conexionempleado = new SqlConnection(cadenaconexionempleado);
                                //conexionempleado.Open();
                                Conexiones.Add(empresaemp.ClaveEmpresa, conexionempleado);
                                EmpresasEmp.Add(empresaemp.ClaveEmpresa, empresaemp);
                            }
                        }
                        else
                        {
                            if (!CadenasNulas.ContainsKey(emp_peg.Emp))
                                CadenasNulas.Add(emp_peg.Emp, "");
                        }
                    }

                    if (empresaempleado != "" && cadenaconexionempleado != "")
                    {
                        empleadonom = objempresa.ObtenerDatosEmpleado(empresaempleado, clavenomina, cadenaconexionempleado);
                    }

                    AsistenciaPGA asis = objChecador.Obtener(empleadonom, emp_peg, DateTime.Now);

                    if (empleadonom != null)
                    {
                        txtNombre.Text = empleadonom.Nombre + " " + empleadonom.Paterno + " " + empleadonom.Materno;
                        txtEmpresa.Text = empleadonom.EmpresaRazonSocial;
                        if (empleadonom.Nivel_Org == "" && empleadonom.Color_Gafete != "")
                            empleadonom.Nivel_Org = objempresa.ObtenerNivelEmpleado(empleadonom.Color_Gafete, cadenaconexionempleado);
                        else if (empleadonom.Nivel_Org != "" && empleadonom.Color_Gafete == "")
                            empleadonom.Color_Gafete = objempresa.ObtenerColorGafete(empleadonom.Nivel_Org, cadenaconexionempleado);

                        txtNivel.Text = (empleadonom.Nivel_Org == "0" ? "1" : empleadonom.Nivel_Org);
                        //txtNivel.Text = (empleadonom.Nivel_Org == "" ? "1" : empleadonom.Nivel_Org);
                        txtColor.Text = empleadonom.Color_Gafete;
                        txtDepartamento.Text = empleadonom.DepartamentoNom;
                        txtDescuento.Text = empleadonom.Descuento.ToString() + "%";
                        //lblEmp.BackColor = Color.Green;
                        //lblEmp.Text = empleadonom.ClaveNomina + " - " + empleadonom.Nombre + " " + empleadonom.Paterno + " " + empleadonom.Materno + "\n\n" +
                        //                empleadonom.DepartamentoNom + " - " + empleadonom.DivisionNom + "\n\n" +
                        //                empleadonom.EmpresaRazonSocial + "\n\n";// +
                        //emp_peg.Clave_control;
                        //imprimir(empleadonom, emp_peg);
                        empleadonomina = empleadonom;
                        emp_pegasys = emp_peg;
                        

                        Application.DoEvents();
                        //Thread.Sleep(3500);
                        //lblEmp.BackColor = this.BackColor;
                        //lblEmp.Text = "";
                        //if (!MODO_PRUEBA)

                        if (asis == null || MODO_PRUEBA)
                        {
                            gpoAsistentes.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("COLABORADOR YA USÓ EL BENEFICIO EL DIA DE HOY, YA NO APLICA DESCUENTO");
                            LimpiarCampos();
                        }

                        //gpoAsistentes.Enabled= true;
                        //LimpiarCampos();
                    }
                    else
                    {
                        //lblEmp.BackColor = Color.Green;
                        txtNombre.Text = emp_peg.C_Mname.Trim() + " " + emp_peg.C_Lname.Trim();
                        txtEmpresa.Text = emp_peg.Company_Name.Trim();
                        emp_pegasys = emp_peg;
                        txtNivel.Text = "1";
                        txtColor.Text = "BLANCO";
                        txtDepartamento.Text = "";
                        txtDescuento.Text = "100%";
                        //lblEmp.Text = emp_peg.C_Nick_Name.Trim() + " - " + emp_peg.C_Mname.Trim() + " " + emp_peg.C_Lname.Trim() + "\n\n" +
                        //            emp_peg.Company_Name.Trim() + "\n\n";// +
                        //emp_peg.Clave_control;
                        //imprimir(empleadonom, emp_peg);
                        empleadonomina = null;
                        emp_pegasys = emp_peg;
                        Application.DoEvents();
                        //Thread.Sleep(3500);
                        //lblEmp.BackColor = this.BackColor;
                        //lblEmp.Text = "";
                        //if (!MODO_PRUEBA)

                        if (asis == null || MODO_PRUEBA)
                        {
                            gpoAsistentes.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("COLABORADOR YA USÓ EL BENEFICIO EL DIA DE HOY, YA NO APLICA DESCUENTO");
                            LimpiarCampos();
                        }

                        //gpoAsistentes.Visible = true;
                        //gpoAsistentes.Enabled= true;
                        //LimpiarCampos();
                    }
                }
                else
                {
                    lblEmp.BackColor = Color.Red;
                    lblEmp.Text = "COLABORADOR NO ENCONTRADO, VALIDAR EN GAFETE, ANOTAR MANUAL";
                    Application.DoEvents();
                    Thread.Sleep(2000);
                    lblEmp.BackColor = this.BackColor;
                    lblEmp.Text = "";
                    LimpiarCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtEmpresa.Text = "";
            txtNivel.Text = "";
            txtColor.Text = "";
            txtDepartamento.Text = "";
            txtDescuento.Text = "";

            lblEmp.BackColor = this.BackColor;
            lblEmp.Text = "";
            lblTarjeta.Text = "";
            Adultos = 1;
            Menores = 0;
        }
        private void frmChecada_Load(object sender, EventArgs e)
        {
            GENERICOS = ConfigurationManager.AppSettings;

            if (GENERICOS.AllKeys.Contains("MODO_PRUEBA"))
                MODO_PRUEBA = (GENERICOS["MODO_PRUEBA"] == "1");
            if (GENERICOS.AllKeys.Contains("ADULTOS"))
                MAX_ADULTOS = Convert.ToInt32(GENERICOS["ADULTOS"]);
            if (GENERICOS.AllKeys.Contains("MENORES"))
                MAX_MENORES = Convert.ToInt32(GENERICOS["MENORES"]);
            Adultos = 1;
            Menores = 0;
            txtAdultos.Text = Adultos.ToString();
            txtMenores.Text = Menores.ToString();
            Equipo = Environment.MachineName;
        }

        private void btnAdplus_Click(object sender, EventArgs e)
        {
            if (Adultos >= MAX_ADULTOS)
                Adultos = MAX_ADULTOS;
            else
                Adultos++;
            ActualizaAsistentes();
        }

        private void btnAdminus_Click(object sender, EventArgs e)
        {
            if (Adultos <= 1)
                Adultos = 1;
            else
                Adultos--;
            ActualizaAsistentes();
        }

        private void btnMenplus_Click(object sender, EventArgs e)
        {
            if (Menores >= MAX_MENORES)
                Menores = MAX_MENORES;
            else
                Menores++;
            ActualizaAsistentes();
        }

        private void btnMenminus_Click(object sender, EventArgs e)
        {
            if (Menores <= 0)
                Menores = 0;
            else
                Menores--;
            ActualizaAsistentes();
        }
        private void ActualizaAsistentes()
        {
            txtAdultos.Text = Adultos.ToString();
            txtMenores.Text = Menores.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Adultos = 1;
            //Menores = 0;
            ActualizaAsistentes();
            DateTime fecha = DateTime.Now;
            int res = objChecador.Agregar(objChecador.GeneraAsistencia(empleadonomina, emp_pegasys, fecha, Adultos, Menores, Equipo));
            //gpoAsistentes.Enabled= false;
            gpoAsistentes.Visible = false;
            //btnConfirmar.Enabled=false; 
            LimpiarCampos();
            ActualizaAsistentes();
            lblTarjeta.Focus();
        }

        private void lblTarjeta_KeyPress(object sender, KeyPressEventArgs e)

        {


            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcesarChecada(lblTarjeta.Text);
                lblTarjeta.Text = "";
            }
            if (e.KeyChar == (char)Keys.Back) lblTarjeta.Text = "";
            else if (e.KeyChar == (char)Keys.Escape) lblTarjeta.Text = "";
            else if (e.KeyChar != (char)Keys.Enter)
            {
                lblTarjeta.Text += Convert.ToString(e.KeyChar);

            }
            e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Adultos = 1;
            Menores = 0;
            ActualizaAsistentes();
            //gpoAsistentes.Enabled= false;
            gpoAsistentes.Visible = false;
            //btnConfirmar.Enabled=false; 
            LimpiarCampos();
            lblTarjeta.Focus();
        }

        private void frmChecada_Activated(object sender, EventArgs e)
        {
            //this.BackColor = SystemColors.Window;
            pictureBox3.BackColor = Color.Green;
        }

        private void frmChecada_Deactivate(object sender, EventArgs e)
        {
            //this.BackColor= Color.Red;
            pictureBox3.BackColor = Color.Red;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}