namespace Calculadora_UTN
{
    partial class FrmCalculadora
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
            lblResultado = new Label();
            grpDecimalBinario = new GroupBox();
            radBinario = new RadioButton();
            radDecimal = new RadioButton();
            txtOperandoUno = new TextBox();
            txtOperandoDos = new TextBox();
            cboxOperador = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grpDecimalBinario.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(50, 50);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(147, 37);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado: ";
            // 
            // grpDecimalBinario
            // 
            grpDecimalBinario.Controls.Add(radBinario);
            grpDecimalBinario.Controls.Add(radDecimal);
            grpDecimalBinario.Location = new Point(184, 125);
            grpDecimalBinario.Name = "grpDecimalBinario";
            grpDecimalBinario.Size = new Size(177, 60);
            grpDecimalBinario.TabIndex = 1;
            grpDecimalBinario.TabStop = false;
            grpDecimalBinario.Text = "Representar resultado en:";
            // 
            // radBinario
            // 
            radBinario.AutoSize = true;
            radBinario.Location = new Point(112, 30);
            radBinario.Name = "radBinario";
            radBinario.Size = new Size(62, 19);
            radBinario.TabIndex = 1;
            radBinario.TabStop = true;
            radBinario.Text = "Binario";
            radBinario.UseVisualStyleBackColor = true;
            // 
            // radDecimal
            // 
            radDecimal.AutoSize = true;
            radDecimal.Location = new Point(6, 30);
            radDecimal.Name = "radDecimal";
            radDecimal.Size = new Size(68, 19);
            radDecimal.TabIndex = 0;
            radDecimal.TabStop = true;
            radDecimal.Text = "Decimal";
            radDecimal.UseVisualStyleBackColor = true;
            // 
            // txtOperandoUno
            // 
            txtOperandoUno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOperandoUno.Location = new Point(67, 260);
            txtOperandoUno.Name = "txtOperandoUno";
            txtOperandoUno.Size = new Size(130, 29);
            txtOperandoUno.TabIndex = 2;
            // 
            // txtOperandoDos
            // 
            txtOperandoDos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOperandoDos.Location = new Point(364, 260);
            txtOperandoDos.Name = "txtOperandoDos";
            txtOperandoDos.Size = new Size(130, 29);
            txtOperandoDos.TabIndex = 3;
            // 
            // cboxOperador
            // 
            cboxOperador.FormattingEnabled = true;
            cboxOperador.Location = new Point(234, 260);
            cboxOperador.Name = "cboxOperador";
            cboxOperador.Size = new Size(88, 23);
            cboxOperador.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 227);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 5;
            label1.Text = "Primero Operando:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(364, 227);
            label2.Name = "label2";
            label2.Size = new Size(162, 21);
            label2.TabIndex = 6;
            label2.Text = "Segundo Operando:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(235, 227);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 7;
            label3.Text = "Operador:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboxOperador);
            Controls.Add(txtOperandoDos);
            Controls.Add(txtOperandoUno);
            Controls.Add(grpDecimalBinario);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Alumno: Alejandro García Bouzada";
            grpDecimalBinario.ResumeLayout(false);
            grpDecimalBinario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private GroupBox grpDecimalBinario;
        private RadioButton radBinario;
        private RadioButton radDecimal;
        private TextBox txtOperandoUno;
        private TextBox txtOperandoDos;
        private ComboBox cboxOperador;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}