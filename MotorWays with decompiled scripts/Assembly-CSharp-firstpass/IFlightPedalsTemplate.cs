using System;

namespace Rewired
{
	// Token: 0x02000006 RID: 6
	public interface IFlightPedalsTemplate : IControllerTemplate
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060000D1 RID: 209
		IControllerTemplateAxis leftPedal { get; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060000D2 RID: 210
		IControllerTemplateAxis rightPedal { get; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060000D3 RID: 211
		IControllerTemplateAxis slide { get; }
	}
}
