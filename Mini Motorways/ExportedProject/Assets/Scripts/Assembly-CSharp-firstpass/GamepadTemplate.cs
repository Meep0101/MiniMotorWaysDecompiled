using System;

namespace Rewired
{
	// Token: 0x02000008 RID: 8
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		IControllerTemplateButton IGamepadTemplate.actionBottomRow1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(4);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002059 File Offset: 0x00000259
		IControllerTemplateButton IGamepadTemplate.a
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(4);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002062 File Offset: 0x00000262
		IControllerTemplateButton IGamepadTemplate.actionBottomRow2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(5);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000206B File Offset: 0x0000026B
		IControllerTemplateButton IGamepadTemplate.b
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(5);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002074 File Offset: 0x00000274
		IControllerTemplateButton IGamepadTemplate.actionBottomRow3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(6);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000207D File Offset: 0x0000027D
		IControllerTemplateButton IGamepadTemplate.c
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(6);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002086 File Offset: 0x00000286
		IControllerTemplateButton IGamepadTemplate.actionTopRow1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000208F File Offset: 0x0000028F
		IControllerTemplateButton IGamepadTemplate.x
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002098 File Offset: 0x00000298
		IControllerTemplateButton IGamepadTemplate.actionTopRow2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000020A1 File Offset: 0x000002A1
		IControllerTemplateButton IGamepadTemplate.y
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000020AA File Offset: 0x000002AA
		IControllerTemplateButton IGamepadTemplate.actionTopRow3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000020B4 File Offset: 0x000002B4
		IControllerTemplateButton IGamepadTemplate.z
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000020BE File Offset: 0x000002BE
		IControllerTemplateButton IGamepadTemplate.leftShoulder1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000020C8 File Offset: 0x000002C8
		IControllerTemplateButton IGamepadTemplate.leftBumper
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000020D2 File Offset: 0x000002D2
		IControllerTemplateAxis IGamepadTemplate.leftShoulder2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(11);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000020DC File Offset: 0x000002DC
		IControllerTemplateAxis IGamepadTemplate.leftTrigger
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(11);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000020E6 File Offset: 0x000002E6
		IControllerTemplateButton IGamepadTemplate.rightShoulder1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000020F0 File Offset: 0x000002F0
		IControllerTemplateButton IGamepadTemplate.rightBumper
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000020FA File Offset: 0x000002FA
		IControllerTemplateAxis IGamepadTemplate.rightShoulder2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(13);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00002104 File Offset: 0x00000304
		IControllerTemplateAxis IGamepadTemplate.rightTrigger
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(13);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000210E File Offset: 0x0000030E
		IControllerTemplateButton IGamepadTemplate.center1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002118 File Offset: 0x00000318
		IControllerTemplateButton IGamepadTemplate.back
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00002122 File Offset: 0x00000322
		IControllerTemplateButton IGamepadTemplate.center2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000212C File Offset: 0x0000032C
		IControllerTemplateButton IGamepadTemplate.start
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00002136 File Offset: 0x00000336
		IControllerTemplateButton IGamepadTemplate.center3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002140 File Offset: 0x00000340
		IControllerTemplateButton IGamepadTemplate.guide
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000214A File Offset: 0x0000034A
		IControllerTemplateThumbStick IGamepadTemplate.leftStick
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(23);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002154 File Offset: 0x00000354
		IControllerTemplateThumbStick IGamepadTemplate.rightStick
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(24);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000215E File Offset: 0x0000035E
		IControllerTemplateDPad IGamepadTemplate.dPad
		{
			get
			{
				return base.GetElement<IControllerTemplateDPad>(25);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002168 File Offset: 0x00000368
		public GamepadTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x04000001 RID: 1
		public static readonly Guid typeGuid = new Guid("83b427e4-086f-47f3-bb06-be266abd1ca5");

		// Token: 0x04000002 RID: 2
		public const int elementId_leftStickX = 0;

		// Token: 0x04000003 RID: 3
		public const int elementId_leftStickY = 1;

		// Token: 0x04000004 RID: 4
		public const int elementId_rightStickX = 2;

		// Token: 0x04000005 RID: 5
		public const int elementId_rightStickY = 3;

		// Token: 0x04000006 RID: 6
		public const int elementId_actionBottomRow1 = 4;

		// Token: 0x04000007 RID: 7
		public const int elementId_a = 4;

		// Token: 0x04000008 RID: 8
		public const int elementId_actionBottomRow2 = 5;

		// Token: 0x04000009 RID: 9
		public const int elementId_b = 5;

		// Token: 0x0400000A RID: 10
		public const int elementId_actionBottomRow3 = 6;

		// Token: 0x0400000B RID: 11
		public const int elementId_c = 6;

		// Token: 0x0400000C RID: 12
		public const int elementId_actionTopRow1 = 7;

		// Token: 0x0400000D RID: 13
		public const int elementId_x = 7;

		// Token: 0x0400000E RID: 14
		public const int elementId_actionTopRow2 = 8;

		// Token: 0x0400000F RID: 15
		public const int elementId_y = 8;

		// Token: 0x04000010 RID: 16
		public const int elementId_actionTopRow3 = 9;

		// Token: 0x04000011 RID: 17
		public const int elementId_z = 9;

		// Token: 0x04000012 RID: 18
		public const int elementId_leftShoulder1 = 10;

		// Token: 0x04000013 RID: 19
		public const int elementId_leftBumper = 10;

		// Token: 0x04000014 RID: 20
		public const int elementId_leftShoulder2 = 11;

		// Token: 0x04000015 RID: 21
		public const int elementId_leftTrigger = 11;

		// Token: 0x04000016 RID: 22
		public const int elementId_rightShoulder1 = 12;

		// Token: 0x04000017 RID: 23
		public const int elementId_rightBumper = 12;

		// Token: 0x04000018 RID: 24
		public const int elementId_rightShoulder2 = 13;

		// Token: 0x04000019 RID: 25
		public const int elementId_rightTrigger = 13;

		// Token: 0x0400001A RID: 26
		public const int elementId_center1 = 14;

		// Token: 0x0400001B RID: 27
		public const int elementId_back = 14;

		// Token: 0x0400001C RID: 28
		public const int elementId_center2 = 15;

		// Token: 0x0400001D RID: 29
		public const int elementId_start = 15;

		// Token: 0x0400001E RID: 30
		public const int elementId_center3 = 16;

		// Token: 0x0400001F RID: 31
		public const int elementId_guide = 16;

		// Token: 0x04000020 RID: 32
		public const int elementId_leftStickButton = 17;

		// Token: 0x04000021 RID: 33
		public const int elementId_rightStickButton = 18;

		// Token: 0x04000022 RID: 34
		public const int elementId_dPadUp = 19;

		// Token: 0x04000023 RID: 35
		public const int elementId_dPadRight = 20;

		// Token: 0x04000024 RID: 36
		public const int elementId_dPadDown = 21;

		// Token: 0x04000025 RID: 37
		public const int elementId_dPadLeft = 22;

		// Token: 0x04000026 RID: 38
		public const int elementId_leftStick = 23;

		// Token: 0x04000027 RID: 39
		public const int elementId_rightStick = 24;

		// Token: 0x04000028 RID: 40
		public const int elementId_dPad = 25;
	}
}
