namespace Chalenge_BT_code_Crafte_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            date = new Label();
            userId = new Label();
            user_id = new TextBox();
            dateTime = new TextBox();
            passwordTb = new TextBox();
            pass = new Label();
            generateBtn = new Button();
            showBtn = new Button();
            lb_error = new Label();
            timer_tb = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(42, 120);
            date.Name = "date";
            date.Size = new Size(63, 15);
            date.TabIndex = 0;
            date.Text = "Date Time:";
            // 
            // userId
            // 
            userId.AutoSize = true;
            userId.Location = new Point(42, 83);
            userId.Name = "userId";
            userId.Size = new Size(50, 15);
            userId.TabIndex = 1;
            userId.Text = "User ID: ";
            // 
            // user_id
            // 
            user_id.Location = new Point(111, 83);
            user_id.Name = "user_id";
            user_id.Size = new Size(188, 23);
            user_id.TabIndex = 2;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(111, 117);
            dateTime.Name = "dateTime";
            dateTime.ReadOnly = true;
            dateTime.Size = new Size(188, 23);
            dateTime.TabIndex = 3;
            dateTime.TextChanged += dateTime_TextChanged;
            // 
            // passwordTb
            // 
            passwordTb.Location = new Point(113, 155);
            passwordTb.Name = "passwordTb";
            passwordTb.ReadOnly = true;
            passwordTb.Size = new Size(186, 23);
            passwordTb.TabIndex = 4;
            passwordTb.UseSystemPasswordChar = true;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(42, 158);
            pass.Name = "pass";
            pass.Size = new Size(57, 15);
            pass.TabIndex = 5;
            pass.Text = "Password";
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(165, 195);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(137, 23);
            generateBtn.TabIndex = 6;
            generateBtn.Text = "Generate password";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(308, 155);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(55, 23);
            showBtn.TabIndex = 7;
            showBtn.Text = "show";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // lb_error
            // 
            lb_error.AutoSize = true;
            lb_error.Location = new Point(135, 229);
            lb_error.Name = "lb_error";
            lb_error.Size = new Size(0, 15);
            lb_error.TabIndex = 8;
            lb_error.Visible = false;
            // 
            // timer_tb
            // 
            timer_tb.AutoSize = true;
            timer_tb.Location = new Point(260, 320);
            timer_tb.Name = "timer_tb";
            timer_tb.Size = new Size(0, 15);
            timer_tb.TabIndex = 9;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 415);
            Controls.Add(timer_tb);
            Controls.Add(lb_error);
            Controls.Add(showBtn);
            Controls.Add(generateBtn);
            Controls.Add(pass);
            Controls.Add(passwordTb);
            Controls.Add(dateTime);
            Controls.Add(user_id);
            Controls.Add(userId);
            Controls.Add(date);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label date;
        private Label userId;
        private TextBox user_id;
        private TextBox dateTime;
        private TextBox passwordTb;
        private Label pass;
        private Button generateBtn;
        private Button showBtn;
        private Label lb_error;
        private Label timer_tb;
        private System.Windows.Forms.Timer timer1;
    }
}