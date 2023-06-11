namespace Is_Bus_da
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.update_button = new System.Windows.Forms.Button();
            this.name_label4 = new System.Windows.Forms.Label();
            this.name_label3 = new System.Windows.Forms.Label();
            this.name_label2 = new System.Windows.Forms.Label();
            this.name_label1 = new System.Windows.Forms.Label();
            this.name_label0 = new System.Windows.Forms.Label();
            this.time_label4 = new System.Windows.Forms.Label();
            this.remaining_label4 = new System.Windows.Forms.Label();
            this.remaining_label3 = new System.Windows.Forms.Label();
            this.time_label3 = new System.Windows.Forms.Label();
            this.time_label2 = new System.Windows.Forms.Label();
            this.remaining_label2 = new System.Windows.Forms.Label();
            this.time_label1 = new System.Windows.Forms.Label();
            this.remaining_label1 = new System.Windows.Forms.Label();
            this.remaining_label0 = new System.Windows.Forms.Label();
            this.time_label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.autoUpdatesMinutes = new System.Windows.Forms.NumericUpDown();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoUpdatesMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.update_button, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.name_label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.name_label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.name_label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.name_label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.name_label0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.time_label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.remaining_label4, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.remaining_label3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.time_label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.time_label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.remaining_label2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.time_label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.remaining_label1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.remaining_label0, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.time_label0, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // update_button
            // 
            this.update_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update_button.Location = new System.Drawing.Point(411, 273);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(130, 25);
            this.update_button.TabIndex = 0;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // name_label4
            // 
            this.name_label4.AutoSize = true;
            this.name_label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label4.Location = new System.Drawing.Point(3, 225);
            this.name_label4.Name = "name_label4";
            this.name_label4.Size = new System.Drawing.Size(266, 45);
            this.name_label4.TabIndex = 7;
            this.name_label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_label3
            // 
            this.name_label3.AutoSize = true;
            this.name_label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label3.Location = new System.Drawing.Point(3, 180);
            this.name_label3.Name = "name_label3";
            this.name_label3.Size = new System.Drawing.Size(266, 45);
            this.name_label3.TabIndex = 6;
            this.name_label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_label2
            // 
            this.name_label2.AutoSize = true;
            this.name_label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label2.Location = new System.Drawing.Point(3, 135);
            this.name_label2.Name = "name_label2";
            this.name_label2.Size = new System.Drawing.Size(266, 45);
            this.name_label2.TabIndex = 5;
            this.name_label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_label1
            // 
            this.name_label1.AutoSize = true;
            this.name_label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label1.Location = new System.Drawing.Point(3, 90);
            this.name_label1.Name = "name_label1";
            this.name_label1.Size = new System.Drawing.Size(266, 45);
            this.name_label1.TabIndex = 4;
            this.name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_label0
            // 
            this.name_label0.AutoSize = true;
            this.name_label0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_label0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label0.Location = new System.Drawing.Point(3, 45);
            this.name_label0.Name = "name_label0";
            this.name_label0.Size = new System.Drawing.Size(266, 45);
            this.name_label0.TabIndex = 1;
            this.name_label0.Text = "Lädt...";
            this.name_label0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time_label4
            // 
            this.time_label4.AutoSize = true;
            this.time_label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_label4.Location = new System.Drawing.Point(275, 225);
            this.time_label4.Name = "time_label4";
            this.time_label4.Size = new System.Drawing.Size(130, 45);
            this.time_label4.TabIndex = 10;
            this.time_label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remaining_label4
            // 
            this.remaining_label4.AutoSize = true;
            this.remaining_label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remaining_label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remaining_label4.Location = new System.Drawing.Point(411, 225);
            this.remaining_label4.Name = "remaining_label4";
            this.remaining_label4.Size = new System.Drawing.Size(130, 45);
            this.remaining_label4.TabIndex = 12;
            this.remaining_label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remaining_label3
            // 
            this.remaining_label3.AutoSize = true;
            this.remaining_label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remaining_label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remaining_label3.Location = new System.Drawing.Point(411, 180);
            this.remaining_label3.Name = "remaining_label3";
            this.remaining_label3.Size = new System.Drawing.Size(130, 45);
            this.remaining_label3.TabIndex = 13;
            this.remaining_label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time_label3
            // 
            this.time_label3.AutoSize = true;
            this.time_label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_label3.Location = new System.Drawing.Point(275, 180);
            this.time_label3.Name = "time_label3";
            this.time_label3.Size = new System.Drawing.Size(130, 45);
            this.time_label3.TabIndex = 11;
            this.time_label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time_label2
            // 
            this.time_label2.AutoSize = true;
            this.time_label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_label2.Location = new System.Drawing.Point(275, 135);
            this.time_label2.Name = "time_label2";
            this.time_label2.Size = new System.Drawing.Size(130, 45);
            this.time_label2.TabIndex = 9;
            this.time_label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remaining_label2
            // 
            this.remaining_label2.AutoSize = true;
            this.remaining_label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remaining_label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remaining_label2.Location = new System.Drawing.Point(411, 135);
            this.remaining_label2.Name = "remaining_label2";
            this.remaining_label2.Size = new System.Drawing.Size(130, 45);
            this.remaining_label2.TabIndex = 14;
            this.remaining_label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time_label1
            // 
            this.time_label1.AutoSize = true;
            this.time_label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_label1.Location = new System.Drawing.Point(275, 90);
            this.time_label1.Name = "time_label1";
            this.time_label1.Size = new System.Drawing.Size(130, 45);
            this.time_label1.TabIndex = 8;
            this.time_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remaining_label1
            // 
            this.remaining_label1.AutoSize = true;
            this.remaining_label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remaining_label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remaining_label1.Location = new System.Drawing.Point(411, 90);
            this.remaining_label1.Name = "remaining_label1";
            this.remaining_label1.Size = new System.Drawing.Size(130, 45);
            this.remaining_label1.TabIndex = 15;
            this.remaining_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remaining_label0
            // 
            this.remaining_label0.AutoSize = true;
            this.remaining_label0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remaining_label0.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remaining_label0.ForeColor = System.Drawing.Color.Red;
            this.remaining_label0.Location = new System.Drawing.Point(411, 45);
            this.remaining_label0.Name = "remaining_label0";
            this.remaining_label0.Size = new System.Drawing.Size(130, 45);
            this.remaining_label0.TabIndex = 3;
            this.remaining_label0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // time_label0
            // 
            this.time_label0.AutoSize = true;
            this.time_label0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_label0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_label0.Location = new System.Drawing.Point(275, 45);
            this.time_label0.Name = "time_label0";
            this.time_label0.Size = new System.Drawing.Size(130, 45);
            this.time_label0.TabIndex = 2;
            this.time_label0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Linie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(275, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 45);
            this.label2.TabIndex = 17;
            this.label2.Text = "Abfahrtszeit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.autoUpdatesMinutes);
            this.flowLayoutPanel1.Controls.Add(this.autoUpdateCheckBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(402, 25);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minuten";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoUpdatesMinutes
            // 
            this.autoUpdatesMinutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoUpdatesMinutes.Location = new System.Drawing.Point(307, 3);
            this.autoUpdatesMinutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.autoUpdatesMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.autoUpdatesMinutes.Name = "autoUpdatesMinutes";
            this.autoUpdatesMinutes.Size = new System.Drawing.Size(34, 23);
            this.autoUpdatesMinutes.TabIndex = 1;
            this.autoUpdatesMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.autoUpdatesMinutes.ValueChanged += new System.EventHandler(this.autoUpdatesMinutes_ValueChanged);
            // 
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.Checked = true;
            this.autoUpdateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(185, 5);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(116, 19);
            this.autoUpdateCheckBox.TabIndex = 2;
            this.autoUpdateCheckBox.Text = "Auto-Update alle";
            this.autoUpdateCheckBox.UseVisualStyleBackColor = true;
            this.autoUpdateCheckBox.CheckedChanged += new System.EventHandler(this.autoUpdateCheckBox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(560, 340);
            this.Name = "Form1";
            this.Text = "Is Bus da?";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoUpdatesMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button update_button;
        private Label name_label0;
        private Label time_label0;
        private Label remaining_label0;
        private Label name_label1;
        private Label name_label2;
        private Label name_label3;
        private Label name_label4;
        private Label time_label1;
        private Label time_label2;
        private Label time_label3;
        private Label remaining_label4;
        private Label time_label4;
        private Label remaining_label3;
        private Label remaining_label2;
        private Label remaining_label1;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private NumericUpDown autoUpdatesMinutes;
        private CheckBox autoUpdateCheckBox;
        private System.Windows.Forms.Timer timer1;
    }
}