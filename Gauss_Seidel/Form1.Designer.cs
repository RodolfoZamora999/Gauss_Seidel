namespace Gauss_Seidel
{
    partial class frmMetodos
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
            this.btnIteracion = new System.Windows.Forms.Button();
            this.txtIteracion = new System.Windows.Forms.TextBox();
            this.lblDimension = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txDimension = new System.Windows.Forms.TextBox();
            this.panelMatriz = new System.Windows.Forms.Panel();
            this.listaResultado = new System.Windows.Forms.ListView();
            this.panelArriba = new System.Windows.Forms.Panel();
            this.panelAbajoAdentro = new System.Windows.Forms.Panel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRojo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNegro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMetodo = new System.Windows.Forms.ComboBox();
            this.lblX = new System.Windows.Forms.Label();
            this.panelDimension.SuspendLayout();
            this.panelArriba.SuspendLayout();
            this.panelAbajoAdentro.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDimension
            // 
            this.panelDimension.BackColor = System.Drawing.Color.Transparent;
            this.panelDimension.Controls.Add(this.cbMetodo);
            this.panelDimension.Controls.Add(this.lblTolerancia);
            this.panelDimension.Controls.Add(this.lblIteraciones);
            this.panelDimension.Controls.Add(this.txtTolerancia);
            this.panelDimension.Controls.Add(this.btnIteracion);
            this.panelDimension.Controls.Add(this.txtIteracion);
            this.panelDimension.Controls.Add(this.lblDimension);
            this.panelDimension.Controls.Add(this.btnAceptar);
            this.panelDimension.Controls.Add(this.txDimension);
            this.panelDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDimension.Location = new System.Drawing.Point(3, 3);
            this.panelDimension.Name = "panelDimension";
            this.panelDimension.Size = new System.Drawing.Size(318, 180);
            this.panelDimension.TabIndex = 0;
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTolerancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lblTolerancia.Location = new System.Drawing.Point(89, 71);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(57, 13);
            this.lblTolerancia.TabIndex = 8;
            this.lblTolerancia.Text = "Tolerancia";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lblIteraciones.Location = new System.Drawing.Point(89, 45);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(89, 13);
            this.lblIteraciones.TabIndex = 7;
            this.lblIteraciones.Text = "Limite Iteraciones";
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTolerancia.Location = new System.Drawing.Point(18, 64);
            this.txtTolerancia.Multiline = true;
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(65, 20);
            this.txtTolerancia.TabIndex = 6;
            this.txtTolerancia.Text = "0";
            // 
            // btnIteracion
            // 
            this.btnIteracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.btnIteracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIteracion.ForeColor = System.Drawing.Color.White;
            this.btnIteracion.Location = new System.Drawing.Point(113, 137);
            this.btnIteracion.Name = "btnIteracion";
            this.btnIteracion.Size = new System.Drawing.Size(109, 38);
            this.btnIteracion.TabIndex = 4;
            this.btnIteracion.Text = "Iniciar";
            this.btnIteracion.UseVisualStyleBackColor = false;
            this.btnIteracion.Click += new System.EventHandler(this.Clic_Iniciar_Iteracion);
            // 
            // txtIteracion
            // 
            this.txtIteracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteracion.Location = new System.Drawing.Point(18, 38);
            this.txtIteracion.Multiline = true;
            this.txtIteracion.Name = "txtIteracion";
            this.txtIteracion.Size = new System.Drawing.Size(65, 20);
            this.txtIteracion.TabIndex = 5;
            this.txtIteracion.Text = "0";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.lblDimension.Location = new System.Drawing.Point(89, 19);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(92, 13);
            this.lblDimension.TabIndex = 3;
            this.lblDimension.Text = "Dimensión (N x N)";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(8, 137);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 38);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.Click_Crear_Matriz);
            // 
            // txDimension
            // 
            this.txDimension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDimension.Location = new System.Drawing.Point(18, 12);
            this.txDimension.Multiline = true;
            this.txDimension.Name = "txDimension";
            this.txDimension.Size = new System.Drawing.Size(65, 20);
            this.txDimension.TabIndex = 1;
            // 
            // panelMatriz
            // 
            this.panelMatriz.BackColor = System.Drawing.Color.Transparent;
            this.panelMatriz.Location = new System.Drawing.Point(327, 0);
            this.panelMatriz.Name = "panelMatriz";
            this.panelMatriz.Size = new System.Drawing.Size(506, 235);
            this.panelMatriz.TabIndex = 1;
            // 
            // listaResultado
            // 
            this.listaResultado.BackColor = System.Drawing.Color.White;
            this.listaResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaResultado.HideSelection = false;
            this.listaResultado.Location = new System.Drawing.Point(0, 0);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(836, 654);
            this.listaResultado.TabIndex = 2;
            this.listaResultado.UseCompatibleStateImageBehavior = false;
            this.listaResultado.View = System.Windows.Forms.View.Details;
            // 
            // panelArriba
            // 
            this.panelArriba.Controls.Add(this.lblX);
            this.panelArriba.Controls.Add(this.msMenu);
            this.panelArriba.Controls.Add(this.panelAbajoAdentro);
            this.panelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArriba.Location = new System.Drawing.Point(0, 0);
            this.panelArriba.Name = "panelArriba";
            this.panelArriba.Size = new System.Drawing.Size(836, 263);
            this.panelArriba.TabIndex = 3;
            // 
            // panelAbajoAdentro
            // 
            this.panelAbajoAdentro.Controls.Add(this.panelMatriz);
            this.panelAbajoAdentro.Controls.Add(this.panelDimension);
            this.panelAbajoAdentro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajoAdentro.Location = new System.Drawing.Point(0, 25);
            this.panelAbajoAdentro.Name = "panelAbajoAdentro";
            this.panelAbajoAdentro.Size = new System.Drawing.Size(836, 238);
            this.panelAbajoAdentro.TabIndex = 2;
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(836, 24);
            this.msMenu.TabIndex = 3;
            this.msMenu.Text = "menuStrip1";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerde,
            this.tsmiRojo,
            this.tsmiNegro,
            this.tsmiAzul});
            this.colorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // tsmiVerde
            // 
            this.tsmiVerde.Name = "tsmiVerde";
            this.tsmiVerde.Size = new System.Drawing.Size(180, 22);
            this.tsmiVerde.Text = "Verde";
            this.tsmiVerde.Click += new System.EventHandler(this.TsmiVerde_Click);
            // 
            // tsmiRojo
            // 
            this.tsmiRojo.Name = "tsmiRojo";
            this.tsmiRojo.Size = new System.Drawing.Size(180, 22);
            this.tsmiRojo.Text = "Rojo";
            this.tsmiRojo.Click += new System.EventHandler(this.TsmiRojo_Click);
            // 
            // tsmiNegro
            // 
            this.tsmiNegro.Name = "tsmiNegro";
            this.tsmiNegro.Size = new System.Drawing.Size(180, 22);
            this.tsmiNegro.Text = "Negro";
            this.tsmiNegro.Click += new System.EventHandler(this.TsmiNegro_Click);
            // 
            // tsmiAzul
            // 
            this.tsmiAzul.Name = "tsmiAzul";
            this.tsmiAzul.Size = new System.Drawing.Size(180, 22);
            this.tsmiAzul.Text = "Azul";
            this.tsmiAzul.Click += new System.EventHandler(this.TsmiAzul_Click);
            // 
            // cbMetodo
            // 
            this.cbMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetodo.FormattingEnabled = true;
            this.cbMetodo.ItemHeight = 13;
            this.cbMetodo.Items.AddRange(new object[] {
            "Gauss-Seidel",
            "Gauss Simple",
            "Gauss Jordan"});
            this.cbMetodo.Location = new System.Drawing.Point(18, 90);
            this.cbMetodo.Name = "cbMetodo";
            this.cbMetodo.Size = new System.Drawing.Size(121, 21);
            this.cbMetodo.TabIndex = 9;
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(813, 5);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 13);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.LblX_Click);
            // 
            // frmMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(836, 654);
            this.Controls.Add(this.panelArriba);
            this.Controls.Add(this.listaResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMetodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gauss Seidel";
            this.panelDimension.ResumeLayout(false);
            this.panelDimension.PerformLayout();
            this.panelArriba.ResumeLayout(false);
            this.panelArriba.PerformLayout();
            this.panelAbajoAdentro.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
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
        private System.Windows.Forms.Panel panelArriba;
        private System.Windows.Forms.Panel panelAbajoAdentro;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerde;
        private System.Windows.Forms.ToolStripMenuItem tsmiRojo;
        private System.Windows.Forms.ToolStripMenuItem tsmiNegro;
        private System.Windows.Forms.ToolStripMenuItem tsmiAzul;
        private System.Windows.Forms.ComboBox cbMetodo;
        private System.Windows.Forms.Label lblX;
    }
}

