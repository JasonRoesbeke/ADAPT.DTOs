﻿/*******************************************************************************
  * Copyright (C) 2019 AgGateway and ADAPT Contributors
  * Copyright (C) 2019 CNH Industrial N.V.
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v20.html
  *
  * Contributors:
  *    Jason Roesbeke - Initial version.
  *******************************************************************************/
using AgGateway.ADAPT.ApplicationDataModel.Common;
using Newtonsoft.Json;
using ADAPT.DTOs.Common;

namespace ADAPT.DTOs.LoggedData
{
	public class EnumeratedWorkingDataDto : WorkingDataDto
	{
		[JsonProperty(Order = 2)]
		public UnitOfMeasureDto UnitOfMeasureDto = new UnitOfMeasureDto()
		{
			Code = "unitless",
			Dimension = UnitOfMeasureDimensionEnum.Unitless.ToString(),
		};
	}
}
