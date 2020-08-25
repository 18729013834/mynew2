using System;
using System.Data;
using MetaShare.Common.Core.Daos;
using yuhs.Daos.Interfaces.src.ceshi;
using yuhs.Entities.src.ceshi;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Daos.src.ceshi
{
	public class leiDao:CommonObjectDao<yuhs.Entities.src.ceshi.lei>,yuhs.Daos.Interfaces.src.ceshi.IleiDao
	{
		public class leiSqlBuilder : ObjectSqlBuilder
		{
			public leiSqlBuilder(SqlDialect sqlDialect) : base(sqlDialect,"lei")
			{
				this.SqlInsert = "INSERT INTO lei(text," + this.SqlBaseFieldInsertFront + ") VALUES (@text," + this.SqlBaseFieldInsertBack + ")";
				this.SqlUpdate = "UPDATE lei SET text=@text," + this.SqlBaseFieldUpdate + " WHERE Id=@Id";
			}
		}
		
		public class leiResultHandler : CommonObjectResultHandler<yuhs.Entities.src.ceshi.lei>
		{
			public override void GetColumnValues(IDataReader reader,lei item)
			{
				base.GetColumnValues(reader, item);
				int ordinaltext = reader.GetOrdinal("text");
				item.text = reader.IsDBNull(ordinaltext) ? null : reader.GetString(ordinaltext);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
			
			public override void AddInsertParameters(IContext context, IDbCommand command, lei item)
			{
				base.AddInsertParameters(context, command, item);
				context.AddParameter(command,"text",item.text ?? (object)DBNull.Value);
				/*add customized code between this region*/
				/*add customized code between this region*/
			}
		}
		
		public leiDao(SqlDialect sqlDialect) : base(new leiSqlBuilder(sqlDialect), new leiResultHandler())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
