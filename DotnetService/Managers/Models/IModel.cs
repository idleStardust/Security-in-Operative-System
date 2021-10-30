namespace Managers.Models
{
    public interface IModel<Model>
    where Model: IModel<Model>
    {
        Model Empty{get;}
    }
}
