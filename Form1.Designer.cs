namespace budicMarinEmailSender1
{
    partial class Form
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPrim = new System.Windows.Forms.Label();
            this.textBoxPrimatelj = new System.Windows.Forms.TextBox();
            this.labelPred = new System.Windows.Forms.Label();
            this.textBoxPredmet = new System.Windows.Forms.TextBox();
            this.labelPoruka = new System.Windows.Forms.Label();
            this.textBoxPoruka = new System.Windows.Forms.TextBox();
            this.buttonPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(13, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(206, 32);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username/mail";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(13, 55);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(139, 32);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(604, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(604, 65);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(173, 22);
            this.textBoxPass.TabIndex = 3;
            // 
            // labelPrim
            // 
            this.labelPrim.AutoSize = true;
            this.labelPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrim.Location = new System.Drawing.Point(13, 99);
            this.labelPrim.Name = "labelPrim";
            this.labelPrim.Size = new System.Drawing.Size(127, 32);
            this.labelPrim.TabIndex = 4;
            this.labelPrim.Text = "Primatelj";
            // 
            // textBoxPrimatelj
            // 
            this.textBoxPrimatelj.Location = new System.Drawing.Point(604, 109);
            this.textBoxPrimatelj.Name = "textBoxPrimatelj";
            this.textBoxPrimatelj.Size = new System.Drawing.Size(173, 22);
            this.textBoxPrimatelj.TabIndex = 5;
            // 
            // labelPred
            // 
            this.labelPred.AutoSize = true;
            this.labelPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPred.Location = new System.Drawing.Point(13, 146);
            this.labelPred.Name = "labelPred";
            this.labelPred.Size = new System.Drawing.Size(122, 32);
            this.labelPred.TabIndex = 6;
            this.labelPred.Text = "Predmet";
            // 
            // textBoxPredmet
            // 
            this.textBoxPredmet.Location = new System.Drawing.Point(604, 156);
            this.textBoxPredmet.Name = "textBoxPredmet";
            this.textBoxPredmet.Size = new System.Drawing.Size(173, 22);
            this.textBoxPredmet.TabIndex = 7;
            // 
            // labelPoruka
            // 
            this.labelPoruka.AutoSize = true;
            this.labelPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoruka.Location = new System.Drawing.Point(13, 190);
            this.labelPoruka.Name = "labelPoruka";
            this.labelPoruka.Size = new System.Drawing.Size(105, 32);
            this.labelPoruka.TabIndex = 8;
            this.labelPoruka.Text = "Poruka";
            // 
            // textBoxPoruka
            // 
            this.textBoxPoruka.Location = new System.Drawing.Point(250, 200);
            this.textBoxPoruka.Multiline = true;
            this.textBoxPoruka.Name = "textBoxPoruka";
            this.textBoxPoruka.Size = new System.Drawing.Size(527, 193);
            this.textBoxPoruka.TabIndex = 9;
            // 
            // buttonPosalji
            // 
            this.buttonPosalji.Location = new System.Drawing.Point(702, 449);
            this.buttonPosalji.Name = "buttonPosalji";
            this.buttonPosalji.Size = new System.Drawing.Size(75, 23);
            this.buttonPosalji.TabIndex = 10;
            this.buttonPosalji.Text = "Pošalji";
            this.buttonPosalji.UseVisualStyleBackColor = true;
            this.buttonPosalji.Click += new System.EventHandler(this.buttonPosalji_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 522);
            this.Controls.Add(this.buttonPosalji);
            this.Controls.Add(this.textBoxPoruka);
            this.Controls.Add(this.labelPoruka);
            this.Controls.Add(this.textBoxPredmet);
            this.Controls.Add(this.labelPred);
            this.Controls.Add(this.textBoxPrimatelj);
            this.Controls.Add(this.labelPrim);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPrim;
        private System.Windows.Forms.TextBox textBoxPrimatelj;
        private System.Windows.Forms.Label labelPred;
        private System.Windows.Forms.TextBox textBoxPredmet;
        private System.Windows.Forms.Label labelPoruka;
        private System.Windows.Forms.TextBox textBoxPoruka;
        private System.Windows.Forms.Button buttonPosalji;
    }
}

