using Marvel.Data;
using Marvel.Data.Helpers;
using Newtonsoft.Json;

namespace Marvel.API.Helpers
{
    public class APIHelper
    {
        DataHelper helper = new DataHelper();

        public string RetrieveCharacter(DataContext context, int characterId)
        {
            var output = string.Empty;
            var character = helper.RetrieveCharacterById(context, characterId).Result;
            if (character != null)
                output = JsonConvert.SerializeObject(character);
            return output;
        }

        public string RetrieveCharacterComics(DataContext context, int characterId)
        {
            var output = string.Empty;
            var character = helper.RetrieveCharacterById(context, characterId).Result;
            if (character != null && character.Comics != null)
                output = JsonConvert.SerializeObject(character.Comics);
            return output;
        }

        public string RetrieveCharacterEvents(DataContext context, int characterId)
        {
            var output = string.Empty;
            var character = helper.RetrieveCharacterById(context, characterId).Result;
            if (character != null && character.Events != null)
                output = JsonConvert.SerializeObject(character.Events);
            return output;
        }

        public string RetrieveCharacterSeries(DataContext context, int characterId)
        {
            var output = string.Empty;
            var character = helper.RetrieveCharacterById(context, characterId).Result;
            if (character != null && character.Series != null)
                output = JsonConvert.SerializeObject(character.Series);
            return output;
        }

        public string RetrieveCharacterStories(DataContext context, int characterId)
        {
            var output = string.Empty;
            var character = helper.RetrieveCharacterById(context, characterId).Result;
            if (character != null && character.Stories != null)
                output = JsonConvert.SerializeObject(character.Stories);
            return output;
        }

        public void AddFakerWithBogus()
        {

        }

    }
}