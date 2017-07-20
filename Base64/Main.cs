using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string texto = "";

        //evento limpiar trxbox
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodificar.ResetText();
            txtDecodificar.ResetText();
            txtTexto.ResetText();            
        }
        //evento codificar
        private void btnCodificar_Click(object sender, EventArgs e)
        {   
            texto = txtTexto.Text;
            //coificacion
            var textoPlano = Encoding.UTF8.GetBytes(texto);
            string codificar = Convert.ToBase64String(textoPlano);
            txtCodificar.Text = codificar;

            //decodificacion
            var textoCodificado = Convert.FromBase64String(codificar);
            string textoPlanoDecodificado = Encoding.UTF8.GetString(textoCodificado);
            txtDecodificar.Text = textoPlanoDecodificado;

        }
        //evento decodificar
        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            //decodificacion
            string decodificar = txtTexto.Text;
            var textoCodificado = Convert.FromBase64String(decodificar);
            string textoDecodificado = Encoding.UTF8.GetString(textoCodificado);
            txtDecodificar.Text = textoDecodificado;
        }
        //eveto de link
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://erikrodrigu3z.blogspot.com");
        }
        //copiar texto
        private void btnCopiartexto_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtTexto.Text);
        }
        //copiar texto
        private void btnCopiarCodificado_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtCodificar.Text);
        }
        //copiar texto
        private void btnCopiarDecodificado_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtDecodificar.Text);
        }
    }
}
