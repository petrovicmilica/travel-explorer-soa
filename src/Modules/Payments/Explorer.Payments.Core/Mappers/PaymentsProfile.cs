﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Explorer.Payments.API.Dtos.ShoppingCartDtos;
using Explorer.Payments.Core.Domain.ShoppingCarts;
using Explorer.Payments.API.Dtos.BundlePayRecord;
using Explorer.Payments.Core.Domain.BundlePayRecords;

namespace Explorer.Payments.Core.Mappers
{
    public class PaymentsProfile : Profile
    {
        public PaymentsProfile() {

            CreateMap<ShoppingCartDto, ShoppingCart>().ReverseMap();   //ShoppingCart
            CreateMap<BundlePayRecordDto, BundlePayRecord>().ReverseMap();   //BundlePayRecord
            CreateMap<OrderItemDto, OrderItem>().ReverseMap();
            CreateMap<TourPurchaseTokenDto, TourPurchaseToken>().ReverseMap();

        }
        
    }
}
