namespace SuperHeroes
{
    partial class Form1
    {
     
        private System.ComponentModel.IContainer components = null;

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

       
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreHeroe = new System.Windows.Forms.TextBox();
            this.txtNombreReal = new System.Windows.Forms.TextBox();
            this.txtPoder = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvHeroes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Héroe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Real";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Poder";
            // 
            // txtNombreHeroe
            // 
            this.txtNombreHeroe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreHeroe.Location = new System.Drawing.Point(302, 91);
            this.txtNombreHeroe.Name = "txtNombreHeroe";
            this.txtNombreHeroe.Size = new System.Drawing.Size(195, 33);
            this.txtNombreHeroe.TabIndex = 3;
            // 
            // txtNombreReal
            // 
            this.txtNombreReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreReal.Location = new System.Drawing.Point(302, 141);
            this.txtNombreReal.Name = "txtNombreReal";
            this.txtNombreReal.Size = new System.Drawing.Size(195, 33);
            this.txtNombreReal.TabIndex = 4;
            // 
            // txtPoder
            // 
            this.txtPoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoder.Location = new System.Drawing.Point(302, 188);
            this.txtPoder.Name = "txtPoder";
            this.txtPoder.Size = new System.Drawing.Size(195, 33);
            this.txtPoder.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(197, 264);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(172, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Insertar Héroe";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvHeroes
            // 
            this.dgvHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeroes.Location = new System.Drawing.Point(82, 315);
            this.dgvHeroes.Name = "dgvHeroes";
            this.dgvHeroes.RowHeadersWidth = 47;
            this.dgvHeroes.Size = new System.Drawing.Size(586, 220);
            this.dgvHeroes.TabIndex = 7;
            this.dgvHeroes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeroes_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 681);
            this.Controls.Add(this.dgvHeroes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPoder);
            this.Controls.Add(this.txtNombreReal);
            this.Controls.Add(this.txtNombreHeroe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreHeroe;
        private System.Windows.Forms.TextBox txtNombreReal;
        private System.Windows.Forms.TextBox txtPoder;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvHeroes;
    }
}

