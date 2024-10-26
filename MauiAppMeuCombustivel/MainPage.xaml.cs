﻿namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Declaração de variáveis
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;
                string msg = "";

                if(etanol <= (gasolina * 0.7))
                    {
                    msg = "O etanol está compensando para o seu " + marca + " " + modelo;
                }
                else
                {
                    msg = "A gasolina está compensando para o seu " + marca + " " + modelo;
                }

                DisplayAlert("Calculado", msg, "ok");

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        } // Fecha método
    } // Fecha class
} // Fecha namespace