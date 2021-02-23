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
    public partial class RoomManagement : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            ZaiRuFangFa();
        }

        private void ZaiRuFangFa()
        {
            //载入房间表
            string sql = string.Format(@"SELECT RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID");


            ZaiRuFangJianBiao(sql, "FangJian");
            //载入房间类型
            try
            {
                sql = string.Format(@"select *
                                    from RoomStateTable");
                DataSet ds = db.GetDataSet(sql, "LeiXing");
                cbLeiXing.DataSource = ds.Tables["LeiXing"];
                cbLeiXing.ValueMember = "ID";
                cbLeiXing.DisplayMember = "StateName";
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
        /// <summary>
        /// 载入房间表
        /// </summary>
        private void ZaiRuFangJianBiao(string sql, string biaoMing)
        {
            try
            {

                DataSet ds = db.GetDataSet(sql, biaoMing);
                dgvFangJian.DataSource = ds.Tables[biaoMing];

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

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbFangJianHao.Text == "")
                {
                    string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomStateTable.StateName='{0}'", cbLeiXing.Text);
                    ZaiRuFangJianBiao(sql, "ChaFangJian");
                }
                else
                {
                    string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomTable.RoomID='{0}'", tbFangJianHao.Text);
                    ZaiRuFangJianBiao(sql, "ChaFangJian");
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


        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddARoom aar = new AddARoom();
            aar.ShowDialog();
            ZaiRuFangFa();
        }

        private void 修改价格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReviseThePrice rtp = new ReviseThePrice();
            rtp.ShowDialog();
            ZaiRuFangFa();
        }

        private void 修改房间信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyInformation mif = new ModifyInformation();
            mif.ShowDialog();
            ZaiRuFangFa();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteInformation dif = new DeleteInformation();
            dif.ShowDialog();
            ZaiRuFangFa();
        }
    }
}
