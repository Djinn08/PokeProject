using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connor.Bohlin.Bizlogic
{
    public class PokeManager
    {
       public Models.Pokemon AddPokemonManage(Models.Pokemon mPokemon)
        {

            //THis is the first step into the bizlogic project.   //
            //Send to PokeValidation to get Validated.
            // If the validation was successful, we will convert our models.pokemon to a database models.pokemon
            //If the validation was not successful, we will simply send the models.pokemon back to the form to display an error message.
          Validation.PokeValidation pokeValidation= new Validation.PokeValidation();
            mPokemon = pokeValidation.ValidatePokemon(mPokemon);

            if (string.IsNullOrEmpty(mPokemon.Message)) 
            {
                mPokemon.Message = "Pokemon Added Yay";
            }

            return mPokemon;


        }
    }
}
