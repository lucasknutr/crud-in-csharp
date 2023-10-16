namespace CRUD.Contracts.UpsertMovieRequest;

public record UpsertMovieRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet
);