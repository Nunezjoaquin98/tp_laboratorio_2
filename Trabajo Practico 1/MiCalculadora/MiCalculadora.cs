using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void MiCalculadora_Load(object sender, EventArgs e)
        {

        }

        //OPERACIONES

        /// <summary>
        /// Realiza el calculo de dos numeros
        /// </summary>
        /// <param name="numero1">numero 1</param>
        /// <param name="numero2">numero 2</param>
        /// <param name="operador">operador</param>
        /// <returns>Resultado del calculon</returns>
        private double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Numero(numero1), new Numero(numero2), operador);
        }

        /// <summary>
        /// Realiza la operacion entre el txtNumero1 y el txtNumero2 con el operador de cmbOperador
        /// Mostrando el resultado en lblResultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
        }


        /// <summary>
        /// Convierte el resultado en Binario de ser posible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text =  Numero.DecimalBinario(this.lblResultado.Text);
        }

        /// <summary>
        /// Convierte el resultado en Decimal de ser posible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }


        //OTROS METODOS


        /// <summary>
        /// Cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Llama al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /// <summary>
        /// Deja todos los campos en limpio
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;
            this.lblResultado.Text = "0";

        }
    }
}
