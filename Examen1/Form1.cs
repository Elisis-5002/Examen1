namespace Examen1
{
    public partial class Form1 : Form
    {
        double sueldo;
        double excedente, isr, sueldoFinal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                lblISR.Text = "";
                lblSueldoFinal.Text = "";

                sueldo = double.Parse(txSueldoInicial.Text);
                if (sueldo < 0)
                {
                    MessageBox.Show("El sueldo no puede ser negativo.");
                    return;
                }
                if (0.01 < sueldo && sueldo < 746.04)
                {
                    excedente = sueldo - 0.01;
                    isr = excedente * 0.0192;
                    sueldoFinal = sueldo - isr;
                } 
                if (746.05 < sueldo && sueldo < 6332.05)
                {
                    excedente = sueldo - 746.05;
                    isr = 14.32 + (excedente * 0.0640);
                    sueldoFinal = sueldo - isr;
                } 
                if (6332.06 < sueldo && sueldo < 11128.01)
                {
                    excedente = sueldo - 6332.06;
                    isr = 371.83 + (excedente * 0.1088);
                    sueldoFinal = sueldo - isr;
                }
                if (11128.02 < sueldo && sueldo < 12935.82)
                {
                    excedente = sueldo - 11128.02;
                    isr = 893.63 + (excedente * 0.16);
                    sueldoFinal = sueldo - isr;
                }
                if (12935.83 < sueldo && sueldo < 15487.71)
                {
                    excedente = sueldo - 12935.83;
                    isr = 1318.26 + (excedente * 0.1792);
                    sueldoFinal = sueldo - isr;
                }
                if (15487.72 < sueldo && sueldo < 31236.49)
                {
                    excedente = sueldo - 15487.72;
                    isr = 1972.12 + (excedente * 0.2136);
                    sueldoFinal = sueldo - isr;
                }
                if (31236.50 < sueldo && sueldo < 49233.00)
                {
                    excedente = sueldo - 31236.50;
                    isr = 5850.76 + (excedente * 0.2352);
                    sueldoFinal = sueldo - isr;
                }
                if (49233.01 < sueldo && sueldo < 93993.90)
                {
                    excedente = sueldo - 49233.01;
                    isr = 10837.02 + (excedente * 0.30);
                    sueldoFinal = sueldo - isr;
                }
                if (93993.91 < sueldo && sueldo < 125325.20)
                {
                    excedente = sueldo - 93993.91;
                    isr = 26177.04 + (excedente * 0.32);
                    sueldoFinal = sueldo - isr;
                }
                if (125325.21 < sueldo && sueldo < 375975.61)
                {
                    excedente = sueldo - 125325.21;
                    isr = 38243.68 + (excedente * 0.34);
                    sueldoFinal = sueldo - isr;
                }
                if (375975.62 < sueldo)
                {
                    excedente = sueldo - 375975.62;
                    isr = 142119.38 + (excedente * 0.35);
                    sueldoFinal = sueldo - isr;
                }
                
                lblISR.Text = isr.ToString("F2");
                lblSueldoFinal.Text = sueldoFinal.ToString("F2");



            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido para el sueldo.");
                return;
            }
        }
    }
}
