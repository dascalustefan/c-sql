using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomWorks
{
   

    public partial class Form1 : Form
    {
        string vin;
        public Form1()
        {
           

            InitializeComponent();
            //adminpaneltxt.Dock = DockStyle.Fill;
            //panel_client.Dock = DockStyle.Fill;
            //panel_admin.Dock = DockStyle.Fill;
            //panel_registerclient.Dock = DockStyle.Fill;
            //panel_removeclient.Dock = DockStyle.Fill;
            //panel_showstatistics.Dock = DockStyle.Fill;
            //panel_specificclient.Dock = DockStyle.Fill;
            //panel_specificinvoice.Dock = DockStyle.Fill;
            //variablepanel.Dock = DockStyle.Fill;

            adminpaneltxt.Visible = false;
            panel_client.Visible = false;
            panel_admin.Visible = false;
            panel_registerclient.Visible = false;
            panel_removeclient.Visible = false;
            panel_showstatistics.Visible = false;
            panel_specificclient.Visible = false;
            panel_specificinvoice.Visible = false;
            variablepanel.Visible = false;

            //Image myimage = new Bitmap("D:\\Fac\\III\\Administrare baze de date\\Proiect\\CustomWorks\\1.jpg");
            //this.BackgroundImage = myimage;
            this.Size = new System.Drawing.Size(400, 300);
        }

        private void buton_start_Click(object sender, EventArgs e)
        {
            panel_admin.Visible = true;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            adminpaneltxt.Visible = true;
            panel_client.Visible = false;
            this.Size = new System.Drawing.Size(300, 250);
            //Form2 frm = new Form2();
            //frm.ShowDialog();
        }

        private void buton_client_Click(object sender, EventArgs e)
        {
            panel_client.Visible = true;
            panel_admin.Visible = false;

            //Form3 frm = new Form3();
            //frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_admin.Visible = false;
           

        }

        private void buton_goo_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == null)
            {
                return;
            }
            string selected_item = comboBox1.Text.ToString();

            if (selected_item == "Register client")
            {
              //  panel_admin.Visible = false;
                panel_registerclient.Visible = true;
            }
            if (selected_item == "Clienti")
            {
                //panel_admin.Visible = false;
                adminpaneltxt.Visible = false;
                //ComboBox1.
                variablepanel.Visible = true;
              
                this.Size = new System.Drawing.Size(1000,2000);
            }

            if (selected_item == "Remove client")
            {
                panel_removeclient.Visible = true;
            }

            if (selected_item == "Specific client")
            {
                panel_specificclient.Visible = true;
            }

            if (selected_item == "Specific invoice")
            {
                panel_specificinvoice.Visible = true;
            }

            if (selected_item == "Order pieces")
            {
                panel_orderpieces.Visible = true;
            }

            if (selected_item == "Show statistics")
            {
                panel_showstatistics.Visible = true;
            }
        }

        private void panel_client_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buton_back_client_Click_1(object sender, EventArgs e)
        {
            panel_client.Visible = false;
        }

        private void buton_go_Click_1(object sender, EventArgs e)
        {
            vin = textbox_VIN.Text;
            if (vin.Length == 17)
            {

            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                string errorr = "Incorrect VIN try again!";

                result = MessageBox.Show(errorr, "Nope", buttons);
            }
        }

        private void buton_done_Click(object sender, EventArgs e)
        {
            string first_name = textBox_firstname.Text;
            string last_name = textBox_lastname.Text;
            string address = textBox_address.Text;
            string cnp = text_cnp.Text;
            string manufacturer = textBox_manufacturer.Text;
            string model = textBox_model.Text;
            string year = textBox_year.Text;
            string doors = textBox_doors.Text;
            string fuel = textBox_fuel.Text;
            string vin = textBox_vinn.Text;

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            string errorr = "Information is "+ first_name+" "+last_name+" "+address+" "+cnp+" "+manufacturer+" "+model+" "+year+" "+doors+" "+fuel+" "+vin;

            result = MessageBox.Show(errorr, "Nope", buttons);

            panel_registerclient.Visible = false;
        }

        private void buton_remove_client_Click(object sender, EventArgs e)
        {

        }

        private void buton_specific_show_Click(object sender, EventArgs e)
        {

        }

        private void buton_specific_invoice_Click(object sender, EventArgs e)
        {

        }

        private void buton_remove_client2_Click(object sender, EventArgs e)
        {
            panel_removeclient.Visible = false;
        }

        private void buton_specific_invoice2_Click(object sender, EventArgs e)
        {
            panel_specificinvoice.Visible = false;
        }

        private void buton_specific_client2_Click(object sender, EventArgs e)
        {
            panel_specificclient.Visible = false;
        }

        private void panel_registerclient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_specificclient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_Click_1(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
