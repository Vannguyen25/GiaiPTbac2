using Complex;
using Ptbac2;
using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;
namespace WinAPP1
{
    public partial class FormPT : Form  // Kế thừa từ lớp con Form
    {
        public FormPT()
        {
            InitializeComponent();
            // Tạo TabControl
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            datagrid_page1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            a = new DataGridViewTextBoxColumn();
            b = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btn_timnghiem_page1 = new Button();
            btn_xoadulieu_page1 = new Button();
            lb_nhapC_page1 = new Label();
            lb_nhapB_page1 = new Label();
            lb_thapphan_page1 = new Label();
            lb_nhapA_page1 = new Label();
            txt_nhapC_page1 = new TextBox();
            txt_nhapB_page1 = new TextBox();
            txt_thapphan_page1 = new TextBox();
            txt_nhapA_page1 = new TextBox();
            btn_vedothi_page1 = new Button();
            tabPage2 = new TabPage();
            datagrid_page2 = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            btn_timnghiem_page2 = new Button();
            btn_xoadulieu_page2 = new Button();
            lb_nhapC_page2 = new Label();
            lb_nhapB_page2 = new Label();
            lb_thapphan_page2 = new Label();
            label1 = new Label();
            lb_nhapA_page2 = new Label();
            txt_nhapC_page2 = new TextBox();
            txt_nhapB_page2 = new TextBox();
            txt_thapphan_page2 = new TextBox();
            txt_nhapA_page2 = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_page1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_page2).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(22, 22);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(2, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1779, 751);
            tabControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(datagrid_page1);
            tabPage1.Controls.Add(btn_timnghiem_page1);
            tabPage1.Controls.Add(btn_xoadulieu_page1);
            tabPage1.Controls.Add(lb_nhapC_page1);
            tabPage1.Controls.Add(lb_nhapB_page1);
            tabPage1.Controls.Add(lb_thapphan_page1);
            tabPage1.Controls.Add(lb_nhapA_page1);
            tabPage1.Controls.Add(txt_nhapC_page1);
            tabPage1.Controls.Add(txt_nhapB_page1);
            tabPage1.Controls.Add(txt_thapphan_page1);
            tabPage1.Controls.Add(txt_nhapA_page1);
            tabPage1.Controls.Add(btn_vedothi_page1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1771, 715);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Số thực";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(929, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(750, 299);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Black", 13.970149F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(249, 22);
            label2.Name = "label2";
            label2.Size = new Size(524, 32);
            label2.TabIndex = 20;
            label2.Text = "GIẢI PHƯƠNG TRÌNH BẬC HAI HỆ SỐ THỰC\r\n";
            // 
            // datagrid_page1
            // 
            datagrid_page1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_page1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_page1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, a, b, c, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            datagrid_page1.Location = new Point(60, 343);
            datagrid_page1.Name = "datagrid_page1";
            datagrid_page1.RowHeadersWidth = 57;
            datagrid_page1.Size = new Size(1619, 326);
            datagrid_page1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn1.HeaderText = "STT";
            dataGridViewTextBoxColumn1.MinimumWidth = 7;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 60;
            // 
            // a
            // 
            a.HeaderText = "a";
            a.MinimumWidth = 7;
            a.Name = "a";
            // 
            // b
            // 
            b.HeaderText = "b";
            b.MinimumWidth = 7;
            b.Name = "b";
            // 
            // c
            // 
            c.HeaderText = "c";
            c.MinimumWidth = 7;
            c.Name = "c";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Số nghiệm";
            dataGridViewTextBoxColumn2.MinimumWidth = 7;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nghiệm x1";
            dataGridViewTextBoxColumn3.MinimumWidth = 7;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Nghiệm x2";
            dataGridViewTextBoxColumn4.MinimumWidth = 7;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btn_timnghiem_page1
            // 
            btn_timnghiem_page1.AutoEllipsis = true;
            btn_timnghiem_page1.Location = new Point(716, 165);
            btn_timnghiem_page1.Name = "btn_timnghiem_page1";
            btn_timnghiem_page1.Size = new Size(182, 39);
            btn_timnghiem_page1.TabIndex = 0;
            btn_timnghiem_page1.Text = "Tìm nghiệm";
            btn_timnghiem_page1.UseVisualStyleBackColor = true;
            btn_timnghiem_page1.Click += button1_Click;
            // 
            // btn_xoadulieu_page1
            // 
            btn_xoadulieu_page1.Location = new Point(716, 210);
            btn_xoadulieu_page1.Name = "btn_xoadulieu_page1";
            btn_xoadulieu_page1.Size = new Size(182, 43);
            btn_xoadulieu_page1.TabIndex = 8;
            btn_xoadulieu_page1.Text = "Xóa dữ liệu";
            btn_xoadulieu_page1.UseVisualStyleBackColor = true;
            btn_xoadulieu_page1.Click += button2_Click;
            // 
            // lb_nhapC_page1
            // 
            lb_nhapC_page1.AutoSize = true;
            lb_nhapC_page1.Location = new Point(70, 253);
            lb_nhapC_page1.Name = "lb_nhapC_page1";
            lb_nhapC_page1.Size = new Size(65, 23);
            lb_nhapC_page1.TabIndex = 5;
            lb_nhapC_page1.Text = "Nhập c";
            // 
            // lb_nhapB_page1
            // 
            lb_nhapB_page1.AutoSize = true;
            lb_nhapB_page1.Location = new Point(72, 176);
            lb_nhapB_page1.Name = "lb_nhapB_page1";
            lb_nhapB_page1.Size = new Size(67, 23);
            lb_nhapB_page1.TabIndex = 5;
            lb_nhapB_page1.Text = "Nhập b";
            // 
            // lb_thapphan_page1
            // 
            lb_thapphan_page1.AutoSize = true;
            lb_thapphan_page1.Location = new Point(602, 106);
            lb_thapphan_page1.Name = "lb_thapphan_page1";
            lb_thapphan_page1.Size = new Size(92, 23);
            lb_thapphan_page1.TabIndex = 5;
            lb_thapphan_page1.Text = "Thập phân";
            // 
            // lb_nhapA_page1
            // 
            lb_nhapA_page1.AutoSize = true;
            lb_nhapA_page1.Location = new Point(72, 103);
            lb_nhapA_page1.Name = "lb_nhapA_page1";
            lb_nhapA_page1.Size = new Size(66, 23);
            lb_nhapA_page1.TabIndex = 5;
            lb_nhapA_page1.Text = "Nhập a";
            // 
            // txt_nhapC_page1
            // 
            txt_nhapC_page1.Location = new Point(194, 250);
            txt_nhapC_page1.Name = "txt_nhapC_page1";
            txt_nhapC_page1.Size = new Size(314, 30);
            txt_nhapC_page1.TabIndex = 2;
            // 
            // txt_nhapB_page1
            // 
            txt_nhapB_page1.Location = new Point(196, 169);
            txt_nhapB_page1.Name = "txt_nhapB_page1";
            txt_nhapB_page1.Size = new Size(314, 30);
            txt_nhapB_page1.TabIndex = 2;
            // 
            // txt_thapphan_page1
            // 
            txt_thapphan_page1.Location = new Point(718, 100);
            txt_thapphan_page1.Name = "txt_thapphan_page1";
            txt_thapphan_page1.Size = new Size(182, 30);
            txt_thapphan_page1.TabIndex = 2;
            // 
            // txt_nhapA_page1
            // 
            txt_nhapA_page1.Location = new Point(194, 102);
            txt_nhapA_page1.Name = "txt_nhapA_page1";
            txt_nhapA_page1.Size = new Size(314, 30);
            txt_nhapA_page1.TabIndex = 2;
            // 
            // btn_vedothi_page1
            // 
            btn_vedothi_page1.AutoEllipsis = true;
            btn_vedothi_page1.Location = new Point(716, 259);
            btn_vedothi_page1.Name = "btn_vedothi_page1";
            btn_vedothi_page1.Size = new Size(182, 39);
            btn_vedothi_page1.TabIndex = 0;
            btn_vedothi_page1.Text = "Vẽ đồ thị";
            btn_vedothi_page1.UseVisualStyleBackColor = true;
            btn_vedothi_page1.Click += VeDoThi_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(datagrid_page2);
            tabPage2.Controls.Add(btn_timnghiem_page2);
            tabPage2.Controls.Add(btn_xoadulieu_page2);
            tabPage2.Controls.Add(lb_nhapC_page2);
            tabPage2.Controls.Add(lb_nhapB_page2);
            tabPage2.Controls.Add(lb_thapphan_page2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(lb_nhapA_page2);
            tabPage2.Controls.Add(txt_nhapC_page2);
            tabPage2.Controls.Add(txt_nhapB_page2);
            tabPage2.Controls.Add(txt_thapphan_page2);
            tabPage2.Controls.Add(txt_nhapA_page2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1771, 715);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Số phức";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // datagrid_page2
            // 
            datagrid_page2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid_page2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_page2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, Column1, Column2, Column3, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            datagrid_page2.Location = new Point(60, 343);
            datagrid_page2.Name = "datagrid_page2";
            datagrid_page2.RowHeadersWidth = 57;
            datagrid_page2.Size = new Size(1631, 360);
            datagrid_page2.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn5.HeaderText = "STT";
            dataGridViewTextBoxColumn5.MinimumWidth = 7;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 60;
            // 
            // Column1
            // 
            Column1.HeaderText = "a";
            Column1.MinimumWidth = 7;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "b";
            Column2.MinimumWidth = 7;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "c";
            Column3.MinimumWidth = 7;
            Column3.Name = "Column3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Số nghiệm";
            dataGridViewTextBoxColumn6.MinimumWidth = 7;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Nghiệm x1";
            dataGridViewTextBoxColumn7.MinimumWidth = 7;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Nghiệm x2";
            dataGridViewTextBoxColumn8.MinimumWidth = 7;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btn_timnghiem_page2
            // 
            btn_timnghiem_page2.AutoEllipsis = true;
            btn_timnghiem_page2.Location = new Point(716, 165);
            btn_timnghiem_page2.Name = "btn_timnghiem_page2";
            btn_timnghiem_page2.Size = new Size(182, 39);
            btn_timnghiem_page2.TabIndex = 10;
            btn_timnghiem_page2.Text = "Tìm nghiệm";
            btn_timnghiem_page2.UseVisualStyleBackColor = true;
            btn_timnghiem_page2.Click += btn_timnghiem_page2_Click;
            // 
            // btn_xoadulieu_page2
            // 
            btn_xoadulieu_page2.Location = new Point(716, 210);
            btn_xoadulieu_page2.Name = "btn_xoadulieu_page2";
            btn_xoadulieu_page2.Size = new Size(182, 43);
            btn_xoadulieu_page2.TabIndex = 20;
            btn_xoadulieu_page2.Text = "Xóa dữ liệu";
            btn_xoadulieu_page2.UseVisualStyleBackColor = true;
            btn_xoadulieu_page2.Click += btn_xoadulieu_page2_Click;
            // 
            // lb_nhapC_page2
            // 
            lb_nhapC_page2.AutoSize = true;
            lb_nhapC_page2.Location = new Point(70, 253);
            lb_nhapC_page2.Name = "lb_nhapC_page2";
            lb_nhapC_page2.Size = new Size(65, 23);
            lb_nhapC_page2.TabIndex = 16;
            lb_nhapC_page2.Text = "Nhập c";
            // 
            // lb_nhapB_page2
            // 
            lb_nhapB_page2.AutoSize = true;
            lb_nhapB_page2.Location = new Point(72, 176);
            lb_nhapB_page2.Name = "lb_nhapB_page2";
            lb_nhapB_page2.Size = new Size(67, 23);
            lb_nhapB_page2.TabIndex = 17;
            lb_nhapB_page2.Text = "Nhập b";
            // 
            // lb_thapphan_page2
            // 
            lb_thapphan_page2.AutoSize = true;
            lb_thapphan_page2.Location = new Point(602, 106);
            lb_thapphan_page2.Name = "lb_thapphan_page2";
            lb_thapphan_page2.Size = new Size(92, 23);
            lb_thapphan_page2.TabIndex = 18;
            lb_thapphan_page2.Text = "Thập phân";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Black", 13.970149F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(249, 22);
            label1.Name = "label1";
            label1.Size = new Size(526, 32);
            label1.TabIndex = 19;
            label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC HAI HỆ SỐ PHỨC";
            // 
            // lb_nhapA_page2
            // 
            lb_nhapA_page2.AutoSize = true;
            lb_nhapA_page2.Location = new Point(72, 103);
            lb_nhapA_page2.Name = "lb_nhapA_page2";
            lb_nhapA_page2.Size = new Size(66, 23);
            lb_nhapA_page2.TabIndex = 19;
            lb_nhapA_page2.Text = "Nhập a";
            // 
            // txt_nhapC_page2
            // 
            txt_nhapC_page2.Location = new Point(194, 250);
            txt_nhapC_page2.Name = "txt_nhapC_page2";
            txt_nhapC_page2.Size = new Size(314, 30);
            txt_nhapC_page2.TabIndex = 12;
            // 
            // txt_nhapB_page2
            // 
            txt_nhapB_page2.Location = new Point(196, 169);
            txt_nhapB_page2.Name = "txt_nhapB_page2";
            txt_nhapB_page2.Size = new Size(314, 30);
            txt_nhapB_page2.TabIndex = 13;
            // 
            // txt_thapphan_page2
            // 
            txt_thapphan_page2.Location = new Point(718, 100);
            txt_thapphan_page2.Name = "txt_thapphan_page2";
            txt_thapphan_page2.Size = new Size(182, 30);
            txt_thapphan_page2.TabIndex = 14;
            // 
            // txt_nhapA_page2
            // 
            txt_nhapA_page2.Location = new Point(194, 102);
            txt_nhapA_page2.Name = "txt_nhapA_page2";
            txt_nhapA_page2.Size = new Size(314, 30);
            txt_nhapA_page2.TabIndex = 15;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // FormPT
            // 
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            CausesValidation = false;
            ClientSize = new Size(1758, 748);
            Controls.Add(tabControl);
            Name = "FormPT";
            Text = "Giải phương trình";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrid_page1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_page2).EndInit();
            ResumeLayout(false);
        }

