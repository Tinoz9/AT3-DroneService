namespace AT3_DroneService
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
            this.listViewR = new System.Windows.Forms.ListView();
            this.rNameCol = new System.Windows.Forms.ColumnHeader();
            this.rModCol = new System.Windows.Forms.ColumnHeader();
            this.rProbCol = new System.Windows.Forms.ColumnHeader();
            this.rCostCol = new System.Windows.Forms.ColumnHeader();
            this.rTagCol = new System.Windows.Forms.ColumnHeader();
            this.listViewE = new System.Windows.Forms.ListView();
            this.eNameCol = new System.Windows.Forms.ColumnHeader();
            this.eModCol = new System.Windows.Forms.ColumnHeader();
            this.eProbCol = new System.Windows.Forms.ColumnHeader();
            this.eCostCol = new System.Windows.Forms.ColumnHeader();
            this.eTagCol = new System.Windows.Forms.ColumnHeader();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dronBox = new System.Windows.Forms.TextBox();
            this.probBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.expBtn = new System.Windows.Forms.RadioButton();
            this.regBtn = new System.Windows.Forms.RadioButton();
            this.tagUp = new System.Windows.Forms.NumericUpDown();
            this.addBtn = new System.Windows.Forms.Button();
            this.rFinBtn = new System.Windows.Forms.Button();
            this.eFinBtn = new System.Windows.Forms.Button();
            this.finBox = new System.Windows.Forms.ListBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagUp)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewR
            // 
            this.listViewR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rNameCol,
            this.rModCol,
            this.rProbCol,
            this.rCostCol,
            this.rTagCol});
            this.listViewR.GridLines = true;
            this.listViewR.Location = new System.Drawing.Point(215, 48);
            this.listViewR.Name = "listViewR";
            this.listViewR.Size = new System.Drawing.Size(384, 364);
            this.listViewR.TabIndex = 0;
            this.listViewR.UseCompatibleStateImageBehavior = false;
            this.listViewR.View = System.Windows.Forms.View.Details;
            this.listViewR.SelectedIndexChanged += new System.EventHandler(this.listViewR_SelectedIndexChanged);
            // 
            // rNameCol
            // 
            this.rNameCol.Text = "Name";
            // 
            // rModCol
            // 
            this.rModCol.Text = "Drone Model";
            this.rModCol.Width = 100;
            // 
            // rProbCol
            // 
            this.rProbCol.Text = "Service Problem";
            this.rProbCol.Width = 100;
            // 
            // rCostCol
            // 
            this.rCostCol.Text = "Cost";
            // 
            // rTagCol
            // 
            this.rTagCol.Text = "Tag";
            // 
            // listViewE
            // 
            this.listViewE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eNameCol,
            this.eModCol,
            this.eProbCol,
            this.eCostCol,
            this.eTagCol});
            this.listViewE.GridLines = true;
            this.listViewE.Location = new System.Drawing.Point(609, 48);
            this.listViewE.Name = "listViewE";
            this.listViewE.Size = new System.Drawing.Size(384, 364);
            this.listViewE.TabIndex = 0;
            this.listViewE.UseCompatibleStateImageBehavior = false;
            this.listViewE.View = System.Windows.Forms.View.Details;
            this.listViewE.SelectedIndexChanged += new System.EventHandler(this.listViewE_SelectedIndexChanged);
            // 
            // eNameCol
            // 
            this.eNameCol.Text = "Name";
            // 
            // eModCol
            // 
            this.eModCol.Text = "Drone Model";
            this.eModCol.Width = 100;
            // 
            // eProbCol
            // 
            this.eProbCol.Text = "Service Problem";
            this.eProbCol.Width = 100;
            // 
            // eCostCol
            // 
            this.eCostCol.Text = "Cost";
            // 
            // eTagCol
            // 
            this.eTagCol.Text = "Tag";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(25, 48);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(152, 23);
            this.nameBox.TabIndex = 3;
            // 
            // dronBox
            // 
            this.dronBox.Location = new System.Drawing.Point(25, 92);
            this.dronBox.Name = "dronBox";
            this.dronBox.Size = new System.Drawing.Size(152, 23);
            this.dronBox.TabIndex = 4;
            // 
            // probBox
            // 
            this.probBox.Location = new System.Drawing.Point(25, 136);
            this.probBox.Multiline = true;
            this.probBox.Name = "probBox";
            this.probBox.Size = new System.Drawing.Size(152, 114);
            this.probBox.TabIndex = 5;
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(25, 271);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(152, 23);
            this.costBox.TabIndex = 6;
            this.costBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Regular Queue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Express Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1026, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Finished List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Drone Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Service Problem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Service Cost";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.expBtn);
            this.groupBox.Controls.Add(this.regBtn);
            this.groupBox.Location = new System.Drawing.Point(12, 300);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(146, 49);
            this.groupBox.TabIndex = 15;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Service Tag and priority";
            // 
            // expBtn
            // 
            this.expBtn.AutoSize = true;
            this.expBtn.Location = new System.Drawing.Point(82, 22);
            this.expBtn.Name = "expBtn";
            this.expBtn.Size = new System.Drawing.Size(64, 19);
            this.expBtn.TabIndex = 1;
            this.expBtn.TabStop = true;
            this.expBtn.Text = "Express";
            this.expBtn.UseVisualStyleBackColor = true;
            // 
            // regBtn
            // 
            this.regBtn.AutoSize = true;
            this.regBtn.Location = new System.Drawing.Point(6, 22);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(65, 19);
            this.regBtn.TabIndex = 0;
            this.regBtn.TabStop = true;
            this.regBtn.Text = "Regular";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.CheckedChanged += new System.EventHandler(this.regBtn_CheckedChanged);
            // 
            // tagUp
            // 
            this.tagUp.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tagUp.Location = new System.Drawing.Point(164, 318);
            this.tagUp.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.tagUp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.tagUp.Name = "tagUp";
            this.tagUp.ReadOnly = true;
            this.tagUp.Size = new System.Drawing.Size(45, 23);
            this.tagUp.TabIndex = 16;
            this.tagUp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(63, 355);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // rFinBtn
            // 
            this.rFinBtn.Location = new System.Drawing.Point(18, 384);
            this.rFinBtn.Name = "rFinBtn";
            this.rFinBtn.Size = new System.Drawing.Size(87, 23);
            this.rFinBtn.TabIndex = 18;
            this.rFinBtn.Text = "Regular - Fin";
            this.rFinBtn.UseVisualStyleBackColor = true;
            this.rFinBtn.Click += new System.EventHandler(this.rFinBtn_Click);
            // 
            // eFinBtn
            // 
            this.eFinBtn.Location = new System.Drawing.Point(114, 384);
            this.eFinBtn.Name = "eFinBtn";
            this.eFinBtn.Size = new System.Drawing.Size(83, 23);
            this.eFinBtn.TabIndex = 19;
            this.eFinBtn.Text = "Express - Fin";
            this.eFinBtn.UseVisualStyleBackColor = true;
            this.eFinBtn.Click += new System.EventHandler(this.eFinBtn_Click);
            // 
            // finBox
            // 
            this.finBox.FormattingEnabled = true;
            this.finBox.ItemHeight = 15;
            this.finBox.Location = new System.Drawing.Point(997, 48);
            this.finBox.Name = "finBox";
            this.finBox.Size = new System.Drawing.Size(162, 364);
            this.finBox.TabIndex = 20;
            this.finBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.finBox_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 444);
            this.Controls.Add(this.finBox);
            this.Controls.Add(this.eFinBtn);
            this.Controls.Add(this.rFinBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tagUp);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.probBox);
            this.Controls.Add(this.dronBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.listViewE);
            this.Controls.Add(this.listViewR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listViewR;
        private ListView listViewE;
        private TextBox nameBox;
        private TextBox dronBox;
        private TextBox probBox;
        private TextBox costBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox;
        private RadioButton expBtn;
        private RadioButton regBtn;
        private NumericUpDown tagUp;
        private Button addBtn;
        private Button rFinBtn;
        private Button eFinBtn;
        private ColumnHeader rNameCol;
        private ColumnHeader rModCol;
        private ColumnHeader rProbCol;
        private ColumnHeader rCostCol;
        private ColumnHeader rTagCol;
        private ColumnHeader eNameCol;
        private ColumnHeader eModCol;
        private ColumnHeader eProbCol;
        private ColumnHeader eCostCol;
        private ColumnHeader eTagCol;
        private ListBox finBox;
    }
}