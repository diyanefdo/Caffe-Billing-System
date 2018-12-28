using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caffe_Billing_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            txtAff.Text = "0";
            txtAm.Text = "0";
            txtBCC.Text = "0";
            txtBFC.Text = "0";
            txtCap.Text = "0";
            txtCHC.Text = "0";
            txtCoffeeCake.Text = "0";
            txtCostCakes.Text = "0";
            txtCostDrinks.Text = "0";
            txtEsp.Text = "0";
            txtGrandTotal.Text = "0";
            txtIcedCap.Text = "0";
            txtIcedLatte.Text = "0";
            txtKCC.Text = "0";
            txtLatte.Text = "0";
            txtLCC.Text = "0";
            txtQPC.Text = "0";
            txtRVC.Text = "0";
            txtSubTotal.Text = "0";
            txtTax.Text = "0";
            txtValeCoffee.Text = "0";
            txtServCharge.Text = "0";

            txtAff.Enabled = false;
            txtAm.Enabled = false;
            txtBCC.Enabled = false;
            txtBFC.Enabled = false;
            txtCap.Enabled = false;
            txtCHC.Enabled = false;
            txtCoffeeCake.Enabled = false;
            txtEsp.Enabled = false;
            txtIcedCap.Enabled = false;
            txtIcedLatte.Enabled = false;
            txtKCC.Enabled = false;
            txtLatte.Enabled = false;
            txtLCC.Enabled = false;
            txtQPC.Enabled = false;
            txtRVC.Enabled = false;
            txtValeCoffee.Enabled = false;

            varAffCoffee.Checked = false;
            varAmCoffee.Checked = false;
            varBCC.Checked = false;
            varBFC.Checked = false;
            varCap.Checked = false;
            varCHCC.Checked = false;
            varCoffeeCake.Checked = false;
            varEsp.Checked = false;
            varIcedCap.Checked = false;
            varIcedLatte.Checked = false;
            varKCC.Checked = false;
            varLatte.Checked = false;
            varLCC.Checked = false;
            varQPCC.Checked = false;
            varRedV.Checked = false;
            varValeCoffee.Checked = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (varIcedLatte.Checked)
                txtIcedLatte.Enabled = true;
            else
            {
                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (varAffCoffee.Checked)
                txtAff.Enabled = true;
            else
            {
                txtAff.Enabled = false;
                txtAff.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (varIcedCap.Checked)
                txtIcedCap.Enabled = true;
            else
            {
                txtIcedCap.Enabled = false;
                txtIcedCap.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (varRedV.Checked)
                txtRVC.Enabled = true;
            else
            {
                txtRVC.Enabled = false;
                txtRVC.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (varBFC.Checked)
                txtBFC.Enabled = true;
            else
            {
                txtBFC.Enabled = false;
                txtBFC.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAff.Text = "0";
            txtAm.Text = "0";
            txtBCC.Text = "0";
            txtBFC.Text = "0";
            txtCap.Text = "0";
            txtCHC.Text = "0";
            txtCoffeeCake.Text = "0";
            txtCostCakes.Text = "0";
            txtCostDrinks.Text = "0";
            txtEsp.Text = "0";
            txtGrandTotal.Text = "0";
            txtIcedCap.Text = "0";
            txtIcedLatte.Text = "0";
            txtKCC.Text = "0";
            txtLatte.Text = "0";
            txtLCC.Text = "0";
            txtQPC.Text = "0";
            txtRVC.Text = "0";
            txtSubTotal.Text = "0";
            txtTax.Text = "0";
            txtValeCoffee.Text = "0";
            txtServCharge.Text = "0";

            varAffCoffee.Checked = false;
            varAmCoffee.Checked = false;
            varBCC.Checked = false;
            varBFC.Checked = false;
            varCap.Checked = false;
            varCHCC.Checked = false;
            varCoffeeCake.Checked = false;
            varEsp.Checked = false;
            varIcedCap.Checked = false;
            varIcedLatte.Checked = false;
            varKCC.Checked = false;
            varLatte.Checked = false;
            varLCC.Checked = false;
            varQPCC.Checked = false;
            varRedV.Checked = false;
            varValeCoffee.Checked = false;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLatte_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCap_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txtValeCoffee_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void txtAm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIcedCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAff_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void varLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (varLatte.Checked)
                txtLatte.Enabled = true;
            else
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
            
        }

        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }

        private void varEsp_CheckedChanged(object sender, EventArgs e)
        {
            if (varEsp.Checked)
                txtEsp.Enabled = true;
            else
            {
                txtEsp.Enabled = false;
                txtEsp.Text = "0";
            }
        }

        private void varValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (varValeCoffee.Checked)
                txtValeCoffee.Enabled = true;
            else
            {
                txtValeCoffee.Enabled = false;
                txtValeCoffee.Text = "0";
            }
        }

        private void varCap_CheckedChanged(object sender, EventArgs e)
        {
            if (varCap.Checked)
                txtCap.Enabled = true;
            else
            {
                txtCap.Enabled = false;
                txtCap.Text = "0";
            }
        }

        private void varAmCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (varAmCoffee.Checked)
                txtAm.Enabled = true;
            else
            {
                txtAm.Enabled = false;
                txtAm.Text = "0";
            }
        }

        private void varCoffeeCake_CheckedChanged(object sender, EventArgs e)
        {
            if (varCoffeeCake.Checked)
                txtCoffeeCake.Enabled = true;
            else
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
        }

        private void varBCC_CheckedChanged(object sender, EventArgs e)
        {
            if (varBCC.Checked)
                txtBCC.Enabled = true;
            else
            {
                txtBCC.Enabled = false;
                txtBCC.Text = "0";
            }
        }

        private void varLCC_CheckedChanged(object sender, EventArgs e)
        {
            if (varLCC.Checked)
                txtLCC.Enabled = true;
            else
            {
                txtLCC.Enabled = false;
                txtLCC.Text = "0";
            }
        }

        private void varKCC_CheckedChanged(object sender, EventArgs e)
        {
            if (varKCC.Checked)
                txtKCC.Enabled = true;
            else
            {
                txtKCC.Enabled = false;
                txtKCC.Text = "0";
            }
        }

        private void varCHCC_CheckedChanged(object sender, EventArgs e)
        {
            if (varCHCC.Checked)
                txtCHC.Enabled = true;
            else
            {
                txtCHC.Enabled = false;
                txtCHC.Text = "0";
            }

        }

        private void varQPCC_CheckedChanged(object sender, EventArgs e)
        {
            if (varQPCC.Checked)
                txtQPC.Enabled = true;
            else
            {
                txtQPC.Enabled = false;
                txtQPC.Text = "0";
            }
        }

        private void txtCoffeeCake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRVC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBCC_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txtLCC_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void txtKCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCHC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQPC_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            receipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileOpen = new OpenFileDialog();
            FileOpen.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (FileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                receipt.LoadFile(FileOpen.FileName, RichTextBoxStreamType.PlainText);
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt*)|*.txt|All files (*.*)|*.*";
            
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(receipt.Text);

                
            }

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            receipt.Clear();
            
            receipt.AppendText(Environment.NewLine);
            receipt.AppendText("\t\t" + "The Grand Cafe " + Environment.NewLine);
            receipt.AppendText("-------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine); 
            receipt.AppendText(varLatte.Text + "\t\t\t\t\t\t" + txtLatte.Text + Environment.NewLine);
            receipt.AppendText(varEsp.Text + "\t\t\t\t\t" + txtEsp.Text + Environment.NewLine);
            receipt.AppendText(varIcedLatte.Text + "\t\t\t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            receipt.AppendText(varValeCoffee.Text + "\t\t\t\t\t" + txtValeCoffee.Text + Environment.NewLine);
            receipt.AppendText(varCap.Text + "\t\t\t\t\t" + txtCap.Text + Environment.NewLine);
            receipt.AppendText(varAffCoffee.Text + "\t\t\t\t\t" + txtAff.Text + Environment.NewLine);
            receipt.AppendText(varAmCoffee.Text + "\t\t\t\t" + txtAm.Text + Environment.NewLine);
            receipt.AppendText(varIcedCap.Text + "\t\t\t\t" + txtIcedCap.Text + Environment.NewLine);
            receipt.AppendText(varCoffeeCake.Text + "\t\t\t\t\t" + txtCoffeeCake.Text + Environment.NewLine);
            receipt.AppendText(varRedV.Text + "\t\t\t\t" + txtRVC.Text + Environment.NewLine);
            receipt.AppendText(varBFC.Text + "\t\t\t\t" + txtBFC.Text + Environment.NewLine);
            receipt.AppendText(varBCC.Text + "\t\t\t\t" + txtBCC.Text + Environment.NewLine);
            receipt.AppendText(varLCC.Text + "\t\t\t\t" + txtLCC.Text + Environment.NewLine);
            receipt.AppendText(varKCC.Text + "\t\t\t\t" + txtKCC.Text + Environment.NewLine);
            receipt.AppendText(varCHCC.Text + "\t\t\t" + txtCHC.Text + Environment.NewLine);
            receipt.AppendText(varQPCC.Text + "\t\t\t" + txtQPC.Text + Environment.NewLine);
            receipt.AppendText("--------------------------------------------------------------------------" + Environment.NewLine);
            receipt.AppendText(ServCharge.Text + "\t\t\t\t\t" + txtServCharge.Text + Environment.NewLine);
            receipt.AppendText("--------------------------------------------------------------------------" + Environment.NewLine);
            receipt.AppendText("Tax\t\t\t\t\t\t" + txtTax.Text + Environment.NewLine);
            receipt.AppendText("Sub Total \t\t\t\t\t" + txtSubTotal.Text + Environment.NewLine);
            receipt.AppendText("Total Cost \t\t\t\t\t" + txtGrandTotal.Text + Environment.NewLine);
            receipt.AppendText("--------------------------------------------------------------------------" + Environment.NewLine);
            receipt.AppendText(lblTime.Text + "\t\t\t" + lblDate.Text);
            
        }

        private void txtEsp_Click(object sender, EventArgs e)
        {
            txtEsp.Text = "";
            txtEsp.Focus();
        }

        private void txtIcedLatte_Click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = "";
            txtIcedLatte.Focus();
        }

        private void txtValeCoffee_Click(object sender, EventArgs e)
        {
            txtValeCoffee.Text = "";
            txtValeCoffee.Focus();
        }

        private void txtCap_Click(object sender, EventArgs e)
        {
            txtCap.Text = "";
            txtCap.Focus();
        }

        private void txtAff_Click(object sender, EventArgs e)
        {
            txtAff.Text = "";
            txtAff.Focus();
        }
        
        private void txtAm_Click(object sender, EventArgs e)
        {
            txtAm.Text = "";
            txtAm.Focus();
        }

        private void txtIcedCap_Click(object sender, EventArgs e)
        {
            txtIcedCap.Text = "";
            txtIcedCap.Focus();
        }

        private void txtCoffeeCake_Click(object sender, EventArgs e)
        {
            txtCoffeeCake.Text = "";
            txtCoffeeCake.Focus();
        }

        private void txtRVC_Click(object sender, EventArgs e)
        {
            txtRVC.Text = "";
            txtRVC.Focus();
        }

        private void txtBFC_Click(object sender, EventArgs e)
        {
            txtBFC.Text = "";
            txtBFC.Focus();
        }

        private void txtBCC_Click(object sender, EventArgs e)
        {
            txtBCC.Text = "";
            txtBCC.Focus();
        }

        private void txtLCC_Click(object sender, EventArgs e)
        {
            txtLCC.Text = "";
            txtLCC.Focus();
        }

        private void txtKCC_Click(object sender, EventArgs e)
        {
            txtKCC.Text = "";
            txtKCC.Focus();
        }

        private void txtCHC_Click(object sender, EventArgs e)
        {
            txtCHC.Text = "";
            txtCHC.Focus();
        }

        private void txtQPC_Click(object sender, EventArgs e)
        {
            txtQPC.Text = "";
            txtQPC.Focus();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double latte, icedLatte, espresso, ValeCoffee, capp, iceCap, afCoffee, amcoffee;
            double coffeeCake, RVCake, bfc, bcc, lcc, kcc, chc, qpc;
            //Coffee
            latte = 100; icedLatte = 70; espresso = 120; ValeCoffee = 130; capp = 150; afCoffee = 60; amcoffee = 115; iceCap = 90;
            //Cake
            coffeeCake = 60; RVCake = 85; bfc = 75; bcc = 90; lcc = 75; kcc = 80; chc = 50; qpc = 100;
            //Tax
            const double Tax = 6.5;
            //Coffee
            double latte_coffee = Convert.ToDouble(txtLatte.Text);
            double espresso_coffee = Convert.ToDouble(txtEsp.Text);
            double Iced_Latte = Convert.ToDouble(txtIcedLatte.Text);
            double vale_coffee = Convert.ToDouble(txtValeCoffee.Text);
            double cappucino = Convert.ToDouble(txtCap.Text);
            double iced_cap = Convert.ToDouble(txtIcedCap.Text);
            double african_coffee = Convert.ToDouble(txtAff.Text);
            double american_coffee = Convert.ToDouble(txtAm.Text);
            //Cake
            double coffee_cake = Convert.ToDouble(txtCoffeeCake.Text);
            double red_velvet_cake = Convert.ToDouble(txtRVC.Text);
            double black_forest = Convert.ToDouble(txtBFC.Text);
            double boston_cream = Convert.ToDouble(txtBCC.Text);
            double lagos_choc = Convert.ToDouble(txtLCC.Text);
            double kilburn_choc = Convert.ToDouble(txtKCC.Text);
            double carlton_hill = Convert.ToDouble(txtCHC.Text);
            double queens_park = Convert.ToDouble(txtQPC.Text);

            double costOfDrinks = (latte_coffee * latte) + (espresso_coffee * espresso) + (Iced_Latte * icedLatte) +
                (vale_coffee * ValeCoffee) + (cappucino * capp) + (iced_cap * iceCap) + (african_coffee * afCoffee) +
                (american_coffee * amcoffee);
            txtCostDrinks.Text = "Rs. " + costOfDrinks.ToString();

            double cost_of_cakes = (coffee_cake * coffeeCake) + (red_velvet_cake * RVCake) + (black_forest * bfc) +
                (boston_cream * bcc) + (lagos_choc * lcc) + (kilburn_choc * kcc) + (carlton_hill * chc) + (queens_park * qpc);
            txtCostCakes.Text = "Rs. " + cost_of_cakes.ToString();

            double service_charge = 0;
            if (costOfDrinks + cost_of_cakes > 0)
                service_charge = 30;

            txtSubTotal.Text = "Rs. " + (cost_of_cakes + costOfDrinks + service_charge).ToString();
            double taxAmount = (cost_of_cakes + costOfDrinks) * Tax / 100;
            txtTax.Text = "Rs. " + taxAmount.ToString();

            txtServCharge.Text = "Rs. " + service_charge;
            txtGrandTotal.Text = "Rs. " + (costOfDrinks + cost_of_cakes + service_charge + taxAmount).ToString();

           
        }
    }
}  
