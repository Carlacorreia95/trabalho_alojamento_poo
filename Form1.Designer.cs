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
            tabControl1 = new TabControl();
            tb_ = new TabPage();
            button1 = new Button();
            fiscal_number = new TextBox();
            sex = new TextBox();
            tb_name = new TextBox();
            tb_age = new TextBox();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tb_.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tb_);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 1;
            // 
            // tb_
            // 
            tb_.Controls.Add(label4);
            tb_.Controls.Add(label3);
            tb_.Controls.Add(label2);
            tb_.Controls.Add(label1);
            tb_.Controls.Add(button1);
            tb_.Controls.Add(fiscal_number);
            tb_.Controls.Add(sex);
            tb_.Controls.Add(tb_name);
            tb_.Controls.Add(tb_age);
            tb_.Location = new Point(4, 29);
            tb_.Name = "tb_";
            tb_.Padding = new Padding(3);
            tb_.Size = new Size(768, 393);
            tb_.TabIndex = 0;
            tb_.Text = "Client";
            tb_.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(377, 120);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // fiscal_number
            // 
            fiscal_number.Location = new Point(153, 120);
            fiscal_number.Name = "fiscal_number";
            fiscal_number.Size = new Size(193, 27);
            fiscal_number.TabIndex = 3;
            // 
            // sex
            // 
            sex.Location = new Point(153, 87);
            sex.Name = "sex";
            sex.Size = new Size(193, 27);
            sex.TabIndex = 2;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(153, 54);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(193, 27);
            tb_name.TabIndex = 1;
            tb_name.TextChanged += tb_name_TextChanged;
            // 
            // tb_age
            // 
            tb_age.Location = new Point(153, 21);
            tb_age.Name = "tb_age";
            tb_age.Size = new Size(193, 27);
            tb_age.TabIndex = 0;
            tb_age.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 28);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 5;
            label1.Text = "age";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 61);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 94);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 7;
            label3.Text = "sex";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 120);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 8;
            label4.Text = "Fiscal Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tb_.ResumeLayout(false);
            tb_.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tb_;
        private TextBox tb_age;
        private TabPage tabPage2;
        private TextBox tb_name;
        private TextBox sex;
        private TextBox fiscal_number;
        private Button button1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
