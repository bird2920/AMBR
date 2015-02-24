using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlDataAdapter sdaexp;
        SqlCommandBuilder scbexp;
        DataTable dtexp;
        SqlDataAdapter sdainc;
        SqlCommandBuilder scbinc;
        DataTable dtinc;
        SqlDataAdapter sdabal;
        SqlCommandBuilder scbbal;
        DataTable dtbal;


        private void dataRefresh()
        {

            SqlConnection con = new SqlConnection("Data Source=.\\SQLBIRD;AttachDbFilename=C:\\Users\\Richardbi\\Documents\\ambr.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            sdaexp = new SqlDataAdapter(@"SELECT billName AS Name, billAmount as Amount, billDescription as Description, billId as ID FROM expenses", con);
            dtexp = new DataTable();
            sdaexp.Fill(dtexp);
            expenseGrid.DataSource = dtexp;
            sdainc = new SqlDataAdapter(@"SELECT incomeName as Name, incomeAmount as Amount, CONVERT(DECIMAL(10,2),incomeTax) as Tax, CONVERT(DECIMAL(10,2),incomeAmount-(incomeAmount * isnull(incomeTax, 0.00))/100) as NetAmount ,incomeId as ID FROM income", con);
            dtinc = new DataTable();
            sdainc.Fill(dtinc);
            incomeGrid.DataSource = dtinc;
            sdabal = new SqlDataAdapter(@"SELECT balanceAccountName as Account, balanceAmount as Amount, balanceDescription as Description, balanceId as ID FROM balance", con);
            dtbal = new DataTable();
            sdabal.Fill(dtbal);
            balanceGrid.DataSource = dtbal;

            UpdateCalculations(null, null);
        }

        private void dataUpdate()
        {
            scbexp = new SqlCommandBuilder(sdaexp);
            sdaexp.Update(dtexp);
            scbinc = new SqlCommandBuilder(sdainc);
            sdainc.Update(dtinc);
            scbbal = new SqlCommandBuilder(sdabal);
            sdabal.Update(dtbal);

            UpdateCalculations(null, null);
        }

        public Form1()
        {
            InitializeComponent();
            dataRefresh();
        }


        private void gridCellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataUpdate();
            UpdateCalculations(null, null);
        }

        private void UpdateCalculations(object sender, EventArgs e)
        {

            decimal expenseSum = 0;
            decimal incomeSum = 0;
            decimal incomeAftTax = 0;
            decimal currBalance = 0;

            try
            {
                for (int expenseLoop = 0; expenseLoop < expenseGrid.Rows.Count; ++expenseLoop)
                {
                    expenseSum += Convert.ToDecimal(expenseGrid.Rows[expenseLoop].Cells[1].Value);
                }
            }
            catch
            {
                Console.Write(expenseSum);
            }

            try
            {
                for (int incomeLoop = 0; incomeLoop < incomeGrid.Rows.Count; ++incomeLoop)
                {
                    incomeSum += Convert.ToDecimal(incomeGrid.Rows[incomeLoop].Cells[1].Value);
                }
            }
            catch
            {
                Console.Write(incomeSum);
            }

            try
            {
                for (int aftTaxLoop = 0; aftTaxLoop < incomeGrid.Rows.Count; ++aftTaxLoop)
                {
                    incomeAftTax += Convert.ToDecimal(incomeGrid.Rows[aftTaxLoop].Cells[3].Value);
                }
            }
            catch
            {
                Console.Write(incomeAftTax);
            }

            try
            {
                for (int currLoop = 0; currLoop < balanceGrid.Rows.Count; ++currLoop)
                {
                    currBalance += Convert.ToDecimal(balanceGrid.Rows[currLoop].Cells[1].Value);
                }
            }
            catch
            {
                Console.Write(currBalance);
            }

            decimal total;

            try
            {
                total = currBalance - expenseSum + incomeAftTax;

                expenseTotalV.Text = String.Format("{0,-10:C}", expenseSum);
                incomeTotal.Text = String.Format("{0,-10:C}", incomeSum);
                incomeAftTaxV.Text = String.Format("{0,-10:C}", incomeAftTax);
                afterExpTotalV.Text = String.Format("{0,-10:C}", total);
                currBalanceV.Text = String.Format("{0,-10:C}", currBalance);

            }
            catch
            {
                Console.Write(currBalance);
            }
        }

        private void deleteRowUpdate(object sender, DataGridViewRowEventArgs e)
        {
            dataUpdate();
            dataRefresh();
        }

        private void refreshButtonClick(object sender, EventArgs e)
        {
            dataRefresh();
            UpdateCalculations(null, null);
        }

        private void doneCloseClick(object sender, EventArgs e)
        {
            dataRefresh();
            dataUpdate();
            this.Close();
        }

        
        //private void validating_Cell(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    expenseGrid.Rows[e.RowIndex].ErrorText = "";
        //    int newInteger;

        //    // Don't try to validate the 'new row' until finished 
        //    // editing since there
        //    // is not any point in validating its initial value.
        //    if (expenseGrid.Rows[e.RowIndex].IsNewRow) { return; }
        //    if (!int.TryParse(e.FormattedValue.ToString(),
        //        out newInteger) || newInteger < 0)
        //    {
        //        e.Cancel = true;
        //        expenseGrid.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
        //    }

        //    incomeGrid.Rows[e.RowIndex].ErrorText = "";
        //    int newInteger1;

        //    // Don't try to validate the 'new row' until finished 
        //    // editing since there
        //    // is not any point in validating its initial value.
        //    if (incomeGrid.Rows[e.RowIndex].IsNewRow) { return; }
        //    if (!int.TryParse(e.FormattedValue.ToString(),
        //        out newInteger1) || newInteger1 < 0)
        //    {
        //        e.Cancel = true;
        //        incomeGrid.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
        //    }

        //    balanceGrid.Rows[e.RowIndex].ErrorText = "";
        //    int newInteger2;

        //    // Don't try to validate the 'new row' until finished 
        //    // editing since there
        //    // is not any point in validating its initial value.
        //    if (balanceGrid.Rows[e.RowIndex].IsNewRow) { return; }
        //    if (!int.TryParse(e.FormattedValue.ToString(),
        //        out newInteger2) || newInteger2 < 0)
        //    {
        //        e.Cancel = true;
        //        balanceGrid.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
        //    }

        //}

        //private void leave_Cell(object sender, DataGridViewCellEventArgs e)
        //{
        //    expenseGrid.Rows[e.RowIndex].ErrorText = "";
        //    incomeGrid.Rows[e.RowIndex].ErrorText = "";
        //    balanceGrid.Rows[e.RowIndex].ErrorText = "";
        //}

    }
}
