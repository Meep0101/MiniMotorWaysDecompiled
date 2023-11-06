using System;

namespace Rewired
{
	// Token: 0x02000002 RID: 2
	public interface IGamepadTemplate : IControllerTemplate
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		IControllerTemplateButton actionBottomRow1 { get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2
		IControllerTemplateButton a { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3
		IControllerTemplateButton actionBottomRow2 { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4
		IControllerTemplateButton b { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5
		IControllerTemplateButton actionBottomRow3 { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6
		IControllerTemplateButton c { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000007 RID: 7
		IControllerTemplateButton actionTopRow1 { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000008 RID: 8
		IControllerTemplateButton x { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000009 RID: 9
		IControllerTemplateButton actionTopRow2 { get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000A RID: 10
		IControllerTemplateButton y { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000B RID: 11
		IControllerTemplateButton actionTopRow3 { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000C RID: 12
		IControllerTemplateButton z { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600000D RID: 13
		IControllerTemplateButton leftShoulder1 { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600000E RID: 14
		IControllerTemplateButton leftBumper { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600000F RID: 15
		IControllerTemplateAxis leftShoulder2 { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000010 RID: 16
		IControllerTemplateAxis leftTrigger { get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000011 RID: 17
		IControllerTemplateButton rightShoulder1 { get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000012 RID: 18
		IControllerTemplateButton rightBumper { get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000013 RID: 19
		IControllerTemplateAxis rightShoulder2 { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000014 RID: 20
		IControllerTemplateAxis rightTrigger { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000015 RID: 21
		IControllerTemplateButton center1 { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000016 RID: 22
		IControllerTemplateButton back { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000017 RID: 23
		IControllerTemplateButton center2 { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000018 RID: 24
		IControllerTemplateButton start { get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000019 RID: 25
		IControllerTemplateButton center3 { get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600001A RID: 26
		IControllerTemplateButton guide { get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600001B RID: 27
		IControllerTemplateThumbStick leftStick { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600001C RID: 28
		IControllerTemplateThumbStick rightStick { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600001D RID: 29
		IControllerTemplateDPad dPad { get; }
	}
}
