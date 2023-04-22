using Connor.Bohlin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation

{
    internal class PokeValidation
    {
        // Make function for validating pokemon to make sure that all text boxes are filled out
        internal Pokemon ValidatePokemon(Pokemon pokemon)
        {
            if (String.IsNullOrEmpty(pokemon.Name))
            {
                pokemon.Message += "Pokemon Name is missing!";
            }
            if (String.IsNullOrEmpty(pokemon.Gender))
            {
                pokemon.Message += "Pokemon Gender is missing!";
            }
            if (String.IsNullOrEmpty(pokemon.Nature))
            {
                pokemon.Message += "Pokemon Nature is missing!";
            }
            if (String.IsNullOrEmpty(pokemon.Type))
            {
                pokemon.Message += "Pokemon Type is missing!";
            }
            if (pokemon.Level <= 0)
            {
                pokemon.Message += "Pokemon Cannot be below Level 0!";
            }
            return pokemon;


        }

    }
}
