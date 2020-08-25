using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Models.src
{
	public class studentModel: CommonModel<yuhs.Entities.src.student>
	{
		public  string studentname { get; set; }
		public  int studentnumber { get; set; }
		/*add customized code between this region*/
		/*add customized code between this region*/
		
		public override void PopulateFrom(yuhs.Entities.src.student entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);
			this.studentname = entity.studentname;
			this.studentnumber = entity.studentnumber;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
		
		public override void PopulateTo(yuhs.Entities.src.student entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);
			entity.studentname = this.studentname;
			entity.studentnumber = this.studentnumber;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
