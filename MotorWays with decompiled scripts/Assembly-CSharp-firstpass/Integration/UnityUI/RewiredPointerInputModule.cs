using System;
using System.Collections.Generic;
using System.Text;
using Rewired.UI;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000015 RID: 21
	public abstract class RewiredPointerInputModule : BaseInputModule
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00004A5C File Offset: 0x00002C5C
		private RewiredPointerInputModule.UnityInputSource defaultInputSource
		{
			get
			{
				if (this.__m_DefaultInputSource == null)
				{
					return this.__m_DefaultInputSource = new RewiredPointerInputModule.UnityInputSource();
				}
				return this.__m_DefaultInputSource;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00004A86 File Offset: 0x00002C86
		private IMouseInputSource defaultMouseInputSource
		{
			get
			{
				return this.defaultInputSource;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00004A8E File Offset: 0x00002C8E
		protected ITouchInputSource defaultTouchInputSource
		{
			get
			{
				return this.defaultInputSource;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00004A96 File Offset: 0x00002C96
		protected bool IsDefaultMouse(IMouseInputSource mouse)
		{
			return this.defaultMouseInputSource == mouse;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00004AA4 File Offset: 0x00002CA4
		public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex)
		{
			if (mouseIndex < 0)
			{
				throw new ArgumentOutOfRangeException("mouseIndex");
			}
			if (this.m_MouseInputSourcesList.Count == 0 && this.IsDefaultPlayer(playerId))
			{
				return this.defaultMouseInputSource;
			}
			int count = this.m_MouseInputSourcesList.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				IMouseInputSource mouseInputSource = this.m_MouseInputSourcesList[i];
				if (!UnityTools.IsNullOrDestroyed<IMouseInputSource>(mouseInputSource) && mouseInputSource.playerId == playerId)
				{
					if (mouseIndex == num)
					{
						return mouseInputSource;
					}
					num++;
				}
			}
			return null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00004B20 File Offset: 0x00002D20
		public void RemoveMouseInputSource(IMouseInputSource source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			this.m_MouseInputSourcesList.Remove(source);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00004B3D File Offset: 0x00002D3D
		public void AddMouseInputSource(IMouseInputSource source)
		{
			if (UnityTools.IsNullOrDestroyed<IMouseInputSource>(source))
			{
				throw new ArgumentNullException("source");
			}
			this.m_MouseInputSourcesList.Add(source);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00004B60 File Offset: 0x00002D60
		public int GetMouseInputSourceCount(int playerId)
		{
			if (this.m_MouseInputSourcesList.Count == 0 && this.IsDefaultPlayer(playerId))
			{
				return 1;
			}
			int count = this.m_MouseInputSourcesList.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				IMouseInputSource mouseInputSource = this.m_MouseInputSourcesList[i];
				if (!UnityTools.IsNullOrDestroyed<IMouseInputSource>(mouseInputSource) && mouseInputSource.playerId == playerId)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex)
		{
			if (!UnityTools.IsNullOrDestroyed<ITouchInputSource>(this.m_UserDefaultTouchInputSource))
			{
				return this.m_UserDefaultTouchInputSource;
			}
			return this.defaultTouchInputSource;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00004BDE File Offset: 0x00002DDE
		public void RemoveTouchInputSource(ITouchInputSource source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (this.m_UserDefaultTouchInputSource == source)
			{
				this.m_UserDefaultTouchInputSource = null;
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00004BFE File Offset: 0x00002DFE
		public void AddTouchInputSource(ITouchInputSource source)
		{
			if (UnityTools.IsNullOrDestroyed<ITouchInputSource>(source))
			{
				throw new ArgumentNullException("source");
			}
			this.m_UserDefaultTouchInputSource = source;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00004C1A File Offset: 0x00002E1A
		public int GetTouchInputSourceCount(int playerId)
		{
			if (!this.IsDefaultPlayer(playerId))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00004C28 File Offset: 0x00002E28
		protected void ClearMouseInputSources()
		{
			this.m_MouseInputSourcesList.Clear();
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00004C38 File Offset: 0x00002E38
		protected virtual bool isMouseSupported
		{
			get
			{
				int count = this.m_MouseInputSourcesList.Count;
				if (count == 0)
				{
					return this.defaultMouseInputSource.enabled;
				}
				for (int i = 0; i < count; i++)
				{
					if (this.m_MouseInputSourcesList[i].enabled)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060002E1 RID: 737
		protected abstract bool IsDefaultPlayer(int playerId);

		// Token: 0x060002E2 RID: 738 RVA: 0x00004C84 File Offset: 0x00002E84
		protected bool GetPointerData(int playerId, int pointerIndex, int pointerTypeId, out PlayerPointerEventData data, bool create, PointerEventType pointerEventType)
		{
			Dictionary<int, PlayerPointerEventData>[] array;
			if (!this.m_PlayerPointerData.TryGetValue(playerId, out array))
			{
				array = new Dictionary<int, PlayerPointerEventData>[pointerIndex + 1];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = new Dictionary<int, PlayerPointerEventData>();
				}
				this.m_PlayerPointerData.Add(playerId, array);
			}
			if (pointerIndex >= array.Length)
			{
				Dictionary<int, PlayerPointerEventData>[] array2 = new Dictionary<int, PlayerPointerEventData>[pointerIndex + 1];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = array[j];
				}
				array2[pointerIndex] = new Dictionary<int, PlayerPointerEventData>();
				array = array2;
				this.m_PlayerPointerData[playerId] = array;
			}
			Dictionary<int, PlayerPointerEventData> dictionary = array[pointerIndex];
			if (dictionary.TryGetValue(pointerTypeId, out data))
			{
				data.mouseSource = ((pointerEventType == PointerEventType.Mouse) ? this.GetMouseInputSource(playerId, pointerIndex) : null);
				data.touchSource = ((pointerEventType == PointerEventType.Touch) ? this.GetTouchInputSource(playerId, pointerIndex) : null);
				return false;
			}
			if (!create)
			{
				return false;
			}
			data = this.CreatePointerEventData(playerId, pointerIndex, pointerTypeId, pointerEventType);
			dictionary.Add(pointerTypeId, data);
			return true;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00004D6C File Offset: 0x00002F6C
		private PlayerPointerEventData CreatePointerEventData(int playerId, int pointerIndex, int pointerTypeId, PointerEventType pointerEventType)
		{
			PlayerPointerEventData playerPointerEventData = new PlayerPointerEventData(base.eventSystem)
			{
				playerId = playerId,
				inputSourceIndex = pointerIndex,
				pointerId = pointerTypeId,
				sourceType = pointerEventType
			};
			if (pointerEventType == PointerEventType.Mouse)
			{
				playerPointerEventData.mouseSource = this.GetMouseInputSource(playerId, pointerIndex);
			}
			else if (pointerEventType == PointerEventType.Touch)
			{
				playerPointerEventData.touchSource = this.GetTouchInputSource(playerId, pointerIndex);
			}
			if (pointerTypeId == -1)
			{
				playerPointerEventData.buttonIndex = 0;
			}
			else if (pointerTypeId == -2)
			{
				playerPointerEventData.buttonIndex = 1;
			}
			else if (pointerTypeId == -3)
			{
				playerPointerEventData.buttonIndex = 2;
			}
			else if (pointerTypeId >= -2147483520 && pointerTypeId <= -2147483392)
			{
				playerPointerEventData.buttonIndex = pointerTypeId - -2147483520;
			}
			return playerPointerEventData;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00004E10 File Offset: 0x00003010
		protected void RemovePointerData(PlayerPointerEventData data)
		{
			Dictionary<int, PlayerPointerEventData>[] array;
			if (this.m_PlayerPointerData.TryGetValue(data.playerId, out array) && data.inputSourceIndex < array.Length)
			{
				array[data.inputSourceIndex].Remove(data.pointerId);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00004E54 File Offset: 0x00003054
		protected PlayerPointerEventData GetTouchPointerEventData(int playerId, int touchDeviceIndex, Touch input, out bool pressed, out bool released)
		{
			PlayerPointerEventData playerPointerEventData;
			bool pointerData = this.GetPointerData(playerId, touchDeviceIndex, input.fingerId, out playerPointerEventData, true, PointerEventType.Touch);
			playerPointerEventData.Reset();
			pressed = (pointerData || input.phase == TouchPhase.Began);
			released = (input.phase == TouchPhase.Canceled || input.phase == TouchPhase.Ended);
			if (pointerData)
			{
				playerPointerEventData.position = input.position;
			}
			if (pressed)
			{
				playerPointerEventData.delta = Vector2.zero;
			}
			else
			{
				playerPointerEventData.delta = input.position - playerPointerEventData.position;
			}
			playerPointerEventData.position = input.position;
			playerPointerEventData.button = PointerEventData.InputButton.Left;
			base.eventSystem.RaycastAll(playerPointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			playerPointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			return playerPointerEventData;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00004F28 File Offset: 0x00003128
		protected virtual RewiredPointerInputModule.MouseState GetMousePointerEventData(int playerId, int mouseIndex)
		{
			IMouseInputSource mouseInputSource = this.GetMouseInputSource(playerId, mouseIndex);
			if (mouseInputSource == null)
			{
				return null;
			}
			PlayerPointerEventData playerPointerEventData;
			bool pointerData = this.GetPointerData(playerId, mouseIndex, -1, out playerPointerEventData, true, PointerEventType.Mouse);
			playerPointerEventData.Reset();
			if (pointerData)
			{
				playerPointerEventData.position = mouseInputSource.screenPosition;
			}
			Vector2 screenPosition = mouseInputSource.screenPosition;
			if (mouseInputSource.locked || !mouseInputSource.enabled)
			{
				playerPointerEventData.position = new Vector2(-1f, -1f);
				playerPointerEventData.delta = Vector2.zero;
			}
			else
			{
				playerPointerEventData.delta = screenPosition - playerPointerEventData.position;
				playerPointerEventData.position = screenPosition;
			}
			playerPointerEventData.scrollDelta = mouseInputSource.wheelDelta;
			playerPointerEventData.button = PointerEventData.InputButton.Left;
			base.eventSystem.RaycastAll(playerPointerEventData, this.m_RaycastResultCache);
			RaycastResult pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(this.m_RaycastResultCache);
			playerPointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			this.m_RaycastResultCache.Clear();
			PlayerPointerEventData playerPointerEventData2;
			this.GetPointerData(playerId, mouseIndex, -2, out playerPointerEventData2, true, PointerEventType.Mouse);
			this.CopyFromTo(playerPointerEventData, playerPointerEventData2);
			playerPointerEventData2.button = PointerEventData.InputButton.Right;
			PlayerPointerEventData playerPointerEventData3;
			this.GetPointerData(playerId, mouseIndex, -3, out playerPointerEventData3, true, PointerEventType.Mouse);
			this.CopyFromTo(playerPointerEventData, playerPointerEventData3);
			playerPointerEventData3.button = PointerEventData.InputButton.Middle;
			for (int i = 3; i < mouseInputSource.buttonCount; i++)
			{
				PlayerPointerEventData playerPointerEventData4;
				this.GetPointerData(playerId, mouseIndex, -2147483520 + i, out playerPointerEventData4, true, PointerEventType.Mouse);
				this.CopyFromTo(playerPointerEventData, playerPointerEventData4);
				playerPointerEventData4.button = (PointerEventData.InputButton)(-1);
			}
			this.m_MouseState.SetButtonState(0, this.StateForMouseButton(playerId, mouseIndex, 0), playerPointerEventData);
			this.m_MouseState.SetButtonState(1, this.StateForMouseButton(playerId, mouseIndex, 1), playerPointerEventData2);
			this.m_MouseState.SetButtonState(2, this.StateForMouseButton(playerId, mouseIndex, 2), playerPointerEventData3);
			for (int j = 3; j < mouseInputSource.buttonCount; j++)
			{
				PlayerPointerEventData data;
				this.GetPointerData(playerId, mouseIndex, -2147483520 + j, out data, false, PointerEventType.Mouse);
				this.m_MouseState.SetButtonState(j, this.StateForMouseButton(playerId, mouseIndex, j), data);
			}
			return this.m_MouseState;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00005104 File Offset: 0x00003304
		protected PlayerPointerEventData GetLastPointerEventData(int playerId, int pointerIndex, int pointerTypeId, bool ignorePointerTypeId, PointerEventType pointerEventType)
		{
			if (!ignorePointerTypeId)
			{
				PlayerPointerEventData result;
				this.GetPointerData(playerId, pointerIndex, pointerTypeId, out result, false, pointerEventType);
				return result;
			}
			Dictionary<int, PlayerPointerEventData>[] array;
			if (!this.m_PlayerPointerData.TryGetValue(playerId, out array))
			{
				return null;
			}
			if (pointerIndex >= array.Length)
			{
				return null;
			}
			using (Dictionary<int, PlayerPointerEventData>.Enumerator enumerator = array[pointerIndex].GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					KeyValuePair<int, PlayerPointerEventData> keyValuePair = enumerator.Current;
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000518C File Offset: 0x0000338C
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			return !useDragThreshold || (pressPos - currentPos).sqrMagnitude >= threshold * threshold;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000051B8 File Offset: 0x000033B8
		protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
		{
			GameObject newEnterTarget;
			if (pointerEvent.sourceType == PointerEventType.Mouse)
			{
				IMouseInputSource mouseInputSource = this.GetMouseInputSource(pointerEvent.playerId, pointerEvent.inputSourceIndex);
				if (mouseInputSource != null)
				{
					newEnterTarget = ((!mouseInputSource.enabled || mouseInputSource.locked) ? null : pointerEvent.pointerCurrentRaycast.gameObject);
				}
				else
				{
					newEnterTarget = null;
				}
			}
			else
			{
				if (pointerEvent.sourceType != PointerEventType.Touch)
				{
					throw new NotImplementedException();
				}
				newEnterTarget = pointerEvent.pointerCurrentRaycast.gameObject;
			}
			base.HandlePointerExitAndEnter(pointerEvent, newEnterTarget);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00005234 File Offset: 0x00003434
		protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
		{
			if (!pointerEvent.IsPointerMoving() || pointerEvent.pointerDrag == null)
			{
				return;
			}
			if (pointerEvent.sourceType == PointerEventType.Mouse)
			{
				IMouseInputSource mouseInputSource = this.GetMouseInputSource(pointerEvent.playerId, pointerEvent.inputSourceIndex);
				if (mouseInputSource == null || mouseInputSource.locked || !mouseInputSource.enabled)
				{
					return;
				}
			}
			if (!pointerEvent.dragging && RewiredPointerInputModule.ShouldStartDrag(pointerEvent.pressPosition, pointerEvent.position, (float)base.eventSystem.pixelDragThreshold, pointerEvent.useDragThreshold))
			{
				ExecuteEvents.Execute<IBeginDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.beginDragHandler);
				pointerEvent.dragging = true;
			}
			if (pointerEvent.dragging)
			{
				if (pointerEvent.pointerPress != pointerEvent.pointerDrag)
				{
					ExecuteEvents.Execute<IPointerUpHandler>(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerUpHandler);
					pointerEvent.eligibleForClick = false;
					pointerEvent.pointerPress = null;
					pointerEvent.rawPointerPress = null;
				}
				ExecuteEvents.Execute<IDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.dragHandler);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00005324 File Offset: 0x00003524
		public override bool IsPointerOverGameObject(int pointerTypeId)
		{
			foreach (KeyValuePair<int, Dictionary<int, PlayerPointerEventData>[]> keyValuePair in this.m_PlayerPointerData)
			{
				Dictionary<int, PlayerPointerEventData>[] value = keyValuePair.Value;
				for (int i = 0; i < value.Length; i++)
				{
					PlayerPointerEventData playerPointerEventData;
					if (value[i].TryGetValue(pointerTypeId, out playerPointerEventData) && playerPointerEventData.pointerEnter != null)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000053AC File Offset: 0x000035AC
		protected void ClearSelection()
		{
			BaseEventData baseEventData = this.GetBaseEventData();
			foreach (KeyValuePair<int, Dictionary<int, PlayerPointerEventData>[]> keyValuePair in this.m_PlayerPointerData)
			{
				Dictionary<int, PlayerPointerEventData>[] value = keyValuePair.Value;
				for (int i = 0; i < value.Length; i++)
				{
					foreach (KeyValuePair<int, PlayerPointerEventData> keyValuePair2 in value[i])
					{
						base.HandlePointerExitAndEnter(keyValuePair2.Value, null);
					}
					value[i].Clear();
				}
			}
			base.eventSystem.SetSelectedGameObject(null, baseEventData);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00005478 File Offset: 0x00003678
		public override string ToString()
		{
			string str = "<b>Pointer Input Module of type: </b>";
			Type type = base.GetType();
			StringBuilder stringBuilder = new StringBuilder(str + ((type != null) ? type.ToString() : null));
			stringBuilder.AppendLine();
			foreach (KeyValuePair<int, Dictionary<int, PlayerPointerEventData>[]> keyValuePair in this.m_PlayerPointerData)
			{
				stringBuilder.AppendLine("<B>Player Id:</b> " + keyValuePair.Key.ToString());
				Dictionary<int, PlayerPointerEventData>[] value = keyValuePair.Value;
				for (int i = 0; i < value.Length; i++)
				{
					stringBuilder.AppendLine("<B>Pointer Index:</b> " + i.ToString());
					foreach (KeyValuePair<int, PlayerPointerEventData> keyValuePair2 in value[i])
					{
						stringBuilder.AppendLine("<B>Button Id:</b> " + keyValuePair2.Key.ToString());
						stringBuilder.AppendLine(keyValuePair2.Value.ToString());
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000055C4 File Offset: 0x000037C4
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			if (ExecuteEvents.GetEventHandler<ISelectHandler>(currentOverGo) != base.eventSystem.currentSelectedGameObject)
			{
				base.eventSystem.SetSelectedGameObject(null, pointerEvent);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000055EB File Offset: 0x000037EB
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			to.position = from.position;
			to.delta = from.delta;
			to.scrollDelta = from.scrollDelta;
			to.pointerCurrentRaycast = from.pointerCurrentRaycast;
			to.pointerEnter = from.pointerEnter;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000562C File Offset: 0x0000382C
		protected PointerEventData.FramePressState StateForMouseButton(int playerId, int mouseIndex, int buttonId)
		{
			IMouseInputSource mouseInputSource = this.GetMouseInputSource(playerId, mouseIndex);
			if (mouseInputSource == null)
			{
				return PointerEventData.FramePressState.NotChanged;
			}
			bool buttonDown = mouseInputSource.GetButtonDown(buttonId);
			bool buttonUp = mouseInputSource.GetButtonUp(buttonId);
			if (buttonDown && buttonUp)
			{
				return PointerEventData.FramePressState.PressedAndReleased;
			}
			if (buttonDown)
			{
				return PointerEventData.FramePressState.Pressed;
			}
			if (buttonUp)
			{
				return PointerEventData.FramePressState.Released;
			}
			return PointerEventData.FramePressState.NotChanged;
		}

		// Token: 0x040001BA RID: 442
		public const int kMouseLeftId = -1;

		// Token: 0x040001BB RID: 443
		public const int kMouseRightId = -2;

		// Token: 0x040001BC RID: 444
		public const int kMouseMiddleId = -3;

		// Token: 0x040001BD RID: 445
		public const int kFakeTouchesId = -4;

		// Token: 0x040001BE RID: 446
		private const int customButtonsStartingId = -2147483520;

		// Token: 0x040001BF RID: 447
		private const int customButtonsMaxCount = 128;

		// Token: 0x040001C0 RID: 448
		private const int customButtonsLastId = -2147483392;

		// Token: 0x040001C1 RID: 449
		private readonly List<IMouseInputSource> m_MouseInputSourcesList = new List<IMouseInputSource>();

		// Token: 0x040001C2 RID: 450
		private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData = new Dictionary<int, Dictionary<int, PlayerPointerEventData>[]>();

		// Token: 0x040001C3 RID: 451
		private ITouchInputSource m_UserDefaultTouchInputSource;

		// Token: 0x040001C4 RID: 452
		private RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource;

		// Token: 0x040001C5 RID: 453
		private readonly RewiredPointerInputModule.MouseState m_MouseState = new RewiredPointerInputModule.MouseState();

		// Token: 0x02000021 RID: 33
		protected class MouseState
		{
			// Token: 0x060003AB RID: 939 RVA: 0x000079E0 File Offset: 0x00005BE0
			public bool AnyPressesThisFrame()
			{
				for (int i = 0; i < this.m_TrackedButtons.Count; i++)
				{
					if (this.m_TrackedButtons[i].eventData.PressedThisFrame())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x060003AC RID: 940 RVA: 0x00007A20 File Offset: 0x00005C20
			public bool AnyReleasesThisFrame()
			{
				for (int i = 0; i < this.m_TrackedButtons.Count; i++)
				{
					if (this.m_TrackedButtons[i].eventData.ReleasedThisFrame())
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x060003AD RID: 941 RVA: 0x00007A60 File Offset: 0x00005C60
			public RewiredPointerInputModule.ButtonState GetButtonState(int button)
			{
				RewiredPointerInputModule.ButtonState buttonState = null;
				for (int i = 0; i < this.m_TrackedButtons.Count; i++)
				{
					if (this.m_TrackedButtons[i].button == button)
					{
						buttonState = this.m_TrackedButtons[i];
						break;
					}
				}
				if (buttonState == null)
				{
					buttonState = new RewiredPointerInputModule.ButtonState
					{
						button = button,
						eventData = new RewiredPointerInputModule.MouseButtonEventData()
					};
					this.m_TrackedButtons.Add(buttonState);
				}
				return buttonState;
			}

			// Token: 0x060003AE RID: 942 RVA: 0x00007AD0 File Offset: 0x00005CD0
			public void SetButtonState(int button, PointerEventData.FramePressState stateForMouseButton, PlayerPointerEventData data)
			{
				RewiredPointerInputModule.ButtonState buttonState = this.GetButtonState(button);
				buttonState.eventData.buttonState = stateForMouseButton;
				buttonState.eventData.buttonData = data;
			}

			// Token: 0x0400020D RID: 525
			private List<RewiredPointerInputModule.ButtonState> m_TrackedButtons = new List<RewiredPointerInputModule.ButtonState>();
		}

		// Token: 0x02000022 RID: 34
		public class MouseButtonEventData
		{
			// Token: 0x060003B0 RID: 944 RVA: 0x00007B03 File Offset: 0x00005D03
			public bool PressedThisFrame()
			{
				return this.buttonState == PointerEventData.FramePressState.Pressed || this.buttonState == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x00007B18 File Offset: 0x00005D18
			public bool ReleasedThisFrame()
			{
				return this.buttonState == PointerEventData.FramePressState.Released || this.buttonState == PointerEventData.FramePressState.PressedAndReleased;
			}

			// Token: 0x0400020E RID: 526
			public PointerEventData.FramePressState buttonState;

			// Token: 0x0400020F RID: 527
			public PlayerPointerEventData buttonData;
		}

		// Token: 0x02000023 RID: 35
		protected class ButtonState
		{
			// Token: 0x17000249 RID: 585
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x00007B36 File Offset: 0x00005D36
			// (set) Token: 0x060003B4 RID: 948 RVA: 0x00007B3E File Offset: 0x00005D3E
			public RewiredPointerInputModule.MouseButtonEventData eventData
			{
				get
				{
					return this.m_EventData;
				}
				set
				{
					this.m_EventData = value;
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x00007B47 File Offset: 0x00005D47
			// (set) Token: 0x060003B6 RID: 950 RVA: 0x00007B4F File Offset: 0x00005D4F
			public int button
			{
				get
				{
					return this.m_Button;
				}
				set
				{
					this.m_Button = value;
				}
			}

			// Token: 0x04000210 RID: 528
			private int m_Button;

			// Token: 0x04000211 RID: 529
			private RewiredPointerInputModule.MouseButtonEventData m_EventData;
		}

		// Token: 0x02000024 RID: 36
		private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
		{
			// Token: 0x1700024B RID: 587
			// (get) Token: 0x060003B8 RID: 952 RVA: 0x00007B60 File Offset: 0x00005D60
			int IMouseInputSource.playerId
			{
				get
				{
					this.TryUpdate();
					return 0;
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x00007B69 File Offset: 0x00005D69
			int ITouchInputSource.playerId
			{
				get
				{
					this.TryUpdate();
					return 0;
				}
			}

			// Token: 0x1700024D RID: 589
			// (get) Token: 0x060003BA RID: 954 RVA: 0x00007B72 File Offset: 0x00005D72
			bool IMouseInputSource.enabled
			{
				get
				{
					this.TryUpdate();
					return true;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x060003BB RID: 955 RVA: 0x00007B7B File Offset: 0x00005D7B
			bool IMouseInputSource.locked
			{
				get
				{
					this.TryUpdate();
					return Cursor.lockState == CursorLockMode.Locked;
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x060003BC RID: 956 RVA: 0x00007B8B File Offset: 0x00005D8B
			int IMouseInputSource.buttonCount
			{
				get
				{
					this.TryUpdate();
					return 3;
				}
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00007B94 File Offset: 0x00005D94
			bool IMouseInputSource.GetButtonDown(int button)
			{
				this.TryUpdate();
				return Input.GetMouseButtonDown(button);
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00007BA2 File Offset: 0x00005DA2
			bool IMouseInputSource.GetButtonUp(int button)
			{
				this.TryUpdate();
				return Input.GetMouseButtonUp(button);
			}

			// Token: 0x060003BF RID: 959 RVA: 0x00007BB0 File Offset: 0x00005DB0
			bool IMouseInputSource.GetButton(int button)
			{
				this.TryUpdate();
				return Input.GetMouseButton(button);
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x00007BBE File Offset: 0x00005DBE
			Vector2 IMouseInputSource.screenPosition
			{
				get
				{
					this.TryUpdate();
					return Input.mousePosition;
				}
			}

			// Token: 0x17000251 RID: 593
			// (get) Token: 0x060003C1 RID: 961 RVA: 0x00007BD0 File Offset: 0x00005DD0
			Vector2 IMouseInputSource.screenPositionDelta
			{
				get
				{
					this.TryUpdate();
					return this.m_MousePosition - this.m_MousePositionPrev;
				}
			}

			// Token: 0x17000252 RID: 594
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x00007BE9 File Offset: 0x00005DE9
			Vector2 IMouseInputSource.wheelDelta
			{
				get
				{
					this.TryUpdate();
					return Input.mouseScrollDelta;
				}
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x00007BF6 File Offset: 0x00005DF6
			bool ITouchInputSource.touchSupported
			{
				get
				{
					this.TryUpdate();
					return Input.touchSupported;
				}
			}

			// Token: 0x17000254 RID: 596
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x00007C03 File Offset: 0x00005E03
			int ITouchInputSource.touchCount
			{
				get
				{
					this.TryUpdate();
					return Input.touchCount;
				}
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x00007C10 File Offset: 0x00005E10
			Touch ITouchInputSource.GetTouch(int index)
			{
				this.TryUpdate();
				return Input.GetTouch(index);
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00007C1E File Offset: 0x00005E1E
			private void TryUpdate()
			{
				if (Time.frameCount == this.m_LastUpdatedFrame)
				{
					return;
				}
				this.m_LastUpdatedFrame = Time.frameCount;
				this.m_MousePositionPrev = this.m_MousePosition;
				this.m_MousePosition = Input.mousePosition;
			}

			// Token: 0x04000212 RID: 530
			private Vector2 m_MousePosition;

			// Token: 0x04000213 RID: 531
			private Vector2 m_MousePositionPrev;

			// Token: 0x04000214 RID: 532
			private int m_LastUpdatedFrame = -1;
		}
	}
}
