using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewStructure.Models;

namespace ViewStructure.ViewCompenents
{
	public class WorkChartViewComponent:ViewComponent
	{
		List<WorkChart> workChart = new List<WorkChart>()
		{
			new WorkChart("Osman", new List<bool>(){false,true,false,true,true}),
			new WorkChart("Şüheda", new List<bool>(){true,false,false,true,false}),
			new WorkChart("Onur", new List<bool>(){false,false,true,false,true}),
			new WorkChart("Leyla", new List<bool>(){true,true,false,false,false})
		};

		public IViewComponentResult Invoke()
		{
			return View(workChart);
		}




	}
}
