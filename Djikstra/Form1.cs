using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Djikstra.global;
using Djikstra.util;

namespace Djikstra
{
	public partial class Form1 : Form
	{
		Graphics g;
		private int count = 0;
		Dictionary<int, Point> mapLocation = new Dictionary<int, Point>();
		int[,] a = new int[GlobalObject.maxScore, GlobalObject.maxScore];
		private Stack<int> stDirection = new Stack<int>();
		private bool isLock = false;
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			g = pictureBox1.CreateGraphics();
		}
		private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
			if (!isLock)
			{
				count++;

				MouseEventArgs me = (MouseEventArgs)e;
				SolidBrush db = new SolidBrush(Color.White);
				SolidBrush db2 = new SolidBrush(Color.Red);
				Font f = new Font("time new roman", 10, FontStyle.Bold);

				g.FillEllipse(db, me.Location.X, me.Location.Y, 25, 25);
				g.DrawString(count.ToString(), f, db2, me.Location.X + 4, me.Location.Y + 4);
				mapLocation.Add(count, new Point(me.X, me.Y));

				cbStart.Items.Add(count);
				cbEnd.Items.Add(count);

				if (count >= 2)
				{
					button2.Enabled = true;
					int maxLine = Utils.getMaxLine(count);
					txtMaxLine.Text = maxLine.ToString();
				}
			}

			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.button2.Enabled = this.button3.Enabled =  false;
			this.pictureBox1.Invalidate();
			this.pictureBox1.Refresh();
			GlobalObject.setLines = new HashSet<string>();
			GlobalObject.mapDistance = new Dictionary<string, int>();
			mapLocation = new Dictionary<int, Point>();
			count = 0;
			isLock = false;

