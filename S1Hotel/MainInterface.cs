using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using CCWin;

namespace S1Hotel
{
    /// <summary>
    /// 主界面
    /// </summary>
    public partial class MainInterface : CCSkinMain
    {

        public string CaoZuoYuan { get; set; }   //操作员
        public string QuanXuang { get; set; }    //权限
                                                 //调用DBHelper类
        private DBHelper db = new DBHelper();
        public MainInterface()
        {
            InitializeComponent();
        }
        private void MainInterface_Load(object sender, EventArgs e)
        {
            //淡出特效隐藏
            if (Win32.AnimateWindow(this.Handle, 300, Win32.AW_BLEND | Win32.AW_HIDE))
            {
                //淡入特效显示
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_BLEND | Win32.AW_ACTIVATE);
            }
            //Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
            ZaiRu();
            lbYongHu.Text = string.Format("{0}（{1}）", QuanXuang, CaoZuoYuan);
            timer2.Start();
            btXiaoXi.BackgroundImage = imageList1.Images[0];
        }

        /// <summary>
        /// 打开主界面自动载入
        /// </summary>
        public void ZaiRu()
        {
            //调用实时时间
            timer1.Start();
            try
            {
                //清空lvFangJian数据
                if (lvFangJian.Items.Count > 0)
                {
                    lvFangJian.Items.Clear();
                }
                //查询所有房间信息
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID");

                FangJian(sql);//调用载入房间方法
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection(); //关闭数据库
            }


            //载入总房态信息
            try
            {
                //总房数
                string sql5 = string.Format(@"select count(*) from RoomTable");
                double cc5 = db.GetSingleIntValue(sql5);
                lbKeGong.Text = cc5.ToString();
                lbZongFangShu.Text = cc5.ToString();

                //可供房
                string sql = string.Format(@"select count(*) from RoomTable where StateID ='{0}'", 1);
                double cc = db.GetSingleIntValue(sql);
                lbKeGong.Text = cc.ToString();

                //占用房
                string sql1 = string.Format(@"select count(*) from RoomTable where StateID ='{0}'", 2);
                double cc1 = db.GetSingleIntValue(sql1);
                lbDaiKe.Text = cc1.ToString();

                //空脏房
                string sql4 = string.Format(@"select count(*) from RoomTable where StateID ='{0}'", 3);
                double cc4 = db.GetSingleIntValue(sql4);
                lbKongZang.Text = cc4.ToString();

                //预定房
                string sql2 = string.Format(@"select count(*) from RoomTable where StateID ='{0}'", 4);
                int cc2 = db.GetSingleIntValue(sql2);
                lbYuDing.Text = cc2.ToString();

                //停用房
                string sql3 = string.Format(@"select count(*) from RoomTable where StateID ='{0}'", 5);
                double cc3 = db.GetSingleIntValue(sql3);
                lbTingYong.Text = cc3.ToString();

                //占用率
                double zhanYongLv = ((cc1 + cc4 + cc2 + cc3) / cc5) * 100;
                pbJinDuTiao.Value = (int)zhanYongLv;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            //载入房价
            try
            {
                //标准单人房
                string sql1 = string.Format(@"select * from RoomTypeTable where ID='{0}'", 1);
                SqlDataReader dr1 = db.SelectDataReader(sql1);
                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        lbBZDanRen.Text = dr1[2].ToString();

                    }
                }
                dr1.Close();
                db.CloseConnection();
                //标准双人
                string sql2 = string.Format(@"select * from RoomTypeTable where ID='{0}'", 3);
                SqlDataReader dr2 = db.SelectDataReader(sql2);
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        lbBZShuangRen.Text = dr2[2].ToString();

                    }
                }
                dr1.Close();
                db.CloseConnection();
                //豪华单人
                string sql3 = string.Format(@"select * from RoomTypeTable where ID='{0}'", 2);
                SqlDataReader dr3 = db.SelectDataReader(sql3);
                if (dr3.HasRows)
                {
                    while (dr3.Read())
                    {
                        lbHHDanRen.Text = dr3[2].ToString();
                    }
                }
                dr1.Close();
                db.CloseConnection();
                //豪华双人
                string sql4 = string.Format(@"select * from RoomTypeTable where ID='{0}'", 4);
                SqlDataReader dr4 = db.SelectDataReader(sql4);
                if (dr4.HasRows)
                {
                    while (dr4.Read())
                    {
                        lbHHShuangRen.Text = dr4[2].ToString();
                    }
                }
                dr1.Close();
                db.CloseConnection();
                //商务套房
                string sql5 = string.Format(@"select * from RoomTypeTable where ID='{0}'", 5);
                SqlDataReader dr5 = db.SelectDataReader(sql5);
                if (dr5.HasRows)
                {
                    while (dr5.Read())
                    {
                        lbSWFang.Text = dr5[2].ToString();
                    }
                }
                dr1.Close();
                db.CloseConnection();
                //豪华单人
                string sql6 = string.Format(@"select * from RoomTypeTable where ID='{0}'", 6);
                SqlDataReader dr6 = db.SelectDataReader(sql6);
                if (dr6.HasRows)
                {
                    while (dr6.Read())
                    {
                        lbZTFang.Text = dr6[2].ToString();
                    }
                }
                dr1.Close();
                db.CloseConnection();
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
        /// //房间信息添加到lvFangJian控件里
        /// </summary>
        /// <param name="sql"></param>
        private void FangJian(string sql)
        {
            SqlDataReader dr = db.SelectDataReader(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //房间信息添加到lvFangJian控件里
                    if (dr["StateName"].ToString().Equals("空净"))
                    {
                        ListViewItem items = new ListViewItem(dr[0].ToString(), 0);
                        lvFangJian.Items.Add(items);
                    }
                    else if (dr["StateName"].ToString().Equals("待客"))
                    {
                        ListViewItem items = new ListViewItem(dr[0].ToString(), 1);
                        lvFangJian.Items.Add(items);
                    }
                    else if (dr["StateName"].ToString().Equals("空脏"))
                    {
                        ListViewItem items = new ListViewItem(dr[0].ToString(), 2);
                        lvFangJian.Items.Add(items);
                    }
                    else if (dr["StateName"].ToString().Equals("预定"))
                    {
                        ListViewItem items = new ListViewItem(dr[0].ToString(), 3);
                        lvFangJian.Items.Add(items);
                    }
                    else if (dr["StateName"].ToString().Equals("停用"))
                    {
                        ListViewItem items = new ListViewItem(dr[0].ToString(), 4);
                        lvFangJian.Items.Add(items);
                    }


                }
            }
        }


        /// <summary>
        /// 实时时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer 事件
            tbShiJian.Text = System.DateTime.Now.ToString();
            //已住时间
            if (lbZhuShiJian.Text != "无")
            {
                //DateTime xz = DateTime.Now;
                //TimeSpan dt = xz - Convert.ToDateTime(lbZhuShiJian.Text);
                //lbYongShiJian.Text = string.Format("{0}:{1}:{2}", dt.Hours.ToString(), dt.Minutes.ToString(), dt.Seconds.ToString()); 
                DateTime d1 = DateTime.Now;
                DateTime d2 = Convert.ToDateTime(lbZhuShiJian.Text);
                TimeSpan d3 = d1.Subtract(d2);
                lbYongShiJian.Text = string.Format("{0}天{1}小时{2}分{3}秒", d3.Days.ToString(), d3.Hours.ToString(), d3.Minutes.ToString(), d3.Seconds.ToString());
            }
            else
            {
                lbYongShiJian.Text = "无";
            }
        }

        private void skinButton7_Click(object sender, EventArgs e)
        {

        }

        private void skinButton5_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击房间显示相关信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public string DanHao;
        private void lvFangJian_SelectedIndexChanged(object sender, EventArgs e)
        {
            //载入相应入住房间的信息
            try
            {
                if (lvFangJian.SelectedItems.Count > 0)
                {
                    lbFangHao.Text = lvFangJian.SelectedItems[0].Text;
                    string sql = string.Format(@"select *
                                                from OrderTable
                                                where RoomID ='{0}' and State='{1}'", lbFangHao.Text, "新开单");
                    SqlDataReader dr = db.SelectDataReader(sql);
                    if (dr.HasRows)
                    {
                        //有入住时，载入相应的信息
                        while (dr.Read())
                        {
                            DanHao = dr[0].ToString();
                            lbXingMing.Text = dr["UName"].ToString();
                            lbNianLing.Text = dr["Age"].ToString();
                            lbZhuShiJian.Text = dr["CheckInTime"].ToString();
                            lbYuLiShiJian.Text = dr["PreDepartureTime"].ToString();
                            lbJinE.Text = dr["AmountReceived"].ToString();
                            lbDianHua.Text = dr["Phone"].ToString();
                            lbGuKeLeiXing.Text = dr["CustomerType"].ToString();
                            lbGongSi.Text = dr["CompanyName"].ToString();
                        }
                    }
                    else
                    {
                        //没人入住是，载入无
                        lbXingMing.Text = "无";
                        lbNianLing.Text = "无";
                        lbZhuShiJian.Text = "无";
                        lbYuLiShiJian.Text = "无";
                        lbJinE.Text = "无";
                        lbDianHua.Text = "无";
                        lbGuKeLeiXing.Text = "无";
                        lbGongSi.Text = "无";
                    }
                    dr.Close();
                }
                //查询房间价格楼层信息
                try
                {
                    if (lvFangJian.SelectedItems.Count > 0)
                    {
                        string sql = string.Format(@"select *
                                                    from RoomTable
                                                    inner join RoomTypeTable
                                                    on RoomTable.TypeID=RoomTypeTable.ID
                                                    where RoomTable.RoomID='{0}'", lbFangHao.Text);
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                lbLouCeng.Text = dr["Floor"].ToString();
                                lbYuShiJia.Text = dr["Price"].ToString();
                            }
                        }
                        dr.Close();
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
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            //查询入住表里的信息
            try
            {
                if (lvFangJian.SelectedItems.Count > 0)
                {
                    string sql = string.Format(@"select * 
                                                from[dbo].[CheckInTable]
                                                where RoomID='{0}'", lbFangHao.Text);
                    SqlDataReader dr = db.SelectDataReader(sql);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lbXingMing.Text = dr["UName"].ToString();
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
        /// <summary>
        /// 全部房间信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton2_Click(object sender, EventArgs e)
        {
            //清空lvFangJian数据
            if (lvFangJian.Items.Count > 0)
            {
                lvFangJian.Items.Clear();
            }
            ZaiRu();
        }
        /// <summary>
        /// 查询标准单人间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton3_Click(object sender, EventArgs e)
        {
            try
            {
                //清空lvFangJian数据
                if (lvFangJian.Items.Count > 0)
                {
                    lvFangJian.Items.Clear();
                }
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomTypeTable.ID ='{0}'", 1);
                FangJian(sql);
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
        /// 查询豪华单人间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //清空lvFangJian数据
                if (lvFangJian.Items.Count > 0)
                {
                    lvFangJian.Items.Clear();
                }
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomTypeTable.ID ='{0}'", 2);
                FangJian(sql);
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
        /// 查询标准双人间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton6_Click(object sender, EventArgs e)
        {
            try
            {
                //清空lvFangJian数据
                if (lvFangJian.Items.Count > 0)
                {
                    lvFangJian.Items.Clear();
                }
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomTypeTable.ID ='{0}'", 3);
                FangJian(sql);
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
        /// 查询豪华双人间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton11_Click(object sender, EventArgs e)
        {
            try
            {
                //清空lvFangJian数据
                if (lvFangJian.Items.Count > 0)
                {
                    lvFangJian.Items.Clear();
                }
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomTypeTable.ID ='{0}'", 4);
                FangJian(sql);
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
        /// 查询商务套房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton12_Click(object sender, EventArgs e)
        {
            try
            {
                //清空lvFangJian数据
                if (lvFangJian.Items.Count > 0)
                {
                    lvFangJian.Items.Clear();
                }
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomTypeTable.ID ='{0}'", 5);
                FangJian(sql);
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
        /// 查询总统套房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton13_Click(object sender, EventArgs e)
        {
            try
            {
                //清空lvFangJian数据
                if (lvFangJian.Items.Count > 0)
                {
                    lvFangJian.Items.Clear();
                }
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomTypeTable.ID ='{0}'", 6);
                FangJian(sql);
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

        ArrayList List = new ArrayList();//房间到期提醒
        ArrayList Lists = new ArrayList();//预定房间提前12小时修改房间状态
        ArrayList Lists1 = new ArrayList();//预定到期提醒
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                //房间到期提醒
                string sql = string.Format(@"select datediff( MI, getdate(), [PreDepartureTime] ),RoomID
                                from [dbo].[OrderTable]
                                where State ='新开单' and datediff( MI, getdate(), [PreDepartureTime] ) = 0");
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        List.Add(dr[1].ToString());
                        timer3.Enabled = true;
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
            string shiJians = DateTime.Now.ToShortDateString();
            for (int i = 0; i < List.Count; i++)
            {
                try
                {

                    string sql = string.Format(@"insert into RemindTable(RooID, Remind, Type, Time)
                            values('{0}','{1}','{2}','{3}')", List[i], "房间到期提醒", "未读", shiJians);
                    db.ExecuteSQLCommand(sql);
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
            List.Clear();

            try
            {
                //预定房间提前12小时修改房间状态
                string sql = string.Format(@"select *
                                    from PredeterminedTable
                                    where datediff( hh, getdate(), PreconditioningTime ) <= 12 and datediff( hh, getdate(), PreconditioningTime ) > 1 and Type = '预定中'");
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lists.Add(dr["RoomID"].ToString());
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
            for (int i = 0; i < Lists.Count; i++)
            {
                try
                {
                    string sql = string.Format(@"update [dbo].[RoomTable] set StateID = 4
                                            where RoomID = '{0}'", Lists[i]);
                    db.ExecuteSQLCommand(sql);
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
            Lists.Clear();

            try
            {
                //预定到期提醒
                string sql = string.Format(@"select *
                                    from PredeterminedTable
                                    where datediff( MI, getdate(), PreconditioningTime ) = 0 and Type = '预定中'");
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lists1.Add(dr["RoomID"].ToString());
                        timer3.Enabled = true;
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
            for (int i = 0; i < Lists1.Count; i++)
            {
                try
                {
                    string sql = string.Format(@"insert into RemindTable(RooID, Remind, Type, Time)
                            values('{0}','{1}','{2}','{3}')", Lists1[i], "预定到期提醒", "未读", shiJians);
                    db.ExecuteSQLCommand(sql);
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
            Lists1.Clear();
            ZaiRu();

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

        }

        private void 打扫房间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打扫房间
            if (lvFangJian.SelectedItems.Count > 0)
            {
                //循环打扫选中的房间
                for (int i = 0; i < lvFangJian.SelectedItems.Count; i++)
                {
                    if (lvFangJian.SelectedItems[i].ImageIndex == 2)
                    {
                        string sql = string.Format(@"update RoomTable set StateID=1
                                                            where RoomID='{0}'", lvFangJian.SelectedItems[i].Text);
                        db.ExecuteSQLCommand(sql);
                    }
                }
                ZaiRu();
            }


        }

        private void 修改房间状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyRoomStatus mr = new ModifyRoomStatus();
            if (lvFangJian.SelectedItems.Count > 0)
            {
                if (lvFangJian.SelectedItems[0].ImageIndex == 1)
                {
                    MessageBox.Show("待客房间不允许修改！");
                    return;
                }
                if (lvFangJian.SelectedItems[0].ImageIndex == 2)
                {
                    MessageBox.Show("空脏房请您先打扫！");
                    return;
                }
                if (lvFangJian.SelectedItems[0].ImageIndex == 3)
                {
                    MessageBox.Show("预定房间不允许修改！");
                    return;
                }
                mr.FangHao = lvFangJian.SelectedItems[0].Text;
            }
            mr.ShowDialog();
            ZaiRu();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //打开顾客散客开单
            BulkGuestOpening bg = new BulkGuestOpening();
            bg.CaoZuoYuan = CaoZuoYuan;
            //入住成功后刷新房间信息
            bg.ShowDialog();
            ZaiRu();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //打开结账窗口
            CheckOut che = new CheckOut();
            che.ShowDialog();
            ZaiRu();
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            RoomManagement rm = new RoomManagement();
            rm.ShowDialog();
            ZaiRu();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            TuiChu();

        }

        private void TuiChu()
        {
            //退出程序
            DialogResult aa = MessageBox.Show("您真的要离开我吗？", "提示", MessageBoxButtons.OKCancel);
            if (aa == DialogResult.OK)
            {
                Win32.AnimateWindow(this.Handle, 300, Win32.AW_HIDE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
                Application.Exit();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LockScreen ls = new LockScreen();
            ls.CaoZuoYuan = CaoZuoYuan;
            ls.ShowDialog();
            //Lock lk = new Lock();
            //lk.ShowDialog();
        }
        //关于
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            About ao = new About();
            ao.ShowDialog();
        }

        private void 换房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //换房
            if (lvFangJian.SelectedItems.Count > 0)   //判断是否选择
            {
                if (lvFangJian.SelectedItems[0].ImageIndex != 1)  //通过图片下表进行判断入住状态
                {
                    MessageBox.Show("该房间没人入住，不能换房！");
                    return;
                }
                ExchangeHouses eh = new ExchangeHouses();
                eh.FangHao = lvFangJian.SelectedItems[0].Text;
                eh.ShowDialog();
                ZaiRu();
            }

        }

        private void 续订ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFangJian.SelectedItems.Count > 0)   //判断是否选择
            {
                if (lvFangJian.SelectedItems[0].ImageIndex != 1) //通过图片下表进行判断入住状态
                {
                    MessageBox.Show("该房间没有客人入住，不允许续房！");
                    return;
                }
                ContinuedRoomcs cr = new ContinuedRoomcs();
                cr.FangHao = lvFangJian.SelectedItems[0].Text;
                cr.ShowDialog();
                ZaiRu();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement();
            cm.ShowDialog();
            ZaiRu();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            CommodityManagement cm = new CommodityManagement();
            cm.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            SystemSetup ss = new SystemSetup();
            ss.Show();
        }

        private void 补录信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvFangJian.SelectedItems.Count > 0)   //判断是否选择
            {
                if (lvFangJian.SelectedItems[0].ImageIndex != 1)    //通过图片下表进行判断入住状态
                {
                    MessageBox.Show("该房间没有客人入住！");
                    return;
                }
                else
                {
                    CheckIn ci = new CheckIn();
                    ci.DingDan = DanHao;
                    ci.CaoZuoYuan = CaoZuoYuan;
                    ci.FangHao = lvFangJian.SelectedItems[0].SubItems[0].Text;
                    ci.yuLi = lbYuLiShiJian.Text;
                    ci.ruZhu = lbZhuShiJian.Text;
                    ci.ShowDialog();
                    ZaiRu();
                }
            }
            else
            {
                MessageBox.Show("请选择房间！");
            }

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            BusinessInquiries bi = new BusinessInquiries();
            bi.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PredeterminedManagement pm = new PredeterminedManagement();
            pm.ShowDialog();
            ZaiRu();
        }
        int ii = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {

            if (ii == 0)
            {
                btXiaoXi.BackgroundImage = imageList1.Images[ii];
                ii++;
            }
            else
            {
                btXiaoXi.BackgroundImage = null;
                ii = 0;
            }

        }

        private void btXiaoXi_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            btXiaoXi.BackgroundImage = imageList1.Images[0];
            Remind rd = new Remind();
            rd.Show();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            EmployeeManagement em = new EmployeeManagement();
            em.ShowDialog();
        }

        private void MainInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HIDE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
            Application.Exit();
        }

        private void 入住查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsOfOccupancy doo = new DetailsOfOccupancy();
            doo.ShowDialog();
        }
    }
}
