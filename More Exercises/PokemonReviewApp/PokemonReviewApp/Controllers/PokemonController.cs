using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PokemonReviewApp.DTO;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using PokemonReviewApp.Repository;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : Controller
{
    private readonly IPokemonRepository _pokemonRepository;

    public PokemonController(IPokemonRepository pokemonRepository)
    {
        _pokemonRepository = pokemonRepository;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<PokemonDTO>))]
    public async Task<IActionResult> GetPokemons()
    {
        //var pokemons = _pokemonRepository.GetPokemons();

        return (IActionResult)await _pokemonRepository.GetContext().Pokemon
            .Select(x => PokemonToDTO(x)).ToListAsync();

        //var pokemons = _pokemonRepository.GetPokemons();

        //if (!ModelState.IsValid)
        //    return BadRequest(ModelState);

        //return Ok(pokemons);
    }

    [HttpGet("{pokemonId}")]
    [ProducesResponseType(200, Type = typeof(Pokemon))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemon(int pokemonId)
    {
        if (!_pokemonRepository.PokemonExists(pokemonId))
            return NotFound();

        var pokemon = _pokemonRepository.GetPokemon(pokemonId);

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(pokemon);
    }

    [HttpGet("{pokemonId}/rating")]
    [ProducesResponseType(200, Type = typeof(decimal))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemonRating(int pokemonId)
    {
        if (!_pokemonRepository.PokemonExists(pokemonId))
            return NotFound();

        var rating = _pokemonRepository.GetPokemonRating(pokemonId);

        if (!ModelState.IsValid)
            return BadRequest();

        return Ok(rating);
    }

    private static PokemonDTO PokemonToDTO(Pokemon pokemon) =>
       new PokemonDTO
       {
           Id = pokemon.Id,
           Name = pokemon.Name,
       };
}
