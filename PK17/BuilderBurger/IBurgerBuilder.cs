using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PK17.BuilderBurger;
using PK17.DBCon;

namespace PK17.BuilderBurger
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddBacon();
        IBurgerBuilder AddCheese();
        IBurgerBuilder AddLetuce();
        IBurgerBuilder AddPickles();
        IBurgerBuilder AddTomato();
        Burgers GetBurgers();
    }
}
