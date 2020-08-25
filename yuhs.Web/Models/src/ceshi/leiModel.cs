using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Models.src.ceshi
{
	public class leiModel: CommonModel<yuhs.Entities.src.ceshi.lei>
	{
		public  string text { get; set; }
		/*add customized code between this region*/
		/*add customized code between this region*/
		
		public override void PopulateFrom(yuhs.Entities.src.ceshi.lei entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			this.text = entity.text;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
		
		public override void PopulateTo(yuhs.Entities.src.ceshi.lei entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			entity.text = this.text;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
