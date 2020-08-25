using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using yuhs.Daos.Interfaces.src;
using yuhs.Entities.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Daos.src
{
	public class test11Dao:CommonObjectDao<yuhs.Entities.src.test11>,yuhs.Daos.Interfaces.src.Itest11Dao
	{
		public class test11SqlBuilder : ObjectSqlBuilder
		{
			public test11SqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"test11")
			{
				this.SqlInsert = "INSERT INTO test11(" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE test11 SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class test11ResultHandler : CommonObjectResultHandler<yuhs.Entities.src.test11>
		{
			public override void GetColumnValues(IDataReader reader,test11 item)
			{
				base.GetColumnValues(reader, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, test11 item)
			{
				base.AddInsertParameters(context, command, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public test11Dao(SqlDialect sqlDialect) : base(new test11SqlBuilder(sqlDialect), new test11ResultHandler())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
