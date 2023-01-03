using System;
using System.Collections.Generic;

namespace FitnessApp.Models
{
	public class Transformations
	{
		public Transformations()
		{
		}

        public string Image { get; set; }
        public string Name { get; set; }
        

        public List<Transformations> list;
        public List<Transformations> GetResult()
        {
            list = new List<Transformations>()
            {
                new Transformations()
                {
                    Image = "https://www.health.com/thmb/CDtX9VinuuaitSa0FOPTzBkdjnc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/15-erica-stepteau-i-did-it-october-1e5789471f1c4f778d515ae448687866.jpg",
                    Name = "Victor",                   
                },


                new Transformations()
                {
                    Image = "https://i.ytimg.com/vi/IU9kB0SXh5g/maxresdefault.jpg",
                    Name = "Anthony",                   
                },

                new Transformations()
                {
                    Image = "https://www.afspremier.com/wp-content/uploads/2019/05/Katie-transformation-at-AFS-Premier-Fitness-750x750.jpg",
                    Name = "Angelina",                  
                },

                new Transformations()
                {
                    Image = "https://i.ytimg.com/vi/L4-QpckHfNo/maxresdefault.jpg",
                    Name = "Justin",                 
                },

            };
            return list;
        }
    }
}

