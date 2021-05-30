namespace Youtube3D_Simulasyon
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
            this.glControl1 = new OpenTK.GLControl();
            this.btnX = new System.Windows.Forms.Button();
            this.TimerXYZ = new System.Windows.Forms.Timer(this.components);
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.btnY = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.cmbxSerialPort = new System.Windows.Forms.ComboBox();
            this.texBoundRate = new System.Windows.Forms.TextBox();
            this.btnTelemetri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OkumaNesnesi = new System.IO.Ports.SerialPort(this.components);
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.btnDurdur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblxx = new System.Windows.Forms.Label();
            this.lblyy = new System.Windows.Forms.Label();
            this.lblzz = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 26);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(810, 620);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(948, 431);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 32);
            this.btnX.TabIndex = 1;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // TimerXYZ
            // 
            this.TimerXYZ.Tick += new System.EventHandler(this.TimerXYZ_Tick);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(877, 437);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 20);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(877, 490);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 20);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(877, 541);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(19, 20);
            this.lblZ.TabIndex = 4;
            this.lblZ.Text = "Z";
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(948, 485);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(75, 31);
            this.btnY.TabIndex = 5;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(948, 535);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(75, 33);
            this.btnZ.TabIndex = 5;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // cmbxSerialPort
            // 
            this.cmbxSerialPort.FormattingEnabled = true;
            this.cmbxSerialPort.Location = new System.Drawing.Point(937, 33);
            this.cmbxSerialPort.Name = "cmbxSerialPort";
            this.cmbxSerialPort.Size = new System.Drawing.Size(164, 28);
            this.cmbxSerialPort.TabIndex = 6;
            // 
            // texBoundRate
            // 
            this.texBoundRate.Location = new System.Drawing.Point(937, 67);
            this.texBoundRate.Name = "texBoundRate";
            this.texBoundRate.Size = new System.Drawing.Size(164, 26);
            this.texBoundRate.TabIndex = 7;
            // 
            // btnTelemetri
            // 
            this.btnTelemetri.Location = new System.Drawing.Point(937, 99);
            this.btnTelemetri.Name = "btnTelemetri";
            this.btnTelemetri.Size = new System.Drawing.Size(164, 42);
            this.btnTelemetri.TabIndex = 8;
            this.btnTelemetri.Text = "BAĞLAN";
            this.btnTelemetri.UseVisualStyleBackColor = true;
            this.btnTelemetri.Click += new System.EventHandler(this.btnTelemetri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bound Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(836, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Serial Port";
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(937, 147);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(164, 41);
            this.btnDurdur.TabIndex = 10;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(900, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(968, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1050, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "z";
            // 
            // lblxx
            // 
            this.lblxx.AutoSize = true;
            this.lblxx.Location = new System.Drawing.Point(888, 296);
            this.lblxx.Name = "lblxx";
            this.lblxx.Size = new System.Drawing.Size(51, 20);
            this.lblxx.TabIndex = 14;
            this.lblxx.Text = "label6";
            // 
            // lblyy
            // 
            this.lblyy.AutoSize = true;
            this.lblyy.Location = new System.Drawing.Point(957, 296);
            this.lblyy.Name = "lblyy";
            this.lblyy.Size = new System.Drawing.Size(51, 20);
            this.lblyy.TabIndex = 15;
            this.lblyy.Text = "label7";
            // 
            // lblzz
            // 
            this.lblzz.AutoSize = true;
            this.lblzz.Location = new System.Drawing.Point(1031, 296);
            this.lblzz.Name = "lblzz";
            this.lblzz.Size = new System.Drawing.Size(51, 20);
            this.lblzz.TabIndex = 16;
            this.lblzz.Text = "label8";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(840, 110);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(67, 31);
            this.btnColor.TabIndex = 17;
            this.btnColor.Text = "Renk1";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.Location = new System.Drawing.Point(839, 147);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(68, 30);
            this.btnColor2.TabIndex = 18;
            this.btnColor2.Text = "Renk2";
            this.btnColor2.UseVisualStyleBackColor = true;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 663);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblzz);
            this.Controls.Add(this.lblyy);
            this.Controls.Add(this.lblxx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTelemetri);
            this.Controls.Add(this.texBoundRate);
            this.Controls.Add(this.cmbxSerialPort);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.glControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Timer TimerXYZ;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnZ;
        private System.Windows.Forms.ComboBox cmbxSerialPort;
        private System.Windows.Forms.TextBox texBoundRate;
        private System.Windows.Forms.Button btnTelemetri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort OkumaNesnesi;
        private System.Windows.Forms.Timer Zamanlayici;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblxx;
        private System.Windows.Forms.Label lblyy;
        private System.Windows.Forms.Label lblzz;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnColor2;
    }
}

