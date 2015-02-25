﻿using System;
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

            // Get the saved value from the application's settings
            primaryAccount.Text = Properties.Settings.Default.primaryAccount;

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
           // string primaryAccountS = Properties.Settings.Default.primaryAccount;

            try
            {
                //Expense loop
                for (int i = 0; i < expenseGrid.Rows.Count; ++i)
                {
                    expenseSum += Convert.ToDecimal(expenseGrid.Rows[i].Cells[1].Value);
                }

                //Income loop
                for (int i = 0; i < incomeGrid.Rows.Count; ++i)
                {
                    incomeSum += Convert.ToDecimal(incomeGrid.Rows[i].Cells[1].Value);
                    incomeAftTax += Convert.ToDecimal(incomeGrid.Rows[i].Cells[3].Value);
                }
            }
            catch
            {
                Console.Write(expenseSum);
            }


            try
            {

                for (int i = 0; i < balanceGrid.Rows.Count; ++i)
                {
                    if (primaryAccount.Text == "")
                    {
                        currBalance += Convert.ToDecimal(balanceGrid.Rows[i].Cells[1].Value);
                    }
                    else
                    {
                        if (Convert.ToInt32(balanceGrid.Rows[i].Cells[3].Value) == Convert.ToInt32(primaryAccount.Text))
                        {
                            currBalance = Convert.ToDecimal(balanceGrid.Rows[i].Cells[1].Value);
                        }
                    }
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
            // Save any un-commited changes
            dataUpdate();
            // Save the value in the text box in the application's settings
            Properties.Settings.Default.primaryAccount = primaryAccount.Text;
            // Tell the application to save the new values
            Properties.Settings.Default.Save();
            this.Close();
        }

    }
}
