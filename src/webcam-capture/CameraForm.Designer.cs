namespace WebCamCapture
{
	partial class CameraForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_pictureBox = new System.Windows.Forms.PictureBox();
			this.m_btnTakePicture = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.m_pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// m_pictureBox
			// 
			this.m_pictureBox.Location = new System.Drawing.Point(12, 12);
			this.m_pictureBox.Name = "m_pictureBox";
			this.m_pictureBox.Size = new System.Drawing.Size(320, 240);
			this.m_pictureBox.TabIndex = 0;
			this.m_pictureBox.TabStop = false;
			// 
			// m_btnTakePicture
			// 
			this.m_btnTakePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnTakePicture.Location = new System.Drawing.Point(66, 258);
			this.m_btnTakePicture.Name = "m_btnTakePicture";
			this.m_btnTakePicture.Size = new System.Drawing.Size(206, 48);
			this.m_btnTakePicture.TabIndex = 1;
			this.m_btnTakePicture.Text = "&Take Picture";
			this.m_btnTakePicture.UseVisualStyleBackColor = true;
			this.m_btnTakePicture.Click += new System.EventHandler(this.OnTakePictureClick);
			// 
			// CameraForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 318);
			this.Controls.Add(this.m_btnTakePicture);
			this.Controls.Add(this.m_pictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CameraForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Camera";
			((System.ComponentModel.ISupportInitialize)(this.m_pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox m_pictureBox;
		private System.Windows.Forms.Button m_btnTakePicture;
	}
}