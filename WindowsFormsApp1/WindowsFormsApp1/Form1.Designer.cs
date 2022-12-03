
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.trackbarvolumen = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbolistar = new System.Windows.Forms.ComboBox();
            this.trackbarvelocidad = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnpausar = new System.Windows.Forms.Button();
            this.btndetener = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarvolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarvelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // trackbarvolumen
            // 
            this.trackbarvolumen.Location = new System.Drawing.Point(137, 205);
            this.trackbarvolumen.Maximum = 100;
            this.trackbarvolumen.Name = "trackbarvolumen";
            this.trackbarvolumen.Size = new System.Drawing.Size(234, 56);
            this.trackbarvolumen.TabIndex = 0;
            this.trackbarvolumen.TickFrequency = 25;
            this.trackbarvolumen.Value = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(377, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Leer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 157);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voz:";
            // 
            // cbolistar
            // 
            this.cbolistar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbolistar.FormattingEnabled = true;
            this.cbolistar.Location = new System.Drawing.Point(137, 175);
            this.cbolistar.Name = "cbolistar";
            this.cbolistar.Size = new System.Drawing.Size(234, 24);
            this.cbolistar.TabIndex = 4;
            // 
            // trackbarvelocidad
            // 
            this.trackbarvelocidad.Location = new System.Drawing.Point(137, 267);
            this.trackbarvelocidad.Minimum = -10;
            this.trackbarvelocidad.Name = "trackbarvelocidad";
            this.trackbarvelocidad.Size = new System.Drawing.Size(234, 56);
            this.trackbarvelocidad.TabIndex = 10;
            this.trackbarvelocidad.TickFrequency = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Volumen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Velocidad:";
            // 
            // btnpausar
            // 
            this.btnpausar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnpausar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpausar.Location = new System.Drawing.Point(377, 63);
            this.btnpausar.Name = "btnpausar";
            this.btnpausar.Size = new System.Drawing.Size(116, 45);
            this.btnpausar.TabIndex = 13;
            this.btnpausar.Text = "Pausar";
            this.btnpausar.UseVisualStyleBackColor = false;
            this.btnpausar.Click += new System.EventHandler(this.btnpausar_Click);
            // 
            // btndetener
            // 
            this.btndetener.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btndetener.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndetener.Location = new System.Drawing.Point(377, 114);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(116, 45);
            this.btndetener.TabIndex = 14;
            this.btndetener.Text = "Detener";
            this.btndetener.UseVisualStyleBackColor = false;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Location = new System.Drawing.Point(377, 165);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(116, 45);
            this.btnguardar.TabIndex = 15;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(377, 216);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(116, 45);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 329);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btndetener);
            this.Controls.Add(this.btnpausar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackbarvelocidad);
            this.Controls.Add(this.cbolistar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackbarvolumen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackbarvolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarvelocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackbarvolumen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbolistar;
        private System.Windows.Forms.TrackBar trackbarvelocidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpausar;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnsalir;
    }
}

