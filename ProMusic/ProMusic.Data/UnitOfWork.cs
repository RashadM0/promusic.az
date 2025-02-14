﻿using System;
using System.Threading.Tasks;
using ProMusic.Core;
using ProMusic.Core.Repositories;
using ProMusic.Data.Repositories;

namespace ProMusic.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private CategoryRepository _categoryRepository;
        private SettingRepository _settingRepository;
        private BrandRepository _brandRepository;
        private ProductRepository _productRepository;
        private SliderRepository _sliderRepository;
        private InformationRepository _informationRepository;
        private SubCategoryRepository _subCategoryRepository;
        private CommentRepository _commentRepository;
        private OrderRepository _orderRepository;
        private OrderItemRepository _orderItemRepository;
        private AccountRepository _accountRepository;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_context);
        public ISettingRepository SettingRepository => _settingRepository ?? new SettingRepository(_context);
        public IBrandRepository BrandRepository => _brandRepository ?? new BrandRepository(_context);
        public IProductRepository ProductRepository => _productRepository ?? new ProductRepository(_context);
        public ISliderRepository SliderRepository => _sliderRepository ?? new SliderRepository(_context);
        public IInformationRepository InformationRepository => _informationRepository ?? new InformationRepository(_context);
        public ISubCategoryRepository SubCategoryRepository => _subCategoryRepository ?? new SubCategoryRepository(_context);
        public ICommentRepository CommentRepository => _commentRepository ?? new CommentRepository(_context);
        public IOrderRepository OrderRepository => _orderRepository ?? new OrderRepository(_context);
        public IOrderItemRepository OrderItemRepository => _orderItemRepository ?? new OrderItemRepository(_context);
        public IAccountRepository AccountRepository => _accountRepository ?? new AccountRepository(_context);

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
