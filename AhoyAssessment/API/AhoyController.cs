using AhoyAssessment.Models;
using AhoyDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AhoyAssessment.API
{
    public class AhoyController : ApiController
    {

        [HttpGet]
        [ActionName("GetUnitById")]
        [Route("api/GetUnit/{id}")]
        public IHttpActionResult GetUnit(int id)
        {
            Unit singleUnit = null;
            AHOYEntities entities = new AHOYEntities();
            singleUnit = entities.Units.FirstOrDefault(e => e.ID == id);
            return Ok(singleUnit);
        }
        [HttpGet]
        [ActionName("GetAllUnit")]
        [Route("api/ahoy/GetAllUnit")]
        public IHttpActionResult GetAllUnit()
        {
            AHOYEntities entities = new AHOYEntities();
            return Ok(entities.Units.ToList());
        }
        [HttpPost]
        [ActionName("GetAvailableRoom")]
        [Route("api/GetAvailableRoom")]
        public IHttpActionResult GetAvailRoom(RequestData requestObj)
        {
            Unit singleUnit = null;
            List<Room> availableRoomList = null;
            AHOYEntities entities = new AHOYEntities();
            var listFilter = entities.Rooms;
            if (!string.IsNullOrEmpty(requestObj.SearchTerm))
            {
                singleUnit = entities.Units.FirstOrDefault(i => i.UnitName.ToLower().Contains(requestObj.SearchTerm.ToLower()));
            }
            var tempListOfRoom = entities.Rooms.Where(i => i.RoomStatus.ToLower().Equals("empty")).ToList();
            if (tempListOfRoom == null)
            {
                return NotFound();
            }
            if (singleUnit != null)
            {
                availableRoomList = tempListOfRoom.Where(i => i.Unit_Id == singleUnit.ID).ToList();
            }
            else
            {
                availableRoomList = tempListOfRoom;
            }
            return Ok(availableRoomList);

        }


        [HttpPost]
        [ActionName("GetTopRated")]
        [Route("api/GetTopRated")]
        public IHttpActionResult GetTopRated()
        {
            List<Unit> singleUnit = null;
            AHOYEntities entities = new AHOYEntities();
            singleUnit = entities.Units.OrderByDescending(i=>i.Rating).Take(3).ToList();
            return Ok(singleUnit);
        }
    }


  






}

//}


