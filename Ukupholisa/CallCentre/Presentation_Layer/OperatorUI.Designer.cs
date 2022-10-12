
namespace Ukupholisa.CallCentre.Presentation_Layer
{
    partial class OperatorUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CallReceiver = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Answer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.CallReceiver.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CallReceiver);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // CallReceiver
            // 
            this.CallReceiver.Controls.Add(this.Answer);
            this.CallReceiver.Location = new System.Drawing.Point(4, 22);
            this.CallReceiver.Name = "CallReceiver";
            this.CallReceiver.Padding = new System.Windows.Forms.Padding(3);
            this.CallReceiver.Size = new System.Drawing.Size(702, 416);
            this.CallReceiver.TabIndex = 0;
            this.CallReceiver.Text = "tabPage1";
            this.CallReceiver.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(702, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(599, 367);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(97, 43);
            this.Answer.TabIndex = 0;
            this.Answer.Text = "Answer";
            this.Answer.UseVisualStyleBackColor = true;
            // 
            // OperatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "OperatorUI";
            this.Text = "OperatorUI";
            this.tabControl1.ResumeLayout(false);
            this.CallReceiver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CallReceiver;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Answer;
    }
}