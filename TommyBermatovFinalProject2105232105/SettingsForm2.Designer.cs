
namespace _4InARow
{
    partial class SettingsForm2
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
            this.lbl_Board = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_boardSize = new System.Windows.Forms.TextBox();
            this.lbl_Button = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_buttonSize = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Board
            // 
            this.lbl_Board.AutoSize = true;
            this.lbl_Board.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Board.Location = new System.Drawing.Point(10, 37);
            this.lbl_Board.Name = "lbl_Board";
            this.lbl_Board.Size = new System.Drawing.Size(106, 22);
            this.lbl_Board.TabIndex = 5;
            this.lbl_Board.Text = "Board Size: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Tag = "";
            this.label1.Text = "6-8";
            // 
            // tb_boardSize
            // 
            this.tb_boardSize.Location = new System.Drawing.Point(276, 45);
            this.tb_boardSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_boardSize.Name = "tb_boardSize";
            this.tb_boardSize.Size = new System.Drawing.Size(76, 20);
            this.tb_boardSize.TabIndex = 10;
            // 
            // lbl_Button
            // 
            this.lbl_Button.AutoSize = true;
            this.lbl_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Button.Location = new System.Drawing.Point(10, 102);
            this.lbl_Button.Name = "lbl_Button";
            this.lbl_Button.Size = new System.Drawing.Size(113, 22);
            this.lbl_Button.TabIndex = 11;
            this.lbl_Button.Text = "Button Size: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "50-75";
            // 
            // tb_buttonSize
            // 
            this.tb_buttonSize.Location = new System.Drawing.Point(276, 110);
            this.tb_buttonSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_buttonSize.Name = "tb_buttonSize";
            this.tb_buttonSize.Size = new System.Drawing.Size(76, 20);
            this.tb_buttonSize.TabIndex = 13;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(10, 362);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.Lime;
            this.btn_Ok.Location = new System.Drawing.Point(375, 453);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 15;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            // 
            // btn_Okay
            // 
            this.btn_Okay.BackColor = System.Drawing.Color.Lime;
            this.btn_Okay.Location = new System.Drawing.Point(300, 362);
            this.btn_Okay.Name = "btn_Okay";
            this.btn_Okay.Size = new System.Drawing.Size(75, 23);
            this.btn_Okay.TabIndex = 16;
            this.btn_Okay.Text = "Ok";
            this.btn_Okay.UseVisualStyleBackColor = false;
            this.btn_Okay.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4InARow.Properties.Resources.Settings;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 396);
            this.Controls.Add(this.btn_Okay);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_buttonSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Button);
            this.Controls.Add(this.tb_boardSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Board);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsForm2";
            this.Text = "SettingsForm2";
            this.Load += new System.EventHandler(this.SettingsForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_boardSize;
        private System.Windows.Forms.Label lbl_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_buttonSize;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Okay;
    }
}