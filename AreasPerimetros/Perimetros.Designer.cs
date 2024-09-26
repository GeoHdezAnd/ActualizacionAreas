namespace AreasPerimetros
{
    partial class Perimetros
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCuadradoP = new System.Windows.Forms.Button();
            this.btnTrianguloP = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.romboBtn = new System.Windows.Forms.Button();
            this.circuloBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perimetros";
            // 
            // btnCuadradoP
            // 
            this.btnCuadradoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadradoP.Location = new System.Drawing.Point(333, 186);
            this.btnCuadradoP.Name = "btnCuadradoP";
            this.btnCuadradoP.Size = new System.Drawing.Size(130, 37);
            this.btnCuadradoP.TabIndex = 1;
            this.btnCuadradoP.Text = "Cuadrado";
            this.btnCuadradoP.UseVisualStyleBackColor = true;
            this.btnCuadradoP.Click += new System.EventHandler(this.btnCuadradoP_Click);
            // 
            // btnTrianguloP
            // 
            this.btnTrianguloP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrianguloP.Location = new System.Drawing.Point(182, 247);
            this.btnTrianguloP.Name = "btnTrianguloP";
            this.btnTrianguloP.Size = new System.Drawing.Size(130, 37);
            this.btnTrianguloP.TabIndex = 2;
            this.btnTrianguloP.Text = "Triangulo";
            this.btnTrianguloP.UseVisualStyleBackColor = true;
            this.btnTrianguloP.Click += new System.EventHandler(this.btnTrianguloP_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangulo.Location = new System.Drawing.Point(487, 241);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(153, 43);
            this.btnRectangulo.TabIndex = 3;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // romboBtn
            // 
            this.romboBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romboBtn.Location = new System.Drawing.Point(510, 322);
            this.romboBtn.Name = "romboBtn";
            this.romboBtn.Size = new System.Drawing.Size(130, 37);
            this.romboBtn.TabIndex = 4;
            this.romboBtn.Text = "Rombo";
            this.romboBtn.UseVisualStyleBackColor = true;
            this.romboBtn.Click += new System.EventHandler(this.romboBtn_Click);
            // 
            // circuloBtn
            // 
            this.circuloBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuloBtn.Location = new System.Drawing.Point(182, 331);
            this.circuloBtn.Name = "circuloBtn";
            this.circuloBtn.Size = new System.Drawing.Size(130, 37);
            this.circuloBtn.TabIndex = 5;
            this.circuloBtn.Text = "Circulo";
            this.circuloBtn.UseVisualStyleBackColor = true;
            this.circuloBtn.Click += new System.EventHandler(this.circuloBtn_Click);
            // 
            // Perimetros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circuloBtn);
            this.Controls.Add(this.romboBtn);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnTrianguloP);
            this.Controls.Add(this.btnCuadradoP);
            this.Controls.Add(this.label1);
            this.Name = "Perimetros";
            this.Text = "Perimetros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCuadradoP;
        private System.Windows.Forms.Button btnTrianguloP;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button romboBtn;
        private System.Windows.Forms.Button circuloBtn;
    }
}