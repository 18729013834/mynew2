using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Models
{
	public class test222Model: CommonModel<yuhs.Entities.test222>
	{
		/*add customized code between this region*/
		/*add customized code between this region*/
		
		public override void PopulateFrom(yuhs.Entities.test222 entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
		
		public override void PopulateTo(yuhs.Entities.test222 entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
