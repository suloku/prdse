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
		UInt32 orbscash;
		byte currclouds;
		//Upgrades
		byte beam;
		byte battery;
		byte visor;
		//Items
		byte vortex;
		byte dragnet;
		byte energyr;
		//Highscire
		UInt32 total_orbs;
		UInt32 next_reward_orbs;
		UInt32 searches;
		UInt32 clouds;
		UInt32 captured;
		UInt32 itemcnt;
		UInt32 tornadus_t;
		UInt32 thundurus_t;
		UInt32 landorus_t;

		//Flags
		byte gen4ext;
		byte gen4ext_captured;
		byte gen4ext_captured2;
		
		public string savegame
        {
            get { return savegamename.Text; }
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
		private void PDR_read_data()
		{
	            System.IO.FileStream saveFile;
	            saveFile = new FileStream(savegame, FileMode.Open);
	            ReadWholeArray(saveFile, savebuffer);
	            saveFile.Close();
	            //Orbs
	            orbscash = BitConverter.ToUInt32(savebuffer, 0x68);
				next_reward_orbs = BitConverter.ToUInt32(savebuffer, 0x288);
				currclouds = savebuffer[0x74];
				//Upgrades
				beam = savebuffer[0x71];
				battery = savebuffer[0x72];
				visor = savebuffer[0x73];
				//Items
				vortex = savebuffer[0x268];
				dragnet = savebuffer[0x269];
				energyr = savebuffer[0x26A];
	            //Highscores
	            total_orbs = BitConverter.ToUInt32(savebuffer, 0x6C);
				searches = BitConverter.ToUInt32(savebuffer, 0x28C);
				clouds = BitConverter.ToUInt32(savebuffer, 0x290);
				captured = BitConverter.ToUInt32(savebuffer, 0x294);
				itemcnt = BitConverter.ToUInt32(savebuffer, 0x298);
				tornadus_t = BitConverter.ToUInt32(savebuffer, 0x29C);
				thundurus_t = BitConverter.ToUInt32(savebuffer, 0x2A0);
				landorus_t = BitConverter.ToUInt32(savebuffer, 0x2A4);
	            //Flags
	            gen4ext = savebuffer[0x26E];
	            gen4ext_captured = savebuffer[0x272];
	            gen4ext_captured2 = savebuffer[0x273];



	        //Set data
	            //Orbs
	            orbscash_box.Value = orbscash;
	            next_reward_orbs_box.Value = next_reward_orbs;
	            currclouds_box.Value = currclouds;

	            //Upgrades
	            beam_box.Value = beam+1;
	            battery_box.Value = battery+1;
	            visor_box.Value = visor+1;
	            	//Set max for current cloud box based on visor level
	            	currclouds_box.Maximum = 10+(5*visor);
	            //Items
	            vortex_box.Value = vortex;
	            dragnet_box.Value = dragnet;
	            energyr_box.Value = energyr;
	            //Highscores
	            totalorb_box.Value = total_orbs;
	            searches_box.Value = searches;
	            clouds_box.Value = clouds;
	            captured_box.Value = captured;
	            itemcnt_box.Value = itemcnt;
	            tornadus_t_box.Value = tornadus_t;
	            thundurus_t_box.Value = thundurus_t;
	            landorus_t_box.Value = landorus_t;

	            //Parse extension unlocked flags
	            if ((gen4ext & 0x4) >0) dialga_check.Checked = true;
	            else dialga_check.Checked = false;
	            if ((gen4ext & 0x8) >0) palkia_check.Checked = true;
	            else palkia_check.Checked = false;
	            if ((gen4ext & 0x10) >0) giratina_check.Checked = true;
	            else giratina_check.Checked = false;
	            if ((gen4ext & 0x20) >0) hoho_check.Checked = true;
	            else hoho_check.Checked = false;
	            if ((gen4ext & 0x40) >0) lugia_check.Checked = true;
	            else lugia_check.Checked = false;
	            
	            //Parse extension pokemon flags
	            if ((gen4ext_captured & 0x10) >0) dialga_catch_check.Checked = true;
	            else dialga_catch_check.Checked = false;
	            if ((gen4ext_captured & 0x20) >0) palkia_catch_check.Checked = true;
	            else palkia_catch_check.Checked = false;
	            if ((gen4ext_captured & 0x40) >0) giratina_catch_check.Checked = true;
	            else giratina_catch_check.Checked = false;
	            if ((gen4ext_captured & 0x80) >0) hoho_catch_check.Checked = true;
	            else hoho_catch_check.Checked = false;
	            if ((gen4ext_captured2 & 0x01) >0) lugia_catch_check.Checked = true;
	            else lugia_catch_check.Checked = false;
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
                PDR_read_data();
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
	            Array.Copy(BitConverter.GetBytes(orbscash), 0, savebuffer, 0x68, 4);
	            Array.Copy(BitConverter.GetBytes(next_reward_orbs), 0, savebuffer, 0x288, 4);
	            savebuffer[0x74] = currclouds;

	            //Upgrades
	            savebuffer[0x71] = beam;
	            savebuffer[0x72] = battery;
	            savebuffer[0x73] = visor;
	            //Items
	            savebuffer[0x268] = vortex;
	            savebuffer[0x269] = dragnet;
	            savebuffer[0x26A] = energyr;
	            //Highscores
	            Array.Copy(BitConverter.GetBytes(total_orbs), 0, savebuffer, 0x6C, 4);
	            Array.Copy(BitConverter.GetBytes(searches), 0, savebuffer, 0x28C, 4);
	            Array.Copy(BitConverter.GetBytes(clouds), 0, savebuffer, 0x290, 4);
	            Array.Copy(BitConverter.GetBytes(captured), 0, savebuffer, 0x294, 4);
	            Array.Copy(BitConverter.GetBytes(itemcnt), 0, savebuffer, 0x298, 4);
	            Array.Copy(BitConverter.GetBytes(tornadus_t), 0, savebuffer, 0x29C, 4);
	            Array.Copy(BitConverter.GetBytes(thundurus_t), 0, savebuffer, 0x2A0, 4);
	            Array.Copy(BitConverter.GetBytes(landorus_t), 0, savebuffer, 0x2A4, 4);

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
	            if (lugia_catch_check.Checked) gen4ext_captured2 |= 0x1;
	            else gen4ext_captured2 &= byte.MaxValue ^ 0x1;
	            savebuffer[0x272] = gen4ext_captured;	
				savebuffer[0x273] = gen4ext_captured2;
				
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
		void Orbscash_boxValueChanged(object sender, EventArgs e)
		{
			orbscash = Convert.ToUInt32(orbscash_box.Value);
		}
		void Button2Click(object sender, EventArgs e)
		{
			PDR_save_data();
		}
		void MainFormDragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}
		void MainFormDragDrop(object sender, DragEventArgs e)
		{
			string[] files =  (string[]) e.Data.GetData(DataFormats.FileDrop, false);
			savegamename.Text =  files[0];
			PDR_read_data();
		}
		void Next_reward_orbs_boxValueChanged(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			next_reward_orbs = 3000;
			next_reward_orbs_box.Value = next_reward_orbs;
		}
		void Button4Click(object sender, EventArgs e)
		{
			currclouds =  Convert.ToByte(10+(5*visor));
			currclouds_box.Value = currclouds;
		}
		void Currclouds_boxValueChanged(object sender, EventArgs e)
		{
			currclouds = Convert.ToByte(currclouds_box.Value);
		}
		void Totalorb_boxValueChanged(object sender, EventArgs e)
		{
			total_orbs = Convert.ToUInt32(totalorb_box.Value);
		}
		void Searches_boxValueChanged(object sender, EventArgs e)
		{
			searches = Convert.ToUInt32(searches_box.Value);
		}
		void Clouds_boxValueChanged(object sender, EventArgs e)
		{
			clouds = Convert.ToUInt32(clouds_box.Value);
		}
		void Captured_boxValueChanged(object sender, EventArgs e)
		{
			captured = Convert.ToUInt32(captured_box.Value);
		}
		void Itemcnt_boxValueChanged(object sender, EventArgs e)
		{
			itemcnt = Convert.ToUInt32(itemcnt_box.Value);
		}
		void Tornadus_t_boxValueChanged(object sender, EventArgs e)
		{
			tornadus_t = Convert.ToUInt32(tornadus_t_box.Value);
		}
		void Thundurus_t_boxValueChanged(object sender, EventArgs e)
		{
			thundurus_t = Convert.ToUInt32(thundurus_t_box.Value);
		}
		void Landorus_t_boxValueChanged(object sender, EventArgs e)
		{
			landorus_t = Convert.ToUInt32(landorus_t_box.Value);
		}
		void Beam_boxValueChanged(object sender, EventArgs e)
		{
			beam = Convert.ToByte(beam_box.Value-1);
		}
		void Battery_boxValueChanged(object sender, EventArgs e)
		{
			battery = Convert.ToByte(battery_box.Value-1);
		}
		void Visor_boxValueChanged(object sender, EventArgs e)
		{
			visor = Convert.ToByte(visor_box.Value-1);
			currclouds_box.Maximum = 10+(5*visor);
			if (currclouds_box.Value > currclouds_box.Maximum) currclouds_box.Value = currclouds_box.Maximum;
		}
		void Vortex_boxValueChanged(object sender, EventArgs e)
		{
			vortex = Convert.ToByte(vortex_box.Value);
		}
		void Dragnet_boxValueChanged(object sender, EventArgs e)
		{
			dragnet = Convert.ToByte(dragnet_box.Value);
		}
		void Energyr_boxValueChanged(object sender, EventArgs e)
		{
			energyr = Convert.ToByte(energyr_box.Value);
		}

	}
}
