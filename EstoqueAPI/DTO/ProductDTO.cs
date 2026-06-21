namespace EstoqueAPI.DTO
{
    public record ProductDTO(string Name, string EAN, int Amount, DateOnly Validate);
}
