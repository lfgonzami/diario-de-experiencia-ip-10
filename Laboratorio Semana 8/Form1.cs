namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // AGREGAR VALORES A LA COMBO BOX
            cmbSeleccion.Items.Add("Sumatoria");
            cmbSeleccion.Items.Add("Tablas de multiplicar");
            cmbSeleccion.Items.Add("Número Perfecto");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch(cmbSeleccion.SelectedIndex)
            {

                case 0:
                    tctSeleccion.SelectedTab = tabSumatoria; //MUESTRA LA PESTAÑA DE SUMATORIA
                    break;
                case 1:
                    tctSeleccion.SelectedTab = tabTablas; // MUESTA LA PESTAÑA DE TABLAS
                    break;
                case 2:
                    tctSeleccion.SelectedTab = tabNPerfecto; // MUESTRA LA PESTAÑA DE NÚMERO PERFECTO
                    break;

                default:
                    break;

            }

            


          

        }

        private void txtbIngreseN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {


            if (tctSeleccion.SelectedTab == tabSumatoria)
            {
                int n = int.Parse(txtbIngreseN.Text);
                int suma = 0;
                int i = 1;

                do
                {
                    suma += i;
                    i++;
                } while (i <= n);
                LbResultadoN.Text = suma.ToString();
            }
            else if (tctSeleccion.SelectedTab == tabTablas)
            {

                string tabla = "  ";
                for (int i = 1; i <= 10; i++)
                {
                    tabla += i + " ";
                }
                tabla += "\n";
                for (int i = 1; i <= 10; i++)
                {
                    tabla += i + " ";
                    for (int j = 1; j <= 10; j++)
                    {
                        tabla += (i * j) + " ";
                    }
                    tabla += "\n";
                }

                lbTabla.Text = tabla;


            }
            else if (tctSeleccion.SelectedTab == tabNPerfecto)
            {


                int num = Convert.ToInt32(txtbNPerfecto.Text);
                int sum = 0;

                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == num)
                {
                    lblResultadoPerfecto.Text = "El número " + num.ToString() + " es perfecto.";
                }
                else
                {
                    lblResultadoPerfecto.Text = "El número " + num.ToString() + " no es perfecto.";
                }


            }
        

            }

        private void tabTablas_Click(object sender, EventArgs e)
        {

        }

        private void tabFactorial_Click(object sender, EventArgs e)
        {

        }
    }
}