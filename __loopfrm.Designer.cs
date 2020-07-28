using System.Windows.Forms;

namespace Interface_RADAR
{
    partial class __loopfrm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(@__loopfrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.iconDimin = new System.Windows.Forms.PictureBox();
            this.iconMaxim = new System.Windows.Forms.PictureBox();
            this.iconMinim = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDimin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinim)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // iconClose
            // 
            this.iconClose.BackColor = System.Drawing.Color.Red;
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(1271, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(23, 23);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // iconDimin
            // 
            this.iconDimin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDimin.Image = ((System.Drawing.Image)(resources.GetObject("iconDimin.Image")));
            this.iconDimin.Location = new System.Drawing.Point(1213, 3);
            this.iconDimin.Name = "iconDimin";
            this.iconDimin.Size = new System.Drawing.Size(23, 23);
            this.iconDimin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconDimin.TabIndex = 4;
            this.iconDimin.TabStop = false;
            this.iconDimin.Visible = false;
            this.iconDimin.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // iconMaxim
            // 
            this.iconMaxim.BackColor = System.Drawing.Color.Lime;
            this.iconMaxim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaxim.Image = ((System.Drawing.Image)(resources.GetObject("iconMaxim.Image")));
            this.iconMaxim.Location = new System.Drawing.Point(1242, 3);
            this.iconMaxim.Name = "iconMaxim";
            this.iconMaxim.Size = new System.Drawing.Size(23, 23);
            this.iconMaxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMaxim.TabIndex = 5;
            this.iconMaxim.TabStop = false;
            this.iconMaxim.Click += new System.EventHandler(this.iconMaxim_Click);
            // 
            // iconMinim
            // 
            this.iconMinim.BackColor = System.Drawing.Color.Lime;
            this.iconMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinim.Image = ((System.Drawing.Image)(resources.GetObject("iconMinim.Image")));
            this.iconMinim.Location = new System.Drawing.Point(1184, 3);
            this.iconMinim.Name = "iconMinim";
            this.iconMinim.Size = new System.Drawing.Size(23, 23);
            this.iconMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMinim.TabIndex = 6;
            this.iconMinim.TabStop = false;
            this.iconMinim.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.iconClose);
            this.flowLayoutPanel1.Controls.Add(this.iconMaxim);
            this.flowLayoutPanel1.Controls.Add(this.iconDimin);
            this.flowLayoutPanel1.Controls.Add(this.iconMinim);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1297, 32);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "79 GHz RADAR  IHM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1054, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 440);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(326, 84);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(722, 403);
            this.flowLayoutPanel3.TabIndex = 11;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(192, 104);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel4.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 537);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1297, 115);
            this.flowLayoutPanel4.TabIndex = 15;
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
            // __loopfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "__loopfrm";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.@__loopfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDimin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinim)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private PictureBox iconClose;
        private PictureBox iconDimin;
        private PictureBox iconMaxim;
        private PictureBox iconMinim;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private PictureBox pictureBox4;
        private FlowLayoutPanel flowLayoutPanel4;
    }
}

