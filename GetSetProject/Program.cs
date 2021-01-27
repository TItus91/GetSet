using System;

namespace GetSetProject
{
	class Entity
	{
		public Entity(string _name)
		{
			name = _name;
		}

		public Entity()
		{
			name = null;
		}

		private string name;
		public string Name { get; set; }
		public string Name2;
		public string Name3
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
				Console.WriteLine($"set name to: {name}");
			}
		}

		public string GetName()
		{
			return Name + ' ' + Name2 + ' ' + name;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Entity czlowiek = new Entity();
			czlowiek.Name = "Jan";
			czlowiek.Name2 = "Tomasz";
			czlowiek.Name3 = "Kowalski";
			Console.WriteLine($"Hello {czlowiek.Name} {czlowiek.Name2} {czlowiek.Name3}");
			Console.WriteLine($"Hello {czlowiek.GetName()}");
		}
	}

	
	
}
