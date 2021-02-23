using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace S1Hotel
{
    public partial class ModifyRoomStatus : CCSkinMain
    {
        public string FangHao { get; set; }
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public ModifyRoomStatus()
        {
            InitializeComponent();
        }

        private void ModifyRoomStatus_Load(object sender, EventArgs e)
        {
            try
            {

                //查询状态添加到skinComboBox2
                string sql = string.Format(@"select *
                                    from RoomStateTable");
                DataSet ds = db.GetDataSet(sql, "ZhuangTai");
                cbZhuangTai.DataSource = ds.Tables["ZhuangTai"];
                cbZhuangTai.ValueMember = "ID";
                cbZhuangTai.DisplayMember = "StateName";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            try
            {
                //查询状态添加到skinComboBox2
                string sql = string.Format(@"select *
                                                from RoomTable where StateID !=2");
                DataSet ds = db.GetDataSet(sql, "FangHao");
                cbFangHao.DataSource = ds.Tables["FangHao"];
                cbFangHao.DisplayMember = "RoomID";
                if (FangHao != "")
                {
                    cbFangHao.Text = FangHao;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //修改房间状态
                string sql = string.Format(@"update RoomTable set StateID='{0}'
                                                where RoomID='{1}'", cbZhuangTai.SelectedValue.ToString(), cbFangHao.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string tiShi = string.Format("{0}房间状态已修改为{1}！", cbFangHao.Text, cbZhuangTai.Text);
                    MessageBox.Show(tiShi);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            this.Close();
        }
    }
}
