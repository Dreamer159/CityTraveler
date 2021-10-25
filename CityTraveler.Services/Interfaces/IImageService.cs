using CityTraveler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface IImageService<T> where T:ImageModel, IServiceMetadata
    {

        public Task<bool> AddNewImage(T image);
        public Task<bool> DeleteImage(Guid imageId);

        public IEnumerable<T>GetImages();
        public T GetImageById(Guid imageId);
    }
}
