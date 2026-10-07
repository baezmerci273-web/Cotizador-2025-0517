namespace Calculadora_Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbCoti = new GroupBox();
            txtTarifa = new TextBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            chkTemporadaAlta = new CheckBox();
            lblTarifa = new Label();
            nudNoches = new NumericUpDown();
            lblNoche = new Label();
            txtHuesped = new TextBox();
            lblHuesped = new Label();
            gbTotales = new GroupBox();
            lbltot = new Label();
            lblser = new Label();
            lblit = new Label();
            lbldes = new Label();
            lblsu = new Label();
            lblTotal = new Label();
            lblServicio = new Label();
            lblitbis = new Label();
            lblDescuento = new Label();
            lblsubtotal = new Label();
            btnCopiar = new Button();
            btnImperactivo = new Button();
            lstHistorial = new ListBox();
            btnNivel1 = new Button();
            gbCoti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // gbCoti
            // 
            gbCoti.Controls.Add(txtTarifa);
            gbCoti.Controls.Add(btnLimpiar);
            gbCoti.Controls.Add(btnCalcular);
            gbCoti.Controls.Add(chkTemporadaAlta);
            gbCoti.Controls.Add(lblTarifa);
            gbCoti.Controls.Add(nudNoches);
            gbCoti.Controls.Add(lblNoche);
            gbCoti.Controls.Add(txtHuesped);
            gbCoti.Controls.Add(lblHuesped);
            gbCoti.Location = new Point(2, 21);
            gbCoti.Name = "gbCoti";
            gbCoti.Size = new Size(458, 333);
            gbCoti.TabIndex = 0;
            gbCoti.TabStop = false;
            gbCoti.Text = "Cotizador ";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(180, 146);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(125, 27);
            txtTarifa.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(154, 269);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(93, 40);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(18, 269);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 40);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // chkTemporadaAlta
            // 
            chkTemporadaAlta.AutoSize = true;
            chkTemporadaAlta.ForeColor = Color.LimeGreen;
            chkTemporadaAlta.Location = new Point(18, 214);
            chkTemporadaAlta.Name = "chkTemporadaAlta";
            chkTemporadaAlta.Size = new Size(172, 24);
            chkTemporadaAlta.TabIndex = 15;
            chkTemporadaAlta.Text = "Temporada Alta 25%";
            chkTemporadaAlta.UseVisualStyleBackColor = true;
            chkTemporadaAlta.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(18, 149);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(153, 20);
            lblTarifa.TabIndex = 13;
            lblTarifa.Text = "Tarifa por noche usd:";
            // 
            // nudNoches
            // 
            nudNoches.BackColor = SystemColors.ControlLightLight;
            nudNoches.Location = new Point(172, 89);
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(150, 27);
            nudNoches.TabIndex = 12;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNoche
            // 
            lblNoche.AutoSize = true;
            lblNoche.Location = new Point(18, 96);
            lblNoche.Name = "lblNoche";
            lblNoche.Size = new Size(64, 20);
            lblNoche.TabIndex = 11;
            lblNoche.Text = "Noches:";
            // 
            // txtHuesped
            // 
            txtHuesped.BorderStyle = BorderStyle.FixedSingle;
            txtHuesped.Location = new Point(172, 44);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.PlaceholderText = "Ej: Nombre del huesped";
            txtHuesped.Size = new Size(252, 27);
            txtHuesped.TabIndex = 10;
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(18, 52);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(73, 20);
            lblHuesped.TabIndex = 9;
            lblHuesped.Text = "Huesped:";
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lbltot);
            gbTotales.Controls.Add(lblser);
            gbTotales.Controls.Add(lblit);
            gbTotales.Controls.Add(lbldes);
            gbTotales.Controls.Add(lblsu);
            gbTotales.Controls.Add(lblTotal);
            gbTotales.Controls.Add(lblServicio);
            gbTotales.Controls.Add(lblitbis);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblsubtotal);
            gbTotales.Location = new Point(12, 375);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(250, 218);
            gbTotales.TabIndex = 1;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            gbTotales.Enter += gbTotales_Enter;
            // 
            // lbltot
            // 
            lbltot.AutoSize = true;
            lbltot.Location = new Point(84, 174);
            lbltot.Name = "lbltot";
            lbltot.Size = new Size(37, 20);
            lbltot.TabIndex = 9;
            lbltot.Text = "0.00";
            // 
            // lblser
            // 
            lblser.AutoSize = true;
            lblser.Location = new Point(84, 138);
            lblser.Name = "lblser";
            lblser.Size = new Size(37, 20);
            lblser.TabIndex = 8;
            lblser.Text = "0.00";
            // 
            // lblit
            // 
            lblit.AutoSize = true;
            lblit.Location = new Point(84, 107);
            lblit.Name = "lblit";
            lblit.Size = new Size(37, 20);
            lblit.TabIndex = 7;
            lblit.Text = "0.00";
            // 
            // lbldes
            // 
            lbldes.AutoSize = true;
            lbldes.Location = new Point(96, 67);
            lbldes.Name = "lbldes";
            lbldes.Size = new Size(37, 20);
            lbldes.TabIndex = 6;
            lbldes.Text = "0.00";
            lbldes.Click += lbldes_Click;
            // 
            // lblsu
            // 
            lblsu.AutoSize = true;
            lblsu.Location = new Point(84, 33);
            lblsu.Name = "lblsu";
            lblsu.Size = new Size(37, 20);
            lblsu.TabIndex = 5;
            lblsu.Text = "0.00";
            lblsu.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 172);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(12, 138);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(64, 20);
            lblServicio.TabIndex = 3;
            lblServicio.Text = "Servicio";
            // 
            // lblitbis
            // 
            lblitbis.AutoSize = true;
            lblitbis.Location = new Point(12, 102);
            lblitbis.Name = "lblitbis";
            lblitbis.Size = new Size(42, 20);
            lblitbis.TabIndex = 2;
            lblitbis.Text = "ITBIS";
            lblitbis.Click += lblitbis_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(12, 67);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(81, 20);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(12, 37);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(68, 20);
            lblsubtotal.TabIndex = 0;
            lblsubtotal.Text = "SubTotal";
            lblsubtotal.Click += label1_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.BackColor = SystemColors.Highlight;
            btnCopiar.ForeColor = SystemColors.ButtonHighlight;
            btnCopiar.Location = new Point(12, 617);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(295, 54);
            btnCopiar.TabIndex = 3;
            btnCopiar.Text = "Copiar para whatsApp";
            btnCopiar.UseVisualStyleBackColor = false;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnImperactivo
            // 
            btnImperactivo.Location = new Point(340, 622);
            btnImperactivo.Name = "btnImperactivo";
            btnImperactivo.Size = new Size(120, 44);
            btnImperactivo.TabIndex = 4;
            btnImperactivo.Text = "Imperrativo";
            btnImperactivo.UseVisualStyleBackColor = true;
            btnImperactivo.Click += btnImperactivo_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(516, 31);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(316, 684);
            lstHistorial.TabIndex = 5;
            lstHistorial.SelectedIndexChanged += lstHistorial_SelectedIndexChanged;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(12, 677);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(94, 29);
            btnNivel1.TabIndex = 6;
            btnNivel1.Text = "Nivel 1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1131, 816);
            Controls.Add(btnNivel1);
            Controls.Add(lstHistorial);
            Controls.Add(btnImperactivo);
            Controls.Add(btnCopiar);
            Controls.Add(gbTotales);
            Controls.Add(gbCoti);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador villa coral-Mercy 2025-0517";
            TransparencyKey = SystemColors.ControlDarkDark;
            Load += Form1_Load;
            gbCoti.ResumeLayout(false);
            gbCoti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCoti;
        private Button btnLimpiar;
        private Button btnCalcular;
        private CheckBox chkTemporadaAlta;
        private Label lblTarifa;
        private NumericUpDown nudNoches;
        private Label lblNoche;
        private TextBox txtHuesped;
        private Label lblHuesped;
        private GroupBox gbTotales;
        private Label lblsubtotal;
        private Label lblServicio;
        private Label lblitbis;
        private Label lblDescuento;
        private Label lblTotal;
        private Label lblit;
        private Label lbldes;
        private Label lblsu;
        private Label lbltot;
        private Label lblser;
        private Button btnCopiar;
        private Button btnImperactivo;
        private ListBox lstHistorial;
        private TextBox txtTarifa;
        private Button btnNivel1;
    }
}
