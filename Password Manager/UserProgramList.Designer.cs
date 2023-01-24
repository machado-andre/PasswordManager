
namespace Password_Manager
{
    partial class UserProgramList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProgramList));
            this.listBoxUserPlatforms = new System.Windows.Forms.ListBox();
            this.platformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.platformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxUserPlatforms
            // 
            this.listBoxUserPlatforms.DataSource = this.platformBindingSource;
            this.listBoxUserPlatforms.FormattingEnabled = true;
            this.listBoxUserPlatforms.Location = new System.Drawing.Point(12, 12);
            this.listBoxUserPlatforms.Name = "listBoxUserPlatforms";
            this.listBoxUserPlatforms.Size = new System.Drawing.Size(201, 264);
            this.listBoxUserPlatforms.TabIndex = 0;
            this.listBoxUserPlatforms.SelectedIndexChanged += new System.EventHandler(this.listBoxUserPlatforms_SelectedIndexChanged);
            // 
            // platformBindingSource
            // 
            this.platformBindingSource.DataSource = typeof(Password_Manager.Platform);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(247, 65);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 59);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show/Hide";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(219, 186);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 15);
            this.labelPassword.TabIndex = 2;
            // 
            // UserProgramList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 293);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.listBoxUserPlatforms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProgramList";
            this.Text = "Password Manager - List";
            this.Load += new System.EventHandler(this.UserProgramList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.platformBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUserPlatforms;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.BindingSource platformBindingSource;
        private System.Windows.Forms.Label labelPassword;
        //private Password_Manager.ProgramDBDataSet programDBDataSet;
    }
}