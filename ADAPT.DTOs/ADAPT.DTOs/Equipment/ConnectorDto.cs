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
using System;

namespace ADAPT.DTOs.Equipment
{
	public class ConnectorDto : BaseDto
	{
		const string Parent = "EquipmentConfigurationId";

		public ConnectorDto() : base(Parent, "EquipmentConfigurationId", "DeviceElementConfiguration")
		{

		}

		//[JsonProperty(PropertyName = EntityId, Order = -2)]
		//public Guid Guid { get; set; }

		public string Description { get; set; }

		[JsonIgnore]
		[JsonProperty(PropertyName = Parent)]
		public Guid EquipmentConfigurationGuid { get; set; }

		public HitchPointDto HitchPoint { get; set; }

		public Guid DeviceElementConfigurationGuid { get; set; }

	}
}