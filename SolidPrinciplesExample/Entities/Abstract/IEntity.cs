using System;
namespace SolidPrinciplesExample.Entities.Abstract
{
    /*
	* IEntity'in görevi: IEntityi implement eden her sınıf bir veritabanı nesnesidir.
	* Single Responsibility Principle ile her nesne 'bir' işten sorumludur.
	* Bu sınıfımızın 'tek' görevi bu sınıfı implement eden sınıfların veritabanı nesnesi olduğunu belirtmektir.
	*/
    public interface IEntity
	{
	}
}

