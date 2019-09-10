namespace 工艺战舰船只设计参考
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.Text_Volume = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.text_ArmorHeight = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.text_ArmorBelt = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.text_Smk = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.text_ArmorDeck = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.text_ArmorBattery = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.text_Weapon = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label_Weight = new System.Windows.Forms.Label();
			this.label_Mgz = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label_LoadDebuff = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label_Power = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(25, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "体积/m^3";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Text_Volume
			// 
			this.Text_Volume.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Text_Volume.Location = new System.Drawing.Point(250, 25);
			this.Text_Volume.Multiline = true;
			this.Text_Volume.Name = "Text_Volume";
			this.Text_Volume.Size = new System.Drawing.Size(200, 50);
			this.Text_Volume.TabIndex = 1;
			this.Text_Volume.Text = "0";
			this.Text_Volume.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.Location = new System.Drawing.Point(25, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 50);
			this.label2.TabIndex = 2;
			this.label2.Text = "装甲盒高宽/格";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// text_ArmorHeight
			// 
			this.text_ArmorHeight.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.text_ArmorHeight.Location = new System.Drawing.Point(250, 100);
			this.text_ArmorHeight.Multiline = true;
			this.text_ArmorHeight.Name = "text_ArmorHeight";
			this.text_ArmorHeight.Size = new System.Drawing.Size(200, 50);
			this.text_ArmorHeight.TabIndex = 3;
			this.text_ArmorHeight.Text = "0,0,0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(475, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(327, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "ah,bh,d:主装装甲板高度,装甲块高度,甲板宽度\r\n作为下述默认数据，使用英文逗号分隔";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(475, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(262, 30);
			this.label4.TabIndex = 5;
			this.label4.Text = "你预期的体积，<=300,0000\r\n与下述主装甲带差别过大时会闪烁提示";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(25, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(200, 50);
			this.label5.TabIndex = 6;
			this.label5.Text = "主装长厚/格";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// text_ArmorBelt
			// 
			this.text_ArmorBelt.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.text_ArmorBelt.Location = new System.Drawing.Point(250, 175);
			this.text_ArmorBelt.Multiline = true;
			this.text_ArmorBelt.Name = "text_ArmorBelt";
			this.text_ArmorBelt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.text_ArmorBelt.Size = new System.Drawing.Size(200, 150);
			this.text_ArmorBelt.TabIndex = 7;
			this.text_ArmorBelt.Text = "0,0,0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(475, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(343, 150);
			this.label6.TabIndex = 8;
			this.label6.Text = resources.GetString("label6.Text");
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label7.Location = new System.Drawing.Point(25, 600);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(200, 50);
			this.label7.TabIndex = 9;
			this.label7.Text = "英烟数量/个";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// text_Smk
			// 
			this.text_Smk.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.text_Smk.Location = new System.Drawing.Point(250, 600);
			this.text_Smk.Multiline = true;
			this.text_Smk.Name = "text_Smk";
			this.text_Smk.Size = new System.Drawing.Size(200, 50);
			this.text_Smk.TabIndex = 10;
			this.text_Smk.Text = "0";
			this.text_Smk.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			this.text_Smk.MouseLeave += new System.EventHandler(this.text_Smk_MouseLeave);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(25, 350);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(200, 50);
			this.label8.TabIndex = 12;
			this.label8.Text = "甲板宽厚/格";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// text_ArmorDeck
			// 
			this.text_ArmorDeck.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.text_ArmorDeck.Location = new System.Drawing.Point(250, 350);
			this.text_ArmorDeck.Multiline = true;
			this.text_ArmorDeck.Name = "text_ArmorDeck";
			this.text_ArmorDeck.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.text_ArmorDeck.Size = new System.Drawing.Size(200, 150);
			this.text_ArmorDeck.TabIndex = 13;
			this.text_ArmorDeck.Text = "0,0,0\r\n\r\n\r\n";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(475, 350);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(345, 60);
			this.label9.TabIndex = 14;
			this.label9.Text = "W(,aT,bT)：宽(,板厚,块厚)\r\n每一行主装长厚对应一行甲板宽厚,请确保行数相等\r\nW==0时忽略后两者，aT,bT不填默认0\r\nｅ.g.  0 | 0," +
    "300, | 15,,200 | 15,200,200";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.White;
			this.label10.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label10.Location = new System.Drawing.Point(25, 525);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(200, 50);
			this.label10.TabIndex = 15;
			this.label10.Text = "主炮塔/个";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// text_ArmorBattery
			// 
			this.text_ArmorBattery.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.text_ArmorBattery.Location = new System.Drawing.Point(250, 525);
			this.text_ArmorBattery.Multiline = true;
			this.text_ArmorBattery.Name = "text_ArmorBattery";
			this.text_ArmorBattery.Size = new System.Drawing.Size(200, 50);
			this.text_ArmorBattery.TabIndex = 16;
			this.text_ArmorBattery.Text = "0,0,0,0";
			this.text_ArmorBattery.TextChanged += new System.EventHandler(this.text_ArmorBattery_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(475, 525);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(318, 45);
			this.label11.TabIndex = 17;
			this.label11.Text = "N,H,aT1,aT2(,bT1,bT2)\r\n数量,装甲高,侧板厚,顶板厚(,侧块厚,顶块厚)\r\n仅提供每个主炮拆分布置装甲的计算";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label12.Location = new System.Drawing.Point(25, 675);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(200, 50);
			this.label12.TabIndex = 18;
			this.label12.Text = "武器布置";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// text_Weapon
			// 
			this.text_Weapon.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.text_Weapon.Location = new System.Drawing.Point(250, 675);
			this.text_Weapon.Multiline = true;
			this.text_Weapon.Name = "text_Weapon";
			this.text_Weapon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.text_Weapon.Size = new System.Drawing.Size(200, 150);
			this.text_Weapon.TabIndex = 20;
			this.text_Weapon.Text = "0,0";
			this.text_Weapon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(450, 675);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(0, 15);
			this.label13.TabIndex = 21;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(475, 675);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(262, 60);
			this.label14.TabIndex = 22;
			this.label14.Text = "N,C : 数量(管子数量),口径(mm)\r\n鱼雷也可输入口径，会自动区分为鱼雷\r\n***防空炮不计算***\r\ne.g.  12,406 | 12,533";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.White;
			this.label15.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label15.Location = new System.Drawing.Point(900, 25);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(200, 50);
			this.label15.TabIndex = 23;
			this.label15.Text = "吨位";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Weight
			// 
			this.label_Weight.BackColor = System.Drawing.Color.White;
			this.label_Weight.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_Weight.Location = new System.Drawing.Point(900, 75);
			this.label_Weight.Name = "label_Weight";
			this.label_Weight.Size = new System.Drawing.Size(200, 50);
			this.label_Weight.TabIndex = 24;
			this.label_Weight.Text = "0";
			this.label_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_Mgz
			// 
			this.label_Mgz.BackColor = System.Drawing.Color.White;
			this.label_Mgz.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_Mgz.Location = new System.Drawing.Point(900, 250);
			this.label_Mgz.Name = "label_Mgz";
			this.label_Mgz.Size = new System.Drawing.Size(200, 50);
			this.label_Mgz.TabIndex = 26;
			this.label_Mgz.Text = "0";
			this.label_Mgz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.White;
			this.label17.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label17.Location = new System.Drawing.Point(900, 200);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(200, 50);
			this.label17.TabIndex = 25;
			this.label17.Text = "弹药库";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(900, 125);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(172, 15);
			this.label16.TabIndex = 27;
			this.label16.Text = "建议吨位约为体积的一半";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(900, 300);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(157, 15);
			this.label18.TabIndex = 28;
			this.label18.Text = "注意预留防空炮弹药库";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(900, 450);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(175, 30);
			this.label19.TabIndex = 31;
			this.label19.Text = "有一定debuff时总投射量\r\n可能也会比少一座炮高";
			// 
			// label_LoadDebuff
			// 
			this.label_LoadDebuff.BackColor = System.Drawing.Color.White;
			this.label_LoadDebuff.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_LoadDebuff.Location = new System.Drawing.Point(900, 400);
			this.label_LoadDebuff.Name = "label_LoadDebuff";
			this.label_LoadDebuff.Size = new System.Drawing.Size(200, 50);
			this.label_LoadDebuff.TabIndex = 30;
			this.label_LoadDebuff.Text = "0";
			this.label_LoadDebuff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.White;
			this.label21.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label21.Location = new System.Drawing.Point(900, 350);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(200, 50);
			this.label21.TabIndex = 29;
			this.label21.Text = "装填debuff";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(898, 600);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(157, 30);
			this.label20.TabIndex = 34;
			this.label20.Text = "船体动力不计算在内，\r\n因此实际功率会高";
			// 
			// label_Power
			// 
			this.label_Power.BackColor = System.Drawing.Color.White;
			this.label_Power.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label_Power.Location = new System.Drawing.Point(898, 550);
			this.label_Power.Name = "label_Power";
			this.label_Power.Size = new System.Drawing.Size(200, 50);
			this.label_Power.TabIndex = 33;
			this.label_Power.Text = "0";
			this.label_Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.White;
			this.label23.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label23.Location = new System.Drawing.Point(898, 500);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(200, 50);
			this.label23.TabIndex = 32;
			this.label23.Text = "烟提供的马力";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 853);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label_Power);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label_LoadDebuff);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label_Mgz);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label_Weight);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.text_Weapon);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.text_ArmorBattery);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.text_ArmorDeck);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.text_Smk);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.text_ArmorBelt);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.text_ArmorHeight);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Text_Volume);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "工艺战舰船只设计参考  Process by MioSleet";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Text_Volume;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox text_ArmorHeight;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox text_ArmorBelt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox text_Smk;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox text_ArmorDeck;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox text_ArmorBattery;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox text_Weapon;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label_Weight;
		private System.Windows.Forms.Label label_Mgz;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label_LoadDebuff;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label_Power;
		private System.Windows.Forms.Label label23;
	}
}

