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
using Newtonsoft.Json;
using ADAPT.DTOs.Common;

namespace ADAPT.DTOs.LoggedData
{
	public class NumericWorkingDataDto : WorkingDataDto
	{
		[JsonProperty(Order = 2)]
		public UnitOfMeasureDto UnitOfMeasure { get; set; }
	}
}
