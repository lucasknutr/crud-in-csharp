namespace CRUD.Contracts.Breakfast.AddMovieRequest;

public record CreateMovietRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);
