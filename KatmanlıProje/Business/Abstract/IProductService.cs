using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetAllCategory(int id);   // kategoriye göre filtreleyeceğimiz için hangi kategori olacağını almamamız gerek

        List<Product> GetByUnitPrices(decimal min, decimal max);

    }
}
