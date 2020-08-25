using System.Collections.Generic;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Web.Utilities.Mvc.Foundation;
/*add customized code between this region*/
/*add customized code between this region*/

namespace yuhs.Web.Controllers.src.ceshi
{
	public class leiController: CommonController<yuhs.Entities.src.ceshi.lei,yuhs.Services.Interfaces.src.ceshi.IleiService,yuhs.Web.Models.src.ceshi.leiModel>
	{
		
		protected override string GetCurrentAreaPath()
		{
			return "src/ceshi/lei";
		}
		
		protected override List<yuhs.Entities.src.ceshi.lei> GetBySearchModel(SearchModel pagerSearchModel)
		{
			if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });
			List<yuhs.Entities.src.ceshi.lei> lists = this.Service.SelectBy(pagerSearchModel.Pager,new yuhs.Entities.src.ceshi.lei { Name = pagerSearchModel.Name }, lei => lei.Name.Contains(pagerSearchModel.Name));
			return lists;
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
