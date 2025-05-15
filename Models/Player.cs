namespace HawksStats25.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public double? BattingAverage { get; set; }
        public double? EarnedRunAverage { get; set; }
        
        public Player() 
        {

        }
    }
}
