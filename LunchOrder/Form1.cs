namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

    //Keeley OBrien   
        private void ClearAddOns()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
        private void ClearTotals()
        {
            txtOrderTotal.Text = string.Empty;
            txtSalesTax.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
        }

    

        private void txtSalesTax_TextChanged(object sender, EventArgs e)
        {

        }


        //Keeley OBrien
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Text = "Add-on Items ($.75/each)";
                checkBox1.Text = "Lettuce, tomato, and onions";
                checkBox2.Text = "Ketchup, mustard, and mayo";
                checkBox3.Text = "French fries";
            }
            else if (radioButton2.Checked)
            {
                groupBox1.Text = "Add-on Items ($.50/each)";
                checkBox1.Text = "Pepperoni";
                checkBox2.Text = "Sausage";
                checkBox3.Text = "Olives";
            }
            else if (radioButton3.Checked)
            {
                groupBox1.Text = "Add-on Items ($.25/each)";
                checkBox1.Text = "Croutons";
                checkBox2.Text = "Bacon bits";
                checkBox3.Text = "Bread sticks";

            }

            ClearAddOns();
            ClearTotals();
        }


        //Keeley OBrien
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal mainCoursePrice = 0m;
            decimal addOnPrice = 0m;

            if (radioButton1.Checked)
            {
                mainCoursePrice = 6.95m;
                addOnPrice = 0.75m;
            }
            else if (radioButton2.Checked)
            {
                mainCoursePrice = 5.95m;
                addOnPrice = 0.50m;
            }
            else if (radioButton3.Checked)
            {
                mainCoursePrice = 4.95m;
                addOnPrice = 0.25m;
            }

            decimal addOnTotal = 0m;
            if (checkBox1.Checked) addOnTotal += addOnPrice;
            if (checkBox2.Checked) addOnTotal += addOnPrice;
            if (checkBox3.Checked) addOnTotal += addOnPrice;

            decimal subtotal = mainCoursePrice + addOnTotal;
            decimal tax = subtotal * 0.0775m;
            decimal orderTotal = subtotal + tax;

            txtSubtotal.Text = subtotal.ToString("C");
            txtSalesTax.Text = tax.ToString("C");
            txtOrderTotal.Text = orderTotal.ToString("C");
        }

        //Keeley OBrien
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
    }
}
