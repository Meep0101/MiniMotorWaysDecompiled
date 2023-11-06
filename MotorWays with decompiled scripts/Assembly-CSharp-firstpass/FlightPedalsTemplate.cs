using System;

namespace Rewired
{
	// Token: 0x0200000C RID: 12
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
	{
		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000292C File Offset: 0x00000B2C
		IControllerTemplateAxis IFlightPedalsTemplate.leftPedal
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(0);
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002935 File Offset: 0x00000B35
		IControllerTemplateAxis IFlightPedalsTemplate.rightPedal
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(1);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000293E File Offset: 0x00000B3E
		IControllerTemplateAxis IFlightPedalsTemplate.slide
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(2);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002947 File Offset: 0x00000B47
		public FlightPedalsTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x0400014F RID: 335
		public static readonly Guid typeGuid = new Guid("f6fe76f8-be2a-4db2-b853-9e3652075913");

		// Token: 0x04000150 RID: 336
		public const int elementId_leftPedal = 0;

		// Token: 0x04000151 RID: 337
		public const int elementId_rightPedal = 1;

		// Token: 0x04000152 RID: 338
		public const int elementId_slide = 2;
	}
}
