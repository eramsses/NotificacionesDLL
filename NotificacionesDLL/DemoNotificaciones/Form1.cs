using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notificaciones;

namespace DemoNotificaciones
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnMostrarMensajeOK_Click(object sender, EventArgs e)
        {
            if (chkIncluirTitulo.Checked)
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Mensajes.ICON_OK);
            }
            else
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, "", Mensajes.ICON_OK);
            }

        }

        private void BtnWarning_Click(object sender, EventArgs e)
        {
            if (chkIncluirTitulo.Checked)
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Mensajes.ICON_WARNING);
            }
            else
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, "", Mensajes.ICON_WARNING);
            }
        }

        private void BtnMensajeError_Click(object sender, EventArgs e)
        {
            if (chkIncluirTitulo.Checked)
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Mensajes.ICON_ERROR);
            }
            else
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, "", Mensajes.ICON_ERROR);
            }
        }

        private void BtnMensajeInformacion_Click(object sender, EventArgs e)
        {
            //Image icono = Properties.Resources.icons8_close_window_64px_2;
            //Mensajes.ICON_INFO = icono;
            if (chkIncluirTitulo.Checked)
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Mensajes.ICON_INFO);
            }
            else
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, "",Mensajes.ICON_INFO);
            }
        }

        private void BtnMensajeDefaul_Click(object sender, EventArgs e)
        {
            if (chkIncluirTitulo.Checked)
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, 6);
            }
            else
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, "", 6);
            }
        }

        private void BtnPersonalizado_Click(object sender, EventArgs e)
        {
            Mensajes.COLOR_CUSTOM = Color.FromArgb(255, 180, 80);
            Mensajes.ICON_CUSTOM = Properties.Resources.icons8_close_window_64px_2;
            Mensajes.COLOR_TEXT_CUSTOM = Color.FromArgb(255, 120, 0);
            if (chkIncluirTitulo.Checked)
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Mensajes.ICON_CUSTOM, false);
            }
            else
            {
                Mensajes.Mostrar(txtContenidoMensaje.Text, "", Mensajes.ICON_CUSTOM, false);
            }
        }
    }
}
