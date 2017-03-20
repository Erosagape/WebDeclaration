using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace JobMvc.DataLayer
{
    public class Connection : IDisposable
    {
        public string Message { get; set; }
        public bool State { get; set; }
        private readonly MySqlConnection cn;
        public Connection(string db="mvc_test")
        {
            State = false;
            try
            {
                cn = new MySqlConnection("server=localhost;uid=root;pwd=;database="+db+@";port=3306;CharSet=utf8;");
                cn.Open();
                State = true;
            }
            catch (Exception e)
            {
                Message = e.Message;
            }
        }
        public MySqlConnection getConnection()
        {
            return cn;
        }
        public bool ExecuteSQL(string sqlcmd)
        {
            try
            {
                MySqlCommand cm = new MySqlCommand(sqlcmd, cn);
                cm.CommandType = CommandType.Text;
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Message = e.Message;
                return false;
            }
        }
        public MySqlDataReader getDataReader(string sqlcmd)
        {
            MySqlDataReader rd = new MySqlCommand(sqlcmd, cn).ExecuteReader();
            return rd;
        }
        public DataTable getDataTable(string sqlcmd)
        {
            var tb = new MysqlDataTable(sqlcmd, this.cn);
            return tb.data;
        }
        public void Close()
        {
            if (cn.State.Equals(ConnectionState.Open)) cn.Close();
            this.Dispose();
        }

        public void Dispose()
        {
            cn.Dispose();
        }
    }
    public class MysqlDataTable : IDisposable
    {
        protected string cmd { get; set; }
        protected MySqlDataAdapter da { get; set; }
        protected MySqlCommandBuilder cmb { get; set; }
        public DataTable data { get; set; }
        public MysqlDataTable(string sqlcmd, MySqlConnection cn)
        {
            cmd = sqlcmd;

            da = new MySqlDataAdapter(cmd, cn);
            cmb = new MySqlCommandBuilder(da);
            data = new DataTable();
            da.Fill(data);
        }
        public int update()
        {
            return da.Update(data);
        }
        public void Dispose()
        {
            da.Dispose();
            cmb.Dispose();
            data.Dispose();
        }
    }
}