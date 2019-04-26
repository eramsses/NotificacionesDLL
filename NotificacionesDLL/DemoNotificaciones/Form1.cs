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
            Notificacion.FONT_TITULO = new Font(base.Font.FontFamily, 12.25F, FontStyle.Bold);
            Notificacion.FONT_MENSAJE = new Font(base.Font.FontFamily, 12.25F, FontStyle.Italic);
        }

        private void BtnMostrarMensajeOK_Click(object sender, EventArgs e)
        {
            if (chkIncluirTitulo.Checked)
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Notificacion.ICON_OK);
            }
            else
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, "", Notificacion.ICON_OK);
            }

        }

        private void BtnWarning_Click(object sender, EventArgs e)
        {
            if (chkIncluirTitulo.Checked)
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Notificacion.ICON_WARNING);
            }
            else
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, "", Notificacion.ICON_WARNING);
            }
        }

        private void BtnMensajeError_Click(object sender, EventArgs e)
        {
            if (chkIncluirTitulo.Checked)
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Notificacion.ICON_ERROR);
            }
            else
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, "", Notificacion.ICON_ERROR);
            }
        }

        private void BtnMensajeInformacion_Click(object sender, EventArgs e)
        {
            //Image icono = Properties.Resources.icons8_close_window_64px_2;
            //Mensajes.ICON_INFO = icono;
            if (chkIncluirTitulo.Checked)
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Notificacion.ICON_INFO);
            }
            else
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, "", Notificacion.ICON_INFO);
            }
        }

        private void BtnMensajeDefaul_Click(object sender, EventArgs e)
        {
            if (chkIncluirTitulo.Checked)
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, 6);
            }
            else
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, "", 6);
            }
        }

        private void BtnPersonalizado_Click(object sender, EventArgs e)
        {
            Notificacion.CUSTOM_OPACIDAD = 0.9;
            Notificacion.CUSTOM_COLOR_FONDO = Color.FromArgb(255, 180, 80);
            Notificacion.CUSTOM_ICON = Properties.Resources.icons8_close_window_64px_2;
            Notificacion.CUSTOM_COLOR_TEXT = Color.FromArgb(255, 120, 0);
            Notificacion.CUSTOM_FONT_TITULO = new Font(base.Font.FontFamily, 8F, FontStyle.Bold);
            Notificacion.CUSTOM_FONT_MENSAJE = new Font(base.Font.FontFamily, 8F, FontStyle.Regular);//new Font("Century Gothic", 13.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            if (chkIncluirTitulo.Checked)
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, txtContenidoTitulo.Text, Notificacion.CUSTOM_ICON, false);
            }
            else
            {
                Notificacion.Mostrar(txtContenidoMensaje.Text, "", Notificacion.CUSTOM_ICON, false);
            }
        }
    }
}
