using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCWin;

namespace S1Hotel
{
    public partial class CheckIn : CCSkinMain
    {
        //操作员
        public string CaoZuoYuan { get; set; }
        //应用DBHelper类
        private DBHelper db = new DBHelper();
        //房号
        public string FangHao { get; set; }
        //订单号
        public string DingDan { get; set; }
        //入住时间和预离时间
        public string ruZhu { get; set; }
        public string yuLi { get; set; }

        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {
            tbFangHao.Text = FangHao;
            lbTiShi.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (tbXingMing.Text.Equals("") || tbFangHao.Text.Equals("") || tbShengFengZheng.Text.Equals(""))
            {
                MessageBox.Show("文本框均不能为空");
                return;
            }
            try
            {   //导入入住表
                string sql = string.Format(@"insert into CheckInTable(OrderID, UName, CarID, RoomID, CheckInTime, PreDepartureTime, Operator)
            values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", DingDan, tbXingMing.Text, tbShengFengZheng.Text, tbFangHao.Text, ruZhu, yuLi, CaoZuoYuan);
                int a = db.ExecuteSQLCommand(sql);
                if ((a > 0))
                {
                    string tiShi = string.Format("{0}顾客入住信息添加成功！", tbFangHao.Text);
                    MessageBox.Show(tiShi);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("新增到入住表失败");
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


            //判断是否是新顾客
            if (tbGuKe.Text.Equals("是"))
            {
                try
                {
                    //新顾客余额为0
                    string yuE = "0";
                    string sex = "";
                    if (rbNan.Checked)
                    {
                        sex = "男";
                    }
                    else
                    {
                        sex = "女";
                    }
                    //将顾客信息新增顾客表
                    string sql = string.Format(@"insert into CustomerTable(Name, CarID, Phone, Balance, Type, Sex, Age)
                                          values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", tbXingMing.Text, tbShengFengZheng.Text, tbDianHua.Text, yuE, 1, sex, tbNianLing.Text);
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
                //查询房卡是否已激活
                string sql = string.Format(@"select count(*)
                                        from [dbo].[RoomIDCard]
                                        where RoomID = '{0}'", tbFangHao.Text);
                if (db.GetSingleIntValue(sql) == 0)
                {
                    //激活房卡
                    Activation at = new Activation();
                    at.FangHao = tbFangHao.Text;
                    at.ShowDialog();
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
            //            try
            //            {
            //                string sql = string.Format(@"insert into RoomIDCard(RoomID, RoomCard)
            //                                            values('{0}','{1}')",FangHao,tbFangKa.Text);
            //                int a = db.ZengShanGaiCha(sql);
            //                if (a>0)
            //                {
            //                    string aaac = string.Format("激活成功！房号为：{0}，房卡为：{1}",FangHao,tbFangKa.Text);
            //                    MessageBox.Show(aaac);
            //                }
            //                else
            //                {
            //                    string aaac = string.Format("{0}房卡激活失败！", FangHao);
            //                    MessageBox.Show(aaac);
            //                }
            //            }
            //            catch (Exception ee)
            //            {
            //                MessageBox.Show(ee.Message);
            //            }
            //            finally
            //            {
            //                db.GuanBi();
            //            }




            //            try
            //            {
            //                //修改房间信息
            //                string sql = string.Format(@"update OrderTable set [UName]='{0}',[Age]='{1}',[Phone]='{2}',[CustomerType]='{3}',[Address]='{4}'
            //                                                where [RoomID]='{5}'",tbXingMing.Text,tbNianLing.Text,tbDianHua.Text,cbLeiXing.Text,tbDiZhi.Text,tbFangHao.Text);
            //                int a = db.ZengShanGaiCha(sql);
            //                if (!(a>0))
            //                {
            //                    MessageBox.Show("修改失败！");
            //                }
            //            }
            //            catch (Exception ee)
            //            {
            //                MessageBox.Show(ee.Message);
            //            }
            //            finally
            //            {
            //                db.GuanBi();
            //            }

        }

        private void tbShengFengZheng_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShengFengZheng()
        {
            if (tbShengFengZheng.Text == "")
            {
                return;
            }
            if (tbShengFengZheng.Text.Length == 18 || tbShengFengZheng.Text.Length == 15)
            {


                if ((!Regex.IsMatch(tbShengFengZheng.Text, @"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
                {
                    lbTiShi.Text = "请输入合法身份证";
                    return;
                }
                else
                {
                    lbTiShi.Text = "";
                }
                string diQu = "";
                string birthday = "";
                string sex = "";

                //18位身份证判定
                if (tbShengFengZheng.Text.Length == 18)
                {
                    //获取出生年月日和性别代码和地区
                    birthday = tbShengFengZheng.Text.Substring(6, 4) + "-" + tbShengFengZheng.Text.Substring(10, 2) + "-" + tbShengFengZheng.Text.Substring(12, 2);
                    sex = tbShengFengZheng.Text.Substring(14, 3);
                    diQu = tbShengFengZheng.Text.Substring(0, 4);
                }

                //15位身份证判定
                if (tbShengFengZheng.Text.Length == 15)
                {
                    birthday = "19" + tbShengFengZheng.Text.Substring(6, 2) + "-" + tbShengFengZheng.Text.Substring(8, 2) + "-" + tbShengFengZheng.Text.Substring(10, 2);
                    sex = tbShengFengZheng.Text.Substring(12, 3);
                }

                //性别代码为偶数是女性奇数为男性
                if (int.Parse(sex) % 2 == 0)
                {
                    rbNan.Checked = true;
                    rbNan.Checked = false;
                }
                else if (int.Parse(sex) % 2 == 1)
                {
                    rbNan.Checked = false;
                    rbNan.Checked = true;
                }
                //用出生日期计算出年龄
                DateTime birth = DateTime.Parse(birthday);
                DateTime now = DateTime.Now;
                int age = now.Year - birth.Year;
                string nianLing = age.ToString();
                tbNianLing.Text = nianLing;

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
                    string sql = string.Format(@"select * from CustomerTable inner join CustomerTypeTable on CustomerTable.Type=CustomerTypeTable.ID where CustomerTable.CarID='{0}'", tbShengFengZheng.Text);
                    SqlDataReader dr = db.SelectDataReader(sql);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cbLeiXing.Text = dr["Grade"].ToString();
                        }
                        tbGuKe.Text = "否";
                    }
                    else
                    {
                        cbLeiXing.Text = "普通用户";
                        tbGuKe.Text = "是";
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

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbShengFengZheng_MouseLeave(object sender, EventArgs e)
        {
            ShengFengZheng();
        }
    }
}
