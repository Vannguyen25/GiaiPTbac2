using System.Windows.Forms.DataVisualization.Charting;

namespace WinAPP1
{
    partial class FormPT
    {
      
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView datagrid_page1;
        private Button btn_timnghiem_page1;
        private Button btn_xoadulieu_page1;
        private Label lb_nhapC_page1;
        private Label lb_nhapB_page1;
        private Label lb_thapphan_page1;
        private Label lb_nhapA_page1;
        private TextBox txt_nhapC_page1;
        private TextBox txt_nhapB_page1;
        private TextBox txt_thapphan_page1;
        private TextBox txt_nhapA_page1;
        private Button btn_vedothi_page1;
        private DataGridView datagrid_page2;
        private Button btn_timnghiem_page2;
        private Button btn_xoadulieu_page2;
        private Label lb_nhapC_page2;
        private Label lb_nhapB_page2;
        private Label lb_thapphan_page2;
        private Label lb_nhapA_page2;
        private TextBox txt_nhapC_page2;
        private TextBox txt_nhapB_page2;
        private TextBox txt_thapphan_page2;
        private TextBox txt_nhapA_page2;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn b;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Chart chart;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private PictureBox pictureBox1;
    }
}
