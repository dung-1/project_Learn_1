using CalculatorApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp.UI.Forms
{
    public partial class Mainform : Form
    {
        private readonly ICalculatorService _calculatorService;

        public Mainform(ICalculatorService calculatorService)
        {
            InitializeComponent();
            _calculatorService = calculatorService;
        }
        //private void RefreshHistory()
        //{
        //    var history = _calculatorService.GetHistory();
        //    lstHistory.Items.Clear();
        //    foreach (var calc in history)
        //    {
        //        lstHistory.Items.Add(
        //            $"{calc.FirstNumber} {calc.Operation} {calc.SecondNumber} = {calc.Result} ({calc.CalculationTime})"
        //        );
        //    }
        //}

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = double.Parse(txtsoa.Text);
                double sob = double.Parse(txtsob.Text);
                lblKetqua.Text = _calculatorService.Calculate(soa, sob, "+").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = double.Parse(txtsoa.Text);
                double sob = double.Parse(txtsob.Text);
                lblKetqua.Text = _calculatorService.Calculate(soa, sob, "-").ToString();
                //RefreshHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = double.Parse(txtsoa.Text);
                double sob = double.Parse(txtsob.Text);
                lblKetqua.Text = _calculatorService.Calculate(soa, sob, "*").ToString();
                //RefreshHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            try
            {
                double soa = double.Parse(txtsoa.Text);
                double sob = double.Parse(txtsob.Text);
                lblKetqua.Text = _calculatorService.Calculate(soa, sob, "/").ToString();
                //RefreshHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtsoa.Text = "";
            txtsob.Text = "";
            lblKetqua.Text = "";

        }
    }
}
