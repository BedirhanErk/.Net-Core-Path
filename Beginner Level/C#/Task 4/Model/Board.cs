using System.Reflection.Metadata;

namespace TaskFour
{
    public class Board
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public Sizes Size { get; set; }
        public Lines Line { get; set; }
    }
}