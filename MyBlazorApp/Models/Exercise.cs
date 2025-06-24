namespace MyBlazorApp.Models
{
    public class Exercise
    {
        public int Id { get; set; }  // optional - if using DB
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;  // e.g. "Strength", "Cardio"
    }
}