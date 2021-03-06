﻿using Housing_RedBadgeMVC.Data;
using Housing_RedBadgeMVC.Models.RatingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housing_RedBadgeMVC.Services
{
   public class RatingService
    {
        private readonly string _userId;

        public RatingService(string userId)
        {
            _userId = userId;
        }

        // Post
        public bool CreateRating(RatingCreate model)
        {
            var entity =
                new SafetyRating()
                {
                    HousingId = model.HousingId,
                    //ApplicantId = model.ApplicantId,
                    Rating = model.Rating,
                    Posted = DateTime.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                entity.ApplicantUser = ctx.Users.Where(e => e.Id == _userId).First();
                ctx.SafetyRatings.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // Get All
        public IEnumerable<RatingListItem> GetRating()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .SafetyRatings.ToList()
                    .Select(
                        e =>
                        new RatingListItem
                        {
                            Id = e.Id,
                            HousingId = e.HousingId,
                            ApplicantId = e.ApplicantId,
                            Rating = e.Rating,
                            Posted = e.Posted
                        }
                        );
                return query.ToArray();
            }
        }

        public RatingDetail GetRatingDetail(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.SafetyRatings.Single(e => e.Id == id);
                var detailedRating = new RatingDetail
                {
                    Id = entity.Id,
                    HousingId = entity.HousingId,
                    ApplicantId = entity.ApplicantId,
                    Rating = entity.Rating,
                    Posted = entity.Posted
                };
                return detailedRating;
            }
        }


        // Update
        public bool UpdateRating(RatingUpdate model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .SafetyRatings
                    .Single(e => e.Id == model.Id);

                entity.Rating = model.Rating;

                return ctx.SaveChanges() == 1;
            }
        }


        // Delete
        public bool DeleteRating(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.SafetyRatings.Single(e => e.Id == id);
                ctx.SafetyRatings.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
