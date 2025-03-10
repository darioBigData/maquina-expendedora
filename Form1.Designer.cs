namespace maquinaExpendedora
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.sacarDinero = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.botonCancel = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pagoTarjeta = new System.Windows.Forms.Button();
            this.dineroInsertado = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.boton2E = new System.Windows.Forms.Button();
            this.button1E = new System.Windows.Forms.Button();
            this.boton50cent = new System.Windows.Forms.Button();
            this.labelInsert = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.precioJackD = new System.Windows.Forms.Label();
            this.botonJackD = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.precioCola = new System.Windows.Forms.Label();
            this.botonCocacola = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.precioLimon = new System.Windows.Forms.Label();
            this.botonLimon = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.precioNaranja = new System.Windows.Forms.Label();
            this.botonNaranja = new System.Windows.Forms.Button();
            this.labelChoose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.recogerBebida = new System.Windows.Forms.Button();
            this.labelTake = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.botonIngles = new System.Windows.Forms.Button();
            this.botonEspañol = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.labelInsert);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 496);
            this.panel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(35, 44);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 449);
            this.panel10.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.sacarDinero);
            this.panel13.Location = new System.Drawing.Point(6, 363);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(161, 83);
            this.panel13.TabIndex = 2;
            // 
            // sacarDinero
            // 
            this.sacarDinero.BackColor = System.Drawing.Color.Black;
            this.sacarDinero.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Recoger_dinero;
            this.sacarDinero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpProvider1.SetHelpString(this.sacarDinero, "Haz click para retirar el cambio");
            this.sacarDinero.Location = new System.Drawing.Point(15, 0);
            this.sacarDinero.Name = "sacarDinero";
            this.helpProvider1.SetShowHelp(this.sacarDinero, false);
            this.sacarDinero.Size = new System.Drawing.Size(134, 80);
            this.sacarDinero.TabIndex = 0;
            this.sacarDinero.UseVisualStyleBackColor = false;
            this.sacarDinero.Click += new System.EventHandler(this.sacarDinero_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.botonCancel);
            this.panel12.Location = new System.Drawing.Point(6, 295);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(161, 62);
            this.panel12.TabIndex = 1;
            // 
            // botonCancel
            // 
            this.botonCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.botonCancel.ForeColor = System.Drawing.Color.White;
            this.helpProvider1.SetHelpString(this.botonCancel, "");
            this.botonCancel.Location = new System.Drawing.Point(15, 8);
            this.botonCancel.Name = "botonCancel";
            this.helpProvider1.SetShowHelp(this.botonCancel, false);
            this.botonCancel.Size = new System.Drawing.Size(134, 50);
            this.botonCancel.TabIndex = 0;
            this.botonCancel.Text = "CANCELAR";
            this.botonCancel.UseVisualStyleBackColor = false;
            this.botonCancel.Click += new System.EventHandler(this.botonCancel_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pagoTarjeta);
            this.panel11.Controls.Add(this.dineroInsertado);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Location = new System.Drawing.Point(6, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(161, 286);
            this.panel11.TabIndex = 0;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // pagoTarjeta
            // 
            this.pagoTarjeta.BackColor = System.Drawing.Color.Black;
            this.pagoTarjeta.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Lector_habilitado;
            this.pagoTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pagoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagoTarjeta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpProvider1.SetHelpKeyword(this.pagoTarjeta, "Tarjeta de crédito");
            this.helpProvider1.SetHelpString(this.pagoTarjeta, "");
            this.pagoTarjeta.Location = new System.Drawing.Point(3, 187);
            this.pagoTarjeta.Name = "pagoTarjeta";
            this.helpProvider1.SetShowHelp(this.pagoTarjeta, false);
            this.pagoTarjeta.Size = new System.Drawing.Size(80, 96);
            this.pagoTarjeta.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pagoTarjeta, "Haz click para pagar con tarjeta(4€ se retirarán de tu tarjeta de crédito)");
            this.pagoTarjeta.UseVisualStyleBackColor = false;
            this.pagoTarjeta.Click += new System.EventHandler(this.pagoTarjeta_Click);
            // 
            // dineroInsertado
            // 
            this.dineroInsertado.BackColor = System.Drawing.Color.Black;
            this.dineroInsertado.Font = new System.Drawing.Font("Digital-7", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dineroInsertado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(201)))), ((int)(((byte)(32)))));
            this.dineroInsertado.Location = new System.Drawing.Point(72, 77);
            this.dineroInsertado.Name = "dineroInsertado";
            this.dineroInsertado.Size = new System.Drawing.Size(77, 26);
            this.dineroInsertado.TabIndex = 3;
            this.dineroInsertado.Text = "0";
            this.dineroInsertado.Click += new System.EventHandler(this.dineroInsertado_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.boton2E);
            this.panel14.Controls.Add(this.button1E);
            this.panel14.Controls.Add(this.boton50cent);
            this.helpProvider1.SetHelpString(this.panel14, "Click to pay with coins");
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.helpProvider1.SetShowHelp(this.panel14, true);
            this.panel14.Size = new System.Drawing.Size(69, 186);
            this.panel14.TabIndex = 3;
            // 
            // boton2E
            // 
            this.boton2E.BackColor = System.Drawing.Color.White;
            this.boton2E.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Euro_2;
            this.boton2E.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpString(this.boton2E, "");
            this.boton2E.Location = new System.Drawing.Point(6, 127);
            this.boton2E.Name = "boton2E";
            this.helpProvider1.SetShowHelp(this.boton2E, false);
            this.boton2E.Size = new System.Drawing.Size(60, 54);
            this.boton2E.TabIndex = 2;
            this.boton2E.UseVisualStyleBackColor = false;
            this.boton2E.Click += new System.EventHandler(this.boton2E_Click);
            // 
            // button1E
            // 
            this.button1E.BackColor = System.Drawing.Color.White;
            this.button1E.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Euro_1;
            this.button1E.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpString(this.button1E, "");
            this.button1E.Location = new System.Drawing.Point(6, 66);
            this.button1E.Name = "button1E";
            this.helpProvider1.SetShowHelp(this.button1E, false);
            this.button1E.Size = new System.Drawing.Size(60, 55);
            this.button1E.TabIndex = 1;
            this.button1E.UseVisualStyleBackColor = false;
            this.button1E.Click += new System.EventHandler(this.button1E_Click);
            // 
            // boton50cent
            // 
            this.boton50cent.BackColor = System.Drawing.Color.White;
            this.boton50cent.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Cents_euro_50;
            this.boton50cent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpString(this.boton50cent, "");
            this.boton50cent.Location = new System.Drawing.Point(6, 5);
            this.boton50cent.Name = "boton50cent";
            this.helpProvider1.SetShowHelp(this.boton50cent, false);
            this.boton50cent.Size = new System.Drawing.Size(60, 58);
            this.boton50cent.TabIndex = 0;
            this.boton50cent.UseVisualStyleBackColor = false;
            this.boton50cent.Click += new System.EventHandler(this.boton50cent_Click);
            // 
            // labelInsert
            // 
            this.labelInsert.BackColor = System.Drawing.Color.Black;
            this.labelInsert.Font = new System.Drawing.Font("Digital-7", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(201)))), ((int)(((byte)(32)))));
            this.labelInsert.Location = new System.Drawing.Point(5, 7);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(288, 28);
            this.labelInsert.TabIndex = 0;
            this.labelInsert.Text = "1. INSERTAR MONEDAS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.labelChoose);
            this.panel2.Location = new System.Drawing.Point(323, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 496);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(97, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 412);
            this.panel5.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.precioJackD);
            this.panel9.Controls.Add(this.botonJackD);
            this.panel9.Location = new System.Drawing.Point(5, 301);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(126, 99);
            this.panel9.TabIndex = 3;
            // 
            // precioJackD
            // 
            this.precioJackD.AutoSize = true;
            this.precioJackD.BackColor = System.Drawing.Color.Black;
            this.precioJackD.Font = new System.Drawing.Font("Digital-7", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioJackD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(201)))), ((int)(((byte)(32)))));
            this.precioJackD.Location = new System.Drawing.Point(63, 33);
            this.precioJackD.Name = "precioJackD";
            this.precioJackD.Size = new System.Drawing.Size(56, 26);
            this.precioJackD.TabIndex = 3;
            this.precioJackD.Text = "3.00";
            this.precioJackD.Click += new System.EventHandler(this.precioJackD_Click);
            // 
            // botonJackD
            // 
            this.botonJackD.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Jack_Daniels_Disabled;
            this.botonJackD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.botonJackD, "Jack Daniels");
            this.helpProvider1.SetHelpString(this.botonJackD, "");
            this.botonJackD.Location = new System.Drawing.Point(7, 3);
            this.botonJackD.Name = "botonJackD";
            this.helpProvider1.SetShowHelp(this.botonJackD, true);
            this.botonJackD.Size = new System.Drawing.Size(56, 93);
            this.botonJackD.TabIndex = 1;
            this.botonJackD.UseVisualStyleBackColor = true;
            this.botonJackD.Click += new System.EventHandler(this.botonJackD_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.precioCola);
            this.panel8.Controls.Add(this.botonCocacola);
            this.panel8.Location = new System.Drawing.Point(5, 198);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(126, 97);
            this.panel8.TabIndex = 2;
            // 
            // precioCola
            // 
            this.precioCola.BackColor = System.Drawing.Color.Black;
            this.precioCola.Font = new System.Drawing.Font("Digital-7", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioCola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(201)))), ((int)(((byte)(32)))));
            this.precioCola.Location = new System.Drawing.Point(63, 32);
            this.precioCola.Name = "precioCola";
            this.precioCola.Size = new System.Drawing.Size(56, 26);
            this.precioCola.TabIndex = 2;
            this.precioCola.Text = "2.50";
            this.precioCola.Click += new System.EventHandler(this.precioCola_Click);
            // 
            // botonCocacola
            // 
            this.botonCocacola.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Coca_Cola_Disabled;
            this.botonCocacola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.botonCocacola, "Coca Cola");
            this.helpProvider1.SetHelpString(this.botonCocacola, "");
            this.botonCocacola.Location = new System.Drawing.Point(7, 3);
            this.botonCocacola.Name = "botonCocacola";
            this.helpProvider1.SetShowHelp(this.botonCocacola, true);
            this.botonCocacola.Size = new System.Drawing.Size(56, 91);
            this.botonCocacola.TabIndex = 1;
            this.botonCocacola.UseVisualStyleBackColor = true;
            this.botonCocacola.Click += new System.EventHandler(this.botonCocacola_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.precioLimon);
            this.panel7.Controls.Add(this.botonLimon);
            this.panel7.Location = new System.Drawing.Point(5, 102);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(126, 90);
            this.panel7.TabIndex = 1;
            // 
            // precioLimon
            // 
            this.precioLimon.BackColor = System.Drawing.Color.Black;
            this.precioLimon.Font = new System.Drawing.Font("Digital-7", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLimon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(201)))), ((int)(((byte)(32)))));
            this.precioLimon.Location = new System.Drawing.Point(63, 29);
            this.precioLimon.Name = "precioLimon";
            this.precioLimon.Size = new System.Drawing.Size(56, 26);
            this.precioLimon.TabIndex = 2;
            this.precioLimon.Text = "2.00";
            this.precioLimon.Click += new System.EventHandler(this.precioLimon_Click);
            // 
            // botonLimon
            // 
            this.botonLimon.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Fanta_Limon_Disabled;
            this.botonLimon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.botonLimon, "Limón");
            this.helpProvider1.SetHelpString(this.botonLimon, "");
            this.botonLimon.Location = new System.Drawing.Point(7, 3);
            this.botonLimon.Name = "botonLimon";
            this.helpProvider1.SetShowHelp(this.botonLimon, true);
            this.botonLimon.Size = new System.Drawing.Size(56, 84);
            this.botonLimon.TabIndex = 1;
            this.botonLimon.UseVisualStyleBackColor = true;
            this.botonLimon.Click += new System.EventHandler(this.botonLimon_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.precioNaranja);
            this.panel6.Controls.Add(this.botonNaranja);
            this.panel6.Location = new System.Drawing.Point(5, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(126, 90);
            this.panel6.TabIndex = 0;
            // 
            // precioNaranja
            // 
            this.precioNaranja.BackColor = System.Drawing.Color.Black;
            this.precioNaranja.Font = new System.Drawing.Font("Digital-7", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioNaranja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(201)))), ((int)(((byte)(32)))));
            this.precioNaranja.Location = new System.Drawing.Point(63, 35);
            this.precioNaranja.Name = "precioNaranja";
            this.precioNaranja.Size = new System.Drawing.Size(56, 26);
            this.precioNaranja.TabIndex = 1;
            this.precioNaranja.Text = "2.00";
            this.precioNaranja.Click += new System.EventHandler(this.precioNaranja_Click);
            // 
            // botonNaranja
            // 
            this.botonNaranja.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Fanta_Naranja_Disabled;
            this.botonNaranja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpKeyword(this.botonNaranja, "Naranja");
            this.helpProvider1.SetHelpString(this.botonNaranja, "");
            this.botonNaranja.Location = new System.Drawing.Point(7, 3);
            this.botonNaranja.Name = "botonNaranja";
            this.helpProvider1.SetShowHelp(this.botonNaranja, true);
            this.botonNaranja.Size = new System.Drawing.Size(56, 84);
            this.botonNaranja.TabIndex = 0;
            this.botonNaranja.UseVisualStyleBackColor = true;
            this.botonNaranja.Click += new System.EventHandler(this.botonNaranja_Click);
            // 
            // labelChoose
            // 
            this.labelChoose.BackColor = System.Drawing.Color.Black;
            this.labelChoose.Font = new System.Drawing.Font("Digital-7", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(201)))), ((int)(((byte)(32)))));
            this.labelChoose.Location = new System.Drawing.Point(3, 7);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(322, 28);
            this.labelChoose.TabIndex = 1;
            this.labelChoose.Text = "2. ELEGIR REFRESCO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.recogerBebida);
            this.panel3.Controls.Add(this.labelTake);
            this.panel3.Location = new System.Drawing.Point(657, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 495);
            this.panel3.TabIndex = 2;
            // 
            // recogerBebida
            // 
            this.recogerBebida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recogerBebida.BackColor = System.Drawing.Color.Black;
            this.recogerBebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpString(this.recogerBebida, "");
            this.recogerBebida.Location = new System.Drawing.Point(10, 65);
            this.recogerBebida.Name = "recogerBebida";
            this.helpProvider1.SetShowHelp(this.recogerBebida, false);
            this.recogerBebida.Size = new System.Drawing.Size(315, 401);
            this.recogerBebida.TabIndex = 2;
            this.recogerBebida.UseVisualStyleBackColor = false;
            this.recogerBebida.Click += new System.EventHandler(this.recogerBebida_Click);
            // 
            // labelTake
            // 
            this.labelTake.BackColor = System.Drawing.Color.Black;
            this.labelTake.Font = new System.Drawing.Font("Digital-7", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(201)))), ((int)(((byte)(32)))));
            this.labelTake.Location = new System.Drawing.Point(3, 6);
            this.labelTake.Name = "labelTake";
            this.labelTake.Size = new System.Drawing.Size(327, 28);
            this.labelTake.TabIndex = 1;
            this.labelTake.Text = "3. RECOGER REFRESCO";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.botonIngles);
            this.panel4.Controls.Add(this.botonEspañol);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(89, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1146, 532);
            this.panel4.TabIndex = 3;
            // 
            // botonIngles
            // 
            this.botonIngles.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Bandera_UK;
            this.botonIngles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonIngles.Location = new System.Drawing.Point(1010, 89);
            this.botonIngles.Name = "botonIngles";
            this.botonIngles.Size = new System.Drawing.Size(94, 57);
            this.botonIngles.TabIndex = 4;
            this.botonIngles.UseVisualStyleBackColor = true;
            this.botonIngles.Click += new System.EventHandler(this.botonIngles_Click);
            // 
            // botonEspañol
            // 
            this.botonEspañol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonEspañol.BackgroundImage = global::maquinaExpendedora.Properties.Resources.Bandera_España;
            this.botonEspañol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpProvider1.SetHelpString(this.botonEspañol, "Click to switch the language of the vending machine to \"Spanish\"");
            this.botonEspañol.Location = new System.Drawing.Point(1010, 180);
            this.botonEspañol.Name = "botonEspañol";
            this.helpProvider1.SetShowHelp(this.botonEspañol, true);
            this.botonEspañol.Size = new System.Drawing.Size(94, 59);
            this.botonEspañol.TabIndex = 5;
            this.botonEspañol.UseVisualStyleBackColor = true;
            this.botonEspañol.Click += new System.EventHandler(this.button10_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 670);
            this.Controls.Add(this.panel4);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelTake;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button recogerBebida;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button botonLimon;
        private System.Windows.Forms.Button botonNaranja;
        private System.Windows.Forms.Button botonJackD;
        private System.Windows.Forms.Button botonCocacola;
        private System.Windows.Forms.Label precioCola;
        private System.Windows.Forms.Label precioLimon;
        private System.Windows.Forms.Label precioNaranja;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label precioJackD;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button sacarDinero;
        private System.Windows.Forms.Button botonCancel;
        private System.Windows.Forms.Button boton2E;
        private System.Windows.Forms.Button button1E;
        private System.Windows.Forms.Button boton50cent;
        private System.Windows.Forms.Label dineroInsertado;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button botonIngles;
        private System.Windows.Forms.Button botonEspañol;
        private System.Windows.Forms.Button pagoTarjeta;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

