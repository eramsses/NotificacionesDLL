using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Notificaciones
{
    /// <summary>
    /// Librería para manejo de alertas para usuarios
    /// 
    /// Desarrollada por: Ing. Erick R. Rodríguez.
    /// </summary>
    public class Mensajes
    {
        #region Atributos
        

        private static int notificacionesActivas = 1;
        private static List<int> listaNotificaciones = new List<int>();
        private static Color colorFondo;
        private static Color colorTexto;

        #endregion

        #region Propiedades
        public static List<int> ListaNotificaciones { get => listaNotificaciones; set => listaNotificaciones = value; }
        public static int NotificacionesActivas { get => notificacionesActivas; set => notificacionesActivas = value; }

        //Iconos
        public static Image ICON_OK { get; } = Properties.Resources.icons8_ok_64px;
        public static Image ICON_WARNING { get;} = Properties.Resources.icons8_warning_64px;
        public static Image ICON_ERROR { get;} = Properties.Resources.icons8_error_64px;
        public static Image ICON_INFO { get; } = Properties.Resources.icons8_info_64px;
        /// <summary>
        /// Icono personalizable.
        /// </summary>
        public static Image ICON_CUSTOM { get; set; } = Properties.Resources.icons8_info_64px;

        // Colores de fondo
        public static Color COLOR_OK { get; } = Color.FromArgb(0,146,14);
        public static Color COLOR_WARNING { get;} = Color.FromArgb(221,120,9);
        public static Color COLOR_ERROR { get;} = Color.FromArgb(180, 0, 0);
        public static Color COLOR_INFO { get;} = Color.FromArgb(0, 80, 200);
        public static Color COLOR_CUSTOM { get; set; } = Color.FromArgb(26, 32, 40);

        // Color Texto
        /// <summary>
        /// Color del texto.
        /// </summary>
        public static Color COLOR_TEXT_OK { get; } = Color.FromArgb(240, 240, 240);
        public static Color COLOR_TEXT_WARNING { get; } = Color.FromArgb(240, 240, 240);
        public static Color COLOR_TEXT_ERROR { get; } = Color.FromArgb(240, 240, 240);
        public static Color COLOR_TEXT_INFO { get; } = Color.FromArgb(240, 240, 240);
        public static Color COLOR_TEXT_CUSTOM { get; set; } = Color.FromArgb(240, 240, 240);
        
        #endregion

        #region Constructor

        #endregion

        #region Métodos
        public static void Mostrar(string mensaje)
        {
            Console.WriteLine(notificacionesActivas);
            FrmNotificaciones frm = new FrmNotificaciones(notificacionesActivas, mensaje);
            frm.Show();
        }

        public static void Mostrar(string mensaje, string titulo)
        {
            FrmNotificaciones frm = new FrmNotificaciones(notificacionesActivas, mensaje, titulo);
            frm.Show();
        }

        public static void Mostrar(string mensaje, string titulo, int tipo)
        {
            FrmNotificaciones frm = new FrmNotificaciones(notificacionesActivas, mensaje, titulo, ObtenerIcono(tipo), colorFondo, colorTexto) ;
            frm.Show();
        }

        public static void Mostrar(string mensaje, string titulo, Image tipo)
        {
            FrmNotificaciones frm = new FrmNotificaciones(notificacionesActivas, mensaje, titulo, tipo, ObtenerColor(tipo), colorTexto);
            frm.Show();
        }

        public static void Mostrar(string mensaje, string titulo, int tipo, bool autoCerrar)
        {
            FrmNotificaciones frm = new FrmNotificaciones(notificacionesActivas, mensaje, titulo, ObtenerIcono(tipo), colorFondo, colorTexto, autoCerrar);
            frm.Show();
        }

        /// <summary>
        /// Muestra un mensaje con título y el icono seleccionado ya sea por defecto o personalizado, también tiene control de cerrado automático.
        /// </summary>
        /// <param name="mensaje">Contenido del mensaje a mostrar.</param>
        /// <param name="titulo">Título del mensaje.</param>
        /// <param name="tipo">Tipo de icono que se va a mostrar, existen Mostrar.ICON_OK, Mostrar.ICON_WARNING, Mostrar.ICON_ERROR, Mostrar.ICON_INFO, Mostrar.CUSTOM </param>
        /// <param name="autoCerrar">Controla si se va a cerrar automáticamente o no, true se cierra automáticamente, false permanese hasta que el usuario la cierra.</param>
        public static void Mostrar(string mensaje, string titulo, Image tipo, bool autoCerrar)
        {
            FrmNotificaciones frm = new FrmNotificaciones(notificacionesActivas, mensaje, titulo, tipo, ObtenerColor(tipo), colorTexto, autoCerrar);
            frm.Show();
        }

        

        

        private static Image ObtenerIcono(int tipo)
        {
            
            if (tipo == 1)
            {
                colorFondo = COLOR_OK;
                colorTexto = COLOR_TEXT_OK;
                return Properties.Resources.icons8_ok_64px;
            }
            else if(tipo == 2)
            {
                colorFondo = COLOR_WARNING;
                colorTexto = COLOR_TEXT_WARNING;
                return Properties.Resources.icons8_warning_64px;
            }
            else if (tipo == 3)
            {
                colorFondo = COLOR_ERROR;
                colorTexto = COLOR_TEXT_ERROR;
                return Properties.Resources.icons8_error_64px;
            }
            else if (tipo == 4)
            {
                colorFondo = COLOR_INFO;
                colorTexto = COLOR_TEXT_INFO;
                return Properties.Resources.icons8_info_64px;
            }
            else if (tipo == 5)
            {
                colorFondo = COLOR_CUSTOM;
                colorTexto = COLOR_TEXT_CUSTOM;
                return ICON_CUSTOM;
            }
            else
            {

                colorTexto = Color.FromArgb(240, 240, 240);
                colorFondo = Color.FromArgb(26, 32, 40);
                return null;
            }
        }

        private static Color ObtenerColor(Image tipo)
        {

            if (tipo == ICON_OK)
            {
                colorTexto = COLOR_TEXT_OK;
                return COLOR_OK;
            }
            else if (tipo == ICON_WARNING)
            {
                colorTexto = COLOR_TEXT_WARNING;
                return COLOR_WARNING;
            }
            else if (tipo == ICON_ERROR)
            {
                colorTexto = COLOR_TEXT_ERROR;
                return COLOR_ERROR;
            }
            else if (tipo == ICON_INFO)
            {
                colorTexto = COLOR_TEXT_INFO;
                return COLOR_INFO;
            }
            else if (tipo == ICON_CUSTOM)
            {
                colorTexto = COLOR_TEXT_CUSTOM;
                return COLOR_CUSTOM;
            }
            else
            {
                colorTexto = Color.FromArgb(240, 240, 240);
                return Color.FromArgb(26, 32, 40);
            }
        }

        #endregion
    }
}
