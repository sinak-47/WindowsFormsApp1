﻿namespace WindowsFormsApp1
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
            this.Order_Event = new System.Windows.Forms.Button();
            this.Setup_Bluetooth = new System.Windows.Forms.Button();
            this.Direct_Stream = new System.Windows.Forms.Button();
            this.Create_Event = new System.Windows.Forms.Button();
            this.Email_SMS = new System.Windows.Forms.Button();
            this.Cur_Event = new System.Windows.Forms.TextBox();
            this.Subscribe = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Order_Event
            // 
            this.Order_Event.Location = new System.Drawing.Point(570, 143);
            this.Order_Event.Name = "Order_Event";
            this.Order_Event.Size = new System.Drawing.Size(111, 52);
            this.Order_Event.TabIndex = 1;
            this.Order_Event.Text = "سفارش اعلان";
            this.Order_Event.UseVisualStyleBackColor = true;
            this.Order_Event.Click += new System.EventHandler(this.Order_Event_Click);
            // 
            // Setup_Bluetooth
            // 
            this.Setup_Bluetooth.Location = new System.Drawing.Point(570, 234);
            this.Setup_Bluetooth.Name = "Setup_Bluetooth";
            this.Setup_Bluetooth.Size = new System.Drawing.Size(111, 49);
            this.Setup_Bluetooth.TabIndex = 2;
            this.Setup_Bluetooth.Text = "پخش بلوتوث";
            this.Setup_Bluetooth.UseVisualStyleBackColor = true;
            this.Setup_Bluetooth.Click += new System.EventHandler(this.Setup_Bluetooth_Click);
            // 
            // Direct_Stream
            // 
            this.Direct_Stream.Location = new System.Drawing.Point(570, 415);
            this.Direct_Stream.Name = "Direct_Stream";
            this.Direct_Stream.Size = new System.Drawing.Size(111, 52);
            this.Direct_Stream.TabIndex = 4;
            this.Direct_Stream.Text = "پخش مجزا";
            this.Direct_Stream.UseVisualStyleBackColor = true;
            this.Direct_Stream.Click += new System.EventHandler(this.Direct_Stream_Click);
            // 
            // Create_Event
            // 
            this.Create_Event.Location = new System.Drawing.Point(570, 51);
            this.Create_Event.Name = "Create_Event";
            this.Create_Event.Size = new System.Drawing.Size(111, 54);
            this.Create_Event.TabIndex = 5;
            this.Create_Event.Text = "ثبت اعلان";
            this.Create_Event.UseVisualStyleBackColor = true;
            this.Create_Event.Click += new System.EventHandler(this.Create_Event_Click);
            // 
            // Email_SMS
            // 
            this.Email_SMS.Location = new System.Drawing.Point(570, 325);
            this.Email_SMS.Name = "Email_SMS";
            this.Email_SMS.Size = new System.Drawing.Size(111, 48);
            this.Email_SMS.TabIndex = 6;
            this.Email_SMS.Text = "ایمیل و پیامک";
            this.Email_SMS.UseVisualStyleBackColor = true;
            this.Email_SMS.Click += new System.EventHandler(this.Email_SMS_Click);
            // 
            // Cur_Event
            // 
            this.Cur_Event.Location = new System.Drawing.Point(764, 51);
            this.Cur_Event.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cur_Event.Multiline = true;
            this.Cur_Event.Name = "Cur_Event";
            this.Cur_Event.ReadOnly = true;
            this.Cur_Event.Size = new System.Drawing.Size(432, 516);
            this.Cur_Event.TabIndex = 7;
            // 
            // Subscribe
            // 
            this.Subscribe.Location = new System.Drawing.Point(570, 515);
            this.Subscribe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Subscribe.Name = "Subscribe";
            this.Subscribe.Size = new System.Drawing.Size(111, 54);
            this.Subscribe.TabIndex = 9;
            this.Subscribe.Text = "عضویت";
            this.Subscribe.UseVisualStyleBackColor = true;
            this.Subscribe.Click += new System.EventHandler(this.Subscribe_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(890, 578);
            this.update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(166, 54);
            this.update.TabIndex = 10;
            this.update.Text = "وضعیت کنونی";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(38, 51);
            this.next.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.next.Multiline = true;
            this.next.Name = "next";
            this.next.ReadOnly = true;
            this.next.Size = new System.Drawing.Size(457, 516);
            this.next.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 578);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "ارسال اعلان بعدی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Subscribe);
            this.Controls.Add(this.Cur_Event);
            this.Controls.Add(this.Email_SMS);
            this.Controls.Add(this.Create_Event);
            this.Controls.Add(this.Direct_Stream);
            this.Controls.Add(this.Setup_Bluetooth);
            this.Controls.Add(this.Order_Event);
            this.Name = "Form1";
            this.Text = "سرور";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Order_Event;
        private System.Windows.Forms.Button Setup_Bluetooth;
        private System.Windows.Forms.Button Direct_Stream;
        private System.Windows.Forms.Button Create_Event;
        private System.Windows.Forms.Button Email_SMS;
        private System.Windows.Forms.TextBox Cur_Event;
        private System.Windows.Forms.Button Subscribe;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox next;
        private System.Windows.Forms.Button button1;
    }
}

