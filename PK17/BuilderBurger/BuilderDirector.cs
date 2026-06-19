using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PK17.DBCon;
using PK17.BuilderBurger;

namespace PK17.BuilderBurger
{
    public class BuilderDirector
    {
        private readonly IBurgerBuilder _builder;

        public BuilderDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildDefoult()
        {
            _builder
            .AddCheese()
            .AddTomato()
            .AddPickles();
        }

        public void BuildWithBeacon()
        {
            _builder
            .AddTomato()
            .AddBacon()
            .AddLetuce();
        }
    }
}
