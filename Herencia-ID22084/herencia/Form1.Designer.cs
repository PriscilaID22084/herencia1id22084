
namespace herencia
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.valordos = new System.Windows.Forms.Label();
            this.valoruno = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Restar = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Italic);
            this.textBox3.Location = new System.Drawing.Point(298, 190);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(264, 41);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Italic);
            this.textBox2.Location = new System.Drawing.Point(298, 129);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 41);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(298, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 41);
            this.textBox1.TabIndex = 19;
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Resultado.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(336, 262);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(183, 41);
            this.Resultado.TabIndex = 18;
            this.Resultado.Text = "Resultado";
            // 
            // valordos
            // 
            this.valordos.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valordos.Location = new System.Drawing.Point(134, 131);
            this.valordos.Name = "valordos";
            this.valordos.Size = new System.Drawing.Size(110, 41);
            this.valordos.TabIndex = 17;
            this.valordos.Text = "Valor 2";
            // 
            // valoruno
            // 
            this.valoruno.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valoruno.Location = new System.Drawing.Point(134, 68);
            this.valoruno.Name = "valoruno";
            this.valoruno.Size = new System.Drawing.Size(110, 41);
            this.valoruno.TabIndex = 16;
            this.valoruno.Text = "Valor 1";
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Limpiar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(725, 240);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(83, 48);
            this.Limpiar.TabIndex = 15;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Dividir
            // 
            this.Dividir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dividir.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dividir.Location = new System.Drawing.Point(806, 76);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(83, 51);
            this.Dividir.TabIndex = 14;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = false;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Multiplicar
            // 
            this.Multiplicar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Multiplicar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicar.Location = new System.Drawing.Point(682, 154);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(156, 48);
            this.Multiplicar.TabIndex = 13;
            this.Multiplicar.Text = "Multiplicar";
            this.Multiplicar.UseVisualStyleBackColor = false;
            this.Multiplicar.Click += new System.EventHandler(this.Multiplicar_Click);
            // 
            // Restar
            // 
            this.Restar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Restar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restar.Location = new System.Drawing.Point(725, 76);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(75, 51);
            this.Restar.TabIndex = 12;
            this.Restar.Text = "Restar";
            this.Restar.UseVisualStyleBackColor = false;
            this.Restar.Click += new System.EventHandler(this.Restar_Click);
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Suma.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(644, 76);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 51);
            this.Suma.TabIndex = 11;
            this.Suma.Text = "Sumar";
            this.Suma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Suma.UseVisualStyleBackColor = false;
            this.Suma.Click += new System.EventHandler(this.Suma_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 429);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.valordos);
            this.Controls.Add(this.valoruno);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.Multiplicar);
            this.Controls.Add(this.Restar);
            this.Controls.Add(this.Suma);
            this.Name = "Form1";
            this.Text = "CALCULADORA BASICA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label valordos;
        private System.Windows.Forms.Label valoruno;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Restar;
        private System.Windows.Forms.Button Suma;
    }
}

