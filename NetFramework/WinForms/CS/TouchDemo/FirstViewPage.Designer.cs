﻿namespace TouchDemo
{
    partial class FirstViewPage
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

        #region Code generated by the Component Designer

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.product3 = new System.Windows.Forms.Label();
            this.mainvisual = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainvisual)).BeginInit();
            this.SuspendLayout();
            // 
            // product3
            // 
            this.product3.AutoSize = true;
            this.product3.BackColor = System.Drawing.Color.Transparent;
            this.product3.Font = new System.Drawing.Font("Meiryo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.product3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.product3.Location = new System.Drawing.Point(30, 430);
            this.product3.Name = "product3";
            this.product3.Size = new System.Drawing.Size(242, 36);
            this.product3.TabIndex = 1;
            this.product3.Text = "C1TouchToolKit For WinForms";
            // 
            // mainvisual
            // 
            this.mainvisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.mainvisual.BackgroundImage = global::TouchDemo.Properties.Resources.mainvisual;
            this.mainvisual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainvisual.Dock = System.Windows.Forms.DockStyle.None;
            this.mainvisual.Location = new System.Drawing.Point(50, 70);
            this.mainvisual.Name = "mainvisual";
            this.mainvisual.Size = new System.Drawing.Size(724, 550);
            this.mainvisual.TabIndex = 0;
            this.mainvisual.TabStop = false;
            // 
            // FirstViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.product3);
            this.Controls.Add(this.mainvisual);
            this.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "FirstViewPage";
            this.Size = new System.Drawing.Size(724, 500);
            ((System.ComponentModel.ISupportInitialize)(this.mainvisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainvisual;
        private System.Windows.Forms.Label product3;

    }
}
