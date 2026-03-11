using Volo.Abp.Modularity;

namespace Mush.BookStore;

[DependsOn(
    typeof(BookStoreApplicationModule),
    typeof(BookStoreDomainTestModule)
)]
public class BookStoreApplicationTestModule : AbpModule
{

}
