using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.DTO;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces;

public interface IPokemonRepository
{
    ICollection<Pokemon> GetPokemons();
    DataContext GetContext();
    Pokemon GetPokemon(int id);
    Pokemon GetPokemon(string name);
    decimal GetPokemonRating(int pokemonId);
    bool PokemonExists(int PokemonId);
}    