			button2.Enabled = true;
			txtLine.Enabled = true;
			txtMaxLine.Text = "0";
			cbStart.Items.Clear();
			cbStart.ResetText();
			//cbStart.Refresh();
			cbEnd.Items.Clear();
			cbEnd.ResetText();
			//cbEnd.Refresh();
			richTextBox1.Clear();
			txtCost.Clear();
			txtDirection.Clear();
		}

		private void initArray()
		{
			for (int i = 1; i <= count; i++)
			{
				for (int j = 1; j <= count; j++)
				{
					if (i == j) a[i, j] = 0;
					else a[i, j] = GlobalObject.MAX_VALUE;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			int lines = int.Parse(txtLine.Text);
			int maxLine = Utils.getMaxLine(count);
			if (lines > maxLine)
			{
				MessageBox.Show("Cần nhập số đường <= " + maxLine);
			}
			else
			{
				button2.Enabled = false;
				txtLine.Enabled = false;
				button3.Enabled = true;
				isLock = true;
				initArray();


				Random rd2 = new Random();
				int start, end, d;
				// Cac diem dau va cuoi khong trung nhau, canh k dc lap lai
				int t = 0;
				string key = "";
				string keyReverse;
				//pictureBox1.Refresh();

				SolidBrush db2 = new SolidBrush(Color.Black);
				Font f = new Font("time new roman", 10, FontStyle.Bold);

				while (true)
				{
					if (t == lines) break;
					start = rd2.Next(1, count + 1); // Ham random(x,y) chỉ chay tu x-> (y-1) nên cộng thêm 1 đơn vị 
					end = rd2.Next(1, count + 1);

					if (start == end) continue;

					key = start + "@" + end;
					keyReverse = end + "@" + start;
					if (!GlobalObject.setLines.Contains(key) && !GlobalObject.setLines.Contains(keyReverse))
					{
						GlobalObject.setLines.Add(key);
						GlobalObject.setLines.Add(keyReverse);

						d = rd2.Next(5, 200);
						GlobalObject.mapDistance.Add(key, d);
						GlobalObject.mapDistance.Add(keyReverse, d);

						// update array
						a[start, end] = d;
						a[end, start] = d;
						// draw line
						Point startPoint = mapLocation.Single(x => x.Key == start).Value;
						Point endPoint = mapLocation.Single(x => x.Key == end).Value;

						drawLine(startPoint, start, endPoint, end);
						g.DrawString(d.ToString(), f, db2, (startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);
						t++;
					}
				}
				genMesMatrix();
			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			txtCost.Clear();
			txtDirection.Clear();
			if (count >= 2)
			{
				this.button3.Enabled = true;
			}
			this.pictureBox1.Invalidate();
			this.pictureBox1.Refresh();

			int start, end, d;
			SolidBrush db2 = new SolidBrush(Color.Black);
			Font f = new Font("time new roman", 10, FontStyle.Bold);
			foreach (string str in GlobalObject.setLines)
			{
				start = int.Parse(str.Split('@')[0]);
				end = int.Parse(str.Split('@')[1]);
				Point startPoint = mapLocation.Single(x => x.Key == start).Value;
				Point endPoint = mapLocation.Single(x => x.Key == end).Value;
				d = GlobalObject.mapDistance.Single(x => x.Key == str).Value;
				drawLine(startPoint, start, endPoint, end);
				g.DrawString(d.ToString(), f, db2, (startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);
			}
		}


		private int oldStart = -1, oldEnd = -1;

		private void cbEnd_SelectedIndexChanged(object sender, EventArgs e)
		{
			int value = int.Parse(cbEnd.SelectedItem.ToString());
			Point point = mapLocation.First(x => x.Key == value).Value;
			drawCircleEnd(point, value);
			if (oldEnd != -1)
			{
				Point end = mapLocation.First(x => x.Key == oldEnd).Value;
				drawCircle(end, oldStart);
			}
			oldEnd = value;
		}



		private void cbStart_SelectedIndexChanged(object sender, EventArgs e)
		{
			int value = int.Parse(cbStart.SelectedItem.ToString());
			Point point = mapLocation.First(x => x.Key == value).Value;
			drawCircleStart(point, value);
			if (oldStart != -1)
			{
				Point start = mapLocation.First(x => x.Key == oldStart).Value;
				drawCircle(start, oldStart);
			}
			oldStart = value;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
			int start = -1, end = -1;
			try
			{
				start = int.Parse(cbStart.SelectedItem.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Chọn điểm bắt đầu trước");
			}
			try
			{
				end = int.Parse(cbEnd.SelectedItem.ToString());
			} catch(Exception ex)
			{
				MessageBox.Show("Chọn điểm kết thúc trước");
			}
			
			if(start != -1 && end != -1)
			{
				this.button3.Enabled = false;

				djikstra(start, count + 1, end);

				string mesDirection = start.ToString();

				while (stDirection.Count > 0)
				{
					end = stDirection.Pop();
					mesDirection = mesDirection + "-->" + end;

					Point startPoint = mapLocation.Single(x => x.Key == start).Value;
					Point endPoint = mapLocation.Single(x => (x.Key == end)).Value;
					drawLineDirection(startPoint, start, endPoint, end);
					start = end;
				}
				txtDirection.Text = mesDirection;
			}
		}
		//int [,] test = new int [9,9]()
		private void djikstra(int start, int n, int end)
		{
			int[] ddnn = new int[n];
			int i, k = start, now, MIN;
			bool[] daXet = new bool[n];
			int[] dist = new int[n];
			for (i = 1; i < n; i++)
			{
				daXet[i] = false;
				dist[i] = GlobalObject.MAX_VALUE;
			}
			daXet[start] = true;
			dist[start] = 0;
			now = start;
			int h = 1;
			while (h < n - 1)
			{
				MIN = GlobalObject.MAX_VALUE;
				for (i = 1; i < n; i++)
				{
					if (!daXet[i])
					{
						if (dist[now] + a[now, i] < dist[i])
						{
							dist[i] = dist[now] + a[now, i];
							ddnn[i] = now;
						}
						if (dist[i] < MIN)
						{
							MIN = dist[i];
							k = i;
						}
					}

				}
				if (k == end)
				{
					saveDirection(start, k, ddnn);
					txtCost.Text = dist[k].ToString();
					break;
				}

				//cout << "\nTrong so: " << dist[k];
				now = k;
				daXet[now] = true;
				h++;
			}
		}



		private void saveDirection(int s, int k, int[] ddnn)
		{
			int i;
			i = k;
			while (i != s)
			{
				stDirection.Push(i);
				i = ddnn[i];
			}
		}

		private void drawLine(Point start, int s_num, Point end, int e_num)
		{
			Pen pen = new Pen(Color.Gray, 2);
			g.DrawLine(pen, start.X + 5, start.Y + 5, end.X + 5, end.Y + 5);
			drawCircle(start, s_num);
			drawCircle(end, e_num);
		}

		private void drawLineDirection(Point start, int s_num, Point end, int e_num)
		{
			SolidBrush db2 = new SolidBrush(Color.DarkRed);
			Font f = new Font("time new roman", 10, FontStyle.Bold);
			AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
			Pen pen = new Pen(Color.Blue, 2);
			pen.CustomEndCap = bigArrow;
			g.DrawLine(pen, start.X + 5, start.Y + 5, end.X + 5, end.Y + 5);
			drawCircle(start, s_num);
			drawCircle(end, e_num);
			string key = s_num + "@" + e_num;
			int d = GlobalObject.mapDistance.Single(x => x.Key == key).Value;
			g.DrawString(d.ToString(), f, db2, (start.X + end.X) / 2, (start.Y + end.Y) / 2);

		}

		private void drawCircle(Point point, int num)
		{
			SolidBrush db = new SolidBrush(Color.White);
			SolidBrush db2 = new SolidBrush(Color.Red);
			Font f = new Font("time new roman", 10, FontStyle.Bold);
			g.FillEllipse(db, point.X, point.Y, 25, 25);
			g.DrawString(num.ToString(), f, db2, point.X + 4, point.Y + 4);
		}

		private void drawCircleStart(Point point, int num)
		{
			SolidBrush db = new SolidBrush(Color.LightGreen);
			SolidBrush db2 = new SolidBrush(Color.Red);
			Font f = new Font("time new roman", 10, FontStyle.Bold);
			g.FillEllipse(db, point.X, point.Y, 25, 25);
			g.DrawString(num.ToString(), f, db2, point.X + 4, point.Y + 4);
		}



		private void drawCircleEnd(Point point, int num)
		{
			SolidBrush db = new SolidBrush(Color.LightSkyBlue);
			SolidBrush db2 = new SolidBrush(Color.Red);
			Font f = new Font("time new roman", 10, FontStyle.Bold);
			g.FillEllipse(db, point.X, point.Y, 25, 25);
			g.DrawString(num.ToString(), f, db2, point.X + 4, point.Y + 4);
		}

		
		private void genMesMatrix()
		{
			string mes = "";
			for (int i = 1; i <= count; i++)
			{
				for (int j = 1; j <= count; j++)
				{
					if (a[i, j] == GlobalObject.MAX_VALUE)
					{
						mes = mes + "0" + " ";
					}
					else
					{
						mes = mes + a[i, j] + " ";
					}
				}
				mes = mes + "\n";
			}

			richTextBox1.Text = mes;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

	
	}
}