        private void VeDoThi_Click(object sender, EventArgs e)
        {
            // Đọc a, b, c từ TextBox
            if (!double.TryParse(txt_nhapA_page1.Text, out double a) ||
                !double.TryParse(txt_nhapB_page1.Text, out double b) ||
                !double.TryParse(txt_nhapC_page1.Text, out double c))
            {
                MessageBox.Show("Chỉ nhập số thực hợp lệ!");
                return;
            }

            // Gọi hàm vẽ đồ thị
            this.pictureBox1.Image = ve_do_thi.draw_bitmap(a,b,c, this.pictureBox1.Width, this.pictureBox1.Height);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int precision = 5;
            float a;
            float b;
            float c;
            try
            {
                a = float.Parse(txt_nhapA_page1.Text);
                b = float.Parse(txt_nhapB_page1.Text);
                c = float.Parse(txt_nhapC_page1.Text);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Vui lòng nhập số thực");
                return;
            }
            try
            {
                precision = int.Parse(this.txt_thapphan_page1.Text);
            }
            catch (Exception ex)
            {
                precision = 5;
            }
            Pt_thuc pt = new Pt_thuc(a, b, c);
            var result = pt.TinhNghiem();

            int stt = datagrid_page1.Rows.Count + 1;
            if (result.Item3 == 0)
            {
                datagrid_page1.Rows.Add(stt - 1, a, b, c, "0", "Vô nghiệm", "");
            }
            if (result.Item3 == -1)
            {
                datagrid_page1.Rows.Add(stt - 1, a, b, c, "∞", "Vô số nghiệm", "");
            }
            else if (result.Item3 == 1)
            {
                datagrid_page1.Rows.Add(stt - 1, a, b, c, 1, result.Item1.ToString(), "");
            }
            else if (result.Item3 == 2)
            {
                datagrid_page1.Rows.Add(stt - 1, a, b, c, 2, result.Item1.ToString(), result.Item2.ToString());
            }
            this.txt_nhapA_page1.Text = "";
            this.txt_nhapB_page1.Text = "";
            this.txt_nhapC_page1.Text = "";
            this.txt_thapphan_page1.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.txt_nhapA_page1.Text = "";
            this.txt_nhapB_page1.Text = "";
            this.txt_nhapC_page1.Text = "";
            this.datagrid_page1.Rows.Clear();
        }




