﻿using CrudApi.DTOs;
using CrudApi.Models;

namespace CrudApi.Data.Services
{
    public interface IUsersService
    {
        Task<IEnumerable<UserDto>> GetAll();
        Task<UserDto> GetById(int id);
        Task<UserDto> Update(int id, UserDto userDto);
        Task<User> Add(UserDto userDto);
        Task Delete(int id);
    }
}
