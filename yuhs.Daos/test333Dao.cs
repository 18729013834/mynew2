using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using yuhs.Daos.Interfaces;
using yuhs.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Daos
{
	public class test333Dao:CommonObjectDao<yuhs.Entities.test333>,yuhs.Daos.Interfaces.Itest333Dao
	{
		public class test333SqlBuilder : ObjectSqlBuilder
		{
			public test333SqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"test333")
			{
				this.SqlInsert = "INSERT INTO test333(" + this.SqlBaseFieldInsertFront + ") VALUES (" + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE test333 SET " + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class test333ResultHandler : CommonObjectResultHandler<yuhs.Entities.test333>
		{
			public override void GetColumnValues(IDataReader reader,test333 item)
			{
				base.GetColumnValues(reader, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, test333 item)
			{
				base.AddInsertParameters(context, command, item);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public test333Dao(SqlDialect sqlDialect) : base(new test333SqlBuilder(sqlDialect), new test333ResultHandler())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
