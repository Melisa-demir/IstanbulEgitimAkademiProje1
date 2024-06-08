﻿using EventProjectWeb.DTO.Event;
using EventProjectWeb.Model.ORM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventProjectWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventProjectContext _db;
        public EventController(EventProjectContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<GetAllEventsResponseDto> model = _db.Events.Where(x => x.IsDeleted == false).Select(x => new GetAllEventsResponseDto
            {
                Id = x.Id,
                Name = x.Name,
                Address = x.Address,
                DetailedDescription = x.DetailedDescription,
                GoogleMapLink = x.GoogleMapLink
            }).ToList();

            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var _event = _db.Events.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);

            if (_event == null)
            {
                return NotFound();
            }

            GetEventResponseDto model = new GetEventResponseDto();
            model.Id = _event.Id;
            model.Name = _event.Name;
            model.Address = _event.Address;
            model.DetailedDescription = _event.DetailedDescription;
            model.GoogleMapLink = _event.GoogleMapLink;

            return Ok(model);
        }

        [HttpPost]
        public IActionResult Post(CreateEventRequestDto model)
        {
            var entity = new Event
            {
                Name = model.Name,
                DetailedDescription = model.DetailedDescription,
                Address = model.Address,
                GoogleMapLink=model.GoogleMapLink
            };

            _db.Events.Add(entity);
            _db.SaveChanges();

            return Ok(model);
        }

        // delete category
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _db.Events.FirstOrDefault(x => x.Id == id);

            if (entity == null)
            {
                return NotFound();
            }
            else
            {
                entity.IsDeleted = true;
                _db.SaveChanges();

                return Ok();
            }
        }


        [HttpPut("{id}")] // api/event/{id}
        public IActionResult Update(int id, UpdateRequestEventDto model)
        {
            var _event = _db.Events.FirstOrDefault(x => x.Id == id && x.IsDeleted == false);

            if (_event == null)
            {
                return NotFound();
            }
            else
            {
                _event.Name = model.Name;
                _db.SaveChanges();

                return Ok(model);
            }
        }
    }
}