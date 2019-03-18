namespace CarAuctionSL.Windows
{
    partial class PersonalInterest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInterest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lst_users = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_town = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_selectedCustomer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_milage = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_bodyTypes = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_yearmade = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_models = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_make = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lst_interest = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rdo_basedonprice = new System.Windows.Forms.RadioButton();
            this.rdo_basedonmakemodel = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.txt_pricefrom = new System.Windows.Forms.Label();
            this.txt_priceto = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_lastname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_firstname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_mobile);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_City);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmb_town);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 293);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lst_users);
            this.panel3.Location = new System.Drawing.Point(691, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(601, 285);
            this.panel3.TabIndex = 19;
            // 
            // lst_users
            // 
            this.lst_users.LargeImageList = this.imageList1;
            this.lst_users.Location = new System.Drawing.Point(16, 11);
            this.lst_users.Name = "lst_users";
            this.lst_users.Size = new System.Drawing.Size(579, 269);
            this.lst_users.SmallImageList = this.imageList1;
            this.lst_users.TabIndex = 0;
            this.lst_users.UseCompatibleStateImageBehavior = false;
            this.lst_users.SelectedIndexChanged += new System.EventHandler(this.lst_users_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001-man.png");
            this.imageList1.Images.SetKeyName(1, "006-like.png");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(331, 116);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(337, 23);
            this.txt_password.TabIndex = 17;
            this.txt_password.Text = "123";
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Last Name";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(331, 164);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(337, 23);
            this.txt_lastname.TabIndex = 15;
            this.txt_lastname.Text = "Pathirana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "First Name";
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(15, 164);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(299, 23);
            this.txt_firstname.TabIndex = 13;
            this.txt_firstname.Text = "Saman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mobile Number";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(15, 66);
            this.txt_mobile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(299, 23);
            this.txt_mobile.TabIndex = 11;
            this.txt_mobile.Text = "0778151152";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "City";
            // 
            // cmb_City
            // 
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Location = new System.Drawing.Point(15, 207);
            this.cmb_City.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(273, 23);
            this.cmb_City.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area";
            // 
            // cmb_town
            // 
            this.cmb_town.FormattingEnabled = true;
            this.cmb_town.Location = new System.Drawing.Point(331, 207);
            this.cmb_town.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_town.Name = "cmb_town";
            this.cmb_town.Size = new System.Drawing.Size(232, 23);
            this.cmb_town.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(15, 116);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(299, 23);
            this.txt_username.TabIndex = 5;
            this.txt_username.Text = "Saman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers _________________________________";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(331, 66);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(337, 23);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.Text = "abc@bcd.com";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txt_priceto);
            this.panel2.Controls.Add(this.txt_pricefrom);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.rdo_basedonmakemodel);
            this.panel2.Controls.Add(this.rdo_basedonprice);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbl_selectedCustomer);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cmb_milage);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cmb_bodyTypes);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cmb_yearmade);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmb_models);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cmb_make);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(14, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 293);
            this.panel2.TabIndex = 5;
            // 
            // lbl_selectedCustomer
            // 
            this.lbl_selectedCustomer.AutoSize = true;
            this.lbl_selectedCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectedCustomer.Location = new System.Drawing.Point(10, 29);
            this.lbl_selectedCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectedCustomer.Name = "lbl_selectedCustomer";
            this.lbl_selectedCustomer.Size = new System.Drawing.Size(90, 19);
            this.lbl_selectedCustomer.TabIndex = 30;
            this.lbl_selectedCustomer.Text = "<Customer>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Millage";
            // 
            // cmb_milage
            // 
            this.cmb_milage.FormattingEnabled = true;
            this.cmb_milage.Location = new System.Drawing.Point(14, 185);
            this.cmb_milage.Name = "cmb_milage";
            this.cmb_milage.Size = new System.Drawing.Size(253, 23);
            this.cmb_milage.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Body Type";
            // 
            // cmb_bodyTypes
            // 
            this.cmb_bodyTypes.FormattingEnabled = true;
            this.cmb_bodyTypes.Location = new System.Drawing.Point(273, 141);
            this.cmb_bodyTypes.Name = "cmb_bodyTypes";
            this.cmb_bodyTypes.Size = new System.Drawing.Size(281, 23);
            this.cmb_bodyTypes.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Year Made";
            // 
            // cmb_yearmade
            // 
            this.cmb_yearmade.FormattingEnabled = true;
            this.cmb_yearmade.Location = new System.Drawing.Point(14, 141);
            this.cmb_yearmade.Name = "cmb_yearmade";
            this.cmb_yearmade.Size = new System.Drawing.Size(253, 23);
            this.cmb_yearmade.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Model";
            // 
            // cmb_models
            // 
            this.cmb_models.FormattingEnabled = true;
            this.cmb_models.Location = new System.Drawing.Point(273, 97);
            this.cmb_models.Name = "cmb_models";
            this.cmb_models.Size = new System.Drawing.Size(281, 23);
            this.cmb_models.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "Make";
            // 
            // cmb_make
            // 
            this.cmb_make.FormattingEnabled = true;
            this.cmb_make.Location = new System.Drawing.Point(14, 97);
            this.cmb_make.Name = "cmb_make";
            this.cmb_make.Size = new System.Drawing.Size(253, 23);
            this.cmb_make.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lst_interest);
            this.panel4.Location = new System.Drawing.Point(691, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(601, 285);
            this.panel4.TabIndex = 19;
            // 
            // lst_interest
            // 
            this.lst_interest.LargeImageList = this.imageList1;
            this.lst_interest.Location = new System.Drawing.Point(16, 11);
            this.lst_interest.Name = "lst_interest";
            this.lst_interest.Size = new System.Drawing.Size(579, 269);
            this.lst_interest.SmallImageList = this.imageList1;
            this.lst_interest.TabIndex = 0;
            this.lst_interest.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 179);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 4);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(521, 26);
            this.label18.TabIndex = 3;
            this.label18.Text = "Personalize Interests _________________________________";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 211);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Price Range";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(92, 211);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "From";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(295, 211);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "To";
            // 
            // rdo_basedonprice
            // 
            this.rdo_basedonprice.AutoSize = true;
            this.rdo_basedonprice.Checked = true;
            this.rdo_basedonprice.Location = new System.Drawing.Point(15, 52);
            this.rdo_basedonprice.Name = "rdo_basedonprice";
            this.rdo_basedonprice.Size = new System.Drawing.Size(153, 19);
            this.rdo_basedonprice.TabIndex = 36;
            this.rdo_basedonprice.TabStop = true;
            this.rdo_basedonprice.Text = "Interest Based On price";
            this.rdo_basedonprice.UseVisualStyleBackColor = true;
            // 
            // rdo_basedonmakemodel
            // 
            this.rdo_basedonmakemodel.AutoSize = true;
            this.rdo_basedonmakemodel.Location = new System.Drawing.Point(273, 52);
            this.rdo_basedonmakemodel.Name = "rdo_basedonmakemodel";
            this.rdo_basedonmakemodel.Size = new System.Drawing.Size(217, 19);
            this.rdo_basedonmakemodel.TabIndex = 37;
            this.rdo_basedonmakemodel.Text = "Interest Based On Make And Model";
            this.rdo_basedonmakemodel.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 231);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(264, 45);
            this.trackBar1.TabIndex = 38;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(275, 231);
            this.trackBar2.Maximum = 300;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(264, 45);
            this.trackBar2.TabIndex = 39;
            this.trackBar2.Value = 1;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // txt_pricefrom
            // 
            this.txt_pricefrom.AutoSize = true;
            this.txt_pricefrom.Location = new System.Drawing.Point(181, 213);
            this.txt_pricefrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_pricefrom.Name = "txt_pricefrom";
            this.txt_pricefrom.Size = new System.Drawing.Size(22, 15);
            this.txt_pricefrom.TabIndex = 40;
            this.txt_pricefrom.Text = "     ";
            // 
            // txt_priceto
            // 
            this.txt_priceto.AutoSize = true;
            this.txt_priceto.Location = new System.Drawing.Point(460, 211);
            this.txt_priceto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_priceto.Name = "txt_priceto";
            this.txt_priceto.Size = new System.Drawing.Size(25, 15);
            this.txt_priceto.TabIndex = 41;
            this.txt_priceto.Text = "      ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(196, 213);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 15);
            this.label19.TabIndex = 42;
            this.label19.Text = "Laks";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(493, 213);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 15);
            this.label20.TabIndex = 43;
            this.label20.Text = "Laks";
            // 
            // PersonalInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PersonalInterest";
            this.Text = "PersonalInterest";
            this.Load += new System.EventHandler(this.PersonalInterest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_town;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lst_users;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lst_interest;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_selectedCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_milage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_bodyTypes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_yearmade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_models;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_make;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rdo_basedonmakemodel;
        private System.Windows.Forms.RadioButton rdo_basedonprice;
        private System.Windows.Forms.Label txt_priceto;
        private System.Windows.Forms.Label txt_pricefrom;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}