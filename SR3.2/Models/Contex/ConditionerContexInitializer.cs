using SR3._2.Models.Device;
using System.Data.Entity;

namespace SR3._2.Models.Contex
{
    public class ConditionerContexInitializer : DropCreateDatabaseAlways<ConditionerContex>
    {
        protected override void Seed(ConditionerContex context)
        {
            context.Conds.Add(new Conditioner { Id = 1, state = true, max = 90, min = 10, temp = 23 });
        }
    }
}