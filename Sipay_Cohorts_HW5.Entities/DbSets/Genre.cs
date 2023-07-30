using Sipay_Cohorts_HW5.Entities.BaseModel;

namespace Sipay_Cohorts_HW5.Entities.DbSets
{
    public class Genre: BaseEntity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
       public List<Genre> Books { get; set; }
    }
}
