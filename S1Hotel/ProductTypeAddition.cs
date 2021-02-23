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
    public partial class ProductTypeAddition : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public ProductTypeAddition()
        {
            InitializeComponent();
        }

        private void ProductTypeAddition_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"insert into CommodityType(TypeName)
                                values('{0}')", tbLeiXing.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("商品类型新增成功！");
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
    }
}
