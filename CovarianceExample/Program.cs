
ProductManager productManager = new ProductManager();
productManager.Log(new DatabaseLogger()); 

ProductManager productManager2 = new ProductManager();
productManager2.Log(new MemoryLogger());

Logger databaseLogger = new DatabaseLogger(); 
databaseLogger.Log();

public class Logger
{
    public virtual void Log()
    {
        Console.WriteLine("Loglandı");
    }
}

public class DatabaseLogger : Logger
{
    public override void Log()
    {
        Console.WriteLine("Veritabanına Loglandı");
    }
}

public class MemoryLogger : Logger
{
    public override void Log()
    {
        Console.WriteLine("Belleğe Loglandı.");
    }
}

public class ProductManager
{
    public void Log(Logger logger)
    {
        logger.Log();
    }
}