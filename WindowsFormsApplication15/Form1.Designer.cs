namespace WindowsFormsApplication15
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.rbPrasinar = new System.Windows.Forms.RadioButton();
            this.rbBugar = new System.Windows.Forms.RadioButton();
            this.rbGmaz = new System.Windows.Forms.RadioButton();
            this.btnKreni = new System.Windows.Forms.Button();
            this.lbZid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rbPrasinar
            // 
            this.rbPrasinar.AutoSize = true;
            this.rbPrasinar.Location = new System.Drawing.Point(12, 356);
            this.rbPrasinar.Name = "rbPrasinar";
            this.rbPrasinar.Size = new System.Drawing.Size(63, 17);
            this.rbPrasinar.TabIndex = 0;
            this.rbPrasinar.TabStop = true;
            this.rbPrasinar.Text = "Prašinar";
            this.rbPrasinar.UseVisualStyleBackColor = true;
            // 
            // rbBugar
            // 
            this.rbBugar.AutoSize = true;
            this.rbBugar.Location = new System.Drawing.Point(12, 379);
            this.rbBugar.Name = "rbBugar";
            this.rbBugar.Size = new System.Drawing.Size(53, 17);
            this.rbBugar.TabIndex = 1;
            this.rbBugar.TabStop = true;
            this.rbBugar.Text = "Bugar";
            this.rbBugar.UseVisualStyleBackColor = true;
            // 
            // rbGmaz
            // 
            this.rbGmaz.AutoSize = true;
            this.rbGmaz.Location = new System.Drawing.Point(12, 402);
            this.rbGmaz.Name = "rbGmaz";
            this.rbGmaz.Size = new System.Drawing.Size(52, 17);
            this.rbGmaz.TabIndex = 2;
            this.rbGmaz.TabStop = true;
            this.rbGmaz.Text = "Gmaz";
            this.rbGmaz.UseVisualStyleBackColor = true;
            // 
            // btnKreni
            // 
            this.btnKreni.Location = new System.Drawing.Point(90, 403);
            this.btnKreni.Name = "btnKreni";
            this.btnKreni.Size = new System.Drawing.Size(75, 23);
            this.btnKreni.TabIndex = 4;
            this.btnKreni.Text = "Kreni";
            this.btnKreni.UseVisualStyleBackColor = true;
            this.btnKreni.Click += new System.EventHandler(this.btnKreni_Click);
            // 
            // lbZid
            // 
            this.lbZid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbZid.Enabled = false;
            this.lbZid.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbZid.Location = new System.Drawing.Point(815, 9);
            this.lbZid.Name = "lbZid";
            this.lbZid.Size = new System.Drawing.Size(107, 40);
            this.lbZid.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 438);
            this.Controls.Add(this.lbZid);
            this.Controls.Add(this.btnKreni);
            this.Controls.Add(this.rbGmaz);
            this.Controls.Add(this.rbBugar);
            this.Controls.Add(this.rbPrasinar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPrasinar;
        private System.Windows.Forms.RadioButton rbBugar;
        private System.Windows.Forms.RadioButton rbGmaz;
        private System.Windows.Forms.Button btnKreni;
        private System.Windows.Forms.Label lbZid;
        private System.Windows.Forms.Timer timer1;

    }
}

