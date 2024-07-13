namespace Basic.Models
{
    public class Repository
    {
        private static readonly List<Bootcamp> _bootcamps = new();

        static Repository()
        {
            _bootcamps = new List<Bootcamp>(){
                new Bootcamp() { Id = 1,
                                Title = "Full Stack Bootcamp",
                                Description = "Bootcamp süreci başladı.",
                                Image = "1.png",
                                Tags= new string[]{"Html","Web Geliştirme"},
                                isActive=true,
                                isHome=true },
                new Bootcamp() { Id = 2,
                                Title = "Game Bootcamp",
                                Description = "Bootcamp süreci başladı.",
                                Image = "2.png",
                                Tags= new string[]{"Game","Web Geliştirme"},
                                isActive=true,
                                isHome=true },
                new Bootcamp() { Id = 3,
                                Title = "Backend Bootcamp",
                                Description = "Bootcamp süreci başladı.",
                                Image = "3.png" ,
                                Tags= new string[]{"Asp.NET","Web Geliştirme"},
                                isActive=true,
                                isHome=false },
            };
        }

        public static List<Bootcamp> Bootcamps
        {
            get
            {
                return _bootcamps;
            }
        }

        public static Bootcamp? GetById(int? id)
        {
            return _bootcamps.FirstOrDefault(b => b.Id == id);
        }
    }
}