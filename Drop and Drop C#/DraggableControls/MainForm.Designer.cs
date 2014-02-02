namespace DraggableControls
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
            this.btnTest = new System.Windows.Forms.Button();
            this.checkBox_DragForm = new System.Windows.Forms.CheckBox();
            this.checkBox_DragButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(175, 28);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(97, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test button";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // checkBox_DragForm
            // 
            this.checkBox_DragForm.AutoSize = true;
            this.checkBox_DragForm.Location = new System.Drawing.Point(13, 28);
            this.checkBox_DragForm.Name = "checkBox_DragForm";
            this.checkBox_DragForm.Size = new System.Drawing.Size(101, 17);
            this.checkBox_DragForm.TabIndex = 1;
            this.checkBox_DragForm.Text = "Draggable Form";
            this.checkBox_DragForm.UseVisualStyleBackColor = true;
            this.checkBox_DragForm.CheckedChanged += new System.EventHandler(this.checkBox_DragForm_CheckedChanged);
            // 
            // checkBox_DragButton
            // 
            this.checkBox_DragButton.AutoSize = true;
            this.checkBox_DragButton.Location = new System.Drawing.Point(13, 52);
            this.checkBox_DragButton.Name = "checkBox_DragButton";
            this.checkBox_DragButton.Size = new System.Drawing.Size(109, 17);
            this.checkBox_DragButton.TabIndex = 2;
            this.checkBox_DragButton.Text = "Draggable Button";
            this.checkBox_DragButton.UseVisualStyleBackColor = true;
            this.checkBox_DragButton.CheckedChanged += new System.EventHandler(this.checkBox_DragButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.checkBox_DragButton);
            this.Controls.Add(this.checkBox_DragForm);
            this.Controls.Add(this.btnTest);
            this.Name = "MainForm";
            this.Text = "Test form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox checkBox_DragForm;
        private System.Windows.Forms.CheckBox checkBox_DragButton;
    }
}

