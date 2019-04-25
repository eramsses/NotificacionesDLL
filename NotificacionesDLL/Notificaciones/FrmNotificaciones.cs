﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notificaciones
{
    public partial class FrmNotificaciones : Form
    {
        #region Atributos
        private bool cerrado = false;
        private int i = 0;
        private int SeparacionMensajes = 3;
        private int tiempoVisible = 300;
        private int ancho = Screen.PrimaryScreen.Bounds.Width;
        private int alto = Screen.PrimaryScreen.WorkingArea.Height;
        private int numeroNotificacion = 1;
        private string titulo = "";
        private string mensaje = "";
        private bool autoCerrado = true;
        private Color colorTexto = Color.FromArgb(240, 240, 240);
        #endregion

        #region Contructores
        /// <summary>
        /// Constructor que solo muestra un mensaje
        /// </summary>
        /// <param name="notificacion">Número de notificación activa</param>
        /// <param name="mensaje">Texto que se muestra en el contenido del mensaje</param>
        public FrmNotificaciones(int notificacion, string mensaje)
        {
            InitializeComponent();
            numeroNotificacion = notificacion;
            this.mensaje = mensaje;
            pgrsBarCerrar.Maximum = tiempoVisible;
        }

        /// <summary>
        /// Constructor que muestra un mensaje con título
        /// </summary>
        /// <param name="notificacion">Número de notificación activa</param>
        /// <param name="mensaje">Texto que se muestra en el contenido del mensaje</param>
        /// <param name="titulo">Texto que se muestra en el título del mensaje</param>
        public FrmNotificaciones(int notificacion, string mensaje, string titulo)
        {
            InitializeComponent();
            numeroNotificacion = notificacion;
            this.titulo = titulo;
            this.mensaje = mensaje;
            pgrsBarCerrar.Maximum = tiempoVisible;
        }
        
        /// <summary>
        /// Constructor que muestra un mensaje con título e icono y diferente color de fondo
        /// </summary>
        /// <param name="notificacion">Número de notificación activa</param>
        /// <param name="mensaje">Texto que se muestra en el contenido del mensaje</param>
        /// <param name="titulo">Texto que se muestra en el título del mensaje</param>
        /// <param name="icono">Imagen PGN al lado izquierdo del mensaje</param>
        /// <param name="color" type="Color">Color de fondo del mensaje</param>
        public FrmNotificaciones(int notificacion, string mensaje, string titulo, Image icono, Color color, Color colorTexto)
        {
            InitializeComponent();
            numeroNotificacion = notificacion;
            this.titulo = titulo;
            this.mensaje = mensaje;
            picIcono.Image = icono;
            pgrsBarCerrar.Maximum = tiempoVisible;
            BackColor = color;
            this.colorTexto = colorTexto;
        }

        /// <summary>
        /// Constructor que muestra un mensaje con título e icono y diferente color de fondo
        /// </summary>
        /// <param name="notificacion">Número de notificación activa</param>
        /// <param name="mensaje">Texto que se muestra en el contenido del mensaje</param>
        /// <param name="titulo">Texto que se muestra en el título del mensaje</param>
        /// <param name="icono">Imagen PGN al lado izquierdo del mensaje</param>
        /// <param name="color" type="Color">Color de fondo del mensaje</param>
        /// <param name="autoCerrado" type="Color">Color de fondo del mensaje</param>
        public FrmNotificaciones(int notificacion, string mensaje, string titulo, Image icono, Color color, Color colorTexto, bool autoCerrado)
        {
            InitializeComponent();
            numeroNotificacion = notificacion;
            this.titulo = titulo;
            this.mensaje = mensaje;
            this.autoCerrado = autoCerrado;
            picIcono.Image = icono;
            pgrsBarCerrar.Maximum = tiempoVisible;
            BackColor = color;
            this.colorTexto = colorTexto;
        }
        
        #endregion

        #region Métodos
        private void Timer1_Tick(object sender, EventArgs e)
        {
            /*
             * Animación
             * 
             * */
            int ubicacionY = Location.Y;
            int ubicacionX = Location.X;
            int nuevaY = ObtenerPosicion(numeroNotificacion);

            if (autoCerrado)
            { 
                if (Opacity <= 0)
                {
                    CerrarMensaje();
                }

                if (i == tiempoVisible)
                {
                    Opacity -= 0.02D;
                }

                pgrsBarCerrar.Value = (tiempoVisible - i);
            }

            if (ubicacionY < nuevaY)
            {
                //Animacion para reacomodar las notificaciones a medida que se van cerrando
                Location = new Point(ubicacionX, ubicacionY + 3);

            }
            else if (ubicacionY > nuevaY)
            {

                //Animacion para reacomodar las notificaciones a medida que se van abriendo
                Location = new Point(ubicacionX, ubicacionY - 3);
            }

            


            //pgrsBarCerrar.Value = (tiempoVisible - i)

            if (i != tiempoVisible)
            {
                i++;
            }

        }

        private int ObtenerPosicion(int numero)
        {
            int p = 9;

            if (Mensajes.ListaNotificaciones.Contains(numero))
            {

                for (int i = 0; i < Mensajes.ListaNotificaciones.Count; i++)
                {
                    if (Mensajes.ListaNotificaciones[i] == numero)
                    {
                        p = i + 1;
                        break;
                    }
                }
            }

            return alto - (p * (Height + SeparacionMensajes));
        }

        private int ObtenerPosicionLista(int numero)
        {
            int p = 9;
            if (Mensajes.ListaNotificaciones.Contains(numero))
            {
                for (int i = 0; i < Mensajes.ListaNotificaciones.Count; i++)
                {
                    if (Mensajes.ListaNotificaciones[i] == numero)
                    {
                        p = i;
                        break;
                    }
                }
            }

            return p;
        }

        private void MantenerMensaje()
        {
            if (!cerrado)
            {
                i = 0;
                Opacity = 0.95;
                timer1.Stop();
            }
        }

        private void CerrarMensaje()
        {
            Mensajes.ListaNotificaciones.Remove(numeroNotificacion);
            Close();
        }
        #endregion



        #region Eventos
        private void FrmNotificaciones_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = titulo;
            txtMensaje.Text = mensaje;
            txtTitulo.ForeColor = colorTexto;
            txtMensaje.ForeColor = colorTexto;
            Mensajes.NotificacionesActivas += 1;
            Mensajes.ListaNotificaciones.Add(numeroNotificacion);
            
            int nuevaY = ObtenerPosicion(numeroNotificacion);

            //Ubica la ventana del mensaje tomando en cuenta las dimensiones de la pantalla
            Location = new Point(ancho - Width, nuevaY + Height);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (autoCerrado)
            {
                cerrado = true;
                i = tiempoVisible;
                timer1.Start();
            }
            else
            {
                CerrarMensaje();
            }
        }

        private void BtnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.Image = Properties.Resources.icons8_close_window_32px_1;
            MantenerMensaje();
        }

        private void BtnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.Image = Properties.Resources.icons8_close_window_32px_2;
            timer1.Start();
        }
        
        private void FrmNotificaciones_MouseEnter(object sender, EventArgs e)
        {
            MantenerMensaje();
        }

        private void FrmNotificaciones_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void PicIcono_MouseEnter(object sender, EventArgs e)
        {
            MantenerMensaje();
        }

        private void PicIcono_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void TxtTitulo_MouseEnter(object sender, EventArgs e)
        {
            MantenerMensaje();
        }

        private void TxtTitulo_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void TxtMensaje_MouseEnter(object sender, EventArgs e)
        {
            MantenerMensaje();
        }
        
        private void TxtMensaje_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }
        #endregion
    }
}
