namespace ClientProcesses
{
    partial class Form2
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
            this.tabFormControl1 = new DevComponents.DotNetBar.Controls.TabFormControl();
            this.tabFormPanel1 = new DevComponents.DotNetBar.Controls.TabFormPanel();
            this.tabFormPanel2 = new DevComponents.DotNetBar.Controls.TabFormPanel();
            this.tabFormItem1 = new DevComponents.DotNetBar.Controls.TabFormItem();
            this.tabFormItem2 = new DevComponents.DotNetBar.Controls.TabFormItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabFormControl1.SuspendLayout();
            this.tabFormPanel1.SuspendLayout();
            this.tabFormPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tabFormControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabFormControl1.Controls.Add(this.tabFormPanel1);
            this.tabFormControl1.Controls.Add(this.tabFormPanel2);
            this.tabFormControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormControl1.ForeColor = System.Drawing.Color.Black;
            this.tabFormControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabFormItem1,
            this.tabFormItem2});
            this.tabFormControl1.Location = new System.Drawing.Point(1, 1);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Size = new System.Drawing.Size(614, 412);
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStripFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFormControl1.Text = "tabFormControl1";
            // 
            // tabFormPanel1
            // 
            this.tabFormPanel1.Controls.Add(this.label1);
            this.tabFormPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormPanel1.Location = new System.Drawing.Point(0, 28);
            this.tabFormPanel1.Name = "tabFormPanel1";
            this.tabFormPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabFormPanel1.Size = new System.Drawing.Size(614, 384);
            // 
            // 
            // 
            this.tabFormPanel1.Style.Class = "TabFormPanel";
            this.tabFormPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabFormPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabFormPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabFormPanel1.TabIndex = 1;
            // 
            // tabFormPanel2
            // 
            this.tabFormPanel2.Controls.Add(this.label2);
            this.tabFormPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormPanel2.Location = new System.Drawing.Point(0, 28);
            this.tabFormPanel2.Name = "tabFormPanel2";
            this.tabFormPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabFormPanel2.Size = new System.Drawing.Size(614, 384);
            // 
            // 
            // 
            this.tabFormPanel2.Style.Class = "TabFormPanel";
            this.tabFormPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabFormPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tabFormPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tabFormPanel2.TabIndex = 2;
            this.tabFormPanel2.Visible = false;
            // 
            // tabFormItem1
            // 
            this.tabFormItem1.Checked = true;
            this.tabFormItem1.Name = "tabFormItem1";
            this.tabFormItem1.Panel = this.tabFormPanel1;
            this.tabFormItem1.Text = "Document 1";
            // 
            // tabFormItem2
            // 
            this.tabFormItem2.Name = "tabFormItem2";
            this.tabFormItem2.Panel = this.tabFormPanel2;
            this.tabFormItem2.Text = "Document 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(241, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your content here...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(257, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your content here...";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 414);
            this.Controls.Add(this.tabFormControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "DotNetBar Tabbed App Form";
            this.tabFormControl1.ResumeLayout(false);
            this.tabFormControl1.PerformLayout();
            this.tabFormPanel1.ResumeLayout(false);
            this.tabFormPanel1.PerformLayout();
            this.tabFormPanel2.ResumeLayout(false);
            this.tabFormPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TabFormControl tabFormControl1;
        private DevComponents.DotNetBar.Controls.TabFormPanel tabFormPanel1;
        private DevComponents.DotNetBar.Controls.TabFormPanel tabFormPanel2;
        private DevComponents.DotNetBar.Controls.TabFormItem tabFormItem1;
        private DevComponents.DotNetBar.Controls.TabFormItem tabFormItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

