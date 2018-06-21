namespace Game15
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGame24 = new System.Windows.Forms.Button();
            this.buttonGame15 = new System.Windows.Forms.Button();
            this.buttonGame8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рекордыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкийУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложныйУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помошьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonGame24, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonGame15, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonGame8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonGame24
            // 
            this.buttonGame24.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonGame24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGame24.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.buttonGame24.Location = new System.Drawing.Point(10, 216);
            this.buttonGame24.Margin = new System.Windows.Forms.Padding(10);
            this.buttonGame24.Name = "buttonGame24";
            this.buttonGame24.Size = new System.Drawing.Size(473, 84);
            this.buttonGame24.TabIndex = 2;
            this.buttonGame24.Text = "Сложный (24)";
            this.buttonGame24.UseVisualStyleBackColor = false;
            this.buttonGame24.Click += new System.EventHandler(this.buttonGame24_Click);
            // 
            // buttonGame15
            // 
            this.buttonGame15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonGame15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGame15.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.buttonGame15.Location = new System.Drawing.Point(10, 113);
            this.buttonGame15.Margin = new System.Windows.Forms.Padding(10);
            this.buttonGame15.Name = "buttonGame15";
            this.buttonGame15.Size = new System.Drawing.Size(473, 83);
            this.buttonGame15.TabIndex = 1;
            this.buttonGame15.Text = "Средний (15)";
            this.buttonGame15.UseVisualStyleBackColor = false;
            this.buttonGame15.Click += new System.EventHandler(this.buttonGame15_Click);
            // 
            // buttonGame8
            // 
            this.buttonGame8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonGame8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGame8.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGame8.Location = new System.Drawing.Point(10, 10);
            this.buttonGame8.Margin = new System.Windows.Forms.Padding(10);
            this.buttonGame8.Name = "buttonGame8";
            this.buttonGame8.Size = new System.Drawing.Size(473, 83);
            this.buttonGame8.TabIndex = 0;
            this.buttonGame8.Text = "Лёгкий (8)";
            this.buttonGame8.UseVisualStyleBackColor = false;
            this.buttonGame8.Click += new System.EventHandler(this.buttonGame8_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рекордыToolStripMenuItem,
            this.помошьToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рекордыToolStripMenuItem
            // 
            this.рекордыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкийУровеньToolStripMenuItem,
            this.среднийУровеньToolStripMenuItem,
            this.сложныйУровеньToolStripMenuItem});
            this.рекордыToolStripMenuItem.Name = "рекордыToolStripMenuItem";
            this.рекордыToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.рекордыToolStripMenuItem.Text = "История результатов";
            // 
            // легкийУровеньToolStripMenuItem
            // 
            this.легкийУровеньToolStripMenuItem.Name = "легкийУровеньToolStripMenuItem";
            this.легкийУровеньToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.легкийУровеньToolStripMenuItem.Text = "Легкий уровень";
            this.легкийУровеньToolStripMenuItem.Click += new System.EventHandler(this.легкийУровеньToolStripMenuItem_Click);
            // 
            // среднийУровеньToolStripMenuItem
            // 
            this.среднийУровеньToolStripMenuItem.Name = "среднийУровеньToolStripMenuItem";
            this.среднийУровеньToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.среднийУровеньToolStripMenuItem.Text = "Средний уровень";
            this.среднийУровеньToolStripMenuItem.Click += new System.EventHandler(this.среднийУровеньToolStripMenuItem_Click);
            // 
            // сложныйУровеньToolStripMenuItem
            // 
            this.сложныйУровеньToolStripMenuItem.Name = "сложныйУровеньToolStripMenuItem";
            this.сложныйУровеньToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.сложныйУровеньToolStripMenuItem.Text = "Сложный уровень";
            this.сложныйУровеньToolStripMenuItem.Click += new System.EventHandler(this.сложныйУровеньToolStripMenuItem_Click);
            // 
            // помошьToolStripMenuItem
            // 
            this.помошьToolStripMenuItem.Name = "помошьToolStripMenuItem";
            this.помошьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.помошьToolStripMenuItem.Text = "Об игре";
            this.помошьToolStripMenuItem.Click += new System.EventHandler(this.помошьToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 334);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню игры";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonGame24;
        private System.Windows.Forms.Button buttonGame15;
        private System.Windows.Forms.Button buttonGame8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рекордыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помошьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкийУровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийУровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложныйУровеньToolStripMenuItem;
    }
}