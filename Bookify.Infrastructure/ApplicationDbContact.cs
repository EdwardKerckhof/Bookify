using Bookify.Domain.Abstractions;

using Microsoft.EntityFrameworkCore;

namespace Bookify.Infrastructure;

public sealed class ApplicationDbContact : DbContext, IUnitOfWork
{
    public ApplicationDbContact(DbContextOptions options) : base(options) { }
}