using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Controllers.src
{
	public class test11Controller: CommonController<yuhs.Entities.src.test11,yuhs.Services.Interfaces.src.Itest11Service,yuhs.Web.Models.src.test11Model>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "src/test11";
		}
		
		protected override List<yuhs.Entities.src.test11> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<yuhs.Entities.src.test11> lists = this.Service.SelectBy(pagerSearchModel.Pager,new yuhs.Entities.src.test11 { Name = pagerSearchModel.Name }, test11 => test11.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
