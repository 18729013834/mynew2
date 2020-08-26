using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Controllers
{
	public class test333Controller: CommonController<yuhs.Entities.test333,yuhs.Services.Interfaces.Itest333Service,yuhs.Web.Models.test333Model>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "test333";
		}
		
		protected override List<yuhs.Entities.test333> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<yuhs.Entities.test333> lists = this.Service.SelectBy(pagerSearchModel.Pager,new yuhs.Entities.test333 { Name = pagerSearchModel.Name }, test333 => test333.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
