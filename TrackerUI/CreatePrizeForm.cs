﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Data;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValue.Text,
                    PlaceNumberValue.Text,
                    PrizeAmountValue.Text,
                    PrizePercentValue.Text);

              foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                PlaceNameValue.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountValue.Text = "0";
                PrizePercentValue.Text="0";
            }
            else
            {
                MessageBox.Show("Invalid Values! Please Recheck");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumberValue.Text, out placeNumber);
      

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid =double.TryParse(PrizePercentValue.Text, out prizePercentage);

            if(prizeAmountValid == false || prizePercentageValid==false)
            {
                output = false;
            }

            if(prizeAmount<=0 && prizePercentage <=0)
            {
                output = false;
            }

            if(prizePercentage<0 || prizePercentage >100)
            {
                output = false;
            }

            return output;
            
        }
    }
}
