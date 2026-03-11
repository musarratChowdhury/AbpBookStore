using System;
using Mush.BookStore.Books;

namespace Mush.BookStore.Authors;

public interface IAuthorManager
{
    public Author CreateNew(string name, DateTime regDate);
}