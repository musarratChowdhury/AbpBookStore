using System.Threading.Tasks;

namespace Mush.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
