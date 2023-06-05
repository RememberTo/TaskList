﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(NotesDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
        }
    }
}
