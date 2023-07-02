using LandingPage.Models;

namespace LandingPage.Services
{
	public interface IConstructionIdeasRepository
	{
		public List<ConstructionIdea> GetIdeas();
	}
	public class ConstructionIdeasRepository : IConstructionIdeasRepository
	{
		public List<ConstructionIdea> GetIdeas()
		{
			return new List<ConstructionIdea>()
			{
				new ConstructionIdea()
				{
					Title= "Windmill",
					Description = "A great tiny cilindric old white solid lego windmill",
					ImageURL = "/images/windmill_-removebg-preview.png",
					URL = ""
				},
				new ConstructionIdea()
				{
					Title = "Piano",
					Description = "An adorable small cubic gold lego piao",
					ImageURL = "/images/piano_-removebg-preview.png",
					URL = ""
				},
				new ConstructionIdea()
				{
					Title = "Fishes",
					Description = "A cute big rectangular blue lego aquarium",
					ImageURL = "/images/fishes_-removebg-preview.png",
					URL = ""
				},
				new ConstructionIdea()
				{
					Title = "Dancer",
					Description = "A beautifull mini agile young purple ballet dancer",
					ImageURL = "/images/dancer_-removebg-preview.png",
					URL = ""
				},
				new ConstructionIdea()
				{
					Title = "Parrot",
					Description = "A lovely huge triangular young yellow parrot on a tree",
					ImageURL = "/images/parrot_-removebg-preview.png",
					URL = ""
				},
				new ConstructionIdea()
				{
					Title = "Apple",
					Description = "A delicious big spherical bite new red apple with a worm",
					ImageURL = "/images/apple_-removebg-preview.png",
					URL = ""
				},
				new ConstructionIdea()
				{
					Title = "Helicopter",
					Description = "A fast massive new green helicopter",
					ImageURL = "/images/helicopter_-removebg-preview.png",
					URL = ""
				}
			};
		}
	}
}
