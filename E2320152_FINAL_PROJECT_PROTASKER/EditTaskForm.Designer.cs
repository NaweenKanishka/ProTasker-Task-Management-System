namespace E2320152_FINAL_PROJECT_PROTASKER
{
    partial class EditTaskForm
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
            this.txtTaskName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerDue = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTaskId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtTaskName
            // 
            this.txtTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaskName.DefaultText = "";
            this.txtTaskName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaskName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaskName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.DisabledState.Parent = this.txtTaskName;
            this.txtTaskName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaskName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.FocusedState.Parent = this.txtTaskName;
            this.txtTaskName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaskName.HoverState.Parent = this.txtTaskName;
            this.txtTaskName.Location = new System.Drawing.Point(73, 36);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PasswordChar = '\0';
            this.txtTaskName.PlaceholderText = "";
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.ShadowDecoration.Parent = this.txtTaskName;
            this.txtTaskName.Size = new System.Drawing.Size(200, 36);
            this.txtTaskName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.Parent = this.txtDescription;
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedState.Parent = this.txtDescription;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescription.HoverState.Parent = this.txtDescription;
            this.txtDescription.Location = new System.Drawing.Point(73, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
            this.txtDescription.Size = new System.Drawing.Size(200, 36);
            this.txtDescription.TabIndex = 1;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CheckedState.Parent = this.dateTimePickerStart;
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerStart.HoverState.Parent = this.dateTimePickerStart;
            this.dateTimePickerStart.Location = new System.Drawing.Point(73, 120);
            this.dateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShadowDecoration.Parent = this.dateTimePickerStart;
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 36);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.Value = new System.DateTime(2025, 4, 12, 14, 40, 6, 695);
            // 
            // dateTimePickerDue
            // 
            this.dateTimePickerDue.CheckedState.Parent = this.dateTimePickerDue;
            this.dateTimePickerDue.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerDue.HoverState.Parent = this.dateTimePickerDue;
            this.dateTimePickerDue.Location = new System.Drawing.Point(73, 162);
            this.dateTimePickerDue.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDue.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDue.Name = "dateTimePickerDue";
            this.dateTimePickerDue.ShadowDecoration.Parent = this.dateTimePickerDue;
            this.dateTimePickerDue.Size = new System.Drawing.Size(200, 36);
            this.dateTimePickerDue.TabIndex = 3;
            this.dateTimePickerDue.Value = new System.DateTime(2025, 4, 12, 14, 40, 6, 695);
            // 
            // cmbPriority
            // 
            this.cmbPriority.BackColor = System.Drawing.Color.Transparent;
            this.cmbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPriority.FocusedState.Parent = this.cmbPriority;
            this.cmbPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.HoverState.Parent = this.cmbPriority;
            this.cmbPriority.ItemHeight = 30;
            this.cmbPriority.Items.AddRange(new object[] {
            "Small",
            "High",
            "Medium"});
            this.cmbPriority.ItemsAppearance.Parent = this.cmbPriority;
            this.cmbPriority.Location = new System.Drawing.Point(73, 204);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.ShadowDecoration.Parent = this.cmbPriority;
            this.cmbPriority.Size = new System.Drawing.Size(200, 36);
            this.cmbPriority.TabIndex = 4;
            // 
            // lblTaskId
            // 
            this.lblTaskId.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskId.Location = new System.Drawing.Point(73, 247);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(86, 15);
            this.lblTaskId.TabIndex = 5;
            this.lblTaskId.Text = "guna2HtmlLabel1";
            // 
            // btnsave
            // 
            this.btnsave.CheckedState.Parent = this.btnsave;
            this.btnsave.CustomImages.Parent = this.btnsave;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.HoverState.Parent = this.btnsave;
            this.btnsave.Location = new System.Drawing.Point(73, 268);
            this.btnsave.Name = "btnsave";
            this.btnsave.ShadowDecoration.Parent = this.btnsave;
            this.btnsave.Size = new System.Drawing.Size(200, 45);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "guna2Button1";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblTaskId);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.dateTimePickerDue);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskName);
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
            this.Load += new System.EventHandler(this.EditTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTaskName;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerDue;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPriority;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTaskId;
        private Guna.UI2.WinForms.Guna2Button btnsave;
    }
}