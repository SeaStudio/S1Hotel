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
    public partial class CommodityModification : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public CommodityModification()
        {
            InitializeComponent();
        }
        public string MingCheng;

        private void CommodityModification_Load(object sender, EventArgs e)
        {

            try
            {
                string sql = string.Format(@"select * 
                            from [dbo].[CommodityType]");
                DataSet ds = db.GetDataSet(sql, "LeiXing");
                cbLeiXing.DataSource = ds.Tables["LeiXing"];
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
            ZaiRuShangPingXinXi();
        }
        private int shuLiang;
        private void ZaiRuShangPingXinXi()
        {
            try
            {
                tbMingCheng.Text = MingCheng;
                string sql = string.Format(@"select*
                                            FROM Commodity
                                            inner join CommodityType
                                            on Commodity.Type = CommodityType.ID where Commodity.Name='{0}'", MingCheng);
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tbDanWei.Text = dr[1].ToString();
                        tbShuLiang.Text = dr[2].ToString();
                        shuLiang = Convert.ToInt32(dr[2].ToString());
                        tbJinHuoJia.Text = dr[3].ToString();
                        tbLingShouJia.Text = dr[4].ToString();
                        cbLeiXing.Text = dr["TypeName"].ToString();
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

        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (tbShuLiang.Text == "")
            {
                MessageBox.Show("数量不能为空!","提示");
                tbShuLiang.Text = shuLiang.ToString();
                return;
            }
            try
            {
                string sql = string.Format(@"update Commodity set Name='{0}', Company='{1}', Number='{2}', BuyingPrice='{3}', RetailPrice='{4}', Type='{5}'
                                where Name ='{6}'", tbMingCheng.Text, tbDanWei.Text, tbShuLiang.Text, tbJinHuoJia.Text, tbLingShouJia.Text, cbLeiXing.SelectedValue, MingCheng);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("修改成功","提示");
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

        private void tbShuLiang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void tbJinHuoJia_KeyPress(object sender, KeyPressEventArgs e)
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
                    for (int i = 0; i < tbJinHuoJia.Text.Length; i++)
                    {
                        if (tbJinHuoJia.Text.Substring(i, 1) == ".")
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

        private void tbLingShouJia_KeyPress(object sender, KeyPressEventArgs e)
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
                    for (int i = 0; i < tbLingShouJia.Text.Length; i++)
                    {
                        if (tbLingShouJia.Text.Substring(i, 1) == ".")
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

        private void skinButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbShuLiang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbShuLiang_MouseLeave(object sender, EventArgs e)
        {
            if (tbShuLiang.Text != "")
            {
                int xinShuLiang = Convert.ToInt32(tbShuLiang.Text);
                if (xinShuLiang < shuLiang)
                {
                    MessageBox.Show("数量只能加，不能减！");
                    tbShuLiang.Text = shuLiang.ToString();

                }
            }
        }
    }
}
