using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Cay_Nhi_Phan
{

	public partial class Form1 : Form
	{
		const int PICTUREBOX_WIDE = 1024;
		const int RET_OK = 0;
		const int EQUAL = 0;
		const int LEFT = -1;
		const int RIGHT = 1;
		public class_node Root;
		Bitmap bitmap;
		Graphics g;
		Bitmap ellip_blue = new Bitmap(Cay_Nhi_Phan.Properties.Resources.ellip_blue);
		List<int> way = new List<int>();
		public Form1()
		{
			InitializeComponent();
			bitmap = new Bitmap(pb_Main.Width, pb_Main.Height);
			g = Graphics.FromImage(bitmap);
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
		}
		public void VeCanh(PointF a, PointF b)
		{
			g.DrawLine(new Pen(Color.GreenYellow, 2), a.X+20, a.Y+39, b.X+20, b.Y);
			pb_Main.Image = bitmap;
		}
		public void DrawNode(class_node A)
		{
			g.DrawImage(Cay_Nhi_Phan.Properties.Resources.ellip_blue, A.vitri.X, A.vitri.Y);
			if (A.number < 10)
			{	
				g.DrawString(A.number.ToString(), new Font(FontFamily.GenericSerif, 15, FontStyle.Bold), new SolidBrush(Color.White), new PointF(A.vitri.X + 11, A.vitri.Y + 8f));
			}
			else
			{		
				g.DrawString(A.number.ToString(), new Font(FontFamily.GenericSerif, 15, FontStyle.Bold), new SolidBrush(Color.White), new PointF(A.vitri.X + 7, A.vitri.Y + 8f));
			}
			pb_Main.Image = bitmap;
		}
		public void DrawNodeRed(class_node A)
		{
			g.DrawImage(Cay_Nhi_Phan.Properties.Resources.ellip_red, A.vitri.X, A.vitri.Y);
			if (A.number < 10)
			{
				g.DrawString(A.number.ToString(), new Font(FontFamily.GenericSerif, 15, FontStyle.Bold), new SolidBrush(Color.White), new PointF(A.vitri.X + 11, A.vitri.Y + 8f));
			}
			else
			{	
				g.DrawString(A.number.ToString(), new Font(FontFamily.GenericSerif, 15, FontStyle.Bold), new SolidBrush(Color.White), new PointF(A.vitri.X + 7, A.vitri.Y + 8f));
			}
			pb_Main.Image = bitmap;
		}
		public void DrawSearch(class_node A)
		{
			g.DrawImage(Cay_Nhi_Phan.Properties.Resources.search, A.vitri.X, A.vitri.Y);
			g.DrawString(A.number.ToString(), new Font(FontFamily.GenericSerif, 15, FontStyle.Bold), new SolidBrush(Color.White), new PointF(A.vitri.X + 11, A.vitri.Y + 8f));
			pb_Main.Image = bitmap;
		}

		public void DiChuyen(ref class_node A, PointF B)
		{
			A.locationOld = A.vitri;
			int speed=1;
			if (ComboBox_Speed.Text == "")
			{
				speed = 1;
			}
			else
			{
				speed = Convert.ToInt32(ComboBox_Speed.Text);
			}
			float a = (B.Y - A.vitri.Y) / (B.X - A.vitri.X);
			float b = B.Y - a * B.X;
			float deltaX = B.X - A.locationOld.X;
			if (A.vitri.X - B.X < 0)
			{
				while (A.vitri.X - B.X < 0)//A.vitri.X - B.X < 0
				{
					g.Clear(Color.White);
					A.vitri.X+=1;
					A.vitri.Y = a * A.vitri.X + b;
					VeCay_special(Root, A);
					DrawNodeRed(A);
					Thread.Sleep(1);
					Application.DoEvents();
				}
			}
			else
			{
				while (A.vitri.X - B.X > 0)
				{
					g.Clear(Color.White);
					A.vitri.X-=1;
					A.vitri.Y = a * A.vitri.X + b;
					VeCay_special(Root, A);			
					DrawNodeRed(A);
					Thread.Sleep(1);
					Application.DoEvents();
				}
			}
		}
	
		private void txtInput_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && txtInput.Text.Length > 0)
			{
				int StatusInsert;
				try
				{
					int Temp = Convert.ToInt32(txtInput.Text);
					way.Clear();
					StatusInsert = InsertNode(ref Root, Temp);
				}
				catch
				{
					MessageBox.Show(" Gia tri nhap khong dung");
				}
				Xd_ViTriCu(ref Root);
				Xd_ViTriMoi(ref Root);
				for (int i = 0; i < 50; i++)
				{
					DiChuyenCay(ref Root);
					g.Clear(Color.White);
					VeCay_normal(Root);
					Thread.Sleep(2);
					Application.DoEvents();
				}
				g.Clear(Color.White);
				Xd_ViTri(ref Root);
				VeCay_normal(Root);
				txtInput.Clear();
			}		
		}

		// Di chuyển node xuống vị trí pLeft hoặc pRight
		public void MoveDown(ref class_node n, int heso)
		{
			if (heso == LEFT) //move_down_left
			{
				DiChuyen(ref n, nodeLR(n.vitri, LEFT));
			}
			if (heso == RIGHT) //move_down_right
			{
				DiChuyen(ref n, nodeLR(n.vitri, RIGHT));
			}
		}
		// Hàm nhận vào 1 node và trả về vị trí node pPeft hoặc pRight của node đó
		public PointF nodeLR(PointF l, int traiphai)
		{
			PointF kq = new PointF();
			int vt_y = ((Convert.ToInt32(l.Y - 20)) + 72) / 72;
			int partwidth = 1024 / (int)Math.Pow(2, (vt_y + 1));
			if (traiphai == -1)  //tra ve vi tri node con ben trai
			{
				kq.X = l.X - partwidth;
				kq.Y = l.Y + 72;
				return kq;
			}
			else  //tra ve vi tri node con ben phai 
			{
				kq.X = l.X + partwidth;
				kq.Y = l.Y + 72;
				return kq;
			}
		}
		// Vẽ cây bình thường
		public void VeCay_normal(class_node n)
		{
			if (Root != null)
				DrawNode(Root);
			if (n != null)
			{
				if (n.left != null)
				{
					
					if (n.left.number.ToString() == txtInput.Text)
					{
						DrawNodeRed(n.left);
					}
					else
					{
						DrawNode(n.left);
					}
					VeCanh(n.vitri, n.left.vitri);
				}
				if (n.right != null)
				{
					
					if (n.right.number.ToString() == txtInput.Text)
					{
						DrawNodeRed(n.right);
					}
					else
					{
						DrawNode(n.right);
					}
					VeCanh(n.vitri, n.right.vitri);
				}
				VeCay_normal(n.left);
				VeCay_normal(n.right);
			}
		}
		public void VeCay_special(class_node n,class_node a)
		{
			if (Root != null)
				DrawNode(Root);
			if (n != null)
			{
				if (n.left != null && n.left!=a)
				{				
					DrawNode(n.left);
					VeCanh(n.vitri, n.left.vitri);
				}
				if (n.right != null && n.right!=a)
				{
					DrawNode(n.right);
					VeCanh(n.vitri, n.right.vitri);
				}
				VeCay_special(n.left,a);
				VeCay_special(n.right,a);
			}
		}
		// Xác dịnh lại vị trí cho node để vẽ cây
		public void Xd_ViTri(ref class_node n)
		{
			PointF vt = new PointF();
			if (Root != null)
			{
				vt = new PointF(512, 20);
				Root.vitri = vt;
			}
			if (n != null)
			{
				if (n.left != null)
				{
					vt = nodeLR(n.vitri, -1);
					n.left.vitri = vt;
				}
				if (n.right != null)
				{
					vt = nodeLR(n.vitri, 1);
					n.right.vitri = vt;
				}
				Xd_ViTri(ref n.left);
				Xd_ViTri(ref n.right);
			}
		}
		public void Xd_ViTriCu(ref class_node n)
		{
			if (Root != null)
			{
				Root.locationOld= Root.vitri;
			}
			if (n != null)
			{
				if (n.left != null)
				{
					n.left.locationOld = n.left.vitri;
				}
				if (n.right != null)
				{
					n.right.locationOld = n.right.vitri;
				}
				Xd_ViTriCu(ref n.left);
				Xd_ViTriCu(ref n.right);
			}
		}

		public void Xd_ViTriMoi(ref class_node n)
		{
			PointF vt = new PointF();
			if (Root != null)
			{
				vt = new PointF(512, 20);
				Root.locationNew = vt;
			}
			if (n != null)
			{
				if (n.left != null)
				{
					vt = nodeLR(n.locationNew, -1);
					n.left.locationNew = vt;
				}
				if (n.right != null)
				{
					vt = nodeLR(n.locationNew, 1);
					n.right.locationNew = vt;
				}
				Xd_ViTriMoi(ref n.left);
				Xd_ViTriMoi(ref n.right);
			}
		}

		public void DiChuyenCay(ref class_node node)
		{
			if (node != null)
			{
				if (node.locationNew != node.locationOld)
				{
					DiChuyenSpecial(ref node, node.locationNew);		
				}
				DiChuyenCay(ref node.left);
				DiChuyenCay(ref node.right);
			}
		}

		public void DiChuyenSpecial(ref class_node A, PointF B)
		{
		
				float a = (B.Y - A.vitri.Y) / (B.X - A.vitri.X);
				float b = B.Y - a * B.X;
				float deltaX = Math.Abs(B.X - A.locationOld.X);
				if (A.vitri.X - B.X < 0)
				{
					if (A.vitri.X - B.X < 0)//A.vitri.X - B.X < 0
					{
						A.vitri.X += (deltaX/50) ;
						A.vitri.Y = a * A.vitri.X + b;
					}
				}
				else
				{
					if (A.vitri.X - B.X > 0)
					{
						A.vitri.X -= (deltaX/50) ;
						A.vitri.Y = a * A.vitri.X + b;
					}
				}
		}
		//
		void Rotate_Left_Left(ref class_node node)
		{
			class_node p;
			p = node.left;
			node.left = p.right;
			p.right = node;
			switch (p.canbang)
			{
				case LEFT:
					node.canbang = EQUAL;
					p.canbang = EQUAL;
					break;
				case EQUAL:
					p.canbang = RIGHT;
					node.canbang = LEFT;
					break;
			}
			node = p;
		}

		//cay con phai lech phai
		void Rotate_Right_Right(ref class_node node)
		{
			class_node p;
			p = node.right;
			node.right = p.left;
			p.left = node;
			switch (p.canbang)
			{
				case EQUAL:
					node.canbang = RIGHT;
					p.canbang = EQUAL;
					break;
				case RIGHT:
					p.canbang = EQUAL;
					node.canbang = EQUAL;
					break;
			}
			node = p;
		}

		//cay con phai lech trai
		void Rotate_Right_Left(ref class_node node)
		{
			class_node p1, p2;
			p1 = node.right;
			p2 = p1.left;
			node.right = p2.left;
			p1.left = p2.right;
			p2.left = node;
			p2.right = p1;
			switch (p2.canbang)
			{
				case LEFT:
					node.canbang = EQUAL;
					p1.canbang = RIGHT;
					break;
				case EQUAL:
					node.canbang = EQUAL;
					p1.canbang = EQUAL;
					break;
				case RIGHT:
					node.canbang = LEFT;
					p1.canbang = EQUAL;
					break;
			}
			p2.canbang = EQUAL;
			node = p2;
		}

		//cay con trai lech phai
		void Rotate_Left_Right(ref class_node node)
		{
			class_node p1, p2;
			p1 = node.left;
			p2 = p1.right;
			node.left = p2.right;
			p1.right = p2.left;
			p2.right = node;
			p2.left = p1;

			switch (p2.canbang)
			{
				case LEFT:
					p1.canbang = EQUAL;
					node.canbang = RIGHT;
					break;
				case EQUAL:
					node.canbang = EQUAL;
					p1.canbang = EQUAL;
					break;
				case RIGHT:
					node.canbang = EQUAL;
					p1.canbang = LEFT;
					break;
			}
			p2.canbang = EQUAL;
			node = p2;
		}

		//Can bang khi cay lech trai
		int BalanceLeft(ref class_node node)
		{
			class_node p;
			p = node.left;
			switch (p.canbang)
			{
				case LEFT:
					Rotate_Left_Left(ref node);
					return 2;
				case EQUAL:
					Rotate_Left_Left(ref node);
					return 1;
				case RIGHT:
					Rotate_Left_Right(ref node);
					return 2;
			}
			return 0;
		}

		//can bang cay lech phai
		int BalanceRight(ref class_node node)
		{
			class_node p;
			p = node.right;
			switch (p.canbang)
			{
				case RIGHT:
					Rotate_Right_Right(ref node);
					return 2;
				case EQUAL:
					Rotate_Right_Right(ref node);
					return 1;
				case LEFT:
					Rotate_Right_Left(ref node);
					return 2;
			}
			return 0;
		}
		int InsertNode(ref class_node node, int number)
		{

			int Res;
			if (node == null)
			{
				node = new class_node(number);
				if (way.Count != 0)
				{
					for (int i = 0; i < way.Count; i++)
					{
						MoveDown(ref node, way[i]);
					}
				}
			}
			else
			{
				if (node.number == number)
				{
					MessageBox.Show(" Da ton tai gia tri ");
					return 0;
				}
				if (number < node.number)
				{
					way.Add(LEFT);
					Res = InsertNode(ref node.left, number);
					if (Res < 2) return Res;

					//Res >= 2
					switch (node.canbang)
					{
						case RIGHT:
							node.canbang = EQUAL;
							return 1;
						case EQUAL:
							node.canbang = LEFT;
							return 2;
						case LEFT:
							BalanceLeft(ref node);
							return 1;
					}
				}
				else
				{
					way.Add(RIGHT);
					Res = InsertNode(ref node.right, number);
					if (Res < 2) return Res;

					//Res >= 2
					switch (node.canbang)
					{
						case LEFT:
							node.canbang = EQUAL;
							return 1;
						case EQUAL:
							node.canbang = RIGHT;
							return 2;
						case RIGHT:
							BalanceRight(ref node);
							return 1;
					}

				}
			}
			return 2;
		}
		private void pb_Main_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void Del_Tree_Button_Click(object sender, EventArgs e)
		{
			Root = null;
			g.Clear(Color.White);
			pb_Main.Image = bitmap;
			MessageBox.Show(" Da xoa thanh cong cay! ");			
		}
	}
}





