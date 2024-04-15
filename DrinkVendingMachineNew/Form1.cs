namespace DrinkVendingMachineNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            int count = 20;
            decimal zeroSales = 0m;
            colaLabel.Text = count.ToString();
            rootBeerLabel.Text = count.ToString();
            lemonLimeLabel.Text = count.ToString();
            grapeSodaLabel.Text = count.ToString();
            creamSodaLabel.Text = count.ToString();
            totalLabel.Text = zeroSales.ToString("c");
        }

        decimal sales;
        decimal total = 0m;
        int totalColaCount = 20;
        int totalRootBeerCount = 20;
        int totalLemonLimeCount = 20;
        int totalGrapeSodaCount = 20;
        int totalCreamSodaCount = 20;

        //array
        object[,] softDrink = new object[,]
                {
                    {"Cola", 1.0m, 20 },
                    {"Root Beer", 1.0m, 20 },
                    {"Lemon Lime", 1.0m, 20 },
                    { "Grape Soda", 1.50m, 20 },
                    { "Cream Soda", 1.50m, 20 },
                };



        private void drinksLeftLlabel2_Click(object sender, EventArgs e)
        {

        }

        private void colaPictureBox_Click(object sender, EventArgs e)
        {
            int count;             

            // Create a Drink instance
            Drink cola = new Drink();

            
            cola.Name = (string)softDrink[0, 0];
            cola.Cost = (decimal)softDrink[0, 1];
            cola.Amount = (int)softDrink[0, 2];

            if (totalColaCount > 0)
            {
                cola.Amount = (int)softDrink[0, 2];

                count = cola.Amount - 1;

                // Get a new count
                totalColaCount = count;

                // Change cola amount
                softDrink[0, 2] = totalColaCount;

                // Get a sales amount
                sales = cola.Cost;

                // Add the sales amount to total
                total += sales;

                // Display the drinks left  
                colaLabel.Text = totalColaCount.ToString();

                // Display the total sales
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + cola.Name + " is sold out.");
            } 
        }

        private void rootBeerPictureBox_Click(object sender, EventArgs e)
        {
            int count;             

            
            Drink rootBeer = new Drink();

          
            rootBeer.Name = (string)softDrink[1, 0];
            rootBeer.Cost = (decimal)softDrink[1, 1];
            rootBeer.Amount = (int)softDrink[1, 2];

            if (totalRootBeerCount > 0)
            {
                rootBeer.Amount = (int)softDrink[1, 2];

                count = rootBeer.Amount - 1;

           
                totalRootBeerCount = count;

                softDrink[1, 2] = totalRootBeerCount;

                sales = rootBeer.Cost;

           
                total += sales;

           
                rootBeerLabel.Text = totalRootBeerCount.ToString();

             
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + rootBeer.Name + " is sold out.");
            } 

        }

        private void lemonLimePictureBox_Click(object sender, EventArgs e)
        {
            int count;             

            Drink lemonLime = new Drink();

            lemonLime.Name = (string)softDrink[2, 0];
            lemonLime.Cost = (decimal)softDrink[2, 1];
            lemonLime.Amount = (int)softDrink[2, 2];

            if (totalLemonLimeCount > 0)
            {
                lemonLime.Amount = (int)softDrink[2, 2];

                count = lemonLime.Amount - 1;

                
                totalLemonLimeCount = count;

               
                softDrink[2, 2] = totalLemonLimeCount;

                
                sales = lemonLime.Cost;

                
                total += sales;

                  
                lemonLimeLabel.Text = totalLemonLimeCount.ToString();

                
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + lemonLime.Name + " is sold out.");
            }
        }

        private void grapeSodaPictureBox_Click(object sender, EventArgs e)
        {
            int count;              

           
            Drink grapeSoda = new Drink();

            
            grapeSoda.Name = (string)softDrink[3, 0];
            grapeSoda.Cost = (decimal)softDrink[3, 1];
            grapeSoda.Amount = (int)softDrink[3, 2];

            if (totalGrapeSodaCount > 0)
            {
                grapeSoda.Amount = (int)softDrink[3, 2];

                count = grapeSoda.Amount - 1;

               
                totalGrapeSodaCount = count;

                
                softDrink[3, 2] = totalGrapeSodaCount;

                
                sales = grapeSoda.Cost;

                
                total += sales;

                  
                grapeSodaLabel.Text = totalGrapeSodaCount.ToString();

                
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + grapeSoda.Name + " is sold out.");
            }  
        }

        private void creamSodaPictureBox_Click(object sender, EventArgs e)
        {
            int count;              

           
            Drink creamSoda = new Drink();

            
            creamSoda.Name = (string)softDrink[4, 0];
            creamSoda.Cost = (decimal)softDrink[4, 1];
            creamSoda.Amount = (int)softDrink[4, 2];

            if (totalCreamSodaCount > 0)
            {
                creamSoda.Amount = (int)softDrink[4, 2];

                count = creamSoda.Amount - 1;

                
                totalCreamSodaCount = count;

                softDrink[4, 2] = totalCreamSodaCount;

                
                sales = creamSoda.Cost;

                
                total += sales;

                
                creamSodaLabel.Text = totalCreamSodaCount.ToString();

                
                totalLabel.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Sorry, " + creamSoda.Name + " is sold out.");
            } 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drinksLeftLlabel_Click(object sender, EventArgs e)
        {

        }

        private void colaPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

