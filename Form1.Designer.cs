
namespace ChatBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeiste = new System.Windows.Forms.Panel();
            this.pboxWindowMaximize = new System.Windows.Forms.PictureBox();
            this.pboxWindowMinimize = new System.Windows.Forms.PictureBox();
            this.pboxWindowClose = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelQuestions = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLeiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeiste
            // 
            this.panelLeiste.BackColor = System.Drawing.Color.Fuchsia;
            this.panelLeiste.Controls.Add(this.pboxWindowMaximize);
            this.panelLeiste.Controls.Add(this.pboxWindowMinimize);
            this.panelLeiste.Controls.Add(this.pboxWindowClose);
            this.panelLeiste.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeiste.Location = new System.Drawing.Point(0, 0);
            this.panelLeiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeiste.Name = "panelLeiste";
            this.panelLeiste.Size = new System.Drawing.Size(600, 28);
            this.panelLeiste.TabIndex = 1;
            // 
            // pboxWindowMaximize
            // 
            this.pboxWindowMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboxWindowMaximize.BackColor = System.Drawing.Color.Transparent;
            this.pboxWindowMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowMaximize.Image")));
            this.pboxWindowMaximize.Location = new System.Drawing.Point(521, 2);
            this.pboxWindowMaximize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboxWindowMaximize.Name = "pboxWindowMaximize";
            this.pboxWindowMaximize.Size = new System.Drawing.Size(36, 24);
            this.pboxWindowMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowMaximize.TabIndex = 4;
            this.pboxWindowMaximize.TabStop = false;
            this.pboxWindowMaximize.Click += new System.EventHandler(this.WindowMaximize);
            // 
            // pboxWindowMinimize
            // 
            this.pboxWindowMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboxWindowMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pboxWindowMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowMinimize.Image")));
            this.pboxWindowMinimize.Location = new System.Drawing.Point(481, 2);
            this.pboxWindowMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboxWindowMinimize.Name = "pboxWindowMinimize";
            this.pboxWindowMinimize.Size = new System.Drawing.Size(36, 24);
            this.pboxWindowMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowMinimize.TabIndex = 4;
            this.pboxWindowMinimize.TabStop = false;
            this.pboxWindowMinimize.Click += new System.EventHandler(this.WindowMinimize);
            // 
            // pboxWindowClose
            // 
            this.pboxWindowClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboxWindowClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowClose.Image")));
            this.pboxWindowClose.Location = new System.Drawing.Point(562, 2);
            this.pboxWindowClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboxWindowClose.Name = "pboxWindowClose";
            this.pboxWindowClose.Size = new System.Drawing.Size(36, 24);
            this.pboxWindowClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowClose.TabIndex = 3;
            this.pboxWindowClose.TabStop = false;
            this.pboxWindowClose.Click += new System.EventHandler(this.FensterSchließen);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(9, 33);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(583, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // flowLayoutPanelQuestions
            // 
            this.flowLayoutPanelQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelQuestions.Location = new System.Drawing.Point(9, 58);
            this.flowLayoutPanelQuestions.Name = "flowLayoutPanelQuestions";
            this.flowLayoutPanelQuestions.Size = new System.Drawing.Size(583, 296);
            this.flowLayoutPanelQuestions.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.flowLayoutPanelQuestions);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelLeiste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelLeiste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeiste;
        private System.Windows.Forms.PictureBox pboxWindowClose;
        private System.Windows.Forms.PictureBox pboxWindowMaximize;
        private System.Windows.Forms.PictureBox pboxWindowMinimize;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuestions;
    }
}

