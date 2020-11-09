using System;
using System.Windows;
using System.Windows.Controls;

namespace Ejercicio_5_Tema_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            Button boton = (Button)sender;
            EscribirTextBlock.Text = EscribirTextBlock.Text + Convert.ToString(boton.Tag);
        }
    }
}
