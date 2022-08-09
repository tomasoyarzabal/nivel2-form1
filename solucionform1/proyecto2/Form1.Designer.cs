
namespace proyecto2
{
    partial class pantalla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnagregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonchocolate = new System.Windows.Forms.CheckBox();
            this.lblchocolate = new System.Windows.Forms.Label();
            this.botonotro = new System.Windows.Forms.RadioButton();
            this.botonmasculino = new System.Windows.Forms.RadioButton();
            this.botonfemenino = new System.Windows.Forms.RadioButton();
            this.lblapellido = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listnombres = new System.Windows.Forms.ListView();
            this.fechadenacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblcolor = new System.Windows.Forms.Label();
            this.btnperfil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregar.Location = new System.Drawing.Point(562, 421);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // botonchocolate
            // 
            this.botonchocolate.AutoSize = true;
            this.botonchocolate.Location = new System.Drawing.Point(297, 125);
            this.botonchocolate.Name = "botonchocolate";
            this.botonchocolate.Size = new System.Drawing.Size(15, 14);
            this.botonchocolate.TabIndex = 3;
            this.botonchocolate.UseVisualStyleBackColor = true;
            // 
            // lblchocolate
            // 
            this.lblchocolate.AutoSize = true;
            this.lblchocolate.Location = new System.Drawing.Point(175, 125);
            this.lblchocolate.Name = "lblchocolate";
            this.lblchocolate.Size = new System.Drawing.Size(116, 13);
            this.lblchocolate.TabIndex = 12;
            this.lblchocolate.Text = "Te gusta el chocolate?";
            // 
            // botonotro
            // 
            this.botonotro.AutoSize = true;
            this.botonotro.Location = new System.Drawing.Point(202, 5);
            this.botonotro.Name = "botonotro";
            this.botonotro.Size = new System.Drawing.Size(43, 17);
            this.botonotro.TabIndex = 0;
            this.botonotro.TabStop = true;
            this.botonotro.Text = "otro";
            this.botonotro.UseVisualStyleBackColor = true;
            // 
            // botonmasculino
            // 
            this.botonmasculino.AutoSize = true;
            this.botonmasculino.Location = new System.Drawing.Point(124, 5);
            this.botonmasculino.Name = "botonmasculino";
            this.botonmasculino.Size = new System.Drawing.Size(72, 17);
            this.botonmasculino.TabIndex = 1;
            this.botonmasculino.TabStop = true;
            this.botonmasculino.Text = "masculino";
            this.botonmasculino.UseVisualStyleBackColor = true;
            // 
            // botonfemenino
            // 
            this.botonfemenino.AutoSize = true;
            this.botonfemenino.Location = new System.Drawing.Point(50, 5);
            this.botonfemenino.Name = "botonfemenino";
            this.botonfemenino.Size = new System.Drawing.Size(68, 17);
            this.botonfemenino.TabIndex = 2;
            this.botonfemenino.TabStop = true;
            this.botonfemenino.Text = "femenino";
            this.botonfemenino.UseVisualStyleBackColor = true;
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(244, 96);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(47, 13);
            this.lblapellido.TabIndex = 11;
            this.lblapellido.Text = "Apellido:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 2;
            // 
            // listnombres
            // 
            this.listnombres.HideSelection = false;
            this.listnombres.Location = new System.Drawing.Point(467, 335);
            this.listnombres.Name = "listnombres";
            this.listnombres.Size = new System.Drawing.Size(180, 62);
            this.listnombres.TabIndex = 8;
            this.listnombres.UseCompatibleStateImageBehavior = false;
            this.listnombres.View = System.Windows.Forms.View.List;
            // 
            // fechadenacimiento
            // 
            this.fechadenacimiento.Location = new System.Drawing.Point(297, 157);
            this.fechadenacimiento.Name = "fechadenacimiento";
            this.fechadenacimiento.Size = new System.Drawing.Size(200, 20);
            this.fechadenacimiento.TabIndex = 4;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(188, 163);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(103, 13);
            this.lblfecha.TabIndex = 13;
            this.lblfecha.Text = "fecha de nacimiento";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(242, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(278, 32);
            this.lbltitulo.TabIndex = 9;
            this.lbltitulo.Text = "perfil de la  persona";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.botonfemenino);
            this.groupBox1.Controls.Add(this.botonmasculino);
            this.groupBox1.Controls.Add(this.botonotro);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(297, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 42);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "sexo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(309, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(223, 263);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(68, 13);
            this.lblcolor.TabIndex = 14;
            this.lblcolor.Text = "color favorito";
            // 
            // btnperfil
            // 
            this.btnperfil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnperfil.Location = new System.Drawing.Point(309, 302);
            this.btnperfil.Name = "btnperfil";
            this.btnperfil.Size = new System.Drawing.Size(75, 23);
            this.btnperfil.TabIndex = 7;
            this.btnperfil.Text = "ver perfil";
            this.btnperfil.UseVisualStyleBackColor = false;
            this.btnperfil.Click += new System.EventHandler(this.btnperfil_Click);
            // 
            // pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnperfil);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.fechadenacimiento);
            this.Controls.Add(this.listnombres);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblchocolate);
            this.Controls.Add(this.botonchocolate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnagregar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "pantalla";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.pantalla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox botonchocolate;
        private System.Windows.Forms.Label lblchocolate;
        private System.Windows.Forms.RadioButton botonotro;
        private System.Windows.Forms.RadioButton botonmasculino;
        private System.Windows.Forms.RadioButton botonfemenino;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listnombres;
        private System.Windows.Forms.DateTimePicker fechadenacimiento;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Button btnperfil;
    }
}

