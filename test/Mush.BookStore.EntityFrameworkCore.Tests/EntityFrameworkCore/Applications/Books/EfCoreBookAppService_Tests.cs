using Mush.BookStore.Books;
using Xunit;

namespace Mush.BookStore.EntityFrameworkCore.Applications.Books;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
{

}