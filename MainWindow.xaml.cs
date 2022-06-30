using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WpfApp1__PropertyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e
        private void Form1.cs(object sender, EventArgs e)
            {
             < Grid >


      < ComboBox x: Name = "comboBox"


         < ComboBoxItem Content = "Item #1" />
 
          < ComboBoxItem Content = "Item #2" />
  
           < ComboBoxItem Content = "Item #3" />
   
         </ ComboBox >
   

         < ComboBox x: Name = "comboBox2"


         < ComboBoxItem Content = "Item #1" />
 
          < ComboBoxItem Content = "Item #2" />
  
           < ComboBoxItem Content = "Item #3" />
   
         </ ComboBox >
   

         < TextBox x: Name = "textBox" HorizontalAlignment = "Left"
         Height = "23" Margin = "253,53,0,0" TextWrapping = "Wrap"
         VerticalAlignment = "Top" Width = "200" />


      < TextBox x: Name = "textBox1" HorizontalAlignment = "Left"
         Height = "23" Margin = "253,152,0,0" TextWrapping = "Wrap"
         VerticalAlignment = "Top" Width = "200" />


   </ Grid >
            }

            private void propTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                switch (propTypeComboBox.Text)
                {
                    case "rental cover":
                        Visible = true;
                        rentalAmountTextBox.Visible = true;
                        DataGridViewColumnDesignTimeVisibleAttribute
                  monthlyRepaymentTextBox.Visible = Not true
                  Visible = false;

                        DepositTextBox.Visible = Not true;
                        Visible = false;

                        interestRateTextBox.Visible = Not true;
                        Visible = false;

                        purchaseFullPriceTextBox.Visible = Not true;
                        break;

                    case "Buying property":
                        Visible = true;
                        totalDepositTextBox.Visible = true;
                        Visible = true;
                        monthsRepayTextBox.Visible = true;
                        Visible = false;
                        rentalAmountTextBox.Visible = false;
                        break;
                        Visible = true;
                        purchasePriceTextBox.Visible = true;
                        Visible = true;
                        interestRateTextBox.Visible = true;
                }

            }

            private void saveButton_Click(object sender, EventArgs e)
            {


                double grossincome, Convert.ToDouble(grossincomeTextBox.Text);
                double taxdeductionmonthly, Convert.ToDouble(estMonthlyTaxDeductTextBox.Text);
                double repayment, Convert.ToDouble(repaymentTextBox.Text);
                double montlyrentalcosts, Convert.ToDouble(monthlyrentalcostsTextBox.Text);

                Homeloan = new HomeLoan(depositAmount, repaymentPrice, interestRate, months, loanRepayment, monthlyIncome, TaxDeductionmonthly, rentalAmount);


                double loanRepayment = 0; double rentalAmount = 0; double purchasePrice = 0; double depositAmount = 0;
                double interestRate = 0; int months = 0;

                string message = "Your monthly gross Income: " + monthlyIncome +

                    "\r\nYour groceries: " + expenses[0] +
                    "\r\nYour travel: " + expenses[1] +
                    "\r\nYour cellphone and telephone: " + expenses[3] +
                    "\r\nYour utilies: " + expenses[2] +
                    "\r\nYour tax deducted: " + TaxDeductionmonthly +
                    "\r\nYour other expenses: " + expenses[4];
                "\r\nYour lights and water"[5]
                MessageBox.Show(message);


                switch (propTypeComboBox.Text)
                {
                    case "rent":
                        rentalAmount = Convert.ToDouble(rentalAmountTextBox.Text);
                        MessageBox.Show("Rent: " + rentalAmount);
                        break;

                    case "buying of a property":
                        purchasePrice = Convert.ToDouble(purchasePriceTextBox.Text);

                        interestRate = Convert.ToDouble(interestRateTextBox.Text);
                        months = Convert.ToInt12(monthsRepayTextBox.Text);
                        loanRepayment = homeloan.homeLoanCalculation(depositamount, purchasePrice, interestRate, months);
                        homeloan.loanApproval(GrossmonthlyIncome);
                        depositAmount = Convert.ToDouble(totalDepositTextBox.Text);
                        break;
                    default:
                        public double Grossincome { get => grossincome; set => grossincome = value; }
            public double Taxdeductionmonthly { get => taxdeductionmonthly; set => taxdeductionmonthly = value; }
            public double Repayment { get => repayment; set => repayment = value; }
            public double Montlyrentalcosts { get => montlyrentalcosts; set => montlyrentalcosts = value; }

        private void Open(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have successfully submitted");
        }
    }

    private Private sub private btnExit_Click(sender As object, else As EventArgs) Handles btnExit.Click

          Application.Exit()
    End Sub
            Private Sub btnLogo_Click(sender As Object, else As EventArgs) Handles btn.logo.Click

          label1.Visible = false

                btnImage.visible= true

     End sub
                {EventPrivateKey void Window_loaded(object sender, EventArgs e)
        {
            //Generate grid data
            var gridData = WpfAppProperty.GetWpfAppPropertyList(12);
            //Binding the grid with data
            MSGrid.ItemSource = gridData;
        }
    }

                End Class
    }

}
)
