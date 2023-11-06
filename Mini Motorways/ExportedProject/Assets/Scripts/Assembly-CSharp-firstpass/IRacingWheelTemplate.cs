using System;

namespace Rewired
{
	// Token: 0x02000003 RID: 3
	public interface IRacingWheelTemplate : IControllerTemplate
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600001E RID: 30
		IControllerTemplateAxis wheel { get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600001F RID: 31
		IControllerTemplateAxis accelerator { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000020 RID: 32
		IControllerTemplateAxis brake { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000021 RID: 33
		IControllerTemplateAxis clutch { get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000022 RID: 34
		IControllerTemplateButton shiftDown { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000023 RID: 35
		IControllerTemplateButton shiftUp { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000024 RID: 36
		IControllerTemplateButton wheelButton1 { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000025 RID: 37
		IControllerTemplateButton wheelButton2 { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000026 RID: 38
		IControllerTemplateButton wheelButton3 { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000027 RID: 39
		IControllerTemplateButton wheelButton4 { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000028 RID: 40
		IControllerTemplateButton wheelButton5 { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000029 RID: 41
		IControllerTemplateButton wheelButton6 { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600002A RID: 42
		IControllerTemplateButton wheelButton7 { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600002B RID: 43
		IControllerTemplateButton wheelButton8 { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600002C RID: 44
		IControllerTemplateButton wheelButton9 { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600002D RID: 45
		IControllerTemplateButton wheelButton10 { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600002E RID: 46
		IControllerTemplateButton consoleButton1 { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600002F RID: 47
		IControllerTemplateButton consoleButton2 { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000030 RID: 48
		IControllerTemplateButton consoleButton3 { get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000031 RID: 49
		IControllerTemplateButton consoleButton4 { get; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000032 RID: 50
		IControllerTemplateButton consoleButton5 { get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000033 RID: 51
		IControllerTemplateButton consoleButton6 { get; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000034 RID: 52
		IControllerTemplateButton consoleButton7 { get; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000035 RID: 53
		IControllerTemplateButton consoleButton8 { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000036 RID: 54
		IControllerTemplateButton consoleButton9 { get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000037 RID: 55
		IControllerTemplateButton consoleButton10 { get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000038 RID: 56
		IControllerTemplateButton shifter1 { get; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000039 RID: 57
		IControllerTemplateButton shifter2 { get; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600003A RID: 58
		IControllerTemplateButton shifter3 { get; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600003B RID: 59
		IControllerTemplateButton shifter4 { get; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600003C RID: 60
		IControllerTemplateButton shifter5 { get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600003D RID: 61
		IControllerTemplateButton shifter6 { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600003E RID: 62
		IControllerTemplateButton shifter7 { get; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600003F RID: 63
		IControllerTemplateButton shifter8 { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000040 RID: 64
		IControllerTemplateButton shifter9 { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000041 RID: 65
		IControllerTemplateButton shifter10 { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000042 RID: 66
		IControllerTemplateButton reverseGear { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000043 RID: 67
		IControllerTemplateButton select { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000044 RID: 68
		IControllerTemplateButton start { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000045 RID: 69
		IControllerTemplateButton systemButton { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000046 RID: 70
		IControllerTemplateButton horn { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000047 RID: 71
		IControllerTemplateDPad dPad { get; }
	}
}
