using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Numerics;


namespace Karatsuba
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        public string valor1;
        public string valor2;

		public MainWindow()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

        static BigInteger calcular(BigInteger x, BigInteger y)
        {
            int n;
            int l1 = x.ToString().Length;
            int l2 = y.ToString().Length;

            if (l1 > l2)
            {
                n = l1;
            }
            else
            {
                n = l2;
            }

            if (n < 4) return x * y;
            
            n = ((n + 1) / 2);

            BigInteger x2 = x >> n;
            BigInteger x1 = x - (x2 << n);
            BigInteger y2 = y >> n;
            BigInteger y1 = y - (y2 << n);

            BigInteger z2 = calcular(x1, y1);
            BigInteger z0 = calcular(x2, y2);
            BigInteger z1 = calcular(x1 + x2, y1 + y2);

            return z2 + ((z1 -z2 - z0) << n) + (z0 << (2 * n));
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Total.Text = calcular(BigInteger.Parse(Multiplicando.Text), BigInteger.Parse(Multiplicador.Text)).ToString();
        }

        public bool validar(string valor)
        {
            int ret;
            try
            {
                for (int y = 0; y < valor.Trim().Length; y++)
                {
                    ret = Int32.Parse(valor.Substring(y, 1)) * 1;
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Solo puede digitar Numeros");
                return false;
            }
        }

      
        private void Multiplicando_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tt = (TextBox)sender;
            if (validar(tt.Text.ToString()) == false) tt.Text = valor1; valor1 = tt.Text;
        }

        private void Multipilicador_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tt = (TextBox)sender;
            if (validar(tt.Text.ToString()) == false) tt.Text = valor2; valor2 = tt.Text;
        }
	}
}