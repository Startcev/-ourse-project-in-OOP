namespace WFhumans
{
    partial class Form2add
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
            this.btaddElement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btaddElement
            // 
            this.btaddElement.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btaddElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btaddElement.Location = new System.Drawing.Point(13, 199);
            this.btaddElement.Margin = new System.Windows.Forms.Padding(4);
            this.btaddElement.Name = "btaddElement";
            this.btaddElement.Size = new System.Drawing.Size(273, 52);
            this.btaddElement.TabIndex = 4;
            this.btaddElement.Text = "Добавить в коллекцию";
            this.btaddElement.UseVisualStyleBackColor = true;
            this.btaddElement.Click += new System.EventHandler(this.btaddHuman_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxLongitude);
            this.panel1.Controls.Add(this.textBoxLatitude);
            this.panel1.Controls.Add(this.textBoxArea);
            this.panel1.Controls.Add(this.labelLongitude);
            this.panel1.Controls.Add(this.labelLatitude);
            this.panel1.Controls.Add(this.labelArea);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 180);
            this.panel1.TabIndex = 1;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(171, 130);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(297, 29);
            this.textBoxLongitude.TabIndex = 3;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(171, 70);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(297, 29);
            this.textBoxLatitude.TabIndex = 2;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(171, 8);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(297, 29);
            this.textBoxArea.TabIndex = 1;
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(8, 133);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(85, 24);
            this.labelLongitude.TabIndex = 2;
            this.labelLongitude.Text = "Долгота";
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Location = new System.Drawing.Point(8, 73);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(77, 24);
            this.labelLatitude.TabIndex = 1;
            this.labelLatitude.Text = "Широта";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(8, 11);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(90, 24);
            this.labelArea.TabIndex = 0;
            this.labelArea.Text = "Площадь";
            // 
            // Form2add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btaddElement);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2add";
            this.Text = "Form2add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btaddElement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Label labelArea;
    }
}