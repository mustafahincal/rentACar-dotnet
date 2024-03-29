﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
      public interface IUserService
      {
            IDataResult<List<User>> GetAll();
            IDataResult<User> GetById(int userId);
            IDataResult<List<OperationClaim>> GetClaims(User user);
            IDataResult<User> GetByMail(string email);
            IResult Add(User user);
            IResult Delete(DeleteUserDto deleteUserDto);
            IResult Update(UpdateUserDto updateUserDto);
            IResult UpdateHelper(User user);

      }
}
