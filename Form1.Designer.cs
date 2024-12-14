namespace Trabalho_Alojamento_POO
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
            TabPage tp_room;
            Remove_room_button = new Button();
            tb_remove_add_room = new TextBox();
            label7 = new Label();
            Search_room_button = new Button();
            tb_id_search_room = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Add_room_button = new Button();
            tb_floor_add_room = new TextBox();
            tb_area_add_room = new TextBox();
            tb_capacity_add_room = new TextBox();
            design = new TabControl();
            who = new TabPage();
            Client = new Button();
            tp_client = new TabPage();
            Remove_client_button = new Button();
            tb_fiscal_number_remove_client = new TextBox();
            label6 = new Label();
            search_client_button = new Button();
            tb_fiscal_number_search_client = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Add_client_button = new Button();
            tb_fiscal_number_add_client = new TextBox();
            tb_sex_add_client = new TextBox();
            tb_name_add_client = new TextBox();
            tb_age_add_client = new TextBox();
            tp_employee = new TabPage();
            label14 = new Label();
            tb_section_add_employee = new TextBox();
            label13 = new Label();
            tb_position_add_employee = new TextBox();
            Remove_employee_button = new Button();
            tb_employee_id_remove_employee = new TextBox();
            lb_employee_remove = new Label();
            Search_employee_button = new Button();
            tb_employee_id_search_employee = new TextBox();
            lb_employee_id_search = new Label();
            lb_employee_sex_add = new Label();
            lb_employee_name_add = new Label();
            lb_employee_age_add = new Label();
            Add_employee_button = new Button();
            tb_sex_add_employee = new TextBox();
            tb_name_add_employee = new TextBox();
            tb_age_add_employee = new TextBox();
            tp_villa = new TabPage();
            cb_living_room = new CheckBox();
            cb_sofa_bed = new CheckBox();
            cb_kitchen = new CheckBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            Remove_villa_button = new Button();
            tb_id_remove_villa = new TextBox();
            label15 = new Label();
            Search_villa_button = new Button();
            tb_id_search_villa = new TextBox();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            Add_villa_button = new Button();
            tb_area_add_villa = new TextBox();
            tb_capacity_add_villa = new TextBox();
            Reservations = new TabPage();
            remove_reservation_button = new Button();
            tb_reservation_remove = new TextBox();
            label17 = new Label();
            search_reservation_button = new Button();
            tb_reservation_search = new TextBox();
            label24 = new Label();
            add_reservation_button = new Button();
            lb_fiscal_number = new Label();
            lb_employee_id = new Label();
            lb_accommodation_ID = new Label();
            tb_fiscal_number_reservation = new TextBox();
            tb_employee_id_reservation = new TextBox();
            tb_accomodation_ID_reservation = new TextBox();
            monthCalendar1 = new MonthCalendar();
            tp_room = new TabPage();
            tp_room.SuspendLayout();
            design.SuspendLayout();
            who.SuspendLayout();
            tp_client.SuspendLayout();
            tp_employee.SuspendLayout();
            tp_villa.SuspendLayout();
            Reservations.SuspendLayout();
            SuspendLayout();
            // 
            // tp_room
            // 
            tp_room.Controls.Add(Remove_room_button);
            tp_room.Controls.Add(tb_remove_add_room);
            tp_room.Controls.Add(label7);
            tp_room.Controls.Add(Search_room_button);
            tp_room.Controls.Add(tb_id_search_room);
            tp_room.Controls.Add(label8);
            tp_room.Controls.Add(label9);
            tp_room.Controls.Add(label10);
            tp_room.Controls.Add(label11);
            tp_room.Controls.Add(Add_room_button);
            tp_room.Controls.Add(tb_floor_add_room);
            tp_room.Controls.Add(tb_area_add_room);
            tp_room.Controls.Add(tb_capacity_add_room);
            tp_room.Location = new Point(4, 29);
            tp_room.Name = "tp_room";
            tp_room.Size = new Size(768, 393);
            tp_room.TabIndex = 3;
            tp_room.Text = "Room_management";
            tp_room.UseVisualStyleBackColor = true;
            // 
            // Remove_room_button
            // 
            Remove_room_button.Location = new Point(428, 275);
            Remove_room_button.Name = "Remove_room_button";
            Remove_room_button.Size = new Size(94, 29);
            Remove_room_button.TabIndex = 44;
            Remove_room_button.Text = "Remove";
            Remove_room_button.UseVisualStyleBackColor = true;
            Remove_room_button.Click += Remove_room_button_Click;
            // 
            // tb_remove_add_room
            // 
            tb_remove_add_room.Location = new Point(207, 277);
            tb_remove_add_room.Name = "tb_remove_add_room";
            tb_remove_add_room.Size = new Size(193, 27);
            tb_remove_add_room.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 280);
            label7.Name = "label7";
            label7.Size = new Size(22, 20);
            label7.TabIndex = 42;
            label7.Text = "Id";
            // 
            // Search_room_button
            // 
            Search_room_button.Location = new Point(428, 211);
            Search_room_button.Name = "Search_room_button";
            Search_room_button.Size = new Size(94, 29);
            Search_room_button.TabIndex = 41;
            Search_room_button.Text = "Search";
            Search_room_button.UseVisualStyleBackColor = true;
            Search_room_button.Click += Search_room_button_Click;
            // 
            // tb_id_search_room
            // 
            tb_id_search_room.Location = new Point(207, 211);
            tb_id_search_room.Name = "tb_id_search_room";
            tb_id_search_room.Size = new Size(193, 27);
            tb_id_search_room.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(176, 210);
            label8.Name = "label8";
            label8.Size = new Size(22, 20);
            label8.TabIndex = 39;
            label8.Text = "Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(155, 144);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 38;
            label9.Text = "Floor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(158, 115);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 37;
            label10.Text = "Area";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(132, 82);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 36;
            label11.Text = "Capacity";
            // 
            // Add_room_button
            // 
            Add_room_button.Location = new Point(428, 139);
            Add_room_button.Name = "Add_room_button";
            Add_room_button.Size = new Size(94, 29);
            Add_room_button.TabIndex = 34;
            Add_room_button.Text = "Add";
            Add_room_button.UseVisualStyleBackColor = true;
            Add_room_button.Click += Add_room_button_Click;
            // 
            // tb_floor_add_room
            // 
            tb_floor_add_room.Location = new Point(207, 141);
            tb_floor_add_room.Name = "tb_floor_add_room";
            tb_floor_add_room.Size = new Size(193, 27);
            tb_floor_add_room.TabIndex = 33;
            // 
            // tb_area_add_room
            // 
            tb_area_add_room.Location = new Point(207, 108);
            tb_area_add_room.Name = "tb_area_add_room";
            tb_area_add_room.Size = new Size(193, 27);
            tb_area_add_room.TabIndex = 32;
            // 
            // tb_capacity_add_room
            // 
            tb_capacity_add_room.Location = new Point(207, 75);
            tb_capacity_add_room.Name = "tb_capacity_add_room";
            tb_capacity_add_room.Size = new Size(193, 27);
            tb_capacity_add_room.TabIndex = 31;
            // 
            // design
            // 
            design.Controls.Add(who);
            design.Controls.Add(tp_client);
            design.Controls.Add(tp_employee);
            design.Controls.Add(tp_room);
            design.Controls.Add(tp_villa);
            design.Controls.Add(Reservations);
            design.Location = new Point(12, 12);
            design.Name = "design";
            design.SelectedIndex = 0;
            design.Size = new Size(776, 426);
            design.TabIndex = 1;
            // 
            // who
            // 
            who.BackColor = Color.Moccasin;
            who.Controls.Add(Client);
            who.Location = new Point(4, 29);
            who.Name = "who";
            who.Padding = new Padding(3);
            who.Size = new Size(768, 393);
            who.TabIndex = 1;
            who.Text = "Who";
            // 
            // Client
            // 
            Client.Location = new Point(219, 112);
            Client.Name = "Client";
            Client.Size = new Size(94, 29);
            Client.TabIndex = 0;
            Client.Text = "button1";
            Client.UseVisualStyleBackColor = true;
            // 
            // tp_client
            // 
            tp_client.Controls.Add(Remove_client_button);
            tp_client.Controls.Add(tb_fiscal_number_remove_client);
            tp_client.Controls.Add(label6);
            tp_client.Controls.Add(search_client_button);
            tp_client.Controls.Add(tb_fiscal_number_search_client);
            tp_client.Controls.Add(label5);
            tp_client.Controls.Add(label4);
            tp_client.Controls.Add(label3);
            tp_client.Controls.Add(label2);
            tp_client.Controls.Add(label1);
            tp_client.Controls.Add(Add_client_button);
            tp_client.Controls.Add(tb_fiscal_number_add_client);
            tp_client.Controls.Add(tb_sex_add_client);
            tp_client.Controls.Add(tb_name_add_client);
            tp_client.Controls.Add(tb_age_add_client);
            tp_client.Location = new Point(4, 29);
            tp_client.Name = "tp_client";
            tp_client.Padding = new Padding(3);
            tp_client.Size = new Size(768, 393);
            tp_client.TabIndex = 0;
            tp_client.Text = "Client_management";
            tp_client.UseVisualStyleBackColor = true;
            // 
            // Remove_client_button
            // 
            Remove_client_button.Location = new Point(374, 254);
            Remove_client_button.Name = "Remove_client_button";
            Remove_client_button.Size = new Size(94, 29);
            Remove_client_button.TabIndex = 14;
            Remove_client_button.Text = "Remove";
            Remove_client_button.UseVisualStyleBackColor = true;
            Remove_client_button.Click += Remove_button_Click;
            // 
            // tb_fiscal_number_remove_client
            // 
            tb_fiscal_number_remove_client.Location = new Point(153, 256);
            tb_fiscal_number_remove_client.Name = "tb_fiscal_number_remove_client";
            tb_fiscal_number_remove_client.Size = new Size(193, 27);
            tb_fiscal_number_remove_client.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 263);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 12;
            label6.Text = "Fiscal Number";
            // 
            // search_client_button
            // 
            search_client_button.Location = new Point(374, 190);
            search_client_button.Name = "search_client_button";
            search_client_button.Size = new Size(94, 29);
            search_client_button.TabIndex = 11;
            search_client_button.Text = "Search";
            search_client_button.UseVisualStyleBackColor = true;
            search_client_button.Click += Search_button_Click;
            // 
            // tb_fiscal_number_search_client
            // 
            tb_fiscal_number_search_client.Location = new Point(153, 190);
            tb_fiscal_number_search_client.Name = "tb_fiscal_number_search_client";
            tb_fiscal_number_search_client.Size = new Size(193, 27);
            tb_fiscal_number_search_client.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 197);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 9;
            label5.Text = "Fiscal Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 127);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 8;
            label4.Text = "Fiscal Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 94);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 7;
            label3.Text = "sex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 61);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 28);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 5;
            label1.Text = "age";
            // 
            // Add_client_button
            // 
            Add_client_button.Location = new Point(374, 118);
            Add_client_button.Name = "Add_client_button";
            Add_client_button.Size = new Size(94, 29);
            Add_client_button.TabIndex = 4;
            Add_client_button.Text = "Add";
            Add_client_button.UseVisualStyleBackColor = true;
            Add_client_button.Click += Add_button_Click;
            // 
            // tb_fiscal_number_add_client
            // 
            tb_fiscal_number_add_client.Location = new Point(153, 120);
            tb_fiscal_number_add_client.Name = "tb_fiscal_number_add_client";
            tb_fiscal_number_add_client.Size = new Size(193, 27);
            tb_fiscal_number_add_client.TabIndex = 3;
            // 
            // tb_sex_add_client
            // 
            tb_sex_add_client.Location = new Point(153, 87);
            tb_sex_add_client.Name = "tb_sex_add_client";
            tb_sex_add_client.Size = new Size(193, 27);
            tb_sex_add_client.TabIndex = 2;
            // 
            // tb_name_add_client
            // 
            tb_name_add_client.Location = new Point(153, 54);
            tb_name_add_client.Name = "tb_name_add_client";
            tb_name_add_client.Size = new Size(193, 27);
            tb_name_add_client.TabIndex = 1;
            // 
            // tb_age_add_client
            // 
            tb_age_add_client.Location = new Point(153, 21);
            tb_age_add_client.Name = "tb_age_add_client";
            tb_age_add_client.Size = new Size(193, 27);
            tb_age_add_client.TabIndex = 0;
            // 
            // tp_employee
            // 
            tp_employee.Controls.Add(label14);
            tp_employee.Controls.Add(tb_section_add_employee);
            tp_employee.Controls.Add(label13);
            tp_employee.Controls.Add(tb_position_add_employee);
            tp_employee.Controls.Add(Remove_employee_button);
            tp_employee.Controls.Add(tb_employee_id_remove_employee);
            tp_employee.Controls.Add(lb_employee_remove);
            tp_employee.Controls.Add(Search_employee_button);
            tp_employee.Controls.Add(tb_employee_id_search_employee);
            tp_employee.Controls.Add(lb_employee_id_search);
            tp_employee.Controls.Add(lb_employee_sex_add);
            tp_employee.Controls.Add(lb_employee_name_add);
            tp_employee.Controls.Add(lb_employee_age_add);
            tp_employee.Controls.Add(Add_employee_button);
            tp_employee.Controls.Add(tb_sex_add_employee);
            tp_employee.Controls.Add(tb_name_add_employee);
            tp_employee.Controls.Add(tb_age_add_employee);
            tp_employee.Location = new Point(4, 29);
            tp_employee.Name = "tp_employee";
            tp_employee.Padding = new Padding(3);
            tp_employee.Size = new Size(768, 393);
            tp_employee.TabIndex = 2;
            tp_employee.Text = "Employee_management";
            tp_employee.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(63, 162);
            label14.Name = "label14";
            label14.Size = new Size(58, 20);
            label14.TabIndex = 33;
            label14.Text = "Section";
            // 
            // tb_section_add_employee
            // 
            tb_section_add_employee.Location = new Point(185, 162);
            tb_section_add_employee.Name = "tb_section_add_employee";
            tb_section_add_employee.Size = new Size(193, 27);
            tb_section_add_employee.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(62, 129);
            label13.Name = "label13";
            label13.Size = new Size(61, 20);
            label13.TabIndex = 31;
            label13.Text = "Position";
            // 
            // tb_position_add_employee
            // 
            tb_position_add_employee.Location = new Point(184, 129);
            tb_position_add_employee.Name = "tb_position_add_employee";
            tb_position_add_employee.Size = new Size(193, 27);
            tb_position_add_employee.TabIndex = 30;
            // 
            // Remove_employee_button
            // 
            Remove_employee_button.Location = new Point(405, 334);
            Remove_employee_button.Name = "Remove_employee_button";
            Remove_employee_button.Size = new Size(94, 29);
            Remove_employee_button.TabIndex = 29;
            Remove_employee_button.Text = "Remove";
            Remove_employee_button.UseVisualStyleBackColor = true;
            Remove_employee_button.Click += Remove_employee_button_Click;
            // 
            // tb_employee_id_remove_employee
            // 
            tb_employee_id_remove_employee.Location = new Point(184, 336);
            tb_employee_id_remove_employee.Name = "tb_employee_id_remove_employee";
            tb_employee_id_remove_employee.Size = new Size(193, 27);
            tb_employee_id_remove_employee.TabIndex = 28;
            // 
            // lb_employee_remove
            // 
            lb_employee_remove.AutoSize = true;
            lb_employee_remove.Location = new Point(62, 343);
            lb_employee_remove.Name = "lb_employee_remove";
            lb_employee_remove.Size = new Size(94, 20);
            lb_employee_remove.TabIndex = 27;
            lb_employee_remove.Text = "Employee ID";
            // 
            // Search_employee_button
            // 
            Search_employee_button.Location = new Point(405, 287);
            Search_employee_button.Name = "Search_employee_button";
            Search_employee_button.Size = new Size(94, 29);
            Search_employee_button.TabIndex = 26;
            Search_employee_button.Text = "Search";
            Search_employee_button.UseVisualStyleBackColor = true;
            Search_employee_button.Click += Search_employee_button_Click;
            // 
            // tb_employee_id_search_employee
            // 
            tb_employee_id_search_employee.Location = new Point(184, 287);
            tb_employee_id_search_employee.Name = "tb_employee_id_search_employee";
            tb_employee_id_search_employee.Size = new Size(193, 27);
            tb_employee_id_search_employee.TabIndex = 25;
            // 
            // lb_employee_id_search
            // 
            lb_employee_id_search.AutoSize = true;
            lb_employee_id_search.Location = new Point(62, 290);
            lb_employee_id_search.Name = "lb_employee_id_search";
            lb_employee_id_search.Size = new Size(94, 20);
            lb_employee_id_search.TabIndex = 24;
            lb_employee_id_search.Text = "Employee ID";
            // 
            // lb_employee_sex_add
            // 
            lb_employee_sex_add.AutoSize = true;
            lb_employee_sex_add.Location = new Point(109, 103);
            lb_employee_sex_add.Name = "lb_employee_sex_add";
            lb_employee_sex_add.Size = new Size(30, 20);
            lb_employee_sex_add.TabIndex = 22;
            lb_employee_sex_add.Text = "sex";
            // 
            // lb_employee_name_add
            // 
            lb_employee_name_add.AutoSize = true;
            lb_employee_name_add.Location = new Point(109, 70);
            lb_employee_name_add.Name = "lb_employee_name_add";
            lb_employee_name_add.Size = new Size(46, 20);
            lb_employee_name_add.TabIndex = 21;
            lb_employee_name_add.Text = "name";
            // 
            // lb_employee_age_add
            // 
            lb_employee_age_add.AutoSize = true;
            lb_employee_age_add.Location = new Point(122, 37);
            lb_employee_age_add.Name = "lb_employee_age_add";
            lb_employee_age_add.Size = new Size(34, 20);
            lb_employee_age_add.TabIndex = 20;
            lb_employee_age_add.Text = "age";
            // 
            // Add_employee_button
            // 
            Add_employee_button.Location = new Point(406, 160);
            Add_employee_button.Name = "Add_employee_button";
            Add_employee_button.Size = new Size(94, 29);
            Add_employee_button.TabIndex = 19;
            Add_employee_button.Text = "Add";
            Add_employee_button.UseVisualStyleBackColor = true;
            Add_employee_button.Click += Add_employee_button_Click;
            // 
            // tb_sex_add_employee
            // 
            tb_sex_add_employee.Location = new Point(184, 96);
            tb_sex_add_employee.Name = "tb_sex_add_employee";
            tb_sex_add_employee.Size = new Size(193, 27);
            tb_sex_add_employee.TabIndex = 17;
            // 
            // tb_name_add_employee
            // 
            tb_name_add_employee.Location = new Point(184, 63);
            tb_name_add_employee.Name = "tb_name_add_employee";
            tb_name_add_employee.Size = new Size(193, 27);
            tb_name_add_employee.TabIndex = 16;
            // 
            // tb_age_add_employee
            // 
            tb_age_add_employee.Location = new Point(184, 30);
            tb_age_add_employee.Name = "tb_age_add_employee";
            tb_age_add_employee.Size = new Size(193, 27);
            tb_age_add_employee.TabIndex = 15;
            // 
            // tp_villa
            // 
            tp_villa.Controls.Add(cb_living_room);
            tp_villa.Controls.Add(cb_sofa_bed);
            tp_villa.Controls.Add(cb_kitchen);
            tp_villa.Controls.Add(label23);
            tp_villa.Controls.Add(label22);
            tp_villa.Controls.Add(label21);
            tp_villa.Controls.Add(Remove_villa_button);
            tp_villa.Controls.Add(tb_id_remove_villa);
            tp_villa.Controls.Add(label15);
            tp_villa.Controls.Add(Search_villa_button);
            tp_villa.Controls.Add(tb_id_search_villa);
            tp_villa.Controls.Add(label16);
            tp_villa.Controls.Add(label18);
            tp_villa.Controls.Add(label19);
            tp_villa.Controls.Add(Add_villa_button);
            tp_villa.Controls.Add(tb_area_add_villa);
            tp_villa.Controls.Add(tb_capacity_add_villa);
            tp_villa.Location = new Point(4, 29);
            tp_villa.Name = "tp_villa";
            tp_villa.Size = new Size(768, 393);
            tp_villa.TabIndex = 4;
            tp_villa.Text = "villa_management";
            tp_villa.UseVisualStyleBackColor = true;
            // 
            // cb_living_room
            // 
            cb_living_room.AutoSize = true;
            cb_living_room.Location = new Point(214, 196);
            cb_living_room.Name = "cb_living_room";
            cb_living_room.Size = new Size(18, 17);
            cb_living_room.TabIndex = 68;
            cb_living_room.UseVisualStyleBackColor = true;
            // 
            // cb_sofa_bed
            // 
            cb_sofa_bed.AutoSize = true;
            cb_sofa_bed.Location = new Point(214, 163);
            cb_sofa_bed.Name = "cb_sofa_bed";
            cb_sofa_bed.Size = new Size(18, 17);
            cb_sofa_bed.TabIndex = 67;
            cb_sofa_bed.UseVisualStyleBackColor = true;
            // 
            // cb_kitchen
            // 
            cb_kitchen.AutoSize = true;
            cb_kitchen.Location = new Point(214, 130);
            cb_kitchen.Name = "cb_kitchen";
            cb_kitchen.Size = new Size(18, 17);
            cb_kitchen.TabIndex = 66;
            cb_kitchen.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(113, 196);
            label23.Name = "label23";
            label23.Size = new Size(92, 20);
            label23.TabIndex = 65;
            label23.Text = "Living Room";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(136, 160);
            label22.Name = "label22";
            label22.Size = new Size(69, 20);
            label22.TabIndex = 63;
            label22.Text = "Sofa Bed";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(147, 130);
            label21.Name = "label21";
            label21.Size = new Size(58, 20);
            label21.TabIndex = 61;
            label21.Text = "Kitchen";
            // 
            // Remove_villa_button
            // 
            Remove_villa_button.Location = new Point(435, 342);
            Remove_villa_button.Name = "Remove_villa_button";
            Remove_villa_button.Size = new Size(94, 29);
            Remove_villa_button.TabIndex = 59;
            Remove_villa_button.Text = "Remove";
            Remove_villa_button.UseVisualStyleBackColor = true;
            Remove_villa_button.Click += Remove_villa_button_Click;
            // 
            // tb_id_remove_villa
            // 
            tb_id_remove_villa.Location = new Point(214, 344);
            tb_id_remove_villa.Name = "tb_id_remove_villa";
            tb_id_remove_villa.Size = new Size(193, 27);
            tb_id_remove_villa.TabIndex = 58;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(183, 347);
            label15.Name = "label15";
            label15.Size = new Size(22, 20);
            label15.TabIndex = 57;
            label15.Text = "Id";
            // 
            // Search_villa_button
            // 
            Search_villa_button.Location = new Point(435, 300);
            Search_villa_button.Name = "Search_villa_button";
            Search_villa_button.Size = new Size(94, 29);
            Search_villa_button.TabIndex = 56;
            Search_villa_button.Text = "Search";
            Search_villa_button.UseVisualStyleBackColor = true;
            Search_villa_button.Click += Search_villa_button_Click;
            // 
            // tb_id_search_villa
            // 
            tb_id_search_villa.Location = new Point(214, 300);
            tb_id_search_villa.Name = "tb_id_search_villa";
            tb_id_search_villa.Size = new Size(193, 27);
            tb_id_search_villa.TabIndex = 55;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(183, 299);
            label16.Name = "label16";
            label16.Size = new Size(22, 20);
            label16.TabIndex = 54;
            label16.Text = "Id";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(165, 101);
            label18.Name = "label18";
            label18.Size = new Size(40, 20);
            label18.TabIndex = 52;
            label18.Text = "Area";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(139, 68);
            label19.Name = "label19";
            label19.Size = new Size(66, 20);
            label19.TabIndex = 51;
            label19.Text = "Capacity";
            // 
            // Add_villa_button
            // 
            Add_villa_button.Location = new Point(435, 196);
            Add_villa_button.Name = "Add_villa_button";
            Add_villa_button.Size = new Size(94, 29);
            Add_villa_button.TabIndex = 49;
            Add_villa_button.Text = "Add";
            Add_villa_button.UseVisualStyleBackColor = true;
            Add_villa_button.Click += Add_villa_button_Click;
            // 
            // tb_area_add_villa
            // 
            tb_area_add_villa.Location = new Point(214, 94);
            tb_area_add_villa.Name = "tb_area_add_villa";
            tb_area_add_villa.Size = new Size(193, 27);
            tb_area_add_villa.TabIndex = 47;
            // 
            // tb_capacity_add_villa
            // 
            tb_capacity_add_villa.Location = new Point(214, 61);
            tb_capacity_add_villa.Name = "tb_capacity_add_villa";
            tb_capacity_add_villa.Size = new Size(193, 27);
            tb_capacity_add_villa.TabIndex = 46;
            // 
            // Reservations
            // 
            Reservations.Controls.Add(remove_reservation_button);
            Reservations.Controls.Add(tb_reservation_remove);
            Reservations.Controls.Add(label17);
            Reservations.Controls.Add(search_reservation_button);
            Reservations.Controls.Add(tb_reservation_search);
            Reservations.Controls.Add(label24);
            Reservations.Controls.Add(add_reservation_button);
            Reservations.Controls.Add(lb_fiscal_number);
            Reservations.Controls.Add(lb_employee_id);
            Reservations.Controls.Add(lb_accommodation_ID);
            Reservations.Controls.Add(tb_fiscal_number_reservation);
            Reservations.Controls.Add(tb_employee_id_reservation);
            Reservations.Controls.Add(tb_accomodation_ID_reservation);
            Reservations.Controls.Add(monthCalendar1);
            Reservations.Location = new Point(4, 29);
            Reservations.Name = "Reservations";
            Reservations.Padding = new Padding(3);
            Reservations.Size = new Size(768, 393);
            Reservations.TabIndex = 5;
            Reservations.Text = "Reservations";
            Reservations.UseVisualStyleBackColor = true;
            // 
            // remove_reservation_button
            // 
            remove_reservation_button.Location = new Point(641, 332);
            remove_reservation_button.Name = "remove_reservation_button";
            remove_reservation_button.Size = new Size(94, 29);
            remove_reservation_button.TabIndex = 53;
            remove_reservation_button.Text = "Remove";
            remove_reservation_button.UseVisualStyleBackColor = true;
            // 
            // tb_reservation_remove
            // 
            tb_reservation_remove.Location = new Point(420, 334);
            tb_reservation_remove.Name = "tb_reservation_remove";
            tb_reservation_remove.Size = new Size(193, 27);
            tb_reservation_remove.TabIndex = 52;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(389, 337);
            label17.Name = "label17";
            label17.Size = new Size(22, 20);
            label17.TabIndex = 51;
            label17.Text = "Id";
            // 
            // search_reservation_button
            // 
            search_reservation_button.Location = new Point(641, 268);
            search_reservation_button.Name = "search_reservation_button";
            search_reservation_button.Size = new Size(94, 29);
            search_reservation_button.TabIndex = 50;
            search_reservation_button.Text = "Search";
            search_reservation_button.UseVisualStyleBackColor = true;
            // 
            // tb_reservation_search
            // 
            tb_reservation_search.Location = new Point(420, 268);
            tb_reservation_search.Name = "tb_reservation_search";
            tb_reservation_search.Size = new Size(193, 27);
            tb_reservation_search.TabIndex = 49;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(389, 267);
            label24.Name = "label24";
            label24.Size = new Size(22, 20);
            label24.TabIndex = 48;
            label24.Text = "Id";
            // 
            // add_reservation_button
            // 
            add_reservation_button.Location = new Point(167, 145);
            add_reservation_button.Name = "add_reservation_button";
            add_reservation_button.Size = new Size(94, 29);
            add_reservation_button.TabIndex = 46;
            add_reservation_button.Text = "Add";
            add_reservation_button.UseVisualStyleBackColor = true;
            add_reservation_button.Click += add_reservation_button_Click;
            // 
            // lb_fiscal_number
            // 
            lb_fiscal_number.AutoSize = true;
            lb_fiscal_number.Location = new Point(58, 107);
            lb_fiscal_number.Name = "lb_fiscal_number";
            lb_fiscal_number.Size = new Size(103, 20);
            lb_fiscal_number.TabIndex = 44;
            lb_fiscal_number.Text = "Fiscal Number";
            // 
            // lb_employee_id
            // 
            lb_employee_id.AutoSize = true;
            lb_employee_id.Location = new Point(67, 70);
            lb_employee_id.Name = "lb_employee_id";
            lb_employee_id.Size = new Size(94, 20);
            lb_employee_id.TabIndex = 43;
            lb_employee_id.Text = "Employee ID";
            // 
            // lb_accommodation_ID
            // 
            lb_accommodation_ID.AutoSize = true;
            lb_accommodation_ID.Location = new Point(22, 41);
            lb_accommodation_ID.Name = "lb_accommodation_ID";
            lb_accommodation_ID.Size = new Size(139, 20);
            lb_accommodation_ID.TabIndex = 42;
            lb_accommodation_ID.Text = "Accommodation ID";
            // 
            // tb_fiscal_number_reservation
            // 
            tb_fiscal_number_reservation.Location = new Point(167, 100);
            tb_fiscal_number_reservation.Name = "tb_fiscal_number_reservation";
            tb_fiscal_number_reservation.Size = new Size(193, 27);
            tb_fiscal_number_reservation.TabIndex = 40;
            // 
            // tb_employee_id_reservation
            // 
            tb_employee_id_reservation.Location = new Point(167, 67);
            tb_employee_id_reservation.Name = "tb_employee_id_reservation";
            tb_employee_id_reservation.Size = new Size(193, 27);
            tb_employee_id_reservation.TabIndex = 39;
            // 
            // tb_accomodation_ID_reservation
            // 
            tb_accomodation_ID_reservation.Location = new Point(167, 34);
            tb_accomodation_ID_reservation.Name = "tb_accomodation_ID_reservation";
            tb_accomodation_ID_reservation.Size = new Size(193, 27);
            tb_accomodation_ID_reservation.TabIndex = 38;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(456, 29);
            monthCalendar1.MaxSelectionCount = 31;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(design);
            Name = "Form1";
            Text = "Form1";
            tp_room.ResumeLayout(false);
            tp_room.PerformLayout();
            design.ResumeLayout(false);
            who.ResumeLayout(false);
            tp_client.ResumeLayout(false);
            tp_client.PerformLayout();
            tp_employee.ResumeLayout(false);
            tp_employee.PerformLayout();
            tp_villa.ResumeLayout(false);
            tp_villa.PerformLayout();
            Reservations.ResumeLayout(false);
            Reservations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl design;
        private TabPage tp_client;
        private TextBox tb_age_add_client;
        private TabPage who;
        private TextBox tb_name_add_client;
        private TextBox tb_sex_add_client;
        private TextBox tb_fiscal_number_add_client;
        private Button Add_client_button;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Button search_client_button;
        private TextBox tb_fiscal_number_search_client;
        private Label label5;
        private Button Remove_client_button;
        private TextBox tb_fiscal_number_remove_client;
        private TabPage tp_employee;
        private Button Client;
        private Button Remove_employee_button;
        private TextBox tb_employee_id_remove_employee;
        private Label lb_employee_remove;
        private Button Search_employee_button;
        private TextBox tb_employee_id_search_employee;
        private Label lb_employee_id_search;
        private Label lb_employee_sex_add;
        private Label lb_employee_name_add;
        private Label lb_employee_age_add;
        private Button Add_employee_button;
        private TextBox tb_sex_add_employee;
        private TextBox tb_name_add_employee;
        private TextBox tb_age_add_employee;
        private Button Remove_room_button;
        private TextBox tb_remove_add_room;
        private Label label7;
        private Button Search_room_button;
        private TextBox tb_id_search_room;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button Add_room_button;
        private TextBox tb_floor_add_room;
        private TextBox tb_area_add_room;
        private TextBox tb_capacity_add_room;
        private Label label13;
        private TextBox tb_position_add_employee;
        private Label label14;
        private TextBox tb_section_add_employee;
        private TabPage tp_villa;
        private Label label23;
        private Label label22;
        private Label label21;
        private Button Remove_villa_button;
        private TextBox tb_id_remove_villa;
        private Label label15;
        private Button Search_villa_button;
        private TextBox tb_id_search_villa;
        private Label label16;
        private Label label18;
        private Label label19;
        private Button Add_villa_button;
        private TextBox tb_area_add_villa;
        private TextBox tb_capacity_add_villa;
        private CheckBox cb_living_room;
        private CheckBox cb_sofa_bed;
        private CheckBox cb_kitchen;
        private TabPage Reservations;
        private MonthCalendar monthCalendar1;
        private Label lb_fiscal_number;
        private Label lb_employee_id;
        private Label lb_accommodation_ID;
        private TextBox tb_fiscal_number_reservation;
        private TextBox tb_employee_id_reservation;
        private TextBox tb_accomodation_ID_reservation;
        private Button remove_reservation_button;
        private TextBox tb_reservation_remove;
        private Label label17;
        private Button search_reservation_button;
        private TextBox tb_reservation_search;
        private Label label24;
        private Button add_reservation_button;
    }
}
