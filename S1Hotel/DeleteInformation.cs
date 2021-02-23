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
    public partial class DeleteInformation : CCSkinMain
    {
        //调用DBHelper类
     private   DBHelper db = new DBHelper();
        public DeleteInformation()
        {
            InitializeComponent();
        }

        private void DeleteInformation_Load(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void ChaXun()
        {
            try
            {
                if (lvKXF.Items.Count>0)
                {
                    lvKXF.Items.Clear();
                }
                //载入房间号码
                string sql = string.Format(@"select  *
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID");
                if (txtFangHao.Text!="")
                {
                    sql = string.Format(@"select  *
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomTable.RoomID='{0}'",txtFangHao.Text);
                }
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem items = new ListViewItem(dr["RoomID"].ToString());
                        items.SubItems.Add(dr["Floor"].ToString());
                        items.SubItems.Add(dr["TypeName"].ToString());
                        items.SubItems.Add(dr["Price"].ToString());
                        items.SubItems.Add(dr["StateName"].ToString());
                        lvKXF.Items.Add(items);
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



        private void lvYXF_DoubleClick(object sender, EventArgs e)
        {
            //双击未预定的房间中的listview 跳到已预定的listview
            ListViewItem list = lvKXF.SelectedItems[0];
            if (!(lvKXF.SelectedItems[0].SubItems[4].Text.Equals("空净")))
            {
                MessageBox.Show("抱歉！非空净的房间不允许删除！","提示");
                return;
            }
            //cbFangJianLeiXing.Text = lvKongJingFang.SelectedItems[0].SubItems[1].Text;
            lvKXF.Items.Remove(list);
            lvYXSCF.Items.Add(list);
        }

        private void lvYXSCF_DoubleClick(object sender, EventArgs e)
        {
            //双击可以删除的房间中的listview 跳到需要删除的listview
            ListViewItem list = lvYXSCF.SelectedItems[0];
            //cbFangJianLeiXing.Text = lvKongJingFang.SelectedItems[0].SubItems[1].Text;
            lvYXSCF.Items.Remove(list);
            lvKXF.Items.Add(list);
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            int a =0;
            if (lvYXSCF.Items.Count>0)
            { 

                DialogResult dr = MessageBox.Show("您确定要删除这几个房间吗？","提示",MessageBoxButtons.YesNo);
                if (dr!=DialogResult.Yes)
                {
                    return;
                }
                try
                {
                    
                    for (int i = 0; i < lvYXSCF.Items.Count; i++)
                    {
                        string sql = string.Format(@"delete from RoomTable 
                        where RoomID='{0}'", lvYXSCF.Items[i].SubItems[0].Text);
                        db.ExecuteSQLCommand(sql);
                        a++;
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
                if (a==lvYXSCF.Items.Count)
                {
                    string aacs = string.Format("成功删除{0}个房间！",a);
                    MessageBox.Show(aacs);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择需要删除的房间！","提示");
            }


        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            ChaXun();
        }


    }
}
