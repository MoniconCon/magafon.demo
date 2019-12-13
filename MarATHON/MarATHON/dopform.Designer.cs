namespace MarATHON
{
    partial class dopform
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
            this.Back = new System.Windows.Forms.Button();
            this.Marafon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.DATA6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Marafon
            // 
            this.Marafon.Location = new System.Drawing.Point(92, 87);
            this.Marafon.Name = "Marafon";
            this.Marafon.Size = new System.Drawing.Size(142, 47);
            this.Marafon.TabIndex = 1;
            this.Marafon.Text = "Marafon Skill 2020";
            this.Marafon.UseVisualStyleBackColor = true;
            this.Marafon.Click += new System.EventHandler(this.Marafon_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Насколько долгий марафон";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(92, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Прведущие результаты";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(240, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "Список благотворительный оргонизаций";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(92, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "BMI калькулятор";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // DATA6
            // 
            this.DATA6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DATA6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DATA6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DATA6.Location = new System.Drawing.Point(-2, 344);
            this.DATA6.Name = "DATA6";
            this.DATA6.Size = new System.Drawing.Size(473, 44);
            this.DATA6.TabIndex = 25;
            this.DATA6.Text = " ";
            this.DATA6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DATA6.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dopform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 384);
            this.Controls.Add(this.DATA6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Marafon);
            this.Controls.Add(this.Back);
            this.Name = "dopform";
            this.Text = "dopform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Marafon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label DATA6;
        private System.Windows.Forms.Timer timer1;
    }
}