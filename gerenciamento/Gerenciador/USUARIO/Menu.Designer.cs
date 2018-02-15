namespace Gerenciador.USUARIO
{
    partial class menu
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
            this.pictureBox_faixa = new System.Windows.Forms.PictureBox();
            this.label_razaosocial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_faixa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_faixa
            // 
            this.pictureBox_faixa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox_faixa.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_faixa.Name = "pictureBox_faixa";
            this.pictureBox_faixa.Size = new System.Drawing.Size(1777, 50);
            this.pictureBox_faixa.TabIndex = 1;
            this.pictureBox_faixa.TabStop = false;
            // 
            // label_razaosocial
            // 
            this.label_razaosocial.AutoSize = true;
            this.label_razaosocial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_razaosocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_razaosocial.Location = new System.Drawing.Point(516, 9);
            this.label_razaosocial.Name = "label_razaosocial";
            this.label_razaosocial.Size = new System.Drawing.Size(280, 20);
            this.label_razaosocial.TabIndex = 2;
            this.label_razaosocial.Text = "CRIAR SISTEMAS DE SEGURANÇA";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 888);
            this.ControlBox = false;
            this.Controls.Add(this.label_razaosocial);
            this.Controls.Add(this.pictureBox_faixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_faixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_faixa;
        private System.Windows.Forms.Label label_razaosocial;
    }
}