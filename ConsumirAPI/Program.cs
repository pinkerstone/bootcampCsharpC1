using System.Text;
using System.Text.Json;

class Program
{
    
    static void Main()
    {
        PostCourse();
        GetCourses();
        Console.ReadLine();
    }
    static async void GetCourses()
    {
        HttpClient httpclient = new HttpClient();
        string url = "https://localhost:7116/api/Courses/Get";

        HttpResponseMessage response = await httpclient.GetAsync(url);
        
        if (response.IsSuccessStatusCode == true)
        {
            string jsonResponse = await response.Content.ReadAsStringAsync();
            //Convertir Json en lista de Objeto
            List<Course> courses = JsonSerializer.Deserialize<List<Course>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
            foreach (var item in courses)
            {
                Console.WriteLine(item.CourseID + " " + item.CourseName + " " + item.Credit);
            }

            Console.WriteLine(jsonResponse);
        }

    }
    
    static async void PostCourse()
    {
        HttpClient httpClient = new HttpClient();
        string url = "https://localhost:7116/api/Courses/Insert";

        Course course = new Course
        {
            CourseName = "Quimica",
            Credit = 2,
            Enable = true
        };
        //Convertir de objeto a json
        string jsonRequest = JsonSerializer.Serialize(course);
        //Armado de contenido para envío
        HttpContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await httpClient.PostAsync(url, content);

        if (response.IsSuccessStatusCode == true)
        {
            Console.WriteLine("Registro correcto");
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }

}

public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public int Credit { get; set; }
    public bool? Enable { get; set; }
}
