using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Drawing.Drawing2D;
using System.Collections;
using System.IO;

namespace TEST_C01
{
    public partial class canvas01 : Form
    {
        Color dColor = new Color(); //색_선
        Color fColor = new Color(); //색_채우기
        int flag_drawtype = 0; ///작업설정
        Point sPoint, ePoint; //시작점,끝점
        Pen pen = new Pen(Color.Transparent);
        SolidBrush sBrush = new SolidBrush(Color.Transparent);
        Color temp_color = new Color();
        bool isDrawing;
        bool check_trans = false;
        Bitmap draw_area = new Bitmap(800, 600);

        public const int TEMP_NUM = 20;
        public const float ZOOM_RATE = 0.7f;

        int[] temp_sx = new int[TEMP_NUM];
        int[] temp_sy = new int[TEMP_NUM];
        int[] temp_ex = new int[TEMP_NUM];
        int[] temp_ey = new int[TEMP_NUM];
        int[] temp_drawtype = new int[TEMP_NUM];
        Pen[] temp_pen = new Pen[TEMP_NUM]; // ------------ 여기
        Brush[] temp_brush = new Brush[TEMP_NUM];
        Color[] temp_bColor = new Color[TEMP_NUM]; // ------------ 여기
        int temp_count = 0;

        int count = 0;
        ArrayList current_points = new ArrayList();

        public canvas01()
        {
            InitializeComponent();
            dColor = Color.Black;
            fColor = Color.White;
        }
        public void temp_Canvas(PictureBox pb, MouseEventArgs e)
        {
            Graphics paint_graphics = Graphics.FromImage(draw_area);
            paint_graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pb.Image = draw_area;
            draw_area.Save(@"temp.bmp"); ///오됨.
        }
        public void save_Canvas(PictureBox pb, EventArgs e)
        {
            saveFileDialog1.Title = "이미지파일저장";
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save an Image File **";

            Stream myStream;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void dColor_btn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            dColor_selected.BackColor = colorDialog1.Color;
            dColor = colorDialog1.Color;
        }
        private void fColor_selected_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            fColor_selected.BackColor = colorDialog2.Color;
            fColor = colorDialog2.Color;
            if (check_trans == true)
            {
                temp_color = fColor;
                fColor = Color.Transparent;
            }
        }

        private void DrawFree_Click(object sender, EventArgs e)
        {
            flag_drawtype = 0;
        }
        private void Rectangle_btn_Click(object sender, EventArgs e)
        {
            flag_drawtype = 1;
        }
        private void Ellipse_btn_Click(object sender, EventArgs e)
        {
            flag_drawtype = 2;
        }
        private void Line_Click(object sender, EventArgs e)
        {
            flag_drawtype = 3;
        }

