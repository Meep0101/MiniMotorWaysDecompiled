using System;

namespace Rewired
{
	// Token: 0x0200000A RID: 10
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00002337 File Offset: 0x00000537
		IControllerTemplateButton IHOTASTemplate.stickTrigger
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(3);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002340 File Offset: 0x00000540
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(4);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002349 File Offset: 0x00000549
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(5);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002352 File Offset: 0x00000552
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(154);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0000235F File Offset: 0x0000055F
		IControllerTemplateButton IHOTASTemplate.stickButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(6);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002368 File Offset: 0x00000568
		IControllerTemplateButton IHOTASTemplate.stickButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(7);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002371 File Offset: 0x00000571
		IControllerTemplateButton IHOTASTemplate.stickButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(8);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000237A File Offset: 0x0000057A
		IControllerTemplateButton IHOTASTemplate.stickButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(9);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00002384 File Offset: 0x00000584
		IControllerTemplateButton IHOTASTemplate.stickButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(10);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000238E File Offset: 0x0000058E
		IControllerTemplateButton IHOTASTemplate.stickButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(11);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00002398 File Offset: 0x00000598
		IControllerTemplateButton IHOTASTemplate.stickButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(12);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000023A2 File Offset: 0x000005A2
		IControllerTemplateButton IHOTASTemplate.stickButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(13);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000154 RID: 340 RVA: 0x000023AC File Offset: 0x000005AC
		IControllerTemplateButton IHOTASTemplate.stickButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(14);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000155 RID: 341 RVA: 0x000023B6 File Offset: 0x000005B6
		IControllerTemplateButton IHOTASTemplate.stickButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(15);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000156 RID: 342 RVA: 0x000023C0 File Offset: 0x000005C0
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(18);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000023CA File Offset: 0x000005CA
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(19);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000158 RID: 344 RVA: 0x000023D4 File Offset: 0x000005D4
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(20);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000023DE File Offset: 0x000005DE
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(21);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000023E8 File Offset: 0x000005E8
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(22);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000023F2 File Offset: 0x000005F2
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(23);
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000023FC File Offset: 0x000005FC
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(24);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002406 File Offset: 0x00000606
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(25);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002410 File Offset: 0x00000610
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(26);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000241A File Offset: 0x0000061A
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(27);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002424 File Offset: 0x00000624
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(161);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002431 File Offset: 0x00000631
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(162);
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000243E File Offset: 0x0000063E
		IControllerTemplateButton IHOTASTemplate.mode1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(44);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002448 File Offset: 0x00000648
		IControllerTemplateButton IHOTASTemplate.mode2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(45);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002452 File Offset: 0x00000652
		IControllerTemplateButton IHOTASTemplate.mode3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(46);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000245C File Offset: 0x0000065C
		IControllerTemplateButton IHOTASTemplate.throttleButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(50);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002466 File Offset: 0x00000666
		IControllerTemplateButton IHOTASTemplate.throttleButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(51);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002470 File Offset: 0x00000670
		IControllerTemplateButton IHOTASTemplate.throttleButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(52);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000247A File Offset: 0x0000067A
		IControllerTemplateButton IHOTASTemplate.throttleButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(53);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002484 File Offset: 0x00000684
		IControllerTemplateButton IHOTASTemplate.throttleButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(54);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000248E File Offset: 0x0000068E
		IControllerTemplateButton IHOTASTemplate.throttleButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(55);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002498 File Offset: 0x00000698
		IControllerTemplateButton IHOTASTemplate.throttleButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(56);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000024A2 File Offset: 0x000006A2
		IControllerTemplateButton IHOTASTemplate.throttleButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(57);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000024AC File Offset: 0x000006AC
		IControllerTemplateButton IHOTASTemplate.throttleButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(58);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000024B6 File Offset: 0x000006B6
		IControllerTemplateButton IHOTASTemplate.throttleButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(59);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600016F RID: 367 RVA: 0x000024C0 File Offset: 0x000006C0
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(60);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000024CA File Offset: 0x000006CA
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(61);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000024D4 File Offset: 0x000006D4
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(62);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000024DE File Offset: 0x000006DE
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(63);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000024E8 File Offset: 0x000006E8
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(64);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000024F2 File Offset: 0x000006F2
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(65);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000024FC File Offset: 0x000006FC
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(66);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002506 File Offset: 0x00000706
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(67);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002510 File Offset: 0x00000710
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(68);
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000251A File Offset: 0x0000071A
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(69);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00002524 File Offset: 0x00000724
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(132);
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00002531 File Offset: 0x00000731
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(133);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000253E File Offset: 0x0000073E
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(134);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000254B File Offset: 0x0000074B
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(135);
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00002558 File Offset: 0x00000758
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(136);
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00002565 File Offset: 0x00000765
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(70);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000256F File Offset: 0x0000076F
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(71);
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00002579 File Offset: 0x00000779
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(72);
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00002583 File Offset: 0x00000783
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(73);
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000258D File Offset: 0x0000078D
		IControllerTemplateAxis IHOTASTemplate.throttleDial1
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(74);
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00002597 File Offset: 0x00000797
		IControllerTemplateAxis IHOTASTemplate.throttleDial2
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(142);
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000025A4 File Offset: 0x000007A4
		IControllerTemplateAxis IHOTASTemplate.throttleDial3
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(143);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000025B1 File Offset: 0x000007B1
		IControllerTemplateAxis IHOTASTemplate.throttleDial4
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(144);
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000025BE File Offset: 0x000007BE
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(145);
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000025CB File Offset: 0x000007CB
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(146);
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000025D8 File Offset: 0x000007D8
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(147);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000025E5 File Offset: 0x000007E5
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(148);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000025F2 File Offset: 0x000007F2
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(149);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000025FF File Offset: 0x000007FF
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(150);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000260C File Offset: 0x0000080C
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(151);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002619 File Offset: 0x00000819
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(152);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00002626 File Offset: 0x00000826
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press
		{
			get
			{
				return base.GetElement<IControllerTemplateButton>(153);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00002633 File Offset: 0x00000833
		IControllerTemplateAxis IHOTASTemplate.leftPedal
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(168);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00002640 File Offset: 0x00000840
		IControllerTemplateAxis IHOTASTemplate.rightPedal
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(169);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000264D File Offset: 0x0000084D
		IControllerTemplateAxis IHOTASTemplate.slidePedals
		{
			get
			{
				return base.GetElement<IControllerTemplateAxis>(170);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000265A File Offset: 0x0000085A
		IControllerTemplateStick IHOTASTemplate.stick
		{
			get
			{
				return base.GetElement<IControllerTemplateStick>(171);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002667 File Offset: 0x00000867
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(172);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002674 File Offset: 0x00000874
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(173);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002681 File Offset: 0x00000881
		IControllerTemplateHat IHOTASTemplate.stickHat1
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(174);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000268E File Offset: 0x0000088E
		IControllerTemplateHat IHOTASTemplate.stickHat2
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(175);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000269B File Offset: 0x0000089B
		IControllerTemplateHat IHOTASTemplate.stickHat3
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(176);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000026A8 File Offset: 0x000008A8
		IControllerTemplateHat IHOTASTemplate.stickHat4
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(177);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000026B5 File Offset: 0x000008B5
		IControllerTemplateThrottle IHOTASTemplate.throttle1
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(178);
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600019A RID: 410 RVA: 0x000026C2 File Offset: 0x000008C2
		IControllerTemplateThrottle IHOTASTemplate.throttle2
		{
			get
			{
				return base.GetElement<IControllerTemplateThrottle>(179);
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000026CF File Offset: 0x000008CF
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick
		{
			get
			{
				return base.GetElement<IControllerTemplateThumbStick>(180);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000026DC File Offset: 0x000008DC
		IControllerTemplateHat IHOTASTemplate.throttleHat1
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(181);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000026E9 File Offset: 0x000008E9
		IControllerTemplateHat IHOTASTemplate.throttleHat2
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(182);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000026F6 File Offset: 0x000008F6
		IControllerTemplateHat IHOTASTemplate.throttleHat3
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(183);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002703 File Offset: 0x00000903
		IControllerTemplateHat IHOTASTemplate.throttleHat4
		{
			get
			{
				return base.GetElement<IControllerTemplateHat>(184);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002710 File Offset: 0x00000910
		public HOTASTemplate(object payload) : base(payload)
		{
		}

		// Token: 0x04000058 RID: 88
		public static readonly Guid typeGuid = new Guid("061a00cf-d8c2-4f8d-8cb5-a15a010bc53e");

		// Token: 0x04000059 RID: 89
		public const int elementId_stickX = 0;

		// Token: 0x0400005A RID: 90
		public const int elementId_stickY = 1;

		// Token: 0x0400005B RID: 91
		public const int elementId_stickRotate = 2;

		// Token: 0x0400005C RID: 92
		public const int elementId_stickMiniStick1X = 78;

		// Token: 0x0400005D RID: 93
		public const int elementId_stickMiniStick1Y = 79;

		// Token: 0x0400005E RID: 94
		public const int elementId_stickMiniStick1Press = 80;

		// Token: 0x0400005F RID: 95
		public const int elementId_stickMiniStick2X = 81;

		// Token: 0x04000060 RID: 96
		public const int elementId_stickMiniStick2Y = 82;

		// Token: 0x04000061 RID: 97
		public const int elementId_stickMiniStick2Press = 83;

		// Token: 0x04000062 RID: 98
		public const int elementId_stickTrigger = 3;

		// Token: 0x04000063 RID: 99
		public const int elementId_stickTriggerStage2 = 4;

		// Token: 0x04000064 RID: 100
		public const int elementId_stickPinkyButton = 5;

		// Token: 0x04000065 RID: 101
		public const int elementId_stickPinkyTrigger = 154;

		// Token: 0x04000066 RID: 102
		public const int elementId_stickButton1 = 6;

		// Token: 0x04000067 RID: 103
		public const int elementId_stickButton2 = 7;

		// Token: 0x04000068 RID: 104
		public const int elementId_stickButton3 = 8;

		// Token: 0x04000069 RID: 105
		public const int elementId_stickButton4 = 9;

		// Token: 0x0400006A RID: 106
		public const int elementId_stickButton5 = 10;

		// Token: 0x0400006B RID: 107
		public const int elementId_stickButton6 = 11;

		// Token: 0x0400006C RID: 108
		public const int elementId_stickButton7 = 12;

		// Token: 0x0400006D RID: 109
		public const int elementId_stickButton8 = 13;

		// Token: 0x0400006E RID: 110
		public const int elementId_stickButton9 = 14;

		// Token: 0x0400006F RID: 111
		public const int elementId_stickButton10 = 15;

		// Token: 0x04000070 RID: 112
		public const int elementId_stickBaseButton1 = 18;

		// Token: 0x04000071 RID: 113
		public const int elementId_stickBaseButton2 = 19;

		// Token: 0x04000072 RID: 114
		public const int elementId_stickBaseButton3 = 20;

		// Token: 0x04000073 RID: 115
		public const int elementId_stickBaseButton4 = 21;

		// Token: 0x04000074 RID: 116
		public const int elementId_stickBaseButton5 = 22;

		// Token: 0x04000075 RID: 117
		public const int elementId_stickBaseButton6 = 23;

		// Token: 0x04000076 RID: 118
		public const int elementId_stickBaseButton7 = 24;

		// Token: 0x04000077 RID: 119
		public const int elementId_stickBaseButton8 = 25;

		// Token: 0x04000078 RID: 120
		public const int elementId_stickBaseButton9 = 26;

		// Token: 0x04000079 RID: 121
		public const int elementId_stickBaseButton10 = 27;

		// Token: 0x0400007A RID: 122
		public const int elementId_stickBaseButton11 = 161;

		// Token: 0x0400007B RID: 123
		public const int elementId_stickBaseButton12 = 162;

		// Token: 0x0400007C RID: 124
		public const int elementId_stickHat1Up = 28;

		// Token: 0x0400007D RID: 125
		public const int elementId_stickHat1UpRight = 29;

		// Token: 0x0400007E RID: 126
		public const int elementId_stickHat1Right = 30;

		// Token: 0x0400007F RID: 127
		public const int elementId_stickHat1DownRight = 31;

		// Token: 0x04000080 RID: 128
		public const int elementId_stickHat1Down = 32;

		// Token: 0x04000081 RID: 129
		public const int elementId_stickHat1DownLeft = 33;

		// Token: 0x04000082 RID: 130
		public const int elementId_stickHat1Left = 34;

		// Token: 0x04000083 RID: 131
		public const int elementId_stickHat1Up_Left = 35;

		// Token: 0x04000084 RID: 132
		public const int elementId_stickHat2Up = 36;

		// Token: 0x04000085 RID: 133
		public const int elementId_stickHat2Up_right = 37;

		// Token: 0x04000086 RID: 134
		public const int elementId_stickHat2Right = 38;

		// Token: 0x04000087 RID: 135
		public const int elementId_stickHat2Down_Right = 39;

		// Token: 0x04000088 RID: 136
		public const int elementId_stickHat2Down = 40;

		// Token: 0x04000089 RID: 137
		public const int elementId_stickHat2Down_Left = 41;

		// Token: 0x0400008A RID: 138
		public const int elementId_stickHat2Left = 42;

		// Token: 0x0400008B RID: 139
		public const int elementId_stickHat2Up_Left = 43;

		// Token: 0x0400008C RID: 140
		public const int elementId_stickHat3Up = 84;

		// Token: 0x0400008D RID: 141
		public const int elementId_stickHat3Up_Right = 85;

		// Token: 0x0400008E RID: 142
		public const int elementId_stickHat3Right = 86;

		// Token: 0x0400008F RID: 143
		public const int elementId_stickHat3Down_Right = 87;

		// Token: 0x04000090 RID: 144
		public const int elementId_stickHat3Down = 88;

		// Token: 0x04000091 RID: 145
		public const int elementId_stickHat3Down_Left = 89;

		// Token: 0x04000092 RID: 146
		public const int elementId_stickHat3Left = 90;

		// Token: 0x04000093 RID: 147
		public const int elementId_stickHat3Up_Left = 91;

		// Token: 0x04000094 RID: 148
		public const int elementId_stickHat4Up = 92;

		// Token: 0x04000095 RID: 149
		public const int elementId_stickHat4Up_Right = 93;

		// Token: 0x04000096 RID: 150
		public const int elementId_stickHat4Right = 94;

		// Token: 0x04000097 RID: 151
		public const int elementId_stickHat4Down_Right = 95;

		// Token: 0x04000098 RID: 152
		public const int elementId_stickHat4Down = 96;

		// Token: 0x04000099 RID: 153
		public const int elementId_stickHat4Down_Left = 97;

		// Token: 0x0400009A RID: 154
		public const int elementId_stickHat4Left = 98;

		// Token: 0x0400009B RID: 155
		public const int elementId_stickHat4Up_Left = 99;

		// Token: 0x0400009C RID: 156
		public const int elementId_mode1 = 44;

		// Token: 0x0400009D RID: 157
		public const int elementId_mode2 = 45;

		// Token: 0x0400009E RID: 158
		public const int elementId_mode3 = 46;

		// Token: 0x0400009F RID: 159
		public const int elementId_throttle1Axis = 49;

		// Token: 0x040000A0 RID: 160
		public const int elementId_throttle2Axis = 155;

		// Token: 0x040000A1 RID: 161
		public const int elementId_throttle1MinDetent = 166;

		// Token: 0x040000A2 RID: 162
		public const int elementId_throttle2MinDetent = 167;

		// Token: 0x040000A3 RID: 163
		public const int elementId_throttleButton1 = 50;

		// Token: 0x040000A4 RID: 164
		public const int elementId_throttleButton2 = 51;

		// Token: 0x040000A5 RID: 165
		public const int elementId_throttleButton3 = 52;

		// Token: 0x040000A6 RID: 166
		public const int elementId_throttleButton4 = 53;

		// Token: 0x040000A7 RID: 167
		public const int elementId_throttleButton5 = 54;

		// Token: 0x040000A8 RID: 168
		public const int elementId_throttleButton6 = 55;

		// Token: 0x040000A9 RID: 169
		public const int elementId_throttleButton7 = 56;

		// Token: 0x040000AA RID: 170
		public const int elementId_throttleButton8 = 57;

		// Token: 0x040000AB RID: 171
		public const int elementId_throttleButton9 = 58;

		// Token: 0x040000AC RID: 172
		public const int elementId_throttleButton10 = 59;

		// Token: 0x040000AD RID: 173
		public const int elementId_throttleBaseButton1 = 60;

		// Token: 0x040000AE RID: 174
		public const int elementId_throttleBaseButton2 = 61;

		// Token: 0x040000AF RID: 175
		public const int elementId_throttleBaseButton3 = 62;

		// Token: 0x040000B0 RID: 176
		public const int elementId_throttleBaseButton4 = 63;

		// Token: 0x040000B1 RID: 177
		public const int elementId_throttleBaseButton5 = 64;

		// Token: 0x040000B2 RID: 178
		public const int elementId_throttleBaseButton6 = 65;

		// Token: 0x040000B3 RID: 179
		public const int elementId_throttleBaseButton7 = 66;

		// Token: 0x040000B4 RID: 180
		public const int elementId_throttleBaseButton8 = 67;

		// Token: 0x040000B5 RID: 181
		public const int elementId_throttleBaseButton9 = 68;

		// Token: 0x040000B6 RID: 182
		public const int elementId_throttleBaseButton10 = 69;

		// Token: 0x040000B7 RID: 183
		public const int elementId_throttleBaseButton11 = 132;

		// Token: 0x040000B8 RID: 184
		public const int elementId_throttleBaseButton12 = 133;

		// Token: 0x040000B9 RID: 185
		public const int elementId_throttleBaseButton13 = 134;

		// Token: 0x040000BA RID: 186
		public const int elementId_throttleBaseButton14 = 135;

		// Token: 0x040000BB RID: 187
		public const int elementId_throttleBaseButton15 = 136;

		// Token: 0x040000BC RID: 188
		public const int elementId_throttleSlider1 = 70;

		// Token: 0x040000BD RID: 189
		public const int elementId_throttleSlider2 = 71;

		// Token: 0x040000BE RID: 190
		public const int elementId_throttleSlider3 = 72;

		// Token: 0x040000BF RID: 191
		public const int elementId_throttleSlider4 = 73;

		// Token: 0x040000C0 RID: 192
		public const int elementId_throttleDial1 = 74;

		// Token: 0x040000C1 RID: 193
		public const int elementId_throttleDial2 = 142;

		// Token: 0x040000C2 RID: 194
		public const int elementId_throttleDial3 = 143;

		// Token: 0x040000C3 RID: 195
		public const int elementId_throttleDial4 = 144;

		// Token: 0x040000C4 RID: 196
		public const int elementId_throttleMiniStickX = 75;

		// Token: 0x040000C5 RID: 197
		public const int elementId_throttleMiniStickY = 76;

		// Token: 0x040000C6 RID: 198
		public const int elementId_throttleMiniStickPress = 77;

		// Token: 0x040000C7 RID: 199
		public const int elementId_throttleWheel1Forward = 145;

		// Token: 0x040000C8 RID: 200
		public const int elementId_throttleWheel1Back = 146;

		// Token: 0x040000C9 RID: 201
		public const int elementId_throttleWheel1Press = 147;

		// Token: 0x040000CA RID: 202
		public const int elementId_throttleWheel2Forward = 148;

		// Token: 0x040000CB RID: 203
		public const int elementId_throttleWheel2Back = 149;

		// Token: 0x040000CC RID: 204
		public const int elementId_throttleWheel2Press = 150;

		// Token: 0x040000CD RID: 205
		public const int elementId_throttleWheel3Forward = 151;

		// Token: 0x040000CE RID: 206
		public const int elementId_throttleWheel3Back = 152;

		// Token: 0x040000CF RID: 207
		public const int elementId_throttleWheel3Press = 153;

		// Token: 0x040000D0 RID: 208
		public const int elementId_throttleHat1Up = 100;

		// Token: 0x040000D1 RID: 209
		public const int elementId_throttleHat1Up_Right = 101;

		// Token: 0x040000D2 RID: 210
		public const int elementId_throttleHat1Right = 102;

		// Token: 0x040000D3 RID: 211
		public const int elementId_throttleHat1Down_Right = 103;

		// Token: 0x040000D4 RID: 212
		public const int elementId_throttleHat1Down = 104;

		// Token: 0x040000D5 RID: 213
		public const int elementId_throttleHat1Down_Left = 105;

		// Token: 0x040000D6 RID: 214
		public const int elementId_throttleHat1Left = 106;

		// Token: 0x040000D7 RID: 215
		public const int elementId_throttleHat1Up_Left = 107;

		// Token: 0x040000D8 RID: 216
		public const int elementId_throttleHat2Up = 108;

		// Token: 0x040000D9 RID: 217
		public const int elementId_throttleHat2Up_Right = 109;

		// Token: 0x040000DA RID: 218
		public const int elementId_throttleHat2Right = 110;

		// Token: 0x040000DB RID: 219
		public const int elementId_throttleHat2Down_Right = 111;

		// Token: 0x040000DC RID: 220
		public const int elementId_throttleHat2Down = 112;

		// Token: 0x040000DD RID: 221
		public const int elementId_throttleHat2Down_Left = 113;

		// Token: 0x040000DE RID: 222
		public const int elementId_throttleHat2Left = 114;

		// Token: 0x040000DF RID: 223
		public const int elementId_throttleHat2Up_Left = 115;

		// Token: 0x040000E0 RID: 224
		public const int elementId_throttleHat3Up = 116;

		// Token: 0x040000E1 RID: 225
		public const int elementId_throttleHat3Up_Right = 117;

		// Token: 0x040000E2 RID: 226
		public const int elementId_throttleHat3Right = 118;

		// Token: 0x040000E3 RID: 227
		public const int elementId_throttleHat3Down_Right = 119;

		// Token: 0x040000E4 RID: 228
		public const int elementId_throttleHat3Down = 120;

		// Token: 0x040000E5 RID: 229
		public const int elementId_throttleHat3Down_Left = 121;

		// Token: 0x040000E6 RID: 230
		public const int elementId_throttleHat3Left = 122;

		// Token: 0x040000E7 RID: 231
		public const int elementId_throttleHat3Up_Left = 123;

		// Token: 0x040000E8 RID: 232
		public const int elementId_throttleHat4Up = 124;

		// Token: 0x040000E9 RID: 233
		public const int elementId_throttleHat4Up_Right = 125;

		// Token: 0x040000EA RID: 234
		public const int elementId_throttleHat4Right = 126;

		// Token: 0x040000EB RID: 235
		public const int elementId_throttleHat4Down_Right = 127;

		// Token: 0x040000EC RID: 236
		public const int elementId_throttleHat4Down = 128;

		// Token: 0x040000ED RID: 237
		public const int elementId_throttleHat4Down_Left = 129;

		// Token: 0x040000EE RID: 238
		public const int elementId_throttleHat4Left = 130;

		// Token: 0x040000EF RID: 239
		public const int elementId_throttleHat4Up_Left = 131;

		// Token: 0x040000F0 RID: 240
		public const int elementId_leftPedal = 168;

		// Token: 0x040000F1 RID: 241
		public const int elementId_rightPedal = 169;

		// Token: 0x040000F2 RID: 242
		public const int elementId_slidePedals = 170;

		// Token: 0x040000F3 RID: 243
		public const int elementId_stick = 171;

		// Token: 0x040000F4 RID: 244
		public const int elementId_stickMiniStick1 = 172;

		// Token: 0x040000F5 RID: 245
		public const int elementId_stickMiniStick2 = 173;

		// Token: 0x040000F6 RID: 246
		public const int elementId_stickHat1 = 174;

		// Token: 0x040000F7 RID: 247
		public const int elementId_stickHat2 = 175;

		// Token: 0x040000F8 RID: 248
		public const int elementId_stickHat3 = 176;

		// Token: 0x040000F9 RID: 249
		public const int elementId_stickHat4 = 177;

		// Token: 0x040000FA RID: 250
		public const int elementId_throttle1 = 178;

		// Token: 0x040000FB RID: 251
		public const int elementId_throttle2 = 179;

		// Token: 0x040000FC RID: 252
		public const int elementId_throttleMiniStick = 180;

		// Token: 0x040000FD RID: 253
		public const int elementId_throttleHat1 = 181;

		// Token: 0x040000FE RID: 254
		public const int elementId_throttleHat2 = 182;

		// Token: 0x040000FF RID: 255
		public const int elementId_throttleHat3 = 183;

		// Token: 0x04000100 RID: 256
		public const int elementId_throttleHat4 = 184;
	}
}
