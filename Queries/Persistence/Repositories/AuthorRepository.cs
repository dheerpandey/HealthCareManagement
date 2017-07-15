﻿using Queries.Core.Domain;
using Queries.Core.Repositories;
using System.Data.Entity;
using System.Linq;

namespace Queries.Persistence.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(HCMContext context) : base(context)
        {
        }

        public Author GetAuthorWithCourses(int id)
        {
            return HCMContext.Authors.SingleOrDefault(a => a.Id == id);
        }

        public HCMContext HCMContext
        {
            get { return Context as HCMContext; }
        }
    }
}