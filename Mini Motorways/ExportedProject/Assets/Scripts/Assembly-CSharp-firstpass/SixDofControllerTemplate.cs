using System;

namespace Rewired
{
	// Token: 0x0200000D RID: 13
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
	{
		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00002961 File Offset: 0x00000B61
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis1
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(8);
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000296A File Offset: 0x00000B6A
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(9);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00002974 File Offset: 0x00000B74
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis3
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(10);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000297E File Offset: 0x00000B7E
		IControllerTemplateAxis ISixDofControllerTemplate.extraAxis4
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(11);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002988 File Offset: 0x00000B88
		IControllerTemplateButton ISixDofControllerTemplate.button1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00002992 File Offset: 0x00000B92
		IControllerTemplateButton ISixDofControllerTemplate.button2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(13);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000299C File Offset: 0x00000B9C
		IControllerTemplateButton ISixDofControllerTemplate.button3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000029A6 File Offset: 0x00000BA6
		IControllerTemplateButton ISixDofControllerTemplate.button4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000029B0 File Offset: 0x00000BB0
		IControllerTemplateButton ISixDofControllerTemplate.button5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(16);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000029BA File Offset: 0x00000BBA
		IControllerTemplateButton ISixDofControllerTemplate.button6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(17);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000029C4 File Offset: 0x00000BC4
		IControllerTemplateButton ISixDofControllerTemplate.button7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(18);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000029CE File Offset: 0x00000BCE
		IControllerTemplateButton ISixDofControllerTemplate.button8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(19);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000029D8 File Offset: 0x00000BD8
		IControllerTemplateButton ISixDofControllerTemplate.button9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(20);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000029E2 File Offset: 0x00000BE2
		IControllerTemplateButton ISixDofControllerTemplate.button10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(21);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000029EC File Offset: 0x00000BEC
		IControllerTemplateButton ISixDofControllerTemplate.button11
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(22);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000029F6 File Offset: 0x00000BF6
		IControllerTemplateButton ISixDofControllerTemplate.button12
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(23);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00002A00 File Offset: 0x00000C00
		IControllerTemplateButton ISixDofControllerTemplate.button13
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(24);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002A0A File Offset: 0x00000C0A
		IControllerTemplateButton ISixDofControllerTemplate.button14
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(25);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00002A14 File Offset: 0x00000C14
		IControllerTemplateButton ISixDofControllerTemplate.button15
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(26);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002A1E File Offset: 0x00000C1E
		IControllerTemplateButton ISixDofControllerTemplate.button16
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(27);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00002A28 File Offset: 0x00000C28
		IControllerTemplateButton ISixDofControllerTemplate.button17
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(28);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00002A32 File Offset: 0x00000C32
		IControllerTemplateButton ISixDofControllerTemplate.button18
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(29);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00002A3C File Offset: 0x00000C3C
		IControllerTemplateButton ISixDofControllerTemplate.button19
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(30);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00002A46 File Offset: 0x00000C46
		IControllerTemplateButton ISixDofControllerTemplate.button20
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(31);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00002A50 File Offset: 0x00000C50
		IControllerTemplateButton ISixDofControllerTemplate.button21
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(55);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002A5A File Offset: 0x00000C5A
		IControllerTemplateButton ISixDofControllerTemplate.button22
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(56);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00002A64 File Offset: 0x00000C64
		IControllerTemplateButton ISixDofControllerTemplate.button23
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(57);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002A6E File Offset: 0x00000C6E
		IControllerTemplateButton ISixDofControllerTemplate.button24
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(58);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00002A78 File Offset: 0x00000C78
		IControllerTemplateButton ISixDofControllerTemplate.button25
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(59);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00002A82 File Offset: 0x00000C82
		IControllerTemplateButton ISixDofControllerTemplate.button26
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(60);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002A8C File Offset: 0x00000C8C
		IControllerTemplateButton ISixDofControllerTemplate.button27
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(61);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002A96 File Offset: 0x00000C96
		IControllerTemplateButton ISixDofControllerTemplate.button28
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(62);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002AA0 File Offset: 0x00000CA0
		IControllerTemplateButton ISixDofControllerTemplate.button29
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(63);
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00002AAA File Offset: 0x00000CAA
		IControllerTemplateButton ISixDofControllerTemplate.button30
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(64);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002AB4 File Offset: 0x00000CB4
		IControllerTemplateButton ISixDofControllerTemplate.button31
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(65);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00002ABE File Offset: 0x00000CBE
		IControllerTemplateButton ISixDofControllerTemplate.button32
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(66);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00002AC8 File Offset: 0x00000CC8
		IControllerTemplateHat ISixDofControllerTemplate.hat1
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(48);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002AD2 File Offset: 0x00000CD2
		IControllerTemplateHat ISixDofControllerTemplate.hat2
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(49);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002ADC File Offset: 0x00000CDC
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle1
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(52);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00002AE6 File Offset: 0x00000CE6
		IControllerTemplateThrottle ISixDofControllerTemplate.throttle2
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(53);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00002AF0 File Offset: 0x00000CF0
		IControllerTemplateStick6D ISixDofControllerTemplate.stick
		{
			get
			{
				return base.GetElement<IControllerTemplateStick6D>(54);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002AFA File Offset: 0x00000CFA
		public SixDofControllerTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x04000153 RID: 339
		public static readonly Guid typeGuid = new Guid("2599beb3-522b-43dd-a4ef-93fd60e5eafa");

		// Token: 0x04000154 RID: 340
		public const int elementId_positionX = 1;

		// Token: 0x04000155 RID: 341
		public const int elementId_positionY = 2;

		// Token: 0x04000156 RID: 342
		public const int elementId_positionZ = 0;

		// Token: 0x04000157 RID: 343
		public const int elementId_rotationX = 3;

		// Token: 0x04000158 RID: 344
		public const int elementId_rotationY = 5;

		// Token: 0x04000159 RID: 345
		public const int elementId_rotationZ = 4;

		// Token: 0x0400015A RID: 346
		public const int elementId_throttle1Axis = 6;

		// Token: 0x0400015B RID: 347
		public const int elementId_throttle1MinDetent = 50;

		// Token: 0x0400015C RID: 348
		public const int elementId_throttle2Axis = 7;

		// Token: 0x0400015D RID: 349
		public const int elementId_throttle2MinDetent = 51;

		// Token: 0x0400015E RID: 350
		public const int elementId_extraAxis1 = 8;

		// Token: 0x0400015F RID: 351
		public const int elementId_extraAxis2 = 9;

		// Token: 0x04000160 RID: 352
		public const int elementId_extraAxis3 = 10;

		// Token: 0x04000161 RID: 353
		public const int elementId_extraAxis4 = 11;

		// Token: 0x04000162 RID: 354
		public const int elementId_button1 = 12;

		// Token: 0x04000163 RID: 355
		public const int elementId_button2 = 13;

		// Token: 0x04000164 RID: 356
		public const int elementId_button3 = 14;

		// Token: 0x04000165 RID: 357
		public const int elementId_button4 = 15;

		// Token: 0x04000166 RID: 358
		public const int elementId_button5 = 16;

		// Token: 0x04000167 RID: 359
		public const int elementId_button6 = 17;

		// Token: 0x04000168 RID: 360
		public const int elementId_button7 = 18;

		// Token: 0x04000169 RID: 361
		public const int elementId_button8 = 19;

		// Token: 0x0400016A RID: 362
		public const int elementId_button9 = 20;

		// Token: 0x0400016B RID: 363
		public const int elementId_button10 = 21;

		// Token: 0x0400016C RID: 364
		public const int elementId_button11 = 22;

		// Token: 0x0400016D RID: 365
		public const int elementId_button12 = 23;

		// Token: 0x0400016E RID: 366
		public const int elementId_button13 = 24;

		// Token: 0x0400016F RID: 367
		public const int elementId_button14 = 25;

		// Token: 0x04000170 RID: 368
		public const int elementId_button15 = 26;

		// Token: 0x04000171 RID: 369
		public const int elementId_button16 = 27;

		// Token: 0x04000172 RID: 370
		public const int elementId_button17 = 28;

		// Token: 0x04000173 RID: 371
		public const int elementId_button18 = 29;

		// Token: 0x04000174 RID: 372
		public const int elementId_button19 = 30;

		// Token: 0x04000175 RID: 373
		public const int elementId_button20 = 31;

		// Token: 0x04000176 RID: 374
		public const int elementId_button21 = 55;

		// Token: 0x04000177 RID: 375
		public const int elementId_button22 = 56;

		// Token: 0x04000178 RID: 376
		public const int elementId_button23 = 57;

		// Token: 0x04000179 RID: 377
		public const int elementId_button24 = 58;

		// Token: 0x0400017A RID: 378
		public const int elementId_button25 = 59;

		// Token: 0x0400017B RID: 379
		public const int elementId_button26 = 60;

		// Token: 0x0400017C RID: 380
		public const int elementId_button27 = 61;

		// Token: 0x0400017D RID: 381
		public const int elementId_button28 = 62;

		// Token: 0x0400017E RID: 382
		public const int elementId_button29 = 63;

		// Token: 0x0400017F RID: 383
		public const int elementId_button30 = 64;

		// Token: 0x04000180 RID: 384
		public const int elementId_button31 = 65;

		// Token: 0x04000181 RID: 385
		public const int elementId_button32 = 66;

		// Token: 0x04000182 RID: 386
		public const int elementId_hat1Up = 32;

		// Token: 0x04000183 RID: 387
		public const int elementId_hat1UpRight = 33;

		// Token: 0x04000184 RID: 388
		public const int elementId_hat1Right = 34;

		// Token: 0x04000185 RID: 389
		public const int elementId_hat1DownRight = 35;

		// Token: 0x04000186 RID: 390
		public const int elementId_hat1Down = 36;

		// Token: 0x04000187 RID: 391
		public const int elementId_hat1DownLeft = 37;

		// Token: 0x04000188 RID: 392
		public const int elementId_hat1Left = 38;

		// Token: 0x04000189 RID: 393
		public const int elementId_hat1UpLeft = 39;

		// Token: 0x0400018A RID: 394
		public const int elementId_hat2Up = 40;

		// Token: 0x0400018B RID: 395
		public const int elementId_hat2UpRight = 41;

		// Token: 0x0400018C RID: 396
		public const int elementId_hat2Right = 42;

		// Token: 0x0400018D RID: 397
		public const int elementId_hat2DownRight = 43;

		// Token: 0x0400018E RID: 398
		public const int elementId_hat2Down = 44;

		// Token: 0x0400018F RID: 399
		public const int elementId_hat2DownLeft = 45;

		// Token: 0x04000190 RID: 400
		public const int elementId_hat2Left = 46;

		// Token: 0x04000191 RID: 401
		public const int elementId_hat2UpLeft = 47;

		// Token: 0x04000192 RID: 402
		public const int elementId_hat1 = 48;

		// Token: 0x04000193 RID: 403
		public const int elementId_hat2 = 49;

		// Token: 0x04000194 RID: 404
		public const int elementId_throttle1 = 52;

		// Token: 0x04000195 RID: 405
		public const int elementId_throttle2 = 53;

		// Token: 0x04000196 RID: 406
		public const int elementId_stick = 54;
	}
}
