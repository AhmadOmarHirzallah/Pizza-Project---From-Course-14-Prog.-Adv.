using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class FrmPlaceOrder : Form
    {
        private FrmMain _parentForm { get; set; }

        public decimal _totalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        public FrmPlaceOrder()
        {
            InitializeComponent();
        }

        public FrmPlaceOrder(FrmMain parentForm)
        {
            InitializeComponent( );
            _parentForm = parentForm;
        }

        private void FrmPlaceOrder_Load(object sender, EventArgs e)
        {
            FontManager.ApplyFontsToForm(this);
        }

        public void setLblPizzaSize(string size)
        {
            lblSize.Text = size;
        }

        public void setLblCrustType(string crustType)
        {
            lblCrustType.Text = crustType;
        }

        public void setLblToppings(string toppings)
        {
            lblToppings.Text = toppings;
            
            // Optional: If you want to automatically adjust height based on content
            using (Graphics g = lblToppings.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(toppings, lblToppings.Font, lblToppings.Width);
                lblToppings.Height = (int)Math.Ceiling(textSize.Height);
            }
        }

        public void setLblTotalPrice(string totalPrice)
        {
            lblTitlePrice.Text = totalPrice;
        }

        public void setLblWhereToEat(string whereToEat)
        {
            lblWhereToEat.Text = whereToEat;
        }


        private void disableControls()
        {
            gpOrderSummary.Enabled = false;
            btnOrderPizza.Enabled = false;
        }
        public void enableControls()
        {
            gpOrderSummary.Enabled = true;
            btnOrderPizza.Enabled = true;
        }


        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to place this order?",
                "Confirm Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Your order has been placed successfully!",
                                 "Order placed successfully",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                disableControls();
                _parentForm?.SetControlsMainEnableStatus( );
            }
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            _parentForm.resetFormMain( );
         }

        // Method to clear the order summary
        public void ClearOrderSummary()
        {
            lblSize.Text = "Not Selected";
            lblToppings.Text = "None";
            lblCrustType.Text = "Not Selected";
            lblWhereToEat.Text = "Not Selected";
            lblTitlePrice.Text = "$ 0.00";
        }
    }
}
