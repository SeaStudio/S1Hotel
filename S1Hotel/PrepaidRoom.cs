using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CCWin;

namespace S1Hotel
{
    public partial class PrepaidRoom : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public PrepaidRoom()
        {
            InitializeComponent();
        }
        private DateTime dt;
        private void PrepaidRoom_Load(object sender, EventArgs e)
        {
            ShengChengID();
            ZaiRuFangJianLeiXing();
            ZaiRuKongJinFang();
            tpRuZhu.Text = DateTime.Now.AddDays(2).ToShortDateString();
            tpYuLi.Text = DateTime.Now.AddDays(3).ToShortDateString() + " 12:00:00";
            dt = Convert.ToDateTime(tpRuZhu.Text);

        }
        /// <summary>
        /// 载入空净房
        /// </summary>
        private void ZaiRuKongJinFang()
        {
            //清空原有房间数据
            if (lvKongJingFang.Items.Count > 0)
            {
                lvKongJingFang.Items.Clear();
            }
            //载入全部空净房
            string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID
												where RoomStateTable.ID=1 or RoomStateTable.ID=2 or RoomStateTable.ID=4");
            //载入所选空净房间类型数据
            if (cbLeiXing.Text != "全部")
            {
                sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID
												where RoomStateTable.ID=1 and RoomTypeTable.TypeName='{0}'", cbLeiXing.Text);
            }
            try
            {
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem items = new ListViewItem(dr[0].ToString());
                        items.SubItems.Add(dr[2].ToString());
                        items.SubItems.Add(dr[3].ToString());
                        lvKongJingFang.Items.Add(items);
                    }
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
            YiChuFangJian();
            YiChuFangJian();
            YiChuFangJian();
        }
        /// <summary>
        /// 房间时间冲突了
        /// </summary>
        public void YiChuFangJian()
        {

            if (lvKongJingFang.Items.Count > 0)
            {
                for (int i = 0; i < lvKongJingFang.Items.Count; i++)
                {
                    //预定的房间
                    try
                    {
                        string sql = string.Format(@"select *
                                        from PredeterminedTable
                                        where RoomID = '{0}' and Type ='预定中'", lvKongJingFang.Items[i].SubItems[0].Text);
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                DateTime dt1 = Convert.ToDateTime(dr["PreconditioningTime"].ToString());
                                DateTime dt2 = Convert.ToDateTime(dr["PreDepartureTime"].ToString());
                                if (db.CalcTimeOverlap(tpRuZhu.Value, tpYuLi.Value, dt1, dt2))
                                {
                                    lvKongJingFang.Items.Remove(lvKongJingFang.Items[i]);//移除时间冲突的！
                                }
                            }
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
                for (int i = 0; i < lvKongJingFang.Items.Count; i++)
                {
                    //入住的房间
                    try
                    {
                        string sql = string.Format(@"select *
                                                    from OrderTable
                                                    where RoomID ='{0}' and State = '新开单'", lvKongJingFang.Items[i].SubItems[0].Text);
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                DateTime dt1 = Convert.ToDateTime(dr["CheckInTime"].ToString());
                                DateTime dt2 = Convert.ToDateTime(dr["PreDepartureTime"].ToString());
                                if (db.CalcTimeOverlap(tpRuZhu.Value, tpYuLi.Value, dt1, dt2))
                                {
                                    lvKongJingFang.Items.Remove(lvKongJingFang.Items[i]);//移除时间冲突的代码！
                                }
                            }
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
        private void ZaiRuFangJianLeiXing()
        {
            string sql = string.Format(@"select * from RoomTypeTable");
            string biaoMing = "LeiXing";
            try
            {
                DataSet ds = db.GetDataSet(sql, biaoMing);
                DataRow row = ds.Tables[biaoMing].NewRow();
                row["ID"] = -1;
                row["TypeName"] = "全部";
                ds.Tables[biaoMing].Rows.InsertAt(row, 0);
                cbLeiXing.DataSource = ds.Tables[biaoMing];
                cbLeiXing.ValueMember = "ID";
                cbLeiXing.DisplayMember = "TypeName";
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
        private void ShengChengID()
        {
            //自动生成id 格式为 20181018001 
            try
            {
                string danHao = "";
                string today = DateTime.Now.ToString("yyyyMMdd");
                string sql = string.Format(@"select MAX(reservationNumber)
                                                from PredeterminedTable
                                            where reservationNumber like '{0}%'", today);
                double aa = db.GetSingleDoubleValue(sql);
                //如果标准中有今天的值就今天的最大值加1
                if (aa > 0)
                {
                    aa++;
                    danHao = (aa).ToString();
                }
                else
                {
                    danHao = today.ToString() + "001";
                }
                tbDingDanHao.Text = danHao;

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
        private void skinGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvKongJingFang_DoubleClick(object sender, EventArgs e)
        {
            //双击未预定的房间中的listview 跳到已预定的listview
            ListViewItem list = lvKongJingFang.SelectedItems[0];
            //cbFangJianLeiXing.Text = lvKongJingFang.SelectedItems[0].SubItems[1].Text;
            lvKongJingFang.Items.Remove(list);
            lvYiXuang.Items.Add(list);
            JiSuanFangJia();

        }

        private void JiSuanFangJia()
        {
            int tianShu = 0;
            //预离时间必须大于入住
            DateTime dt1 = Convert.ToDateTime(tpRuZhu.Text);
            DateTime dt2 = Convert.ToDateTime(tpYuLi.Text);
            TimeSpan ts1 = dt2.Subtract(dt1);
            if (dt1 > dt2)
            {
                MessageBox.Show("预离时间必须大于入住时间!","提示");
                return;
            }
            if (ts1.Days == 0)
            {
                if (ts1.Hours > 6)
                {
                    tianShu = ts1.Days + 1;
                }
            }
            else
            {
                tianShu = ts1.Days;
                if (ts1.Hours > 12)
                {
                    tianShu = ts1.Days + 1;
                }
            }
            //计算总房价
            int count = lvYiXuang.Items.Count;
            if (lvYiXuang.Items.Count > 0)
            {
                double money = 0;
                for (int i = 0; i < count; i++)
                {
                    money += Convert.ToDouble(lvYiXuang.Items[i].SubItems[2].Text) * tianShu;
                }
                tbZongJia.Text = money.ToString();
            }
        }

        private void cbFangJianLeiXing_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZaiRuKongJinFang();
        }

        private void lvYiXuang_DoubleClick(object sender, EventArgs e)
        {
            //双击已预定的房间中的listview 跳到未预定的listview
            ListViewItem list = lvYiXuang.SelectedItems[0];
            lvYiXuang.Items.Remove(list);
            lvKongJingFang.Items.Add(list);
            JiSuanFangJia();
        }

        private void tpRuZhu_ValueChanged(object sender, EventArgs e)
        {
            if (dt > tpRuZhu.Value)
            {
                MessageBox.Show("必须提前2天才能预定！","提示");
                tpRuZhu.Value = dt;
            }
            ZaiRuKongJinFang();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (txtXingMing.Text == "" || txtDianHua.Text == "" || txtBeiZhu.Text == "")
            {
                MessageBox.Show("请填写所有信息！","提示");
                return;
            }
            int zhi = 0;
            for (int i = 0; i < lvYiXuang.Items.Count; i++)
            {
                try
                {
                    string sql = string.Format(@"insert into PredeterminedTable(reservationNumber, Name, Phone, RoomID, RoomType, PreconditioningTime, PreDepartureTime, Operator, Price, Type)
                                    values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')"
                                                    , tbDingDanHao.Text, txtXingMing.Text, txtDianHua.Text, lvYiXuang.Items[i].SubItems[0].Text, lvYiXuang.Items[i].SubItems[1].Text, tpRuZhu.Text, tpYuLi.Text, "1", lvYiXuang.Items[i].SubItems[2].Text, "预定中");
                    if (db.ExecuteSQLCommand(sql) > 0)
                    {
                        zhi++;
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

            MessageBox.Show("成功预定" + zhi + "房！");
            this.Close();
        }

        private void tpYuLi_ValueChanged(object sender, EventArgs e)
        {
            ZaiRuKongJinFang();

        }
    }
}
