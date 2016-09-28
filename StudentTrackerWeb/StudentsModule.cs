namespace StudentTrackerWeb
{
    using Nancy;

    public class StudentsModule : NancyModule
    {
        public StudentsModule() : base("/students")
        {
            Get("/", _ => "Hello World");
            Get("/hello", _ => "This is my other page");
        }
    }
}
