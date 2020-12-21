using Marvel.API.Helpers;
using Marvel.Data;
using Marvel.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Marvel.API.Controllers
{
    [ApiController]
    [Route("v1/public/characters")]
    public class CharacterController : ControllerBase
    {
        public APIHelper helper = new APIHelper();

        [HttpGet, Route("")]
        public async Task<ActionResult<List<Character>>> GetCharacters([FromServices] DataContext context)
        {
            return Ok(await context.Characters.ToListAsync());
        }
        [HttpGet, Route("{characterId:int}")]
        public ActionResult<string> GetCharactersById([FromServices] DataContext context, int characterId)
        {
            var result = helper.RetrieveCharacter(context, characterId);
            return !string.IsNullOrEmpty(result) ? Ok(result) : NotFound();
        }
        [HttpGet, Route("{characterId:int}/comics")]
        public ActionResult<string> GetCharacterComicsById([FromServices] DataContext context, int characterId)
        {
            var result = helper.RetrieveCharacterComics(context, characterId);
            return !string.IsNullOrEmpty(result) ? Ok(result) : NotFound();
        }
        [HttpGet, Route("{characterId:int}/events")]
        public ActionResult<string> GetCharacterEventsById([FromServices] DataContext context, int characterId)
        {
            var result = helper.RetrieveCharacterEvents(context, characterId);
            return !string.IsNullOrEmpty(result) ? Ok(result) : NotFound();
        }
        [HttpGet, Route("{characterId:int}/series")]
        public ActionResult<string> GetCharacterSeriesById([FromServices] DataContext context, int characterId)
        {
            var result = helper.RetrieveCharacterSeries(context, characterId);
            return !string.IsNullOrEmpty(result) ? Ok(result) : NotFound();
        }
        [HttpGet, Route("{characterId:int}/stories")]
        public ActionResult<string> GetCharacterStoriesById([FromServices] DataContext context, int characterId)
        {
            var result = helper.RetrieveCharacterStories(context, characterId);
            return !string.IsNullOrEmpty(result) ? Ok(result) : NotFound();
        }
    }
}