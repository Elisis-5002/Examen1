namespace Examen1
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
            txSueldoInicial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            lblISR = new Label();
            lblSueldoFinal = new Label();
            SuspendLayout();
            // 
            // txSueldoInicial
            // 
            txSueldoInicial.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txSueldoInicial.Location = new Point(575, 47);
            txSueldoInicial.Name = "txSueldoInicial";
            txSueldoInicial.Size = new Size(199, 45);
            txSueldoInicial.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 1;
            label1.Text = "Sueldo Mensual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 139);
            label2.Name = "label2";
            label2.Size = new Size(191, 38);
            label2.TabIndex = 3;
            label2.Text = "ISR calculado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 229);
            label3.Name = "label3";
            label3.Size = new Size(392, 38);
            label3.TabIndex = 5;
            label3.Text = "Sueldo Neto después del ISR";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(39, 324);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(194, 56);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblISR
            // 
            lblISR.BackColor = SystemColors.ButtonHighlight;
            lblISR.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISR.Location = new Point(575, 139);
            lblISR.Name = "lblISR";
            lblISR.Size = new Size(199, 38);
            lblISR.TabIndex = 7;
            // 
            // lblSueldoFinal
            // 
            lblSueldoFinal.BackColor = SystemColors.ButtonHighlight;
            lblSueldoFinal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldoFinal.Location = new Point(575, 220);
            lblSueldoFinal.Name = "lblSueldoFinal";
            lblSueldoFinal.Size = new Size(199, 38);
            lblSueldoFinal.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSueldoFinal);
            Controls.Add(lblISR);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txSueldoInicial);
            Name = "Form1";
            Text = "Calculo del ISR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txSueldoInicial;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txSueldoFinal;
        private Button btnCalcular;
        private Label lblISR;
        private Label lblSueldoFinal;
    }
}
