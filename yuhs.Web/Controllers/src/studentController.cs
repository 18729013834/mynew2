using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Controllers.src
{
	public class studentController: CommonController<yuhs.Entities.src.student,yuhs.Services.Interfaces.src.IstudentService,yuhs.Web.Models.src.studentModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "src/student";
		}
		
		protected override List<yuhs.Entities.src.student> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<yuhs.Entities.src.student> lists = this.Service.SelectBy(pagerSearchModel.Pager,new yuhs.Entities.src.student { Name = pagerSearchModel.Name }, student => student.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
