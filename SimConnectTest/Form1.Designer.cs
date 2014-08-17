namespace SimConnectTest
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnData = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCOM2 = new System.Windows.Forms.Button();
            this.btnCOM1 = new System.Windows.Forms.Button();
            this.btnCOM1MHzUp = new System.Windows.Forms.Button();
            this.btnCOM1KHzUp = new System.Windows.Forms.Button();
            this.btnCOM1MHzDown = new System.Windows.Forms.Button();
            this.btnCOM1KHzDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCOM1Active = new System.Windows.Forms.TextBox();
            this.txtCOM1Standby = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCOM2Standby = new System.Windows.Forms.TextBox();
            this.txtCOM2Active = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCOM2KHzDown = new System.Windows.Forms.Button();
            this.btnCOM2MHzUp = new System.Windows.Forms.Button();
            this.btnCOM2MHzDown = new System.Windows.Forms.Button();
            this.btnCOM2KHzUp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNAV1Standby = new System.Windows.Forms.TextBox();
            this.txtNAV1Active = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNAV1KHzDown = new System.Windows.Forms.Button();
            this.btnNAV1 = new System.Windows.Forms.Button();
            this.btnNAV1MHzUp = new System.Windows.Forms.Button();
            this.btnNAV1MHzDown = new System.Windows.Forms.Button();
            this.btnNAV1KHzUp = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNAV2Standby = new System.Windows.Forms.TextBox();
            this.txtNAV2Active = new System.Windows.Forms.TextBox();
            this.btnNAV2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNAV2KHzDown = new System.Windows.Forms.Button();
            this.btnNAV2MHzUp = new System.Windows.Forms.Button();
            this.btnNAV2MHzDown = new System.Windows.Forms.Button();
            this.btnNAV2KHzUp = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTransponderOff = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnTransponderSby = new System.Windows.Forms.Button();
            this.btnTransponderTst = new System.Windows.Forms.Button();
            this.btnTransponderOn = new System.Windows.Forms.Button();
            this.btnTransponderAlt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTransponder = new System.Windows.Forms.TextBox();
            this.btnTransponderIdent = new System.Windows.Forms.Button();
            this.btnTransponder0 = new System.Windows.Forms.Button();
            this.btnTransponder1 = new System.Windows.Forms.Button();
            this.btnTransponder2 = new System.Windows.Forms.Button();
            this.btnTransponder3 = new System.Windows.Forms.Button();
            this.btnTransponder4 = new System.Windows.Forms.Button();
            this.btnTransponder5 = new System.Windows.Forms.Button();
            this.btnTransponder6 = new System.Windows.Forms.Button();
            this.btnTransponder7 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(249, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to Prepare3D";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(267, 12);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(249, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "disconnect from Prepar3D";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 546);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1014, 220);
            this.txtOutput.TabIndex = 2;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(522, 12);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(249, 23);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "Request Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(777, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(249, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send Data";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCOM2
            // 
            this.btnCOM2.Location = new System.Drawing.Point(7, 78);
            this.btnCOM2.Name = "btnCOM2";
            this.btnCOM2.Size = new System.Drawing.Size(172, 23);
            this.btnCOM2.TabIndex = 5;
            this.btnCOM2.Text = "Flip COM2";
            this.btnCOM2.UseVisualStyleBackColor = true;
            this.btnCOM2.Click += new System.EventHandler(this.btnCOM2_Click);
            // 
            // btnCOM1
            // 
            this.btnCOM1.Location = new System.Drawing.Point(7, 79);
            this.btnCOM1.Name = "btnCOM1";
            this.btnCOM1.Size = new System.Drawing.Size(172, 23);
            this.btnCOM1.TabIndex = 6;
            this.btnCOM1.Text = "Flip COM1";
            this.btnCOM1.UseVisualStyleBackColor = true;
            this.btnCOM1.Click += new System.EventHandler(this.btnCOM1_Click);
            // 
            // btnCOM1MHzUp
            // 
            this.btnCOM1MHzUp.Location = new System.Drawing.Point(7, 20);
            this.btnCOM1MHzUp.Name = "btnCOM1MHzUp";
            this.btnCOM1MHzUp.Size = new System.Drawing.Size(83, 23);
            this.btnCOM1MHzUp.TabIndex = 7;
            this.btnCOM1MHzUp.Text = "MHz+";
            this.btnCOM1MHzUp.UseVisualStyleBackColor = true;
            this.btnCOM1MHzUp.Click += new System.EventHandler(this.btnCOM1MHzUp_Click);
            // 
            // btnCOM1KHzUp
            // 
            this.btnCOM1KHzUp.Location = new System.Drawing.Point(96, 20);
            this.btnCOM1KHzUp.Name = "btnCOM1KHzUp";
            this.btnCOM1KHzUp.Size = new System.Drawing.Size(83, 23);
            this.btnCOM1KHzUp.TabIndex = 8;
            this.btnCOM1KHzUp.Text = "KHz+";
            this.btnCOM1KHzUp.UseVisualStyleBackColor = true;
            this.btnCOM1KHzUp.Click += new System.EventHandler(this.btnCOM1KHzUp_Click);
            // 
            // btnCOM1MHzDown
            // 
            this.btnCOM1MHzDown.Location = new System.Drawing.Point(7, 49);
            this.btnCOM1MHzDown.Name = "btnCOM1MHzDown";
            this.btnCOM1MHzDown.Size = new System.Drawing.Size(83, 23);
            this.btnCOM1MHzDown.TabIndex = 9;
            this.btnCOM1MHzDown.Text = "MHZ-";
            this.btnCOM1MHzDown.UseVisualStyleBackColor = true;
            this.btnCOM1MHzDown.Click += new System.EventHandler(this.btnCOM1MHzDown_Click);
            // 
            // btnCOM1KHzDown
            // 
            this.btnCOM1KHzDown.Location = new System.Drawing.Point(96, 49);
            this.btnCOM1KHzDown.Name = "btnCOM1KHzDown";
            this.btnCOM1KHzDown.Size = new System.Drawing.Size(83, 23);
            this.btnCOM1KHzDown.TabIndex = 10;
            this.btnCOM1KHzDown.Text = "KHz-";
            this.btnCOM1KHzDown.UseVisualStyleBackColor = true;
            this.btnCOM1KHzDown.Click += new System.EventHandler(this.btnCOM1KHzDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCOM1Standby);
            this.groupBox1.Controls.Add(this.txtCOM1Active);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCOM1KHzDown);
            this.groupBox1.Controls.Add(this.btnCOM1);
            this.groupBox1.Controls.Add(this.btnCOM1MHzUp);
            this.groupBox1.Controls.Add(this.btnCOM1MHzDown);
            this.groupBox1.Controls.Add(this.btnCOM1KHzUp);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 113);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Standby";
            // 
            // txtCOM1Active
            // 
            this.txtCOM1Active.Location = new System.Drawing.Point(258, 23);
            this.txtCOM1Active.Name = "txtCOM1Active";
            this.txtCOM1Active.ReadOnly = true;
            this.txtCOM1Active.Size = new System.Drawing.Size(77, 20);
            this.txtCOM1Active.TabIndex = 12;
            // 
            // txtCOM1Standby
            // 
            this.txtCOM1Standby.Location = new System.Drawing.Point(258, 52);
            this.txtCOM1Standby.Name = "txtCOM1Standby";
            this.txtCOM1Standby.ReadOnly = true;
            this.txtCOM1Standby.Size = new System.Drawing.Size(77, 20);
            this.txtCOM1Standby.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCOM2Standby);
            this.groupBox2.Controls.Add(this.txtCOM2Active);
            this.groupBox2.Controls.Add(this.btnCOM2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCOM2KHzDown);
            this.groupBox2.Controls.Add(this.btnCOM2MHzUp);
            this.groupBox2.Controls.Add(this.btnCOM2MHzDown);
            this.groupBox2.Controls.Add(this.btnCOM2KHzUp);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 113);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COM2";
            // 
            // txtCOM2Standby
            // 
            this.txtCOM2Standby.Location = new System.Drawing.Point(258, 52);
            this.txtCOM2Standby.Name = "txtCOM2Standby";
            this.txtCOM2Standby.ReadOnly = true;
            this.txtCOM2Standby.Size = new System.Drawing.Size(77, 20);
            this.txtCOM2Standby.TabIndex = 14;
            // 
            // txtCOM2Active
            // 
            this.txtCOM2Active.Location = new System.Drawing.Point(258, 23);
            this.txtCOM2Active.Name = "txtCOM2Active";
            this.txtCOM2Active.ReadOnly = true;
            this.txtCOM2Active.Size = new System.Drawing.Size(77, 20);
            this.txtCOM2Active.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Standby";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Active";
            // 
            // btnCOM2KHzDown
            // 
            this.btnCOM2KHzDown.Location = new System.Drawing.Point(96, 49);
            this.btnCOM2KHzDown.Name = "btnCOM2KHzDown";
            this.btnCOM2KHzDown.Size = new System.Drawing.Size(83, 23);
            this.btnCOM2KHzDown.TabIndex = 10;
            this.btnCOM2KHzDown.Text = "KHz-";
            this.btnCOM2KHzDown.UseVisualStyleBackColor = true;
            this.btnCOM2KHzDown.Click += new System.EventHandler(this.btnCOM2KHzDown_Click);
            // 
            // btnCOM2MHzUp
            // 
            this.btnCOM2MHzUp.Location = new System.Drawing.Point(7, 20);
            this.btnCOM2MHzUp.Name = "btnCOM2MHzUp";
            this.btnCOM2MHzUp.Size = new System.Drawing.Size(83, 23);
            this.btnCOM2MHzUp.TabIndex = 7;
            this.btnCOM2MHzUp.Text = "MHz+";
            this.btnCOM2MHzUp.UseVisualStyleBackColor = true;
            this.btnCOM2MHzUp.Click += new System.EventHandler(this.btnCOM2MHzUp_Click);
            // 
            // btnCOM2MHzDown
            // 
            this.btnCOM2MHzDown.Location = new System.Drawing.Point(7, 49);
            this.btnCOM2MHzDown.Name = "btnCOM2MHzDown";
            this.btnCOM2MHzDown.Size = new System.Drawing.Size(83, 23);
            this.btnCOM2MHzDown.TabIndex = 9;
            this.btnCOM2MHzDown.Text = "MHZ-";
            this.btnCOM2MHzDown.UseVisualStyleBackColor = true;
            this.btnCOM2MHzDown.Click += new System.EventHandler(this.btnCOM2MHzDown_Click);
            // 
            // btnCOM2KHzUp
            // 
            this.btnCOM2KHzUp.Location = new System.Drawing.Point(96, 20);
            this.btnCOM2KHzUp.Name = "btnCOM2KHzUp";
            this.btnCOM2KHzUp.Size = new System.Drawing.Size(83, 23);
            this.btnCOM2KHzUp.TabIndex = 8;
            this.btnCOM2KHzUp.Text = "KHz+";
            this.btnCOM2KHzUp.UseVisualStyleBackColor = true;
            this.btnCOM2KHzUp.Click += new System.EventHandler(this.btnCOM2KHzUp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNAV1Standby);
            this.groupBox3.Controls.Add(this.txtNAV1Active);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnNAV1KHzDown);
            this.groupBox3.Controls.Add(this.btnNAV1);
            this.groupBox3.Controls.Add(this.btnNAV1MHzUp);
            this.groupBox3.Controls.Add(this.btnNAV1MHzDown);
            this.groupBox3.Controls.Add(this.btnNAV1KHzUp);
            this.groupBox3.Location = new System.Drawing.Point(522, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 113);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NAV1";
            // 
            // txtNAV1Standby
            // 
            this.txtNAV1Standby.Location = new System.Drawing.Point(258, 52);
            this.txtNAV1Standby.Name = "txtNAV1Standby";
            this.txtNAV1Standby.ReadOnly = true;
            this.txtNAV1Standby.Size = new System.Drawing.Size(77, 20);
            this.txtNAV1Standby.TabIndex = 14;
            // 
            // txtNAV1Active
            // 
            this.txtNAV1Active.Location = new System.Drawing.Point(258, 23);
            this.txtNAV1Active.Name = "txtNAV1Active";
            this.txtNAV1Active.ReadOnly = true;
            this.txtNAV1Active.Size = new System.Drawing.Size(77, 20);
            this.txtNAV1Active.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Standby";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Active";
            // 
            // btnNAV1KHzDown
            // 
            this.btnNAV1KHzDown.Location = new System.Drawing.Point(96, 49);
            this.btnNAV1KHzDown.Name = "btnNAV1KHzDown";
            this.btnNAV1KHzDown.Size = new System.Drawing.Size(83, 23);
            this.btnNAV1KHzDown.TabIndex = 10;
            this.btnNAV1KHzDown.Text = "KHz-";
            this.btnNAV1KHzDown.UseVisualStyleBackColor = true;
            this.btnNAV1KHzDown.Click += new System.EventHandler(this.btnNAV1KHzDown_Click);
            // 
            // btnNAV1
            // 
            this.btnNAV1.Location = new System.Drawing.Point(7, 79);
            this.btnNAV1.Name = "btnNAV1";
            this.btnNAV1.Size = new System.Drawing.Size(172, 23);
            this.btnNAV1.TabIndex = 6;
            this.btnNAV1.Text = "Flip NAV1";
            this.btnNAV1.UseVisualStyleBackColor = true;
            this.btnNAV1.Click += new System.EventHandler(this.btnNAV1_Click);
            // 
            // btnNAV1MHzUp
            // 
            this.btnNAV1MHzUp.Location = new System.Drawing.Point(7, 20);
            this.btnNAV1MHzUp.Name = "btnNAV1MHzUp";
            this.btnNAV1MHzUp.Size = new System.Drawing.Size(83, 23);
            this.btnNAV1MHzUp.TabIndex = 7;
            this.btnNAV1MHzUp.Text = "MHz+";
            this.btnNAV1MHzUp.UseVisualStyleBackColor = true;
            this.btnNAV1MHzUp.Click += new System.EventHandler(this.btnNAV1MHzUp_Click);
            // 
            // btnNAV1MHzDown
            // 
            this.btnNAV1MHzDown.Location = new System.Drawing.Point(7, 49);
            this.btnNAV1MHzDown.Name = "btnNAV1MHzDown";
            this.btnNAV1MHzDown.Size = new System.Drawing.Size(83, 23);
            this.btnNAV1MHzDown.TabIndex = 9;
            this.btnNAV1MHzDown.Text = "MHZ-";
            this.btnNAV1MHzDown.UseVisualStyleBackColor = true;
            this.btnNAV1MHzDown.Click += new System.EventHandler(this.btnNAV1MHzDown_Click);
            // 
            // btnNAV1KHzUp
            // 
            this.btnNAV1KHzUp.Location = new System.Drawing.Point(96, 20);
            this.btnNAV1KHzUp.Name = "btnNAV1KHzUp";
            this.btnNAV1KHzUp.Size = new System.Drawing.Size(83, 23);
            this.btnNAV1KHzUp.TabIndex = 8;
            this.btnNAV1KHzUp.Text = "KHz+";
            this.btnNAV1KHzUp.UseVisualStyleBackColor = true;
            this.btnNAV1KHzUp.Click += new System.EventHandler(this.btnNAV1KHzUp_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNAV2Standby);
            this.groupBox4.Controls.Add(this.txtNAV2Active);
            this.groupBox4.Controls.Add(this.btnNAV2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnNAV2KHzDown);
            this.groupBox4.Controls.Add(this.btnNAV2MHzUp);
            this.groupBox4.Controls.Add(this.btnNAV2MHzDown);
            this.groupBox4.Controls.Add(this.btnNAV2KHzUp);
            this.groupBox4.Location = new System.Drawing.Point(522, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 113);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NAV2";
            // 
            // txtNAV2Standby
            // 
            this.txtNAV2Standby.Location = new System.Drawing.Point(258, 52);
            this.txtNAV2Standby.Name = "txtNAV2Standby";
            this.txtNAV2Standby.ReadOnly = true;
            this.txtNAV2Standby.Size = new System.Drawing.Size(77, 20);
            this.txtNAV2Standby.TabIndex = 14;
            // 
            // txtNAV2Active
            // 
            this.txtNAV2Active.Location = new System.Drawing.Point(258, 23);
            this.txtNAV2Active.Name = "txtNAV2Active";
            this.txtNAV2Active.ReadOnly = true;
            this.txtNAV2Active.Size = new System.Drawing.Size(77, 20);
            this.txtNAV2Active.TabIndex = 12;
            // 
            // btnNAV2
            // 
            this.btnNAV2.Location = new System.Drawing.Point(7, 78);
            this.btnNAV2.Name = "btnNAV2";
            this.btnNAV2.Size = new System.Drawing.Size(172, 23);
            this.btnNAV2.TabIndex = 5;
            this.btnNAV2.Text = "Flip NAV2";
            this.btnNAV2.UseVisualStyleBackColor = true;
            this.btnNAV2.Click += new System.EventHandler(this.btnNAV2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Standby";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Active";
            // 
            // btnNAV2KHzDown
            // 
            this.btnNAV2KHzDown.Location = new System.Drawing.Point(96, 49);
            this.btnNAV2KHzDown.Name = "btnNAV2KHzDown";
            this.btnNAV2KHzDown.Size = new System.Drawing.Size(83, 23);
            this.btnNAV2KHzDown.TabIndex = 10;
            this.btnNAV2KHzDown.Text = "KHz-";
            this.btnNAV2KHzDown.UseVisualStyleBackColor = true;
            this.btnNAV2KHzDown.Click += new System.EventHandler(this.btnNAV2KHzDown_Click);
            // 
            // btnNAV2MHzUp
            // 
            this.btnNAV2MHzUp.Location = new System.Drawing.Point(7, 20);
            this.btnNAV2MHzUp.Name = "btnNAV2MHzUp";
            this.btnNAV2MHzUp.Size = new System.Drawing.Size(83, 23);
            this.btnNAV2MHzUp.TabIndex = 7;
            this.btnNAV2MHzUp.Text = "MHz+";
            this.btnNAV2MHzUp.UseVisualStyleBackColor = true;
            this.btnNAV2MHzUp.Click += new System.EventHandler(this.btnNAV2MHzUp_Click);
            // 
            // btnNAV2MHzDown
            // 
            this.btnNAV2MHzDown.Location = new System.Drawing.Point(7, 49);
            this.btnNAV2MHzDown.Name = "btnNAV2MHzDown";
            this.btnNAV2MHzDown.Size = new System.Drawing.Size(83, 23);
            this.btnNAV2MHzDown.TabIndex = 9;
            this.btnNAV2MHzDown.Text = "MHZ-";
            this.btnNAV2MHzDown.UseVisualStyleBackColor = true;
            this.btnNAV2MHzDown.Click += new System.EventHandler(this.btnNAV2MHzDown_Click);
            // 
            // btnNAV2KHzUp
            // 
            this.btnNAV2KHzUp.Location = new System.Drawing.Point(96, 20);
            this.btnNAV2KHzUp.Name = "btnNAV2KHzUp";
            this.btnNAV2KHzUp.Size = new System.Drawing.Size(83, 23);
            this.btnNAV2KHzUp.TabIndex = 8;
            this.btnNAV2KHzUp.Text = "KHz+";
            this.btnNAV2KHzUp.UseVisualStyleBackColor = true;
            this.btnNAV2KHzUp.Click += new System.EventHandler(this.btnNAV2KHzUp_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(12, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(458, 49);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Announciator";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnTransponder7);
            this.groupBox6.Controls.Add(this.btnTransponder6);
            this.groupBox6.Controls.Add(this.btnTransponder5);
            this.groupBox6.Controls.Add(this.btnTransponder4);
            this.groupBox6.Controls.Add(this.btnTransponder3);
            this.groupBox6.Controls.Add(this.btnTransponder2);
            this.groupBox6.Controls.Add(this.btnTransponder1);
            this.groupBox6.Controls.Add(this.btnTransponder0);
            this.groupBox6.Controls.Add(this.btnTransponderIdent);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.txtTransponder);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(12, 334);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(341, 150);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transponder";
            // 
            // btnTransponderOff
            // 
            this.btnTransponderOff.Location = new System.Drawing.Point(6, 19);
            this.btnTransponderOff.Name = "btnTransponderOff";
            this.btnTransponderOff.Size = new System.Drawing.Size(44, 23);
            this.btnTransponderOff.TabIndex = 19;
            this.btnTransponderOff.Text = "OFF";
            this.btnTransponderOff.UseVisualStyleBackColor = true;
            this.btnTransponderOff.Click += new System.EventHandler(this.btnTransponderOff_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnTransponderAlt);
            this.groupBox7.Controls.Add(this.btnTransponderOn);
            this.groupBox7.Controls.Add(this.btnTransponderTst);
            this.groupBox7.Controls.Add(this.btnTransponderSby);
            this.groupBox7.Controls.Add(this.btnTransponderOff);
            this.groupBox7.Location = new System.Drawing.Point(225, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(110, 108);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Mode";
            // 
            // btnTransponderSby
            // 
            this.btnTransponderSby.Location = new System.Drawing.Point(6, 48);
            this.btnTransponderSby.Name = "btnTransponderSby";
            this.btnTransponderSby.Size = new System.Drawing.Size(44, 23);
            this.btnTransponderSby.TabIndex = 20;
            this.btnTransponderSby.Text = "SBY";
            this.btnTransponderSby.UseVisualStyleBackColor = true;
            this.btnTransponderSby.Click += new System.EventHandler(this.btnTransponderSby_Click);
            // 
            // btnTransponderTst
            // 
            this.btnTransponderTst.Location = new System.Drawing.Point(6, 77);
            this.btnTransponderTst.Name = "btnTransponderTst";
            this.btnTransponderTst.Size = new System.Drawing.Size(44, 23);
            this.btnTransponderTst.TabIndex = 21;
            this.btnTransponderTst.Text = "TST";
            this.btnTransponderTst.UseVisualStyleBackColor = true;
            this.btnTransponderTst.Click += new System.EventHandler(this.btnTransponderTst_Click);
            // 
            // btnTransponderOn
            // 
            this.btnTransponderOn.Location = new System.Drawing.Point(56, 19);
            this.btnTransponderOn.Name = "btnTransponderOn";
            this.btnTransponderOn.Size = new System.Drawing.Size(44, 23);
            this.btnTransponderOn.TabIndex = 22;
            this.btnTransponderOn.Text = "ON";
            this.btnTransponderOn.UseVisualStyleBackColor = true;
            this.btnTransponderOn.Click += new System.EventHandler(this.btnTransponderOn_Click);
            // 
            // btnTransponderAlt
            // 
            this.btnTransponderAlt.Location = new System.Drawing.Point(56, 48);
            this.btnTransponderAlt.Name = "btnTransponderAlt";
            this.btnTransponderAlt.Size = new System.Drawing.Size(44, 23);
            this.btnTransponderAlt.TabIndex = 23;
            this.btnTransponderAlt.Text = "ALT";
            this.btnTransponderAlt.UseVisualStyleBackColor = true;
            this.btnTransponderAlt.Click += new System.EventHandler(this.btnTransponderAlt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Squawk";
            // 
            // txtTransponder
            // 
            this.txtTransponder.Location = new System.Drawing.Point(58, 19);
            this.txtTransponder.Name = "txtTransponder";
            this.txtTransponder.ReadOnly = true;
            this.txtTransponder.Size = new System.Drawing.Size(100, 20);
            this.txtTransponder.TabIndex = 1;
            // 
            // btnTransponderIdent
            // 
            this.btnTransponderIdent.Location = new System.Drawing.Point(164, 17);
            this.btnTransponderIdent.Name = "btnTransponderIdent";
            this.btnTransponderIdent.Size = new System.Drawing.Size(43, 23);
            this.btnTransponderIdent.TabIndex = 19;
            this.btnTransponderIdent.Text = "IDENT";
            this.btnTransponderIdent.UseVisualStyleBackColor = true;
            this.btnTransponderIdent.Click += new System.EventHandler(this.btnTransponderIdent_Click);
            // 
            // btnTransponder0
            // 
            this.btnTransponder0.Location = new System.Drawing.Point(9, 57);
            this.btnTransponder0.Name = "btnTransponder0";
            this.btnTransponder0.Size = new System.Drawing.Size(30, 23);
            this.btnTransponder0.TabIndex = 21;
            this.btnTransponder0.Text = "0";
            this.btnTransponder0.UseVisualStyleBackColor = true;
            this.btnTransponder0.Click += new System.EventHandler(this.btnTransponder0_Click);
            // 
            // btnTransponder1
            // 
            this.btnTransponder1.Location = new System.Drawing.Point(45, 57);
            this.btnTransponder1.Name = "btnTransponder1";
            this.btnTransponder1.Size = new System.Drawing.Size(30, 23);
            this.btnTransponder1.TabIndex = 22;
            this.btnTransponder1.Text = "1";
            this.btnTransponder1.UseVisualStyleBackColor = true;
            this.btnTransponder1.Click += new System.EventHandler(this.btnTransponder1_Click);
            // 
            // btnTransponder2
            // 
            this.btnTransponder2.Location = new System.Drawing.Point(81, 57);
            this.btnTransponder2.Name = "btnTransponder2";
            this.btnTransponder2.Size = new System.Drawing.Size(30, 23);
            this.btnTransponder2.TabIndex = 23;
            this.btnTransponder2.Text = "2";
            this.btnTransponder2.UseVisualStyleBackColor = true;
            this.btnTransponder2.Click += new System.EventHandler(this.btnTransponder2_Click);
            // 
            // btnTransponder3
            // 
            this.btnTransponder3.Location = new System.Drawing.Point(117, 57);
            this.btnTransponder3.Name = "btnTransponder3";
            this.btnTransponder3.Size = new System.Drawing.Size(30, 23);
            this.btnTransponder3.TabIndex = 24;
            this.btnTransponder3.Text = "3";
            this.btnTransponder3.UseVisualStyleBackColor = true;
            this.btnTransponder3.Click += new System.EventHandler(this.btnTransponder3_Click);
            // 
            // btnTransponder4
            // 
            this.btnTransponder4.Location = new System.Drawing.Point(153, 57);
            this.btnTransponder4.Name = "btnTransponder4";
            this.btnTransponder4.Size = new System.Drawing.Size(30, 23);
            this.btnTransponder4.TabIndex = 25;
            this.btnTransponder4.Text = "4";
            this.btnTransponder4.UseVisualStyleBackColor = true;
            this.btnTransponder4.Click += new System.EventHandler(this.btnTransponder4_Click);
            // 
            // btnTransponder5
            // 
            this.btnTransponder5.Location = new System.Drawing.Point(9, 86);
            this.btnTransponder5.Name = "btnTransponder5";
            this.btnTransponder5.Size = new System.Drawing.Size(30, 23);
            this.btnTransponder5.TabIndex = 26;
            this.btnTransponder5.Text = "5";
            this.btnTransponder5.UseVisualStyleBackColor = true;
            this.btnTransponder5.Click += new System.EventHandler(this.btnTransponder5_Click);
            // 
            // btnTransponder6
            // 
            this.btnTransponder6.Location = new System.Drawing.Point(45, 86);
            this.btnTransponder6.Name = "btnTransponder6";
            this.btnTransponder6.Size = new System.Drawing.Size(30, 23);
            this.btnTransponder6.TabIndex = 27;
            this.btnTransponder6.Text = "6";
            this.btnTransponder6.UseVisualStyleBackColor = true;
            this.btnTransponder6.Click += new System.EventHandler(this.btnTransponder6_Click);
            // 
            // btnTransponder7
            // 
            this.btnTransponder7.Location = new System.Drawing.Point(81, 86);
            this.btnTransponder7.Name = "btnTransponder7";
            this.btnTransponder7.Size = new System.Drawing.Size(30, 23);
            this.btnTransponder7.TabIndex = 28;
            this.btnTransponder7.Text = "7";
            this.btnTransponder7.UseVisualStyleBackColor = true;
            this.btnTransponder7.Click += new System.EventHandler(this.btnTransponder7_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Location = new System.Drawing.Point(522, 334);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(341, 100);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ADF";
            // 
            // groupBox9
            // 
            this.groupBox9.Location = new System.Drawing.Point(529, 440);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(334, 100);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "DME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 781);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCOM2;
        private System.Windows.Forms.Button btnCOM1;
        private System.Windows.Forms.Button btnCOM1MHzUp;
        private System.Windows.Forms.Button btnCOM1KHzUp;
        private System.Windows.Forms.Button btnCOM1MHzDown;
        private System.Windows.Forms.Button btnCOM1KHzDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCOM1Standby;
        private System.Windows.Forms.TextBox txtCOM1Active;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCOM2Standby;
        private System.Windows.Forms.TextBox txtCOM2Active;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCOM2KHzDown;
        private System.Windows.Forms.Button btnCOM2MHzUp;
        private System.Windows.Forms.Button btnCOM2MHzDown;
        private System.Windows.Forms.Button btnCOM2KHzUp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNAV1Standby;
        private System.Windows.Forms.TextBox txtNAV1Active;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNAV1KHzDown;
        private System.Windows.Forms.Button btnNAV1;
        private System.Windows.Forms.Button btnNAV1MHzUp;
        private System.Windows.Forms.Button btnNAV1MHzDown;
        private System.Windows.Forms.Button btnNAV1KHzUp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNAV2Standby;
        private System.Windows.Forms.TextBox txtNAV2Active;
        private System.Windows.Forms.Button btnNAV2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNAV2KHzDown;
        private System.Windows.Forms.Button btnNAV2MHzUp;
        private System.Windows.Forms.Button btnNAV2MHzDown;
        private System.Windows.Forms.Button btnNAV2KHzUp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnTransponder7;
        private System.Windows.Forms.Button btnTransponder6;
        private System.Windows.Forms.Button btnTransponder5;
        private System.Windows.Forms.Button btnTransponder4;
        private System.Windows.Forms.Button btnTransponder3;
        private System.Windows.Forms.Button btnTransponder2;
        private System.Windows.Forms.Button btnTransponder1;
        private System.Windows.Forms.Button btnTransponder0;
        private System.Windows.Forms.Button btnTransponderIdent;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnTransponderAlt;
        private System.Windows.Forms.Button btnTransponderOn;
        private System.Windows.Forms.Button btnTransponderTst;
        private System.Windows.Forms.Button btnTransponderSby;
        private System.Windows.Forms.Button btnTransponderOff;
        private System.Windows.Forms.TextBox txtTransponder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
    }
}

