using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.ModelsLibrary.ViewModels
{
	public class ProductViewModel
	{
        public Product Product { get; set; }
		public IEnumerable<SelectListItem> CategoryLIst { get; set; }	
    }
}
