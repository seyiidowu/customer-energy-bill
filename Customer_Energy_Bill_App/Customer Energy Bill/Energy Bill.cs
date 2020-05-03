using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Energy_Bill
{
    public partial class frmCalculateEnergyBill : Form
    {

        private void frmCalculateEnergyBill_Load(object sender, EventArgs e)
        {
            cmbenergyUser.SelectedIndex = 0;
        }
        public frmCalculateEnergyBill()
        {
            InitializeComponent();
        }

        private void cmbenergyUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbenergyUser.SelectedIndex)
            {
                case 0:
                    lblNumofKWh.Visible = false;
                    lblBalance.Visible = false;
                    txtNumofKWh.Visible = false;
                    txtBalance.Visible = false;
                    btnCalculate.Visible = false;
                    btnReset.Visible = false;
                    btnExit.Visible = false;
                    lblPHKWh.Visible = false;
                    lblOPHKWh.Visible = false;
                    txtPHKWh.Visible = false;
                    txtOPHKWh.Visible = false;
                    break;

                case 1:
                case 2:
                    lblNumofKWh.Visible = true;
                    lblBalance.Visible = true;
                    txtNumofKWh.Visible = true;
                    txtBalance.Visible = true;
                    btnCalculate.Visible = true;
                    btnReset.Visible = true;
                    btnExit.Visible = true;
                    lblPHKWh.Visible = false;
                    lblOPHKWh.Visible = false;
                    txtPHKWh.Visible = false;
                    txtOPHKWh.Visible = false;
                    break;

                case 3:
                    lblNumofKWh.Visible = false;
                    lblBalance.Visible = true;
                    txtNumofKWh.Visible = false;
                    txtBalance.Visible = true;
                    btnCalculate.Visible = true;
                    btnReset.Visible = true;
                    btnExit.Visible = true;
                    lblPHKWh.Visible = true;
                    lblOPHKWh.Visible = true;
                    txtPHKWh.Visible = true;
                    txtOPHKWh.Visible = true;
                    break;
            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // function used in calculation of energy bill amount
        public double calculatePay(int FLAT, int KWh, double rate, int FLATRATE)
        {
            decimal result;
            if (KWh > FLAT)
                result = ((KWh - FLAT) * rate) + FLATRATE;
            else
                result = FLATRATE;
            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare constants
            const double RES_RATE = 0.052;
            const int RES_FLAT_RATE = 6;
            const double COMM_RATE = 0.045;
            const int COMM_FLAT_RATE = 60;
            const int FLAT_KWH = 1000m;
            const int IND_P_FLAT_RATE = 76;
            const int IND_OP_FLAT_RATE = 40;
            const double IND_P_RATE = 0.065;
            const double IND_OP_RATE = 0.028;

            //Variable
            double numKWh;  //input
            double numPHKWh;  //input
            double numOPHKWh; //input
            double chargeAmt = 0;


            if (Validator.IsPresent(txtNumofKWh, "KWh") &&
                Validator.IsNonNegativeDouble(txtNumofKWh, "KWh") &&
                Validator.IsPresent(txtPHKWh, "PeakHourKWh") &&
                Validator.IsNonNegativeDouble(txtPHKWh, "PeakHourKWh") &&
                Validator.IsPresent(txtOPHKWh, "OffPeakHourKWh") &&
                Validator.IsNonNegativeDouble(txtOPHKWh, "OffPeakHourKWh")
                )

            {
                // perform calculations

                switch (cmbenergyUser.SelectedIndex)
                {
                    case 1:
                        numKWh = Convert.ToDouble(txtNumofKWh.Text);  //get input
                        chargeAmt = calculatePay(FLAT_KWH, numKWh, RES_RATE, RES_FLAT_RATE);
                        break;

                    case 2:
                        numKWh = Convert.ToDouble(txtNumofKWh.Text);  //get input  
                        chargeAmt = calculatePay(FLAT_KWH, numKWh, COMM_RATE, COMM_FLAT_RATE);
                        break;

                    case 3:
                        numPHKWh = Convert.ToDouble(txtPHKWh.Text);  //get input
                        numOPHKWh = Convert.ToDouble(txtOPHKWh.Text);  //get input

                        if (numPHKWh > FLAT_KWH && numOPHKWh > FLAT_KWH)
                            chargeAmt = (((numPHKWh - FLAT_KWH) * IND_P_RATE) + IND_P_FLAT_RATE) + (((numOPHKWh - FLAT_KWH) * IND_OP_RATE) + IND_OP_FLAT_RATE);
                        else if (numPHKWh > FLAT_KWH && numOPHKWh <= FLAT_KWH)
                            chargeAmt = (((numPHKWh - FLAT_KWH) * IND_P_RATE) + IND_P_FLAT_RATE) + IND_OP_FLAT_RATE;
                        else if (numPHKWh <= FLAT_KWH && numOPHKWh > FLAT_KWH)
                            chargeAmt = IND_P_FLAT_RATE + (((numOPHKWh - FLAT_KWH) * IND_OP_RATE) + IND_OP_FLAT_RATE);
                        else
                            chargeAmt = IND_P_FLAT_RATE + IND_OP_FLAT_RATE;
                        break;
                }

                // display result
                txtBalance.Text = chargeAmt.ToString("c");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBalance.Text = "";
            txtNumofKWh.Text = "";
            txtPHKWh.Text = "";
            txtOPHKWh.Text = "";
            txtNumofKWh.Focus();
            txtPHKWh.Focus();
       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

    }
}
