using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio1Cap6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int cantidad;
        int curso = 0;
        float[][] calificaciones;
        public static int cont = 0;
        public static float suma = 0;
        public static float promedio = 0;
        public static float mayor = 0;
        public static float menor = 0;
        public static float m = 0;
        public static float n = 0;




        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            curso = Convert.ToInt32(CantidadCursosTextBox.Text);
            calificaciones = new float[curso][];
            DigiteCantidadAlumnos();

        }

       
    //Funcion 
        private void AgregarCalificacionButton_Click(object sender, RoutedEventArgs e)
        {
            AgregarCalificacion();
        }

       
        
    //Funcion
        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = suma / cont;

            ListViewCalificaciones.Items.Add("El promedio es: ");
            ListViewCalificaciones.Items.Add(promedio);

            ListViewCalificaciones.Items.Add("Mayor calificacion ");
            ListViewCalificaciones.Items.Add(mayor);

            ListViewCalificaciones.Items.Add("Menor calificaion ");
            ListViewCalificaciones.Items.Add(menor);



        }

        public void DigiteCantidadAlumnos()
        {

            for (int i = 0; i < curso; i++)
            {
                cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la cantidad de alumnos en el salon: {i + 1}", " Cantidad de Alumnos ", " ", 0));
                calificaciones[i] = new float[cantidad];
                cont += cantidad;
                cantidad += cantidad;
            }

        }

        public void AgregarCalificacion()
        {


            for (int i = 0; i < curso; i++)
            {
                for (int m = 0; m < calificaciones[i].GetLength(0); m++)
                {
                    calificaciones[i][m] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la calificacion del alumno numero: {m + 1}  del salón {i + 1}", "Calificaciones Alumnos", " ", 0));
                    suma += calificaciones[i][m];

                    cont++;
                    if (calificaciones[i][m] > mayor)
                    {
                        mayor = calificaciones[i][m];
                    }
                    else if (calificaciones[i][m] < menor)
                    {
                        menor = calificaciones[i][m];
                    }
                }
            }
        }
    }
}
