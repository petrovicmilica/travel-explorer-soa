﻿using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Tours.API.Dtos;
using Explorer.Tours.API.Public.Administration;
using Explorer.Tours.Core.UseCases.Administration;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;

namespace Explorer.API.Controllers.Author.Administration
{
    [Route("api/administration/tourStatistics")]
    public class TourStatisticsController : BaseApiController
    {
        private ITourStatisticsService _tourStatisticsService;
        public TourStatisticsController(ITourStatisticsService tourStatisticsService) {
            _tourStatisticsService = tourStatisticsService;
        }

        [HttpGet("getAllPurchasedNumber")]
        public int GetNumberOfPurchaseByAuthor(int authorId)
        {
            var result = _tourStatisticsService.GetNumberOfPurchaseByAuthor(authorId);
          
            return result;
        }

        [HttpGet("getAllCompletedNumber")]
        public int GetNumberOfCompletedByAuthor(int authorId)
        {
            var result = _tourStatisticsService.GetNumberOfCompletedByAuthor(authorId);

            return result;
        }

        [HttpGet("getAllStartedNumber")]
        public int GetNumberOfStartedByAuthor(int authorId)
        {
            var result = _tourStatisticsService.GetNumberOfStartedByAuthor(authorId);

            return result;
        }

        [HttpGet("getPurchasedNumberByTour")]
        public int GetNumberOfPurchaseByTour(int authorId, int tourId)
        {
            var result = _tourStatisticsService.GetNumberOfPurchaseByTour(authorId, tourId);

            return result;
        }

        [HttpGet("getStartedNumberByTour")]
        public int GetNumberOfStartedByTour(int authorId, int tourId)
        {
            var result = _tourStatisticsService.GetNumberOfStartedByTour(authorId, tourId);

            return result;
        }

        [HttpGet("getCompletedNumberByTour")]
        public int GetNumberOfCompletedByTour(int authorId, int tourId)
        {
            var result = _tourStatisticsService.GetNumberOfCompletedByTour(authorId, tourId);

            return result;
        }

    }
}
