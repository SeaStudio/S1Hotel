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
    public partial class CommodityManagement : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public CommodityManagement()
        {
            InitializeComponent();
        }

        private void CommodityManagement_Load(object sender, EventArgs e)
        {
            //            try
            //            {
            //                //载入商品类型
            //                string sql = string.Format(@"select *
            //                                            from[dbo].[CommodityType]");
            //                DataSet ds = db.Biao(sql,"LeiXing");
            //                DataRow row = ds.Tables["LeiXing"].NewRow();
            //                row["ID"] = -1;
            //                row["TypeName"] = "全部";
            //                ds.Tables["LeiXing"].Rows.InsertAt(row, 0);
            //                cbLeiXing.DataSource = ds.Tables["LeiXing"];
            //                cbLeiXing.ValueMember = "ID";
            //                cbLeiXing.DisplayMember = "TypeName";
            //            }
            //            catch (Exception ee)
            //            {
            //                MessageBox.Show(ee.Message);
            //            }
            //            finally
            //            {
            //                db.GuanBi();
            //            }

            GetCommodity();
        }

        /// <summary>
        /// 载入商品信息
        /// </summary>
        private void GetCommodity()
        {
            try
            {
                //清空商品类型框
                if (lvShangPing.Items.Count > 0)
                {
                    lvShangPing.Items.Clear();
                }
                //载入所有商品新息
                string sql = string.Format(@"select*
                                            FROM Commodity
                                            inner join CommodityType
                                            on Commodity.Type = CommodityType.ID");
                //                //按商品类型查询商品
                //                if (!cbLeiXing.Text.Equals("全部"))
                //                {
                //                    sql = string.Format(@"select*
                //                                            FROM Commodity
                //                                            inner join CommodityType
                //                                            on Commodity.Type = CommodityType.ID where CommodityType.TypeName='{0}'",cbLeiXing.Text);
                //                }

                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    //循环添加数量
                    while (dr.Read())
                    {
                        ListViewItem items = new ListViewItem(dr["Name"].ToString());
                        items.SubItems.Add(dr["TypeName"].ToString());
                        items.SubItems.Add(dr["Company"].ToString());
                        items.SubItems.Add(dr["Number"].ToString());
                        items.SubItems.Add(dr["RetailPrice"].ToString());
                        lvShangPing.Items.Add(items);
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
        private void cbLeiXing_SelectedIndexChanged(object sender, EventArgs e)
        {
            //按商品类型查询商品
            GetCommodity();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvShangPing_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < lvShangPing.SelectedItems.Count; i++)
            {
                PurchaseQuantity pq = new PurchaseQuantity();

                if (pq.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                int shuLiang = pq.a;

                ListViewItem list = new ListViewItem(lvShangPing.SelectedItems[i].SubItems[0].Text);
                int kuCun = Convert.ToInt32(lvShangPing.SelectedItems[i].SubItems[3].Text);
                //移动数量不能大于库存量
                if (shuLiang > kuCun)
                {
                    MessageBox.Show("库存量不足！","提示");
                    return;
                }
                int j;
                //如果已经有则添加数量
                for (j = 0; j < lvGouWuChe.Items.Count; j++)
                {
                    if (lvGouWuChe.Items[j].SubItems[0].Text == lvShangPing.SelectedItems[i].SubItems[0].Text)
                    {
                        lvGouWuChe.Items[j].SubItems[3].Text = (Convert.ToInt32(lvGouWuChe.Items[j].SubItems[3].Text) + shuLiang).ToString();
                        break;
                    }
                }

                if (j == lvGouWuChe.Items.Count)
                {
                    string[] str = { lvShangPing.SelectedItems[i].SubItems[1].Text, lvShangPing.SelectedItems[i].SubItems[2].Text, shuLiang.ToString(), lvShangPing.SelectedItems[i].SubItems[4].Text };
                    list.SubItems.AddRange(str);
                    lvGouWuChe.Items.Add(list);
                }
                lvShangPing.SelectedItems[i].SubItems[3].Text = (kuCun - shuLiang).ToString();
            }
            //计算价格
            JiSuanJiaGe();
        }

        private void JiSuanJiaGe()
        {
            //计算价格
            if (lvGouWuChe.Items.Count > 0)
            {
                double heJi = 0;
                for (int i = 0; i < lvGouWuChe.Items.Count; i++)
                {
                    double shuLiang = Convert.ToDouble(lvGouWuChe.Items[i].SubItems[3].Text);
                    double jiaGe = Convert.ToDouble(lvGouWuChe.Items[i].SubItems[4].Text);
                    heJi += (jiaGe * shuLiang);
                }
                tbHeJi.Text = heJi.ToString();
            }
            else
            {
                tbHeJi.Text = "0";
            }
        }

        private void lvGouWuChe_DoubleClick(object sender, EventArgs e)
        {
            //删减购物车！
            for (int i = 0; i < lvGouWuChe.SelectedItems.Count; i++)
            {
                PurchaseQuantity pq = new PurchaseQuantity();
                pq.Text = "退 回 数 量";
                pq.ShowDialog();
                int shuLiang = pq.a;
                ListViewItem list = new ListViewItem(lvGouWuChe.SelectedItems[i].SubItems[0].Text);
                int kuCun = Convert.ToInt32(lvGouWuChe.SelectedItems[i].SubItems[3].Text);
                //移动数量不能大于库存量
                if (shuLiang > kuCun)
                {
                    MessageBox.Show("数量不足！","提示");
                    return;
                }
                if (shuLiang == 0)
                {
                    MessageBox.Show("数量不能为零！","提示");
                    return;
                }
                int j;
                //如果已经有则添加数量
                for (j = 0; j < lvShangPing.Items.Count; j++)
                {
                    if (lvShangPing.Items[j].SubItems[0].Text == lvGouWuChe.SelectedItems[i].SubItems[0].Text)
                    {
                        lvShangPing.Items[j].SubItems[3].Text = (Convert.ToInt32(lvShangPing.Items[j].SubItems[3].Text) + shuLiang).ToString();
                        break;
                    }
                }

                if (j == lvShangPing.Items.Count)
                {
                    string[] str = { lvGouWuChe.SelectedItems[i].SubItems[1].Text, lvGouWuChe.SelectedItems[i].SubItems[2].Text, shuLiang.ToString(), lvGouWuChe.SelectedItems[i].SubItems[4].Text };
                    list.SubItems.AddRange(str);
                    lvShangPing.Items.Add(list);
                }
                lvGouWuChe.SelectedItems[i].SubItems[3].Text = (kuCun - shuLiang).ToString();
            }
            for (int i = 0; i < lvGouWuChe.Items.Count; i++)
            {
                if (lvGouWuChe.Items[i].SubItems[3].Text.Equals("0"))
                {
                    ListViewItem list = lvGouWuChe.Items[i];
                    lvGouWuChe.Items.Remove(list);
                }
            }
            JiSuanJiaGe();
        }
        //实收
        private void tbShiShou_TextChanged(object sender, EventArgs e)
        {

            if (tbShiShou.Text != "")
            {
                if (Convert.ToDouble(tbShiShou.Text) < Convert.ToDouble(tbHeJi.Text))
                {
                    tbZhaoLing.Text = "实收必须大于合计金额！";
                    btJieZhang.Enabled = false;
                    return;
                }
                tbZhaoLing.Text = (Convert.ToDouble(tbShiShou.Text) - Convert.ToDouble(tbHeJi.Text)).ToString();
                btJieZhang.Enabled = true;
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            //结账
            if (lvGouWuChe.Items.Count > 0)
            {
                string sql;
                for (int i = 0; i < lvGouWuChe.Items.Count; i++)
                {
                    try
                    {
                        sql = string.Format(@"update [dbo].[Commodity] set  Number-={0}
                                            where Name = '{1}'", Convert.ToInt32(lvGouWuChe.Items[i].SubItems[3].Text), lvGouWuChe.Items[i].SubItems[0].Text);
                        if (db.ExecuteSQLCommand(sql) == 0)
                        {
                            MessageBox.Show("商品数量修改失败！","提示");
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
                sql = string.Format(@"insert into MerchandiseOrderTable(OrderTable, CollectMoney, PaymentMethod)
                                            values('{0}','{1}','{2}')", DateTime.Now.ToString(), tbHeJi.Text, cbFuKuangFangShi.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("购买成功！","提示");
                    tbHeJi.Text = "";
                    tbShiShou.Text = "";
                    tbZhaoLing.Text = "";
                    lvGouWuChe.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("请选择商品！","提示");
            }
        }

        private void 添加商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开添加商品
            CommodityAddition ca = new CommodityAddition();
            ca.ShowDialog();
            GetCommodity();

        }

        private void 修改商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //修改商品
            if (lvShangPing.SelectedItems.Count > 0)
            {
                CommodityModification cmm = new CommodityModification();
                cmm.MingCheng = lvShangPing.SelectedItems[0].SubItems[0].Text;
                cmm.ShowDialog();
                GetCommodity();
            }
            else
            {
                MessageBox.Show("请在商品表选择需要修改的商品！","提示");
            }

        }

        private void 删除商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult aa = MessageBox.Show("您确定要删除该商品吗？", "提示", MessageBoxButtons.OKCancel);
            if (aa != DialogResult.OK)
            {
                return;
            }
            //删除指定商品
            if (lvShangPing.SelectedItems.Count > 0)
            {

                string sql = string.Format(@"delete from Commodity
                                        where Name = '{0}'", lvShangPing.SelectedItems[0].SubItems[0].Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("删除成功！","提示");
                    GetCommodity();
                }
                else
                {
                    MessageBox.Show("抱歉！该商品舍不得您！","提示");
                }

            }
            else
            {
                MessageBox.Show("请在商品表选择需要删除的商品！","提示");
            }
        }

        private void tbShiShou_KeyPress(object sender, KeyPressEventArgs e)
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
                    for (int i = 0; i < tbShiShou.Text.Length; i++)
                    {
                        if (tbShiShou.Text.Substring(i, 1) == ".")
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

        private void lvShangPing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvGouWuChe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
