using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using yuhs.Entities;
using yuhs.Services.Interfaces;
using yuhs.Daos.Interfaces;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Services
{
	public class test333Service:Service<yuhs.Entities.test333>,Itest333Service
	{
		public test333Service() : base(typeof(Itest333Dao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
