using System;
using System.ComponentModel.DataAnnotations;

namespace Mush.BookStore.Authors.Dtos;

public class CreateUpdateAuthorDto
{
    [Required]
    [StringLength(128)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    public DateTime RegDate { get; set; } = DateTime.Now;
}