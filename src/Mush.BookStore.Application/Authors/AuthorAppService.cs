using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Mush.BookStore.Authors.Dtos;
using Mush.BookStore.Books;
using Mush.BookStore.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Mush.BookStore.Authors;

[Authorize(BookStorePermissions.Authors.Default)]
public class AuthorAppService : ApplicationService, IAuthorAppService
{
    private readonly IAuthorRepository _authorRepository;
    public AuthorAppService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    
    public async Task<AuthorDto> GetAsync(Guid id)
    {
        var author = await _authorRepository.GetAsync(id);
        return ObjectMapper.Map<Author, AuthorDto>(author);
    }

    public Task<PagedResultDto<AuthorDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        throw new NotImplementedException();
    }

    public Task<AuthorDto> CreateAsync(CreateUpdateAuthorDto input)
    {
        throw new NotImplementedException();
    }

    public Task<AuthorDto> UpdateAsync(Guid id, CreateUpdateAuthorDto input)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}