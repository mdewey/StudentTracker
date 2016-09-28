namespace StudentTrackerWeb
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", _ => "Hello World");
            Get("/hello", _ => "This is my other page");
        }
    }
}
