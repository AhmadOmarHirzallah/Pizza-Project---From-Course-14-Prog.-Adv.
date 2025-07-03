using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class FrmMain : Form
    {

        private FrmPlaceOrder _orderForm;


        public FrmMain()
        {
            InitializeComponent();
        }

        private void initializePizzaDefaults()
        {
            rdoSmall.Checked = true;
            rdoCrustThin.Checked = true;
            rdoEatIn.Checked = true;
            _orderForm.setLblToppings(string.Empty);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Use the new FontManager to apply fonts to all controls
            FontManager.ApplyFontsToForm(this);
            _orderForm = new FrmPlaceOrder(  this ); // Initialize _orderForm
            initializePizzaDefaults( );
        }

        private void btnOrderPizza_Click( object sender, EventArgs e )
        {
            var orderForm = getOrderForm( );
            updatePizzaSize( );
            orderForm.Show( );
            orderForm.BringToFront( );
        }
        private void OrderForm_FormClosed( object sender, FormClosedEventArgs e )
        {
            // Clean up our reference when the form is closed
            _orderForm = null;
        }

        private FrmPlaceOrder getOrderForm()
        {
            if (_orderForm == null || _orderForm.IsDisposed)
            {
                _orderForm = new FrmPlaceOrder( this );
                _orderForm.FormClosed += OrderForm_FormClosed;

            }
            return (_orderForm);
        }

        private void updatePizzaSize( )
        {
            if (rdoBig.Checked)
            {
                _orderForm.setLblPizzaSize( rdoBig.Text );
            }
            else if (rdoMedium.Checked)
            {
                _orderForm.setLblPizzaSize( rdoMedium.Text );
            }
            else if (rdoSmall.Checked)
            {
                _orderForm.setLblPizzaSize( rdoSmall.Text );
            }
        }

        private decimal CalcSelectedSizePrice()
        {
            foreach (Control control in gpSizes.Controls)
            {
                if (control is RadioButton radioButton
                    && radioButton.Checked)
                {
                    return ( Convert.ToDecimal( radioButton.Tag ) );
                }
            }
            return (0);
        }

        private decimal CalcSelectedCrustPrice()
        {
            foreach (Control control in gpCrustType.Controls)
            {
                if (control is RadioButton rdoButton 
                    && rdoButton.Checked)
                {
                    return ( Convert.ToDecimal( rdoButton.Tag ) );
                }
            }
            return ( 0 );
        }

        private decimal CalcSelectedToppingsPrice()
        {
            decimal total = 0;
            foreach (Control ctrl in gpToppings.Controls)
            {
                if (ctrl is CheckBox checkBox && checkBox.Checked)
                {
                    total += Convert.ToDecimal( checkBox.Tag );
                }
            }
            return ( total );
        }
        private decimal CalculateTotalPrice()
        {
            int pizzaCount = barCountOfPizzas.Value;
            return ((CalcSelectedSizePrice() + 
                    CalcSelectedCrustPrice() +
                    CalcSelectedToppingsPrice()) * pizzaCount);
        }

        private void updateTotalPrice()
        {
            lblTitlePrice.Text = $"$ {CalculateTotalPrice( )}";
            _orderForm.setLblTotalPrice ( lblTitlePrice.Text );
        }

        private void rdoSmall_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            updatePizzaSize( );
        }

        private void rdoMedium_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            updatePizzaSize( ); 
        }

        private void rdoBig_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            updatePizzaSize( ); 
        }

        private void UpdateCrustType()
        {
            foreach (Control control in gpCrustType.Controls)
            {
                if (control is RadioButton rdoButton &&
                    rdoButton.Checked == true)
                {
                    _orderForm.setLblCrustType( rdoButton.Text );
                }
            }
            
        }

        private void rdoCrustThick_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            UpdateCrustType( );
        }

        private void rdoCrustThin_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            UpdateCrustType( );
        }

        private List<string>   GetToppings()
        {
            List<string> strings = new List<string>( );
            foreach (Control control in gpToppings.Controls)
            {
                if (control is CheckBox checkBox &&
                    checkBox.Checked == true)
                {
                    strings.Add( checkBox.Text );
                }
            }
            return ( strings ) ;
        }

        private void UpdateToppings()
        {
            List<string> toppings = GetToppings( );
            string toppingsString = string.Join( ", ", toppings );
            _orderForm.setLblToppings( toppingsString );
           
        }


        private void chkExtraCheese_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            UpdateToppings( );
        }

        private void chkMushrooms_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            UpdateToppings( ); 
        }

        private void chkTomatoes_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            UpdateToppings( ); 
        }

        private void chkOnion_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            UpdateToppings( ); 
        }

        private void chkOlives_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            UpdateToppings( ); 
        }

        private void chkGreenPeppers_CheckedChanged( object sender, EventArgs e )
        {
            updateTotalPrice( );
            UpdateToppings( ); 
        }

        private void UpdateEatPlace()
        {
            foreach (Control ctrl in gpWhereToEat.Controls)
            {
                if (ctrl is RadioButton rdoButton
                    && rdoButton.Checked)
                {
                    _orderForm.setLblWhereToEat( rdoButton.Text );
                    return;
                }
            }
        }

        private void rdoEatIn_CheckedChanged( object sender, EventArgs e )
        {
            UpdateEatPlace( ); 
        }

        private void rdoEatOut_CheckedChanged( object sender, EventArgs e )
        {
            UpdateEatPlace( ); 
        }

        public void SetControlsMainEnableStatus(bool status = false)
        {
            gpCrustType.Enabled = status;
            gpSizes.Enabled = status;
            gpToppings.Enabled = status;
            gpWhereToEat.Enabled = status;
            btnOrderPizza.Enabled = status ;
            barCountOfPizzas.Enabled = status;
        }

        private void ResetControlsRecursively(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                
                if (control.HasChildren)
                {
                    ResetControlsRecursively(control);
                }
            }
        }

        public void resetFormMain()
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reset the form? This will clear all order information.",
                "Confirm Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                // Clear all checkboxes and radio buttons throughout the entire form
                ResetControlsRecursively(this);
                
                // Re-enable all controls when Reset is clicked
                _orderForm?.enableControls();
                
                // Clear the order summary
                _orderForm?.ClearOrderSummary(); 
                lblTitlePrice.Text = "$ 0.00";
                
                // Set controls enabled
                SetControlsMainEnableStatus(true);
                
                // Set defaults after clearing everything
                initializePizzaDefaults();
            }
        }

        private void btnResetForm_Click( object sender, EventArgs e )
        {
            resetFormMain( );
        }

        private void barCountOfPizzas_Scroll( object sender, ScrollEventArgs e )
        {
            updateTotalPrice( );
            lblPizzasCount.Text = barCountOfPizzas.Value.ToString();
        }
    }
}
