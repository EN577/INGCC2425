﻿namespace P5_INGCC2425
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
            label1 = new Label();
            txtPrecio = new TextBox();
            btnCalcularPrecio = new Button();
            txtTelegrama = new TextBox();
            label2 = new Label();
            radioButtonOr = new RadioButton();
            radioButtonUr = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(72, 329);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(339, 304);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(148, 48);
            btnCalcularPrecio.TabIndex = 4;
            btnCalcularPrecio.Text = "Calcular";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(28, 47);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(459, 189);
            txtTelegrama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 332);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Coste:";
            // 
            // radioButtonOr
            // 
            radioButtonOr.AutoSize = true;
            radioButtonOr.Checked = true;
            radioButtonOr.Location = new Point(28, 292);
            radioButtonOr.Name = "radioButtonOr";
            radioButtonOr.Size = new Size(75, 19);
            radioButtonOr.TabIndex = 6;
            radioButtonOr.TabStop = true;
            radioButtonOr.Text = "Ordinario";
            radioButtonOr.UseVisualStyleBackColor = true;
            // 
            // radioButtonUr
            // 
            radioButtonUr.AutoSize = true;
            radioButtonUr.Location = new Point(142, 292);
            radioButtonUr.Name = "radioButtonUr";
            radioButtonUr.Size = new Size(67, 19);
            radioButtonUr.TabIndex = 7;
            radioButtonUr.TabStop = true;
            radioButtonUr.Text = "Urgente";
            radioButtonUr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 393);
            Controls.Add(radioButtonUr);
            Controls.Add(radioButtonOr);
            Controls.Add(label2);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Práctica Telegrama, CC 1DAM-O";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrecio;
        private Button btnCalcularPrecio;
        private TextBox txtTelegrama;
        private Label label2;
        private RadioButton radioButtonOr;
        private RadioButton radioButtonUr;
    }
}
