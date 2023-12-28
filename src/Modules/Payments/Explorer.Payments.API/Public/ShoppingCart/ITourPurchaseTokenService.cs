﻿using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Payments.API.Dtos.ShoppingCartDtos;
using Explorer.Tours.API.Dtos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Explorer.Payments.API.Public.ShoppingCart
{
    public interface ITourPurchaseTokenService
    {
        //Result<List<TourDTO>> GetPurchasedTours(int touristId);
        Result<PagedResult<TourPurchaseTokenDto>> GetPaged(int page, int pageSize);

        public List<TourDTO> GetAllPurchasedToursByAuthor(int authorId);
    }
}
