using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Controllers
{
	public class test222Controller: CommonController<yuhs.Entities.test222,yuhs.Services.Interfaces.Itest222Service,yuhs.Web.Models.test222Model>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "test222";
		}
		
		protected override List<yuhs.Entities.test222> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<yuhs.Entities.test222> lists = this.Service.SelectBy(pagerSearchModel.Pager,new yuhs.Entities.test222 { Name = pagerSearchModel.Name }, test222 => test222.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
