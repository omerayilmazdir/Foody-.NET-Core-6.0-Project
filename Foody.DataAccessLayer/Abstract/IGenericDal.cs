using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // burada T değerinin sınıf olması gerektiğini beyan ediyoruz
    {
        // şimdi buraya yöntemlerimizi yani metotlarımızı yazıyoruz

        void Insert(T entity);

        void Update(T entity);

        void Delete(int id);

        List<T> GetAll();

        T GetById(int id);
    }
}
