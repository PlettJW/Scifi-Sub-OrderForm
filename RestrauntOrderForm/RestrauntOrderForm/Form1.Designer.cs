namespace RestrauntOrderForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rb12 = new System.Windows.Forms.RadioButton();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.gbMeat = new System.Windows.Forms.GroupBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.cbPep = new System.Windows.Forms.CheckBox();
            this.cbSalami = new System.Windows.Forms.CheckBox();
            this.cbBacon = new System.Windows.Forms.CheckBox();
            this.cbChicken = new System.Windows.Forms.CheckBox();
            this.cbTurkey = new System.Windows.Forms.CheckBox();
            this.bgBread = new System.Windows.Forms.GroupBox();
            this.cbHoneyO = new System.Windows.Forms.CheckBox();
            this.cbWholeG = new System.Windows.Forms.CheckBox();
            this.cbItalian = new System.Windows.Forms.CheckBox();
            this.gbVeg = new System.Windows.Forms.GroupBox();
            this.cbSpinich = new System.Windows.Forms.CheckBox();
            this.cbTomato = new System.Windows.Forms.CheckBox();
            this.cbOnions = new System.Windows.Forms.CheckBox();
            this.cbPeppers = new System.Windows.Forms.CheckBox();
            this.cbPickels = new System.Windows.Forms.CheckBox();
            this.cbLettuce = new System.Windows.Forms.CheckBox();
            this.gbSauce = new System.Windows.Forms.GroupBox();
            this.cbMayonnaise = new System.Windows.Forms.CheckBox();
            this.cbAioli = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.cbMustard = new System.Windows.Forms.CheckBox();
            this.cbRanch = new System.Windows.Forms.CheckBox();
            this.cbSriracha = new System.Windows.Forms.CheckBox();
            this.cbFranks = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbToast = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butSubmit = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.nudSubs = new System.Windows.Forms.NumericUpDown();
            this.lblSubs = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rbPickUp = new System.Windows.Forms.RadioButton();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbMeat.SuspendLayout();
            this.bgBread.SuspendLayout();
            this.gbVeg.SuspendLayout();
            this.gbSauce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbToast.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.LimeGreen;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1113, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SciFi Sub";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.LimeGreen;
            this.gbSize.Controls.Add(this.rb12);
            this.gbSize.Controls.Add(this.rb6);
            this.gbSize.Controls.Add(this.checkBox8);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(46, 45);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(192, 132);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rb12
            // 
            this.rb12.AutoSize = true;
            this.rb12.Location = new System.Drawing.Point(7, 75);
            this.rb12.Name = "rb12";
            this.rb12.Size = new System.Drawing.Size(104, 24);
            this.rb12.TabIndex = 2;
            this.rb12.TabStop = true;
            this.rb12.Text = "12 inch: $7";
            this.rb12.UseVisualStyleBackColor = true;
            this.rb12.CheckedChanged += new System.EventHandler(this.rb12_CheckedChanged);
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Location = new System.Drawing.Point(7, 26);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(95, 24);
            this.rb6.TabIndex = 1;
            this.rb6.TabStop = true;
            this.rb6.Text = "6 inch: $3";
            this.rb6.UseVisualStyleBackColor = true;
            this.rb6.CheckedChanged += new System.EventHandler(this.rb6_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(280, 57);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(106, 24);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "checkBox1";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // gbMeat
            // 
            this.gbMeat.BackColor = System.Drawing.Color.LimeGreen;
            this.gbMeat.Controls.Add(this.cbHam);
            this.gbMeat.Controls.Add(this.cbPep);
            this.gbMeat.Controls.Add(this.cbSalami);
            this.gbMeat.Controls.Add(this.cbBacon);
            this.gbMeat.Controls.Add(this.cbChicken);
            this.gbMeat.Controls.Add(this.cbTurkey);
            this.gbMeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMeat.Location = new System.Drawing.Point(320, 45);
            this.gbMeat.Name = "gbMeat";
            this.gbMeat.Size = new System.Drawing.Size(347, 132);
            this.gbMeat.TabIndex = 2;
            this.gbMeat.TabStop = false;
            this.gbMeat.Text = "Meat: $2";
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Location = new System.Drawing.Point(6, 93);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(62, 24);
            this.cbHam.TabIndex = 0;
            this.cbHam.Text = "Ham";
            this.cbHam.UseVisualStyleBackColor = true;
            this.cbHam.CheckedChanged += new System.EventHandler(this.cbTurkey_CheckedChanged);
            // 
            // cbPep
            // 
            this.cbPep.AutoSize = true;
            this.cbPep.Location = new System.Drawing.Point(6, 56);
            this.cbPep.Name = "cbPep";
            this.cbPep.Size = new System.Drawing.Size(100, 24);
            this.cbPep.TabIndex = 0;
            this.cbPep.Text = "Pepperoni";
            this.cbPep.UseVisualStyleBackColor = true;
            this.cbPep.CheckedChanged += new System.EventHandler(this.cbTurkey_CheckedChanged);
            // 
            // cbSalami
            // 
            this.cbSalami.AutoSize = true;
            this.cbSalami.Location = new System.Drawing.Point(155, 93);
            this.cbSalami.Name = "cbSalami";
            this.cbSalami.Size = new System.Drawing.Size(76, 24);
            this.cbSalami.TabIndex = 0;
            this.cbSalami.Text = "Salami";
            this.cbSalami.UseVisualStyleBackColor = true;
            this.cbSalami.CheckedChanged += new System.EventHandler(this.cbTurkey_CheckedChanged);
            // 
            // cbBacon
            // 
            this.cbBacon.AutoSize = true;
            this.cbBacon.Location = new System.Drawing.Point(155, 56);
            this.cbBacon.Name = "cbBacon";
            this.cbBacon.Size = new System.Drawing.Size(74, 24);
            this.cbBacon.TabIndex = 0;
            this.cbBacon.Text = "Bacon";
            this.cbBacon.UseVisualStyleBackColor = true;
            this.cbBacon.CheckedChanged += new System.EventHandler(this.cbTurkey_CheckedChanged);
            // 
            // cbChicken
            // 
            this.cbChicken.AutoSize = true;
            this.cbChicken.Location = new System.Drawing.Point(155, 19);
            this.cbChicken.Name = "cbChicken";
            this.cbChicken.Size = new System.Drawing.Size(82, 24);
            this.cbChicken.TabIndex = 0;
            this.cbChicken.Text = "chicken";
            this.cbChicken.UseVisualStyleBackColor = true;
            this.cbChicken.CheckedChanged += new System.EventHandler(this.cbTurkey_CheckedChanged);
            // 
            // cbTurkey
            // 
            this.cbTurkey.AutoSize = true;
            this.cbTurkey.Location = new System.Drawing.Point(6, 19);
            this.cbTurkey.Name = "cbTurkey";
            this.cbTurkey.Size = new System.Drawing.Size(75, 24);
            this.cbTurkey.TabIndex = 0;
            this.cbTurkey.Text = "Turkey";
            this.cbTurkey.UseVisualStyleBackColor = true;
            this.cbTurkey.CheckedChanged += new System.EventHandler(this.cbTurkey_CheckedChanged);
            // 
            // bgBread
            // 
            this.bgBread.BackColor = System.Drawing.Color.LimeGreen;
            this.bgBread.Controls.Add(this.cbHoneyO);
            this.bgBread.Controls.Add(this.cbWholeG);
            this.bgBread.Controls.Add(this.cbItalian);
            this.bgBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgBread.Location = new System.Drawing.Point(46, 239);
            this.bgBread.Name = "bgBread";
            this.bgBread.Size = new System.Drawing.Size(192, 132);
            this.bgBread.TabIndex = 2;
            this.bgBread.TabStop = false;
            this.bgBread.Text = "Bread";
            // 
            // cbHoneyO
            // 
            this.cbHoneyO.AutoSize = true;
            this.cbHoneyO.Location = new System.Drawing.Point(7, 94);
            this.cbHoneyO.Name = "cbHoneyO";
            this.cbHoneyO.Size = new System.Drawing.Size(104, 24);
            this.cbHoneyO.TabIndex = 2;
            this.cbHoneyO.Text = "Honey Oat";
            this.cbHoneyO.UseVisualStyleBackColor = true;
            this.cbHoneyO.CheckedChanged += new System.EventHandler(this.cbHoneyO_CheckedChanged);
            // 
            // cbWholeG
            // 
            this.cbWholeG.AutoSize = true;
            this.cbWholeG.Location = new System.Drawing.Point(7, 57);
            this.cbWholeG.Name = "cbWholeG";
            this.cbWholeG.Size = new System.Drawing.Size(116, 24);
            this.cbWholeG.TabIndex = 1;
            this.cbWholeG.Text = "Whole Grain";
            this.cbWholeG.UseVisualStyleBackColor = true;
            this.cbWholeG.CheckedChanged += new System.EventHandler(this.cbWholeG_CheckedChanged);
            // 
            // cbItalian
            // 
            this.cbItalian.AutoSize = true;
            this.cbItalian.Location = new System.Drawing.Point(7, 20);
            this.cbItalian.Name = "cbItalian";
            this.cbItalian.Size = new System.Drawing.Size(71, 24);
            this.cbItalian.TabIndex = 0;
            this.cbItalian.Text = "Italian";
            this.cbItalian.UseVisualStyleBackColor = true;
            this.cbItalian.CheckedChanged += new System.EventHandler(this.cbItalian_CheckedChanged);
            // 
            // gbVeg
            // 
            this.gbVeg.BackColor = System.Drawing.Color.LimeGreen;
            this.gbVeg.Controls.Add(this.cbSpinich);
            this.gbVeg.Controls.Add(this.cbTomato);
            this.gbVeg.Controls.Add(this.cbOnions);
            this.gbVeg.Controls.Add(this.cbPeppers);
            this.gbVeg.Controls.Add(this.cbPickels);
            this.gbVeg.Controls.Add(this.cbLettuce);
            this.gbVeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVeg.Location = new System.Drawing.Point(320, 239);
            this.gbVeg.Name = "gbVeg";
            this.gbVeg.Size = new System.Drawing.Size(347, 132);
            this.gbVeg.TabIndex = 2;
            this.gbVeg.TabStop = false;
            this.gbVeg.Text = "Vegitables: $1";
            // 
            // cbSpinich
            // 
            this.cbSpinich.AutoSize = true;
            this.cbSpinich.Location = new System.Drawing.Point(6, 94);
            this.cbSpinich.Name = "cbSpinich";
            this.cbSpinich.Size = new System.Drawing.Size(80, 24);
            this.cbSpinich.TabIndex = 0;
            this.cbSpinich.Text = "Spinich";
            this.cbSpinich.UseVisualStyleBackColor = true;
            this.cbSpinich.CheckedChanged += new System.EventHandler(this.cbLettuce_CheckedChanged);
            // 
            // cbTomato
            // 
            this.cbTomato.AutoSize = true;
            this.cbTomato.Location = new System.Drawing.Point(6, 57);
            this.cbTomato.Name = "cbTomato";
            this.cbTomato.Size = new System.Drawing.Size(82, 24);
            this.cbTomato.TabIndex = 0;
            this.cbTomato.Text = "Tomato";
            this.cbTomato.UseVisualStyleBackColor = true;
            this.cbTomato.CheckedChanged += new System.EventHandler(this.cbLettuce_CheckedChanged);
            // 
            // cbOnions
            // 
            this.cbOnions.AutoSize = true;
            this.cbOnions.Location = new System.Drawing.Point(155, 94);
            this.cbOnions.Name = "cbOnions";
            this.cbOnions.Size = new System.Drawing.Size(78, 24);
            this.cbOnions.TabIndex = 0;
            this.cbOnions.Text = "Onions";
            this.cbOnions.UseVisualStyleBackColor = true;
            this.cbOnions.CheckedChanged += new System.EventHandler(this.cbLettuce_CheckedChanged);
            // 
            // cbPeppers
            // 
            this.cbPeppers.AutoSize = true;
            this.cbPeppers.Location = new System.Drawing.Point(155, 57);
            this.cbPeppers.Name = "cbPeppers";
            this.cbPeppers.Size = new System.Drawing.Size(87, 24);
            this.cbPeppers.TabIndex = 0;
            this.cbPeppers.Text = "Peppers";
            this.cbPeppers.UseVisualStyleBackColor = true;
            this.cbPeppers.CheckedChanged += new System.EventHandler(this.cbLettuce_CheckedChanged);
            // 
            // cbPickels
            // 
            this.cbPickels.AutoSize = true;
            this.cbPickels.Location = new System.Drawing.Point(155, 20);
            this.cbPickels.Name = "cbPickels";
            this.cbPickels.Size = new System.Drawing.Size(77, 24);
            this.cbPickels.TabIndex = 0;
            this.cbPickels.Text = "Pickels";
            this.cbPickels.UseVisualStyleBackColor = true;
            this.cbPickels.CheckedChanged += new System.EventHandler(this.cbLettuce_CheckedChanged);
            // 
            // cbLettuce
            // 
            this.cbLettuce.AutoSize = true;
            this.cbLettuce.Location = new System.Drawing.Point(6, 20);
            this.cbLettuce.Name = "cbLettuce";
            this.cbLettuce.Size = new System.Drawing.Size(82, 24);
            this.cbLettuce.TabIndex = 0;
            this.cbLettuce.Text = "Lettuce";
            this.cbLettuce.UseVisualStyleBackColor = true;
            this.cbLettuce.CheckedChanged += new System.EventHandler(this.cbLettuce_CheckedChanged);
            // 
            // gbSauce
            // 
            this.gbSauce.BackColor = System.Drawing.Color.LimeGreen;
            this.gbSauce.Controls.Add(this.cbMayonnaise);
            this.gbSauce.Controls.Add(this.cbAioli);
            this.gbSauce.Controls.Add(this.checkBox27);
            this.gbSauce.Controls.Add(this.cbMustard);
            this.gbSauce.Controls.Add(this.cbRanch);
            this.gbSauce.Controls.Add(this.cbSriracha);
            this.gbSauce.Controls.Add(this.cbFranks);
            this.gbSauce.Controls.Add(this.checkBox21);
            this.gbSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSauce.Location = new System.Drawing.Point(744, 45);
            this.gbSauce.Name = "gbSauce";
            this.gbSauce.Size = new System.Drawing.Size(192, 339);
            this.gbSauce.TabIndex = 1;
            this.gbSauce.TabStop = false;
            this.gbSauce.Text = "Sauce: $1";
            // 
            // cbMayonnaise
            // 
            this.cbMayonnaise.AutoSize = true;
            this.cbMayonnaise.Location = new System.Drawing.Point(6, 19);
            this.cbMayonnaise.Name = "cbMayonnaise";
            this.cbMayonnaise.Size = new System.Drawing.Size(113, 24);
            this.cbMayonnaise.TabIndex = 0;
            this.cbMayonnaise.Text = "Mayonnaise";
            this.cbMayonnaise.UseVisualStyleBackColor = true;
            this.cbMayonnaise.CheckedChanged += new System.EventHandler(this.cbMayonnaise_CheckedChanged);
            // 
            // cbAioli
            // 
            this.cbAioli.AutoSize = true;
            this.cbAioli.Location = new System.Drawing.Point(6, 299);
            this.cbAioli.Name = "cbAioli";
            this.cbAioli.Size = new System.Drawing.Size(102, 24);
            this.cbAioli.TabIndex = 0;
            this.cbAioli.Text = "Garlic Aioli";
            this.cbAioli.UseVisualStyleBackColor = true;
            this.cbAioli.CheckedChanged += new System.EventHandler(this.cbMayonnaise_CheckedChanged);
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(6, 301);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(106, 24);
            this.checkBox27.TabIndex = 0;
            this.checkBox27.Text = "checkBox1";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // cbMustard
            // 
            this.cbMustard.AutoSize = true;
            this.cbMustard.Location = new System.Drawing.Point(6, 243);
            this.cbMustard.Name = "cbMustard";
            this.cbMustard.Size = new System.Drawing.Size(86, 24);
            this.cbMustard.TabIndex = 0;
            this.cbMustard.Text = "Mustard";
            this.cbMustard.UseVisualStyleBackColor = true;
            this.cbMustard.CheckedChanged += new System.EventHandler(this.cbMayonnaise_CheckedChanged);
            // 
            // cbRanch
            // 
            this.cbRanch.AutoSize = true;
            this.cbRanch.Location = new System.Drawing.Point(6, 131);
            this.cbRanch.Name = "cbRanch";
            this.cbRanch.Size = new System.Drawing.Size(75, 24);
            this.cbRanch.TabIndex = 0;
            this.cbRanch.Text = "Ranch";
            this.cbRanch.UseVisualStyleBackColor = true;
            this.cbRanch.CheckedChanged += new System.EventHandler(this.cbMayonnaise_CheckedChanged);
            // 
            // cbSriracha
            // 
            this.cbSriracha.AutoSize = true;
            this.cbSriracha.Location = new System.Drawing.Point(6, 187);
            this.cbSriracha.Name = "cbSriracha";
            this.cbSriracha.Size = new System.Drawing.Size(87, 24);
            this.cbSriracha.TabIndex = 0;
            this.cbSriracha.Text = "Sriracha";
            this.cbSriracha.UseVisualStyleBackColor = true;
            this.cbSriracha.CheckedChanged += new System.EventHandler(this.cbMayonnaise_CheckedChanged);
            // 
            // cbFranks
            // 
            this.cbFranks.AutoSize = true;
            this.cbFranks.Location = new System.Drawing.Point(6, 75);
            this.cbFranks.Name = "cbFranks";
            this.cbFranks.Size = new System.Drawing.Size(107, 24);
            this.cbFranks.TabIndex = 0;
            this.cbFranks.Text = "Franks Hot";
            this.cbFranks.UseVisualStyleBackColor = true;
            this.cbFranks.CheckedChanged += new System.EventHandler(this.cbMayonnaise_CheckedChanged);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(6, 20);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(106, 24);
            this.checkBox21.TabIndex = 0;
            this.checkBox21.Text = "checkBox1";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestrauntOrderForm.Properties.Resources.Big_Black_Wallpaper_12;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1120, 615);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gbToast
            // 
            this.gbToast.BackColor = System.Drawing.Color.LimeGreen;
            this.gbToast.Controls.Add(this.rbNo);
            this.gbToast.Controls.Add(this.rbYes);
            this.gbToast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToast.Location = new System.Drawing.Point(46, 433);
            this.gbToast.Name = "gbToast";
            this.gbToast.Size = new System.Drawing.Size(192, 132);
            this.gbToast.TabIndex = 2;
            this.gbToast.TabStop = false;
            this.gbToast.Text = "Toasted?";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(7, 77);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(120, 24);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No Thankyou";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(7, 26);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(107, 24);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes Please";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // gbDetails
            // 
            this.gbDetails.BackColor = System.Drawing.Color.LimeGreen;
            this.gbDetails.Controls.Add(this.tbAdress);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Controls.Add(this.butSubmit);
            this.gbDetails.Controls.Add(this.butClear);
            this.gbDetails.Controls.Add(this.nudSubs);
            this.gbDetails.Controls.Add(this.lblSubs);
            this.gbDetails.Controls.Add(this.tbPhone);
            this.gbDetails.Controls.Add(this.tbName);
            this.gbDetails.Controls.Add(this.lblPhone);
            this.gbDetails.Controls.Add(this.lblName);
            this.gbDetails.Controls.Add(this.rbPickUp);
            this.gbDetails.Controls.Add(this.rbDelivery);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(320, 433);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(616, 132);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // tbAdress
            // 
            this.tbAdress.Enabled = false;
            this.tbAdress.Location = new System.Drawing.Point(96, 94);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(100, 26);
            this.tbAdress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adress";
            // 
            // butSubmit
            // 
            this.butSubmit.BackColor = System.Drawing.Color.DimGray;
            this.butSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSubmit.Location = new System.Drawing.Point(471, 63);
            this.butSubmit.Name = "butSubmit";
            this.butSubmit.Size = new System.Drawing.Size(72, 52);
            this.butSubmit.TabIndex = 6;
            this.butSubmit.Text = "Submit";
            this.butSubmit.UseVisualStyleBackColor = false;
            this.butSubmit.Click += new System.EventHandler(this.butSubmit_Click);
            // 
            // butClear
            // 
            this.butClear.BackColor = System.Drawing.Color.DimGray;
            this.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butClear.Location = new System.Drawing.Point(366, 63);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(72, 52);
            this.butClear.TabIndex = 6;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = false;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // nudSubs
            // 
            this.nudSubs.Location = new System.Drawing.Point(209, 63);
            this.nudSubs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSubs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSubs.Name = "nudSubs";
            this.nudSubs.Size = new System.Drawing.Size(120, 26);
            this.nudSubs.TabIndex = 5;
            this.nudSubs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSubs.ValueChanged += new System.EventHandler(this.nudSubs_ValueChanged);
            // 
            // lblSubs
            // 
            this.lblSubs.AutoSize = true;
            this.lblSubs.Location = new System.Drawing.Point(156, 63);
            this.lblSubs.Name = "lblSubs";
            this.lblSubs.Size = new System.Drawing.Size(46, 20);
            this.lblSubs.TabIndex = 4;
            this.lblSubs.Text = "Subs";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(424, 22);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(138, 26);
            this.tbPhone.TabIndex = 3;
            this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(209, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(138, 26);
            this.tbName.TabIndex = 3;
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(362, 28);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(151, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // rbPickUp
            // 
            this.rbPickUp.AutoSize = true;
            this.rbPickUp.Location = new System.Drawing.Point(8, 28);
            this.rbPickUp.Name = "rbPickUp";
            this.rbPickUp.Size = new System.Drawing.Size(81, 24);
            this.rbPickUp.TabIndex = 0;
            this.rbPickUp.TabStop = true;
            this.rbPickUp.Text = "Pick Up";
            this.rbPickUp.UseVisualStyleBackColor = true;
            this.rbPickUp.CheckedChanged += new System.EventHandler(this.rbPickUp_CheckedChanged);
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(7, 61);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(82, 24);
            this.rbDelivery.TabIndex = 0;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery";
            this.rbDelivery.UseVisualStyleBackColor = true;
            this.rbDelivery.CheckedChanged += new System.EventHandler(this.rbDelivery_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(959, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SubTotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(959, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(959, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Lime;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(1042, 455);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(49, 20);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "$0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.BackColor = System.Drawing.Color.Lime;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(1042, 482);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(49, 20);
            this.lblTax.TabIndex = 5;
            this.lblTax.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Lime;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1042, 509);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1113, 609);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbToast);
            this.Controls.Add(this.bgBread);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbVeg);
            this.Controls.Add(this.gbMeat);
            this.Controls.Add(this.gbSauce);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SciFi Sub";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbMeat.ResumeLayout(false);
            this.gbMeat.PerformLayout();
            this.bgBread.ResumeLayout(false);
            this.bgBread.PerformLayout();
            this.gbVeg.ResumeLayout(false);
            this.gbVeg.PerformLayout();
            this.gbSauce.ResumeLayout(false);
            this.gbSauce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbToast.ResumeLayout(false);
            this.gbToast.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbMeat;
        private System.Windows.Forms.GroupBox bgBread;
        private System.Windows.Forms.GroupBox gbVeg;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox cbHam;
        private System.Windows.Forms.CheckBox cbPep;
        private System.Windows.Forms.CheckBox cbSalami;
        private System.Windows.Forms.CheckBox cbBacon;
        private System.Windows.Forms.CheckBox cbChicken;
        private System.Windows.Forms.CheckBox cbTurkey;
        private System.Windows.Forms.CheckBox cbHoneyO;
        private System.Windows.Forms.CheckBox cbWholeG;
        private System.Windows.Forms.CheckBox cbItalian;
        private System.Windows.Forms.CheckBox cbSpinich;
        private System.Windows.Forms.CheckBox cbTomato;
        private System.Windows.Forms.CheckBox cbOnions;
        private System.Windows.Forms.CheckBox cbPeppers;
        private System.Windows.Forms.CheckBox cbPickels;
        private System.Windows.Forms.CheckBox cbLettuce;
        private System.Windows.Forms.GroupBox gbSauce;
        private System.Windows.Forms.CheckBox cbMayonnaise;
        private System.Windows.Forms.CheckBox cbAioli;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox cbMustard;
        private System.Windows.Forms.CheckBox cbRanch;
        private System.Windows.Forms.CheckBox cbSriracha;
        private System.Windows.Forms.CheckBox cbFranks;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbToast;
        private System.Windows.Forms.RadioButton rb12;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Button butSubmit;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.NumericUpDown nudSubs;
        private System.Windows.Forms.Label lblSubs;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbPickUp;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label label4;
    }
}

