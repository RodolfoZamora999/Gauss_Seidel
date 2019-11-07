using System.Drawing;
using System.Windows.Forms;

namespace Gauss_Seidel
{
    /// <summary>
    /// Clase destinada para el manejo de Matrices dinámicas.
    /// </summary>
    class ArrayDynamic
    {
        private readonly Control control;
        private TextBox[,] matrizValores;
        private TextBox[] matrizIgual;
        
        /// <summary>
        /// </summary>
        /// <param name="control">Provee la base para la inserción de los componentes de TextBox</param>
        public ArrayDynamic(Control control)
        {
            this.control = control;
        }

        /// <summary>
        /// Método para crear una matriz de nxn. 
        /// </summary>
        /// <param name="n">Define el tamaño de la matriz nxn</param>
        /// <returns>Devuelve true si la matriz fue creada correctamente, en caso contrario retorna false</returns>
        public bool Crear_Matriz(int n)
        {
            if (control != null && n > 1)
            {
                this.matrizValores = new TextBox[n, n];
                this.matrizIgual = new TextBox[n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        //Creación de la matriz de TextBox para los valores de las ecuaciones.
                        this.matrizValores[i, j] = new TextBox()
                        {
                            Size = new Size(28, 28),
                            Location = new Point((j + 1) * 60, (i + 1) * 40),
                            Multiline = true,
                            TextAlign = HorizontalAlignment.Center
                        };

                        //Creación de las etiquetas para los TextBox de valores "xn".
                        Label lblX = new Label()
                        {
                            Size = new Size(28, 28),
                            Location = new Point((matrizValores[i, j].Location.X) + 25, ((i + 1) * 40)),
                            Text = "X" + (j + 1),
                            ForeColor = Color.Black,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        this.control.Controls.Add(this.matrizValores[i, j]);
                        this.control.Controls.Add(lblX);
                    }

                    //Creación de las etiquetas para los TextBox de igualación "=".
                    Label lblIgual = new Label()
                    {
                        Size = new Size(28, 28),
                        Location = new Point((matrizValores[i, (n - 1)].Location.X) + 50, ((i + 1) * 40)),
                        Text = "=",
                        ForeColor = Color.Black,
                        TextAlign = ContentAlignment.MiddleCenter
                    };

                    //Creación de la matriz de TextBox para los valores de igualación.
                    this.matrizIgual[i] = new TextBox()
                    {
                        Size = new Size(28, 28),
                        Location = new Point((matrizValores[i, (n - 1)].Location.X) + 80, ((i + 1) * 40)),
                        Multiline = true
                    };

                    this.control.Controls.Add(lblIgual);
                    this.control.Controls.Add(this.matrizIgual[i]);
                }

                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Método que retorna una matriz con todos los valores introducidos en los TextBoxs de incognitas.
        /// </summary>
        /// <returns>Una matriz double de nxn con los valores de los TextBoxs</returns>
        public double[,] LeerIncognitas()
        {

            if (this.matrizValores != null)
            {
                int n = this.matrizValores.GetLength(0);

                double[,] matrizTemp = new double[n, n];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        matrizTemp[i, j] = double.Parse(this.matrizValores[i, j].Text);
                    }
                    
                return matrizTemp;
            }
            else
                return null;
        }

        /// <summary>
        /// Método que retorna una matriz con todos los valores introducidos en los TextBoxs de las igualaciones.
        /// </summary>
        /// <returns>Una matriz double de n con los valores de los TextBoxs</returns>
        public double[] LeerIgualaciones()
        {
            if (this.matrizIgual != null)
            {
                int n = this.matrizIgual.Length;

                double[] matrizTemp = new double[n];

                for (int i = 0; i < n; i++)
                    matrizTemp[i] = double.Parse(this.matrizIgual[i].Text);

                return matrizTemp;
            }
            else
                return null;
        }
    }
}
