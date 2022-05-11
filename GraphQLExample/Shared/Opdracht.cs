using System;
namespace GraphQLExample.Shared
{
	public class Opdracht
	{
        public int Id { get; set; }

        public DateTime DatumAanvraag { get; set; }

        public DateTime BeginTijd { get; set; }

        public int AantalUur { get; set; }


        public Opdracht()
		{
		}
	}
}

