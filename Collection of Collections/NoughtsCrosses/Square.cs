using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsCrosses
{
	public enum Player { None = 0, Noughts, Crosses }

	//Starts Empty as default
	public struct Square
	{
		public Square(Player owner)
		{
			this.Owner = owner;
		}

		public Player Owner { get; }

		public override string ToString()
		{
			switch (Owner)
			{
				case Player.None:
					return ".";
				case Player.Crosses:
					return "X";
				case Player.Noughts:
					return "O";
				default:
					throw new Exception("Invalid state");
			}
		}
	}
}

