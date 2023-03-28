using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SolidPrinciplesExample.Entities.Abstract;

namespace SolidPrinciplesExample.DataAccess.EntityFramework
{
    /*
     * Ekleme-Güncelleme-Silme-Listeleme işlemleri için bir veritabanı nesnesi ve
     * çalışacağı context bilgisini alır. Bu bilgileri alırken farklı bilgiler verilmesin 
     * diye de kısıtlamalar konulur. Bu aldığı bilgilere göre de metotların içerisini doldurur.
     */
	public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
                             where TEntity : class, IEntity, new()
                             where TContext : DbContext, new()
    {
      
            public void Add(TEntity entity)
            {
                using (TContext context = new TContext())
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
            }

            public void Delete(TEntity entity)
            {
                using (TContext context = new TContext())
                {
                    var deletedEntity = context.Entry(entity);
                    deletedEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }

            public List<TEntity> GetAll()
            {
                using (TContext context = new TContext())
                {
                return context.Set<TEntity>().ToList();
                }
            }

            public void Update(TEntity entity)
            {
                using (TContext context = new TContext())
                {
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
    }

