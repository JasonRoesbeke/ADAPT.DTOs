using System;
using System.Collections.Generic;
using System.Text;
using ADAPT.DTOs.Representations;

namespace ADAPT.DTOs.Equipment
{
	public class EndgunTableEntryDto
	{
		public NumericRepresentationValueDto Pressure { get; set; }
		public NumericRepresentationValueDto FlowValue { get; set; }
		public NumericRepresentationValueDto ThrowValue { get; set; }
	}
}
