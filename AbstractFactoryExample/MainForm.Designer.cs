namespace AbstractFactoryExample
{
    partial class MainForm
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
            this.btnFixed = new System.Windows.Forms.Button();
            this.btnResizable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFixed
            // 
            this.btnFixed.Location = new System.Drawing.Point(60, 181);
            this.btnFixed.Name = "btnFixed";
            this.btnFixed.Size = new System.Drawing.Size(141, 52);
            this.btnFixed.TabIndex = 0;
            this.btnFixed.Text = "Fixed Size Window";
            this.btnFixed.UseVisualStyleBackColor = true;
            this.btnFixed.Click += new System.EventHandler(this.btnFixed_Click);
            // 
            // btnResizable
            // 
            this.btnResizable.Location = new System.Drawing.Point(299, 181);
            this.btnResizable.Name = "btnResizable";
            this.btnResizable.Size = new System.Drawing.Size(141, 52);
            this.btnResizable.TabIndex = 1;
            this.btnResizable.Text = "Resizable Window";
            this.btnResizable.UseVisualStyleBackColor = true;
            this.btnResizable.Click += new System.EventHandler(this.btnResizable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.btnResizable);
            this.Controls.Add(this.btnFixed);
            this.Name = "Form1";
            this.Text = "Abstract Factory Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFixed;
        private System.Windows.Forms.Button btnResizable;
    }
}

