using booksapi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace booksapi.Services
{
    public class CategoryService
    {
        private BooksApiContext _Context { get; set; }
        public CategoryService(BooksApiContext context)
        {
            _Context = context;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = await _Context.Categories.ToListAsync();

            return categories;
        }

        public async Task<Category> PostAsync(Category category)
        {
            
            category.CreatedAt = DateTime.Now;
            category.UpdatedAt = DateTime.Now;

            _Context.Categories.Add(category);
            await _Context.SaveChangesAsync();

            return category;
        }
    }
}
