namespace LooklingGlassShooting.Models
{
    public class Player
    {
        public int Life { get; set; }
        public SeasonFormat Season { get; set; }
    }

    public enum SeasonFormat
    {
        Spring,Summer,Fall,Winter
    }
}

