using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjektZUS
{
    public class BasicErrorException : Exception
    {
        public BasicErrorException(string message) : base(message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public BasicErrorException(string message, SqlDataReader dr) : base(message)
        {
            DialogResult result = MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(result == DialogResult.OK)
            {
                dr.Close();
            }
        }
    }
}
