namespace Data.Models
{
    public interface IModel<Model>
    where Model : IModel<Model>
    {
        int ID {get; set;}
        Model Empty {get;}
    }
}
