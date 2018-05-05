using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DatabaseReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkFirm_CheckedChanged(object sender, EventArgs e)
        {
            txtFirmName.Enabled = chkFirm.Checked;
        }

        private void chkJurCity_CheckedChanged(object sender, EventArgs e)
        {
            txtJurCityName.Enabled = chkJurCity.Checked;
        }

        private void chkPostCity_CheckedChanged(object sender, EventArgs e)
        {
            txtPostCityName.Enabled = chkPostCity.Checked;
        }
        public string QueryConst()
        {
            string query = "SELECT FIRM.NAME AS 'FIRM NAME',JUR_CITY.NAME AS 'JUR_CITY NAME',POST_CITY.NAME AS 'POST_CITY NAME' "+
            "FROM FIRM INNER JOIN CITY AS JUR_CITY on (FIRM.JUR_CITY_ID = JUR_CITY.ID) " +
            "LEFT join CITY AS POST_CITY on (FIRM.POST_CITY_ID = POST_CITY.ID) " +
            "WHERE (CASE WHEN @firm_name = '' " +
            "THEN 1 ELSE(CASE WHEN UPPER(@firm_name) = UPPER(FIRM.NAME) THEN 1 ELSE 0 END) END) = 1 " +
            "AND (CASE WHEN @jur_city_name = '' " +
            "THEN 1 ELSE(CASE WHEN UPPER(@jur_city_name) = UPPER(JUR_CITY.NAME) THEN 1 ELSE 0 END) END) = 1 "+
            "AND (CASE WHEN @post_city_name = '' THEN 1 " +
            "ELSE (CASE WHEN UPPER(@post_city_name) = UPPER(POST_CITY.NAME) THEN 1 ELSE 0 END) END) = 1 ";   
            return query;

        }
        private void btnExecuteQuery_Click(object sender, EventArgs e)
        {
            string s = QueryConst();
            SqlCommand command = new SqlCommand(s);
            command.CommandType = CommandType.Text;
            command.CommandTimeout = 30;
            command.Connection = this.sqlConnection1;
            command.Parameters.Add("@firm_name", SqlDbType.VarChar);
            command.Parameters["@firm_name"].Value = txtFirmName.Text.ToString();
            command.Parameters.Add("@jur_city_name", SqlDbType.VarChar);
            command.Parameters["@jur_city_name"].Value = txtJurCityName.Text.ToString();
            command.Parameters.Add("@post_city_name", SqlDbType.VarChar);
            command.Parameters["@post_city_name"].Value = txtPostCityName.Text.ToString();
            this.sqlDataAdapter1.SelectCommand = command;
            DataTable data = new DataTable();
            sqlDataAdapter1.Fill(data);
            dataGridView1.DataSource = data;
            sqlConnection1.Close();
        }
    }
}
