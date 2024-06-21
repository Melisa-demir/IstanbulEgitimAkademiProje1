using EventProjectWeb.DTO.Activity;
using EventProjectWeb.Model.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventProjectWeb.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityEventsImagesController : ControllerBase
    {
        private readonly EventProjectContext _db;

        public ActivityEventsImagesController(EventProjectContext db)
        {
            _db = db;
        }
        [HttpPost]
        public IActionResult Post(CreateActivityRequestDTO model)
        {
            //var imageNames = int()
           //List<string> imagePaths = new List<string>();
           // foreach (var image in model.Images)
           // {
           //     string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", image.FileName);
           //     using (var stream = new FileStream(path,FileMode.Create))
           //     {
           //         image.CopyTo(stream);
           //     }
           //     imagePaths.Add(image.FileName);
           // }
            return Ok();
    }
}
}
