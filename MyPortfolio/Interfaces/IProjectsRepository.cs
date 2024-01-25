using MyPortfolio.Models;

namespace MyPortfolio.Interfaces
{
	public interface IProjectsRepository
	{
		List<ProjectDTO> GetProjectsDTO();
	}
}
