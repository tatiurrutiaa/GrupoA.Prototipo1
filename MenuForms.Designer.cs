﻿namespace GrupoA.Prototipo
{
    partial class MenuForms
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 21);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 0;
            label1.Text = "Por favor, seleccione una opción.";
            // 
            // button1
            // 
            button1.Location = new Point(35, 48);
            button1.Name = "button1";
            button1.Size = new Size(232, 23);
            button1.TabIndex = 1;
            button1.Text = "Cargar una Orden de Preparación";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(35, 77);
            button2.Name = "button2";
            button2.Size = new Size(232, 23);
            button2.TabIndex = 2;
            button2.Text = "Generar una Orden de Selección";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(35, 106);
            button3.Name = "button3";
            button3.Size = new Size(232, 23);
            button3.TabIndex = 3;
            button3.Text = "Seleccionar Ordenes a empaquetar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(35, 135);
            button4.Name = "button4";
            button4.Size = new Size(232, 23);
            button4.TabIndex = 4;
            button4.Text = "Crear Ordenes de Entrega";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(35, 164);
            button5.Name = "button5";
            button5.Size = new Size(232, 23);
            button5.TabIndex = 5;
            button5.Text = "Verificar transportista";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(35, 193);
            button6.Name = "button6";
            button6.Size = new Size(232, 23);
            button6.TabIndex = 6;
            button6.Text = "Crear Remito";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(107, 222);
            button7.Name = "button7";
            button7.Size = new Size(86, 23);
            button7.TabIndex = 7;
            button7.Text = "Salir";
            button7.UseVisualStyleBackColor = true;
            // 
            // MenuForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 266);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MenuForms";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}