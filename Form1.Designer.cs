namespace HospitalSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bloodBox = new System.Windows.Forms.ComboBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.natIDBox = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.bloodTyp = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.residence = new System.Windows.Forms.Label();
            this.natID = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.showBtn = new System.Windows.Forms.Button();
            this.showlbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hdbloodTypBox = new System.Windows.Forms.ComboBox();
            this.hdfemale = new System.Windows.Forms.RadioButton();
            this.hdmale = new System.Windows.Forms.RadioButton();
            this.hdnatIDBox = new System.Windows.Forms.TextBox();
            this.hdresidenceBox = new System.Windows.Forms.TextBox();
            this.hdnameBox = new System.Windows.Forms.TextBox();
            this.hdbloodTyp = new System.Windows.Forms.Label();
            this.hdgender = new System.Windows.Forms.Label();
            this.hdresidence = new System.Windows.Forms.Label();
            this.hdnatID = new System.Windows.Forms.Label();
            this.hdname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1681, 834);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.insert);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1665, 780);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert New Patient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1052, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.Color.Lavender;
            this.insert.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insert.Location = new System.Drawing.Point(1052, 558);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(409, 114);
            this.insert.TabIndex = 1;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bloodBox);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.natIDBox);
            this.groupBox1.Controls.Add(this.resBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.bloodTyp);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.residence);
            this.groupBox1.Controls.Add(this.natID);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 690);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // bloodBox
            // 
            this.bloodBox.FormattingEnabled = true;
            this.bloodBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.bloodBox.Location = new System.Drawing.Point(260, 224);
            this.bloodBox.Name = "bloodBox";
            this.bloodBox.Size = new System.Drawing.Size(242, 40);
            this.bloodBox.TabIndex = 10;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(483, 308);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(127, 36);
            this.female.TabIndex = 9;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(249, 306);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(102, 36);
            this.male.TabIndex = 8;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // natIDBox
            // 
            this.natIDBox.Location = new System.Drawing.Point(260, 141);
            this.natIDBox.Name = "natIDBox";
            this.natIDBox.Size = new System.Drawing.Size(200, 40);
            this.natIDBox.TabIndex = 7;
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(249, 404);
            this.resBox.Multiline = true;
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(390, 221);
            this.resBox.TabIndex = 6;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(260, 64);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 40);
            this.nameBox.TabIndex = 5;
            // 
            // bloodTyp
            // 
            this.bloodTyp.AutoSize = true;
            this.bloodTyp.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bloodTyp.Location = new System.Drawing.Point(37, 224);
            this.bloodTyp.Name = "bloodTyp";
            this.bloodTyp.Size = new System.Drawing.Size(147, 32);
            this.bloodTyp.TabIndex = 4;
            this.bloodTyp.Text = "Blood Type";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(37, 308);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(97, 32);
            this.gender.TabIndex = 3;
            this.gender.Text = "Gender";
            // 
            // residence
            // 
            this.residence.AutoSize = true;
            this.residence.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.residence.Location = new System.Drawing.Point(37, 404);
            this.residence.Name = "residence";
            this.residence.Size = new System.Drawing.Size(130, 32);
            this.residence.TabIndex = 2;
            this.residence.Text = "Residence";
            // 
            // natID
            // 
            this.natID.AutoSize = true;
            this.natID.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.natID.Location = new System.Drawing.Point(37, 141);
            this.natID.Name = "natID";
            this.natID.Size = new System.Drawing.Size(146, 32);
            this.natID.TabIndex = 1;
            this.natID.Text = "National ID";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(37, 67);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 32);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.showBtn);
            this.tabPage2.Controls.Add(this.showlbl);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1665, 780);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Patient Information";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(278, 30);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(150, 46);
            this.showBtn.TabIndex = 1;
            this.showBtn.Text = "Show Info";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // showlbl
            // 
            this.showlbl.AutoSize = true;
            this.showlbl.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showlbl.Location = new System.Drawing.Point(91, 37);
            this.showlbl.Name = "showlbl";
            this.showlbl.Size = new System.Drawing.Size(146, 32);
            this.showlbl.TabIndex = 0;
            this.showlbl.Text = "National ID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Salmon;
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1665, 780);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Show Patients Information";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1659, 599);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1147, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(407, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // hdbloodTypBox
            // 
            this.hdbloodTypBox.FormattingEnabled = true;
            this.hdbloodTypBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.hdbloodTypBox.Location = new System.Drawing.Point(260, 224);
            this.hdbloodTypBox.Name = "hdbloodTypBox";
            this.hdbloodTypBox.Size = new System.Drawing.Size(242, 40);
            this.hdbloodTypBox.TabIndex = 10;
            // 
            // hdfemale
            // 
            this.hdfemale.AutoSize = true;
            this.hdfemale.Location = new System.Drawing.Point(483, 308);
            this.hdfemale.Name = "hdfemale";
            this.hdfemale.Size = new System.Drawing.Size(127, 36);
            this.hdfemale.TabIndex = 9;
            this.hdfemale.TabStop = true;
            this.hdfemale.Text = "Female";
            this.hdfemale.UseVisualStyleBackColor = true;
            // 
            // hdmale
            // 
            this.hdmale.AutoSize = true;
            this.hdmale.Location = new System.Drawing.Point(249, 306);
            this.hdmale.Name = "hdmale";
            this.hdmale.Size = new System.Drawing.Size(102, 36);
            this.hdmale.TabIndex = 8;
            this.hdmale.TabStop = true;
            this.hdmale.Text = "Male";
            this.hdmale.UseVisualStyleBackColor = true;
            // 
            // hdnatIDBox
            // 
            this.hdnatIDBox.Location = new System.Drawing.Point(260, 141);
            this.hdnatIDBox.Name = "hdnatIDBox";
            this.hdnatIDBox.Size = new System.Drawing.Size(200, 40);
            this.hdnatIDBox.TabIndex = 7;
            // 
            // hdresidenceBox
            // 
            this.hdresidenceBox.Location = new System.Drawing.Point(249, 404);
            this.hdresidenceBox.Multiline = true;
            this.hdresidenceBox.Name = "hdresidenceBox";
            this.hdresidenceBox.Size = new System.Drawing.Size(390, 221);
            this.hdresidenceBox.TabIndex = 6;
            // 
            // hdnameBox
            // 
            this.hdnameBox.Location = new System.Drawing.Point(260, 64);
            this.hdnameBox.Name = "hdnameBox";
            this.hdnameBox.Size = new System.Drawing.Size(200, 40);
            this.hdnameBox.TabIndex = 5;
            // 
            // hdbloodTyp
            // 
            this.hdbloodTyp.AutoSize = true;
            this.hdbloodTyp.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hdbloodTyp.Location = new System.Drawing.Point(37, 224);
            this.hdbloodTyp.Name = "hdbloodTyp";
            this.hdbloodTyp.Size = new System.Drawing.Size(147, 32);
            this.hdbloodTyp.TabIndex = 4;
            this.hdbloodTyp.Text = "Blood Type";
            // 
            // hdgender
            // 
            this.hdgender.AutoSize = true;
            this.hdgender.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hdgender.Location = new System.Drawing.Point(37, 308);
            this.hdgender.Name = "hdgender";
            this.hdgender.Size = new System.Drawing.Size(97, 32);
            this.hdgender.TabIndex = 3;
            this.hdgender.Text = "Gender";
            // 
            // hdresidence
            // 
            this.hdresidence.AutoSize = true;
            this.hdresidence.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hdresidence.Location = new System.Drawing.Point(37, 404);
            this.hdresidence.Name = "hdresidence";
            this.hdresidence.Size = new System.Drawing.Size(130, 32);
            this.hdresidence.TabIndex = 2;
            this.hdresidence.Text = "Residence";
            // 
            // hdnatID
            // 
            this.hdnatID.AutoSize = true;
            this.hdnatID.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hdnatID.Location = new System.Drawing.Point(37, 141);
            this.hdnatID.Name = "hdnatID";
            this.hdnatID.Size = new System.Drawing.Size(146, 32);
            this.hdnatID.TabIndex = 1;
            this.hdnatID.Text = "National ID";
            // 
            // hdname
            // 
            this.hdname.AutoSize = true;
            this.hdname.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hdname.Location = new System.Drawing.Point(37, 67);
            this.hdname.Name = "hdname";
            this.hdname.Size = new System.Drawing.Size(82, 32);
            this.hdname.TabIndex = 0;
            this.hdname.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hdbloodTypBox);
            this.groupBox2.Controls.Add(this.hdfemale);
            this.groupBox2.Controls.Add(this.hdmale);
            this.groupBox2.Controls.Add(this.hdnatIDBox);
            this.groupBox2.Controls.Add(this.hdresidenceBox);
            this.groupBox2.Controls.Add(this.hdnameBox);
            this.groupBox2.Controls.Add(this.hdbloodTyp);
            this.groupBox2.Controls.Add(this.hdgender);
            this.groupBox2.Controls.Add(this.hdresidence);
            this.groupBox2.Controls.Add(this.hdnatID);
            this.groupBox2.Controls.Add(this.hdname);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(77, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 649);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 834);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Patient Admission System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button insert;
        private GroupBox groupBox1;
        private ComboBox bloodBox;
        private RadioButton female;
        private RadioButton male;
        private TextBox natIDBox;
        private TextBox resBox;
        private TextBox nameBox;
        private Label bloodTyp;
        private Label gender;
        private Label residence;
        private Label natID;
        private Label name;
        private PictureBox pictureBox1;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button showBtn;
        private Label showlbl;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private ComboBox hdbloodTypBox;
        private RadioButton hdfemale;
        private RadioButton hdmale;
        private TextBox hdnatIDBox;
        private TextBox hdresidenceBox;
        private TextBox hdnameBox;
        private Label hdbloodTyp;
        private Label hdgender;
        private Label hdresidence;
        private Label hdnatID;
        private Label hdname;
    }
}