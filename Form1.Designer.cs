namespace PA
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;
        
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
            this.newFlight = new System.Windows.Forms.TabPage();
            this.narr = new System.Windows.Forms.MonthCalendar();
            this.ndep = new System.Windows.Forms.MonthCalendar();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.mealYN = new System.Windows.Forms.ComboBox();
            this.nto = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.TextBox();
            this.row_text = new System.Windows.Forms.TextBox();
            this.cap_text = new System.Windows.Forms.TextBox();
            this.nairname = new System.Windows.Forms.TextBox();
            this.fID_text = new System.Windows.Forms.TextBox();
            this.nfrom = new System.Windows.Forms.TextBox();
            this.addF_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dep = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flights = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ticket = new System.Windows.Forms.TabPage();
            this.passNames_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.booking = new System.Windows.Forms.TabPage();
            this.book_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flightName_drop = new System.Windows.Forms.ComboBox();
            this.available = new System.Windows.Forms.TextBox();
            this.align_box = new System.Windows.Forms.ComboBox();
            this.row_box = new System.Windows.Forms.ComboBox();
            this.departure_pick = new System.Windows.Forms.DateTimePicker();
            this.check = new System.Windows.Forms.Button();
            this.seatAlign = new System.Windows.Forms.Label();
            this.seatRow = new System.Windows.Forms.Label();
            this.dateOdep = new System.Windows.Forms.Label();
            this.flightName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mail_text = new System.Windows.Forms.TextBox();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.lName_text = new System.Windows.Forms.TextBox();
            this.fName_text = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.navBar = new System.Windows.Forms.TabControl();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stopovers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meeeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ticket.SuspendLayout();
            this.booking.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // newFlight
            // 
            this.newFlight.Controls.Add(this.narr);
            this.newFlight.Controls.Add(this.ndep);
            this.newFlight.Controls.Add(this.label14);
            this.newFlight.Controls.Add(this.label13);
            this.newFlight.Controls.Add(this.numericUpDown2);
            this.newFlight.Controls.Add(this.numericUpDown1);
            this.newFlight.Controls.Add(this.mealYN);
            this.newFlight.Controls.Add(this.nto);
            this.newFlight.Controls.Add(this.stop);
            this.newFlight.Controls.Add(this.row_text);
            this.newFlight.Controls.Add(this.cap_text);
            this.newFlight.Controls.Add(this.nairname);
            this.newFlight.Controls.Add(this.fID_text);
            this.newFlight.Controls.Add(this.nfrom);
            this.newFlight.Controls.Add(this.addF_button);
            this.newFlight.Controls.Add(this.label11);
            this.newFlight.Controls.Add(this.label10);
            this.newFlight.Controls.Add(this.label9);
            this.newFlight.Controls.Add(this.label8);
            this.newFlight.Controls.Add(this.label7);
            this.newFlight.Controls.Add(this.label6);
            this.newFlight.Controls.Add(this.dep);
            this.newFlight.Controls.Add(this.label12);
            this.newFlight.Controls.Add(this.label5);
            this.newFlight.Controls.Add(this.label4);
            this.newFlight.Controls.Add(this.fID);
            this.newFlight.Controls.Add(this.label3);
            this.newFlight.Location = new System.Drawing.Point(4, 29);
            this.newFlight.Name = "newFlight";
            this.newFlight.Size = new System.Drawing.Size(1135, 623);
            this.newFlight.TabIndex = 2;
            this.newFlight.Text = "New Flight";
            this.newFlight.UseVisualStyleBackColor = true;
            // 
            // narr
            // 
            this.narr.Location = new System.Drawing.Point(823, 95);
            this.narr.Name = "narr";
            this.narr.TabIndex = 11;
            this.narr.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.narr_DateSelected);
            // 
            // ndep
            // 
            this.ndep.Location = new System.Drawing.Point(513, 95);
            this.ndep.Name = "ndep";
            this.ndep.TabIndex = 10;
            this.ndep.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.ndep_DateSelected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(988, 363);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 27);
            this.label14.TabIndex = 7;
            this.label14.Text = "GMT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(860, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 32);
            this.label13.TabIndex = 6;
            this.label13.Text = ":";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(889, 363);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(93, 26);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(775, 362);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 26);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mealYN
            // 
            this.mealYN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mealYN.FormattingEnabled = true;
            this.mealYN.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.mealYN.Location = new System.Drawing.Point(227, 460);
            this.mealYN.Name = "mealYN";
            this.mealYN.Size = new System.Drawing.Size(252, 28);
            this.mealYN.TabIndex = 4;
            // 
            // nto
            // 
            this.nto.Location = new System.Drawing.Point(127, 129);
            this.nto.Name = "nto";
            this.nto.Size = new System.Drawing.Size(252, 26);
            this.nto.TabIndex = 2;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(693, 414);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(269, 26);
            this.stop.TabIndex = 2;
            // 
            // row_text
            // 
            this.row_text.Location = new System.Drawing.Point(227, 393);
            this.row_text.Name = "row_text";
            this.row_text.Size = new System.Drawing.Size(252, 26);
            this.row_text.TabIndex = 2;
            this.row_text.TextChanged += new System.EventHandler(this.row_text_TextChanged);
            this.row_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // cap_text
            // 
            this.cap_text.Location = new System.Drawing.Point(227, 322);
            this.cap_text.Name = "cap_text";
            this.cap_text.Size = new System.Drawing.Size(252, 26);
            this.cap_text.TabIndex = 2;
            this.cap_text.TextChanged += new System.EventHandler(this.cap_text_TextChanged);
            this.cap_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // nairname
            // 
            this.nairname.Location = new System.Drawing.Point(227, 257);
            this.nairname.Name = "nairname";
            this.nairname.Size = new System.Drawing.Size(252, 26);
            this.nairname.TabIndex = 2;
            // 
            // fID_text
            // 
            this.fID_text.Location = new System.Drawing.Point(227, 184);
            this.fID_text.Name = "fID_text";
            this.fID_text.Size = new System.Drawing.Size(252, 26);
            this.fID_text.TabIndex = 2;
            this.fID_text.TextChanged += new System.EventHandler(this.fID_text_TextChanged);
            this.fID_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // nfrom
            // 
            this.nfrom.Location = new System.Drawing.Point(127, 65);
            this.nfrom.Name = "nfrom";
            this.nfrom.Size = new System.Drawing.Size(252, 26);
            this.nfrom.TabIndex = 2;
            // 
            // addF_button
            // 
            this.addF_button.Location = new System.Drawing.Point(610, 484);
            this.addF_button.Name = "addF_button";
            this.addF_button.Size = new System.Drawing.Size(492, 102);
            this.addF_button.TabIndex = 1;
            this.addF_button.Text = "Add Flight";
            this.addF_button.UseVisualStyleBackColor = true;
            this.addF_button.Click += new System.EventHandler(this.addF_Button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "Meal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "Number of rows";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Capacity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Airplane Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stopovers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "To";
            // 
            // dep
            // 
            this.dep.AutoSize = true;
            this.dep.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep.Location = new System.Drawing.Point(23, 65);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(68, 27);
            this.dep.TabIndex = 0;
            this.dep.Text = "From";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(535, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "Departure Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(895, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Arrival Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Departure Date";
            // 
            // fID
            // 
            this.fID.AutoSize = true;
            this.fID.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fID.Location = new System.Drawing.Point(23, 184);
            this.fID.Name = "fID";
            this.fID.Size = new System.Drawing.Size(138, 27);
            this.fID.TabIndex = 0;
            this.fID.Text = "Flight ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add new Flight";
            // 
            // flights
            // 
            this.flights.Controls.Add(this.dataGridView1);
            this.flights.Controls.Add(this.label2);
            this.flights.Location = new System.Drawing.Point(4, 29);
            this.flights.Name = "flights";
            this.flights.Padding = new System.Windows.Forms.Padding(3);
            this.flights.Size = new System.Drawing.Size(1135, 623);
            this.flights.TabIndex = 1;
            this.flights.Text = "Available Flights";
            this.flights.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.From,
            this.To,
            this.NameFlight,
            this.Stopovers,
            this.AName,
            this.meeeal});
            this.dataGridView1.Location = new System.Drawing.Point(19, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Available Flights";
            // 
            // ticket
            // 
            this.ticket.Controls.Add(this.passNames_box);
            this.ticket.Controls.Add(this.label1);
            this.ticket.Location = new System.Drawing.Point(4, 29);
            this.ticket.Name = "ticket";
            this.ticket.Size = new System.Drawing.Size(1135, 623);
            this.ticket.TabIndex = 3;
            this.ticket.Text = "Ticket Info";
            this.ticket.UseVisualStyleBackColor = true;
            // 
            // passNames_box
            // 
            this.passNames_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passNames_box.FormattingEnabled = true;
            this.passNames_box.Location = new System.Drawing.Point(320, 98);
            this.passNames_box.Name = "passNames_box";
            this.passNames_box.Size = new System.Drawing.Size(475, 28);
            this.passNames_box.TabIndex = 1;
            this.passNames_box.SelectedValueChanged += new System.EventHandler(this.passNames_box_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passenger Names";
            // 
            // booking
            // 
            this.booking.Controls.Add(this.book_button);
            this.booking.Controls.Add(this.groupBox2);
            this.booking.Controls.Add(this.groupBox1);
            this.booking.Location = new System.Drawing.Point(4, 29);
            this.booking.Name = "booking";
            this.booking.Padding = new System.Windows.Forms.Padding(3);
            this.booking.Size = new System.Drawing.Size(1135, 623);
            this.booking.TabIndex = 0;
            this.booking.Text = "Book a Flight";
            this.booking.UseVisualStyleBackColor = true;
            // 
            // book_button
            // 
            this.book_button.Enabled = false;
            this.book_button.Location = new System.Drawing.Point(408, 483);
            this.book_button.Name = "book_button";
            this.book_button.Size = new System.Drawing.Size(266, 114);
            this.book_button.TabIndex = 22;
            this.book_button.Text = "Book ";
            this.book_button.UseVisualStyleBackColor = true;
            this.book_button.Click += new System.EventHandler(this.book_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flightName_drop);
            this.groupBox2.Controls.Add(this.available);
            this.groupBox2.Controls.Add(this.align_box);
            this.groupBox2.Controls.Add(this.row_box);
            this.groupBox2.Controls.Add(this.departure_pick);
            this.groupBox2.Controls.Add(this.check);
            this.groupBox2.Controls.Add(this.seatAlign);
            this.groupBox2.Controls.Add(this.seatRow);
            this.groupBox2.Controls.Add(this.dateOdep);
            this.groupBox2.Controls.Add(this.flightName);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(560, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 469);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flight Info";
            // 
            // flightName_drop
            // 
            this.flightName_drop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flightName_drop.FormattingEnabled = true;
            this.flightName_drop.Location = new System.Drawing.Point(281, 60);
            this.flightName_drop.Name = "flightName_drop";
            this.flightName_drop.Size = new System.Drawing.Size(281, 35);
            this.flightName_drop.TabIndex = 6;
            this.flightName_drop.SelectedValueChanged += new System.EventHandler(this.flightName_drop_SelectedValueChanged);
            // 
            // available
            // 
            this.available.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.Location = new System.Drawing.Point(30, 318);
            this.available.Multiline = true;
            this.available.Name = "available";
            this.available.Size = new System.Drawing.Size(516, 71);
            this.available.TabIndex = 5;
            this.available.Text = "Please provide all the infos.";
            this.available.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // align_box
            // 
            this.align_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.align_box.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.align_box.FormattingEnabled = true;
            this.align_box.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.align_box.Location = new System.Drawing.Point(281, 264);
            this.align_box.Name = "align_box";
            this.align_box.Size = new System.Drawing.Size(137, 30);
            this.align_box.TabIndex = 4;
            this.align_box.SelectedValueChanged += new System.EventHandler(this.align_box_SelectedValueChanged);
            // 
            // row_box
            // 
            this.row_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.row_box.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row_box.FormattingEnabled = true;
            this.row_box.Location = new System.Drawing.Point(281, 199);
            this.row_box.Name = "row_box";
            this.row_box.Size = new System.Drawing.Size(137, 30);
            this.row_box.TabIndex = 4;
            this.row_box.SelectedValueChanged += new System.EventHandler(this.row_box_SelectedValueChanged);
            // 
            // departure_pick
            // 
            this.departure_pick.CalendarFont = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure_pick.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departure_pick.Location = new System.Drawing.Point(281, 137);
            this.departure_pick.Name = "departure_pick";
            this.departure_pick.Size = new System.Drawing.Size(281, 26);
            this.departure_pick.TabIndex = 3;
            // 
            // check
            // 
            this.check.Enabled = false;
            this.check.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(367, 395);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(179, 48);
            this.check.TabIndex = 10;
            this.check.Text = "Check availability";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // seatAlign
            // 
            this.seatAlign.AutoSize = true;
            this.seatAlign.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatAlign.Location = new System.Drawing.Point(26, 270);
            this.seatAlign.Name = "seatAlign";
            this.seatAlign.Size = new System.Drawing.Size(192, 24);
            this.seatAlign.TabIndex = 0;
            this.seatAlign.Text = "Seat alignment";
            // 
            // seatRow
            // 
            this.seatRow.AutoSize = true;
            this.seatRow.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatRow.Location = new System.Drawing.Point(26, 201);
            this.seatRow.Name = "seatRow";
            this.seatRow.Size = new System.Drawing.Size(114, 24);
            this.seatRow.TabIndex = 0;
            this.seatRow.Text = "Seat row";
            // 
            // dateOdep
            // 
            this.dateOdep.AutoSize = true;
            this.dateOdep.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOdep.Location = new System.Drawing.Point(26, 137);
            this.dateOdep.Name = "dateOdep";
            this.dateOdep.Size = new System.Drawing.Size(231, 24);
            this.dateOdep.TabIndex = 0;
            this.dateOdep.Text = "Date of Departure";
            // 
            // flightName
            // 
            this.flightName.AutoSize = true;
            this.flightName.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightName.Location = new System.Drawing.Point(26, 65);
            this.flightName.Name = "flightName";
            this.flightName.Size = new System.Drawing.Size(153, 24);
            this.flightName.TabIndex = 0;
            this.flightName.Text = "Flight Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mail_text);
            this.groupBox1.Controls.Add(this.phone_text);
            this.groupBox1.Controls.Add(this.lName_text);
            this.groupBox1.Controls.Add(this.fName_text);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.lName);
            this.groupBox1.Controls.Add(this.fName);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passenger Info";
            // 
            // mail_text
            // 
            this.mail_text.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_text.Location = new System.Drawing.Point(226, 287);
            this.mail_text.Name = "mail_text";
            this.mail_text.Size = new System.Drawing.Size(281, 26);
            this.mail_text.TabIndex = 1;
            // 
            // phone_text
            // 
            this.phone_text.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_text.Location = new System.Drawing.Point(226, 215);
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(281, 26);
            this.phone_text.TabIndex = 1;
            // 
            // lName_text
            // 
            this.lName_text.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName_text.Location = new System.Drawing.Point(226, 137);
            this.lName_text.Name = "lName_text";
            this.lName_text.Size = new System.Drawing.Size(281, 26);
            this.lName_text.TabIndex = 1;
            // 
            // fName_text
            // 
            this.fName_text.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName_text.Location = new System.Drawing.Point(226, 66);
            this.fName_text.Name = "fName_text";
            this.fName_text.Size = new System.Drawing.Size(281, 26);
            this.fName_text.TabIndex = 1;
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(21, 286);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(192, 24);
            this.mail.TabIndex = 0;
            this.mail.Text = "E-Mail Address";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(21, 214);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(166, 24);
            this.phone.TabIndex = 0;
            this.phone.Text = "Phone Number";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(21, 136);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(127, 24);
            this.lName.TabIndex = 0;
            this.lName.Text = "Last Name";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(21, 65);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(140, 24);
            this.fName.TabIndex = 0;
            this.fName.Text = "First Name";
            // 
            // navBar
            // 
            this.navBar.Controls.Add(this.booking);
            this.navBar.Controls.Add(this.ticket);
            this.navBar.Controls.Add(this.flights);
            this.navBar.Controls.Add(this.newFlight);
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.SelectedIndex = 0;
            this.navBar.Size = new System.Drawing.Size(1143, 656);
            this.navBar.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.HeaderText = "Schedule";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 110;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 8;
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 8;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // NameFlight
            // 
            this.NameFlight.HeaderText = "Flight ID";
            this.NameFlight.MinimumWidth = 8;
            this.NameFlight.Name = "NameFlight";
            this.NameFlight.ReadOnly = true;
            this.NameFlight.Width = 80;
            // 
            // Stopovers
            // 
            this.Stopovers.HeaderText = "Stopovers";
            this.Stopovers.MinimumWidth = 8;
            this.Stopovers.Name = "Stopovers";
            this.Stopovers.ReadOnly = true;
            // 
            // AName
            // 
            this.AName.HeaderText = "Airplane Name";
            this.AName.MinimumWidth = 8;
            this.AName.Name = "AName";
            this.AName.ReadOnly = true;
            this.AName.Width = 150;
            // 
            // meeeal
            // 
            this.meeeal.HeaderText = "Meal";
            this.meeeal.MinimumWidth = 8;
            this.meeeal.Name = "meeeal";
            this.meeeal.ReadOnly = true;
            this.meeeal.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 655);
            this.Controls.Add(this.navBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newFlight.ResumeLayout(false);
            this.newFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flights.ResumeLayout(false);
            this.flights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ticket.ResumeLayout(false);
            this.ticket.PerformLayout();
            this.booking.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.navBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage newFlight;
        private System.Windows.Forms.TabPage flights;
        private System.Windows.Forms.TabPage ticket;
        private System.Windows.Forms.TabPage booking;
        private System.Windows.Forms.Button book_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox flightName_drop;
        private System.Windows.Forms.TextBox available;
        private System.Windows.Forms.ComboBox align_box;
        private System.Windows.Forms.ComboBox row_box;
        private System.Windows.Forms.DateTimePicker departure_pick;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label seatAlign;
        private System.Windows.Forms.Label seatRow;
        private System.Windows.Forms.Label dateOdep;
        private System.Windows.Forms.Label flightName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mail_text;
        private System.Windows.Forms.TextBox phone_text;
        private System.Windows.Forms.TextBox lName_text;
        private System.Windows.Forms.TextBox fName_text;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.TabControl navBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dep;
        private System.Windows.Forms.Label fID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox passNames_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox mealYN;
        private System.Windows.Forms.TextBox nto;
        private System.Windows.Forms.TextBox stop;
        private System.Windows.Forms.TextBox row_text;
        private System.Windows.Forms.TextBox cap_text;
        private System.Windows.Forms.TextBox nairname;
        private System.Windows.Forms.TextBox fID_text;
        private System.Windows.Forms.TextBox nfrom;
        private System.Windows.Forms.Button addF_button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar narr;
        private System.Windows.Forms.MonthCalendar ndep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stopovers;
        private System.Windows.Forms.DataGridViewTextBoxColumn AName;
        private System.Windows.Forms.DataGridViewTextBoxColumn meeeal;
    }
}

