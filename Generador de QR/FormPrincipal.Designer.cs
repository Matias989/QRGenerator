
namespace Generador_de_QR
{
    partial class FormPrincipal
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
            this.PictureBoxQr = new System.Windows.Forms.PictureBox();
            this.GenerarBTN = new System.Windows.Forms.Button();
            this.GuardarBTN = new System.Windows.Forms.Button();
            this.TextTXT = new System.Windows.Forms.TextBox();
            this.rd2x2 = new System.Windows.Forms.RadioButton();
            this.rd5x5 = new System.Windows.Forms.RadioButton();
            this.rd3x3 = new System.Windows.Forms.RadioButton();
            this.gbRadioButtons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxQr)).BeginInit();
            this.gbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxQr
            // 
            this.PictureBoxQr.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxQr.Name = "PictureBoxQr";
            this.PictureBoxQr.Size = new System.Drawing.Size(251, 250);
            this.PictureBoxQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxQr.TabIndex = 0;
            this.PictureBoxQr.TabStop = false;
            // 
            // GenerarBTN
            // 
            this.GenerarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarBTN.Location = new System.Drawing.Point(12, 345);
            this.GenerarBTN.Name = "GenerarBTN";
            this.GenerarBTN.Size = new System.Drawing.Size(120, 35);
            this.GenerarBTN.TabIndex = 1;
            this.GenerarBTN.Text = "Generar";
            this.GenerarBTN.UseVisualStyleBackColor = true;
            this.GenerarBTN.Click += new System.EventHandler(this.GenerarBTN_Click);
            // 
            // GuardarBTN
            // 
            this.GuardarBTN.Enabled = false;
            this.GuardarBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.GuardarBTN.Location = new System.Drawing.Point(143, 345);
            this.GuardarBTN.Name = "GuardarBTN";
            this.GuardarBTN.Size = new System.Drawing.Size(120, 35);
            this.GuardarBTN.TabIndex = 2;
            this.GuardarBTN.Text = "Guardar";
            this.GuardarBTN.UseVisualStyleBackColor = true;
            this.GuardarBTN.Click += new System.EventHandler(this.GuardarBTN_Click);
            // 
            // TextTXT
            // 
            this.TextTXT.Location = new System.Drawing.Point(12, 268);
            this.TextTXT.Name = "TextTXT";
            this.TextTXT.Size = new System.Drawing.Size(250, 20);
            this.TextTXT.TabIndex = 3;
            // 
            // rd2x2
            // 
            this.rd2x2.AutoSize = true;
            this.rd2x2.Checked = true;
            this.rd2x2.Location = new System.Drawing.Point(6, 19);
            this.rd2x2.Name = "rd2x2";
            this.rd2x2.Size = new System.Drawing.Size(45, 17);
            this.rd2x2.TabIndex = 4;
            this.rd2x2.Text = "2x2";
            this.rd2x2.UseVisualStyleBackColor = true;
            this.rd2x2.CheckedChanged += new System.EventHandler(this.rd2x2_CheckedChanged);
            // 
            // rd5x5
            // 
            this.rd5x5.AutoSize = true;
            this.rd5x5.Location = new System.Drawing.Point(203, 19);
            this.rd5x5.Name = "rd5x5";
            this.rd5x5.Size = new System.Drawing.Size(45, 17);
            this.rd5x5.TabIndex = 5;
            this.rd5x5.Text = "5x5";
            this.rd5x5.UseVisualStyleBackColor = true;
            this.rd5x5.CheckedChanged += new System.EventHandler(this.rd5x5_CheckedChanged);
            // 
            // rd3x3
            // 
            this.rd3x3.AutoSize = true;
            this.rd3x3.Location = new System.Drawing.Point(101, 19);
            this.rd3x3.Name = "rd3x3";
            this.rd3x3.Size = new System.Drawing.Size(45, 17);
            this.rd3x3.TabIndex = 6;
            this.rd3x3.Text = "3x3";
            this.rd3x3.UseVisualStyleBackColor = true;
            this.rd3x3.CheckedChanged += new System.EventHandler(this.rd3x3_CheckedChanged);
            // 
            // gbRadioButtons
            // 
            this.gbRadioButtons.Controls.Add(this.rd3x3);
            this.gbRadioButtons.Controls.Add(this.rd2x2);
            this.gbRadioButtons.Controls.Add(this.rd5x5);
            this.gbRadioButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRadioButtons.Location = new System.Drawing.Point(12, 294);
            this.gbRadioButtons.Name = "gbRadioButtons";
            this.gbRadioButtons.Size = new System.Drawing.Size(251, 45);
            this.gbRadioButtons.TabIndex = 7;
            this.gbRadioButtons.TabStop = false;
            this.gbRadioButtons.Text = "Tamaño";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 389);
            this.Controls.Add(this.gbRadioButtons);
            this.Controls.Add(this.TextTXT);
            this.Controls.Add(this.GuardarBTN);
            this.Controls.Add(this.GenerarBTN);
            this.Controls.Add(this.PictureBoxQr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Generador QR";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxQr)).EndInit();
            this.gbRadioButtons.ResumeLayout(false);
            this.gbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxQr;
        private System.Windows.Forms.Button GenerarBTN;
        private System.Windows.Forms.Button GuardarBTN;
        private System.Windows.Forms.TextBox TextTXT;
        private System.Windows.Forms.RadioButton rd2x2;
        private System.Windows.Forms.RadioButton rd5x5;
        private System.Windows.Forms.RadioButton rd3x3;
        private System.Windows.Forms.GroupBox gbRadioButtons;
    }
}

