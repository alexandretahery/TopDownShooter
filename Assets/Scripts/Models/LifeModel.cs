using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Models
{
    public class LifeModel
    {
        public float MaxLife {get; set;}
        public float ActualLife { get; set; }

        public LifeModel(float maxLifeInput) 
        {
            MaxLife = maxLifeInput;
            ActualLife = MaxLife;
        }

    }
}
