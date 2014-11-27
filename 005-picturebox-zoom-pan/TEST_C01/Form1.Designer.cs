namespace TEST_C01
{
    partial class canvas01
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(canvas01));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menu_file = new System.Windows.Forms.ToolStripDropDownButton();
            this.새그림ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dColor_selected = new System.Windows.Forms.ToolStripButton();
            this.fColor_selected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.ellipse = new System.Windows.Forms.ToolStripButton();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.DrawFree = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.이동 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Trans = new System.Windows.Forms.CheckBox();
            this.PenWidth_bar = new System.Windows.Forms.TrackBar();
            this.DashStyle_box = new System.Windows.Forms.ListBox();
            this.picture_window = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidth_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_window)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.toolStripSeparator1,
            this.dColor_selected,
            this.fColor_selected,
            this.toolStripSeparator2,
            this.Rectangle,
            this.ellipse,
            this.Line,
            this.DrawFree,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.이동});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(352, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새그림ToolStripMenuItem,
            this.저장하기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menu_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(44, 28);
            this.menu_file.Text = "파일";
            // 
            // 새그림ToolStripMenuItem
            // 
            this.새그림ToolStripMenuItem.Name = "새그림ToolStripMenuItem";
            this.새그림ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.새그림ToolStripMenuItem.Text = "새그림";
            this.새그림ToolStripMenuItem.Click += new System.EventHandler(this.새그림ToolStripMenuItem_Click);
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // dColor_selected
            // 
            this.dColor_selected.BackColor = System.Drawing.Color.Black;
            this.dColor_selected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dColor_selected.Image = ((System.Drawing.Image)(resources.GetObject("dColor_selected.Image")));
            this.dColor_selected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dColor_selected.Margin = new System.Windows.Forms.Padding(0, 5, 0, 6);
            this.dColor_selected.Name = "dColor_selected";
            this.dColor_selected.Size = new System.Drawing.Size(23, 20);
            this.dColor_selected.Text = "fColor_btn";
            this.dColor_selected.Click += new System.EventHandler(this.dColor_btn_Click);
            // 
            // fColor_selected
            // 
            this.fColor_selected.BackColor = System.Drawing.SystemColors.Window;
            this.fColor_selected.Margin = new System.Windows.Forms.Padding(0, 5, 0, 6);
            this.fColor_selected.Name = "fColor_selected";
            this.fColor_selected.Size = new System.Drawing.Size(23, 20);
            this.fColor_selected.Click += new System.EventHandler(this.fColor_selected_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(23, 28);
            this.Rectangle.Text = "Rectangle_btn";
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_btn_Click);
            // 
            // ellipse
            // 
            this.ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipse.Image = ((System.Drawing.Image)(resources.GetObject("ellipse.Image")));
            this.ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(23, 28);
            this.ellipse.Text = "Ellipse_btn";
            this.ellipse.Click += new System.EventHandler(this.Ellipse_btn_Click);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(23, 28);
            this.Line.Text = "Line_btn";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // DrawFree
            // 
            this.DrawFree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DrawFree.Image = ((System.Drawing.Image)(resources.GetObject("DrawFree.Image")));
            this.DrawFree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawFree.Name = "DrawFree";
            this.DrawFree.Size = new System.Drawing.Size(23, 28);
            this.DrawFree.Text = "DrawFree_btn";
            this.DrawFree.Click += new System.EventHandler(this.DrawFree_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(43, 28);
            this.toolStripButton1.Text = "확대+";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(40, 28);
            this.toolStripButton2.Text = "축소-";
            // 
            // 이동
            // 
            this.이동.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.이동.Image = ((System.Drawing.Image)(resources.GetObject("이동.Image")));
            this.이동.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.이동.Name = "이동";
            this.이동.Size = new System.Drawing.Size(35, 28);
            this.이동.Text = "이동";
            this.이동.Click += new System.EventHandler(this.이동_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "-";
            // 
            // Trans
            // 
            this.Trans.AutoSize = true;
            this.Trans.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Trans.Location = new System.Drawing.Point(324, 3);
            this.Trans.Name = "Trans";
            this.Trans.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Trans.Size = new System.Drawing.Size(48, 21);
            this.Trans.TabIndex = 8;
            this.Trans.Text = "투명";
            this.Trans.UseVisualStyleBackColor = false;
            this.Trans.CheckStateChanged += new System.EventHandler(this.Trans_CheckStateChanged);
            // 
            // PenWidth_bar
            // 
            this.PenWidth_bar.Location = new System.Drawing.Point(806, 28);
            this.PenWidth_bar.Maximum = 20;
            this.PenWidth_bar.Minimum = 2;
            this.PenWidth_bar.Name = "PenWidth_bar";
            this.PenWidth_bar.Size = new System.Drawing.Size(105, 45);
            this.PenWidth_bar.TabIndex = 9;
            this.PenWidth_bar.Value = 2;
            this.PenWidth_bar.Scroll += new System.EventHandler(this.PenWidth_bar_Scroll);
            // 
            // DashStyle_box
            // 
            this.DashStyle_box.FormattingEnabled = true;
            this.DashStyle_box.ItemHeight = 12;
            this.DashStyle_box.Items.AddRange(new object[] {
            "Solid",
            "Dot",
            "Dash",
            "Dash-Dot",
            "Dash-Dot-Dot"});
            this.DashStyle_box.Location = new System.Drawing.Point(813, 66);
            this.DashStyle_box.Name = "DashStyle_box";
            this.DashStyle_box.Size = new System.Drawing.Size(94, 64);
            this.DashStyle_box.TabIndex = 10;
            this.DashStyle_box.SelectedIndexChanged += new System.EventHandler(this.DashStyle_box_SelectedIndexChanged);
            // 
            // picture_window
            // 
            this.picture_window.BackColor = System.Drawing.Color.White;
            this.picture_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_window.Location = new System.Drawing.Point(0, 28);
            this.picture_window.Name = "picture_window";
            this.picture_window.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.picture_window.Size = new System.Drawing.Size(800, 600);
            this.picture_window.TabIndex = 11;
            this.picture_window.TabStop = false;
            this.picture_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_window_MouseDown);
            this.picture_window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_window_MouseMove);
            this.picture_window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_window_MouseUp);
            // 
            // canvas01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 651);
            this.Controls.Add(this.picture_window);
            this.Controls.Add(this.DashStyle_box);
            this.Controls.Add(this.PenWidth_bar);
            this.Controls.Add(this.Trans);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "canvas01";
            this.Text = "캔버스 0.1 ver";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenWidth_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_window)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton menu_file;
        private System.Windows.Forms.ToolStripButton DrawFree;
        private System.Windows.Forms.ToolStripButton dColor_selected;
        private System.Windows.Forms.ToolStripMenuItem 새그림ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton ellipse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton fColor_selected;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.CheckBox Trans;
        private System.Windows.Forms.TrackBar PenWidth_bar;
        private System.Windows.Forms.ListBox DashStyle_box;
        private System.Windows.Forms.PictureBox picture_window;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton 이동;
    }
}

