
namespace Tarea1Lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IDLabel = new System.Windows.Forms.Label();
            this.ActivocheckBox = new System.Windows.Forms.CheckBox();
            this.AdministradorcomboBox = new System.Windows.Forms.ComboBox();
            this.Nivellabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Aliaslabel = new System.Windows.Forms.Label();
            this.EneltextBox = new System.Windows.Forms.TextBox();
            this.Nombreslabel = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Clavelabel = new System.Windows.Forms.Label();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ConfirmarClavelabel = new System.Windows.Forms.Label();
            this.ConfirmarClavetextBox = new System.Windows.Forms.TextBox();
            this.CostoXHoralabel = new System.Windows.Forms.Label();
            this.CostoXHoratextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 23);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID\r\n";
            this.IDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ActivocheckBox
            // 
            this.ActivocheckBox.AutoSize = true;
            this.ActivocheckBox.Location = new System.Drawing.Point(590, 21);
            this.ActivocheckBox.Name = "ActivocheckBox";
            this.ActivocheckBox.Size = new System.Drawing.Size(68, 21);
            this.ActivocheckBox.TabIndex = 2;
            this.ActivocheckBox.Text = "Activo";
            this.ActivocheckBox.UseVisualStyleBackColor = true;
            this.ActivocheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AdministradorcomboBox
            // 
            this.AdministradorcomboBox.FormattingEnabled = true;
            this.AdministradorcomboBox.Location = new System.Drawing.Point(537, 56);
            this.AdministradorcomboBox.Name = "AdministradorcomboBox";
            this.AdministradorcomboBox.Size = new System.Drawing.Size(121, 24);
            this.AdministradorcomboBox.TabIndex = 3;
            this.AdministradorcomboBox.Text = "Administrador";
            // 
            // Nivellabel
            // 
            this.Nivellabel.AutoSize = true;
            this.Nivellabel.Location = new System.Drawing.Point(492, 59);
            this.Nivellabel.Name = "Nivellabel";
            this.Nivellabel.Size = new System.Drawing.Size(39, 17);
            this.Nivellabel.TabIndex = 4;
            this.Nivellabel.Text = "Nivel";
            this.Nivellabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Aliaslabel
            // 
            this.Aliaslabel.AutoSize = true;
            this.Aliaslabel.Location = new System.Drawing.Point(12, 61);
            this.Aliaslabel.Name = "Aliaslabel";
            this.Aliaslabel.Size = new System.Drawing.Size(38, 17);
            this.Aliaslabel.TabIndex = 6;
            this.Aliaslabel.Text = "Alias";
            // 
            // EneltextBox
            // 
            this.EneltextBox.Location = new System.Drawing.Point(80, 58);
            this.EneltextBox.Name = "EneltextBox";
            this.EneltextBox.Size = new System.Drawing.Size(209, 22);
            this.EneltextBox.TabIndex = 7;
            this.EneltextBox.Text = "enel";
            this.EneltextBox.TextChanged += new System.EventHandler(this.EneltextBox_TextChanged);
            // 
            // Nombreslabel
            // 
            this.Nombreslabel.AutoSize = true;
            this.Nombreslabel.Location = new System.Drawing.Point(12, 108);
            this.Nombreslabel.Name = "Nombreslabel";
            this.Nombreslabel.Size = new System.Drawing.Size(65, 17);
            this.Nombreslabel.TabIndex = 8;
            this.Nombreslabel.Text = "Nombres";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(80, 103);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(315, 22);
            this.NombretextBox.TabIndex = 9;
            this.NombretextBox.Text = "Enel R. Almonte P";
            this.NombretextBox.TextChanged += new System.EventHandler(this.NombretextBox_TextChanged);
            // 
            // Clavelabel
            // 
            this.Clavelabel.AutoSize = true;
            this.Clavelabel.Location = new System.Drawing.Point(12, 149);
            this.Clavelabel.Name = "Clavelabel";
            this.Clavelabel.Size = new System.Drawing.Size(43, 17);
            this.Clavelabel.TabIndex = 10;
            this.Clavelabel.Text = "Clave";
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(80, 149);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(100, 22);
            this.ClavetextBox.TabIndex = 11;
            this.ClavetextBox.Text = "texto";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(408, 106);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(42, 17);
            this.Emaillabel.TabIndex = 12;
            this.Emaillabel.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(456, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "enel.almonte@sagrd.com";
            // 
            // ConfirmarClavelabel
            // 
            this.ConfirmarClavelabel.AutoSize = true;
            this.ConfirmarClavelabel.Location = new System.Drawing.Point(195, 152);
            this.ConfirmarClavelabel.Name = "ConfirmarClavelabel";
            this.ConfirmarClavelabel.Size = new System.Drawing.Size(108, 17);
            this.ConfirmarClavelabel.TabIndex = 14;
            this.ConfirmarClavelabel.Text = "Confirmar Clave";
            // 
            // ConfirmarClavetextBox
            // 
            this.ConfirmarClavetextBox.Location = new System.Drawing.Point(309, 152);
            this.ConfirmarClavetextBox.Name = "ConfirmarClavetextBox";
            this.ConfirmarClavetextBox.PasswordChar = '*';
            this.ConfirmarClavetextBox.Size = new System.Drawing.Size(126, 22);
            this.ConfirmarClavetextBox.TabIndex = 15;
            this.ConfirmarClavetextBox.Text = "texto";
            // 
            // CostoXHoralabel
            // 
            this.CostoXHoralabel.AutoSize = true;
            this.CostoXHoralabel.Location = new System.Drawing.Point(453, 152);
            this.CostoXHoralabel.Name = "CostoXHoralabel";
            this.CostoXHoralabel.Size = new System.Drawing.Size(89, 17);
            this.CostoXHoralabel.TabIndex = 16;
            this.CostoXHoralabel.Text = "Costo x Hora";
            // 
            // CostoXHoratextBox
            // 
            this.CostoXHoratextBox.Location = new System.Drawing.Point(565, 149);
            this.CostoXHoratextBox.Name = "CostoXHoratextBox";
            this.CostoXHoratextBox.Size = new System.Drawing.Size(100, 22);
            this.CostoXHoratextBox.TabIndex = 17;
            this.CostoXHoratextBox.Text = "102";
            // 
            // button2
            // 
            this.button2.Image = global::Tarea1Lab.Properties.Resources.eliminar;
            this.button2.Location = new System.Drawing.Point(397, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 58);
            this.button2.TabIndex = 20;
            this.button2.Text = "Eliminar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Tarea1Lab.Properties.Resources.guardar;
            this.button1.Location = new System.Drawing.Point(289, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Guardar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Tarea1Lab.Properties.Resources.nuevo;
            this.Nuevobutton.Location = new System.Drawing.Point(166, 188);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(88, 58);
            this.Nuevobutton.TabIndex = 18;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Tarea1Lab.Properties.Resources.lupa__1_;
            this.Buscarbutton.Location = new System.Drawing.Point(186, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(33, 28);
            this.Buscarbutton.TabIndex = 1;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.CostoXHoratextBox);
            this.Controls.Add(this.CostoXHoralabel);
            this.Controls.Add(this.ConfirmarClavetextBox);
            this.Controls.Add(this.ConfirmarClavelabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.Clavelabel);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Nombreslabel);
            this.Controls.Add(this.EneltextBox);
            this.Controls.Add(this.Aliaslabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nivellabel);
            this.Controls.Add(this.AdministradorcomboBox);
            this.Controls.Add(this.ActivocheckBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IDLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registros de Usuarios";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.CheckBox ActivocheckBox;
        private System.Windows.Forms.ComboBox AdministradorcomboBox;
        private System.Windows.Forms.Label Nivellabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Aliaslabel;
        private System.Windows.Forms.TextBox EneltextBox;
        private System.Windows.Forms.Label Nombreslabel;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label Clavelabel;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ConfirmarClavelabel;
        private System.Windows.Forms.TextBox ConfirmarClavetextBox;
        private System.Windows.Forms.Label CostoXHoralabel;
        private System.Windows.Forms.TextBox CostoXHoratextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

