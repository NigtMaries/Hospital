
namespace Hospital.Domen.Models
{

    public abstract class Base
    {
        public int Id { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
    }

}