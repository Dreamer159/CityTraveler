using CityTraveler.Domain.Entities;
using CityTraveler.Domain.Errors;
using CityTraveler.Infrastucture.Data;
using CityTraveler.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services
{
    public class ImageService<TEntity> : IImageService<TEntity> where TEntity:ImageModel, IServiceMetadata
    {

        private ApplicationContext _context;
        DbSet<TEntity> _dbset;
        public ImageService(ApplicationContext context)
        {
            _context = context;
        }

        public bool IsActive { get; set ; }
        public string Version { get; set; }

        public async Task<bool> AddNewImage(TEntity image)
        {
            try
            {
                _context.Add(image);
                await _context.SaveChangesAsync();
            }
            catch (ImageServiceException e)
            {

                throw new ImageServiceException("Exception on adding new image!", e);
            }
            return true;
        }

        public async Task<bool> DeleteImage(Guid imageId)
        {
            try
            {
                var image = await _context.Images.FirstOrDefaultAsync(x=>x.Id==imageId);
                _context.Images.Remove(image);
                await _context.SaveChangesAsync();
            }
            catch (ImageServiceException e)
            {

                throw new ImageServiceException("Exception on deleting image!", e);
            }
            return true;
        }

        public TEntity GetImageById(Guid imageId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetImages()
        {
            throw new NotImplementedException();
        }
    }
}
