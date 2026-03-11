using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Mush.BookStore.Authors.Dtos;

public class AuthorDto : AuditedEntityDto<Guid>, 
    IHasConcurrencyStamp
{
    public string ConcurrencyStamp { get; set; }
}