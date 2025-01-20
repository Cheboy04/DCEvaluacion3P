/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCEvaluacion3P
{
    public class DCCatRepositorio
    {
        string _dbPath;
        private SQLiteAsyncConnection conn;

        public string StatusMessage { get; set; }

        private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);

            await conn.CreateTableAsync<DCCat>();
        }
        public DCCatRepositorio(string dbPath)
        {
            _dbPath = dbPath;
        }
    }
}
*/
