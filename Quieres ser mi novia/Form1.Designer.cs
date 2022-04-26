namespace Quieres_ser_mi_novia
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Blue;
            this.btnYes.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYes.Location = new System.Drawing.Point(72, 204);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(85, 35);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Si";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.OnClick);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Crimson;
            this.btnNo.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNo.Location = new System.Drawing.Point(464, 204);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(85, 35);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseOver);
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Text.Location = new System.Drawing.Point(154, 85);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(325, 47);
            this.Text.TabIndex = 3;
            this.Text.Text = "¿Quieres ser mi novia?";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(610, 275);
            this.ControlBox = false;
            this.Controls.Add(this.Text);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnYes;
        private Button btnNo;
        private Label Text;
    }
}