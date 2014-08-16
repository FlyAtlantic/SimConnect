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
            this.btnDisconnect.Location = new System.Drawing.Point(12, 41);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(249, 23);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "disconnect from Prepar3D";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(7, 189);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(455, 265);
            this.txtOutput.TabIndex = 2;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(12, 70);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(249, 23);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "Request Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 102);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(249, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send Data";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCOM2
            // 
            this.btnCOM2.Location = new System.Drawing.Point(12, 160);
            this.btnCOM2.Name = "btnCOM2";
            this.btnCOM2.Size = new System.Drawing.Size(249, 23);
            this.btnCOM2.TabIndex = 5;
            this.btnCOM2.Text = "Flip COM2";
            this.btnCOM2.UseVisualStyleBackColor = true;
            this.btnCOM2.Click += new System.EventHandler(this.btnCOM2_Click);
            // 
            // btnCOM1
            // 
            this.btnCOM1.Location = new System.Drawing.Point(12, 131);
            this.btnCOM1.Name = "btnCOM1";
            this.btnCOM1.Size = new System.Drawing.Size(249, 23);
            this.btnCOM1.TabIndex = 6;
            this.btnCOM1.Text = "Flip COM1";
            this.btnCOM1.UseVisualStyleBackColor = true;
            this.btnCOM1.Click += new System.EventHandler(this.btnCOM1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 460);
            this.Controls.Add(this.btnCOM1);
            this.Controls.Add(this.btnCOM2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

