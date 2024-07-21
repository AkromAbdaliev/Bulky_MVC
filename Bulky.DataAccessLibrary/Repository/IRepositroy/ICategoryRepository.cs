using Bulky.ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccessLibrary.Repository.IRepositroy
{
	public interface ICategoryRepository: IRepository<Category>
	{
		void Update(Category obj);
		void Save();	
	}
}
