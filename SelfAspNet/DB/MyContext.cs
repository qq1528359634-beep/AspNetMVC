using Microsoft.EntityFrameworkCore;
using SelfAspNet_MVC.Models;

namespace SelfAspNet_MVC.DB
{
    public class ApplicationDbContext:DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            //接收配置文件并上交给父类 DbContext 来处理
            //DbContextOptions<ApplicationDbContext>  包含了连接字符串等数据库连接相关的配置信息
            //依赖注入容器会根据Program.cs中的配置自动创建options实例，通过构造函数注入到 ApplicationDbContext 中，
            //并通过 base(options) 将其传递给 DbContext 的构造函数，使得 DbContext 能够正确地使用这些配置来连接数据库。

        }
        //通过 books 对象来操作数据库中的 Books 表，实现对 Books 表的增删改查等操作
        public DbSet<Book> Books { get; set; }
    }
}