        private void picture_window_MouseDown(object sender, MouseEventArgs e)
        {
            if (flag_drawtype == 0)
            {
                isDrawing = true;
                current_points.Add(new Point(e.X, e.Y));
            } //자유곡선이면true
            sPoint.X = e.X;
            sPoint.Y = e.Y;

            pen.Color = dColor;
            sBrush.Color = fColor;
        }
        private void picture_window_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphics = Graphics.FromImage(draw_area);
            //Graphics graphics = picture_window.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (isDrawing == true)
            {
                graphics.DrawLine(pen, (Point)current_points[count], e.Location);
                current_points.Add(e.Location);
                count++;
            }
            toolStripStatusLabel1.Text = "현재위치: " + e.X + ", " + e.Y;
        }
        private void picture_window_MouseUp(object sender, MouseEventArgs e)
        {
            ePoint.X = e.X;
            ePoint.Y = e.Y;

            Point point = new Point();
            int move_x, move_y;

            /*
            if (sPoint.X <= ePoint.X)
            {
                point.X = sPoint.X;
                temp_sx[temp_count] = sPoint.X;
                temp_ex[temp_count] = ePoint.X;
            }
            else
            {
                point.X = ePoint.X;
                temp_sx[temp_count] = ePoint.X;
                temp_ex[temp_count] = sPoint.X;
            }
            if (sPoint.Y <= ePoint.Y)
            {
                point.Y = sPoint.Y;
                temp_sy[temp_count] = sPoint.Y;
                temp_ey[temp_count] = ePoint.Y;
            }
            else
            {
                point.Y = ePoint.Y;
                temp_sy[temp_count] = ePoint.Y;
                temp_ey[temp_count] = sPoint.Y;
            }*/

            if (sPoint.X <= ePoint.X)
            {
                point.X = sPoint.X;
            }
            else
            {
                point.X = ePoint.X;
            }
            if (sPoint.Y <= ePoint.Y)
            {
                point.Y = sPoint.Y;
            }
            else
            {
                point.Y = ePoint.Y;
            }
            if (flag_drawtype >= 1 && flag_drawtype <=3)
            {
                temp_sx[temp_count] = sPoint.X;
                temp_sy[temp_count] = sPoint.Y;
                temp_ex[temp_count] = ePoint.X;
                temp_ey[temp_count] = ePoint.Y;
                temp_pen[temp_count] = pen;
                temp_brush[temp_count] = sBrush;
            }
            
            temp_drawtype[temp_count] = flag_drawtype;
            move_x = ePoint.X - sPoint.X; //이동
            move_y = ePoint.Y - sPoint.Y; //이동

            Rectangle guide_rect = new Rectangle(point.X, point.Y, Math.Abs(move_x), Math.Abs(move_y));
            Graphics graphics = Graphics.FromImage(draw_area);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            switch (flag_drawtype)
            {
                case 0:
                    current_points.Clear();
                    count = 0;
                    isDrawing = false;
                    break;
                case 1:
                    graphics.DrawRectangle(pen, guide_rect);
                    graphics.FillRectangle(sBrush, guide_rect);
                    //temp_drawtype[temp_count] = 1;
                    temp_count++;
                    break;
                case 2:
                    graphics.DrawEllipse(pen, guide_rect);
                    graphics.FillEllipse(sBrush, guide_rect);
                    temp_count++;
                    break;
                case 3:
                    //pen.DashCap = DashCap.Round; //라운딩
                    graphics.DrawLine(pen, sPoint, ePoint);
                    pen.DashCap = DashCap.Flat; //원래대로
                    temp_count++;
                    break;
                case 4: // ------------ 여기
                    graphics.Clear(Color.White);
                    for (int i = 0; i < TEMP_NUM; i++)
                    {
                        temp_sx[i] = temp_sx[i] + move_x;
                        temp_sy[i] = temp_sy[i] + move_y;
                        temp_ex[i] = temp_ex[i] + move_x;
                        temp_ey[i] = temp_ey[i] + move_y;

                        if (temp_sx[i] <= temp_ex[i])
                        {
                            point.X = temp_sx[i];
                        }
                        else
                        {
                            point.X = temp_ex[i];
                        }
                        if (temp_sy[i] <= temp_ey[i])
                        {
                            point.Y = temp_sy[i];
                        }
                        else
                        {
                            point.Y = temp_ey[i];
                        }
                        Rectangle guide_rect_move = new Rectangle(point.X, point.Y, Math.Abs(temp_sx[i] - temp_ex[i]), Math.Abs(temp_sy[i] - temp_ey[i]));
                        if (temp_drawtype[i] == 1)
                        {
                            graphics.DrawRectangle(temp_pen[i], guide_rect_move); // ------------ 여기
                            //graphics.DrawRectangle(pen, guide_rect_move);
                            graphics.FillRectangle(sBrush, guide_rect_move);
                        }
                        if (temp_drawtype[i] == 2)
                        {
                            graphics.DrawEllipse(pen, guide_rect_move);
                            graphics.FillEllipse(sBrush, guide_rect_move);
                        }
                        if (temp_drawtype[i] == 3)
                        {
                            Point move_start = new Point (temp_sx[i], temp_sy[i]);
                            Point move_end = new Point(temp_ex[i], temp_ey[i]);
                            graphics.DrawLine(pen, move_start, move_end);
                        }
                    }
                    break;
                case 5: //가변확대
                     graphics.Clear(Color.White);
                    for (int i = 0; i < TEMP_NUM; i++)
                    {
                        float variable_zoom_rate = 1;
                        variable_zoom_rate = (float)(Math.Sqrt(move_x ^ 2 + move_y ^ 2)*(ZOOM_RATE));
                        if(variable_zoom_rate==0)
                        {
                            variable_zoom_rate = 1;
                        }
                        float temp__sx = (temp_sx[i] - sPoint.X) * variable_zoom_rate + sPoint.X;
                        float temp__sy = (temp_sy[i] - sPoint.Y) * variable_zoom_rate + sPoint.Y;
                        float temp__ex = (temp_ex[i] - sPoint.X) * variable_zoom_rate + sPoint.X;
                        float temp__ey = (temp_ey[i] - sPoint.Y) * variable_zoom_rate + sPoint.Y;

                        temp_sx[i] = (int)(temp__sx);
                        temp_sy[i] = (int)(temp__sy);
                        temp_ex[i] = (int)(temp__ex);
                        temp_ey[i] = (int)(temp__ey);

                        if (temp_sx[i] <= temp_ex[i])
                        {
                            point.X = temp_sx[i];
                        }
                        else
                        {
                            point.X = temp_ex[i];
                        }
                        if (temp_sy[i] <= temp_ey[i])
                        {
                            point.Y = temp_sy[i];
                        }
                        else
                        {
                            point.Y = temp_ey[i];
                        }
                        Rectangle guide_rect_move = new Rectangle(point.X, point.Y, Math.Abs(temp_sx[i] - temp_ex[i]), Math.Abs(temp_sy[i] - temp_ey[i]));
                        if (temp_drawtype[i] == 1)
                        {
                            graphics.DrawRectangle(temp_pen[i], guide_rect_move); // ------------ 여기
                            //graphics.DrawRectangle(pen, guide_rect_move);
                            graphics.FillRectangle(sBrush, guide_rect_move);
                        }
                        if (temp_drawtype[i] == 2)
                        {
                            graphics.DrawEllipse(pen, guide_rect_move);
                            graphics.FillEllipse(sBrush, guide_rect_move);
                        }
                        if (temp_drawtype[i] == 3)
                        {
                            Point move_start = new Point (temp_sx[i], temp_sy[i]);
                            Point move_end = new Point(temp_ex[i], temp_ey[i]);
                            graphics.DrawLine(pen, move_start, move_end);
                        }
                    }
                    break;
                case 6: //고전축소
                    graphics.Clear(Color.White);
                    for (int i = 0; i < TEMP_NUM; i++)
                    {
                        float temp__sx = (temp_sx[i] - sPoint.X) * ZOOM_RATE + sPoint.X;
                        float temp__sy = (temp_sy[i] - sPoint.Y) * ZOOM_RATE + sPoint.Y;
                        float temp__ex = (temp_ex[i] - sPoint.X) * ZOOM_RATE + sPoint.X;
                        float temp__ey = (temp_ey[i] - sPoint.Y) * ZOOM_RATE + sPoint.Y;

                        temp_sx[i] = (int)(temp__sx);
                        temp_sy[i] = (int)(temp__sy);
                        temp_ex[i] = (int)(temp__ex);
                        temp_ey[i] = (int)(temp__ey);

                        if (temp_sx[i] <= temp_ex[i])
                        {
                            point.X = temp_sx[i];
                        }
                        else
                        {
                            point.X = temp_ex[i];
                        }
                        if (temp_sy[i] <= temp_ey[i])
                        {
                            point.Y = temp_sy[i];
                        }
                        else
                        {
                            point.Y = temp_ey[i];
                        }
                        Rectangle guide_rect_move = new Rectangle(point.X, point.Y, Math.Abs(temp_sx[i] - temp_ex[i]), Math.Abs(temp_sy[i] - temp_ey[i]));
                        if (temp_drawtype[i] == 1)
                        {
                            graphics.DrawRectangle(temp_pen[i], guide_rect_move); // ------------ 여기
                            //graphics.DrawRectangle(pen, guide_rect_move);
                            graphics.FillRectangle(sBrush, guide_rect_move);
                        }
                        if (temp_drawtype[i] == 2)
                        {
                            graphics.DrawEllipse(pen, guide_rect_move);
                            graphics.FillEllipse(sBrush, guide_rect_move);
                        }
                        if (temp_drawtype[i] == 3)
                        {
                            Point move_start = new Point (temp_sx[i], temp_sy[i]);
                            Point move_end = new Point(temp_ex[i], temp_ey[i]);
                            graphics.DrawLine(pen, move_start, move_end);
                        }
                    }
                    break;
            }
            temp_Canvas(picture_window, e);
        }

        private void 새그림ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics graphics = picture_window.CreateGraphics();
            graphics.Clear(Color.White);
            for (int i=0; i < TEMP_NUM; i++ )
            {
                temp_sx[i] = 0;
                temp_sy[i] = 0;
                temp_ex[i] = 0;
                temp_ey[i] = 0;
                temp_drawtype[i]=0;
                temp_pen[i] = null;
                temp_brush[i] = null;
            }
            /*
            Bitmap draw_area_temp = new Bitmap(800, 600);
            draw_area = draw_area_temp;
            Graphics graphics = Graphics.FromImage(draw_area_temp);
            graphics.Clear(Color.White);
             * */
        }
        public void new_canvas(PictureBox pb)
        {
            Bitmap draw_area_temp = new Bitmap(800, 600);
            draw_area = draw_area_temp;
            Graphics graphics = Graphics.FromImage(draw_area_temp);
            graphics.Clear(Color.White);

            Graphics paint_graphics = Graphics.FromImage(draw_area);
            paint_graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pb.Image = draw_area;
        }

        private void Trans_CheckStateChanged(object sender, EventArgs e)
        {
            if (Trans.Checked == true)
            {
                temp_color = fColor;
                fColor = Color.Transparent;
                check_trans = true;
            }
            else
            {
                fColor = temp_color;
                check_trans = false;
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "이미지파일저장";
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Save an Image File **";
            //saveFileDialog1.ShowDialog();

            Stream myStream;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
            save_Canvas(picture_window, e);
        }
        private void PenWidth_bar_Scroll(object sender, EventArgs e)
        {
            pen.Width = PenWidth_bar.Value;
        }

        private void DashStyle_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DashStyle_box.SelectedIndex)
            {
                case 0:
                    pen.DashStyle = DashStyle.Solid;
                    break;
                case 1:
                    pen.DashStyle = DashStyle.Dot;
                    break;
                case 2:
                    pen.DashStyle = DashStyle.Dash;
                    break;
                case 3:
                    pen.DashStyle = DashStyle.DashDot;
                    break;
                case 4:
                    pen.DashStyle = DashStyle.DashDotDot;
                    break;
            }
        }

        private void 이동_Click(object sender, EventArgs e)
        {
            flag_drawtype = 4;
        }

        private void 확대_Click(object sender, EventArgs e)
        {
            flag_drawtype = 5;
        }
        private void 축소_Click(object sender, EventArgs e)
        {
            flag_drawtype = 6;
        }
    }
}
