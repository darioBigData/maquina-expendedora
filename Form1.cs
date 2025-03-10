using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace maquinaExpendedora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            boton50cent.Enabled = true;
            button1E.Enabled = true;
            boton2E.Enabled = true;
            botonLimon.Enabled = false;
            botonNaranja.Enabled = false;
            botonCocacola.Enabled = false;
            botonJackD.Enabled = false;
            sacarDinero.Enabled = false;
            botonCancel.Enabled = false;
            recogerBebida.Enabled = false;
            pagoTarjeta.Enabled = true;
            idiomaSeleccionado = Idioma.Español;
            botonCancel.EnabledChanged += botonCancel_EnabledChanged;
            helpProvider1.HelpNamespace = "file:///C:/Users/dario/ayuda.html";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public enum Idioma
        {
            Español,
            Inglés
        }
        private decimal dinero;
        private bool bebidaComprada = false;
        private string nombreBebidaComprada = "";
        private Idioma idiomaSeleccionado = Idioma.Inglés;
        private decimal costeBebida;
        private void MostrarMensaje(string mensajeEspañol, string mensajeIngles)
        {
            string mensajeMostrar = (idiomaSeleccionado == Idioma.Español) ? mensajeEspañol : mensajeIngles;
            MessageBox.Show(mensajeMostrar, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void agregarDinero(decimal cantidad)
        {
            if (dinero + cantidad <= 3.0m || dinero < 3.0m)
            {
                dinero += cantidad;
                actualizarDineroInsertado();
                actualizarEstadoBotones();
            }
            else
            {
                MostrarMensaje("Has alcanzado el límite de saldo permitido (3 €). No se pueden insertar más monedas.", "You have reached the allowed balance limit (3 €). No more coins can be inserted.");
            }
            botonCancel.Enabled = true;
        }
        private void actualizarEstadoBotones()
        {
            // Habilitar o deshabilitar botones de bebidas según la cantidad de dinero insertado
            botonNaranja.Enabled = dinero >= 2.0m;
            botonLimon.Enabled = dinero >= 2.0m;
            botonCocacola.Enabled = dinero >= 2.5m;
            botonJackD.Enabled = dinero >= 3.0m;

            // Cambiar la imagen de fondo de los botones según su estado
            botonNaranja.BackgroundImage = (botonNaranja.Enabled) ? Properties.Resources.Fanta_Naranja : Properties.Resources.Fanta_Naranja_Disabled;
            botonLimon.BackgroundImage = (botonLimon.Enabled) ? Properties.Resources.Fanta_Limon : Properties.Resources.Fanta_Limon_Disabled;
            botonCocacola.BackgroundImage = (botonCocacola.Enabled) ? Properties.Resources.Cocacola : Properties.Resources.Coca_Cola_Disabled;
            botonJackD.BackgroundImage = (botonJackD.Enabled) ? Properties.Resources.Jack_Daniels : Properties.Resources.Jack_Daniels_Disabled;

            // Cambiar la imagen de fondo de los botones de monedas a blanco y negro si están deshabilitados
            boton50cent.BackgroundImage = (boton50cent.Enabled) ? Properties.Resources.Cents_euro_50 : Properties.Resources.Cents_euro_50_disabled;
            button1E.BackgroundImage = (button1E.Enabled) ? Properties.Resources.Euro_1 : Properties.Resources.Euro_1_disabled;
            boton2E.BackgroundImage = (boton2E.Enabled) ? Properties.Resources.Euro_2 : Properties.Resources.Euro_2_disabled;

            //Cambiar la imagen del lector de tarjeta de crédito en función de si está habilitado el pago con tarjeta
            pagoTarjeta.BackgroundImage = (pagoTarjeta.Enabled) ? Properties.Resources.Lector_habilitado : Properties.Resources.Lector_deshabilitado;                     
        }
        private void botonCancel_EnabledChanged(object sender, EventArgs e)
        {
            // Verificamos si el botón "Cancelar" está habilitado o no y se actualiza el color en consecuencia
            if (botonCancel.Enabled)
            {
                botonCancel.BackColor = Color.Red; // Color cuando está habilitado
            }
            else
            {
                botonCancel.BackColor = Color.RosyBrown; // Color cuando está deshabilitado
            }
        }
        private void resetearContador()
        {
            //Se reestablece el contador del dinero insertado solo si la cantidad introducida es mayor o igual al costo de la bebida
            if (dinero >= costeBebida)
            {
                dinero -= costeBebida;
            }
            actualizarDineroInsertado();
            actualizarEstadoBotones();
        }
        private decimal obtenerCosteBebida(string nombreBebida)
        {
            //Se define el coste de cada bebida
            switch (nombreBebida)
            {
                case "Fanta Naranja":
                    return 2.0m;
                case "Fanta Limon":
                    return 2.0m;
                case "Cocacola":
                    return 2.5m;
                case "Jack Daniels":
                    return 3.0m;
                default:
                    return 0.0m;
            }
        }
        private void comprarBebida(string nombreBebida)
        {
            decimal costeBebida = obtenerCosteBebida(nombreBebida);

            if (dinero >= costeBebida)
            {
                MostrarMensaje($"Has comprado {nombreBebida}.", $"You have purchased {nombreBebida}.");

                dinero -= costeBebida;
                actualizarDineroInsertado();

                resetearContador();  
                
                botonCancel.Enabled = false;
                bebidaComprada = true;
                nombreBebidaComprada = nombreBebida;
                boton50cent.Enabled = false;
                button1E.Enabled = false;
                boton2E.Enabled = false;
                pagoTarjeta.Enabled = false;

                actualizarEstadoBotones();

                if (dinero == 0)
                {
                    // Establecer la imagen correspondiente a la bebida en el botón "recogerBebida"
                    recogerBebida.BackgroundImage = Properties.Resources.ResourceManager.GetObject(nombreBebidaComprada) as Image;
                    recogerBebida.Enabled = true;
                }
                else
                {
                    sacarDinero.BackgroundImageLayout = ImageLayout.Stretch;
                    sacarDinero.Enabled = true;
                }
            }
            else
            {
                MostrarMensaje("No tienes suficiente dinero para comprar esta bebida.", "You do not have enough money to buy this drink.");
            }

            // Desactivar el botón de la bebida para evitar compras múltiples sin agregar más dinero.
            switch (nombreBebida)
            {
                case "Fanta Naranja":
                    botonNaranja.Enabled = false;
                    break;
                case "Fanta Limon":
                    botonLimon.Enabled = false;
                    break;
                case "Cocacola":
                    botonCocacola.Enabled = false;
                    break;
                case "Jack Daniels":
                    botonJackD.Enabled = false;
                    break;
            }
        }
        private void actualizarDineroInsertado()
        {
            // Actualizar el texto del label con el monto actual del dinero insertado
            dineroInsertado.Text = dinero.ToString();
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            idiomaSeleccionado = Idioma.Español;

             labelInsert.Text = "1. INSERTAR MONEDAS"; labelInsert.Refresh(); 
             labelChoose.Text = "2. ELEGIR REFRESCO"; labelChoose.Refresh(); 
             labelTake.Text = "3. RECOGER REFRESCO"; labelTake.Refresh(); 
             botonCancel.Text = "CANCELAR"; botonCancel.Refresh();
             helpProvider1.HelpNamespace = "file:///C:/Users/dario/ayuda.html"; 

            //Establecer la ayuda de cada control en español
            toolTip1.SetToolTip(pagoTarjeta, "Haz click para pagar con tarjeta(4€ se retirarán de tu tarjeta de crédito)");
            helpProvider1.SetHelpString(sacarDinero, "Haz click para retirar el cambio"); 
        }
        private void botonIngles_Click(object sender, EventArgs e)
        {
            idiomaSeleccionado = Idioma.Inglés;
           
            labelInsert.Text = "1. INSERT COIN"; labelInsert.Refresh(); 
            labelChoose.Text = "2. CHOOSE BEVERAGE"; labelChoose.Refresh(); 
            labelTake.Text = "3. TAKE BEVERAGE"; labelTake.Refresh(); 
            botonCancel.Text = "CANCEL"; botonCancel.Refresh();
            helpProvider1.HelpNamespace = "file:///C:/Users/dario/help.html";

            //Establecer la ayuda de cada control en inglés
            toolTip1.SetToolTip(pagoTarjeta, "Click to pay with credit card(4€ will be drawn from your credit card)");
            helpProvider1.SetHelpString(sacarDinero, "Click to retire the remaining cash");
        }
        private void boton50cent_Click(object sender, EventArgs e)
        {
            // Agregar 50 centimos al dinero insertado
            agregarDinero(0.5m);
            pagoTarjeta.Enabled = false;
            actualizarEstadoBotones();
        }
        private void button1E_Click(object sender, EventArgs e)
        {
            // Agregar 1 € al dinero insertado
            agregarDinero(1.0m);
            pagoTarjeta.Enabled = false;
            actualizarEstadoBotones();
        }
        private void boton2E_Click(object sender, EventArgs e)
        {
            // Agregar 2 € al dinero insertado
            agregarDinero(2.0m);
            pagoTarjeta.Enabled = false;
            actualizarEstadoBotones();
        }
        private void botonCancel_Click(object sender, EventArgs e)
        {
            // Establecer el valor del dinero a 0 en el contador de dineroInsertado
            dinero = 0.0m;
            actualizarDineroInsertado();

            //Se vuelve a activar el pago con monedas/tarjeta
            pagoTarjeta.Enabled = true;
            boton50cent.Enabled = true;
            button1E.Enabled = true;
            boton2E.Enabled = true;

            //Se vuelve a cambiar la imagen de las monedas a su version en color         
            actualizarEstadoBotones();

            //Se deshabilita el botón de cancelar hasta que se vuelva a introducir saldo
            botonCancel.Enabled = false;
        }
        private void sacarDinero_Click(object sender, EventArgs e)
        {
            MostrarMensaje($"Has recogido {dinero} €.", $"You have withdrawn {dinero} €.");

            // Deshabilitar el botón para sacar dinero una vez se ha retirado el saldo restante
            sacarDinero.Enabled = false;
            sacarDinero.BackgroundImageLayout = ImageLayout.None;

            //Habilitar que se recoga la bebida comprada
            recogerBebida.Enabled = true;

            // Establecer el valor del dinero a 0 en el contador de dineroInsertado
            dinero = 0.0m;

            //Resetear el contador
            resetearContador();

            // Restablecer el contador del dinero insertado y actualizar el estado de los botones de bebidas
            actualizarDineroInsertado();
            actualizarEstadoBotones();

            // Establecer la imagen correspondiente a la bebida en el botón "recogerBebida"
            recogerBebida.BackgroundImage = Properties.Resources.ResourceManager.GetObject(nombreBebidaComprada) as Image;

            // Limpiar el nombre de la bebida comprada
            nombreBebidaComprada = "";
        }
        private void botonNaranja_Click(object sender, EventArgs e)
        {
            comprarBebida("Fanta Naranja");
        }
        private void botonLimon_Click(object sender, EventArgs e)
        {
            comprarBebida("Fanta Limon");
        }
        private void botonCocacola_Click(object sender, EventArgs e)
        {
            comprarBebida("Cocacola");

        }
        private void botonJackD_Click(object sender, EventArgs e)
        {
            comprarBebida("Jack Daniels");
        }   
        private void recogerBebida_Click(object sender, EventArgs e)
        {
            if (bebidaComprada)
            {
                // Simular que el usuario recoge la bebida
                MostrarMensaje("Bebida recogida. ¡Disfruta!", "Beverage taken. ¡Enjoy!");

                // Limpiar la imagen del botón "recogerBebida"
                recogerBebida.BackgroundImage = null;

                // Restablecer el contador del dinero insertado y actualizar el estado de los botones de bebidas
                resetearContador();

                //Se habilita de nuevo la introduccion de saldo
                boton50cent.Enabled = true;
                button1E.Enabled = true;
                boton2E.Enabled = true;
                pagoTarjeta.Enabled = true;

                //Se vuelve a cambiar la imagen de las monedas a su version en color     
                actualizarEstadoBotones();

                // Deshabilitar el botón de recoger bebida hasta que se complete el proceso nuevamente
                recogerBebida.Enabled = false;
            }
            else
            {
                // Mostrar un mensaje indicando que no se ha comprado ninguna bebida
                MostrarMensaje("Error. Primero debes comprar una bebida antes de recogerla.", "Failure. First you need to buy a drink and then you can take it");
            }
        }
        private void pagoTarjeta_Click(object sender, EventArgs e)
        {
            agregarDinero(3.0m);
            boton50cent.Enabled = false;
            button1E.Enabled = false;
            boton2E.Enabled = false;
            actualizarEstadoBotones();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
        }
        private void botonEspañol_Click(object sender, EventArgs e)
        {
        }
        private void dineroInsertado_Click(object sender, EventArgs e)
        {

        }
        private void precioNaranja_Click(object sender, EventArgs e)
        {

        }
        private void precioLimon_Click(object sender, EventArgs e)
        {

        }
        private void precioCola_Click(object sender, EventArgs e)
        {

        }
        private void precioJackD_Click(object sender, EventArgs e)
        {

        }        
    }
}