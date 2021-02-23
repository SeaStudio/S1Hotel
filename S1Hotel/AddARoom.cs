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
    public partial class AddARoom : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public AddARoom()
        {
            InitializeComponent();
        }

        private void AddARoom_Load(object sender, EventArgs e)
        {
            try
            {
                //载入房间类型
                string sql = string.Format(@"select *
                                        from RoomTypeTable");
                DataSet ds = db.GetDataSet(sql, "LeiXing");
                cbLeiXing.DataSource = ds.Tables["LeiXing"];
                cbLeiXing.ValueMember = "ID";
                cbLeiXing.DisplayMember = "TypeName";

                //载入房间状态
                sql = string.Format(@"select *
                                            from RoomStateTable");
                DataSet dss = db.GetDataSet(sql, "ZhuangTai");
                cbZhuangTai.DataSource = dss.Tables["ZhuangTai"];
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
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (tbFangHao.Text == "" || tbLouCeng.Text == "")
            {
                MessageBox.Show("请填写房间和楼层！");
                return;
            }
            try
            {
                string sql = string.Format(@"insert into RoomTable(RoomID, Floor, TypeID, StateID)
                                            values('{0}','{1}','{2}','{3}')", tbFangHao.Text, tbLouCeng.Text, cbLeiXing.SelectedValue.ToString(), cbZhuangTai.SelectedValue.ToString());
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string aac = string.Format("{0}房间新增成功！", tbFangHao.Text);
                    MessageBox.Show(aac);
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

        private void skinButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFangHao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"select COUNT(*)
                                                from RoomTable
                                                where RoomID='{0}'", tbFangHao.Text);
                if (db.GetSingleIntValue(sql) > 0)
                {
                    MessageBox.Show("该房间已存在，请重新输入！");
                    tbFangHao.Text = "";
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
    }
}
