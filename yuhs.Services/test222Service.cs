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
	public class test222Service:Service<yuhs.Entities.test222>,Itest222Service
	{
		public test222Service() : base(typeof(Itest222Dao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
