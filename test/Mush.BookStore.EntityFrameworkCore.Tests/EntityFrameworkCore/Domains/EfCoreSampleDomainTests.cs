using Mush.BookStore.Samples;
using Xunit;

namespace Mush.BookStore.EntityFrameworkCore.Domains;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreEntityFrameworkCoreTestModule>
{

}
