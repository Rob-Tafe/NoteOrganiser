namespace NoteOrganiser
{
    partial class NoteOrganiser
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
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.RtbNote = new System.Windows.Forms.RichTextBox();
            this.TbStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOpen
            // 
            this.BtnOpen.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpen.Location = new System.Drawing.Point(10, 10);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(80, 40);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(120, 10);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(80, 40);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // RtbNote
            // 
            this.RtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbNote.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RtbNote.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbNote.Location = new System.Drawing.Point(10, 70);
            this.RtbNote.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RtbNote.Name = "RtbNote";
            this.RtbNote.Size = new System.Drawing.Size(785, 530);
            this.RtbNote.TabIndex = 4;
            this.RtbNote.Text = "";
            this.RtbNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotkeySave);
            this.RtbNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AutoNewLine);
            // 
            // TbStatus
            // 
            this.TbStatus.Location = new System.Drawing.Point(695, 40);
            this.TbStatus.Name = "TbStatus";
            this.TbStatus.ReadOnly = true;
            this.TbStatus.Size = new System.Drawing.Size(100, 21);
            this.TbStatus.TabIndex = 5;
            // 
            // NoteOrganiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.TbStatus);
            this.Controls.Add(this.RtbNote);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnOpen);
            this.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NoteOrganiser";
            this.Text = "NoteOrganiser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RichTextBox RtbNote;
        private System.Windows.Forms.TextBox TbStatus;
    }
}

