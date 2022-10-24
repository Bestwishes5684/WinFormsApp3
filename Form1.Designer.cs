namespace WinFormsApp3
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeliteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datarod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Russian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummBall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel3.Text = "toolStripLabel3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.DeliteToolStripMenuItem,
            this.ChangeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.AddToolStripMenuItem.Text = "Добавить студента ";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // DeliteToolStripMenuItem
            // 
            this.DeliteToolStripMenuItem.Name = "DeliteToolStripMenuItem";
            this.DeliteToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.DeliteToolStripMenuItem.Text = "Удалить студента ";
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.ChangeToolStripMenuItem.Text = "Изменить студента ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fio,
            this.Datarod,
            this.Pol,
            this.FORM,
            this.MATH,
            this.Russian,
            this.Inform,
            this.SummBall});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(845, 395);
            this.dataGridView1.TabIndex = 3;
            // 
            // Fio
            // 
            this.Fio.DataPropertyName = "FullName";
            this.Fio.HeaderText = "ФИО";
            this.Fio.Name = "Fio";
            // 
            // Datarod
            // 
            this.Datarod.HeaderText = "Дата Рождения ";
            this.Datarod.Name = "Datarod";
            // 
            // Pol
            // 
            this.Pol.DataPropertyName = "Gender";
            this.Pol.HeaderText = "Пол";
            this.Pol.Name = "Pol";
            // 
            // FORM
            // 
            this.FORM.DataPropertyName = "FormOB";
            this.FORM.HeaderText = "Форма обучения ";
            this.FORM.Name = "FORM";
            // 
            // MATH
            // 
            this.MATH.DataPropertyName = "Mathematics ";
            this.MATH.HeaderText = "ЕГЭ по Математике";
            this.MATH.Name = "MATH";
            // 
            // Russian
            // 
            this.Russian.DataPropertyName = "Russian";
            this.Russian.HeaderText = "Егэ по русскому";
            this.Russian.Name = "Russian";
            // 
            // Inform
            // 
            this.Inform.DataPropertyName = "informatics";
            this.Inform.HeaderText = "Егэ по информатике";
            this.Inform.Name = "Inform";
            // 
            // SummBall
            // 
            this.SummBall.DataPropertyName = "totalpoints ";
            this.SummBall.HeaderText = "Общая сумма баллов";
            this.SummBall.Name = "SummBall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Приёмная комиссия ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem AddToolStripMenuItem;
        private ToolStripMenuItem DeliteToolStripMenuItem;
        private ToolStripMenuItem ChangeToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fio;
        private DataGridViewTextBoxColumn Datarod;
        private DataGridViewTextBoxColumn Pol;
        private DataGridViewTextBoxColumn FORM;
        private DataGridViewTextBoxColumn MATH;
        private DataGridViewTextBoxColumn Russian;
        private DataGridViewTextBoxColumn Inform;
        private DataGridViewTextBoxColumn SummBall;
    }
}