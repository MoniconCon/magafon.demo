namespace MarATHON
{
    partial class blagorg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(blagorg));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список благотворительных огранизаций";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Это список всех благоторительных учереждений";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(552, 211);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arise-logo.png");
            this.imageList1.Images.SetKeyName(1, "aves-do-brazil-logo.png");
            this.imageList1.Images.SetKeyName(2, "clara-santos-oliveira-institute-logo.png");
            this.imageList1.Images.SetKeyName(3, "conquer-cancer-brazil.png");
            this.imageList1.Images.SetKeyName(4, "diabetes-brazil-logo.png");
            this.imageList1.Images.SetKeyName(5, "heart-health-sao-paulo-logo.png");
            this.imageList1.Images.SetKeyName(6, "human-rights-centre-logo.png");
            this.imageList1.Images.SetKeyName(7, "oxfam-international-logo.png");
            this.imageList1.Images.SetKeyName(8, "querstadtein-logo.png");
            this.imageList1.Images.SetKeyName(9, "save-the-children-fund-logo.png");
            this.imageList1.Images.SetKeyName(10, "stay-pumped-logo.png");
            this.imageList1.Images.SetKeyName(11, "the-red-cross-logo.png");
            this.imageList1.Images.SetKeyName(12, "upbeat-logo.png");
            this.imageList1.Images.SetKeyName(13, "wwsm-rescue-logo.png");
            // 
            // blagorg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(640, 388);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "blagorg";
            this.Text = "blagorg";
            this.Load += new System.EventHandler(this.blagorg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}