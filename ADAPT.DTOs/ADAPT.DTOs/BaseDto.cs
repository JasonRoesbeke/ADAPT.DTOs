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
using System.Collections.Generic;

namespace ADAPT.DTOs
{
	public class BaseDto
	{
		public const string EntityId = "@Id";

		public BaseDto(string parentPropertyName = null, params string[] otherDetailProperties)
		{
			JsonDetailProperties = new List<string>();
			if (parentPropertyName != null || parentPropertyName != "")
			{
				JsonDetailProperties.Add(parentPropertyName);
			}
			if (otherDetailProperties != null)
			{
				JsonDetailProperties.AddRange(otherDetailProperties);
			}
		}

		[JsonIgnore]
		public List<string> JsonDetailProperties { get; }

		[JsonIgnore]
		public int ReferenceId { get; set; }
	}
}
