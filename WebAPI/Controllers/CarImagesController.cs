﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : Controller
    {
        ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService) {
            _carImageService = carImageService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile? file, [FromForm] int carId) 
        {
            var carImage = new CarImage() { CarId = carId};
            var result = _carImageService.Add(file, carImage, carId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage) {
            var carDeleteImage = _carImageService.GetByImageId(carImage.Id).Data;
            var result = _carImageService.Delete(carDeleteImage);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] CarImage carImage) {
            var result = _carImageService.Update(file, carImage);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll() {
            var result = _carImageService.GetAll();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetByCarId(int id) {
            var result = _carImageService.GetByCarId(id);
            if (result.Success) {
                return Ok(result);
            }
            return Ok(result);
        }

        [HttpGet("getbyimageid")]
        public IActionResult GetByImageId(int imageId) {
            var result = _carImageService.GetByImageId(imageId);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

