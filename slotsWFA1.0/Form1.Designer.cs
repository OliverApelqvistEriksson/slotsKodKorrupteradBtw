namespace slotsWFA1._0
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
            this.textRuta = new System.Windows.Forms.TextBox();
            this.spinKnapp = new System.Windows.Forms.Button();
            this.textRuta2 = new System.Windows.Forms.TextBox();
            this.vinstLåda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textRuta
            // 
            this.textRuta.Enabled = false;
            this.textRuta.Location = new System.Drawing.Point(457, 165);
            this.textRuta.Name = "textRuta";
            this.textRuta.ReadOnly = true;
            this.textRuta.Size = new System.Drawing.Size(100, 26);
            this.textRuta.TabIndex = 0;
            // 
            // spinKnapp
            // 
            this.spinKnapp.Location = new System.Drawing.Point(611, 298);
            this.spinKnapp.Name = "spinKnapp";
            this.spinKnapp.Size = new System.Drawing.Size(113, 83);
            this.spinKnapp.TabIndex = 1;
            this.spinKnapp.Text = "SPIN!!!";
            this.spinKnapp.UseVisualStyleBackColor = true;
            this.spinKnapp.Click += new System.EventHandler(this.spinKnapp_Click);
            // 
            // textRuta2
            // 
            this.textRuta2.Enabled = false;
            this.textRuta2.Location = new System.Drawing.Point(308, 165);
            this.textRuta2.Name = "textRuta2";
            this.textRuta2.ReadOnly = true;
            this.textRuta2.Size = new System.Drawing.Size(100, 26);
            this.textRuta2.TabIndex = 2;
            // 
            // vinstLåda
            // 
            this.vinstLåda.Enabled = false;
            this.vinstLåda.Location = new System.Drawing.Point(308, 232);
            this.vinstLåda.Name = "vinstLåda";
            this.vinstLåda.ReadOnly = true;
            this.vinstLåda.Size = new System.Drawing.Size(240, 26);
            this.vinstLåda.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vinstLåda);
            this.Controls.Add(this.textRuta2);
            this.Controls.Add(this.spinKnapp);
            this.Controls.Add(this.textRuta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRuta;
        private System.Windows.Forms.Button spinKnapp;
        private System.Windows.Forms.TextBox textRuta2;
        private System.Windows.Forms.TextBox vinstLåda;
    }
}

