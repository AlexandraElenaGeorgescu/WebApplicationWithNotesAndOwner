using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class NotesController : ControllerBase
    {
        static List<Notes> _notes = new List<Notes> {
        new Notes {
            Id = new System.Guid(), 
            CategoryId = "1", 
            OwnerId = new System.Guid(), 
            Title = "First Note",
            Description = "First Note Description"
        },
        new Notes { 
            Id = new System.Guid("833400e7-30cb-494b-887d-139d7a193451"), 
            CategoryId = "1", 
            OwnerId = new System.Guid(), 
            Title = "Second Note", 
            Description = "Second Note Description" 
        },
        new Notes { 
            Id = new System.Guid(), 
            CategoryId = "1", 
            OwnerId = new System.Guid(), 
            Title = "Third Note", 
            Description = "Third Note Description" },
        new Notes { 
            Id = new System.Guid(), 
            CategoryId = "1", 
            OwnerId = new System.Guid(), 
            Title = "Fourth Note", 
            Description = "Fourth Note Description" },
        new Notes { 
            Id = new System.Guid(), 
            CategoryId = "1", 
            OwnerId = new System.Guid(), 
            Title = "Fifth Note", 
            Description = "Fifth Note Description" }
        };
        public NotesController()
        { 
        
        }
      
        [HttpGet]
        public IActionResult GetNotes()
        {
            return Ok(_notes);
        }

        [HttpPost]
        public IActionResult CreateNotes([FromBody] Notes note)
        {
            if (note == null)
            {
                return BadRequest("Note cannot be null");
            }
            _notes.Add(note);
            return Ok();
            //return StatusCode(StatusCodes.Status500InternalServerError, "Error in processing the note");
        }
        [HttpGet("OwnerId/{id}")]
        public IActionResult GetByOwnerId(Guid id)
        {
            List<Notes> note=_notes.FindAll(note => note.OwnerId==id);
            return Ok(note); 
        }

        [HttpGet(" Id/{id}")]
        public IActionResult GetByNoteId(Guid id)
        {
            List<Notes> note = _notes.FindAll(note => note.Id == id);
            return Ok(note);
        }


        /*///List<string> myList = new List<string> { "test1", "test2", "test3" };

        /// <summary>
        /// Returns the notes collection
        /// </summary>
        /// <return></return>
        ///[HttpGet("{id}")]
        ///public IActionResult GetWithParams(string id, string id2, string id3)
        /// {
        ///   return Ok($"id:{ id}, id2: { id2},id3: { id3}");

        ///}
        /// <summary>
        /// Returns a list of notes
        /// </summary>
        /// <returns></returns>
        ///[HttpGet("")]
       /// public IActionResult Get()
        ///{
          ///  return Ok("FROM GET");

        ///}

    /// <summary>
    /// Returns the notes collection
    /// </summary>
    /// <param name="bodyContent"></param>
    /// <returns></returns>
        [HttpPost("")]
        public IActionResult Post([FromBody] string bodyContent)
        {
            myList.Add(bodyContent);
        }
        /// <summary>
        /// REturns the notes collection
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
         [HttpDelete("{id}")]
       public IActionResult Delete( string id)
        {
            myList.Remove(id);
        }*/


    }
}
