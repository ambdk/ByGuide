// By: Jesper Højlund
// Description: This class handles JSON file operations for Post objects in the ByGuide
// application. It provides functionality to read from and write to a JSON file,
// managing persistence of post data. The service utilizes the IWebHostEnvironment for
// determining the file path, ensuring compatibility with web hosting environments.

using System.Text.Json;
using ByGuide.Models;

namespace ByGuide.Service
{
    public class JsonFilePostService
    {
        #region Constructor
        public JsonFilePostService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        #endregion

        #region Properties
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string JsonFileName 
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "Posts.json");
            }
        }
        #endregion

        #region Methods
        public void SaveJsonPosts(List<Post> posts)
        {
            using (FileStream jsonFileWriter = File.Create(JsonFileName))
            {
                Utf8JsonWriter jsonWriter = new Utf8JsonWriter(jsonFileWriter, new JsonWriterOptions()
                {
                    SkipValidation = false,
                    Indented = true,
                });
                JsonSerializer.Serialize<Post[]>(jsonWriter, posts.ToArray());
            }
        }

        public IEnumerable<Post> GetJsonPosts()
        {
            using (StreamReader jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Post[]>(jsonFileReader.ReadToEnd());
            }
        }
        #endregion
    }
}
