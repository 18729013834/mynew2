using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using yuhs.Entities.src;
using yuhs.Services.Interfaces.src;
using yuhs.Daos.Interfaces.src;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Services.src
{
	public class test11Service:Service<yuhs.Entities.src.test11>,Itest11Service
	{
		public test11Service() : base(typeof(Itest11Dao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
