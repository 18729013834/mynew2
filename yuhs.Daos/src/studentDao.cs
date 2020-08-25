using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using yuhs.Daos.Interfaces.src;
using yuhs.Entities.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Daos.src
{
	public class studentDao:CommonObjectDao<yuhs.Entities.src.student>,yuhs.Daos.Interfaces.src.IstudentDao
	{
		public class studentSqlBuilder : ObjectSqlBuilder
		{
			public studentSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"student")
			{
				this.SqlInsert = "INSERT INTO student(studentnumber,studentname," + this.SqlBaseFieldInsertFront + ") VALUES (@studentnumber,@studentname," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE student SET studentnumber=@studentnumber,studentname=@studentname," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class studentResultHandler : CommonObjectResultHandler<yuhs.Entities.src.student>
		{
			public override void GetColumnValues(IDataReader reader,student item)
			{
				base.GetColumnValues(reader, item);
				int ordinalstudentnumber = reader.GetOrdinal("studentnumber");
				item.studentnumber = reader.IsDBNull(ordinalstudentnumber) ? 0 : reader.GetInt32(ordinalstudentnumber);
				int ordinalstudentname = reader.GetOrdinal("studentname");
				item.studentname = reader.IsDBNull(ordinalstudentname) ? null : reader.GetString(ordinalstudentname);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, student item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command,"studentnumber",item.studentnumber);
				context.AddParameter(command,"studentname",item.studentname ?? (object)DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public studentDao(SqlDialect sqlDialect) : base(new studentSqlBuilder(sqlDialect), new studentResultHandler())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
