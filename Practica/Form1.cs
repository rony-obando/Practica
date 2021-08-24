using EmpleadoModel1;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace Practica
{
    public partial class Form1 : Form
    {
        public EmpleadoModel modelo;
        public Form1()
        {
            modelo = new EmpleadoModel();
            InitializeComponent();
        }
        public Empleado1[] empleados;
        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // verificar();
            string nombres,apellidos,dni;
            decimal salario;
            nombres = TxBNombres.Text;
            apellidos = TxBApellidos.Text;
            dni = TxBDNI.Text;
            if (string.IsNullOrWhiteSpace(TxBSalario.Text))
            {
                MessageBox.Show("Error,No puede estar vacio", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else if (!decimal.TryParse(TxBSalario.Text, out salario))
            {
                MessageBox.Show($@"Error, Esto: {TxBSalario.Text} no es un salario", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                return;
            }
            else
            {
                salario = decimal.Parse(TxBSalario.Text);
            }
            Empleado1 empleado = new Empleado1();
            empleado.Nombres = nombres;
            empleado.apellidos = apellidos;
            empleado.DNI = dni;
            empleado.Sueldo = salario;
            MessageBox.Show($@"Nombres: {TxBNombres.Text}{Environment.NewLine}
Apellidos: {TxBApellidos.Text}{Environment.NewLine}
DNI: {TxBDNI.Text}{Environment.NewLine}
Salario: {TxBSalario.Text}");
            modelo.add(empleado);
            TxBApellidos.Text = string.Empty;
            TxBDNI.Text = string.Empty;
            TxBNombres.Text = string.Empty;
            TxBSalario.Text = string.Empty;
        }
        public void verificar()
        {
            if (TxBApellidos.Text.Length > 20 && TxBNombres.Text.Length > 20)
            {
                MessageBox.Show("Demasiadas letras, solo 20 letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string PatterDni = @"001-\d{6}-\d{4}[A-Z]{1}";
            Regex regex = new Regex(PatterDni);
            MatchCollection elmatch = regex.Matches(TxBDNI.Text);
            if (string.IsNullOrWhiteSpace(TxBDNI.Text))
            {
                MessageBox.Show("Error, DNI no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (elmatch.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Error, esto no es una dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSminimo_Click(object sender, EventArgs e)
        {
            decimal a = modelo.SalarioMinimo();
            MessageBox.Show($"El salario minimo es: {a}");

        }

        private void btnSmaximo_Click(object sender, EventArgs e)
        {
            decimal b = 5;
              b=  modelo.SalarioMaximo();
            MessageBox.Show($"El salario maximo es: {b}");
        }

        private void OrdAsc_Click(object sender, EventArgs e)
        {
            string a=modelo.Encima();
            MessageBox.Show($@"Ordenado: {a}{Environment.NewLine}");
            MessageBox.Show($@"Ordenado: {modelo.promedio()}");

        }
    }
}
