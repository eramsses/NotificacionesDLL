namespace DemoNotificaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarMensajeOK = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.txtContenidoTitulo = new System.Windows.Forms.TextBox();
            this.txtContenidoMensaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIncluirTitulo = new System.Windows.Forms.CheckBox();
            this.btnMensajeError = new System.Windows.Forms.Button();
            this.btnMensajeInformacion = new System.Windows.Forms.Button();
            this.btnMensajeDefaul = new System.Windows.Forms.Button();
            this.btnPersonalizado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarMensajeOK
            // 
            this.btnMostrarMensajeOK.Location = new System.Drawing.Point(109, 202);
            this.btnMostrarMensajeOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnMostrarMensajeOK.Name = "btnMostrarMensajeOK";
            this.btnMostrarMensajeOK.Size = new System.Drawing.Size(209, 37);
            this.btnMostrarMensajeOK.TabIndex = 0;
            this.btnMostrarMensajeOK.Text = "Mensaje OK";
            this.btnMostrarMensajeOK.UseVisualStyleBackColor = true;
            this.btnMostrarMensajeOK.Click += new System.EventHandler(this.BtnMostrarMensajeOK_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.Location = new System.Drawing.Point(109, 247);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(209, 32);
            this.btnWarning.TabIndex = 1;
            this.btnWarning.Text = "Mensaje Warning";
            this.btnWarning.UseVisualStyleBackColor = true;
            this.btnWarning.Click += new System.EventHandler(this.BtnWarning_Click);
            // 
            // txtContenidoTitulo
            // 
            this.txtContenidoTitulo.Location = new System.Drawing.Point(109, 12);
            this.txtContenidoTitulo.Name = "txtContenidoTitulo";
            this.txtContenidoTitulo.Size = new System.Drawing.Size(381, 27);
            this.txtContenidoTitulo.TabIndex = 2;
            this.txtContenidoTitulo.Text = "Título del mensaje";
            // 
            // txtContenidoMensaje
            // 
            this.txtContenidoMensaje.Location = new System.Drawing.Point(109, 62);
            this.txtContenidoMensaje.Multiline = true;
            this.txtContenidoMensaje.Name = "txtContenidoMensaje";
            this.txtContenidoMensaje.Size = new System.Drawing.Size(381, 132);
            this.txtContenidoMensaje.TabIndex = 3;
            this.txtContenidoMensaje.Text = "Lorem ipsum dolor sit amet consectetur adipiscing elit duis neque, rhoncus habita" +
    "sse volutpat phasellus penatibus pharetra.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mensaje";
            // 
            // chkIncluirTitulo
            // 
            this.chkIncluirTitulo.AutoSize = true;
            this.chkIncluirTitulo.Location = new System.Drawing.Point(499, 14);
            this.chkIncluirTitulo.Name = "chkIncluirTitulo";
            this.chkIncluirTitulo.Size = new System.Drawing.Size(119, 25);
            this.chkIncluirTitulo.TabIndex = 6;
            this.chkIncluirTitulo.Text = "Incluir título";
            this.chkIncluirTitulo.UseVisualStyleBackColor = true;
            // 
            // btnMensajeError
            // 
            this.btnMensajeError.Location = new System.Drawing.Point(109, 285);
            this.btnMensajeError.Name = "btnMensajeError";
            this.btnMensajeError.Size = new System.Drawing.Size(209, 32);
            this.btnMensajeError.TabIndex = 7;
            this.btnMensajeError.Text = "Mensaje Error";
            this.btnMensajeError.UseVisualStyleBackColor = true;
            this.btnMensajeError.Click += new System.EventHandler(this.BtnMensajeError_Click);
            // 
            // btnMensajeInformacion
            // 
            this.btnMensajeInformacion.Location = new System.Drawing.Point(109, 323);
            this.btnMensajeInformacion.Name = "btnMensajeInformacion";
            this.btnMensajeInformacion.Size = new System.Drawing.Size(209, 32);
            this.btnMensajeInformacion.TabIndex = 8;
            this.btnMensajeInformacion.Text = "Mensaje Información";
            this.btnMensajeInformacion.UseVisualStyleBackColor = true;
            this.btnMensajeInformacion.Click += new System.EventHandler(this.BtnMensajeInformacion_Click);
            // 
            // btnMensajeDefaul
            // 
            this.btnMensajeDefaul.Location = new System.Drawing.Point(109, 361);
            this.btnMensajeDefaul.Name = "btnMensajeDefaul";
            this.btnMensajeDefaul.Size = new System.Drawing.Size(209, 32);
            this.btnMensajeDefaul.TabIndex = 9;
            this.btnMensajeDefaul.Text = "Mensaje Default";
            this.btnMensajeDefaul.UseVisualStyleBackColor = true;
            this.btnMensajeDefaul.Click += new System.EventHandler(this.BtnMensajeDefaul_Click);
            // 
            // btnPersonalizado
            // 
            this.btnPersonalizado.Location = new System.Drawing.Point(363, 202);
            this.btnPersonalizado.Margin = new System.Windows.Forms.Padding(5);
            this.btnPersonalizado.Name = "btnPersonalizado";
            this.btnPersonalizado.Size = new System.Drawing.Size(209, 37);
            this.btnPersonalizado.TabIndex = 10;
            this.btnPersonalizado.Text = "Mensaje Personalizado";
            this.btnPersonalizado.UseVisualStyleBackColor = true;
            this.btnPersonalizado.Click += new System.EventHandler(this.BtnPersonalizado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 431);
            this.Controls.Add(this.btnPersonalizado);
            this.Controls.Add(this.btnMensajeDefaul);
            this.Controls.Add(this.btnMensajeInformacion);
            this.Controls.Add(this.btnMensajeError);
            this.Controls.Add(this.chkIncluirTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContenidoMensaje);
            this.Controls.Add(this.txtContenidoTitulo);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnMostrarMensajeOK);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarMensajeOK;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.TextBox txtContenidoTitulo;
        private System.Windows.Forms.TextBox txtContenidoMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIncluirTitulo;
        private System.Windows.Forms.Button btnMensajeError;
        private System.Windows.Forms.Button btnMensajeInformacion;
        private System.Windows.Forms.Button btnMensajeDefaul;
        private System.Windows.Forms.Button btnPersonalizado;
    }
}

