using System;
using System.Linq.Expressions;
using SolidPrinciplesExample.Entities.Abstract;

namespace SolidPrinciplesExample.DataAccess.EntityFramework
{
    /* Her veritabanı nesnesinin sahip olması gereken metotların tanımlandığı interface.
    *  Bu da Interfaces Segregation örneğidir. Çünkü sadece her sınıfta kullanılması gereken metotlara
    *  yer verilmiştir.
    */

	public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

