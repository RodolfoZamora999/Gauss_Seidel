namespace Gauss_Seidel
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
            this.panelDimension = new System.Windows.Forms.Panel();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.txtIteracion = new System.Windows.Forms.TextBox();
            this.btnIteracion = new System.Windows.Forms.Button();
            this.lblDimension = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txDimension = new System.Windows.Forms.TextBox();
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.listaResultado = new System.Windows.Forms.ListView();
            this.panelDimension.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDimension
            // 
            this.panelDimension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelDimension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDimension.Controls.Add(this.lblTolerancia);
            this.panelDimension.Controls.Add(this.lblIteraciones);
            this.panelDimension.Controls.Add(this.txtTolerancia);
            this.panelDimension.Controls.Add(this.btnIteracion);
            this.panelDimension.Controls.Add(this.txtIteracion);
            this.panelDimension.Controls.Add(this.lblDimension);
            this.panelDimension.Controls.Add(this.btnAceptar);
            this.panelDimension.Controls.Add(this.txDimension);
            this.panelDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDimension.Location = new System.Drawing.Point(12, 12);
            this.panelDimension.Name = "panelDimension";
            this.panelDimension.Size = new System.Drawing.Size(314, 197);
            this.panelDimension.TabIndex = 0;
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTolerancia.ForeColor = System.Drawing.Color.White;
            this.lblTolerancia.Location = new System.Drawing.Point(89, 95);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(82, 20);
            this.lblTolerancia.TabIndex = 8;
            this.lblTolerancia.Text = "Tolerancia";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.Color.White;
            this.lblIteraciones.Location = new System.Drawing.Point(89, 57);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(134, 20);
            this.lblIteraciones.TabIndex = 7;
            this.lblIteraciones.Text = "Limite Iteraciones";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(18, 88);
            this.txtTolerancia.Multiline = true;
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(65, 32);
            this.txtTolerancia.TabIndex = 6;
            this.txtTolerancia.Text = "0";
            // 
            // txtIteracion
            // 
            this.txtIteracion.Location = new System.Drawing.Point(18, 50);
            this.txtIteracion.Multiline = true;
            this.txtIteracion.Name = "txtIteracion";
            this.txtIteracion.Size = new System.Drawing.Size(65, 32);
            this.txtIteracion.TabIndex = 5;
            this.txtIteracion.Text = "0";
            // 
            // btnIteracion
            // 
            this.btnIteracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnIteracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIteracion.ForeColor = System.Drawing.Color.White;
            this.btnIteracion.Location = new System.Drawing.Point(184, 135);
            this.btnIteracion.Name = "btnIteracion";
            this.btnIteracion.Size = new System.Drawing.Size(116, 49);
            this.btnIteracion.TabIndex = 4;
            this.btnIteracion.Text = "Iniciar";
            this.btnIteracion.UseVisualStyleBackColor = false;
            this.btnIteracion.Click += new System.EventHandler(this.Clic_Iniciar_Iteracion);
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimension.ForeColor = System.Drawing.Color.White;
            this.lblDimension.Location = new System.Drawing.Point(89, 19);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(135, 20);
            this.lblDimension.TabIndex = 3;
            this.lblDimension.Text = "Dimensión (N x N)";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(18, 135);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 38);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.Click_Crear_Matriz);
            // 
            // txDimension
            // 
            this.txDimension.Location = new System.Drawing.Point(18, 12);
            this.txDimension.Multiline = true;
            this.txDimension.Name = "txDimension";
            this.txDimension.Size = new System.Drawing.Size(65, 32);
            this.txDimension.TabIndex = 1;
            // 
            // panelMatriz
            // 
            this.panelMatriz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMatriz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatriz.Location = new System.Drawing.Point(332, 12);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(488, 197);
            this.panelMatriz.TabIndex = 1;
            // 
            // listaResultado
            // 
            this.listaResultado.BackColor = System.Drawing.Color.White;
            this.listaResultado.HideSelection = false;
            this.listaResultado.Location = new System.Drawing.Point(12, 215);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(808, 427);
            this.listaResultado.TabIndex = 2;
            this.listaResultado.UseCompatibleStateImageBehavior = false;
            this.listaResultado.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(836, 654);
            this.Controls.Add(this.listaResultado);
            this.Controls.Add(this.panelMatriz);
            this.Controls.Add(this.panelDimension);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gauss Seidel";
            this.panelDimension.ResumeLayout(false);
            this.panelDimension.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDimension;
        private System.Windows.Forms.TextBox txDimension;
        private System.Windows.Forms.Panel panelMatriz;
        private System.Windows.Forms.ListView listaResultado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Button btnIteracion;
        private System.Windows.Forms.Label lblTolerancia;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.TextBox txtIteracion;
    }
}

