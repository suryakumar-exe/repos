
namespace Excel_Manipulation_Learning
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.Main_compare = new System.Windows.Forms.Button();
            this.Fatigue = new System.Windows.Forms.ComboBox();
            this.QuickView = new System.Windows.Forms.ComboBox();
            this.Fatigue_lbl = new System.Windows.Forms.Label();
            this.Quickview_lbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.quickview_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main_compare
            // 
            this.Main_compare.Location = new System.Drawing.Point(361, 310);
            this.Main_compare.Name = "Main_compare";
            this.Main_compare.Size = new System.Drawing.Size(75, 23);
            this.Main_compare.TabIndex = 2;
            this.Main_compare.Text = "Compare";
            this.Main_compare.UseVisualStyleBackColor = true;
            this.Main_compare.Click += new System.EventHandler(this.button3_Click);
            // 
            // Fatigue
            // 
            this.Fatigue.FormattingEnabled = true;
            this.Fatigue.Location = new System.Drawing.Point(250, 68);
            this.Fatigue.Name = "Fatigue";
            this.Fatigue.Size = new System.Drawing.Size(274, 23);
            this.Fatigue.TabIndex = 3;
            // 
            // QuickView
            // 
            this.QuickView.FormattingEnabled = true;
            this.QuickView.Location = new System.Drawing.Point(250, 129);
            this.QuickView.Name = "QuickView";
            this.QuickView.Size = new System.Drawing.Size(274, 23);
            this.QuickView.TabIndex = 4;
            // 
            // Fatigue_lbl
            // 
            this.Fatigue_lbl.AutoSize = true;
            this.Fatigue_lbl.Location = new System.Drawing.Point(183, 76);
            this.Fatigue_lbl.Name = "Fatigue_lbl";
            this.Fatigue_lbl.Size = new System.Drawing.Size(46, 15);
            this.Fatigue_lbl.TabIndex = 5;
            this.Fatigue_lbl.Text = "Fatigue";
            // 
            // Quickview_lbl
            // 
            this.Quickview_lbl.AutoSize = true;
            this.Quickview_lbl.Location = new System.Drawing.Point(183, 137);
            this.Quickview_lbl.Name = "Quickview_lbl";
            this.Quickview_lbl.Size = new System.Drawing.Size(63, 15);
            this.Quickview_lbl.TabIndex = 6;
            this.Quickview_lbl.Text = "QuickView";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(543, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(666, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // quickview_cb
            // 
            this.quickview_cb.FormattingEnabled = true;
            this.quickview_cb.Location = new System.Drawing.Point(539, 128);
            this.quickview_cb.Name = "quickview_cb";
            this.quickview_cb.Size = new System.Drawing.Size(121, 23);
            this.quickview_cb.TabIndex = 9;
            this.quickview_cb.SelectedIndexChanged += new System.EventHandler(this.quickview_cb_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quickview_cb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Quickview_lbl);
            this.Controls.Add(this.Fatigue_lbl);
            this.Controls.Add(this.QuickView);
            this.Controls.Add(this.Fatigue);
            this.Controls.Add(this.Main_compare);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Main_compare;
        private System.Windows.Forms.ComboBox Fatigue;
        private System.Windows.Forms.ComboBox QuickView;
        private System.Windows.Forms.Label Fatigue_lbl;
        public System.Windows.Forms.Label Quickview_lbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox quickview_cb;
    }
}

