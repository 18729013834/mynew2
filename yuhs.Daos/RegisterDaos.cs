using System;
using MetaShare.Common.Core.Daos;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}
		
		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}
		
		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(yuhs.Daos.Interfaces.src.ceshi.IleiDao), new yuhs.Daos.src.ceshi.leiDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(yuhs.Daos.Interfaces.src.Itest11Dao), new yuhs.Daos.src.test11Dao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(yuhs.Daos.Interfaces.src.IstudentDao), new yuhs.Daos.src.studentDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
