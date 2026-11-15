namespace GerenciamentoDeVeiculos
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgv_Exibir = new System.Windows.Forms.DataGridView();
            this.comboBoxOpcoesFiltro = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Anos = new System.Windows.Forms.ComboBox();
            this.btn_filtrarPorAno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exibir)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(36, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgv_Exibir
            // 
            this.dgv_Exibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exibir.Location = new System.Drawing.Point(36, 141);
            this.dgv_Exibir.Name = "dgv_Exibir";
            this.dgv_Exibir.Size = new System.Drawing.Size(731, 297);
            this.dgv_Exibir.TabIndex = 1;
            this.dgv_Exibir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExibirDados);
            // 
            // comboBoxOpcoesFiltro
            // 
            this.comboBoxOpcoesFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpcoesFiltro.FormattingEnabled = true;
            this.comboBoxOpcoesFiltro.Location = new System.Drawing.Point(278, 29);
            this.comboBoxOpcoesFiltro.Name = "comboBoxOpcoesFiltro";
            this.comboBoxOpcoesFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOpcoesFiltro.TabIndex = 4;
            this.comboBoxOpcoesFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpcoesFiltro_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exibir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BuscarVeiculos);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar por região:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Opções:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Anos
            // 
            this.Anos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Anos.FormattingEnabled = true;
            this.Anos.Location = new System.Drawing.Point(36, 75);
            this.Anos.Name = "Anos";
            this.Anos.Size = new System.Drawing.Size(121, 21);
            this.Anos.TabIndex = 8;
            this.Anos.SelectedIndexChanged += new System.EventHandler(this.Anos_SelectedIndexChanged);
            // 
            // btn_filtrarPorAno
            // 
            this.btn_filtrarPorAno.Location = new System.Drawing.Point(172, 73);
            this.btn_filtrarPorAno.Name = "btn_filtrarPorAno";
            this.btn_filtrarPorAno.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrarPorAno.TabIndex = 9;
            this.btn_filtrarPorAno.Text = "Exibir";
            this.btn_filtrarPorAno.UseVisualStyleBackColor = true;
            this.btn_filtrarPorAno.Click += new System.EventHandler(this.FiltrarPorAno);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filtrar por ano";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Relatório de frequência";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GerarRelatorioFrequencia);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_filtrarPorAno);
            this.Controls.Add(this.Anos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxOpcoesFiltro);
            this.Controls.Add(this.dgv_Exibir);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exibir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgv_Exibir;
        private System.Windows.Forms.ComboBox comboBoxOpcoesFiltro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Anos;
        private System.Windows.Forms.Button btn_filtrarPorAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

