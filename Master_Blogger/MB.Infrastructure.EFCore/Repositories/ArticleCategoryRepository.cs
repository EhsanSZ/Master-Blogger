﻿using System.Collections.Generic;
using System.Linq;
using MB.Domain.ArticleCategoryAgg;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleCategoryRepository(MasterBloggerContext context) 
        {
            _context = context;
        }

        public void Add(ArticleCategory entity)
        {
            _context.ArticleCategories.Add(entity);
            Save();    
        }

        public ArticleCategory Get(long id)
        {
            return _context.ArticleCategories.FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}