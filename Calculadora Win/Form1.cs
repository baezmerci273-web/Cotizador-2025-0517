namespace Calculadora_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblitbis_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbldes_Click(object sender, EventArgs e)
        {

        }

        private void gbTotales_Enter(object sender, EventArgs e)
        {

        }

        private void btnImperactivo_Click(object sender, EventArgs e)
        {
            string huesped = txtHuesped.Text;
            int noche = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);

            decimal subtotal = noche * tarifa;
            decimal descuento = 0m;
            if (noche >= 7)
            {
                descuento = subtotal * 0.10m;
            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;


            lstHistorial.Items.Add($"[IMPERATIVO] {huesped}:us$ {total:N2}");
        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHuesped.Text))
            {
                MessageBox.Show("Escribe el nombre del huésped.", "Falta un dato",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHuesped.Focus();
                return;
            }

            if (!decimal.TryParse(txtTarifa.Text, out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor que cero.", "Dato incorrecto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTarifa.Focus();
                txtTarifa.SelectAll();
                return;
            }

            MessageBox.Show(
                $"Huésped: {txtHuesped.Text}\nNoches: {nudNoches.Value}\nTemporada alta: {chkTemporadaAlta.Checked}",
                "Prueba de lectura");

            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = decimal.Parse(txtTarifa.Text),
                esTemporadaAlta = chkTemporadaAlta.Checked
            };

            lblsu.Text = reserva.Subtotal.ToString("N2");
            lbldes.Text = "-" + reserva.descuento.ToString("N2");
            lblit.Text = reserva.Itbis.ToString("N2");
            lblser.Text = reserva.Servicio.ToString("N2");
            lbltot.Text = reserva.Total.ToString("N2");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtHuesped.Clear();
            txtTarifa.Clear();
            nudNoches.Value = 1;
            chkTemporadaAlta.Checked = false;

            lblsu.Text = lbldes.Text = lblit.Text =
                lblser.Text = lbltot.Text = "0.00";

            lstHistorial.Items.Clear();

            txtHuesped.Focus();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text == "0.00")
            {
                MessageBox.Show("Primero calcula una cotización.", "Nada que copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var texto = $"""
        *Cotización Villa Coral*
        Huésped: {txtHuesped.Text}
        Noches: {nudNoches.Value}
        Subtotal: US$ {lblsu.Text}
        Descuento: US$ {lbldes.Text}
        ITBIS 18%: US$ {lblit.Text}
        Servicio 10%: US$ {lblser.Text}
        *TOTAL: US$ {lbltot.Text}*
        """;

            Clipboard.SetText(texto);

            MessageBox.Show("Cotización copiada. Ya puedes pegarla en WhatsApp.", "Listo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 3;
            int r = a / b;
            lstHistorial.Items.Add($"resultado {r}");

            decimal c = 10 / 4m;
            lstHistorial.Items.Add($"resultado {c}");

            int x = 5;
            x = x + 2;
            x = x * 3;
            lstHistorial.Items.Add($"resultado {x}");

            decimal p = 200m;
            decimal d = p * 0.18m;
            lstHistorial.Items.Add($"resultado {d}");

            int n = 7;
            decimal l = 0m;
            if (n > 7)
            {
                l = 50m;
            }
            lstHistorial.Items.Add($"resultado {l}");

            int q = 7;
            bool larga = q >= 7;
            lstHistorial.Items.Add($"resultado {larga}");

            string s = "Villa" + "Coral";
            lstHistorial.Items.Add($"resultado {s}");

            int w = 4;
            decimal t = 100m;
            decimal total = w * t * 1.28m;
            lstHistorial.Items.Add($"resultado {total}");

            decimal y = 120m;
            y = y + y * 0.25m;
            lstHistorial.Items.Add($"resultado {y}");

            int noches = (int)8.9m;
            lstHistorial.Items.Add($"resultado {noches}");


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            decimal totalusd = Convert.ToDecimal(lbltot.Text);
            decimal cambio = totalusd * nudTasa.Value;
            lstHistorial.Items.Add($"Total en RD$:{cambio}");
        }

        private void nudTasa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gbCoti_Enter(object sender, EventArgs e)
        {

        }

        private void btnPorPersona_Click(object sender, EventArgs e)
        {

            decimal totalusd = Convert.ToDecimal(lbltot.Text);
            decimal persona = totalusd / nudPorPersona.Value;
            lstHistorial.Items.Add($"Total que debe pagar cada persona en USD$:{persona}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            decimal totalusd = Convert.ToDecimal(lbltot.Text);
            decimal descuento = totalusd * 0.30m;
            decimal TOTAL = totalusd - descuento;
            lstHistorial.Items.Add($"Deposito USD$:{descuento}");
            lstHistorial.Items.Add($"Cuenta pendiente USD$:{TOTAL}");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal tarifa = Convert.ToDecimal(lbltot.Text);
            decimal total = 0, suma;
            if (chkFinSemana.Checked == true)
            {
                suma = tarifa * 0.15m;
                total = tarifa + suma;
            }
            var reserva = new Reserva { TarifaPorNoche = total };
            lstHistorial.Items.Add($"Total en usd por el fin de semana {total}");
        }

        private void btnCuentaTotal_Click(object sender, EventArgs e)
        {
           
            var reserva = new Reserva
            {

                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = decimal.Parse(txtTarifa.Text),
                esTemporadaAlta = chkTemporadaAlta.Checked
            };

           

            var traslado = new Clase_TrasladoAeropuerto
            {
                
                nocturno= chkNocturno.Checked
            };
            var excur = new Excursion { } 

           ;
            var bar = new ConsumidorMiniBar 
            {
                 
            };

            lstHistorial.Items.Add($"Nombre de la reserva:{reserva.Huesped} ");
            lstHistorial.Items.Add($"Cantidad de personas trasladadas:{traslado.pasajeros}");
            lstHistorial.Items.Add($"Cantidad de persona de excursion{excur.persona}, Precio C/U: {excur.precioPorPersona}");
            lstHistorial.Items.Add($"Cantidad consumida en el bar {bar.cantidad} Precio de productos:{bar.precioUnitario}");
            lstHistorial.Items.Add($"Total a pagar por todo: {reserva.Total + traslado.total + excur.total + bar.total}");
        }

        private void nudPersonas_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
