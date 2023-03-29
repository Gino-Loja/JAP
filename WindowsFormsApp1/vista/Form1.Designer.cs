namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2_consumos = new System.Windows.Forms.Panel();
            this.button9_egresos = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7_consumo = new System.Windows.Forms.Button();
            this.button6_costo_m = new System.Windows.Forms.Button();
            this.button5_periodo = new System.Windows.Forms.Button();
            this.panelSubmenuUsuario = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4_usuarios = new System.Windows.Forms.Button();
            this.button6_Dashboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2_consumos.SuspendLayout();
            this.panelSubmenuUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2_consumos);
            this.panel1.Controls.Add(this.button7_consumo);
            this.panel1.Controls.Add(this.button6_costo_m);
            this.panel1.Controls.Add(this.button5_periodo);
            this.panel1.Controls.Add(this.panelSubmenuUsuario);
            this.panel1.Controls.Add(this.button4_usuarios);
            this.panel1.Controls.Add(this.button6_Dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 725);
            this.panel1.TabIndex = 1;
            // 
            // panel2_consumos
            // 
            this.panel2_consumos.Controls.Add(this.button9_egresos);
            this.panel2_consumos.Controls.Add(this.button8);
            this.panel2_consumos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_consumos.Location = new System.Drawing.Point(0, 352);
            this.panel2_consumos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2_consumos.Name = "panel2_consumos";
            this.panel2_consumos.Size = new System.Drawing.Size(190, 107);
            this.panel2_consumos.TabIndex = 14;
            this.panel2_consumos.Visible = false;
            // 
            // button9_egresos
            // 
            this.button9_egresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9_egresos.FlatAppearance.BorderSize = 0;
            this.button9_egresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9_egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9_egresos.Location = new System.Drawing.Point(0, 49);
            this.button9_egresos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9_egresos.Name = "button9_egresos";
            this.button9_egresos.Size = new System.Drawing.Size(190, 55);
            this.button9_egresos.TabIndex = 1;
            this.button9_egresos.Text = "Ingresos y Egresos";
            this.button9_egresos.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 49);
            this.button8.TabIndex = 0;
            this.button8.Text = "Consumo m";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7_consumo
            // 
            this.button7_consumo.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7_consumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7_consumo.Location = new System.Drawing.Point(0, 305);
            this.button7_consumo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7_consumo.Name = "button7_consumo";
            this.button7_consumo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button7_consumo.Size = new System.Drawing.Size(190, 47);
            this.button7_consumo.TabIndex = 13;
            this.button7_consumo.Text = "Consumos";
            this.button7_consumo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7_consumo.UseVisualStyleBackColor = true;
            this.button7_consumo.Click += new System.EventHandler(this.button7_consumo_Click_1);
            // 
            // button6_costo_m
            // 
            this.button6_costo_m.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6_costo_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6_costo_m.Location = new System.Drawing.Point(0, 259);
            this.button6_costo_m.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6_costo_m.Name = "button6_costo_m";
            this.button6_costo_m.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button6_costo_m.Size = new System.Drawing.Size(190, 46);
            this.button6_costo_m.TabIndex = 12;
            this.button6_costo_m.Text = "Costo m";
            this.button6_costo_m.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6_costo_m.UseVisualStyleBackColor = true;
            // 
            // button5_periodo
            // 
            this.button5_periodo.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5_periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_periodo.Location = new System.Drawing.Point(0, 210);
            this.button5_periodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5_periodo.Name = "button5_periodo";
            this.button5_periodo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button5_periodo.Size = new System.Drawing.Size(190, 49);
            this.button5_periodo.TabIndex = 11;
            this.button5_periodo.Text = "Periodo";
            this.button5_periodo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5_periodo.UseVisualStyleBackColor = true;
            // 
            // panelSubmenuUsuario
            // 
            this.panelSubmenuUsuario.Controls.Add(this.button2);
            this.panelSubmenuUsuario.Controls.Add(this.button3);
            this.panelSubmenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuUsuario.Location = new System.Drawing.Point(0, 97);
            this.panelSubmenuUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSubmenuUsuario.Name = "panelSubmenuUsuario";
            this.panelSubmenuUsuario.Size = new System.Drawing.Size(190, 113);
            this.panelSubmenuUsuario.TabIndex = 10;
            this.panelSubmenuUsuario.Visible = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lecturas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "Administradores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4_usuarios
            // 
            this.button4_usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4_usuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_usuarios.Location = new System.Drawing.Point(0, 50);
            this.button4_usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4_usuarios.Name = "button4_usuarios";
            this.button4_usuarios.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button4_usuarios.Size = new System.Drawing.Size(190, 47);
            this.button4_usuarios.TabIndex = 3;
            this.button4_usuarios.Text = "Usuarios";
            this.button4_usuarios.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4_usuarios.UseVisualStyleBackColor = true;
            this.button4_usuarios.Click += new System.EventHandler(this.button4_usuarios_Click);
            // 
            // button6_Dashboard
            // 
            this.button6_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.button6_Dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6_Dashboard.Name = "button6_Dashboard";
            this.button6_Dashboard.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button6_Dashboard.Size = new System.Drawing.Size(190, 50);
            this.button6_Dashboard.TabIndex = 1;
            this.button6_Dashboard.Text = "Dashboard";
            this.button6_Dashboard.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6_Dashboard.UseVisualStyleBackColor = true;
            this.button6_Dashboard.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 725);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2_consumos.ResumeLayout(false);
            this.panelSubmenuUsuario.ResumeLayout(false);
            this.panelSubmenuUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6_Dashboard;
        private System.Windows.Forms.Button button4_usuarios;
        private System.Windows.Forms.Button button9_egresos;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panelSubmenuUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6_costo_m;
        private System.Windows.Forms.Button button5_periodo;
        private System.Windows.Forms.Button button7_consumo;
        private System.Windows.Forms.Panel panel2_consumos;
    }
}