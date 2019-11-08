using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gauss_Seidel
{
    public partial class frmMetodos : Form
    {
        //Esta matriz almacena los valores de "x" calculados.
        private double[] valoresX;
        private ArrayDynamic arrayDynamic;

        public frmMetodos()
        {
            InitializeComponent();
            this.btnIteracion.Enabled = false;
        }

        //Evento para el botón de "Aceptar"
        //Sirve para preparar la interfaz y todo lo necesario
        private void Click_Crear_Matriz(object sender, EventArgs e)
        {
           try
            {
                Limpiar();
                //Inicializa el vector para guardar todos los valores de las x
                this.valoresX = new double[int.Parse(this.txDimension.Text)];

                //Todos los valores se igualan a 0
                for (int i = 0; i < this.valoresX.Length; i++)
                    this.valoresX[i] = 0;

                //Creación de la matriz de TextBoxs
                this.arrayDynamic = new ArrayDynamic(this.panelMatriz);
                this.arrayDynamic.Crear_Matriz(int.Parse(this.txDimension.Text));

                Crear_Columnas(int.Parse(this.txDimension.Text));

                this.btnIteracion.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houston, tenemos un problema...");
                Console.WriteLine(ex.ToString());
            }

        }

        //Método que se encarga de crear la lista donde se desplegaran los resultados
        private void Crear_Columnas(int variables)
        {
            ColumnHeader[] columnas = new ColumnHeader[(variables * 2)];

            this.listaResultado.Columns.Add(new ColumnHeader() {Text = "#Iteración", Width = 90 });

            for(int i = 0; i < variables; i++)
            {
                columnas[i] = new ColumnHeader()
                {
                    Text = "X" + (i+1),
                    Width = 90
                };
            }

            byte n = 1;
            for (int i = variables; i < (variables*2); i++)
            {
                columnas[i] = new ColumnHeader()
                {
                    Text = "Ex" + (n),
                    Width = 90
                };

                n++;
            }
            this.listaResultado.Columns.AddRange(columnas);
        }

        //Método para empezar con la iteración del programa 
        private void Clic_Iniciar_Iteracion(object sender, EventArgs e)
        {
            this.listaResultado.Items.Clear();

            //Limite 
            int limite = int.Parse(this.txtIteracion.Text);

            //Toleranciad error
            double tolerancia = double.Parse(this.txtTolerancia.Text);
 
            if (ComprobarDiagonal(this.arrayDynamic.LeerIncognitas()))
            {
                if(cbMetodo.SelectedIndex==0)
                    AlgoritmoGauss_Seidel(this.arrayDynamic.LeerIncognitas(), this.arrayDynamic.LeerIgualaciones(), limite, tolerancia);
                else if(cbMetodo.SelectedIndex==1)
                    AlgoritmoGauss_Simple(this.arrayDynamic.LeerIncognitas(), this.arrayDynamic.LeerIgualaciones(), limite, tolerancia);
            }

            else
                MessageBox.Show("Comprobar diagonal, ¿Quieres?");
        }

        //Método para calcular las iteraciones 
        public void AlgoritmoGauss_Seidel(double[,] valores, double[] igualaciones, int limite, double tolerancia)
        {
            //Variables que guardan los xn anteriores
            double[] valoresXanteriores;
            valoresXanteriores = (double[])valoresX.Clone();

            //Esta parte del código sirve para imprimir los valores
            string[] valoresImprimir = new string[ (this.valoresX.Length * 2) + 1];

            //Ciclo para hacer el numero de iteraciones
            for (int iterador = 1; iterador <= limite || limite == 0; iterador++)
            {
                valoresImprimir[0] = iterador.ToString();

                //Almacenar los valores
                for (int i = 0; i < this.valoresX.Length; i++)
                    valoresImprimir[i+1] = Math.Round(this.valoresX[i], 4).ToString();

                //Almacenar los errores
                for (int i = this.valoresX.Length; i < valoresX.Length * 2; i++)
                    valoresImprimir[i + 1] = Math.Round(Calcular_EX(this.valoresX[i - this.valoresX.Length],
                        valoresXanteriores[i - this.valoresX.Length]), 4).ToString();

                this.listaResultado.Items.Add(new ListViewItem(valoresImprimir));

                //Comprobar la tolerancia
                for (int i = 0; i < this.valoresX.Length; i++)
                {
                    if (Math.Round(Calcular_EX(this.valoresX[i], valoresXanteriores[i]), 4) <= tolerancia)
                    {
                        //Por si el error es menor o igual al establecido 
                        MessageBox.Show("La iteración ha sido exitosa");
                        return;
                    }
                }

                //Se almacenan los valores en anteriores
                valoresXanteriores = (double[])valoresX.Clone();

                //Ciclo para recorrer los vectores
                for (int i = 0; i < igualaciones.Length; i++)
                {
                    //Esta variable es temporal
                    double valorTemp = 0;

                    //Recorre un valor por cada iteración
                    for (int j = 0; j < igualaciones.Length; j++)
                    {
                        if (i != j)
                            valorTemp = valorTemp - (valores[i, j] * this.valoresX[j]);
                    }

                    valorTemp += igualaciones[i];

                    //Almacena el resultado de los valores para X
                    this.valoresX[i] = (valorTemp / valores[i, i]);
                }
            }
            //Por si alcanza el limite de iteraciones
            MessageBox.Show("La iteración ha sido exitosa por iteraciones");
        }
        public void AlgoritmoGauss_Simple(double[,] valores, double[]igualaciones, int limite, double tolerancia)
        {
            for (int iterador = 1; iterador <= limite || limite == 0; iterador++)
            {
                for (int k = 0; k < valoresX.Length - 1; k++)
                {
                    for (int i = k + 1; i < valoresX.Length - 1; i++)
                    {
                        double factor = valores[i, k] / valores[k, k];

                        for (int j = k; j <= valoresX.Length - 1; j++)
                        {
                            valores[i, j] = valores[i, j] - valores[k, j] * factor;
                        }
                    }
                }
            }
        }
        public bool ComprobarDiagonal(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    if (matriz[i, i] < matriz[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //Método encargado para el cálculo del error aproximado.
        private double Calcular_EX(double xnActual, double xnAnterior)
        {
            return Math.Abs(((xnActual - xnAnterior) / xnActual) * 100); ;
        }

        //Método que se encarga de limpiar toda la interfaz grafica
        private void Limpiar()
        {
            this.listaResultado.Columns.Clear();
            this.listaResultado.Items.Clear();
            this.panelMatriz.Controls.Clear();
        }

        //Cambiar de color a componentes
        //
        // No personalizable porque escogen colores feos
        //
        private void TsmiVerde_Click(object sender, EventArgs e)
        {
            msMenu.BackColor = Color.FromArgb(162, 215, 41);
            btnAceptar.BackColor = Color.FromArgb(162, 215, 41);
            btnIteracion.BackColor = Color.FromArgb(162, 215, 41);
        }

        private void TsmiRojo_Click(object sender, EventArgs e)
        {
            msMenu.BackColor = Color.FromArgb(250, 130, 76);
            btnAceptar.BackColor = Color.FromArgb(250, 130, 76);
            btnIteracion.BackColor = Color.FromArgb(250, 130, 76);
        }

        private void TsmiNegro_Click(object sender, EventArgs e)
        {
            msMenu.BackColor = Color.FromArgb(52, 46, 55);
            btnAceptar.BackColor = Color.FromArgb(52, 46, 55);
            btnIteracion.BackColor = Color.FromArgb(52, 46, 55);
        }

        private void TsmiAzul_Click(object sender, EventArgs e)
        {
            msMenu.BackColor = Color.FromArgb(60, 145, 230);
            btnAceptar.BackColor = Color.FromArgb(60, 145, 230);
            btnIteracion.BackColor = Color.FromArgb(60, 145, 230);
        }

        private void LblX_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
