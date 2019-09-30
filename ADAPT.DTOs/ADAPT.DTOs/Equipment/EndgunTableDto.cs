using System.Collections.Generic;

namespace ADAPT.DTOs.Equipment
{
	public class EndgunTableDto
	{
		public EndgunTableDto()
		{
			TableEntries = new List<EndgunTableEntryDto>();
		}
		public List<EndgunTableEntryDto> TableEntries { get; set; }
	}
}