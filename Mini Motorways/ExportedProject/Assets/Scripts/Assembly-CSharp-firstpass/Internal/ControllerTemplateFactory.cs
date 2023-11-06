using System;

namespace Rewired.Internal
{
	// Token: 0x02000012 RID: 18
	public static class ControllerTemplateFactory
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000471E File Offset: 0x0000291E
		public static Type[] templateTypes
		{
			get
			{
				return ControllerTemplateFactory._defaultTemplateTypes;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00004725 File Offset: 0x00002925
		public static Type[] templateInterfaceTypes
		{
			get
			{
				return ControllerTemplateFactory._defaultTemplateInterfaceTypes;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000472C File Offset: 0x0000292C
		public static IControllerTemplate Create(Guid typeGuid, object payload)
		{
			if (typeGuid == GamepadTemplate.typeGuid)
			{
				return new GamepadTemplate(payload);
			}
			if (typeGuid == RacingWheelTemplate.typeGuid)
			{
				return new RacingWheelTemplate(payload);
			}
			if (typeGuid == HOTASTemplate.typeGuid)
			{
				return new HOTASTemplate(payload);
			}
			if (typeGuid == FlightYokeTemplate.typeGuid)
			{
				return new FlightYokeTemplate(payload);
			}
			if (typeGuid == FlightPedalsTemplate.typeGuid)
			{
				return new FlightPedalsTemplate(payload);
			}
			if (typeGuid == SixDofControllerTemplate.typeGuid)
			{
				return new SixDofControllerTemplate(payload);
			}
			return null;
		}

		// Token: 0x040001B1 RID: 433
		private static readonly Type[] _defaultTemplateTypes = new Type[]
		{
			typeof(GamepadTemplate),
			typeof(RacingWheelTemplate),
			typeof(HOTASTemplate),
			typeof(FlightYokeTemplate),
			typeof(FlightPedalsTemplate),
			typeof(SixDofControllerTemplate)
		};

		// Token: 0x040001B2 RID: 434
		private static readonly Type[] _defaultTemplateInterfaceTypes = new Type[]
		{
			typeof(IGamepadTemplate),
			typeof(IRacingWheelTemplate),
			typeof(IHOTASTemplate),
			typeof(IFlightYokeTemplate),
			typeof(IFlightPedalsTemplate),
			typeof(ISixDofControllerTemplate)
		};
	}
}
