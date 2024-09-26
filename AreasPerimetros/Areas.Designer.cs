namespace AreasPerimetros
{
    partial class Areas
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
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.circuloBtn = new System.Windows.Forms.Button();
            this.romboBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Areas";
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.Location = new System.Drawing.Point(316, 175);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(149, 39);
            this.btnCuadrado.TabIndex = 1;
            this.btnCuadrado.Text = "Cuadrado";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriangulo.Location = new System.Drawing.Point(163, 222);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(149, 39);
            this.btnTriangulo.TabIndex = 2;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangulo.Location = new System.Drawing.Point(484, 222);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(181, 39);
            this.btnRectangulo.TabIndex = 3;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // circuloBtn
            // 
            this.circuloBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuloBtn.Location = new System.Drawing.Point(173, 313);
            this.circuloBtn.Name = "circuloBtn";
            this.circuloBtn.Size = new System.Drawing.Size(130, 37);
            this.circuloBtn.TabIndex = 7;
            this.circuloBtn.Text = "Circulo";
            this.circuloBtn.UseVisualStyleBackColor = true;
            this.circuloBtn.Click += new System.EventHandler(this.circuloBtn_Click);
            // 
            // romboBtn
            // 
            this.romboBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romboBtn.Location = new System.Drawing.Point(503, 313);
            this.romboBtn.Name = "romboBtn";
            this.romboBtn.Size = new System.Drawing.Size(130, 37);
            this.romboBtn.TabIndex = 6;
            this.romboBtn.Text = "Rombo";
            this.romboBtn.UseVisualStyleBackColor = true;
            this.romboBtn.Click += new System.EventHandler(this.romboBtn_Click);
            // 
            // Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circuloBtn);
            this.Controls.Add(this.romboBtn);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Areas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Areas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button circuloBtn;
        private System.Windows.Forms.Button romboBtn;
    }
}