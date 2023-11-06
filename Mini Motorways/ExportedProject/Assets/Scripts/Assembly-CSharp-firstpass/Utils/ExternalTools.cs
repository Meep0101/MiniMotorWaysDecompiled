using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Internal;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Platforms.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Utils
{
	// Token: 0x02000010 RID: 16
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ExternalTools : IExternalTools
	{
		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00002BFD File Offset: 0x00000DFD
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002C04 File Offset: 0x00000E04
		public static Func<object> getPlatformInitializerDelegate
		{
			get
			{
				return ExternalTools._getPlatformInitializerDelegate;
			}
			set
			{
				ExternalTools._getPlatformInitializerDelegate = value;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002C14 File Offset: 0x00000E14
		public void Destroy()
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00002C16 File Offset: 0x00000E16
		public bool isEditorPaused
		{
			get
			{
				return this._isEditorPaused;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000217 RID: 535 RVA: 0x00002C1E File Offset: 0x00000E1E
		// (remove) Token: 0x06000218 RID: 536 RVA: 0x00002C37 File Offset: 0x00000E37
		public event Action<bool> EditorPausedStateChangedEvent
		{
			add
			{
				this._EditorPausedStateChangedEvent = (Action<bool>)Delegate.Combine(this._EditorPausedStateChangedEvent, value);
			}
			remove
			{
				this._EditorPausedStateChangedEvent = (Action<bool>)Delegate.Remove(this._EditorPausedStateChangedEvent, value);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002C50 File Offset: 0x00000E50
		public object GetPlatformInitializer()
		{
			return Main.GetPlatformInitializer();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002C57 File Offset: 0x00000E57
		public string GetFocusedEditorWindowTitle()
		{
			return string.Empty;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002C5E File Offset: 0x00000E5E
		public bool IsEditorSceneViewFocused()
		{
			return false;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002C61 File Offset: 0x00000E61
		public bool LinuxInput_IsJoystickPreconfigured(string name)
		{
			return false;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600021D RID: 541 RVA: 0x00002C64 File Offset: 0x00000E64
		// (remove) Token: 0x0600021E RID: 542 RVA: 0x00002C9C File Offset: 0x00000E9C
		public event Action<uint, bool> XboxOneInput_OnGamepadStateChange;

		// Token: 0x0600021F RID: 543 RVA: 0x00002CD1 File Offset: 0x00000ED1
		public int XboxOneInput_GetUserIdForGamepad(uint id)
		{
			return 0;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
		{
			return 0UL;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
		{
			return false;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002CDB File Offset: 0x00000EDB
		public string XboxOneInput_GetControllerType(ulong xboxControllerId)
		{
			return string.Empty;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002CE2 File Offset: 0x00000EE2
		public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
		{
			return 0U;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public void XboxOne_Gamepad_UpdatePlugin()
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002CE7 File Offset: 0x00000EE7
		public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
		{
			return false;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002CEA File Offset: 0x00000EEA
		public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002CEC File Offset: 0x00000EEC
		public Vector3 PS4Input_GetLastAcceleration(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002CF3 File Offset: 0x00000EF3
		public Vector3 PS4Input_GetLastGyro(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002CFA File Offset: 0x00000EFA
		public Vector4 PS4Input_GetLastOrientation(int id)
		{
			return Vector4.zero;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002D01 File Offset: 0x00000F01
		public void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id)
		{
			touchNum = 0;
			touch0x = 0;
			touch0y = 0;
			touch0id = 0;
			touch1x = 0;
			touch1y = 0;
			touch1id = 0;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002D1D File Offset: 0x00000F1D
		public void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType)
		{
			touchpixelDensity = 0f;
			touchResolutionX = 0;
			touchResolutionY = 0;
			analogDeadZoneLeft = 0;
			analogDeadZoneright = 0;
			connectionType = 0;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002D39 File Offset: 0x00000F39
		public void PS4Input_PadSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002D3B File Offset: 0x00000F3B
		public void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002D3D File Offset: 0x00000F3D
		public void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002D3F File Offset: 0x00000F3F
		public void PS4Input_PadSetLightBar(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002D41 File Offset: 0x00000F41
		public void PS4Input_PadResetLightBar(int id)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002D43 File Offset: 0x00000F43
		public void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002D45 File Offset: 0x00000F45
		public void PS4Input_PadResetOrientation(int id)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002D47 File Offset: 0x00000F47
		public bool PS4Input_PadIsConnected(int id)
		{
			return false;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002D4A File Offset: 0x00000F4A
		public void PS4Input_GetUsersDetails(int slot, object loggedInUser)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002D4C File Offset: 0x00000F4C
		public int PS4Input_GetDeviceClassForHandle(int handle)
		{
			return -1;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002D4F File Offset: 0x00000F4F
		public string PS4Input_GetDeviceClassString(int intValue)
		{
			return null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002D52 File Offset: 0x00000F52
		public int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002D55 File Offset: 0x00000F55
		public void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002D57 File Offset: 0x00000F57
		public Vector3 PS4Input_SpecialGetLastAcceleration(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002D5E File Offset: 0x00000F5E
		public Vector3 PS4Input_SpecialGetLastGyro(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002D65 File Offset: 0x00000F65
		public Vector4 PS4Input_SpecialGetLastOrientation(int id)
		{
			return Vector4.zero;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002D6C File Offset: 0x00000F6C
		public int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002D6F File Offset: 0x00000F6F
		public int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002D72 File Offset: 0x00000F72
		public bool PS4Input_SpecialIsConnected(int id)
		{
			return false;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002D75 File Offset: 0x00000F75
		public void PS4Input_SpecialResetLightSphere(int id)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002D77 File Offset: 0x00000F77
		public void PS4Input_SpecialResetOrientation(int id)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002D79 File Offset: 0x00000F79
		public void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002D7B File Offset: 0x00000F7B
		public void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002D7D File Offset: 0x00000F7D
		public void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002D7F File Offset: 0x00000F7F
		public void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002D81 File Offset: 0x00000F81
		public void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002D83 File Offset: 0x00000F83
		public Vector3 PS4Input_AimGetLastAcceleration(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002D8A File Offset: 0x00000F8A
		public Vector3 PS4Input_AimGetLastGyro(int id)
		{
			return Vector3.zero;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002D91 File Offset: 0x00000F91
		public Vector4 PS4Input_AimGetLastOrientation(int id)
		{
			return Vector4.zero;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002D98 File Offset: 0x00000F98
		public int PS4Input_AimGetUsersHandles(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002D9B File Offset: 0x00000F9B
		public int PS4Input_AimGetUsersHandles2(int maxNumberControllers, int[] handles)
		{
			return 0;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002D9E File Offset: 0x00000F9E
		public bool PS4Input_AimIsConnected(int id)
		{
			return false;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002DA1 File Offset: 0x00000FA1
		public void PS4Input_AimResetLightSphere(int id)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002DA3 File Offset: 0x00000FA3
		public void PS4Input_AimResetOrientation(int id)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002DA5 File Offset: 0x00000FA5
		public void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002DA7 File Offset: 0x00000FA7
		public void PS4Input_AimSetLightSphere(int id, int red, int green, int blue)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002DA9 File Offset: 0x00000FA9
		public void PS4Input_AimSetMotionSensorState(int id, bool bEnable)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002DAB File Offset: 0x00000FAB
		public void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002DAD File Offset: 0x00000FAD
		public void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002DAF File Offset: 0x00000FAF
		public Vector3 PS4Input_GetLastMoveAcceleration(int id, int index)
		{
			return Vector3.zero;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002DB6 File Offset: 0x00000FB6
		public Vector3 PS4Input_GetLastMoveGyro(int id, int index)
		{
			return Vector3.zero;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002DBD File Offset: 0x00000FBD
		public int PS4Input_MoveGetButtons(int id, int index)
		{
			return 0;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public int PS4Input_MoveGetAnalogButton(int id, int index)
		{
			return 0;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002DC3 File Offset: 0x00000FC3
		public bool PS4Input_MoveIsConnected(int id, int index)
		{
			return false;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002DC6 File Offset: 0x00000FC6
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles)
		{
			return 0;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002DC9 File Offset: 0x00000FC9
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles)
		{
			return 0;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002DCC File Offset: 0x00000FCC
		public int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers)
		{
			return 0;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002DCF File Offset: 0x00000FCF
		public IntPtr PS4Input_MoveGetControllerInputForTracking()
		{
			return IntPtr.Zero;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002DD6 File Offset: 0x00000FD6
		public int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue)
		{
			return 0;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002DD9 File Offset: 0x00000FD9
		public int PS4Input_MoveSetVibration(int id, int index, int motor)
		{
			return 0;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002DDC File Offset: 0x00000FDC
		public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
		{
			vids = new List<int>();
			pids = new List<int>();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002DEC File Offset: 0x00000FEC
		public int GetAndroidAPILevel()
		{
			return -1;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002DEF File Offset: 0x00000FEF
		public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
		{
			return !(graphic as Graphic == null) && (graphic as Graphic).raycastTarget;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002E0C File Offset: 0x0000100C
		public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
		{
			if (graphic as Graphic == null)
			{
				return;
			}
			(graphic as Graphic).raycastTarget = value;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00002E29 File Offset: 0x00001029
		public bool UnityInput_IsTouchPressureSupported
		{
			get
			{
				return Input.touchPressureSupported;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002E30 File Offset: 0x00001030
		public float UnityInput_GetTouchPressure(ref Touch touch)
		{
			return touch.pressure;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002E38 File Offset: 0x00001038
		public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
		{
			return touch.maximumPossiblePressure;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002E40 File Offset: 0x00001040
		public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
		{
			return ControllerTemplateFactory.Create(typeGuid, payload);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002E49 File Offset: 0x00001049
		public Type[] GetControllerTemplateTypes()
		{
			return ControllerTemplateFactory.templateTypes;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002E50 File Offset: 0x00001050
		public Type[] GetControllerTemplateInterfaceTypes()
		{
			return ControllerTemplateFactory.templateInterfaceTypes;
		}

		// Token: 0x04000199 RID: 409
		private static Func<object> _getPlatformInitializerDelegate;

		// Token: 0x0400019A RID: 410
		private bool _isEditorPaused;

		// Token: 0x0400019B RID: 411
		private Action<bool> _EditorPausedStateChangedEvent;
	}
}
