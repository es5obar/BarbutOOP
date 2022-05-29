
namespace BarbutOOP
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
            this.lZar1 = new System.Windows.Forms.Label();
            this.lZar2 = new System.Windows.Forms.Label();
            this.bZarAt = new System.Windows.Forms.Button();
            this.lbSonuc = new System.Windows.Forms.ListBox();
            this.pbZar1 = new System.Windows.Forms.PictureBox();
            this.pbZar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lZar1
            // 
            this.lZar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lZar1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lZar1.Location = new System.Drawing.Point(476, 223);
            this.lZar1.Name = "lZar1";
            this.lZar1.Size = new System.Drawing.Size(100, 100);
            this.lZar1.TabIndex = 0;
            this.lZar1.Text = "lZar1";
            this.lZar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lZar2
            // 
            this.lZar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lZar2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lZar2.Location = new System.Drawing.Point(616, 223);
            this.lZar2.Name = "lZar2";
            this.lZar2.Size = new System.Drawing.Size(100, 100);
            this.lZar2.TabIndex = 1;
            this.lZar2.Text = "lZar2";
            this.lZar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bZarAt
            // 
            this.bZarAt.Location = new System.Drawing.Point(90, 151);
            this.bZarAt.Name = "bZarAt";
            this.bZarAt.Size = new System.Drawing.Size(75, 23);
            this.bZarAt.TabIndex = 2;
            this.bZarAt.Text = "Zarları At";
            this.bZarAt.UseVisualStyleBackColor = true;
            this.bZarAt.Click += new System.EventHandler(this.bZarAt_Click);
            // 
            // lbSonuc
            // 
            this.lbSonuc.FormattingEnabled = true;
            this.lbSonuc.Location = new System.Drawing.Point(12, 180);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(412, 225);
            this.lbSonuc.TabIndex = 3;
            // 
            // pbZar1
            // 
            this.pbZar1.Location = new System.Drawing.Point(33, 22);
            this.pbZar1.Name = "pbZar1";
            this.pbZar1.Size = new System.Drawing.Size(100, 100);
            this.pbZar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZar1.TabIndex = 4;
            this.pbZar1.TabStop = false;
            // 
            // pbZar2
            // 
            this.pbZar2.Location = new System.Drawing.Point(158, 22);
            this.pbZar2.Name = "pbZar2";
            this.pbZar2.Size = new System.Drawing.Size(100, 100);
            this.pbZar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZar2.TabIndex = 5;
            this.pbZar2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbZar2);
            this.Controls.Add(this.pbZar1);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.bZarAt);
            this.Controls.Add(this.lZar2);
            this.Controls.Add(this.lZar1);
            this.Name = "Form1";
            this.Text = "Barbut";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbZar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lZar1;
        private System.Windows.Forms.Label lZar2;
        private System.Windows.Forms.Button bZarAt;
        private System.Windows.Forms.ListBox lbSonuc;
        private System.Windows.Forms.PictureBox pbZar1;
        private System.Windows.Forms.PictureBox pbZar2;
    }
}

