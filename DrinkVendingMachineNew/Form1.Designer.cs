namespace DrinkVendingMachineNew
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            colaPanel = new Panel();
            colaPictureBox = new PictureBox();
            costLabel = new Label();
            colaLabel = new Label();
            drinksLeftLlabel = new Label();
            totalLabel = new Label();
            selectLabel = new Label();
            drinksLeftLlabel2 = new Label();
            rootBeerLabel = new Label();
            costLabel2 = new Label();
            rootBeerPanel = new Panel();
            rootBeerPictureBox = new PictureBox();
            lemonLimePanel = new Panel();
            costLabel3 = new Label();
            lemonLimePictureBox = new PictureBox();
            lemonLimeLabel = new Label();
            drinksLeftLlabel3 = new Label();
            grapeSodaPanel = new Panel();
            costLabel4 = new Label();
            grapeSodaPictureBox = new PictureBox();
            grapeSodaLabel = new Label();
            label1drinksLeftLlabel4 = new Label();
            creamSodaPanel = new Panel();
            costLabel5 = new Label();
            creamSodaPictureBox = new PictureBox();
            creamSodaLabel = new Label();
            drinksLeftLlabel5 = new Label();
            panel5 = new Panel();
            totalSalesLabel = new Label();
            exitButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            colaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)colaPictureBox).BeginInit();
            rootBeerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rootBeerPictureBox).BeginInit();
            lemonLimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lemonLimePictureBox).BeginInit();
            grapeSodaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grapeSodaPictureBox).BeginInit();
            creamSodaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)creamSodaPictureBox).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // colaPanel
            // 
            colaPanel.BorderStyle = BorderStyle.Fixed3D;
            colaPanel.Controls.Add(label1);
            colaPanel.Controls.Add(colaPictureBox);
            colaPanel.Controls.Add(costLabel);
            colaPanel.Controls.Add(colaLabel);
            colaPanel.Location = new Point(12, 23);
            colaPanel.Name = "colaPanel";
            colaPanel.Size = new Size(191, 100);
            colaPanel.TabIndex = 0;
            colaPanel.Paint += colaPanel_Paint;
            // 
            // colaPictureBox
            // 
            colaPictureBox.BorderStyle = BorderStyle.Fixed3D;
            colaPictureBox.Image = Properties.Resources.Screenshot_2024_04_13_115041;
            colaPictureBox.Location = new Point(0, 0);
            colaPictureBox.Name = "colaPictureBox";
            colaPictureBox.Size = new Size(100, 100);
            colaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            colaPictureBox.TabIndex = 2;
            colaPictureBox.TabStop = false;
            colaPictureBox.Click += colaPictureBox_Click;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costLabel.Location = new Point(112, 1);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(38, 15);
            costLabel.TabIndex = 4;
            costLabel.Text = "$1.00";
            // 
            // colaLabel
            // 
            colaLabel.BorderStyle = BorderStyle.Fixed3D;
            colaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            colaLabel.Location = new Point(107, 50);
            colaLabel.Name = "colaLabel";
            colaLabel.Size = new Size(68, 28);
            colaLabel.TabIndex = 1;
            colaLabel.Text = "20";
            colaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLlabel
            // 
            drinksLeftLlabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            drinksLeftLlabel.Location = new Point(112, 1);
            drinksLeftLlabel.Name = "drinksLeftLlabel";
            drinksLeftLlabel.Size = new Size(68, 23);
            drinksLeftLlabel.TabIndex = 5;
            drinksLeftLlabel.Text = "Cola:";
            drinksLeftLlabel.TextAlign = ContentAlignment.MiddleCenter;
            drinksLeftLlabel.Click += drinksLeftLlabel_Click;
            // 
            // totalLabel
            // 
            totalLabel.BorderStyle = BorderStyle.Fixed3D;
            totalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(54, 37);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(100, 23);
            totalLabel.TabIndex = 2;
            totalLabel.Text = "$0.00";
            totalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Location = new Point(112, 482);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(269, 15);
            selectLabel.TabIndex = 3;
            selectLabel.Text = "Select a flavor of soda from the vending machine!";
            // 
            // drinksLeftLlabel2
            // 
            drinksLeftLlabel2.BackColor = SystemColors.Control;
            drinksLeftLlabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            drinksLeftLlabel2.Location = new Point(112, 152);
            drinksLeftLlabel2.Name = "drinksLeftLlabel2";
            drinksLeftLlabel2.Size = new Size(100, 23);
            drinksLeftLlabel2.TabIndex = 5;
            drinksLeftLlabel2.Text = "Root beer:";
            drinksLeftLlabel2.TextAlign = ContentAlignment.MiddleCenter;
            drinksLeftLlabel2.Click += drinksLeftLlabel2_Click;
            // 
            // rootBeerLabel
            // 
            rootBeerLabel.BorderStyle = BorderStyle.Fixed3D;
            rootBeerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rootBeerLabel.Location = new Point(119, 50);
            rootBeerLabel.Name = "rootBeerLabel";
            rootBeerLabel.Size = new Size(61, 29);
            rootBeerLabel.TabIndex = 6;
            rootBeerLabel.Text = "20";
            rootBeerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // costLabel2
            // 
            costLabel2.AutoSize = true;
            costLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costLabel2.Location = new Point(128, 9);
            costLabel2.Name = "costLabel2";
            costLabel2.Size = new Size(38, 15);
            costLabel2.TabIndex = 7;
            costLabel2.Text = "$1.00";
            // 
            // rootBeerPanel
            // 
            rootBeerPanel.BorderStyle = BorderStyle.Fixed3D;
            rootBeerPanel.Controls.Add(label3);
            rootBeerPanel.Controls.Add(rootBeerPictureBox);
            rootBeerPanel.Controls.Add(costLabel2);
            rootBeerPanel.Controls.Add(rootBeerLabel);
            rootBeerPanel.Location = new Point(12, 176);
            rootBeerPanel.Name = "rootBeerPanel";
            rootBeerPanel.Size = new Size(200, 100);
            rootBeerPanel.TabIndex = 8;
            // 
            // rootBeerPictureBox
            // 
            rootBeerPictureBox.BorderStyle = BorderStyle.Fixed3D;
            rootBeerPictureBox.Image = Properties.Resources.Screenshot_2024_04_13_1150461;
            rootBeerPictureBox.Location = new Point(0, 0);
            rootBeerPictureBox.Name = "rootBeerPictureBox";
            rootBeerPictureBox.Size = new Size(100, 97);
            rootBeerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rootBeerPictureBox.TabIndex = 0;
            rootBeerPictureBox.TabStop = false;
            rootBeerPictureBox.Click += rootBeerPictureBox_Click;
            // 
            // lemonLimePanel
            // 
            lemonLimePanel.BorderStyle = BorderStyle.Fixed3D;
            lemonLimePanel.Controls.Add(label5);
            lemonLimePanel.Controls.Add(costLabel3);
            lemonLimePanel.Controls.Add(lemonLimePictureBox);
            lemonLimePanel.Controls.Add(lemonLimeLabel);
            lemonLimePanel.Location = new Point(19, 359);
            lemonLimePanel.Name = "lemonLimePanel";
            lemonLimePanel.Size = new Size(200, 100);
            lemonLimePanel.TabIndex = 6;
            // 
            // costLabel3
            // 
            costLabel3.AutoSize = true;
            costLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costLabel3.Location = new Point(130, 8);
            costLabel3.Name = "costLabel3";
            costLabel3.Size = new Size(38, 15);
            costLabel3.TabIndex = 11;
            costLabel3.Text = "$1.00";
            // 
            // lemonLimePictureBox
            // 
            lemonLimePictureBox.BorderStyle = BorderStyle.Fixed3D;
            lemonLimePictureBox.Image = Properties.Resources.Screenshot_2024_04_13_115050;
            lemonLimePictureBox.Location = new Point(0, 0);
            lemonLimePictureBox.Name = "lemonLimePictureBox";
            lemonLimePictureBox.Size = new Size(100, 100);
            lemonLimePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            lemonLimePictureBox.TabIndex = 10;
            lemonLimePictureBox.TabStop = false;
            lemonLimePictureBox.Click += lemonLimePictureBox_Click;
            // 
            // lemonLimeLabel
            // 
            lemonLimeLabel.BorderStyle = BorderStyle.Fixed3D;
            lemonLimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lemonLimeLabel.Location = new Point(107, 56);
            lemonLimeLabel.Name = "lemonLimeLabel";
            lemonLimeLabel.Size = new Size(76, 27);
            lemonLimeLabel.TabIndex = 9;
            lemonLimeLabel.Text = "20";
            lemonLimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLlabel3
            // 
            drinksLeftLlabel3.BorderStyle = BorderStyle.Fixed3D;
            drinksLeftLlabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            drinksLeftLlabel3.Location = new Point(119, 335);
            drinksLeftLlabel3.Name = "drinksLeftLlabel3";
            drinksLeftLlabel3.Size = new Size(100, 23);
            drinksLeftLlabel3.TabIndex = 9;
            drinksLeftLlabel3.Text = "Lemon Lime:";
            drinksLeftLlabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grapeSodaPanel
            // 
            grapeSodaPanel.BorderStyle = BorderStyle.Fixed3D;
            grapeSodaPanel.Controls.Add(label2);
            grapeSodaPanel.Controls.Add(costLabel4);
            grapeSodaPanel.Controls.Add(grapeSodaPictureBox);
            grapeSodaPanel.Controls.Add(grapeSodaLabel);
            grapeSodaPanel.Location = new Point(242, 23);
            grapeSodaPanel.Name = "grapeSodaPanel";
            grapeSodaPanel.Size = new Size(200, 100);
            grapeSodaPanel.TabIndex = 12;
            // 
            // costLabel4
            // 
            costLabel4.AutoSize = true;
            costLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costLabel4.Location = new Point(128, 1);
            costLabel4.Name = "costLabel4";
            costLabel4.Size = new Size(38, 15);
            costLabel4.TabIndex = 2;
            costLabel4.Text = "$1.50";
            // 
            // grapeSodaPictureBox
            // 
            grapeSodaPictureBox.BorderStyle = BorderStyle.Fixed3D;
            grapeSodaPictureBox.Image = Properties.Resources.Screenshot_2024_04_13_115054;
            grapeSodaPictureBox.Location = new Point(0, 0);
            grapeSodaPictureBox.Name = "grapeSodaPictureBox";
            grapeSodaPictureBox.Size = new Size(100, 100);
            grapeSodaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            grapeSodaPictureBox.TabIndex = 1;
            grapeSodaPictureBox.TabStop = false;
            grapeSodaPictureBox.Click += grapeSodaPictureBox_Click;
            // 
            // grapeSodaLabel
            // 
            grapeSodaLabel.BorderStyle = BorderStyle.Fixed3D;
            grapeSodaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grapeSodaLabel.Location = new Point(116, 50);
            grapeSodaLabel.Name = "grapeSodaLabel";
            grapeSodaLabel.Size = new Size(67, 28);
            grapeSodaLabel.TabIndex = 13;
            grapeSodaLabel.Text = "20";
            grapeSodaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1drinksLeftLlabel4
            // 
            label1drinksLeftLlabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1drinksLeftLlabel4.Location = new Point(339, 1);
            label1drinksLeftLlabel4.Name = "label1drinksLeftLlabel4";
            label1drinksLeftLlabel4.Size = new Size(100, 23);
            label1drinksLeftLlabel4.TabIndex = 0;
            label1drinksLeftLlabel4.Text = "Grape Soda:";
            label1drinksLeftLlabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // creamSodaPanel
            // 
            creamSodaPanel.BorderStyle = BorderStyle.Fixed3D;
            creamSodaPanel.Controls.Add(label4);
            creamSodaPanel.Controls.Add(costLabel5);
            creamSodaPanel.Controls.Add(creamSodaPictureBox);
            creamSodaPanel.Controls.Add(creamSodaLabel);
            creamSodaPanel.Location = new Point(239, 176);
            creamSodaPanel.Name = "creamSodaPanel";
            creamSodaPanel.Size = new Size(200, 100);
            creamSodaPanel.TabIndex = 14;
            // 
            // costLabel5
            // 
            costLabel5.AutoSize = true;
            costLabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costLabel5.Location = new Point(131, 9);
            costLabel5.Name = "costLabel5";
            costLabel5.Size = new Size(38, 15);
            costLabel5.TabIndex = 16;
            costLabel5.Text = "$1.50";
            // 
            // creamSodaPictureBox
            // 
            creamSodaPictureBox.BorderStyle = BorderStyle.Fixed3D;
            creamSodaPictureBox.Image = Properties.Resources.Screenshot_2024_04_13_115058;
            creamSodaPictureBox.Location = new Point(-2, -2);
            creamSodaPictureBox.Name = "creamSodaPictureBox";
            creamSodaPictureBox.Size = new Size(92, 99);
            creamSodaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            creamSodaPictureBox.TabIndex = 1;
            creamSodaPictureBox.TabStop = false;
            creamSodaPictureBox.Click += creamSodaPictureBox_Click;
            // 
            // creamSodaLabel
            // 
            creamSodaLabel.BorderStyle = BorderStyle.Fixed3D;
            creamSodaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            creamSodaLabel.Location = new Point(115, 50);
            creamSodaLabel.Name = "creamSodaLabel";
            creamSodaLabel.Size = new Size(71, 29);
            creamSodaLabel.TabIndex = 15;
            creamSodaLabel.Text = "20";
            creamSodaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLlabel5
            // 
            drinksLeftLlabel5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            drinksLeftLlabel5.Location = new Point(339, 152);
            drinksLeftLlabel5.Name = "drinksLeftLlabel5";
            drinksLeftLlabel5.Size = new Size(100, 23);
            drinksLeftLlabel5.TabIndex = 0;
            drinksLeftLlabel5.Text = "Cream Soda:";
            drinksLeftLlabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(totalSalesLabel);
            panel5.Controls.Add(totalLabel);
            panel5.Location = new Point(239, 361);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 16;
            // 
            // totalSalesLabel
            // 
            totalSalesLabel.AutoSize = true;
            totalSalesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalSalesLabel.Location = new Point(76, 6);
            totalSalesLabel.Name = "totalSalesLabel";
            totalSalesLabel.Size = new Size(65, 15);
            totalSalesLabel.TabIndex = 0;
            totalSalesLabel.Text = "Total Sales";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(178, 539);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 46);
            exitButton.TabIndex = 17;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 23);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 18;
            label1.Text = "Drinks Left:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 23);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 19;
            label2.Text = "Drinks Left:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 24);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 12;
            label3.Text = "Drinks Left:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 24);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 13;
            label4.Text = "Drinks Left:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 39);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 12;
            label5.Text = "Drinks Left:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 597);
            Controls.Add(drinksLeftLlabel);
            Controls.Add(drinksLeftLlabel2);
            Controls.Add(drinksLeftLlabel3);
            Controls.Add(drinksLeftLlabel5);
            Controls.Add(exitButton);
            Controls.Add(label1drinksLeftLlabel4);
            Controls.Add(panel5);
            Controls.Add(creamSodaPanel);
            Controls.Add(grapeSodaPanel);
            Controls.Add(lemonLimePanel);
            Controls.Add(rootBeerPanel);
            Controls.Add(selectLabel);
            Controls.Add(colaPanel);
            Name = "Form1";
            Text = "Drink Vending Machine Simulator";
            colaPanel.ResumeLayout(false);
            colaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)colaPictureBox).EndInit();
            rootBeerPanel.ResumeLayout(false);
            rootBeerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rootBeerPictureBox).EndInit();
            lemonLimePanel.ResumeLayout(false);
            lemonLimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lemonLimePictureBox).EndInit();
            grapeSodaPanel.ResumeLayout(false);
            grapeSodaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grapeSodaPictureBox).EndInit();
            creamSodaPanel.ResumeLayout(false);
            creamSodaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)creamSodaPictureBox).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel colaPanel;
        private PictureBox colaPictureBox;
        private Label colaLabel;
        private Label totalLabel;
        private Label selectLabel;
        private Label costLabel;
        private Label drinksLeftLlabel;
        private Label drinksLeftLlabel2;
        private Label rootBeerLabel;
        private Label costLabel2;
        private Panel rootBeerPanel;
        private PictureBox rootBeerPictureBox;
        private Panel lemonLimePanel;
        private Label drinksLeftLlabel3;
        private Label costLabel3;
        private PictureBox lemonLimePictureBox;
        private Label lemonLimeLabel;
        private Panel grapeSodaPanel;
        private Label costLabel4;
        private PictureBox grapeSodaPictureBox;
        private Label label1drinksLeftLlabel4;
        private Label grapeSodaLabel;
        private Panel creamSodaPanel;
        private Label costLabel5;
        private PictureBox creamSodaPictureBox;
        private Label drinksLeftLlabel5;
        private Label creamSodaLabel;
        private Panel panel5;
        private Label totalSalesLabel;
        private Button exitButton;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label4;
    }
}
