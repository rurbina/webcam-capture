// Webcam-Capture - A simple library for capturing images from a webcam
//
// Copyright © 2009 Justin Cherniak
//
// This library is free software; you can redistribute it and/or modify it
// under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2.1 of the License, or (at
// your option) any later version.
//
// This library is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
// FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public
// License (COPYING.txt) for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this library; if not, write to the Free Software Foundation,
// Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebCamCapture
{
	public partial class CameraForm : Form
	{
		private WebCam m_webCam;
		private Image m_image;

		public CameraForm()
		{
			Cursor.Current = Cursors.WaitCursor;
			InitializeComponent();

			m_webCam = new WebCam(0, m_pictureBox.Handle, 320, 240, true);

			Cursor.Current = Cursors.Default;
		}

		private void OnTakePictureClick(object sender, EventArgs e)
		{
			m_image = m_webCam.TakePicture();
			m_webCam.Stop();

			DialogResult = DialogResult.OK;
			this.Close();
		}

		public static Image TakePicture()
		{
			CameraForm form = new CameraForm();
			form.ShowDialog();

			return form.m_image;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				m_webCam.Dispose();
				if (components != null)
					components.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}
