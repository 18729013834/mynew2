using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using yuhs.Daos.Interfaces;
using yuhs.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Daos
{
	public class test222Dao:CommonObjectDao<yuhs.Entities.test222>,yuhs.Daos.Interfaces.Itest222Dao
	{
		public class test222SqlBuilder : ObjectSqlBuilder
		{
			public test222SqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"test222")
			{
				this.SqlInsert = "INSERT INTO test222(" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE test222 SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class test222ResultHandler : CommonObjectResultHandler<yuhs.Entities.test222>
		{
			public override void GetColumnValues(IDataReader reader,test222 item)
			{
				base.GetColumnValues(reader, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, test222 item)
			{
				base.AddInsertParameters(context, command, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public test222Dao(SqlDialect sqlDialect) : base(new test222SqlBuilder(sqlDialect), new test222ResultHandler())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
