using MetaShare.Common.Core.CommonService;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}
		
		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}
		
		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(yuhs.Services.Interfaces.src.ceshi.IleiService), new yuhs.Services.src.ceshi.leiService(), isRegister);
			factory.Register(typeof(yuhs.Services.Interfaces.src.IstudentService), new yuhs.Services.src.studentService(), isRegister);
			factory.Register(typeof(yuhs.Services.Interfaces.src.Itest11Service), new yuhs.Services.src.test11Service(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
