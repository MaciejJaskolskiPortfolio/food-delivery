using AutoMapper;
using Bogus;
using Bogus.Extensions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Infra.Seed
{
    public static class AddressSeed
    {
        public static void AddAddresses(ModelBuilder builder)
        {
            var addressId = 1;
            var addressFaker = new Faker<Address>()
                .RuleFor(a => a.Id, _ => ++addressId)
              .RuleFor(a => a.City, f => f.Address.City())
              .RuleFor(a => a.Street, f => f.Address.StreetName())
              .RuleFor(a => a.ApartmentNumber, f => f.Address.BuildingNumber())
              .RuleFor(a => a.HouseNumber, f => f.Address.BuildingNumber())
              .RuleFor(a => a.PostalCode, f => f.Address.ZipCode())
              .RuleFor(a => a.AdditionalInfo, f => f.Random.Word().OrNull(f));

            var seedAdresses = addressFaker.Generate(10);

            var addresses = builder.Entity<Address>().HasData(
                seedAdresses
            );
        }
    }
}
