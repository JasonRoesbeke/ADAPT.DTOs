using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAPT.DTOs.Equipment
{
	public class EndgunConfigurationDto : DeviceElementConfigurationDto
	{
		public EndgunTableEntryDto NominalValues { get; set; }
		public EndgunTableDto TabularValues { get; set; }
	}
}
