namespace Calculadora_2._0
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
            adicao = new Button();
            div = new Button();
            multi = new Button();
            subt = new Button();
            label1 = new Label();
            label2 = new Label();
            labresultado = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            SuspendLayout();
            // 
            // adicao
            // 
            adicao.Location = new Point(40, 102);
            adicao.Name = "adicao";
            adicao.Size = new Size(41, 41);
            adicao.TabIndex = 0;
            adicao.Text = "+";
            adicao.UseVisualStyleBackColor = true;
            adicao.Click += adicao_Click;
            // 
            // div
            // 
            div.Location = new Point(87, 149);
            div.Name = "div";
            div.Size = new Size(41, 41);
            div.TabIndex = 1;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // multi
            // 
            multi.Location = new Point(40, 149);
            multi.Name = "multi";
            multi.Size = new Size(41, 41);
            multi.TabIndex = 2;
            multi.Text = "*";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // subt
            // 
            subt.Location = new Point(87, 102);
            subt.Name = "subt";
            subt.Size = new Size(41, 41);
            subt.TabIndex = 3;
            subt.Text = "-";
            subt.UseVisualStyleBackColor = true;
            subt.Click += subt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 48);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Número 2";
            // 
            // labresultado
            // 
            labresultado.AutoSize = true;
            labresultado.Location = new Point(3, 80);
            labresultado.Name = "labresultado";
            labresultado.Size = new Size(62, 15);
            labresultado.TabIndex = 6;
            labresultado.Text = "Resultado:";
            // 
            // num1
            // 
            num1.Location = new Point(69, 12);
            num1.Name = "num1";
            num1.Size = new Size(88, 23);
            num1.TabIndex = 7;
            // 
            // num2
            // 
            num2.Location = new Point(69, 45);
            num2.Name = "num2";
            num2.Size = new Size(88, 23);
            num2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(164, 196);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(labresultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(subt);
            Controls.Add(multi);
            Controls.Add(div);
            Controls.Add(adicao);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button adicao;
        private Button div;
        private Button multi;
        private Button subt;
        private Label label1;
        private Label label2;
        private Label labresultado;
        private TextBox num1;
        private TextBox num2;
    }
}
