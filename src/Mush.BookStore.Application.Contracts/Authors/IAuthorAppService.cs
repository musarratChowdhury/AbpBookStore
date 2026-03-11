using System;
using Mush.BookStore.Authors.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Mush.BookStore.Authors;

public interface IAuthorAppService :
    ICrudAppService<
        AuthorDto,
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateAuthorDto>
{
    
}