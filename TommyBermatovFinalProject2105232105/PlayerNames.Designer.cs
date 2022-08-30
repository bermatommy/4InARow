
namespace _4InARow
{
    partial class PlayerNames
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
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.tb_name1 = new System.Windows.Forms.TextBox();
            this.tb_name2 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name1.Location = new System.Drawing.Point(10, 67);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(80, 22);
            this.lbl_name1.TabIndex = 1;
            this.lbl_name1.Text = "Player1: ";
            // 
            // lbl_name2
            // 
            this.lbl_name2.AutoSize = true;
            this.lbl_name2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name2.Location = new System.Drawing.Point(10, 106);
            this.lbl_name2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(80, 22);
            this.lbl_name2.TabIndex = 4;
            this.lbl_name2.Text = "Player2: ";
            // 
            // tb_name1
            // 
            this.tb_name1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name1.Location = new System.Drawing.Point(321, 67);
            this.tb_name1.Name = "tb_name1";
            this.tb_name1.Size = new System.Drawing.Size(125, 28);
            this.tb_name1.TabIndex = 5;
            this.tb_name1.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_name2
            // 
            this.tb_name2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name2.Location = new System.Drawing.Point(321, 106);
            this.tb_name2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_name2.Name = "tb_name2";
            this.tb_name2.Size = new System.Drawing.Size(125, 28);
            this.tb_name2.TabIndex = 6;
            this.tb_name2.TextChanged += new System.EventHandler(this.tb_Name2_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Lime;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ok.Location = new System.Drawing.Point(380, 265);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // PlayerNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 298);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_name2);
            this.Controls.Add(this.tb_name1);
            this.Controls.Add(this.lbl_name2);
            this.Controls.Add(this.lbl_name1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayerNames";
            this.Text = "PlayerNames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name1;
        private System.Windows.Forms.Label lbl_name2;
        private System.Windows.Forms.TextBox tb_name1;
        private System.Windows.Forms.TextBox tb_name2;
        private System.Windows.Forms.Button btn_ok;
    }
}