        private void btn_timnghiem_page2_Click(object sender, EventArgs e)
        {
            int precision = 5;
            complex a;
            complex b;
            complex c;
            try
            {
                a = new complex(this.txt_nhapA_page2.Text);
                b = new complex(this.txt_nhapB_page2.Text);
                c = new complex(this.txt_nhapC_page2.Text);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Chuỗi nhập không hợp lệ: " + ex.Message, "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                precision = int.Parse(this.txt_thapphan_page2.Text);
            }
            catch
            {
                precision = 5;
            }
            Pt_phuc pt = new Pt_phuc(a, b, c);
            var result = pt.TinhNghiem();

            int stt = datagrid_page2.Rows.Count + 1;

            if (result.Item3 == -1)
            {
                datagrid_page2.Rows.Add(stt - 1, a.ToString(), b.ToString(), c.ToString(), "∞", "Vô số nghiệm", "");
            }
            else if (result.Item3 == 1)
            {
                datagrid_page2.Rows.Add(stt - 1, a.ToString(), b.ToString(), c.ToString(), 1, result.Item1.ToString(), "");
            }
            else if (result.Item3 == 2)
            {
                datagrid_page2.Rows.Add(stt - 1, a.ToString(), b.ToString(), c.ToString(), 2, result.Item1.ToString(), result.Item2.ToString());
            }
            this.txt_nhapA_page2.Text = "";
            this.txt_nhapB_page2.Text = "";
            this.txt_nhapC_page2.Text = "";
            this.txt_thapphan_page2.Text = "";
        }

