using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Entities.Concrete
{
      public class AddCarDto : IDto
      {
            public int? ModelId { get; set; }
            public int? BrandId { get; set; }
            public int? ColorId { get; set; }
            public int DailyPrice { get; set; }
            public string ModelYear { get; set; }
            public string Description { get; set; }
            public IFormFile file { get; set; }
      }
}
