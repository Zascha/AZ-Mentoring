using System;
using AdventureWorks.Data.Models;
using AdventureWorks.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using AdventureWorks.Data;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.DataAccess.Queries
{
    public class ProductsQuery : IQuery<Product>
    {
        private readonly Func<DataContext> _contextFactory;

        public ProductsQuery(Func<DataContext> contextFactory)
        {
            _contextFactory = contextFactory ?? throw new ArgumentNullException(nameof(contextFactory));
        }

        public List<Product> GetAll()
        {
            using (var context = _contextFactory())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetAllPaged(int pageNumber, int pageSize)
        {
            using (var context = _contextFactory())
            {
                return context.Products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public Product GetById(int itemId)
        {
            using (var context = _contextFactory())
            {
                return context.Products.FirstOrDefault(x => x.ProductID == itemId);
            }
        }

        public List<Product> GetByPredicate(Func<Product, bool> predicate)
        {
            using (var context = _contextFactory())
            {
                return context.Products.Where(x => predicate(x)).ToList();
            }
        }

        public int Create(Product item)
        {
            using (var context = _contextFactory())
            {
                context.Products.Add(item);
                context.SaveChanges();

                return item.ProductID;
            }
        }

        public void Update(Product item)
        {
            using (var context = _contextFactory())
            {
                context.Products.Attach(item);
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product item)
        {
            using (var context = _contextFactory())
            {
                context.Products.Attach(item);
                context.Products.Remove(item);
                context.SaveChanges();
            }
        }

        public void DeleteById(int itemId)
        {
            using (var context = _contextFactory())
            {
                var productToDelete = context.Products.FirstOrDefault(x => x.ProductID == itemId);
                var transactionHistoryToDelete = context.TransactionHistories.Where(x => x.ProductID == itemId);

                if (productToDelete == null)
                {
                    throw new KeyNotFoundException("Not existing product.");
                }

                context.TransactionHistories.RemoveRange(transactionHistoryToDelete);
                context.Products.Remove(productToDelete);
                context.SaveChanges();
            }
        }
    }
}