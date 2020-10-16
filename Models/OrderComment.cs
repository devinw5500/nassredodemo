using System.Text;

namespace TaxSystemNASS.Models
{
    public partial class OrderComment
    {
        public int OrderCommentId { get; set; }
        public int OrderId { get; set; }
        public string Comment { get; set; }
        public bool? Urgent { get; set; }

        public virtual Order Order { get; set; }

        public string toSqlStatement()
        {
            StringBuilder sqlInsertAddress = new StringBuilder("INSERT INTO [dbo].[OrderComment] VALUES (");

            sqlInsertAddress.AppendFormat(@"'{0}', '{1}','{2}','{3}')", OrderCommentId, OrderId, Comment, Urgent);

            return sqlInsertAddress.ToString();
        }
    }
}