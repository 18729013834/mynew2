using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using yuhs.Entities.src.ceshi;
using yuhs.Services.Interfaces.src.ceshi;
using yuhs.Daos.Interfaces.src.ceshi;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Services.src.ceshi
{
	public class leiService:Service<yuhs.Entities.src.ceshi.lei>,IleiService
	{
		public leiService() : base(typeof(IleiDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
