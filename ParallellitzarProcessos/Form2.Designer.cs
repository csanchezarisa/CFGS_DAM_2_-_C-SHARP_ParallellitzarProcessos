
namespace ParallellitzarProcessos
{
    partial class Form2
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
            this.titleSequential = new System.Windows.Forms.Label();
            this.btnSeq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPar = new System.Windows.Forms.Button();
            this.txtSeq = new System.Windows.Forms.Label();
            this.txtPar = new System.Windows.Forms.Label();
            this.progressSeq = new System.Windows.Forms.ProgressBar();
            this.progressPar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressInvoke = new System.Windows.Forms.ProgressBar();
            this.txtInvoke = new System.Windows.Forms.Label();
            this.btnInvoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleSequential
            // 
            this.titleSequential.AutoSize = true;
            this.titleSequential.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSequential.Location = new System.Drawing.Point(12, 9);
            this.titleSequential.Name = "titleSequential";
            this.titleSequential.Size = new System.Drawing.Size(425, 39);
            this.titleSequential.TabIndex = 0;
            this.titleSequential.Text = "Comprovació Seqüencial";
            // 
            // btnSeq
            // 
            this.btnSeq.Location = new System.Drawing.Point(19, 51);
            this.btnSeq.Name = "btnSeq";
            this.btnSeq.Size = new System.Drawing.Size(75, 23);
            this.btnSeq.TabIndex = 1;
            this.btnSeq.Text = "Comprovar";
            this.btnSeq.UseVisualStyleBackColor = true;
            this.btnSeq.Click += new System.EventHandler(this.btnSeq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comprovació Paral·lela";
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(19, 159);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(75, 23);
            this.btnPar.TabIndex = 3;
            this.btnPar.Text = "Comprovar";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // txtSeq
            // 
            this.txtSeq.AutoSize = true;
            this.txtSeq.Location = new System.Drawing.Point(100, 56);
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.Size = new System.Drawing.Size(42, 13);
            this.txtSeq.TabIndex = 4;
            this.txtSeq.Text = "Temps:";
            // 
            // txtPar
            // 
            this.txtPar.AutoSize = true;
            this.txtPar.Location = new System.Drawing.Point(100, 164);
            this.txtPar.Name = "txtPar";
            this.txtPar.Size = new System.Drawing.Size(42, 13);
            this.txtPar.TabIndex = 5;
            this.txtPar.Text = "Temps:";
            // 
            // progressSeq
            // 
            this.progressSeq.Location = new System.Drawing.Point(19, 80);
            this.progressSeq.Name = "progressSeq";
            this.progressSeq.Size = new System.Drawing.Size(418, 23);
            this.progressSeq.TabIndex = 6;
            // 
            // progressPar
            // 
            this.progressPar.Location = new System.Drawing.Point(19, 188);
            this.progressPar.Name = "progressPar";
            this.progressPar.Size = new System.Drawing.Size(418, 23);
            this.progressPar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Comprovació Invoke";
            // 
            // progressInvoke
            // 
            this.progressInvoke.Location = new System.Drawing.Point(19, 303);
            this.progressInvoke.Name = "progressInvoke";
            this.progressInvoke.Size = new System.Drawing.Size(418, 23);
            this.progressInvoke.TabIndex = 11;
            // 
            // txtInvoke
            // 
            this.txtInvoke.AutoSize = true;
            this.txtInvoke.Location = new System.Drawing.Point(100, 279);
            this.txtInvoke.Name = "txtInvoke";
            this.txtInvoke.Size = new System.Drawing.Size(42, 13);
            this.txtInvoke.TabIndex = 10;
            this.txtInvoke.Text = "Temps:";
            // 
            // btnInvoke
            // 
            this.btnInvoke.Location = new System.Drawing.Point(19, 274);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(75, 23);
            this.btnInvoke.TabIndex = 9;
            this.btnInvoke.Text = "Comprovar";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressInvoke);
            this.Controls.Add(this.txtInvoke);
            this.Controls.Add(this.btnInvoke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressPar);
            this.Controls.Add(this.progressSeq);
            this.Controls.Add(this.txtPar);
            this.Controls.Add(this.txtSeq);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeq);
            this.Controls.Add(this.titleSequential);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleSequential;
        private System.Windows.Forms.Button btnSeq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.Label txtSeq;
        private System.Windows.Forms.Label txtPar;
        private System.Windows.Forms.ProgressBar progressSeq;
        private System.Windows.Forms.ProgressBar progressPar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressInvoke;
        private System.Windows.Forms.Label txtInvoke;
        private System.Windows.Forms.Button btnInvoke;
    }
}