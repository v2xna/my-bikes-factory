namespace MyBikesFactory.UI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManufacturingYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSuspensionType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTireType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOriginalId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbMountainBikes = new System.Windows.Forms.RadioButton();
            this.rbRoadBikes = new System.Windows.Forms.RadioButton();
            this.lstBikes = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color:";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Green"});
            this.cbColor.Location = new System.Drawing.Point(301, 187);
            this.cbColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(127, 28);
            this.cbColor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial Number:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(301, 93);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(127, 27);
            this.txtSerialNumber.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(621, 93);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(127, 27);
            this.txtModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model:";
            // 
            // txtManufacturingYear
            // 
            this.txtManufacturingYear.Location = new System.Drawing.Point(138, 187);
            this.txtManufacturingYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtManufacturingYear.Name = "txtManufacturingYear";
            this.txtManufacturingYear.Size = new System.Drawing.Size(127, 27);
            this.txtManufacturingYear.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manufacturing Year:";
            // 
            // cbSuspensionType
            // 
            this.cbSuspensionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuspensionType.FormattingEnabled = true;
            this.cbSuspensionType.Items.AddRange(new object[] {
            "Front",
            "Rear",
            "Dual"});
            this.cbSuspensionType.Location = new System.Drawing.Point(463, 187);
            this.cbSuspensionType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSuspensionType.Name = "cbSuspensionType";
            this.cbSuspensionType.Size = new System.Drawing.Size(127, 28);
            this.cbSuspensionType.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Suspension Type:";
            // 
            // cbTireType
            // 
            this.cbTireType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTireType.FormattingEnabled = true;
            this.cbTireType.Items.AddRange(new object[] {
            "Regular",
            "Commuter",
            "Gravel"});
            this.cbTireType.Location = new System.Drawing.Point(621, 187);
            this.cbTireType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTireType.Name = "cbTireType";
            this.cbTireType.Size = new System.Drawing.Size(127, 28);
            this.cbTireType.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tire Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(609, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Original Serial Number:";
            // 
            // txtOriginalId
            // 
            this.txtOriginalId.Enabled = false;
            this.txtOriginalId.Location = new System.Drawing.Point(609, 267);
            this.txtOriginalId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOriginalId.Name = "txtOriginalId";
            this.txtOriginalId.Size = new System.Drawing.Size(188, 27);
            this.txtOriginalId.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Location = new System.Drawing.Point(109, 328);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(330, 77);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Location = new System.Drawing.Point(494, 328);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(330, 77);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(20, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(497, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "Display All existing bikes, Mountain Bikes or Road Bikes ";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAll.Location = new System.Drawing.Point(523, 451);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(55, 29);
            this.rbAll.TabIndex = 11;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbMountainBikes
            // 
            this.rbMountainBikes.AutoSize = true;
            this.rbMountainBikes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMountainBikes.Location = new System.Drawing.Point(582, 451);
            this.rbMountainBikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMountainBikes.Name = "rbMountainBikes";
            this.rbMountainBikes.Size = new System.Drawing.Size(163, 29);
            this.rbMountainBikes.TabIndex = 12;
            this.rbMountainBikes.Text = "Mountain Bikes";
            this.rbMountainBikes.UseVisualStyleBackColor = true;
            this.rbMountainBikes.CheckedChanged += new System.EventHandler(this.rbMountainBikes_CheckedChanged);
            // 
            // rbRoadBikes
            // 
            this.rbRoadBikes.AutoSize = true;
            this.rbRoadBikes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbRoadBikes.Location = new System.Drawing.Point(751, 452);
            this.rbRoadBikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRoadBikes.Name = "rbRoadBikes";
            this.rbRoadBikes.Size = new System.Drawing.Size(123, 29);
            this.rbRoadBikes.TabIndex = 13;
            this.rbRoadBikes.Text = "Road Bikes";
            this.rbRoadBikes.UseVisualStyleBackColor = true;
            this.rbRoadBikes.CheckedChanged += new System.EventHandler(this.rbRoadBikes_CheckedChanged);
            // 
            // lstBikes
            // 
            this.lstBikes.BackColor = System.Drawing.SystemColors.Control;
            this.lstBikes.FormattingEnabled = true;
            this.lstBikes.ItemHeight = 20;
            this.lstBikes.Location = new System.Drawing.Point(26, 508);
            this.lstBikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstBikes.Name = "lstBikes";
            this.lstBikes.Size = new System.Drawing.Size(894, 204);
            this.lstBikes.TabIndex = 14;
            this.lstBikes.SelectedIndexChanged += new System.EventHandler(this.lstBikes_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSearch.Location = new System.Drawing.Point(42, 744);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(179, 91);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Searc&h";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(281, 744);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 91);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(505, 744);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(179, 91);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(730, 744);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 91);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbBikeType
            // 
            this.cbBikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Items.AddRange(new object[] {
            "Mountain Bike",
            "Road Bike"});
            this.cbBikeType.Location = new System.Drawing.Point(138, 93);
            this.cbBikeType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(127, 28);
            this.cbBikeType.TabIndex = 0;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Bike Type:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(463, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 27);
            this.txtName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(952, 889);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstBikes);
            this.Controls.Add(this.rbRoadBikes);
            this.Controls.Add(this.rbMountainBikes);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtOriginalId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTireType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSuspensionType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtManufacturingYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbColor;
        private Label label2;
        private TextBox txtSerialNumber;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtManufacturingYear;
        private Label label4;
        private ComboBox cbSuspensionType;
        private Label label5;
        private ComboBox cbTireType;
        private Label label6;
        private Label label7;
        private TextBox txtOriginalId;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label8;
        private RadioButton rbAll;
        private RadioButton rbMountainBikes;
        private RadioButton rbRoadBikes;
        private ListBox lstBikes;
        private Button btnSearch;
        private Button btnSave;
        private Button btnRemove;
        private Button btnExit;
        private ComboBox cbBikeType;
        private Label label9;
        private TextBox txtName;
        private Label label11;
    }
}