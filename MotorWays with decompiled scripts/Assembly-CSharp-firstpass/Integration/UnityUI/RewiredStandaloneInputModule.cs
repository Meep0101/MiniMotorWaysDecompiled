using System;
using System.Collections.Generic;
using Rewired.Components;
using Rewired.UI;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000017 RID: 23
	[AddComponentMenu("Rewired/Rewired Standalone Input Module")]
	public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00005692 File Offset: 0x00003892
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0000569A File Offset: 0x0000389A
		public InputManager_Base RewiredInputManager
		{
			get
			{
				return this.rewiredInputManager;
			}
			set
			{
				this.rewiredInputManager = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x000056A3 File Offset: 0x000038A3
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000056AB File Offset: 0x000038AB
		public bool UseAllRewiredGamePlayers
		{
			get
			{
				return this.useAllRewiredGamePlayers;
			}
			set
			{
				bool flag = value != this.useAllRewiredGamePlayers;
				this.useAllRewiredGamePlayers = value;
				if (flag)
				{
					this.SetupRewiredVars();
				}
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000056C8 File Offset: 0x000038C8
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x000056D0 File Offset: 0x000038D0
		public bool UseRewiredSystemPlayer
		{
			get
			{
				return this.useRewiredSystemPlayer;
			}
			set
			{
				bool flag = value != this.useRewiredSystemPlayer;
				this.useRewiredSystemPlayer = value;
				if (flag)
				{
					this.SetupRewiredVars();
				}
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000056ED File Offset: 0x000038ED
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x000056FF File Offset: 0x000038FF
		public int[] RewiredPlayerIds
		{
			get
			{
				return (int[])this.rewiredPlayerIds.Clone();
			}
			set
			{
				this.rewiredPlayerIds = ((value != null) ? ((int[])value.Clone()) : new int[0]);
				this.SetupRewiredVars();
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00005723 File Offset: 0x00003923
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000572B File Offset: 0x0000392B
		public bool UsePlayingPlayersOnly
		{
			get
			{
				return this.usePlayingPlayersOnly;
			}
			set
			{
				this.usePlayingPlayersOnly = value;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00005734 File Offset: 0x00003934
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00005741 File Offset: 0x00003941
		public List<PlayerMouse> PlayerMice
		{
			get
			{
				return new List<PlayerMouse>(this.playerMice);
			}
			set
			{
				if (value == null)
				{
					this.playerMice = new List<PlayerMouse>();
					this.SetupRewiredVars();
					return;
				}
				this.playerMice = new List<PlayerMouse>(value);
				this.SetupRewiredVars();
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0000576A File Offset: 0x0000396A
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00005772 File Offset: 0x00003972
		public bool MoveOneElementPerAxisPress
		{
			get
			{
				return this.moveOneElementPerAxisPress;
			}
			set
			{
				this.moveOneElementPerAxisPress = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000577B File Offset: 0x0000397B
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00005783 File Offset: 0x00003983
		public bool allowMouseInput
		{
			get
			{
				return this.m_allowMouseInput;
			}
			set
			{
				this.m_allowMouseInput = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000578C File Offset: 0x0000398C
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00005794 File Offset: 0x00003994
		public bool allowMouseInputIfTouchSupported
		{
			get
			{
				return this.m_allowMouseInputIfTouchSupported;
			}
			set
			{
				this.m_allowMouseInputIfTouchSupported = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0000579D File Offset: 0x0000399D
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000057A5 File Offset: 0x000039A5
		public bool allowTouchInput
		{
			get
			{
				return this.m_allowTouchInput;
			}
			set
			{
				this.m_allowTouchInput = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000057AE File Offset: 0x000039AE
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000057B6 File Offset: 0x000039B6
		public bool deselectIfBackgroundClicked
		{
			get
			{
				return this.m_deselectIfBackgroundClicked;
			}
			set
			{
				this.m_deselectIfBackgroundClicked = value;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000057BF File Offset: 0x000039BF
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000057C7 File Offset: 0x000039C7
		private bool deselectBeforeSelecting
		{
			get
			{
				return this.m_deselectBeforeSelecting;
			}
			set
			{
				this.m_deselectBeforeSelecting = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000057D0 File Offset: 0x000039D0
		// (set) Token: 0x0600030B RID: 779 RVA: 0x000057D8 File Offset: 0x000039D8
		public bool SetActionsById
		{
			get
			{
				return this.setActionsById;
			}
			set
			{
				if (this.setActionsById == value)
				{
					return;
				}
				this.setActionsById = value;
				this.SetupRewiredVars();
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000057F1 File Offset: 0x000039F1
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000057FC File Offset: 0x000039FC
		public int HorizontalActionId
		{
			get
			{
				return this.horizontalActionId;
			}
			set
			{
				if (value == this.horizontalActionId)
				{
					return;
				}
				this.horizontalActionId = value;
				if (ReInput.isReady)
				{
					this.m_HorizontalAxis = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000584B File Offset: 0x00003A4B
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00005854 File Offset: 0x00003A54
		public int VerticalActionId
		{
			get
			{
				return this.verticalActionId;
			}
			set
			{
				if (value == this.verticalActionId)
				{
					return;
				}
				this.verticalActionId = value;
				if (ReInput.isReady)
				{
					this.m_VerticalAxis = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000058A3 File Offset: 0x00003AA3
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000058AC File Offset: 0x00003AAC
		public int SubmitActionId
		{
			get
			{
				return this.submitActionId;
			}
			set
			{
				if (value == this.submitActionId)
				{
					return;
				}
				this.submitActionId = value;
				if (ReInput.isReady)
				{
					this.m_SubmitButton = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000058FB File Offset: 0x00003AFB
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00005904 File Offset: 0x00003B04
		public int CancelActionId
		{
			get
			{
				return this.cancelActionId;
			}
			set
			{
				if (value == this.cancelActionId)
				{
					return;
				}
				this.cancelActionId = value;
				if (ReInput.isReady)
				{
					this.m_CancelButton = ((ReInput.mapping.GetAction(value) != null) ? ReInput.mapping.GetAction(value).name : string.Empty);
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00005953 File Offset: 0x00003B53
		protected override bool isMouseSupported
		{
			get
			{
				return base.isMouseSupported && this.m_allowMouseInput && (!this.isTouchSupported || this.m_allowMouseInputIfTouchSupported);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00005979 File Offset: 0x00003B79
		private bool isTouchAllowed
		{
			get
			{
				return this.m_allowTouchInput;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00005981 File Offset: 0x00003B81
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00005989 File Offset: 0x00003B89
		[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
		public bool allowActivationOnMobileDevice
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
				this.m_ForceModuleActive = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00005992 File Offset: 0x00003B92
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0000599A File Offset: 0x00003B9A
		public bool forceModuleActive
		{
			get
			{
				return this.m_ForceModuleActive;
			}
			set
			{
				this.m_ForceModuleActive = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000059A3 File Offset: 0x00003BA3
		// (set) Token: 0x0600031B RID: 795 RVA: 0x000059AB File Offset: 0x00003BAB
		public float inputActionsPerSecond
		{
			get
			{
				return this.m_InputActionsPerSecond;
			}
			set
			{
				this.m_InputActionsPerSecond = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600031C RID: 796 RVA: 0x000059B4 File Offset: 0x00003BB4
		// (set) Token: 0x0600031D RID: 797 RVA: 0x000059BC File Offset: 0x00003BBC
		public float repeatDelay
		{
			get
			{
				return this.m_RepeatDelay;
			}
			set
			{
				this.m_RepeatDelay = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600031E RID: 798 RVA: 0x000059C5 File Offset: 0x00003BC5
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000059CD File Offset: 0x00003BCD
		public string horizontalAxis
		{
			get
			{
				return this.m_HorizontalAxis;
			}
			set
			{
				if (this.m_HorizontalAxis == value)
				{
					return;
				}
				this.m_HorizontalAxis = value;
				if (ReInput.isReady)
				{
					this.horizontalActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000320 RID: 800 RVA: 0x000059FD File Offset: 0x00003BFD
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00005A05 File Offset: 0x00003C05
		public string verticalAxis
		{
			get
			{
				return this.m_VerticalAxis;
			}
			set
			{
				if (this.m_VerticalAxis == value)
				{
					return;
				}
				this.m_VerticalAxis = value;
				if (ReInput.isReady)
				{
					this.verticalActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00005A35 File Offset: 0x00003C35
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00005A3D File Offset: 0x00003C3D
		public string submitButton
		{
			get
			{
				return this.m_SubmitButton;
			}
			set
			{
				if (this.m_SubmitButton == value)
				{
					return;
				}
				this.m_SubmitButton = value;
				if (ReInput.isReady)
				{
					this.submitActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00005A6D File Offset: 0x00003C6D
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00005A75 File Offset: 0x00003C75
		public string cancelButton
		{
			get
			{
				return this.m_CancelButton;
			}
			set
			{
				if (this.m_CancelButton == value)
				{
					return;
				}
				this.m_CancelButton = value;
				if (ReInput.isReady)
				{
					this.cancelActionId = ReInput.mapping.GetActionId(value);
				}
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00005AA8 File Offset: 0x00003CA8
		private RewiredStandaloneInputModule()
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00005B50 File Offset: 0x00003D50
		protected override void Awake()
		{
			base.Awake();
			this.isTouchSupported = base.defaultTouchInputSource.touchSupported;
			TouchInputModule component = base.GetComponent<TouchInputModule>();
			if (component != null)
			{
				component.enabled = false;
			}
			ReInput.InitializedEvent += this.OnRewiredInitialized;
			this.InitializeRewired();
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00005BA2 File Offset: 0x00003DA2
		public override void UpdateModule()
		{
			this.CheckEditorRecompile();
			if (this.recompiling)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.m_HasFocus)
			{
				this.ShouldIgnoreEventsOnNoFocus();
				return;
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00005BCB File Offset: 0x00003DCB
		public override bool IsModuleSupported()
		{
			return true;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00005BD0 File Offset: 0x00003DD0
		public override bool ShouldActivateModule()
		{
			if (!base.ShouldActivateModule())
			{
				return false;
			}
			if (this.recompiling)
			{
				return false;
			}
			if (!ReInput.isReady)
			{
				return false;
			}
			bool flag = this.m_ForceModuleActive;
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					flag |= this.GetButtonDown(player, this.submitActionId);
					flag |= this.GetButtonDown(player, this.cancelActionId);
					if (this.moveOneElementPerAxisPress)
					{
						flag |= (this.GetButtonDown(player, this.horizontalActionId) || this.GetNegativeButtonDown(player, this.horizontalActionId));
						flag |= (this.GetButtonDown(player, this.verticalActionId) || this.GetNegativeButtonDown(player, this.verticalActionId));
					}
					else
					{
						flag |= !Mathf.Approximately(this.GetAxis(player, this.horizontalActionId), 0f);
						flag |= !Mathf.Approximately(this.GetAxis(player, this.verticalActionId), 0f);
					}
				}
			}
			if (this.isMouseSupported)
			{
				flag |= this.DidAnyMouseMove();
				flag |= this.GetMouseButtonDownOnAnyMouse(0);
			}
			if (this.isTouchAllowed)
			{
				for (int j = 0; j < base.defaultTouchInputSource.touchCount; j++)
				{
					Touch touch = base.defaultTouchInputSource.GetTouch(j);
					flag |= (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary);
				}
			}
			return flag;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00005D5C File Offset: 0x00003F5C
		public override void ActivateModule()
		{
			if (!this.m_HasFocus && this.ShouldIgnoreEventsOnNoFocus())
			{
				return;
			}
			base.ActivateModule();
			GameObject gameObject = base.eventSystem.currentSelectedGameObject;
			if (gameObject == null)
			{
				gameObject = base.eventSystem.firstSelectedGameObject;
			}
			base.eventSystem.SetSelectedGameObject(gameObject, this.GetBaseEventData());
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00005DB3 File Offset: 0x00003FB3
		public override void DeactivateModule()
		{
			base.DeactivateModule();
			base.ClearSelection();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00005DC4 File Offset: 0x00003FC4
		public override void Process()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.m_HasFocus && this.ShouldIgnoreEventsOnNoFocus())
			{
				return;
			}
			if (!base.enabled || !base.gameObject.activeInHierarchy)
			{
				return;
			}
			bool flag = this.SendUpdateEventToSelectedObject();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag |= this.SendMoveEventToSelectedObject();
				}
				if (!flag)
				{
					this.SendSubmitEventToSelectedObject();
				}
			}
			if (!this.ProcessTouchEvents() && this.isMouseSupported)
			{
				this.ProcessMouseEvents();
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00005E40 File Offset: 0x00004040
		private bool ProcessTouchEvents()
		{
			if (!this.isTouchAllowed)
			{
				return false;
			}
			for (int i = 0; i < base.defaultTouchInputSource.touchCount; i++)
			{
				Touch touch = base.defaultTouchInputSource.GetTouch(i);
				if (touch.type != TouchType.Indirect)
				{
					bool pressed;
					bool flag;
					PlayerPointerEventData touchPointerEventData = base.GetTouchPointerEventData(0, 0, touch, out pressed, out flag);
					this.ProcessTouchPress(touchPointerEventData, pressed, flag);
					if (!flag)
					{
						this.ProcessMove(touchPointerEventData);
						this.ProcessDrag(touchPointerEventData);
					}
					else
					{
						base.RemovePointerData(touchPointerEventData);
					}
				}
			}
			return base.defaultTouchInputSource.touchCount > 0;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00005EC8 File Offset: 0x000040C8
		private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			GameObject gameObject = pointerEvent.pointerCurrentRaycast.gameObject;
			if (pressed)
			{
				pointerEvent.eligibleForClick = true;
				pointerEvent.delta = Vector2.zero;
				pointerEvent.dragging = false;
				pointerEvent.useDragThreshold = true;
				pointerEvent.pressPosition = pointerEvent.position;
				pointerEvent.pointerPressRaycast = pointerEvent.pointerCurrentRaycast;
				this.HandleMouseTouchDeselectionOnSelectionChanged(gameObject, pointerEvent);
				if (pointerEvent.pointerEnter != gameObject)
				{
					base.HandlePointerExitAndEnter(pointerEvent, gameObject);
					pointerEvent.pointerEnter = gameObject;
				}
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, pointerEvent, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
				double unscaledTime = ReInput.time.unscaledTime;
				if (gameObject2 == pointerEvent.lastPress)
				{
					if (unscaledTime - (double)pointerEvent.clickTime < 0.30000001192092896)
					{
						int clickCount = pointerEvent.clickCount + 1;
						pointerEvent.clickCount = clickCount;
					}
					else
					{
						pointerEvent.clickCount = 1;
					}
					pointerEvent.clickTime = (float)unscaledTime;
				}
				else
				{
					pointerEvent.clickCount = 1;
				}
				pointerEvent.pointerPress = gameObject2;
				pointerEvent.rawPointerPress = gameObject;
				pointerEvent.clickTime = (float)unscaledTime;
				pointerEvent.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (pointerEvent.pointerDrag != null)
				{
					ExecuteEvents.Execute<IInitializePotentialDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.initializePotentialDrag);
				}
			}
			if (released)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (pointerEvent.pointerPress == eventHandler && pointerEvent.eligibleForClick)
				{
					ExecuteEvents.Execute<IPointerClickHandler>(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerClickHandler);
				}
				else if (pointerEvent.pointerDrag != null && pointerEvent.dragging)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, pointerEvent, ExecuteEvents.dropHandler);
				}
				pointerEvent.eligibleForClick = false;
				pointerEvent.pointerPress = null;
				pointerEvent.rawPointerPress = null;
				if (pointerEvent.pointerDrag != null && pointerEvent.dragging)
				{
					ExecuteEvents.Execute<IEndDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.endDragHandler);
				}
				pointerEvent.dragging = false;
				pointerEvent.pointerDrag = null;
				if (pointerEvent.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.endDragHandler);
				}
				pointerEvent.pointerDrag = null;
				ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>(pointerEvent.pointerEnter, pointerEvent, ExecuteEvents.pointerExitHandler);
				pointerEvent.pointerEnter = null;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000060F8 File Offset: 0x000042F8
		private bool SendSubmitEventToSelectedObject()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			if (this.recompiling)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					if (this.GetButtonDown(player, this.submitActionId))
					{
						ExecuteEvents.Execute<ISubmitHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
						break;
					}
					if (this.GetButtonDown(player, this.cancelActionId))
					{
						ExecuteEvents.Execute<ICancelHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
						break;
					}
				}
			}
			return baseEventData.used;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000061C0 File Offset: 0x000043C0
		private Vector2 GetRawMoveVector()
		{
			if (this.recompiling)
			{
				return Vector2.zero;
			}
			Vector2 zero = Vector2.zero;
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					float num = this.GetAxis(player, this.horizontalActionId);
					float num2 = this.GetAxis(player, this.verticalActionId);
					if (Mathf.Approximately(num, 0f))
					{
						num = 0f;
					}
					if (Mathf.Approximately(num2, 0f))
					{
						num2 = 0f;
					}
					if (this.moveOneElementPerAxisPress)
					{
						if (this.GetButtonDown(player, this.horizontalActionId) && num > 0f)
						{
							zero.x += 1f;
						}
						if (this.GetNegativeButtonDown(player, this.horizontalActionId) && num < 0f)
						{
							zero.x -= 1f;
						}
						if (this.GetButtonDown(player, this.verticalActionId) && num2 > 0f)
						{
							zero.y += 1f;
						}
						if (this.GetNegativeButtonDown(player, this.verticalActionId) && num2 < 0f)
						{
							zero.y -= 1f;
						}
					}
					else
					{
						if (this.GetButton(player, this.horizontalActionId) && num > 0f)
						{
							zero.x += 1f;
						}
						if (this.GetNegativeButton(player, this.horizontalActionId) && num < 0f)
						{
							zero.x -= 1f;
						}
						if (this.GetButton(player, this.verticalActionId) && num2 > 0f)
						{
							zero.y += 1f;
						}
						if (this.GetNegativeButton(player, this.verticalActionId) && num2 < 0f)
						{
							zero.y -= 1f;
						}
					}
				}
			}
			return zero;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000063C0 File Offset: 0x000045C0
		private bool SendMoveEventToSelectedObject()
		{
			if (this.recompiling)
			{
				return false;
			}
			double unscaledTime = ReInput.time.unscaledTime;
			Vector2 rawMoveVector = this.GetRawMoveVector();
			if (Mathf.Approximately(rawMoveVector.x, 0f) && Mathf.Approximately(rawMoveVector.y, 0f))
			{
				this.m_ConsecutiveMoveCount = 0;
				return false;
			}
			bool flag = Vector2.Dot(rawMoveVector, this.m_LastMoveVector) > 0f;
			bool flag2;
			bool flag3;
			this.CheckButtonOrKeyMovement(out flag2, out flag3);
			AxisEventData axisEventData = null;
			bool flag4 = flag2 || flag3;
			if (flag4)
			{
				axisEventData = this.GetAxisEventData(rawMoveVector.x, rawMoveVector.y, 0f);
				MoveDirection moveDir = axisEventData.moveDir;
				flag4 = (((moveDir == MoveDirection.Up || moveDir == MoveDirection.Down) && flag3) || ((moveDir == MoveDirection.Left || moveDir == MoveDirection.Right) && flag2));
			}
			if (!flag4)
			{
				if (this.m_RepeatDelay > 0f)
				{
					if (flag && this.m_ConsecutiveMoveCount == 1)
					{
						flag4 = (unscaledTime > this.m_PrevActionTime + (double)this.m_RepeatDelay);
					}
					else
					{
						flag4 = (unscaledTime > this.m_PrevActionTime + (double)(1f / this.m_InputActionsPerSecond));
					}
				}
				else
				{
					flag4 = (unscaledTime > this.m_PrevActionTime + (double)(1f / this.m_InputActionsPerSecond));
				}
			}
			if (!flag4)
			{
				return false;
			}
			if (axisEventData == null)
			{
				axisEventData = this.GetAxisEventData(rawMoveVector.x, rawMoveVector.y, 0f);
			}
			if (axisEventData.moveDir != MoveDirection.None)
			{
				ExecuteEvents.Execute<IMoveHandler>(base.eventSystem.currentSelectedGameObject, axisEventData, ExecuteEvents.moveHandler);
				if (!flag)
				{
					this.m_ConsecutiveMoveCount = 0;
				}
				if (this.m_ConsecutiveMoveCount == 0 || (!flag2 && !flag3))
				{
					this.m_ConsecutiveMoveCount++;
				}
				this.m_PrevActionTime = unscaledTime;
				this.m_LastMoveVector = rawMoveVector;
			}
			else
			{
				this.m_ConsecutiveMoveCount = 0;
			}
			return axisEventData.used;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00006578 File Offset: 0x00004778
		private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
		{
			downHorizontal = false;
			downVertical = false;
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					downHorizontal |= (this.GetButtonDown(player, this.horizontalActionId) || this.GetNegativeButtonDown(player, this.horizontalActionId));
					downVertical |= (this.GetButtonDown(player, this.verticalActionId) || this.GetNegativeButtonDown(player, this.verticalActionId));
				}
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000660C File Offset: 0x0000480C
		private void ProcessMouseEvents()
		{
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				Player player = ReInput.players.GetPlayer(this.playerIds[i]);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int mouseInputSourceCount = base.GetMouseInputSourceCount(this.playerIds[i]);
					for (int j = 0; j < mouseInputSourceCount; j++)
					{
						this.ProcessMouseEvent(this.playerIds[i], j);
					}
				}
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000667C File Offset: 0x0000487C
		private void ProcessMouseEvent(int playerId, int pointerIndex)
		{
			RewiredPointerInputModule.MouseState mousePointerEventData = this.GetMousePointerEventData(playerId, pointerIndex);
			if (mousePointerEventData == null)
			{
				return;
			}
			RewiredPointerInputModule.MouseButtonEventData eventData = mousePointerEventData.GetButtonState(0).eventData;
			this.ProcessMousePress(eventData);
			this.ProcessMove(eventData.buttonData);
			this.ProcessDrag(eventData.buttonData);
			this.ProcessMousePress(mousePointerEventData.GetButtonState(1).eventData);
			this.ProcessDrag(mousePointerEventData.GetButtonState(1).eventData.buttonData);
			this.ProcessMousePress(mousePointerEventData.GetButtonState(2).eventData);
			this.ProcessDrag(mousePointerEventData.GetButtonState(2).eventData.buttonData);
			IMouseInputSource mouseInputSource = base.GetMouseInputSource(playerId, pointerIndex);
			if (mouseInputSource == null)
			{
				return;
			}
			for (int i = 3; i < mouseInputSource.buttonCount; i++)
			{
				this.ProcessMousePress(mousePointerEventData.GetButtonState(i).eventData);
				this.ProcessDrag(mousePointerEventData.GetButtonState(i).eventData.buttonData);
			}
			if (!Mathf.Approximately(eventData.buttonData.scrollDelta.sqrMagnitude, 0f))
			{
				ExecuteEvents.ExecuteHierarchy<IScrollHandler>(ExecuteEvents.GetEventHandler<IScrollHandler>(eventData.buttonData.pointerCurrentRaycast.gameObject), eventData.buttonData, ExecuteEvents.scrollHandler);
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000067A8 File Offset: 0x000049A8
		private bool SendUpdateEventToSelectedObject()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			ExecuteEvents.Execute<IUpdateSelectedHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
			return baseEventData.used;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000067F0 File Offset: 0x000049F0
		private void ProcessMousePress(RewiredPointerInputModule.MouseButtonEventData data)
		{
			PlayerPointerEventData buttonData = data.buttonData;
			if (base.GetMouseInputSource(buttonData.playerId, buttonData.inputSourceIndex) == null)
			{
				return;
			}
			GameObject gameObject = buttonData.pointerCurrentRaycast.gameObject;
			if (data.PressedThisFrame())
			{
				buttonData.eligibleForClick = true;
				buttonData.delta = Vector2.zero;
				buttonData.dragging = false;
				buttonData.useDragThreshold = true;
				buttonData.pressPosition = buttonData.position;
				buttonData.pointerPressRaycast = buttonData.pointerCurrentRaycast;
				this.HandleMouseTouchDeselectionOnSelectionChanged(gameObject, buttonData);
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, buttonData, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
				double unscaledTime = ReInput.time.unscaledTime;
				if (gameObject2 == buttonData.lastPress)
				{
					if (unscaledTime - (double)buttonData.clickTime < 0.30000001192092896)
					{
						PlayerPointerEventData playerPointerEventData = buttonData;
						int clickCount = playerPointerEventData.clickCount + 1;
						playerPointerEventData.clickCount = clickCount;
					}
					else
					{
						buttonData.clickCount = 1;
					}
					buttonData.clickTime = (float)unscaledTime;
				}
				else
				{
					buttonData.clickCount = 1;
				}
				buttonData.pointerPress = gameObject2;
				buttonData.rawPointerPress = gameObject;
				buttonData.clickTime = (float)unscaledTime;
				buttonData.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (buttonData.pointerDrag != null)
				{
					ExecuteEvents.Execute<IInitializePotentialDragHandler>(buttonData.pointerDrag, buttonData, ExecuteEvents.initializePotentialDrag);
				}
			}
			if (data.ReleasedThisFrame())
			{
				ExecuteEvents.Execute<IPointerUpHandler>(buttonData.pointerPress, buttonData, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (buttonData.pointerPress == eventHandler && buttonData.eligibleForClick)
				{
					ExecuteEvents.Execute<IPointerClickHandler>(buttonData.pointerPress, buttonData, ExecuteEvents.pointerClickHandler);
				}
				else if (buttonData.pointerDrag != null && buttonData.dragging)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, buttonData, ExecuteEvents.dropHandler);
				}
				buttonData.eligibleForClick = false;
				buttonData.pointerPress = null;
				buttonData.rawPointerPress = null;
				if (buttonData.pointerDrag != null && buttonData.dragging)
				{
					ExecuteEvents.Execute<IEndDragHandler>(buttonData.pointerDrag, buttonData, ExecuteEvents.endDragHandler);
				}
				buttonData.dragging = false;
				buttonData.pointerDrag = null;
				if (gameObject != buttonData.pointerEnter)
				{
					base.HandlePointerExitAndEnter(buttonData, null);
					base.HandlePointerExitAndEnter(buttonData, gameObject);
				}
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00006A0C File Offset: 0x00004C0C
		private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			if (this.m_deselectIfBackgroundClicked && this.m_deselectBeforeSelecting)
			{
				base.DeselectIfSelectionChanged(currentOverGo, pointerEvent);
				return;
			}
			GameObject eventHandler = ExecuteEvents.GetEventHandler<ISelectHandler>(currentOverGo);
			if (this.m_deselectIfBackgroundClicked)
			{
				if (eventHandler != base.eventSystem.currentSelectedGameObject && eventHandler != null)
				{
					base.eventSystem.SetSelectedGameObject(null, pointerEvent);
					return;
				}
			}
			else if (this.m_deselectBeforeSelecting && eventHandler != null && eventHandler != base.eventSystem.currentSelectedGameObject)
			{
				base.eventSystem.SetSelectedGameObject(null, pointerEvent);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00006A9C File Offset: 0x00004C9C
		private void OnApplicationFocus(bool hasFocus)
		{
			this.m_HasFocus = hasFocus;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00006AA5 File Offset: 0x00004CA5
		private bool ShouldIgnoreEventsOnNoFocus()
		{
			return !ReInput.isReady || ReInput.configuration.ignoreInputWhenAppNotInFocus;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00006ABA File Offset: 0x00004CBA
		protected override void OnDestroy()
		{
			base.OnDestroy();
			ReInput.InitializedEvent -= this.OnRewiredInitialized;
			ReInput.ShutDownEvent -= this.OnRewiredShutDown;
			ReInput.EditorRecompileEvent -= this.OnEditorRecompile;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00006AF8 File Offset: 0x00004CF8
		protected override bool IsDefaultPlayer(int playerId)
		{
			if (this.playerIds == null)
			{
				return false;
			}
			if (!ReInput.isReady)
			{
				return false;
			}
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < this.playerIds.Length; j++)
				{
					Player player = ReInput.players.GetPlayer(this.playerIds[j]);
					if (player != null && (i >= 1 || !this.usePlayingPlayersOnly || player.isPlaying) && (i >= 2 || player.controllers.hasMouse))
					{
						return this.playerIds[j] == playerId;
					}
				}
			}
			return false;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00006B80 File Offset: 0x00004D80
		private void InitializeRewired()
		{
			if (!ReInput.isReady)
			{
				Debug.LogError("Rewired is not initialized! Are you missing a Rewired Input Manager in your scene?");
				return;
			}
			ReInput.ShutDownEvent -= this.OnRewiredShutDown;
			ReInput.ShutDownEvent += this.OnRewiredShutDown;
			ReInput.EditorRecompileEvent -= this.OnEditorRecompile;
			ReInput.EditorRecompileEvent += this.OnEditorRecompile;
			this.SetupRewiredVars();
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00006BEC File Offset: 0x00004DEC
		private void SetupRewiredVars()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			this.SetUpRewiredActions();
			if (this.useAllRewiredGamePlayers)
			{
				IList<Player> list = this.useRewiredSystemPlayer ? ReInput.players.AllPlayers : ReInput.players.Players;
				this.playerIds = new int[list.Count];
				for (int i = 0; i < list.Count; i++)
				{
					this.playerIds[i] = list[i].id;
				}
			}
			else
			{
				bool flag = false;
				List<int> list2 = new List<int>(this.rewiredPlayerIds.Length + 1);
				for (int j = 0; j < this.rewiredPlayerIds.Length; j++)
				{
					Player player = ReInput.players.GetPlayer(this.rewiredPlayerIds[j]);
					if (player != null && !list2.Contains(player.id))
					{
						list2.Add(player.id);
						if (player.id == 9999999)
						{
							flag = true;
						}
					}
				}
				if (this.useRewiredSystemPlayer && !flag)
				{
					list2.Insert(0, ReInput.players.GetSystemPlayer().id);
				}
				this.playerIds = list2.ToArray();
			}
			this.SetUpRewiredPlayerMice();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00006D0C File Offset: 0x00004F0C
		private void SetUpRewiredPlayerMice()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			base.ClearMouseInputSources();
			for (int i = 0; i < this.playerMice.Count; i++)
			{
				PlayerMouse playerMouse = this.playerMice[i];
				if (!UnityTools.IsNullOrDestroyed<PlayerMouse>(playerMouse))
				{
					base.AddMouseInputSource(playerMouse);
				}
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00006D5C File Offset: 0x00004F5C
		private void SetUpRewiredActions()
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (!this.setActionsById)
			{
				this.horizontalActionId = ReInput.mapping.GetActionId(this.m_HorizontalAxis);
				this.verticalActionId = ReInput.mapping.GetActionId(this.m_VerticalAxis);
				this.submitActionId = ReInput.mapping.GetActionId(this.m_SubmitButton);
				this.cancelActionId = ReInput.mapping.GetActionId(this.m_CancelButton);
				return;
			}
			InputAction action = ReInput.mapping.GetAction(this.horizontalActionId);
			this.m_HorizontalAxis = ((action != null) ? action.name : string.Empty);
			if (action == null)
			{
				this.horizontalActionId = -1;
			}
			action = ReInput.mapping.GetAction(this.verticalActionId);
			this.m_VerticalAxis = ((action != null) ? action.name : string.Empty);
			if (action == null)
			{
				this.verticalActionId = -1;
			}
			action = ReInput.mapping.GetAction(this.submitActionId);
			this.m_SubmitButton = ((action != null) ? action.name : string.Empty);
			if (action == null)
			{
				this.submitActionId = -1;
			}
			action = ReInput.mapping.GetAction(this.cancelActionId);
			this.m_CancelButton = ((action != null) ? action.name : string.Empty);
			if (action == null)
			{
				this.cancelActionId = -1;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00006E96 File Offset: 0x00005096
		private bool GetButton(Player player, int actionId)
		{
			return actionId >= 0 && player.GetButton(actionId);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00006EA5 File Offset: 0x000050A5
		private bool GetButtonDown(Player player, int actionId)
		{
			return actionId >= 0 && player.GetButtonDown(actionId);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00006EB4 File Offset: 0x000050B4
		private bool GetNegativeButton(Player player, int actionId)
		{
			return actionId >= 0 && player.GetNegativeButton(actionId);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00006EC3 File Offset: 0x000050C3
		private bool GetNegativeButtonDown(Player player, int actionId)
		{
			return actionId >= 0 && player.GetNegativeButtonDown(actionId);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00006ED2 File Offset: 0x000050D2
		private float GetAxis(Player player, int actionId)
		{
			if (actionId < 0)
			{
				return 0f;
			}
			return player.GetAxis(actionId);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00006EE5 File Offset: 0x000050E5
		private void CheckEditorRecompile()
		{
			if (!this.recompiling)
			{
				return;
			}
			if (!ReInput.isReady)
			{
				return;
			}
			this.recompiling = false;
			this.InitializeRewired();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00006F05 File Offset: 0x00005105
		private void OnEditorRecompile()
		{
			this.recompiling = true;
			this.ClearRewiredVars();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00006F14 File Offset: 0x00005114
		private void ClearRewiredVars()
		{
			Array.Clear(this.playerIds, 0, this.playerIds.Length);
			base.ClearMouseInputSources();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00006F30 File Offset: 0x00005130
		private bool DidAnyMouseMove()
		{
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				int playerId = this.playerIds[i];
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int mouseInputSourceCount = base.GetMouseInputSourceCount(playerId);
					for (int j = 0; j < mouseInputSourceCount; j++)
					{
						IMouseInputSource mouseInputSource = base.GetMouseInputSource(playerId, j);
						if (mouseInputSource != null && mouseInputSource.screenPositionDelta.sqrMagnitude > 0f)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00006FBC File Offset: 0x000051BC
		private bool GetMouseButtonDownOnAnyMouse(int buttonIndex)
		{
			for (int i = 0; i < this.playerIds.Length; i++)
			{
				int playerId = this.playerIds[i];
				Player player = ReInput.players.GetPlayer(playerId);
				if (player != null && (!this.usePlayingPlayersOnly || player.isPlaying))
				{
					int mouseInputSourceCount = base.GetMouseInputSourceCount(playerId);
					for (int j = 0; j < mouseInputSourceCount; j++)
					{
						IMouseInputSource mouseInputSource = base.GetMouseInputSource(playerId, j);
						if (mouseInputSource != null && mouseInputSource.GetButtonDown(buttonIndex))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00007038 File Offset: 0x00005238
		private void OnRewiredInitialized()
		{
			this.InitializeRewired();
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00007040 File Offset: 0x00005240
		private void OnRewiredShutDown()
		{
			this.ClearRewiredVars();
		}

		// Token: 0x040001C9 RID: 457
		private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";

		// Token: 0x040001CA RID: 458
		private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";

		// Token: 0x040001CB RID: 459
		private const string DEFAULT_ACTION_SUBMIT = "UISubmit";

		// Token: 0x040001CC RID: 460
		private const string DEFAULT_ACTION_CANCEL = "UICancel";

		// Token: 0x040001CD RID: 461
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
		[SerializeField]
		private InputManager_Base rewiredInputManager;

		// Token: 0x040001CE RID: 462
		[SerializeField]
		[Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
		private bool useAllRewiredGamePlayers;

		// Token: 0x040001CF RID: 463
		[SerializeField]
		[Tooltip("Allow the Rewired System Player to control the UI.")]
		private bool useRewiredSystemPlayer;

		// Token: 0x040001D0 RID: 464
		[SerializeField]
		[Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
		private int[] rewiredPlayerIds = new int[1];

		// Token: 0x040001D1 RID: 465
		[SerializeField]
		[Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
		private bool usePlayingPlayersOnly;

		// Token: 0x040001D2 RID: 466
		[SerializeField]
		[Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
		private List<PlayerMouse> playerMice = new List<PlayerMouse>();

		// Token: 0x040001D3 RID: 467
		[SerializeField]
		[Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
		private bool moveOneElementPerAxisPress;

		// Token: 0x040001D4 RID: 468
		[SerializeField]
		[Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
		private bool setActionsById;

		// Token: 0x040001D5 RID: 469
		[SerializeField]
		[Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
		private int horizontalActionId = -1;

		// Token: 0x040001D6 RID: 470
		[SerializeField]
		[Tooltip("Id of the vertical Action for movement (if axis events are used).")]
		private int verticalActionId = -1;

		// Token: 0x040001D7 RID: 471
		[SerializeField]
		[Tooltip("Id of the Action used to submit.")]
		private int submitActionId = -1;

		// Token: 0x040001D8 RID: 472
		[SerializeField]
		[Tooltip("Id of the Action used to cancel.")]
		private int cancelActionId = -1;

		// Token: 0x040001D9 RID: 473
		[SerializeField]
		[Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
		private string m_HorizontalAxis = "UIHorizontal";

		// Token: 0x040001DA RID: 474
		[SerializeField]
		[Tooltip("Name of the vertical axis for movement (if axis events are used).")]
		private string m_VerticalAxis = "UIVertical";

		// Token: 0x040001DB RID: 475
		[SerializeField]
		[Tooltip("Name of the action used to submit.")]
		private string m_SubmitButton = "UISubmit";

		// Token: 0x040001DC RID: 476
		[SerializeField]
		[Tooltip("Name of the action used to cancel.")]
		private string m_CancelButton = "UICancel";

		// Token: 0x040001DD RID: 477
		[SerializeField]
		[Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
		private float m_InputActionsPerSecond = 10f;

		// Token: 0x040001DE RID: 478
		[SerializeField]
		[Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
		private float m_RepeatDelay;

		// Token: 0x040001DF RID: 479
		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements.")]
		private bool m_allowMouseInput = true;

		// Token: 0x040001E0 RID: 480
		[SerializeField]
		[Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
		private bool m_allowMouseInputIfTouchSupported = true;

		// Token: 0x040001E1 RID: 481
		[SerializeField]
		[Tooltip("Allows touch input to be used to select elements.")]
		private bool m_allowTouchInput = true;

		// Token: 0x040001E2 RID: 482
		[SerializeField]
		[Tooltip("Deselects the current selection on mouse/touch click when the pointer is not over a selectable object.")]
		private bool m_deselectIfBackgroundClicked = true;

		// Token: 0x040001E3 RID: 483
		[SerializeField]
		[Tooltip("Deselects the current selection on mouse/touch click before selecting the next object.")]
		private bool m_deselectBeforeSelecting = true;

		// Token: 0x040001E4 RID: 484
		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
		[Tooltip("Forces the module to always be active.")]
		private bool m_ForceModuleActive;

		// Token: 0x040001E5 RID: 485
		[NonSerialized]
		private int[] playerIds;

		// Token: 0x040001E6 RID: 486
		private bool recompiling;

		// Token: 0x040001E7 RID: 487
		[NonSerialized]
		private bool isTouchSupported;

		// Token: 0x040001E8 RID: 488
		[NonSerialized]
		private double m_PrevActionTime;

		// Token: 0x040001E9 RID: 489
		[NonSerialized]
		private Vector2 m_LastMoveVector;

		// Token: 0x040001EA RID: 490
		[NonSerialized]
		private int m_ConsecutiveMoveCount;

		// Token: 0x040001EB RID: 491
		[NonSerialized]
		private bool m_HasFocus = true;

		// Token: 0x02000025 RID: 37
		[Serializable]
		public class PlayerSetting
		{
			// Token: 0x060003C8 RID: 968 RVA: 0x00007C64 File Offset: 0x00005E64
			public PlayerSetting()
			{
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x00007C78 File Offset: 0x00005E78
			private PlayerSetting(RewiredStandaloneInputModule.PlayerSetting other)
			{
				if (other == null)
				{
					throw new ArgumentNullException("other");
				}
				this.playerId = other.playerId;
				this.playerMice = new List<PlayerMouse>();
				if (other.playerMice != null)
				{
					foreach (PlayerMouse item in other.playerMice)
					{
						this.playerMice.Add(item);
					}
				}
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00007D10 File Offset: 0x00005F10
			public RewiredStandaloneInputModule.PlayerSetting Clone()
			{
				return new RewiredStandaloneInputModule.PlayerSetting(this);
			}

			// Token: 0x04000215 RID: 533
			public int playerId;

			// Token: 0x04000216 RID: 534
			public List<PlayerMouse> playerMice = new List<PlayerMouse>();
		}
	}
}
