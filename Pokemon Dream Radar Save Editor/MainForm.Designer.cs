/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 12/10/2015
 * Time: 20:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pokemon_Dream_Radar_Save_Editor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox savegamename;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown orbs_box;
		private System.Windows.Forms.CheckBox dialga_check;
		private System.Windows.Forms.CheckBox giratina_check;
		private System.Windows.Forms.CheckBox hoho_check;
		private System.Windows.Forms.CheckBox lugia_check;
		private System.Windows.Forms.CheckBox palkia_check;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown totalorb_box;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox giratina_catch_check;
		private System.Windows.Forms.CheckBox palkia_catch_check;
		private System.Windows.Forms.CheckBox lugia_catch_check;
		private System.Windows.Forms.CheckBox hoho_catch_check;
		private System.Windows.Forms.CheckBox dialga_catch_check;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox12;
		private System.Windows.Forms.CheckBox checkBox11;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;

		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.savegamename = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.totalorb_box = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.giratina_catch_check = new System.Windows.Forms.CheckBox();
			this.dialga_catch_check = new System.Windows.Forms.CheckBox();
			this.palkia_catch_check = new System.Windows.Forms.CheckBox();
			this.lugia_catch_check = new System.Windows.Forms.CheckBox();
			this.hoho_catch_check = new System.Windows.Forms.CheckBox();
			this.giratina_check = new System.Windows.Forms.CheckBox();
			this.dialga_check = new System.Windows.Forms.CheckBox();
			this.palkia_check = new System.Windows.Forms.CheckBox();
			this.lugia_check = new System.Windows.Forms.CheckBox();
			this.hoho_check = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.orbs_box = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBox11 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox12 = new System.Windows.Forms.CheckBox();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(112, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Open Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// savegamename
			// 
			this.savegamename.Location = new System.Drawing.Point(12, 41);
			this.savegamename.Name = "savegamename";
			this.savegamename.Size = new System.Drawing.Size(298, 20);
			this.savegamename.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(646, 36);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(316, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Total collected orbs";
			// 
			// totalorb_box
			// 
			this.totalorb_box.Location = new System.Drawing.Point(422, 39);
			this.totalorb_box.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
			this.totalorb_box.Name = "totalorb_box";
			this.totalorb_box.ReadOnly = true;
			this.totalorb_box.Size = new System.Drawing.Size(120, 20);
			this.totalorb_box.TabIndex = 14;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.giratina_catch_check);
			this.groupBox1.Controls.Add(this.dialga_catch_check);
			this.groupBox1.Controls.Add(this.palkia_catch_check);
			this.groupBox1.Controls.Add(this.lugia_catch_check);
			this.groupBox1.Controls.Add(this.hoho_catch_check);
			this.groupBox1.Controls.Add(this.giratina_check);
			this.groupBox1.Controls.Add(this.dialga_check);
			this.groupBox1.Controls.Add(this.palkia_check);
			this.groupBox1.Controls.Add(this.lugia_check);
			this.groupBox1.Controls.Add(this.hoho_check);
			this.groupBox1.Location = new System.Drawing.Point(555, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(247, 124);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gen IV Extension";
			// 
			// giratina_catch_check
			// 
			this.giratina_catch_check.Location = new System.Drawing.Point(127, 55);
			this.giratina_catch_check.Name = "giratina_catch_check";
			this.giratina_catch_check.Size = new System.Drawing.Size(114, 24);
			this.giratina_catch_check.TabIndex = 18;
			this.giratina_catch_check.Text = "Giratina Catched";
			this.giratina_catch_check.UseVisualStyleBackColor = true;
			// 
			// dialga_catch_check
			// 
			this.dialga_catch_check.Location = new System.Drawing.Point(127, 14);
			this.dialga_catch_check.Name = "dialga_catch_check";
			this.dialga_catch_check.Size = new System.Drawing.Size(115, 24);
			this.dialga_catch_check.TabIndex = 16;
			this.dialga_catch_check.Text = "Dialga Catched";
			this.dialga_catch_check.UseVisualStyleBackColor = true;
			// 
			// palkia_catch_check
			// 
			this.palkia_catch_check.Location = new System.Drawing.Point(127, 34);
			this.palkia_catch_check.Name = "palkia_catch_check";
			this.palkia_catch_check.Size = new System.Drawing.Size(104, 24);
			this.palkia_catch_check.TabIndex = 17;
			this.palkia_catch_check.Text = "Palkia Catched";
			this.palkia_catch_check.UseVisualStyleBackColor = true;
			// 
			// lugia_catch_check
			// 
			this.lugia_catch_check.Location = new System.Drawing.Point(127, 95);
			this.lugia_catch_check.Name = "lugia_catch_check";
			this.lugia_catch_check.Size = new System.Drawing.Size(115, 24);
			this.lugia_catch_check.TabIndex = 20;
			this.lugia_catch_check.Text = "Lugia Catched";
			this.lugia_catch_check.UseVisualStyleBackColor = true;
			// 
			// hoho_catch_check
			// 
			this.hoho_catch_check.Location = new System.Drawing.Point(127, 75);
			this.hoho_catch_check.Name = "hoho_catch_check";
			this.hoho_catch_check.Size = new System.Drawing.Size(115, 24);
			this.hoho_catch_check.TabIndex = 19;
			this.hoho_catch_check.Text = "Ho-Oh Catched";
			this.hoho_catch_check.UseVisualStyleBackColor = true;
			// 
			// giratina_check
			// 
			this.giratina_check.Location = new System.Drawing.Point(6, 55);
			this.giratina_check.Name = "giratina_check";
			this.giratina_check.Size = new System.Drawing.Size(123, 24);
			this.giratina_check.TabIndex = 13;
			this.giratina_check.Text = "Renegade (Giratina)";
			this.giratina_check.UseVisualStyleBackColor = true;
			// 
			// dialga_check
			// 
			this.dialga_check.Location = new System.Drawing.Point(6, 14);
			this.dialga_check.Name = "dialga_check";
			this.dialga_check.Size = new System.Drawing.Size(115, 24);
			this.dialga_check.TabIndex = 11;
			this.dialga_check.Text = "Temporal (Dialga)";
			this.dialga_check.UseVisualStyleBackColor = true;
			// 
			// palkia_check
			// 
			this.palkia_check.Location = new System.Drawing.Point(6, 34);
			this.palkia_check.Name = "palkia_check";
			this.palkia_check.Size = new System.Drawing.Size(104, 24);
			this.palkia_check.TabIndex = 12;
			this.palkia_check.Text = "Spatial (Palkia)";
			this.palkia_check.UseVisualStyleBackColor = true;
			// 
			// lugia_check
			// 
			this.lugia_check.Location = new System.Drawing.Point(6, 95);
			this.lugia_check.Name = "lugia_check";
			this.lugia_check.Size = new System.Drawing.Size(115, 24);
			this.lugia_check.TabIndex = 15;
			this.lugia_check.Text = "Diving (Lugia)";
			this.lugia_check.UseVisualStyleBackColor = true;
			// 
			// hoho_check
			// 
			this.hoho_check.Location = new System.Drawing.Point(6, 75);
			this.hoho_check.Name = "hoho_check";
			this.hoho_check.Size = new System.Drawing.Size(115, 24);
			this.hoho_check.TabIndex = 14;
			this.hoho_check.Text = "Rainbow (Ho-Oh)";
			this.hoho_check.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numericUpDown4);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.numericUpDown3);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.numericUpDown2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.orbs_box);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(12, 87);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(227, 152);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Orbs";
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.Location = new System.Drawing.Point(89, 120);
			this.numericUpDown4.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.ReadOnly = true;
			this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown4.TabIndex = 33;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(35, 122);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 32;
			this.label6.Text = "Blue";
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(89, 94);
			this.numericUpDown3.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.ReadOnly = true;
			this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown3.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(35, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 30;
			this.label5.Text = "Orange:";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(89, 68);
			this.numericUpDown2.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.ReadOnly = true;
			this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown2.TabIndex = 29;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(35, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 28;
			this.label4.Text = "Green:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(89, 42);
			this.numericUpDown1.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ReadOnly = true;
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(35, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 26;
			this.label2.Text = "Pink:";
			// 
			// orbs_box
			// 
			this.orbs_box.Location = new System.Drawing.Point(55, 17);
			this.orbs_box.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
			this.orbs_box.Name = "orbs_box";
			this.orbs_box.Size = new System.Drawing.Size(120, 20);
			this.orbs_box.TabIndex = 25;
			this.orbs_box.ValueChanged += new System.EventHandler(this.Orbs_boxValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 24;
			this.label1.Text = "Current:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkBox12);
			this.groupBox3.Controls.Add(this.checkBox11);
			this.groupBox3.Controls.Add(this.checkBox10);
			this.groupBox3.Controls.Add(this.checkBox9);
			this.groupBox3.Controls.Add(this.checkBox8);
			this.groupBox3.Controls.Add(this.checkBox7);
			this.groupBox3.Controls.Add(this.checkBox6);
			this.groupBox3.Controls.Add(this.checkBox5);
			this.groupBox3.Controls.Add(this.checkBox4);
			this.groupBox3.Controls.Add(this.checkBox3);
			this.groupBox3.Controls.Add(this.checkBox2);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Location = new System.Drawing.Point(245, 87);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(297, 152);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Extensions (Currently disabled)";
			// 
			// checkBox11
			// 
			this.checkBox11.Location = new System.Drawing.Point(160, 116);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(131, 24);
			this.checkBox11.TabIndex = 10;
			this.checkBox11.Text = "Landorus Catched";
			this.checkBox11.UseVisualStyleBackColor = true;
			// 
			// checkBox10
			// 
			this.checkBox10.Location = new System.Drawing.Point(160, 95);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(131, 24);
			this.checkBox10.TabIndex = 9;
			this.checkBox10.Text = "Thundurus Catched";
			this.checkBox10.UseVisualStyleBackColor = true;
			// 
			// checkBox9
			// 
			this.checkBox9.Location = new System.Drawing.Point(160, 75);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(131, 24);
			this.checkBox9.TabIndex = 8;
			this.checkBox9.Text = "Tornadus Catched";
			this.checkBox9.UseVisualStyleBackColor = true;
			// 
			// checkBox8
			// 
			this.checkBox8.Location = new System.Drawing.Point(160, 55);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(131, 24);
			this.checkBox8.TabIndex = 7;
			this.checkBox8.Text = "Simulator Gamma";
			this.checkBox8.UseVisualStyleBackColor = true;
			// 
			// checkBox7
			// 
			this.checkBox7.Location = new System.Drawing.Point(160, 34);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(131, 24);
			this.checkBox7.TabIndex = 6;
			this.checkBox7.Text = "Simulator Beta";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(6, 116);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(165, 24);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Eureka Gamma (Landorus)";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(6, 95);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(148, 24);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Eureka Beta (Thundurus)";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(6, 55);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(148, 24);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Dowsing";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(6, 75);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(148, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Eureka Alpha (Tornadus)";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(6, 35);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(148, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Retrieval";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.Location = new System.Drawing.Point(160, 14);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(148, 24);
			this.checkBox6.TabIndex = 5;
			this.checkBox6.Text = "Simulator Alpha";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox12
			// 
			this.checkBox12.Location = new System.Drawing.Point(6, 14);
			this.checkBox12.Name = "checkBox12";
			this.checkBox12.Size = new System.Drawing.Size(148, 24);
			this.checkBox12.TabIndex = 11;
			this.checkBox12.Text = "Basic";
			this.checkBox12.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 250);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.totalorb_box);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.savegamename);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.Name = "MainForm";
			this.Text = "Pokemon Dream Radar Save Editor 0.1 by suloku\'15";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.totalorb_box)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orbs_box)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
