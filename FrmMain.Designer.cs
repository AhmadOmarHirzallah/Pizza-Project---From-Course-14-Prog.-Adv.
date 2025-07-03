namespace PizzaProject
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCenter = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetForm = new Guna.UI2.WinForms.Guna2Button();
            this.gpOrderPrice = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblTitlePrice = new System.Windows.Forms.Label();
            this.btnOrderPizza = new Guna.UI2.WinForms.Guna2Button();
            this.gpWhereToEat = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoEatOut = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoEatIn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gpCrustType = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoCrustThick = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoCrustThin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gpToppings = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkGreenPeppers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkOlives = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkOnion = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkTomatoes = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMushrooms = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkExtraCheese = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gpSizes = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoBig = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoMedium = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdoSmall = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.barCountOfPizzas = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPizzasCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.gpOrderPrice.SuspendLayout();
            this.gpWhereToEat.SuspendLayout();
            this.gpCrustType.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpSizes.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.pnlCenter);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(1220, 1069);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCenter.BorderRadius = 12;
            this.pnlCenter.Controls.Add(this.barCountOfPizzas);
            this.pnlCenter.Controls.Add(this.label3);
            this.pnlCenter.Controls.Add(this.label4);
            this.pnlCenter.Controls.Add(this.lblPizzasCount);
            this.pnlCenter.Controls.Add(this.label2);
            this.pnlCenter.Controls.Add(this.label1);
            this.pnlCenter.Controls.Add(this.btnResetForm);
            this.pnlCenter.Controls.Add(this.gpOrderPrice);
            this.pnlCenter.Controls.Add(this.btnOrderPizza);
            this.pnlCenter.Controls.Add(this.gpWhereToEat);
            this.pnlCenter.Controls.Add(this.gpCrustType);
            this.pnlCenter.Controls.Add(this.gpToppings);
            this.pnlCenter.Controls.Add(this.gpSizes);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 125);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.ShadowDecoration.Parent = this.pnlCenter;
            this.pnlCenter.Size = new System.Drawing.Size(1220, 944);
            this.pnlCenter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 589);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pizza\'s Count:";
            // 
            // btnResetForm
            // 
            this.btnResetForm.BorderRadius = 16;
            this.btnResetForm.CheckedState.Parent = this.btnResetForm;
            this.btnResetForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetForm.CustomImages.Parent = this.btnResetForm;
            this.btnResetForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetForm.ForeColor = System.Drawing.Color.White;
            this.btnResetForm.HoverState.Parent = this.btnResetForm;
            this.btnResetForm.Location = new System.Drawing.Point(426, 815);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.ShadowDecoration.Parent = this.btnResetForm;
            this.btnResetForm.Size = new System.Drawing.Size(226, 95);
            this.btnResetForm.TabIndex = 0;
            this.btnResetForm.Text = "Reset";
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gpOrderPrice
            // 
            this.gpOrderPrice.BorderColor = System.Drawing.Color.SteelBlue;
            this.gpOrderPrice.Controls.Add(this.lblTitlePrice);
            this.gpOrderPrice.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.gpOrderPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpOrderPrice.ForeColor = System.Drawing.Color.Black;
            this.gpOrderPrice.Location = new System.Drawing.Point(723, 715);
            this.gpOrderPrice.Name = "gpOrderPrice";
            this.gpOrderPrice.ShadowDecoration.Parent = this.gpOrderPrice;
            this.gpOrderPrice.Size = new System.Drawing.Size(333, 195);
            this.gpOrderPrice.TabIndex = 6;
            this.gpOrderPrice.Text = "Order Price";
            // 
            // lblTitlePrice
            // 
            this.lblTitlePrice.AutoSize = true;
            this.lblTitlePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTitlePrice.Location = new System.Drawing.Point(22, 105);
            this.lblTitlePrice.Name = "lblTitlePrice";
            this.lblTitlePrice.Size = new System.Drawing.Size(48, 30);
            this.lblTitlePrice.TabIndex = 3;
            this.lblTitlePrice.Text = "$ 0";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BorderRadius = 16;
            this.btnOrderPizza.CheckedState.Parent = this.btnOrderPizza;
            this.btnOrderPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderPizza.CustomImages.Parent = this.btnOrderPizza;
            this.btnOrderPizza.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOrderPizza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrderPizza.ForeColor = System.Drawing.Color.Black;
            this.btnOrderPizza.HoverState.Parent = this.btnOrderPizza;
            this.btnOrderPizza.Location = new System.Drawing.Point(62, 788);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.ShadowDecoration.Parent = this.btnOrderPizza;
            this.btnOrderPizza.Size = new System.Drawing.Size(304, 123);
            this.btnOrderPizza.TabIndex = 0;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // gpWhereToEat
            // 
            this.gpWhereToEat.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpWhereToEat.Controls.Add(this.rdoEatOut);
            this.gpWhereToEat.Controls.Add(this.rdoEatIn);
            this.gpWhereToEat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpWhereToEat.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.gpWhereToEat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpWhereToEat.ForeColor = System.Drawing.Color.Black;
            this.gpWhereToEat.Location = new System.Drawing.Point(512, 378);
            this.gpWhereToEat.Name = "gpWhereToEat";
            this.gpWhereToEat.ShadowDecoration.Parent = this.gpWhereToEat;
            this.gpWhereToEat.Size = new System.Drawing.Size(562, 148);
            this.gpWhereToEat.TabIndex = 2;
            this.gpWhereToEat.Text = "Where To Eat";
            // 
            // rdoEatOut
            // 
            this.rdoEatOut.AutoSize = true;
            this.rdoEatOut.BackColor = System.Drawing.Color.Transparent;
            this.rdoEatOut.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoEatOut.CheckedState.BorderThickness = 0;
            this.rdoEatOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoEatOut.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoEatOut.CheckedState.InnerOffset = -4;
            this.rdoEatOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEatOut.Location = new System.Drawing.Point(348, 78);
            this.rdoEatOut.Name = "rdoEatOut";
            this.rdoEatOut.Size = new System.Drawing.Size(106, 29);
            this.rdoEatOut.TabIndex = 0;
            this.rdoEatOut.TabStop = true;
            this.rdoEatOut.Tag = "0";
            this.rdoEatOut.Text = "Take Out";
            this.rdoEatOut.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoEatOut.UncheckedState.BorderThickness = 2;
            this.rdoEatOut.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoEatOut.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoEatOut.UseVisualStyleBackColor = false;
            this.rdoEatOut.CheckedChanged += new System.EventHandler(this.rdoEatOut_CheckedChanged);
            // 
            // rdoEatIn
            // 
            this.rdoEatIn.AutoSize = true;
            this.rdoEatIn.BackColor = System.Drawing.Color.Transparent;
            this.rdoEatIn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoEatIn.CheckedState.BorderThickness = 0;
            this.rdoEatIn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoEatIn.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoEatIn.CheckedState.InnerOffset = -4;
            this.rdoEatIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoEatIn.Location = new System.Drawing.Point(44, 78);
            this.rdoEatIn.Name = "rdoEatIn";
            this.rdoEatIn.Size = new System.Drawing.Size(81, 29);
            this.rdoEatIn.TabIndex = 0;
            this.rdoEatIn.TabStop = true;
            this.rdoEatIn.Tag = "0";
            this.rdoEatIn.Text = "Eat In";
            this.rdoEatIn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoEatIn.UncheckedState.BorderThickness = 2;
            this.rdoEatIn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoEatIn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoEatIn.UseVisualStyleBackColor = false;
            this.rdoEatIn.CheckedChanged += new System.EventHandler(this.rdoEatIn_CheckedChanged);
            // 
            // gpCrustType
            // 
            this.gpCrustType.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpCrustType.Controls.Add(this.rdoCrustThick);
            this.gpCrustType.Controls.Add(this.rdoCrustThin);
            this.gpCrustType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpCrustType.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.gpCrustType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpCrustType.ForeColor = System.Drawing.Color.Black;
            this.gpCrustType.Location = new System.Drawing.Point(62, 378);
            this.gpCrustType.Name = "gpCrustType";
            this.gpCrustType.ShadowDecoration.Parent = this.gpCrustType;
            this.gpCrustType.Size = new System.Drawing.Size(242, 231);
            this.gpCrustType.TabIndex = 2;
            this.gpCrustType.Text = "Curst Type";
            // 
            // rdoCrustThick
            // 
            this.rdoCrustThick.AutoSize = true;
            this.rdoCrustThick.BackColor = System.Drawing.Color.Transparent;
            this.rdoCrustThick.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoCrustThick.CheckedState.BorderThickness = 0;
            this.rdoCrustThick.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoCrustThick.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoCrustThick.CheckedState.InnerOffset = -4;
            this.rdoCrustThick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoCrustThick.Location = new System.Drawing.Point(44, 165);
            this.rdoCrustThick.Name = "rdoCrustThick";
            this.rdoCrustThick.Size = new System.Drawing.Size(77, 29);
            this.rdoCrustThick.TabIndex = 0;
            this.rdoCrustThick.TabStop = true;
            this.rdoCrustThick.Tag = "5";
            this.rdoCrustThick.Text = "Thick";
            this.rdoCrustThick.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoCrustThick.UncheckedState.BorderThickness = 2;
            this.rdoCrustThick.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoCrustThick.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoCrustThick.UseVisualStyleBackColor = false;
            this.rdoCrustThick.CheckedChanged += new System.EventHandler(this.rdoCrustThick_CheckedChanged);
            // 
            // rdoCrustThin
            // 
            this.rdoCrustThin.AutoSize = true;
            this.rdoCrustThin.BackColor = System.Drawing.Color.Transparent;
            this.rdoCrustThin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoCrustThin.CheckedState.BorderThickness = 0;
            this.rdoCrustThin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoCrustThin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoCrustThin.CheckedState.InnerOffset = -4;
            this.rdoCrustThin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoCrustThin.Location = new System.Drawing.Point(44, 86);
            this.rdoCrustThin.Name = "rdoCrustThin";
            this.rdoCrustThin.Size = new System.Drawing.Size(70, 29);
            this.rdoCrustThin.TabIndex = 0;
            this.rdoCrustThin.TabStop = true;
            this.rdoCrustThin.Tag = "0";
            this.rdoCrustThin.Text = "Thin";
            this.rdoCrustThin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoCrustThin.UncheckedState.BorderThickness = 2;
            this.rdoCrustThin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoCrustThin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoCrustThin.UseVisualStyleBackColor = false;
            this.rdoCrustThin.CheckedChanged += new System.EventHandler(this.rdoCrustThin_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpToppings.Controls.Add(this.chkGreenPeppers);
            this.gpToppings.Controls.Add(this.chkOlives);
            this.gpToppings.Controls.Add(this.chkOnion);
            this.gpToppings.Controls.Add(this.chkTomatoes);
            this.gpToppings.Controls.Add(this.chkMushrooms);
            this.gpToppings.Controls.Add(this.chkExtraCheese);
            this.gpToppings.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.gpToppings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpToppings.ForeColor = System.Drawing.Color.Black;
            this.gpToppings.Location = new System.Drawing.Point(512, 32);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.ShadowDecoration.Parent = this.gpToppings;
            this.gpToppings.Size = new System.Drawing.Size(562, 289);
            this.gpToppings.TabIndex = 1;
            this.gpToppings.Text = "Size";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.BackColor = System.Drawing.Color.Transparent;
            this.chkGreenPeppers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkGreenPeppers.CheckedState.BorderRadius = 2;
            this.chkGreenPeppers.CheckedState.BorderThickness = 0;
            this.chkGreenPeppers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkGreenPeppers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkGreenPeppers.Location = new System.Drawing.Point(324, 225);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(152, 29);
            this.chkGreenPeppers.TabIndex = 0;
            this.chkGreenPeppers.Tag = "0.7";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkGreenPeppers.UncheckedState.BorderRadius = 2;
            this.chkGreenPeppers.UncheckedState.BorderThickness = 0;
            this.chkGreenPeppers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkGreenPeppers.UseVisualStyleBackColor = false;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.BackColor = System.Drawing.Color.Transparent;
            this.chkOlives.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkOlives.CheckedState.BorderRadius = 2;
            this.chkOlives.CheckedState.BorderThickness = 0;
            this.chkOlives.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkOlives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOlives.Location = new System.Drawing.Point(324, 155);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(86, 29);
            this.chkOlives.TabIndex = 0;
            this.chkOlives.Tag = "0.7";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkOlives.UncheckedState.BorderRadius = 2;
            this.chkOlives.UncheckedState.BorderThickness = 0;
            this.chkOlives.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkOlives.UseVisualStyleBackColor = false;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.BackColor = System.Drawing.Color.Transparent;
            this.chkOnion.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkOnion.CheckedState.BorderRadius = 2;
            this.chkOnion.CheckedState.BorderThickness = 0;
            this.chkOnion.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkOnion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOnion.Location = new System.Drawing.Point(324, 80);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(87, 29);
            this.chkOnion.TabIndex = 0;
            this.chkOnion.Tag = "0.8";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkOnion.UncheckedState.BorderRadius = 2;
            this.chkOnion.UncheckedState.BorderThickness = 0;
            this.chkOnion.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkOnion.UseVisualStyleBackColor = false;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.BackColor = System.Drawing.Color.Transparent;
            this.chkTomatoes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkTomatoes.CheckedState.BorderRadius = 2;
            this.chkTomatoes.CheckedState.BorderThickness = 0;
            this.chkTomatoes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkTomatoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkTomatoes.Location = new System.Drawing.Point(34, 225);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(115, 29);
            this.chkTomatoes.TabIndex = 0;
            this.chkTomatoes.Tag = "0.5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTomatoes.UncheckedState.BorderRadius = 2;
            this.chkTomatoes.UncheckedState.BorderThickness = 0;
            this.chkTomatoes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTomatoes.UseVisualStyleBackColor = false;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.BackColor = System.Drawing.Color.Transparent;
            this.chkMushrooms.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMushrooms.CheckedState.BorderRadius = 2;
            this.chkMushrooms.CheckedState.BorderThickness = 0;
            this.chkMushrooms.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMushrooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMushrooms.Location = new System.Drawing.Point(34, 155);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(134, 29);
            this.chkMushrooms.TabIndex = 0;
            this.chkMushrooms.Tag = "2";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMushrooms.UncheckedState.BorderRadius = 2;
            this.chkMushrooms.UncheckedState.BorderThickness = 0;
            this.chkMushrooms.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMushrooms.UseVisualStyleBackColor = false;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.BackColor = System.Drawing.Color.Transparent;
            this.chkExtraCheese.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkExtraCheese.CheckedState.BorderRadius = 2;
            this.chkExtraCheese.CheckedState.BorderThickness = 0;
            this.chkExtraCheese.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkExtraCheese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkExtraCheese.Location = new System.Drawing.Point(34, 80);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(137, 29);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "1.5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkExtraCheese.UncheckedState.BorderRadius = 2;
            this.chkExtraCheese.UncheckedState.BorderThickness = 0;
            this.chkExtraCheese.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkExtraCheese.UseVisualStyleBackColor = false;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gpSizes
            // 
            this.gpSizes.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gpSizes.Controls.Add(this.rdoBig);
            this.gpSizes.Controls.Add(this.rdoMedium);
            this.gpSizes.Controls.Add(this.rdoSmall);
            this.gpSizes.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.gpSizes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpSizes.ForeColor = System.Drawing.Color.Black;
            this.gpSizes.Location = new System.Drawing.Point(62, 32);
            this.gpSizes.Name = "gpSizes";
            this.gpSizes.ShadowDecoration.Parent = this.gpSizes;
            this.gpSizes.Size = new System.Drawing.Size(242, 289);
            this.gpSizes.TabIndex = 1;
            this.gpSizes.Text = "Size";
            // 
            // rdoBig
            // 
            this.rdoBig.AutoSize = true;
            this.rdoBig.BackColor = System.Drawing.Color.Transparent;
            this.rdoBig.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoBig.CheckedState.BorderThickness = 0;
            this.rdoBig.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoBig.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoBig.CheckedState.InnerOffset = -4;
            this.rdoBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rdoBig.Location = new System.Drawing.Point(39, 218);
            this.rdoBig.Name = "rdoBig";
            this.rdoBig.Size = new System.Drawing.Size(75, 34);
            this.rdoBig.TabIndex = 0;
            this.rdoBig.TabStop = true;
            this.rdoBig.Tag = "15";
            this.rdoBig.Text = "Big";
            this.rdoBig.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoBig.UncheckedState.BorderThickness = 2;
            this.rdoBig.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoBig.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoBig.UseVisualStyleBackColor = false;
            this.rdoBig.CheckedChanged += new System.EventHandler(this.rdoBig_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.BackColor = System.Drawing.Color.Transparent;
            this.rdoMedium.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMedium.CheckedState.BorderThickness = 0;
            this.rdoMedium.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoMedium.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoMedium.CheckedState.InnerOffset = -4;
            this.rdoMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rdoMedium.Location = new System.Drawing.Point(39, 155);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(130, 34);
            this.rdoMedium.TabIndex = 0;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Tag = "10";
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoMedium.UncheckedState.BorderThickness = 2;
            this.rdoMedium.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoMedium.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoMedium.UseVisualStyleBackColor = false;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoMedium_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.BackColor = System.Drawing.Color.Transparent;
            this.rdoSmall.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSmall.CheckedState.BorderThickness = 0;
            this.rdoSmall.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdoSmall.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdoSmall.CheckedState.InnerOffset = -4;
            this.rdoSmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rdoSmall.Location = new System.Drawing.Point(39, 91);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(103, 34);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Tag = "5";
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdoSmall.UncheckedState.BorderThickness = 2;
            this.rdoSmall.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdoSmall.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdoSmall.UseVisualStyleBackColor = false;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTop.BorderRadius = 12;
            this.pnlTop.Controls.Add(this.guna2Panel1);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.ShadowDecoration.Parent = this.pnlTop;
            this.pnlTop.Size = new System.Drawing.Size(1220, 125);
            this.pnlTop.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = global::PizzaProject.Resource1.PizzaImg;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(806, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(414, 125);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(232, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(330, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pizza Resturant";
            // 
            // barCountOfPizzas
            // 
            this.barCountOfPizzas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.barCountOfPizzas.HoverState.Parent = this.barCountOfPizzas;
            this.barCountOfPizzas.Location = new System.Drawing.Point(556, 636);
            this.barCountOfPizzas.Maximum = 50;
            this.barCountOfPizzas.Minimum = 1;
            this.barCountOfPizzas.Name = "barCountOfPizzas";
            this.barCountOfPizzas.Size = new System.Drawing.Size(377, 39);
            this.barCountOfPizzas.TabIndex = 11;
            this.barCountOfPizzas.ThumbColor = System.Drawing.Color.SteelBlue;
            this.barCountOfPizzas.Value = 1;
            this.barCountOfPizzas.Scroll += new System.Windows.Forms.ScrollEventHandler(this.barCountOfPizzas_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(960, 655);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(508, 655);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "1";
            // 
            // lblPizzasCount
            // 
            this.lblPizzasCount.AutoSize = true;
            this.lblPizzasCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPizzasCount.Location = new System.Drawing.Point(731, 589);
            this.lblPizzasCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPizzasCount.Name = "lblPizzasCount";
            this.lblPizzasCount.Size = new System.Drawing.Size(18, 20);
            this.lblPizzasCount.TabIndex = 8;
            this.lblPizzasCount.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(773, 589);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pizza/s";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 1069);
            this.Controls.Add(this.pnlMain);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.gpOrderPrice.ResumeLayout(false);
            this.gpOrderPrice.PerformLayout();
            this.gpWhereToEat.ResumeLayout(false);
            this.gpWhereToEat.PerformLayout();
            this.gpCrustType.ResumeLayout(false);
            this.gpCrustType.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpSizes.ResumeLayout(false);
            this.gpSizes.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlCenter;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GroupBox gpSizes;
        private Guna.UI2.WinForms.Guna2RadioButton rdoBig;
        private Guna.UI2.WinForms.Guna2RadioButton rdoMedium;
        private Guna.UI2.WinForms.Guna2RadioButton rdoSmall;
        private Guna.UI2.WinForms.Guna2GroupBox gpCrustType;
        private Guna.UI2.WinForms.Guna2RadioButton rdoCrustThin;
        private Guna.UI2.WinForms.Guna2RadioButton rdoCrustThick;
        private Guna.UI2.WinForms.Guna2GroupBox gpToppings;
        private Guna.UI2.WinForms.Guna2CheckBox chkGreenPeppers;
        private Guna.UI2.WinForms.Guna2CheckBox chkOlives;
        private Guna.UI2.WinForms.Guna2CheckBox chkOnion;
        private Guna.UI2.WinForms.Guna2CheckBox chkTomatoes;
        private Guna.UI2.WinForms.Guna2CheckBox chkMushrooms;
        private Guna.UI2.WinForms.Guna2CheckBox chkExtraCheese;
        private Guna.UI2.WinForms.Guna2GroupBox gpWhereToEat;
        private Guna.UI2.WinForms.Guna2RadioButton rdoEatOut;
        private Guna.UI2.WinForms.Guna2RadioButton rdoEatIn;
        private Guna.UI2.WinForms.Guna2Button btnOrderPizza;
        private Guna.UI2.WinForms.Guna2Button btnResetForm;
        private Guna.UI2.WinForms.Guna2GroupBox gpOrderPrice;
        private System.Windows.Forms.Label lblTitlePrice;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TrackBar barCountOfPizzas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPizzasCount;
        private System.Windows.Forms.Label label4;
    }






}