        private void btn_xoadulieu_page2_Click(object sender, EventArgs e)
        {
            this.txt_nhapA_page2.Text = "";
            this.txt_nhapB_page2.Text = "";
            this.txt_nhapC_page2.Text = "";
            this.datagrid_page2.Rows.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /*
        private void DrawQuadraticGraph(double a, double b, double c)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                int w = bmp.Width;
                int h = bmp.Height;

                // Tạo đối tượng Pt_thuc để tính nghiệm
                Pt_thuc pt = new Pt_thuc(a, b, c);
                var (x1, x2, numNghiem) = pt.TinhNghiem();

                // Xác định dải x để vẽ
                double xMin = -10, xMax = 10;
                if (numNghiem == 1) // 1 nghiệm thực
                {
                    double xr = x1.Value;
                    xMin = xr - 5;
                    xMax = xr + 5;
                }
                else if (numNghiem == 2) // 2 nghiệm thực
                {
                    double xrMin = Math.Min(x1.Value, x2.Value);
                    double xrMax = Math.Max(x1.Value, x2.Value);
                    double padding = 2;
                    xMin = xrMin - padding;
                    xMax = xrMax + padding;
                }
                // nếu numNghiem = 0 hoặc -1 thì để mặc định -10..10

                // Tìm yMin, yMax để tỉ lệ tự động
                double yMin = a * xMin * xMin + b * xMin + c;
                double yMax = yMin;
                for (double x = xMin; x <= xMax; x += (xMax - xMin) / w)
                {
                    double y = a * x * x + b * x + c;
                    if (y < yMin) yMin = y;
                    if (y > yMax) yMax = y;
                }

                // Mở rộng y một chút để đồ thị không bị sát biên
                double yPadding = (yMax - yMin) * 0.1;
                yMin -= yPadding;
                yMax += yPadding;

                // Vẽ lưới
                Pen gridPen = new Pen(Color.LightGray, 1);
                Font font = new Font("Arial", 8);
                Brush brush = Brushes.Black;

                int zeroX = (int)((0 - xMin) / (xMax - xMin) * w);
                int zeroY = (int)((yMax - 0) / (yMax - yMin) * h);

                // Vẽ các đường ngang (trục Y)
                int numYLines = 10;
                for (int i = 0; i <= numYLines; i++)
                {
                    double yVal = yMin + i * (yMax - yMin) / numYLines;
                    int py = (int)((yMax - yVal) / (yMax - yMin) * h);
                    g.DrawLine(gridPen, 0, py, w, py);
                    g.DrawString(yVal.ToString("F1"), font, brush, zeroX + 2, py - 10);
                }

                // Vẽ các đường dọc (trục X)
                int numXLines = 10;
                for (int i = 0; i <= numXLines; i++)
                {
                    double xVal = xMin + i * (xMax - xMin) / numXLines;
                    int px = (int)((xVal - xMin) / (xMax - xMin) * w);
                    g.DrawLine(gridPen, px, 0, px, h);
                    g.DrawString(xVal.ToString("F1"), font, brush, px + 2, zeroY + 2);
                }

                // Vẽ trục Oxy
                Pen axisPen = new Pen(Color.Black, 1);
                g.DrawLine(axisPen, 0, zeroY, w, zeroY); // trục X
                g.DrawLine(axisPen, zeroX, 0, zeroX, h); // trục Y

                // Vẽ đồ thị parabola
                Pen curvePen = new Pen(Color.Red, 2);
                Point? prevPoint = null;
                for (int i = 0; i <= w; i++)
                {
                    double x = xMin + i * (xMax - xMin) / w;
                    double y = a * x * x + b * x + c;
                    int px = i;
                    int py = (int)((yMax - y) / (yMax - yMin) * h);
                    Point p = new Point(px, py);
                    if (prevPoint != null)
                        g.DrawLine(curvePen, prevPoint.Value, p);
                    prevPoint = p;
                }

                // Đánh dấu nghiệm thực nếu có
                if (numNghiem > 0)
                {
                    Pen markPen = new Pen(Color.Blue, 2);
                    Brush markBrush = Brushes.Blue;
                    if (numNghiem >= 1) // 1 nghiệm
                    {
                        int px = (int)((x1.Value - xMin) / (xMax - xMin) * w);
                        int py = zeroY;
                        g.FillEllipse(markBrush, px - 3, py - 3, 6, 6);
                        g.DrawString($"x={x1.Value:F2}", font, markBrush, px + 2, py - 15);
                    }
                    if (numNghiem == 2) // 2 nghiệm
                    {
                        int px = (int)((x2.Value - xMin) / (xMax - xMin) * w);
                        int py = zeroY;
                        g.FillEllipse(markBrush, px - 3, py - 3, 6, 6);
                        g.DrawString($"x={x2.Value:F2}", font, markBrush, px + 2, py - 15);
                    }
                }
            }

            pictureBox1.Image = bmp;
        }*/
    }
}

