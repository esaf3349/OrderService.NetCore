using System;
using System.Linq.Expressions;

namespace OrderService.Domain.Interfaces
{
    public interface ISpecification<T>
    {
        public Expression<Func<T, bool>> Criteria { get; }
        public Expression<Func<T, object>> OrderBy { get; }
        public Expression<Func<T, object>> OrderByDescending { get; }
        public Expression<Func<T, object>> GroupBy { get; }

        public int Take { get; }
        public int Skip { get; }
        public bool IsPagingEnabled { get; }
    }
}
