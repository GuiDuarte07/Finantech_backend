﻿using ControleCerto.DTOs.Category;
using ControleCerto.Enums;
using ControleCerto.Errors;
using ControleCerto.Models.Entities;

namespace ControleCerto.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<Result<InfoCategoryResponse>> CreateCategoryAsync(CreateCategoryRequest request, int userId);
        public Task<Result<InfoCategoryResponse>> UpdateCategoryAsync(UpdateCategoryRequest request, int userId);
        public Task<Result<bool>> DeleteCategoryAsync(int categoryId, int userId);
        public Task<Result<ICollection<InfoCategoryResponse>>> GetAllCategoriesAsync(int userId, BillTypeEnum? type);
    }
}