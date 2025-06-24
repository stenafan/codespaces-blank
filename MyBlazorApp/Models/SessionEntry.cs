using MyBlazorApp.Models;
namespace MyBlazorApp.Models
{
    public class SessionEntry
    {
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double Weight { get; set; }
        public Exercise? Exercise { get; set; }
    }
}
