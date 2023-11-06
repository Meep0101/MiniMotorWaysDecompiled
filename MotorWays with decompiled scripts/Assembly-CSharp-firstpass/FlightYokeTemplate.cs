using System;

namespace Rewired
{
	// Token: 0x0200000B RID: 11
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000272A File Offset: 0x0000092A
		IControllerTemplateButton IFlightYokeTemplate.leftPaddle
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(59);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002734 File Offset: 0x00000934
		IControllerTemplateButton IFlightYokeTemplate.rightPaddle
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(60);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000273E File Offset: 0x0000093E
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00002747 File Offset: 0x00000947
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002750 File Offset: 0x00000950
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000275A File Offset: 0x0000095A
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002764 File Offset: 0x00000964
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(11);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000276E File Offset: 0x0000096E
		IControllerTemplateButton IFlightYokeTemplate.leftGripButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00002778 File Offset: 0x00000978
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(13);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002782 File Offset: 0x00000982
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000278C File Offset: 0x0000098C
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00002796 File Offset: 0x00000996
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000027A0 File Offset: 0x000009A0
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(17);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000027AA File Offset: 0x000009AA
		IControllerTemplateButton IFlightYokeTemplate.rightGripButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(18);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000027B4 File Offset: 0x000009B4
		IControllerTemplateButton IFlightYokeTemplate.centerButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(19);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000027BE File Offset: 0x000009BE
		IControllerTemplateButton IFlightYokeTemplate.centerButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(20);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000027C8 File Offset: 0x000009C8
		IControllerTemplateButton IFlightYokeTemplate.centerButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(21);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000027D2 File Offset: 0x000009D2
		IControllerTemplateButton IFlightYokeTemplate.centerButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(22);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000027DC File Offset: 0x000009DC
		IControllerTemplateButton IFlightYokeTemplate.centerButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(23);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000027E6 File Offset: 0x000009E6
		IControllerTemplateButton IFlightYokeTemplate.centerButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(24);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000027F0 File Offset: 0x000009F0
		IControllerTemplateButton IFlightYokeTemplate.centerButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(25);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000027FA File Offset: 0x000009FA
		IControllerTemplateButton IFlightYokeTemplate.centerButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(26);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002804 File Offset: 0x00000A04
		IControllerTemplateButton IFlightYokeTemplate.wheel1Up
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(53);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000280E File Offset: 0x00000A0E
		IControllerTemplateButton IFlightYokeTemplate.wheel1Down
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(54);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002818 File Offset: 0x00000A18
		IControllerTemplateButton IFlightYokeTemplate.wheel1Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(55);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002822 File Offset: 0x00000A22
		IControllerTemplateButton IFlightYokeTemplate.wheel2Up
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(56);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000282C File Offset: 0x00000A2C
		IControllerTemplateButton IFlightYokeTemplate.wheel2Down
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(57);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002836 File Offset: 0x00000A36
		IControllerTemplateButton IFlightYokeTemplate.wheel2Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(58);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002840 File Offset: 0x00000A40
		IControllerTemplateButton IFlightYokeTemplate.consoleButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(43);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000284A File Offset: 0x00000A4A
		IControllerTemplateButton IFlightYokeTemplate.consoleButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(44);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00002854 File Offset: 0x00000A54
		IControllerTemplateButton IFlightYokeTemplate.consoleButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(45);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000285E File Offset: 0x00000A5E
		IControllerTemplateButton IFlightYokeTemplate.consoleButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(46);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002868 File Offset: 0x00000A68
		IControllerTemplateButton IFlightYokeTemplate.consoleButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(47);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002872 File Offset: 0x00000A72
		IControllerTemplateButton IFlightYokeTemplate.consoleButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(48);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000287C File Offset: 0x00000A7C
		IControllerTemplateButton IFlightYokeTemplate.consoleButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(49);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00002886 File Offset: 0x00000A86
		IControllerTemplateButton IFlightYokeTemplate.consoleButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(50);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002890 File Offset: 0x00000A90
		IControllerTemplateButton IFlightYokeTemplate.consoleButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(51);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000289A File Offset: 0x00000A9A
		IControllerTemplateButton IFlightYokeTemplate.consoleButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(52);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000028A4 File Offset: 0x00000AA4
		IControllerTemplateButton IFlightYokeTemplate.mode1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(61);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000028AE File Offset: 0x00000AAE
		IControllerTemplateButton IFlightYokeTemplate.mode2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(62);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000028B8 File Offset: 0x00000AB8
		IControllerTemplateButton IFlightYokeTemplate.mode3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(63);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000028C2 File Offset: 0x00000AC2
		IControllerTemplateYoke IFlightYokeTemplate.yoke
		{
			get
			{
				return base.GetElement<IControllerTemplateYoke>(69);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000028CC File Offset: 0x00000ACC
		IControllerTemplateThrottle IFlightYokeTemplate.lever1
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(70);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000028D6 File Offset: 0x00000AD6
		IControllerTemplateThrottle IFlightYokeTemplate.lever2
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(71);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000028E0 File Offset: 0x00000AE0
		IControllerTemplateThrottle IFlightYokeTemplate.lever3
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(72);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000028EA File Offset: 0x00000AEA
		IControllerTemplateThrottle IFlightYokeTemplate.lever4
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(73);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000028F4 File Offset: 0x00000AF4
		IControllerTemplateThrottle IFlightYokeTemplate.lever5
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(74);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000028FE File Offset: 0x00000AFE
		IControllerTemplateHat IFlightYokeTemplate.leftGripHat
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(75);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002908 File Offset: 0x00000B08
		IControllerTemplateHat IFlightYokeTemplate.rightGripHat
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(76);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002912 File Offset: 0x00000B12
		public FlightYokeTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x04000101 RID: 257
		public static readonly Guid typeGuid = new Guid("f311fa16-0ccc-41c0-ac4b-50f7100bb8ff");

		// Token: 0x04000102 RID: 258
		public const int elementId_rotateYoke = 0;

		// Token: 0x04000103 RID: 259
		public const int elementId_yokeZ = 1;

		// Token: 0x04000104 RID: 260
		public const int elementId_leftPaddle = 59;

		// Token: 0x04000105 RID: 261
		public const int elementId_rightPaddle = 60;

		// Token: 0x04000106 RID: 262
		public const int elementId_lever1Axis = 2;

		// Token: 0x04000107 RID: 263
		public const int elementId_lever1MinDetent = 64;

		// Token: 0x04000108 RID: 264
		public const int elementId_lever2Axis = 3;

		// Token: 0x04000109 RID: 265
		public const int elementId_lever2MinDetent = 65;

		// Token: 0x0400010A RID: 266
		public const int elementId_lever3Axis = 4;

		// Token: 0x0400010B RID: 267
		public const int elementId_lever3MinDetent = 66;

		// Token: 0x0400010C RID: 268
		public const int elementId_lever4Axis = 5;

		// Token: 0x0400010D RID: 269
		public const int elementId_lever4MinDetent = 67;

		// Token: 0x0400010E RID: 270
		public const int elementId_lever5Axis = 6;

		// Token: 0x0400010F RID: 271
		public const int elementId_lever5MinDetent = 68;

		// Token: 0x04000110 RID: 272
		public const int elementId_leftGripButton1 = 7;

		// Token: 0x04000111 RID: 273
		public const int elementId_leftGripButton2 = 8;

		// Token: 0x04000112 RID: 274
		public const int elementId_leftGripButton3 = 9;

		// Token: 0x04000113 RID: 275
		public const int elementId_leftGripButton4 = 10;

		// Token: 0x04000114 RID: 276
		public const int elementId_leftGripButton5 = 11;

		// Token: 0x04000115 RID: 277
		public const int elementId_leftGripButton6 = 12;

		// Token: 0x04000116 RID: 278
		public const int elementId_rightGripButton1 = 13;

		// Token: 0x04000117 RID: 279
		public const int elementId_rightGripButton2 = 14;

		// Token: 0x04000118 RID: 280
		public const int elementId_rightGripButton3 = 15;

		// Token: 0x04000119 RID: 281
		public const int elementId_rightGripButton4 = 16;

		// Token: 0x0400011A RID: 282
		public const int elementId_rightGripButton5 = 17;

		// Token: 0x0400011B RID: 283
		public const int elementId_rightGripButton6 = 18;

		// Token: 0x0400011C RID: 284
		public const int elementId_centerButton1 = 19;

		// Token: 0x0400011D RID: 285
		public const int elementId_centerButton2 = 20;

		// Token: 0x0400011E RID: 286
		public const int elementId_centerButton3 = 21;

		// Token: 0x0400011F RID: 287
		public const int elementId_centerButton4 = 22;

		// Token: 0x04000120 RID: 288
		public const int elementId_centerButton5 = 23;

		// Token: 0x04000121 RID: 289
		public const int elementId_centerButton6 = 24;

		// Token: 0x04000122 RID: 290
		public const int elementId_centerButton7 = 25;

		// Token: 0x04000123 RID: 291
		public const int elementId_centerButton8 = 26;

		// Token: 0x04000124 RID: 292
		public const int elementId_wheel1Up = 53;

		// Token: 0x04000125 RID: 293
		public const int elementId_wheel1Down = 54;

		// Token: 0x04000126 RID: 294
		public const int elementId_wheel1Press = 55;

		// Token: 0x04000127 RID: 295
		public const int elementId_wheel2Up = 56;

		// Token: 0x04000128 RID: 296
		public const int elementId_wheel2Down = 57;

		// Token: 0x04000129 RID: 297
		public const int elementId_wheel2Press = 58;

		// Token: 0x0400012A RID: 298
		public const int elementId_leftGripHatUp = 27;

		// Token: 0x0400012B RID: 299
		public const int elementId_leftGripHatUpRight = 28;

		// Token: 0x0400012C RID: 300
		public const int elementId_leftGripHatRight = 29;

		// Token: 0x0400012D RID: 301
		public const int elementId_leftGripHatDownRight = 30;

		// Token: 0x0400012E RID: 302
		public const int elementId_leftGripHatDown = 31;

		// Token: 0x0400012F RID: 303
		public const int elementId_leftGripHatDownLeft = 32;

		// Token: 0x04000130 RID: 304
		public const int elementId_leftGripHatLeft = 33;

		// Token: 0x04000131 RID: 305
		public const int elementId_leftGripHatUpLeft = 34;

		// Token: 0x04000132 RID: 306
		public const int elementId_rightGripHatUp = 35;

		// Token: 0x04000133 RID: 307
		public const int elementId_rightGripHatUpRight = 36;

		// Token: 0x04000134 RID: 308
		public const int elementId_rightGripHatRight = 37;

		// Token: 0x04000135 RID: 309
		public const int elementId_rightGripHatDownRight = 38;

		// Token: 0x04000136 RID: 310
		public const int elementId_rightGripHatDown = 39;

		// Token: 0x04000137 RID: 311
		public const int elementId_rightGripHatDownLeft = 40;

		// Token: 0x04000138 RID: 312
		public const int elementId_rightGripHatLeft = 41;

		// Token: 0x04000139 RID: 313
		public const int elementId_rightGripHatUpLeft = 42;

		// Token: 0x0400013A RID: 314
		public const int elementId_consoleButton1 = 43;

		// Token: 0x0400013B RID: 315
		public const int elementId_consoleButton2 = 44;

		// Token: 0x0400013C RID: 316
		public const int elementId_consoleButton3 = 45;

		// Token: 0x0400013D RID: 317
		public const int elementId_consoleButton4 = 46;

		// Token: 0x0400013E RID: 318
		public const int elementId_consoleButton5 = 47;

		// Token: 0x0400013F RID: 319
		public const int elementId_consoleButton6 = 48;

		// Token: 0x04000140 RID: 320
		public const int elementId_consoleButton7 = 49;

		// Token: 0x04000141 RID: 321
		public const int elementId_consoleButton8 = 50;

		// Token: 0x04000142 RID: 322
		public const int elementId_consoleButton9 = 51;

		// Token: 0x04000143 RID: 323
		public const int elementId_consoleButton10 = 52;

		// Token: 0x04000144 RID: 324
		public const int elementId_mode1 = 61;

		// Token: 0x04000145 RID: 325
		public const int elementId_mode2 = 62;

		// Token: 0x04000146 RID: 326
		public const int elementId_mode3 = 63;

		// Token: 0x04000147 RID: 327
		public const int elementId_yoke = 69;

		// Token: 0x04000148 RID: 328
		public const int elementId_lever1 = 70;

		// Token: 0x04000149 RID: 329
		public const int elementId_lever2 = 71;

		// Token: 0x0400014A RID: 330
		public const int elementId_lever3 = 72;

		// Token: 0x0400014B RID: 331
		public const int elementId_lever4 = 73;

		// Token: 0x0400014C RID: 332
		public const int elementId_lever5 = 74;

		// Token: 0x0400014D RID: 333
		public const int elementId_leftGripHat = 75;

		// Token: 0x0400014E RID: 334
		public const int elementId_rightGripHat = 76;
	}
}
