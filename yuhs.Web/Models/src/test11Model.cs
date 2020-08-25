using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Models.src
{
	public class test11Model: CommonModel<yuhs.Entities.src.test11>
	{
		/*add customized code between this region*/
		/*add customized code between this region*/
		
		public override void PopulateFrom(yuhs.Entities.src.test11 entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
		
		public override void PopulateTo(yuhs.Entities.src.test11 entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
