using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connor.Bohlin.Winapp
{
    public partial class AddPokemon : Form
    {
        public AddPokemon()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create an instance of the models.pokemon object class.
            Models.Pokemon pokemon= new Models.Pokemon();
            //Assign the txt boxes from the form to the properties of the pokemon object.
            pokemon.Gender = txtPokemonGender.Text;
            pokemon.Nature = txtPokemonNature.Text; 
            pokemon.Name = txtPokemonName.Text;
            if (int.TryParse(txtPokemonLevel.Text, out _))
            {
                pokemon.Level = Int32.Parse(txtPokemonLevel.Text);
            }
            pokemon.Type = txtPokemonType.Text;
            // After the pokemon object has been filled out we send it to bizlogic.pokemanager
            Bizlogic.PokeManager pokemanager= new Bizlogic.PokeManager();
            pokemon = pokemanager.AddPokemonManage(pokemon);
            lblMessage.Text = pokemon.Message;
            lblMessage.Visible = true;

        }
    }
}
