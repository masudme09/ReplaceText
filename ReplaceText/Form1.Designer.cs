namespace ReplaceText
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadTextTag = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBxTagValuePair = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnLoadSource = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadTextTag);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnLoadTextTag
            // 
            this.btnLoadTextTag.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLoadTextTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadTextTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTextTag.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadTextTag.Location = new System.Drawing.Point(0, 0);
            this.btnLoadTextTag.Name = "btnLoadTextTag";
            this.btnLoadTextTag.Size = new System.Drawing.Size(596, 42);
            this.btnLoadTextTag.TabIndex = 0;
            this.btnLoadTextTag.Text = "Load Tag Value Pair";
            this.btnLoadTextTag.UseVisualStyleBackColor = false;
            this.btnLoadTextTag.Click += new System.EventHandler(this.BtnLoadTextTag_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstBxTagValuePair);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 455);
            this.panel2.TabIndex = 1;
            // 
            // lstBxTagValuePair
            // 
            this.lstBxTagValuePair.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstBxTagValuePair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBxTagValuePair.FormattingEnabled = true;
            this.lstBxTagValuePair.Location = new System.Drawing.Point(0, 0);
            this.lstBxTagValuePair.Name = "lstBxTagValuePair";
            this.lstBxTagValuePair.Size = new System.Drawing.Size(596, 455);
            this.lstBxTagValuePair.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBrowseDest);
            this.panel3.Controls.Add(this.btnGenerate);
            this.panel3.Controls.Add(this.btnLoadSource);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 44);
            this.panel3.TabIndex = 2;
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseDest.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDest.Location = new System.Drawing.Point(186, 0);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(191, 44);
            this.btnBrowseDest.TabIndex = 2;
            this.btnBrowseDest.Text = "Browse Destination";
            this.btnBrowseDest.UseVisualStyleBackColor = true;
            this.btnBrowseDest.Click += new System.EventHandler(this.BtnBrowseDest_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(377, 0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(219, 44);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnLoadSource
            // 
            this.btnLoadSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoadSource.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSource.Location = new System.Drawing.Point(0, 0);
            this.btnLoadSource.Name = "btnLoadSource";
            this.btnLoadSource.Size = new System.Drawing.Size(186, 44);
            this.btnLoadSource.TabIndex = 0;
            this.btnLoadSource.Text = "Load Source";
            this.btnLoadSource.UseVisualStyleBackColor = true;
            this.btnLoadSource.Click += new System.EventHandler(this.BtnLoadSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 497);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "TextReplacer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLoadTextTag;
        private System.Windows.Forms.ListBox lstBxTagValuePair;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnLoadSource;
        private System.Windows.Forms.Button btnBrowseDest;
    }
}

