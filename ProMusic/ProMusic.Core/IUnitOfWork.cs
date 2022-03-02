﻿using System;
using System.Threading.Tasks;
using ProMusic.Core.Repositories;
using ProMusic.Data.Repositories;

namespace ProMusic.Core
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        ISettingRepository SettingRepository { get; }
        IBrandRepository BrandRepository { get; }
        IProductRepository ProductRepository { get; }

        int Save();
        Task<int> SaveAsync();
    }
}
