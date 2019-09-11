

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 工艺战舰船只设计参考
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private struct displacement {
			public double Volume;
			public double Belt_a;
			public double Belt_b;
			public double Deck_a;
			public double Deck_b;
			public double Battery;
			public double sum() {
				double tot = this.Volume + this.Belt_a + this.Belt_b + this.Deck_a + this.Deck_b + this.Battery;
				return tot;
			}
		};//排水量
		displacement dis;

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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			/*
			String temp_input = Text_Volume.Text.ToString();
			if (temp_input.Length == 0) return;
			List<List<int>> data = get_input(temp_input);
			if (data.Count > 1) return;
			dis.Volume = 0.2 * data[0][0];
			*/
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			int[] hp = { 0, 58496, 100000, 132192, 158496, 180735, 200000, 216992, 232192, 245943, 258496, 270043, 280735, 290689, 300000, 308746, 316992, 324792, 332192, 339231, 345943 };
			String temp_input = text_Smk.Text.ToString();
			if (temp_input.Length == 0) return;
			List<List<double>> data = get_input(temp_input);
			int smk_cnt = (int)data[0][0];
			if (smk_cnt > 20) smk_cnt = 20;
			label_Power.Text = hp[smk_cnt].ToString();
		}//烟数量 输入

		private void text_Smk_MouseLeave(object sender, EventArgs e)
		{
			
		}



		private double calc_mgz_cnt(List<Weapon> data) {
			//一根管的弹药消耗：M=0.0001*C^2
			double cnt=0.0;
			for (int i = 0; i < data.Count; i++) {
				if (data[i].caliber >= 500) cnt += data[i].cnt;
				else cnt += 0.0001 * data[i].cnt * Math.Pow(data[i].caliber, 2);
			}
			return cnt;
		}//计算弹药库

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
				label_Mgz.Text = mgz_cnt.ToString();
			}
			

			//string[] imput_arr = temp_input.Split(new char[2] { '\r', '\n' });


		}//输入输出弹药库

		private void text_ArmorBattery_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
