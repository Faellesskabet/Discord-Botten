namespace Dikubot.DataLayer.Database.Global;

/// <summary>
///     Class for for retrieving information from a given collection.
/// </summary>
public abstract class GlobalMongoService<TModel> : MongoService<TModel> where TModel : MainModel
{
    /// <summary>
    ///     Constructor for the services.
    /// </summary>
    protected GlobalMongoService(Database database) : base(database, "KULIV_GLOBAL")
    {
    }
}