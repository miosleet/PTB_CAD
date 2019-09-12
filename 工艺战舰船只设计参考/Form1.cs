

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///1、注意get_input已经改为返回一个List<List<double>>
///2、输入框注意判断输入为空时直接return
///3、dis是结构体displacement下的变量，代表整船的吨位。更改每一个文本框的时候请更改dis结构体内的变量的值。
///4、进行了更爱吨位操作后记得加上 label_Weight.Text = dis.sum().ToString(); 以显示吨位
/// </summary>


namespace 工艺战舰船只设计参考
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		int aH = 0, bH = 0,eH=0;//装甲高度
		List<double> Armor_belt ,Armor_deck;//装甲带长宽(米)
		int belt_cnt;//装甲带段数

		private struct displacement {
			public double Volume;//船体
			public double Belt;//主装
			public double Deck;//甲板
			public double Battery;//主炮装甲
			public double Smk;//烟
			public double sum() {
				double tot = this.Volume + this.Belt + this.Deck + this.Battery + this.Smk;
				return tot;
			}
		};//吨位
		displacement dis;//吨位

		struct Weapon
		{
			public int cnt;
			public double caliber;
		}//武器

		private List<List<double>> get_input(String data) {//输入的string转int[]
			List<List<double>> ret_data = new List<List<double>>();
			if (data.Length == 0)return ret_data;

			try
			{
				String[] imput_arr = data.Split(new char[2] { '\r', '\n' });
				for (int i = 0; i < imput_arr.Length; i++)
				{
					if (imput_arr[i].Length == 0) continue;
					List<double> now_data = new List<double>();
					String[] record = imput_arr[i].Split(new char[1] { ',' });
					for (int j = 0; j < record.Length; j++)
					{
						if (record[j].Length == 0){
							now_data.Add(0.0);
							continue;
						}
						now_data.Add(double.Parse(record[j]));
					}
					ret_data.Add(now_data);
				}
			}
			catch (FormatException) {
				ret_data = new List<List<double>>();
				MessageBox.Show("输入格式错误");
			}

			return ret_data;
		}//输入的string转int[]
		
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private bool is_alert = true;
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			String temp_input = Text_Volume.Text.ToString();
			if (temp_input.Length == 0) return;
			List<List<double>> data = get_input(temp_input);
			if (data.Count > 1||data.Count==0) return;
			double Volume = data[0][0];
			dis.Volume = 0.2 * Volume;
			if (is_alert&& Volume > 300000)if (MessageBox.Show("体积过大，不应超过300000\n保留提示点确定，关闭提示点取消", "警告", MessageBoxButtons.YesNo) == DialogResult.No)is_alert = false;
			if(Volume<300000) is_alert = true;
			label_Weight.Text = dis.sum().ToString();
		}//更改体积

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			int[] hp = { 0, 58496, 100000, 132192, 158496, 180735, 200000, 216992, 232192, 245943, 258496, 270043, 280735, 290689, 300000, 308746, 316992, 324792, 332192, 339231, 345943 };
			String temp_input = text_Smk.Text.ToString();
			if (temp_input.Length == 0) return;
			List<List<double>> data = get_input(temp_input);
			int smk_cnt = (int)data[0][0];
			if (smk_cnt > 20) smk_cnt = 20;
			label_Power.Text = hp[smk_cnt].ToString();
			dis.Smk = 1215.0 * smk_cnt;
			label_Weight.Text = dis.sum().ToString();
		}//更改烟数量

		private double calc_mgz_cnt(List<Weapon> data) {
			//一根管的弹药消耗：M=0.0001*C^2
			double cnt=0.0;
			for (int i = 0; i < data.Count; i++) {
				if (data[i].caliber >= 500) cnt += data[i].cnt;
				else cnt += 0.0001 * data[i].cnt * Math.Pow(data[i].caliber, 2);
			}
			return cnt;
		}//计算弹药库

		private double calc_mgz_max() {
			double max_mgz=0.0;
			double tot_dis = dis.sum();
			max_mgz = 66.772 * Math.Log(tot_dis, Math.E) - 501.6;
			return max_mgz;
		}//计算最大弹药库

		private double calc_mgz_debuff(double cnt,double max) {
			double mgz_debuff = 0;
			if (cnt > max) mgz_debuff = 207.35 * (cnt / max - 1);
			return mgz_debuff;
		}//计算debuff

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			string temp_input = text_Weapon.Text.ToString();
			if (temp_input.Length > 0) {
				List<List<double>> data = get_input(temp_input);
				List<Weapon> data_arr = new List<Weapon>();
				for (int i = 0; i < data.Count; i++) {
					if (data[i].Count % 2 == 1) return;
					Weapon temp = new Weapon();
					temp.cnt = (int)data[i][0];temp.caliber = data[i][1];
					data_arr.Add(temp);
				}
				double mgz_cnt = calc_mgz_cnt(data_arr);
				double mgz_max = calc_mgz_max();
				label_Mgz.Text = (Math.Ceiling(mgz_cnt)).ToString()+'/'+(Math.Floor(mgz_max)).ToString();
				label_LoadDebuff.Text = (calc_mgz_debuff(mgz_cnt, mgz_max)).ToString("#0.000")+'%';
			}
			


		}//输入输出弹药库

		private void text_ArmorBattery_TextChanged(object sender, EventArgs e)
		{
			double now_weight = 0.0;
			String temp_input = text_ArmorBattery.Text.ToString();
			if (temp_input.Length == 0) {
				dis.Battery = 0;
				label_Weight.Text = dis.sum().ToString();
				return;
			}
			List<List<double>> data = get_input(temp_input);
			List<double> now_data = data[0];
			if (now_data.Count != 6 && now_data.Count != 9) return;
			//N,H,aT1,aT2(,bT1,bT2,bM)数量,装甲高,侧板厚,顶板厚(, 侧块厚, 顶块厚, 块轻重)
			double N = now_data[0], L = now_data[1],W = now_data[2],H = now_data[3], aT1 = now_data[4], aT2 = now_data[5], bT1=0, bT2=0, bM=0;
			if (now_data.Count == 9) {
				bT1 = now_data[6]; bT2 = now_data[7]; bM = now_data[8];
			}
			now_weight += N * ((L + W) * H * 2 * 9 * aT1 * 0.001 * 7.81);//侧板
			now_weight += N * ((L + W - 2) * H * 2 * 27 * bT1 * 0.001 * (bM == 0 ? 10 : 6));//侧块
			now_weight += N * (L * W * 9 * aT2 * 0.001 * 7.81);//顶板
			now_weight += N * (L * W * 27 * bT2 * 0.001 * (bM == 0 ? 10 : 6));//顶块
			//now_weight += N* (/*侧面*/(2 *((L+W)*H *(27 * bT1 * 0.001 * (bM == 0 ? 10 : 6)+9*aT1*0.001*7.81)))/*侧面*/+/*上面*/(L * W * (27 * bT1 * 0.001 * (bM == 0 ? 10 : 6) + 9 * aT1 * 0.001 * 7.81))/*上面*/);
			dis.Battery = now_weight;
			label_Weight.Text = dis.sum().ToString();
		}//炮塔座圈

		private void text_ArmorBelt_TextChanged(object sender, EventArgs e)
		{
			Armor_belt = new List<double>();
			double now_weight = 0.0;
			//重块比重10，轻块比重6，装甲板比重7.81
			//L,aT,bT(,aH,bH,bM):长度,板厚度,块厚度(, 板高度, 块高度, 块轻重)
			String temp_input = text_ArmorBelt.Text.ToString();
			if (temp_input.Length == 0) return;
			List<List<double>> data = get_input(temp_input);
			belt_cnt = data.Count-1;
			for (int i = 0; i < data.Count; i++) {
				List<double> now_data = data[i];
				if(now_data.Count!=3&&now_data.Count!=6)return;
				double L = now_data[0], aT = now_data[1], bT = now_data[2], now_aH = aH, now_bH = bH, bM = 0;
				if (now_data.Count == 6) { now_aH = now_data[3]; now_bH = now_data[4]; bM = now_data[5]; }
				now_weight += 2 * (9 * L * now_aH * aT * 0.001 * 7.81 + L * now_bH * 27 * bT * 0.001 * (bM == 0 ? 10 : 6));
				if (i!=0)Armor_belt.Add(L);
			}



			dis.Belt = now_weight;
			label_Weight.Text = dis.sum().ToString();

		}//主装

		private void text_ArmorDeck_TextChanged(object sender, EventArgs e)
		{
			Armor_deck = new List<double>();
			double now_weight = 0.0;
			String temp_input = text_ArmorDeck.Text.ToString();
			if (temp_input.Length == 0) return;
			List<List<double>> data = get_input(temp_input);
			if (data.Count != belt_cnt) return;
			for (int i = 0; i < data.Count; i++) {
				List<double> now_data = data[i];
				Armor_deck.Add(now_data[0]);
				if (now_data[0] == 0) continue;
				else if (now_data.Count != 4) return;
				double aT = now_data[1], bT = now_data[2],bM=now_data[3];
				double S = Armor_belt[i] * Armor_deck[i];
				now_weight+= 9 * S * aT * 0.001 * 7.81 + S * 27 * bT * 0.001 * (bM == 0 ? 10 : 6);
			}
			dis.Deck = now_weight;
			label_Weight.Text = dis.sum().ToString();
		}//装甲甲板

		private void text_ArmorHeight_TextChanged(object sender, EventArgs e)
		{
			String temp_input = text_ArmorHeight.Text.ToString();
			if (temp_input.Length == 0) return;
			List<List<double>> data = get_input(temp_input);
			if (data[0].Count != 3 || data.Count != 1) return;
			aH = (int)data[0][0]; bH = (int)data[0][1];eH=(int)data[0][2] ;
		}//更改主装高度
	}
}
