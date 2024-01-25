using MyPortfolio.Models;
using MyPortfolio.Interfaces;

namespace MyPortfolio.Repositories
{
	public class ProjectsRepository : IProjectsRepository
	{
		public List<ProjectDTO> GetProjectsDTO()
		{
			return new List<ProjectDTO>() {
				new ProjectDTO
				{
					Title = "Home",
					Description = "Home",
					Link = "https://amazon.com",
					ImageURL = "/images/imageProject.webp",
				},
				new ProjectDTO
				{
					Title = "Home",
					Description = "Home",
					Link = "https://amazon.com",
					ImageURL = "/images/imageProject.webp",
				},
				new ProjectDTO
				{
					Title = "Home",
					Description = "Home",
					Link = "https://amazon.com",
					ImageURL = "/images/imageProject.webp",
				},
				new ProjectDTO
				{
					Title = "Home",
					Description = "Home",
					Link = "https://amazon.com",
					ImageURL = "/images/imageProject.webp",
				},
			};
		}
	}
}
