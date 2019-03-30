using UnityEngine;

namespace LooklingGlassShooting.Models
{
    public class Player: MonoBehaviour
    {
        public int Life { get; set; }
        public SeasonFormat Season { get; set; }

        public Player(): base()
        {
            Life = 100;
        }
    }

    public enum SeasonFormat
    {
        Spring,Summer,Fall,Winter
    }
}

