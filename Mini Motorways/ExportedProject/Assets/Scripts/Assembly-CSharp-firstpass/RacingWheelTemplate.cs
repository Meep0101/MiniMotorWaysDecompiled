using System;

namespace Rewired
{
	// Token: 0x02000009 RID: 9
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002182 File Offset: 0x00000382
		IControllerTemplateAxis IRacingWheelTemplate.wheel
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(0);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000218B File Offset: 0x0000038B
		IControllerTemplateAxis IRacingWheelTemplate.accelerator
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(1);
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00002194 File Offset: 0x00000394
		IControllerTemplateAxis IRacingWheelTemplate.brake
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(2);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000219D File Offset: 0x0000039D
		IControllerTemplateAxis IRacingWheelTemplate.clutch
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(3);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000021A6 File Offset: 0x000003A6
		IControllerTemplateButton IRacingWheelTemplate.shiftDown
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(4);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000021AF File Offset: 0x000003AF
		IControllerTemplateButton IRacingWheelTemplate.shiftUp
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(5);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000122 RID: 290 RVA: 0x000021B8 File Offset: 0x000003B8
		IControllerTemplateButton IRacingWheelTemplate.wheelButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(6);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000021C1 File Offset: 0x000003C1
		IControllerTemplateButton IRacingWheelTemplate.wheelButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000021CA File Offset: 0x000003CA
		IControllerTemplateButton IRacingWheelTemplate.wheelButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000021D3 File Offset: 0x000003D3
		IControllerTemplateButton IRacingWheelTemplate.wheelButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000021DD File Offset: 0x000003DD
		IControllerTemplateButton IRacingWheelTemplate.wheelButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000021E7 File Offset: 0x000003E7
		IControllerTemplateButton IRacingWheelTemplate.wheelButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(11);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000021F1 File Offset: 0x000003F1
		IControllerTemplateButton IRacingWheelTemplate.wheelButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000021FB File Offset: 0x000003FB
		IControllerTemplateButton IRacingWheelTemplate.wheelButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(13);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00002205 File Offset: 0x00000405
		IControllerTemplateButton IRacingWheelTemplate.wheelButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000220F File Offset: 0x0000040F
		IControllerTemplateButton IRacingWheelTemplate.wheelButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00002219 File Offset: 0x00000419
		IControllerTemplateButton IRacingWheelTemplate.consoleButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00002223 File Offset: 0x00000423
		IControllerTemplateButton IRacingWheelTemplate.consoleButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(17);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000222D File Offset: 0x0000042D
		IControllerTemplateButton IRacingWheelTemplate.consoleButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(18);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00002237 File Offset: 0x00000437
		IControllerTemplateButton IRacingWheelTemplate.consoleButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(19);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002241 File Offset: 0x00000441
		IControllerTemplateButton IRacingWheelTemplate.consoleButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(20);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000224B File Offset: 0x0000044B
		IControllerTemplateButton IRacingWheelTemplate.consoleButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(21);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002255 File Offset: 0x00000455
		IControllerTemplateButton IRacingWheelTemplate.consoleButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(22);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000225F File Offset: 0x0000045F
		IControllerTemplateButton IRacingWheelTemplate.consoleButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(23);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002269 File Offset: 0x00000469
		IControllerTemplateButton IRacingWheelTemplate.consoleButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(24);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002273 File Offset: 0x00000473
		IControllerTemplateButton IRacingWheelTemplate.consoleButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(25);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000227D File Offset: 0x0000047D
		IControllerTemplateButton IRacingWheelTemplate.shifter1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(26);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00002287 File Offset: 0x00000487
		IControllerTemplateButton IRacingWheelTemplate.shifter2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(27);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002291 File Offset: 0x00000491
		IControllerTemplateButton IRacingWheelTemplate.shifter3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(28);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000229B File Offset: 0x0000049B
		IControllerTemplateButton IRacingWheelTemplate.shifter4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(29);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000022A5 File Offset: 0x000004A5
		IControllerTemplateButton IRacingWheelTemplate.shifter5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(30);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000022AF File Offset: 0x000004AF
		IControllerTemplateButton IRacingWheelTemplate.shifter6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(31);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000022B9 File Offset: 0x000004B9
		IControllerTemplateButton IRacingWheelTemplate.shifter7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(32);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000022C3 File Offset: 0x000004C3
		IControllerTemplateButton IRacingWheelTemplate.shifter8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(33);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600013E RID: 318 RVA: 0x000022CD File Offset: 0x000004CD
		IControllerTemplateButton IRacingWheelTemplate.shifter9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(34);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000022D7 File Offset: 0x000004D7
		IControllerTemplateButton IRacingWheelTemplate.shifter10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(35);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000022E1 File Offset: 0x000004E1
		IControllerTemplateButton IRacingWheelTemplate.reverseGear
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(44);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000022EB File Offset: 0x000004EB
		IControllerTemplateButton IRacingWheelTemplate.select
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(36);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000022F5 File Offset: 0x000004F5
		IControllerTemplateButton IRacingWheelTemplate.start
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(37);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000022FF File Offset: 0x000004FF
		IControllerTemplateButton IRacingWheelTemplate.systemButton
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(38);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00002309 File Offset: 0x00000509
		IControllerTemplateButton IRacingWheelTemplate.horn
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(43);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00002313 File Offset: 0x00000513
		IControllerTemplateDPad IRacingWheelTemplate.dPad
		{
			get
			{
				return base.GetElement<IControllerTemplateDPad>(45);
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000231D File Offset: 0x0000051D
		public RacingWheelTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x04000029 RID: 41
		public static readonly Guid typeGuid = new Guid("104e31d8-9115-4dd5-a398-2e54d35e6c83");

		// Token: 0x0400002A RID: 42
		public const int elementId_wheel = 0;

		// Token: 0x0400002B RID: 43
		public const int elementId_accelerator = 1;

		// Token: 0x0400002C RID: 44
		public const int elementId_brake = 2;

		// Token: 0x0400002D RID: 45
		public const int elementId_clutch = 3;

		// Token: 0x0400002E RID: 46
		public const int elementId_shiftDown = 4;

		// Token: 0x0400002F RID: 47
		public const int elementId_shiftUp = 5;

		// Token: 0x04000030 RID: 48
		public const int elementId_wheelButton1 = 6;

		// Token: 0x04000031 RID: 49
		public const int elementId_wheelButton2 = 7;

		// Token: 0x04000032 RID: 50
		public const int elementId_wheelButton3 = 8;

		// Token: 0x04000033 RID: 51
		public const int elementId_wheelButton4 = 9;

		// Token: 0x04000034 RID: 52
		public const int elementId_wheelButton5 = 10;

		// Token: 0x04000035 RID: 53
		public const int elementId_wheelButton6 = 11;

		// Token: 0x04000036 RID: 54
		public const int elementId_wheelButton7 = 12;

		// Token: 0x04000037 RID: 55
		public const int elementId_wheelButton8 = 13;

		// Token: 0x04000038 RID: 56
		public const int elementId_wheelButton9 = 14;

		// Token: 0x04000039 RID: 57
		public const int elementId_wheelButton10 = 15;

		// Token: 0x0400003A RID: 58
		public const int elementId_consoleButton1 = 16;

		// Token: 0x0400003B RID: 59
		public const int elementId_consoleButton2 = 17;

		// Token: 0x0400003C RID: 60
		public const int elementId_consoleButton3 = 18;

		// Token: 0x0400003D RID: 61
		public const int elementId_consoleButton4 = 19;

		// Token: 0x0400003E RID: 62
		public const int elementId_consoleButton5 = 20;

		// Token: 0x0400003F RID: 63
		public const int elementId_consoleButton6 = 21;

		// Token: 0x04000040 RID: 64
		public const int elementId_consoleButton7 = 22;

		// Token: 0x04000041 RID: 65
		public const int elementId_consoleButton8 = 23;

		// Token: 0x04000042 RID: 66
		public const int elementId_consoleButton9 = 24;

		// Token: 0x04000043 RID: 67
		public const int elementId_consoleButton10 = 25;

		// Token: 0x04000044 RID: 68
		public const int elementId_shifter1 = 26;

		// Token: 0x04000045 RID: 69
		public const int elementId_shifter2 = 27;

		// Token: 0x04000046 RID: 70
		public const int elementId_shifter3 = 28;

		// Token: 0x04000047 RID: 71
		public const int elementId_shifter4 = 29;

		// Token: 0x04000048 RID: 72
		public const int elementId_shifter5 = 30;

		// Token: 0x04000049 RID: 73
		public const int elementId_shifter6 = 31;

		// Token: 0x0400004A RID: 74
		public const int elementId_shifter7 = 32;

		// Token: 0x0400004B RID: 75
		public const int elementId_shifter8 = 33;

		// Token: 0x0400004C RID: 76
		public const int elementId_shifter9 = 34;

		// Token: 0x0400004D RID: 77
		public const int elementId_shifter10 = 35;

		// Token: 0x0400004E RID: 78
		public const int elementId_reverseGear = 44;

		// Token: 0x0400004F RID: 79
		public const int elementId_select = 36;

		// Token: 0x04000050 RID: 80
		public const int elementId_start = 37;

		// Token: 0x04000051 RID: 81
		public const int elementId_systemButton = 38;

		// Token: 0x04000052 RID: 82
		public const int elementId_horn = 43;

		// Token: 0x04000053 RID: 83
		public const int elementId_dPadUp = 39;

		// Token: 0x04000054 RID: 84
		public const int elementId_dPadRight = 40;

		// Token: 0x04000055 RID: 85
		public const int elementId_dPadDown = 41;

		// Token: 0x04000056 RID: 86
		public const int elementId_dPadLeft = 42;

		// Token: 0x04000057 RID: 87
		public const int elementId_dPad = 45;
	}
}
