using System;

namespace Data.Models
{
    public interface IModel<Model>
    where Model : IModel<Model>
    {
        Guid ID {get; set;}
        Model Empty {get;}
    }
}
