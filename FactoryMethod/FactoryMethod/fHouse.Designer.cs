namespace FactoryMethod
{
    partial class fHouse
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rb3DShapeType = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxHouseImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHouseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(720, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 686);
            this.panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreate.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCreate.Location = new System.Drawing.Point(45, 569);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(290, 83);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.rb3DShapeType);
            this.panel2.Location = new System.Drawing.Point(19, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 267);
            this.panel2.TabIndex = 1;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Snap ITC", 16.2F);
            this.radioButton3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton3.Location = new System.Drawing.Point(15, 193);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(224, 40);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Wood House";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rbHouseType_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Snap ITC", 16.2F);
            this.radioButton2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.radioButton2.Location = new System.Drawing.Point(15, 109);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(229, 40);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Brick House";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rbHouseType_CheckedChanged);
            // 
            // rb3DShapeType
            // 
            this.rb3DShapeType.AutoSize = true;
            this.rb3DShapeType.Font = new System.Drawing.Font("Snap ITC", 16.2F);
            this.rb3DShapeType.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rb3DShapeType.Location = new System.Drawing.Point(15, 23);
            this.rb3DShapeType.Name = "rb3DShapeType";
            this.rb3DShapeType.Size = new System.Drawing.Size(286, 40);
            this.rb3DShapeType.TabIndex = 0;
            this.rb3DShapeType.TabStop = true;
            this.rb3DShapeType.Text = "Concrete House";
            this.rb3DShapeType.UseVisualStyleBackColor = true;
            this.rb3DShapeType.CheckedChanged += new System.EventHandler(this.rbHouseType_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose House";
            // 
            // pbxHouseImage
            // 
            this.pbxHouseImage.BackColor = System.Drawing.Color.Lavender;
            this.pbxHouseImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxHouseImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxHouseImage.Location = new System.Drawing.Point(0, 0);
            this.pbxHouseImage.Margin = new System.Windows.Forms.Padding(100);
            this.pbxHouseImage.Name = "pbxHouseImage";
            this.pbxHouseImage.Size = new System.Drawing.Size(720, 686);
            this.pbxHouseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHouseImage.TabIndex = 1;
            this.pbxHouseImage.TabStop = false;
            // 
            // fHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1099, 686);
            this.Controls.Add(this.pbxHouseImage);
            this.Controls.Add(this.panel1);
            this.Name = "fHouse";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHouseImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxHouseImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb3DShapeType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnCreate;
    }
}

