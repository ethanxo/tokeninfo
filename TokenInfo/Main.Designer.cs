namespace TokenInfo
{
    partial class Main
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
            this.combobox_token = new MetroFramework.Controls.MetroComboBox();
            this.stylemanager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.button_back = new MetroFramework.Controls.MetroButton();
            this.button_next = new MetroFramework.Controls.MetroButton();
            this.button_browse = new MetroFramework.Controls.MetroButton();
            this.label_filepath = new MetroFramework.Controls.MetroLabel();
            this.label_status = new MetroFramework.Controls.MetroLabel();
            this.picturebox_avatar = new System.Windows.Forms.PictureBox();
            this.openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.label_tag = new MetroFramework.Controls.MetroLabel();
            this.label_email = new MetroFramework.Controls.MetroLabel();
            this.label_id = new MetroFramework.Controls.MetroLabel();
            this.label_tokensloaded = new MetroFramework.Controls.MetroLabel();
            this.label_token = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_token
            // 
            this.combobox_token.Enabled = false;
            this.combobox_token.FormattingEnabled = true;
            this.combobox_token.ItemHeight = 23;
            this.combobox_token.Location = new System.Drawing.Point(23, 34);
            this.combobox_token.Name = "combobox_token";
            this.combobox_token.Size = new System.Drawing.Size(386, 29);
            this.combobox_token.TabIndex = 0;
            this.combobox_token.DropDown += new System.EventHandler(this.combobox_token_DropDown);
            this.combobox_token.DropDownClosed += new System.EventHandler(this.combobox_token_DropDownClosed);
            // 
            // stylemanager
            // 
            this.stylemanager.Owner = this;
            this.stylemanager.Style = MetroFramework.MetroColorStyle.Red;
            this.stylemanager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // button_back
            // 
            this.button_back.Enabled = false;
            this.button_back.Location = new System.Drawing.Point(415, 34);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(26, 29);
            this.button_back.Style = MetroFramework.MetroColorStyle.Red;
            this.button_back.TabIndex = 1;
            this.button_back.Text = "<";
            this.button_back.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_next
            // 
            this.button_next.Enabled = false;
            this.button_next.Location = new System.Drawing.Point(447, 34);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(26, 29);
            this.button_next.Style = MetroFramework.MetroColorStyle.Red;
            this.button_next.TabIndex = 2;
            this.button_next.Text = ">";
            this.button_next.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(25, 249);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(115, 29);
            this.button_browse.Style = MetroFramework.MetroColorStyle.Red;
            this.button_browse.TabIndex = 3;
            this.button_browse.Text = "Browse Token List";
            this.button_browse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label_filepath
            // 
            this.label_filepath.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_filepath.Location = new System.Drawing.Point(146, 249);
            this.label_filepath.Name = "label_filepath";
            this.label_filepath.Size = new System.Drawing.Size(327, 29);
            this.label_filepath.Style = MetroFramework.MetroColorStyle.Red;
            this.label_filepath.TabIndex = 4;
            this.label_filepath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_filepath.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_status
            // 
            this.label_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label_status.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_status.Location = new System.Drawing.Point(20, 73);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(279, 29);
            this.label_status.Style = MetroFramework.MetroColorStyle.Red;
            this.label_status.TabIndex = 5;
            this.label_status.Text = "Status: ";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_status.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_status.Click += new System.EventHandler(this.label_status_Click);
            // 
            // picturebox_avatar
            // 
            this.picturebox_avatar.Location = new System.Drawing.Point(305, 72);
            this.picturebox_avatar.Name = "picturebox_avatar";
            this.picturebox_avatar.Size = new System.Drawing.Size(168, 168);
            this.picturebox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_avatar.TabIndex = 6;
            this.picturebox_avatar.TabStop = false;
            this.picturebox_avatar.Click += new System.EventHandler(this.picturebox_avatar_Click);
            // 
            // label_tag
            // 
            this.label_tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_tag.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_tag.Location = new System.Drawing.Point(20, 107);
            this.label_tag.Name = "label_tag";
            this.label_tag.Size = new System.Drawing.Size(279, 29);
            this.label_tag.Style = MetroFramework.MetroColorStyle.Red;
            this.label_tag.TabIndex = 8;
            this.label_tag.Text = "Tag: ";
            this.label_tag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_tag.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_tag.Click += new System.EventHandler(this.label_tag_Click);
            // 
            // label_email
            // 
            this.label_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_email.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_email.Location = new System.Drawing.Point(20, 141);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(279, 29);
            this.label_email.Style = MetroFramework.MetroColorStyle.Red;
            this.label_email.TabIndex = 10;
            this.label_email.Text = "Email: ";
            this.label_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_email.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // label_id
            // 
            this.label_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_id.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_id.Location = new System.Drawing.Point(20, 176);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(279, 29);
            this.label_id.Style = MetroFramework.MetroColorStyle.Red;
            this.label_id.TabIndex = 11;
            this.label_id.Text = "ID: ";
            this.label_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_id.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // label_tokensloaded
            // 
            this.label_tokensloaded.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_tokensloaded.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_tokensloaded.Location = new System.Drawing.Point(23, 288);
            this.label_tokensloaded.Name = "label_tokensloaded";
            this.label_tokensloaded.Size = new System.Drawing.Size(450, 29);
            this.label_tokensloaded.Style = MetroFramework.MetroColorStyle.Red;
            this.label_tokensloaded.TabIndex = 12;
            this.label_tokensloaded.Text = "Active Verified Tokens: 0";
            this.label_tokensloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_tokensloaded.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label_token
            // 
            this.label_token.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label_token.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.label_token.Location = new System.Drawing.Point(20, 211);
            this.label_token.Name = "label_token";
            this.label_token.Size = new System.Drawing.Size(279, 29);
            this.label_token.Style = MetroFramework.MetroColorStyle.Red;
            this.label_token.TabIndex = 13;
            this.label_token.Text = "Token: ";
            this.label_token.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_token.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.label_token.Click += new System.EventHandler(this.label_token_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(23, 317);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(450, 15);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Left click any data label to silently copy its content";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label_token);
            this.Controls.Add(this.label_tokensloaded);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_tag);
            this.Controls.Add(this.picturebox_avatar);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_filepath);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.combobox_token);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.stylemanager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox combobox_token;
        private MetroFramework.Components.MetroStyleManager stylemanager;
        private MetroFramework.Controls.MetroButton button_back;
        private MetroFramework.Controls.MetroButton button_next;
        private MetroFramework.Controls.MetroLabel label_filepath;
        private MetroFramework.Controls.MetroButton button_browse;
        private MetroFramework.Controls.MetroLabel label_status;
        private System.Windows.Forms.PictureBox picturebox_avatar;
        private System.Windows.Forms.OpenFileDialog openfiledialog;
        private MetroFramework.Controls.MetroLabel label_tag;
        private MetroFramework.Controls.MetroLabel label_email;
        private MetroFramework.Controls.MetroLabel label_id;
        private MetroFramework.Controls.MetroLabel label_tokensloaded;
        private MetroFramework.Controls.MetroLabel label_token;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

