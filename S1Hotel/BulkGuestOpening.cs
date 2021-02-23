using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCWin;

namespace S1Hotel
{
    public partial class BulkGuestOpening : CCSkinMain
    {
        public string CaoZuoYuan = "1";
        //应用DBHelper类
        private DBHelper db = new DBHelper();
        //  List<string> list = new List<string>();

        public string YuDingDan { get; set; }
        public BulkGuestOpening()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 退出本窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btQuXiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        static string str = @"Data Source=.;Initial Catalog=S1Hotel;Integrated Security=True";
        SqlConnection con = new SqlConnection(str);
        private void BulkGuestOpening_Load(object sender, EventArgs e)
        {
            ZaiRuKongJinFang();
            ZaiRuFangJianLeiXing();
            ShengChengID();
            cbFuKuangFangShi.SelectedIndex = 0;
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
            //当预定单不为空的时候执行
            if (YuDingDan != null)
            {
                try
                {
                    string sql = string.Format(@"select *
                                                from [dbo].[PredeterminedTable]
                                                where reservationNumber = '{0}'", YuDingDan);
                    SqlDataReader dr = db.SelectDataReader(sql);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tbXingMing.Text = dr["Name"].ToString();
                            tbDianHua.Text = dr["Phone"].ToString();
                            ListViewItem items = new ListViewItem(dr["RoomID"].ToString());
                            items.SubItems.Add(dr["RoomType"].ToString());
                            items.SubItems.Add(dr["Price"].ToString());
                            lvYiXuang.Items.Add(items);
                            tpRuZhu.Text = dr["PreconditioningTime"].ToString();
                            tpYuLi.Text = dr["PreDepartureTime"].ToString();
                        }
                        JiSuanJiaGe();
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
        /// <summary>
        /// //自动生成id 格式为 20181018001 
        /// </summary>
        private void ShengChengID()
        {
            //自动生成id 格式为 20181018001 
            try
            {
                string danHao = "";
                string today = DateTime.Now.ToString("yyyyMMdd");
                string sql = string.Format(@"select MAX([OrderID])
                                                from OrderTable
                                            where OrderID like '{0}%'", today);
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
        /// <summary>
        /// 载入房间类型
        /// </summary>
        private void ZaiRuFangJianLeiXing()
        {
            if (YuDingDan != null)
            {
                return;
            }
            string sql = string.Format(@"select * from RoomTypeTable");
            string biaoMing = "LeiXing";
            try
            {
                DataSet ds = db.GetDataSet(sql, biaoMing);
                DataRow row = ds.Tables[biaoMing].NewRow();
                row["ID"] = -1;
                row["TypeName"] = "全部";
                ds.Tables[biaoMing].Rows.InsertAt(row, 0);
                cbFangJianLeiXing.DataSource = ds.Tables[biaoMing];
                cbFangJianLeiXing.ValueMember = "ID";
                cbFangJianLeiXing.DisplayMember = "TypeName";
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
        /// 载入空净房
        /// </summary>
        private void ZaiRuKongJinFang()
        {
            if (YuDingDan != null)
            {
                return;
            }
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
												where RoomStateTable.ID=1");
            //载入所选空净房间类型数据
            if (cbFangJianLeiXing.Text != "全部")
            {
                sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID
												where RoomStateTable.ID=1 and RoomTypeTable.TypeName='{0}'", cbFangJianLeiXing.Text);
            }
            try
            {
                SqlDataReader dr = db.SelectDataReader(sql); ;
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
                dr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
                db.CloseConnection();
            }
            YiChuFangJian();
            YiChuFangJian();
            YiChuFangJian();
        }
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
                                        from [dbo].[PredeterminedTable]
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
        private void cbFangJianLeiXing_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZaiRuKongJinFang();
        }
        /// <summary>
        /// 身份证验证
        /// </summary>
        private void SFZYanZheng()
        {
            if (tbShengFenngZheng.Text == "")
            {
                ttMsg.Hide(tbShengFenngZheng);
            }
            if ((!Regex.IsMatch(tbShengFenngZheng.Text, @"^(\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
            {
                tbNianLing.Text = "";
                tbDiZhi.Text = "";
                //气泡提示
                ttMsg.Show("请输入合法身份证！", tbShengFenngZheng);
                return;
            }
            ttMsg.Hide(tbShengFenngZheng);
            string diQu = "";
            string birthday = "";
            string sex = "";
            //18位身份证判定
            if (tbShengFenngZheng.Text.Length == 18)
            {
                //获取出生年月日和性别代码和地区
                birthday = tbShengFenngZheng.Text.Substring(6, 4) + "-" + tbShengFenngZheng.Text.Substring(10, 2) + "-" + tbShengFenngZheng.Text.Substring(12, 2);
                sex = tbShengFenngZheng.Text.Substring(14, 3);
                diQu = tbShengFenngZheng.Text.Substring(0, 4);
            }
            //性别代码为偶数是女性奇数为男性
            if (int.Parse(sex) % 2 == 0)
            {
                rbNan.Checked = false;
                rbNv.Checked = true;

            }
            else if (int.Parse(sex) % 2 == 1)
            {
                rbNan.Checked = true;
                rbNv.Checked = false;
            }
            //用出生日期计算出年龄
            DateTime birth = DateTime.Parse(birthday);
            DateTime now = DateTime.Now;
            int age = now.Year - birth.Year;
            tbNianLing.Text = age.ToString();
            int a = int.Parse(diQu);
            StringBuilder stbuff = new StringBuilder();
            stbuff.Append("湖南省");
            switch (a)
            {
                case 4301:
                    stbuff.Append("长沙市");
                    break;
                case 4302:
                    stbuff.Append("株洲市");
                    break;
                case 4303:
                    stbuff.Append("湘潭市");
                    break;
                case 4304:
                    stbuff.Append("衡阳市");
                    break;
                case 4305:
                    stbuff.Append("邵阳市");
                    break;
                case 4306:
                    stbuff.Append("岳阳市");
                    break;
                case 4307:
                    stbuff.Append("常德市");
                    break;
                case 4308:
                    stbuff.Append("张家界市");
                    break;
                case 4309:
                    stbuff.Append("益阳市");
                    break;
                case 4310:
                    stbuff.Append("郴州市");
                    break;
                case 4311:
                    stbuff.Append("永州市");
                    break;
                case 4312:
                    stbuff.Append("怀化市");
                    break;
                case 4313:
                    stbuff.Append("娄底市");
                    break;
                case 4325:
                    stbuff.Append("娄底地区");
                    break;
                case 4331:
                    stbuff.Append("湘西");
                    break;
                default:
                    tbDiZhi.Text = "暂时未录入此地区";
                    break;
            }
            tbDiZhi.Text = stbuff.ToString();

            //用身份证号查询是否有此顾客，以及他的会员等级

            try
            {
                string sql = string.Format(@"select * from CustomerTable inner join CustomerTypeTable on CustomerTable.Type=CustomerTypeTable.ID where CustomerTable.CarID='{0}'", tbShengFenngZheng.Text);
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader dr = com.ExecuteReader();
                //判断此顾客是否在本店住过
                if (dr.HasRows)
                {
                    //不是新顾客
                    while (dr.Read())
                    {
                        tbXingMing.Text = dr["Name"].ToString();
                        tbDianHua.Text = dr["Phone"].ToString();
                        tbLeiXing.Text = dr["Grade"].ToString();
                        tbZhangHuYuE.Text = dr["Balance"].ToString();
                        //折扣
                        if (dr["Discount"].ToString().Equals("不打折"))
                        {
                            tbZhiKou.Text = dr["Discount"].ToString();
                        }
                        else
                        {
                            double zheKou = double.Parse(dr["Discount"].ToString()) * 10;
                            tbZhiKou.Text = zheKou.ToString() + "折";
                        }
                    }
                    tbGuKe.Text = "否";
                }
                else
                {

                    //新顾客
                    tbLeiXing.Text = "普通用户";
                    tbZhiKou.Text = "不打折";
                    if (YuDingDan == null)
                    {
                        tbXingMing.Text = "";
                        tbDianHua.Text = "";
                    }
                    tbGuKe.Text = "是";
                }
                con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                con.Close();
                db.CloseConnection();
            }
        }
        private void tbShengFenngZheng_TextChanged(object sender, EventArgs e)
        {
            SFZYanZheng();
        }

        private void tbLeiXing_TextChanged(object sender, EventArgs e)
        {
            HuiYuanShiJian();
        }

        private void HuiYuanShiJian()
        {
            if (tbLeiXing.Text == "")
            {
                return;
            }
            if (YuDingDan != null)
            {
                return;
            }
            //根据会员类型的不同，预离时间不同！
            switch (tbLeiXing.Text)
            {
                case "钻石会员":
                    tpYuLi.Text = DateTime.Now.AddDays(1).ToShortDateString() + " 14:00:00";
                    break;
                case "陨石会员":
                    tpYuLi.Text = DateTime.Now.AddDays(1).ToShortDateString() + " 16:00:00";
                    break;
                case "黄金会员":
                    tpYuLi.Text = DateTime.Now.AddDays(1).ToShortDateString() + " 13:00:00";
                    break;
                case "普通用户":
                    tpYuLi.Text = DateTime.Now.AddDays(1).ToShortDateString() + " 12:00:00";
                    break;
            }
        }
        private void lvKongJingFang_DoubleClick(object sender, EventArgs e)
        {
            //双击未预定的房间中的listview 跳到已预定的listview
            ListViewItem list = lvKongJingFang.SelectedItems[0];
            //cbFangJianLeiXing.Text = lvKongJingFang.SelectedItems[0].SubItems[1].Text;
            lvKongJingFang.Items.Remove(list);
            lvYiXuang.Items.Add(list);
            tpYuLi.Enabled = false;
            JiSuanJiaGe();
        }

        private void JiSuanJiaGe()
        {
            try
            {
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
                //计算应收金额
                if (tbZhiKou.Text.Equals("不打折"))
                {
                    tbYingShou.Text = tbZongJia.Text;
                }
                else
                {
                    tbYingShou.Text = (Convert.ToDouble(tbZongJia.Text) * Convert.ToDouble(tbZhiKou.Text.Substring(0, 1)) / 10).ToString();
                }

                if (tbXiangJin.Text == "" || tbYuEFuKuan.Text == "")
                {
                    return;
                }
                //选择支付方式！
                if (cbFuKuangFangShi.Text == "现金支付")
                {
                    tbYuEFuKuan.Enabled = false;
                    tbXiangJin.Enabled = true;
                    tbZhaoLing.Text = (Convert.ToDouble(tbXiangJin.Text) - Convert.ToDouble(tbYingShou.Text)).ToString();
                    tbYuEFuKuan.Text = "0";
                }
                else if (cbFuKuangFangShi.Text == "账户余额")
                {
                    //余额不足不让选择
                    if ((Convert.ToDouble(tbZhangHuYuE.Text) < Convert.ToDouble(tbYingShou.Text)) || (Convert.ToDouble(tbZhangHuYuE.Text) == 0))
                    {
                        MessageBox.Show("余额不足！请选择现金支付或现金+余额的支付方式支付！");
                        cbFuKuangFangShi.Text = "现金支付";
                        return;
                    }
                    tbYuEFuKuan.Enabled = false;
                    tbXiangJin.Enabled = false;
                    //余额直接付应付
                    tbYuEFuKuan.Text = tbYingShou.Text;
                    tbZhaoLing.Text = "0";
                    tbXiangJin.Text = "0";
                }
                else
                {
                    //余额不足不让选择
                    if (Convert.ToDouble(tbZhangHuYuE.Text) == 0)
                    {
                        MessageBox.Show("余额为0，请选择现金支付！");
                        cbFuKuangFangShi.Text = "现金支付";
                        return;
                    }
                    tbYuEFuKuan.Enabled = true;
                    tbXiangJin.Enabled = true;
                    tbZhaoLing.Text = (Convert.ToDouble(tbXiangJin.Text) - Convert.ToDouble(tbYingShou.Text) + Convert.ToDouble(tbYuEFuKuan.Text)).ToString();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        private void lvYiXuang_DoubleClick(object sender, EventArgs e)
        {
            //双击已预定的房间中的listview 跳到未预定的listview
            ListViewItem list = lvYiXuang.SelectedItems[0];
            lvYiXuang.Items.Remove(list);
            lvKongJingFang.Items.Add(list);
            if (lvYiXuang.Items.Count == 0)
            {
                tpYuLi.Enabled = true;
            }
            JiSuanJiaGe();
        }
        /// <summary>
        /// 手机号码框只能输入数字！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDianHua_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (tbDianHua.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(tbDianHua.Text, out oldf);
                    b2 = float.TryParse(tbDianHua.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
        /// <summary>
        /// 手机号码验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDianHua_TextChanged(object sender, EventArgs e)
        {
            if (tbDianHua.Text != "")
            {
                Regex rx = new Regex(@"^0{0,1}(13[0-9]|15[5-9]|15[0-2]|18[7-8]|17[6-8])[0-9]{8}$");
                if (!rx.IsMatch(tbDianHua.Text)) //不匹配
                {
                    //显示气泡提示
                    ttMsg.Show("手机号码不合法!", tbDianHua);
                    return;
                }
            }
            //隐藏气泡提示
            ttMsg.Hide(tbDianHua);
        }

        /// <summary>
        /// 计算天数，预离时间必须大于入住
        /// </summary>
        public int tianShu = 1;
        private void tpYuLi_ValueChanged(object sender, EventArgs e)
        {
            //预离时间必须大于入住
            DateTime dt1 = Convert.ToDateTime(tpRuZhu.Text);
            DateTime dt2 = Convert.ToDateTime(tpYuLi.Text);
            TimeSpan ts1 = dt2.Subtract(dt1);
            if (dt1 > dt2)
            {
                MessageBox.Show("预离时间必须大于入住时间!");
                HuiYuanShiJian();
                return;
            }
            if (ts1.Days == 0)
            {
                if (ts1.Hours > 12)
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
            JiSuanJiaGe();
        }
        private void tbShiShou_TextChanged(object sender, EventArgs e)
        {
            JiSuanJiaGe();
        }
        private void cbFuKuangFangShi_SelectedIndexChanged(object sender, EventArgs e)
        {
            JiSuanJiaGe();
        }

        private void tbXiangJin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //第一步：判断输入的是否是数字——char.IsNumber(e.KeyChar)
            //如果是数字，可以输入（e.Handled = false;）
            //如果不是数字，则判断是否是小数点
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //判断输入的是否是小数点，或中文状态下的句号，或者是退格键
                //如果是小数点，循环判断每个字符是不是小数点，如果存在不能输入，如果不存在允许输入
                //如果是退格键，允许输入——if (e.KeyChar == '\b')
                //如果不是小数点也不是退格键，不允许输入
                if (e.KeyChar == Convert.ToChar("。") || e.KeyChar == Convert.ToChar("."))
                {

                    int i_d = 0;
                    for (int i = 0; i < tbXiangJin.Text.Length; i++)
                    {
                        if (tbXiangJin.Text.Substring(i, 1) == ".")
                        {
                            e.Handled = true;
                            i_d++;
                            return;
                        }
                    }
                    if (i_d == 0)
                    {
                        e.KeyChar = Convert.ToChar(".");//设置按键输入的值为"."
                        e.Handled = false;
                    }
                }
                else if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            }
        }
        private void tbYuEFuKuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //第一步：判断输入的是否是数字——char.IsNumber(e.KeyChar)
            //如果是数字，可以输入（e.Handled = false;）
            //如果不是数字，则判断是否是小数点
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //判断输入的是否是小数点，或中文状态下的句号，或者是退格键
                //如果是小数点，循环判断每个字符是不是小数点，如果存在不能输入，如果不存在允许输入
                //如果是退格键，允许输入——if (e.KeyChar == '\b')
                //如果不是小数点也不是退格键，不允许输入
                if (e.KeyChar == Convert.ToChar("。") || e.KeyChar == Convert.ToChar("."))
                {
                    int i_d = 0;
                    for (int i = 0; i < tbYuEFuKuan.Text.Length; i++)
                    {
                        if (tbYuEFuKuan.Text.Substring(i, 1) == ".")
                        {
                            e.Handled = true;
                            i_d++;
                            return;
                        }
                    }
                    if (i_d == 0)
                    {
                        e.KeyChar = Convert.ToChar(".");//设置按键输入的值为"."
                        e.Handled = false;
                    }
                }
                else if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            }
        }
        private void tbYuEFuKuan_TextChanged(object sender, EventArgs e)
        {
            if (tbYuEFuKuan.Text == "")
            {
                return;
            }
            if (Convert.ToDouble(tbYuEFuKuan.Text) > Convert.ToDouble(tbZhangHuYuE.Text))
            {
                MessageBox.Show("余额不足！请充值！");
                //当我的余额大于当前金额余额付款就等于应付的钱
                if (Convert.ToDouble(tbZhangHuYuE.Text) >= Convert.ToDouble(tbYingShou.Text))
                {
                    tbYuEFuKuan.Text = tbYingShou.Text;
                }
                if (Convert.ToDouble(tbZhangHuYuE.Text) < Convert.ToDouble(tbYingShou.Text))
                {
                    tbYuEFuKuan.Text = tbZhangHuYuE.Text;
                }
            }
            if (Convert.ToDouble(tbYuEFuKuan.Text) > Convert.ToDouble(tbYingShou.Text))
            {
                MessageBox.Show("余额付款不能大于应收金额！");
                tbYuEFuKuan.Text = tbYingShou.Text;
            }
            JiSuanJiaGe();
        }

        private void btQueDing_Click(object sender, EventArgs e)
        {
            if (tbXingMing.Text.Equals("") || tbShengFenngZheng.Text.Equals("") || tbNianLing.Text.Equals(""))
            {
                MessageBox.Show("请认真填写所有信息！");
                return;
            }
        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (tbXingMing.Text.Equals("") || tbNianLing.Text.Equals("") || tbShengFenngZheng.Text.Equals(""))
            {
                MessageBox.Show("抱歉！请认真填写所有信息！");
                return;
            }
            if (Convert.ToDouble(tbZhaoLing.Text) < 0)
            {
                MessageBox.Show("抱歉！实付金额不足！");
                return;
            }
            if (lvYiXuang.Items.Count == 0)
            {
                MessageBox.Show("抱歉！请选择入住房间！");
                return;
            }
            string sex = "男";
            if (rbNv.Checked)
            {
                sex = "女";
            }
            //将新顾客信息新增到顾客表
            if (tbGuKe.Text.Equals("是"))
            {
                try
                {
                    //新顾客余额为0
                    string yuE = "0";
                    //将顾客信息新增顾客表
                    string sql = string.Format(@"insert into CustomerTable(Name, CarID, Phone, Balance, Type, Sex, Age)
                                values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", tbXingMing.Text, tbShengFenngZheng.Text, tbDianHua.Text, yuE, "1", sex, tbNianLing.Text);
                    if (db.ExecuteSQLCommand(sql) > 0)
                    {
                        //新增成功
                    }
                    else
                    {
                        MessageBox.Show("顾客信息填入顾客表失败");
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
            try
            {
                //获取已选房间数
                int a = lvYiXuang.Items.Count;
                int fangShu = 0;
                //循环输入已选房间
                for (int i = 0; i < a; i++)
                {
                    string FangJianHao = lvYiXuang.Items[i].Text.ToString();
                    try
                    {
                        string sql = "";
                        double zheKou = 1;
                        if (tbZhiKou.Text != "不打折")
                        {
                            zheKou = Convert.ToDouble(tbZhiKou.Text.Substring(0, 1)) / 10;
                        }
                        double FangJias = Convert.ToDouble(lvYiXuang.Items[i].SubItems[2].Text);

                        //在订单表中插入相应数据
                        if (cbFuKuangFangShi.Text == "现金支付")
                        {
                            sql = string.Format(@"insert into [dbo].[OrderTable](OrderID, RoomID, UName, Age, Deposit, CheckInTime, PreDepartureTime, Phone, CustomerType, CompanyName, Remarks, State, Address, Discounts, AmountReceived, PaymentMethod, Operator, Price)
                                        values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')"
                            , tbDingDanHao.Text, FangJianHao, tbXingMing.Text, tbNianLing.Text, "0", tpRuZhu.Text, tpYuLi.Text, tbDianHua.Text, tbLeiXing.Text, FangJias * zheKou, tbBeiZhu.Text, "新开单", tbDiZhi.Text, tbZhiKou.Text, FangJias * zheKou, cbFuKuangFangShi.Text, CaoZuoYuan, FangJias);

                        }
                        else if (cbFuKuangFangShi.Text == "账户余额")
                        {
                            sql = string.Format(@"insert into [dbo].[OrderTable](OrderID, RoomID, UName, Age, Deposit, CheckInTime, PreDepartureTime, Phone, CustomerType, CompanyName, Remarks, State, Address, Discounts, AmountReceived, PaymentMethod, Operator, Price)
                                        values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')"
                        , tbDingDanHao.Text, FangJianHao, tbXingMing.Text, tbNianLing.Text, FangJias * zheKou, tpRuZhu.Text, tpYuLi.Text, tbDianHua.Text, tbLeiXing.Text, "0", tbBeiZhu.Text, "新开单", tbDiZhi.Text, tbZhiKou.Text, FangJias * zheKou, cbFuKuangFangShi.Text, CaoZuoYuan, FangJias);
                        }
                        else if (cbFuKuangFangShi.Text == "现金+余额")
                        {
                            double xianJins = Convert.ToDouble(tbXiangJin.Text) / lvYiXuang.Items.Count;
                            double yuEss = Convert.ToDouble(tbYuEFuKuan.Text) / lvYiXuang.Items.Count;
                            sql = string.Format(@"insert into [dbo].[OrderTable](OrderID, RoomID, UName, Age, Deposit, CheckInTime, PreDepartureTime, Phone, CustomerType, CompanyName, Remarks, State, Address, Discounts, AmountReceived, PaymentMethod, Operator, Price)
                                        values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')"
                        , tbDingDanHao.Text, FangJianHao, tbXingMing.Text, tbNianLing.Text, yuEss, tpRuZhu.Text, tpYuLi.Text, tbDianHua.Text, tbLeiXing.Text, xianJins, tbBeiZhu.Text, "新开单", tbDiZhi.Text, tbZhiKou.Text, xianJins + yuEss, cbFuKuangFangShi.Text, CaoZuoYuan, FangJias);
                        }


                        if (db.ExecuteSQLCommand(sql) > 0)
                        {
                            fangShu++;
                            //修改房间状态
                            sql = string.Format(@"update RoomTable set StateID = 2
                                                where RoomID ='{0}'", FangJianHao);
                            if (db.ExecuteSQLCommand(sql) == 0)
                            {
                                MessageBox.Show("修改房间状态失败，请手动修改！");
                            }
                        }
                        else
                        {
                            MessageBox.Show("入住失败！");
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
                if (fangShu == a)
                {
                    MessageBox.Show("入住成功！");
                    Activation at = new Activation();
                    at.FangHao = lvYiXuang.Items[0].Text.ToString();
                    at.ShowDialog();
                    //语音提示
                    string YuYinTiShi = string.Format("找零{0}元", tbZhaoLing.Text);
                    SpeechSynthesizer synth = new SpeechSynthesizer();
                    synth.Speak(YuYinTiShi);
                    if (YuDingDan != null)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE | Win32.AW_HIDE | Win32.AW_SLIDE);
                    this.Close();
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

        private void tsmiTianjia_Click(object sender, EventArgs e)
        {
            //打开补录信息窗口
            if (lvYiXuang.SelectedItems.Count > 0)
            {
                CheckIn Ci = new CheckIn();
                Ci.CaoZuoYuan = CaoZuoYuan;
                Ci.FangHao = lvYiXuang.SelectedItems[0].SubItems[0].Text;
                Ci.DingDan = tbDingDanHao.Text;
                Ci.ruZhu = tpRuZhu.Text;
                Ci.yuLi = tpYuLi.Text;
                if (Ci.ShowDialog() == DialogResult.OK)
                {
                    lvYiXuang.SelectedItems[0].ForeColor = Color.Red;
                }
            }
        }

        private void lvYiXuang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvKongJingFang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbGuKe_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            ZaiRuKongJinFang();
            tpYuLi.Enabled = false;
            tbBeiZhu.Enabled = false;
        }




    }
}
