/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 12/10/2015
 * Time: 20:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pokemon_Dream_Radar_Save_Editor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		byte[] savebuffer = new byte[692];
		short orbs;
		short total_orbs;
		byte gen4ext;
		byte gen4ext_captured;
		public string savegame
        {
            get { return savegamename.Text; }
        }
		public string orbs_s
        {
			get { return orbs.ToString(); }
        }

		/// <summary>
		/// Reads data into a complete array, throwing an EndOfStreamException
		/// if the stream runs out of data first, or if an IOException
		/// naturally occurs.
		/// </summary>
		/// <param name="stream">The stream to read data from</param>
		/// <param name="data">The array to read bytes into. The array
		/// will be completely filled from the stream, so an appropriate
		/// size must be given.</param>
		public static void ReadWholeArray (Stream stream, byte[] data)
		{
		    int offset=0;
		    int remaining = data.Length;
		    while (remaining > 0)
		    {
		        int read = stream.Read(data, offset, remaining);
		        if (read <= 0)
		            throw new EndOfStreamException 
		                (String.Format("End of stream reached with {0} bytes left to read", remaining));
		        remaining -= read;
		        offset += read;
		    }
		}
		private void PDR_get_data()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            //openFD.InitialDirectory = "c:\\";
            openFD.Filter = "cygsavedata|*.dat|All Files (*.*)|*.*";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                #region filename
                savegamename.Text = openFD.FileName;
                #endregion
            
	            System.IO.FileStream saveFile;
	            saveFile = new FileStream(savegame, FileMode.Open);
	            ReadWholeArray(saveFile, savebuffer);
	            saveFile.Close();
	            total_orbs = BitConverter.ToInt16(savebuffer, 0x6C);
	            orbs = BitConverter.ToInt16(savebuffer, 0x68);
	            gen4ext = savebuffer[0x26E];
	            gen4ext_captured = savebuffer[0x272];;
	            //Set data
	            totalorb_box.Value = total_orbs;
	            orbs_box.Value = orbs;
	            //Parse extension unlocked flags
	            if ((gen4ext & 0x4) >1) dialga_check.Checked = true;
	            else dialga_check.Checked = false;
	            if ((gen4ext & 0x8) >1) palkia_check.Checked = true;
	            else palkia_check.Checked = false;
	            if ((gen4ext & 0x10) >1) giratina_check.Checked = true;
	            else giratina_check.Checked = false;
	            if ((gen4ext & 0x20) >1) hoho_check.Checked = true;
	            else hoho_check.Checked = false;
	            if ((gen4ext & 0x40) >1) lugia_check.Checked = true;
	            else lugia_check.Checked = false;
	            
	            //Parse extension pokemon flags
	            if ((gen4ext_captured & 0x10) >1) dialga_catch_check.Checked = true;
	            else dialga_catch_check.Checked = false;
	            if ((gen4ext_captured & 0x20) >1) palkia_catch_check.Checked = true;
	            else palkia_catch_check.Checked = false;
	            if ((gen4ext_captured & 0x40) >1) giratina_catch_check.Checked = true;
	            else giratina_catch_check.Checked = false;
	            if ((gen4ext_captured & 0x80) >1) hoho_catch_check.Checked = true;
	            else hoho_catch_check.Checked = false;
	            //if ((gen4ext_captured & 0x80) >1) lugia_catch_check.Checked = true;
	            //else lugia_catch_check.Checked = false;
            }
            
        }
		private void PDR_save_data()
		{	if (savegame.Length < 1) return;
            SaveFileDialog saveFD = new SaveFileDialog();
            //saveFD.InitialDirectory = "c:\\";
            saveFD.Filter = "cygsavedata|*.dat|All Files (*.*)|*.*";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
	            System.IO.FileStream saveFile;
	            saveFile = new FileStream(saveFD.FileName, FileMode.Create);
	            //Update orbs
	            Array.Copy(BitConverter.GetBytes(orbs), 0, savebuffer, 0x68, 2);
	            //Update extensions
	            if (dialga_check.Checked) gen4ext |= 0x4;
	            else gen4ext &= byte.MaxValue ^ 0x4;
	            if (palkia_check.Checked) gen4ext |= 0x8;
	            else gen4ext &= byte.MaxValue ^ 0x8;
	            if (giratina_check.Checked) gen4ext |= 0x10;
	            else gen4ext &= byte.MaxValue ^ 0x10;
	            if (hoho_check.Checked) gen4ext |= 0x20;
	            else gen4ext &= byte.MaxValue ^ 0x20;
	            if (lugia_check.Checked) gen4ext |= 0x40;
	            else gen4ext &= byte.MaxValue ^ 0x40;
	            savebuffer[0x26E] = gen4ext;
	            //Update catched extension pokemon
	            if (dialga_catch_check.Checked) gen4ext_captured |= 0x10;
	            else gen4ext_captured &= byte.MaxValue ^ 0x10;
	            if (palkia_catch_check.Checked) gen4ext_captured |= 0x20;
	            else gen4ext_captured &= byte.MaxValue ^ 0x20;
	            if (giratina_catch_check.Checked) gen4ext_captured |= 0x40;
	            else gen4ext_captured &= byte.MaxValue ^ 0x40;
	            if (hoho_catch_check.Checked) gen4ext_captured |= 0x80;
	            else gen4ext_captured &= byte.MaxValue ^ 0x80;
	            //if (lugia_catch_check.Checked) gen4ext_captured |= 0x40;
	            //else gen4ext_captured &= byte.MaxValue ^ 0x40;
	            savebuffer[0x272] = gen4ext_captured;	            
	            //Write file
	            saveFile.Write(savebuffer, 0, savebuffer.Length);
	            saveFile.Close();
	            MessageBox.Show("File Saved.", "Save file");
            }
		}
		void SavegamenameTextChanged(object sender, EventArgs e)
		{
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			PDR_get_data();
		}
		void Orbs_boxValueChanged(object sender, EventArgs e)
		{
			orbs = Convert.ToInt16(orbs_box.Value);
		}
		void Button2Click(object sender, EventArgs e)
		{
			PDR_save_data();
		}

	}
}
