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
	public class studentService:Service<yuhs.Entities.src.student>,IstudentService
	{
		public studentService() : base(typeof(IstudentDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
