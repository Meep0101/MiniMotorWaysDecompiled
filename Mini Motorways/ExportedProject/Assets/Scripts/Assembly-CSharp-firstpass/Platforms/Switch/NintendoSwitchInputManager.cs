using System;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.Switch
{
	// Token: 0x0200000F RID: 15
	[AddComponentMenu("Rewired/Nintendo Switch Input Manager")]
	[RequireComponent(typeof(InputManager))]
	public sealed class NintendoSwitchInputManager : MonoBehaviour, IExternalInputManager
	{
		// Token: 0x0600020F RID: 527 RVA: 0x00002BE5 File Offset: 0x00000DE5
		object IExternalInputManager.Initialize(Platform platform, object configVars)
		{
			return null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002BE8 File Offset: 0x00000DE8
		void IExternalInputManager.Deinitialize()
		{
		}

		// Token: 0x04000198 RID: 408
		[SerializeField]
		private NintendoSwitchInputManager.UserData _userData = new NintendoSwitchInputManager.UserData();

		// Token: 0x02000018 RID: 24
		[Serializable]
		private class UserData : IKeyedData<int>
		{
			// Token: 0x1700022E RID: 558
			// (get) Token: 0x0600034D RID: 845 RVA: 0x00007048 File Offset: 0x00005248
			// (set) Token: 0x0600034E RID: 846 RVA: 0x00007050 File Offset: 0x00005250
			public int allowedNpadStyles
			{
				get
				{
					return this._allowedNpadStyles;
				}
				set
				{
					this._allowedNpadStyles = value;
				}
			}

			// Token: 0x1700022F RID: 559
			// (get) Token: 0x0600034F RID: 847 RVA: 0x00007059 File Offset: 0x00005259
			// (set) Token: 0x06000350 RID: 848 RVA: 0x00007061 File Offset: 0x00005261
			public int joyConGripStyle
			{
				get
				{
					return this._joyConGripStyle;
				}
				set
				{
					this._joyConGripStyle = value;
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06000351 RID: 849 RVA: 0x0000706A File Offset: 0x0000526A
			// (set) Token: 0x06000352 RID: 850 RVA: 0x00007072 File Offset: 0x00005272
			public bool adjustIMUsForGripStyle
			{
				get
				{
					return this._adjustIMUsForGripStyle;
				}
				set
				{
					this._adjustIMUsForGripStyle = value;
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x06000353 RID: 851 RVA: 0x0000707B File Offset: 0x0000527B
			// (set) Token: 0x06000354 RID: 852 RVA: 0x00007083 File Offset: 0x00005283
			public int handheldActivationMode
			{
				get
				{
					return this._handheldActivationMode;
				}
				set
				{
					this._handheldActivationMode = value;
				}
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0000708C File Offset: 0x0000528C
			// (set) Token: 0x06000356 RID: 854 RVA: 0x00007094 File Offset: 0x00005294
			public bool assignJoysticksByNpadId
			{
				get
				{
					return this._assignJoysticksByNpadId;
				}
				set
				{
					this._assignJoysticksByNpadId = value;
				}
			}

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x06000357 RID: 855 RVA: 0x0000709D File Offset: 0x0000529D
			// (set) Token: 0x06000358 RID: 856 RVA: 0x000070A5 File Offset: 0x000052A5
			public bool useVibrationThread
			{
				get
				{
					return this._useVibrationThread;
				}
				set
				{
					this._useVibrationThread = value;
				}
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x06000359 RID: 857 RVA: 0x000070AE File Offset: 0x000052AE
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo1
			{
				get
				{
					return this._npadNo1;
				}
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x0600035A RID: 858 RVA: 0x000070B6 File Offset: 0x000052B6
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo2
			{
				get
				{
					return this._npadNo2;
				}
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x0600035B RID: 859 RVA: 0x000070BE File Offset: 0x000052BE
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo3
			{
				get
				{
					return this._npadNo3;
				}
			}

			// Token: 0x17000237 RID: 567
			// (get) Token: 0x0600035C RID: 860 RVA: 0x000070C6 File Offset: 0x000052C6
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo4
			{
				get
				{
					return this._npadNo4;
				}
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x0600035D RID: 861 RVA: 0x000070CE File Offset: 0x000052CE
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo5
			{
				get
				{
					return this._npadNo5;
				}
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x0600035E RID: 862 RVA: 0x000070D6 File Offset: 0x000052D6
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo6
			{
				get
				{
					return this._npadNo6;
				}
			}

			// Token: 0x1700023A RID: 570
			// (get) Token: 0x0600035F RID: 863 RVA: 0x000070DE File Offset: 0x000052DE
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo7
			{
				get
				{
					return this._npadNo7;
				}
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x06000360 RID: 864 RVA: 0x000070E6 File Offset: 0x000052E6
			private NintendoSwitchInputManager.NpadSettings_Internal npadNo8
			{
				get
				{
					return this._npadNo8;
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x06000361 RID: 865 RVA: 0x000070EE File Offset: 0x000052EE
			private NintendoSwitchInputManager.NpadSettings_Internal npadHandheld
			{
				get
				{
					return this._npadHandheld;
				}
			}

			// Token: 0x1700023D RID: 573
			// (get) Token: 0x06000362 RID: 866 RVA: 0x000070F6 File Offset: 0x000052F6
			public NintendoSwitchInputManager.DebugPadSettings_Internal debugPad
			{
				get
				{
					return this._debugPad;
				}
			}

			// Token: 0x1700023E RID: 574
			// (get) Token: 0x06000363 RID: 867 RVA: 0x00007100 File Offset: 0x00005300
			private Dictionary<int, object[]> delegates
			{
				get
				{
					if (this.__delegates != null)
					{
						return this.__delegates;
					}
					Dictionary<int, object[]> dictionary = new Dictionary<int, object[]>();
					dictionary.Add(0, new object[]
					{
						new Func<int>(() => this.allowedNpadStyles),
						new Action<int>(delegate(int x)
						{
							this.allowedNpadStyles = x;
						})
					});
					dictionary.Add(1, new object[]
					{
						new Func<int>(() => this.joyConGripStyle),
						new Action<int>(delegate(int x)
						{
							this.joyConGripStyle = x;
						})
					});
					dictionary.Add(2, new object[]
					{
						new Func<bool>(() => this.adjustIMUsForGripStyle),
						new Action<bool>(delegate(bool x)
						{
							this.adjustIMUsForGripStyle = x;
						})
					});
					dictionary.Add(3, new object[]
					{
						new Func<int>(() => this.handheldActivationMode),
						new Action<int>(delegate(int x)
						{
							this.handheldActivationMode = x;
						})
					});
					dictionary.Add(4, new object[]
					{
						new Func<bool>(() => this.assignJoysticksByNpadId),
						new Action<bool>(delegate(bool x)
						{
							this.assignJoysticksByNpadId = x;
						})
					});
					Dictionary<int, object[]> dictionary2 = dictionary;
					int key = 5;
					object[] array = new object[2];
					array[0] = new Func<object>(() => this.npadNo1);
					dictionary2.Add(key, array);
					Dictionary<int, object[]> dictionary3 = dictionary;
					int key2 = 6;
					object[] array2 = new object[2];
					array2[0] = new Func<object>(() => this.npadNo2);
					dictionary3.Add(key2, array2);
					Dictionary<int, object[]> dictionary4 = dictionary;
					int key3 = 7;
					object[] array3 = new object[2];
					array3[0] = new Func<object>(() => this.npadNo3);
					dictionary4.Add(key3, array3);
					Dictionary<int, object[]> dictionary5 = dictionary;
					int key4 = 8;
					object[] array4 = new object[2];
					array4[0] = new Func<object>(() => this.npadNo4);
					dictionary5.Add(key4, array4);
					Dictionary<int, object[]> dictionary6 = dictionary;
					int key5 = 9;
					object[] array5 = new object[2];
					array5[0] = new Func<object>(() => this.npadNo5);
					dictionary6.Add(key5, array5);
					Dictionary<int, object[]> dictionary7 = dictionary;
					int key6 = 10;
					object[] array6 = new object[2];
					array6[0] = new Func<object>(() => this.npadNo6);
					dictionary7.Add(key6, array6);
					Dictionary<int, object[]> dictionary8 = dictionary;
					int key7 = 11;
					object[] array7 = new object[2];
					array7[0] = new Func<object>(() => this.npadNo7);
					dictionary8.Add(key7, array7);
					Dictionary<int, object[]> dictionary9 = dictionary;
					int key8 = 12;
					object[] array8 = new object[2];
					array8[0] = new Func<object>(() => this.npadNo8);
					dictionary9.Add(key8, array8);
					Dictionary<int, object[]> dictionary10 = dictionary;
					int key9 = 13;
					object[] array9 = new object[2];
					array9[0] = new Func<object>(() => this.npadHandheld);
					dictionary10.Add(key9, array9);
					Dictionary<int, object[]> dictionary11 = dictionary;
					int key10 = 14;
					object[] array10 = new object[2];
					array10[0] = new Func<object>(() => this.debugPad);
					dictionary11.Add(key10, array10);
					dictionary.Add(15, new object[]
					{
						new Func<bool>(() => this.useVibrationThread),
						new Action<bool>(delegate(bool x)
						{
							this.useVibrationThread = x;
						})
					});
					return this.__delegates = dictionary;
				}
			}

			// Token: 0x06000364 RID: 868 RVA: 0x00007350 File Offset: 0x00005550
			bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
			{
				object[] array;
				if (!this.delegates.TryGetValue(key, out array))
				{
					value = default(T);
					return false;
				}
				Func<T> func = array[0] as Func<T>;
				if (func == null)
				{
					value = default(T);
					return false;
				}
				value = func();
				return true;
			}

			// Token: 0x06000365 RID: 869 RVA: 0x00007398 File Offset: 0x00005598
			bool IKeyedData<int>.TrySetValue<T>(int key, T value)
			{
				object[] array;
				if (!this.delegates.TryGetValue(key, out array))
				{
					return false;
				}
				Action<T> action = array[1] as Action<T>;
				if (action == null)
				{
					return false;
				}
				action(value);
				return true;
			}

			// Token: 0x040001EC RID: 492
			[SerializeField]
			private int _allowedNpadStyles = -1;

			// Token: 0x040001ED RID: 493
			[SerializeField]
			private int _joyConGripStyle = 1;

			// Token: 0x040001EE RID: 494
			[SerializeField]
			private bool _adjustIMUsForGripStyle = true;

			// Token: 0x040001EF RID: 495
			[SerializeField]
			private int _handheldActivationMode;

			// Token: 0x040001F0 RID: 496
			[SerializeField]
			private bool _assignJoysticksByNpadId = true;

			// Token: 0x040001F1 RID: 497
			[SerializeField]
			private bool _useVibrationThread = true;

			// Token: 0x040001F2 RID: 498
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo1 = new NintendoSwitchInputManager.NpadSettings_Internal(0);

			// Token: 0x040001F3 RID: 499
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo2 = new NintendoSwitchInputManager.NpadSettings_Internal(1);

			// Token: 0x040001F4 RID: 500
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo3 = new NintendoSwitchInputManager.NpadSettings_Internal(2);

			// Token: 0x040001F5 RID: 501
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo4 = new NintendoSwitchInputManager.NpadSettings_Internal(3);

			// Token: 0x040001F6 RID: 502
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo5 = new NintendoSwitchInputManager.NpadSettings_Internal(4);

			// Token: 0x040001F7 RID: 503
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo6 = new NintendoSwitchInputManager.NpadSettings_Internal(5);

			// Token: 0x040001F8 RID: 504
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo7 = new NintendoSwitchInputManager.NpadSettings_Internal(6);

			// Token: 0x040001F9 RID: 505
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadNo8 = new NintendoSwitchInputManager.NpadSettings_Internal(7);

			// Token: 0x040001FA RID: 506
			[SerializeField]
			private NintendoSwitchInputManager.NpadSettings_Internal _npadHandheld = new NintendoSwitchInputManager.NpadSettings_Internal(0);

			// Token: 0x040001FB RID: 507
			[SerializeField]
			private NintendoSwitchInputManager.DebugPadSettings_Internal _debugPad = new NintendoSwitchInputManager.DebugPadSettings_Internal(0);

			// Token: 0x040001FC RID: 508
			private Dictionary<int, object[]> __delegates;
		}

		// Token: 0x02000019 RID: 25
		[Serializable]
		private sealed class NpadSettings_Internal : IKeyedData<int>
		{
			// Token: 0x1700023F RID: 575
			// (get) Token: 0x0600037D RID: 893 RVA: 0x00007534 File Offset: 0x00005734
			// (set) Token: 0x0600037E RID: 894 RVA: 0x0000753C File Offset: 0x0000573C
			private bool isAllowed
			{
				get
				{
					return this._isAllowed;
				}
				set
				{
					this._isAllowed = value;
				}
			}

			// Token: 0x17000240 RID: 576
			// (get) Token: 0x0600037F RID: 895 RVA: 0x00007545 File Offset: 0x00005745
			// (set) Token: 0x06000380 RID: 896 RVA: 0x0000754D File Offset: 0x0000574D
			private int rewiredPlayerId
			{
				get
				{
					return this._rewiredPlayerId;
				}
				set
				{
					this._rewiredPlayerId = value;
				}
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x06000381 RID: 897 RVA: 0x00007556 File Offset: 0x00005756
			// (set) Token: 0x06000382 RID: 898 RVA: 0x0000755E File Offset: 0x0000575E
			private int joyConAssignmentMode
			{
				get
				{
					return this._joyConAssignmentMode;
				}
				set
				{
					this._joyConAssignmentMode = value;
				}
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00007567 File Offset: 0x00005767
			internal NpadSettings_Internal(int playerId)
			{
				this._rewiredPlayerId = playerId;
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x06000384 RID: 900 RVA: 0x00007584 File Offset: 0x00005784
			private Dictionary<int, object[]> delegates
			{
				get
				{
					if (this.__delegates != null)
					{
						return this.__delegates;
					}
					return this.__delegates = new Dictionary<int, object[]>
					{
						{
							0,
							new object[]
							{
								new Func<bool>(() => this.isAllowed),
								new Action<bool>(delegate(bool x)
								{
									this.isAllowed = x;
								})
							}
						},
						{
							1,
							new object[]
							{
								new Func<int>(() => this.rewiredPlayerId),
								new Action<int>(delegate(int x)
								{
									this.rewiredPlayerId = x;
								})
							}
						},
						{
							2,
							new object[]
							{
								new Func<int>(() => this.joyConAssignmentMode),
								new Action<int>(delegate(int x)
								{
									this.joyConAssignmentMode = x;
								})
							}
						}
					};
				}
			}

			// Token: 0x06000385 RID: 901 RVA: 0x00007634 File Offset: 0x00005834
			bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
			{
				object[] array;
				if (!this.delegates.TryGetValue(key, out array))
				{
					value = default(T);
					return false;
				}
				Func<T> func = array[0] as Func<T>;
				if (func == null)
				{
					value = default(T);
					return false;
				}
				value = func();
				return true;
			}

			// Token: 0x06000386 RID: 902 RVA: 0x0000767C File Offset: 0x0000587C
			bool IKeyedData<int>.TrySetValue<T>(int key, T value)
			{
				object[] array;
				if (!this.delegates.TryGetValue(key, out array))
				{
					return false;
				}
				Action<T> action = array[1] as Action<T>;
				if (action == null)
				{
					return false;
				}
				action(value);
				return true;
			}

			// Token: 0x040001FD RID: 509
			[Tooltip("Determines whether this Npad id is allowed to be used by the system.")]
			[SerializeField]
			private bool _isAllowed = true;

			// Token: 0x040001FE RID: 510
			[Tooltip("The Rewired Player Id assigned to this Npad id.")]
			[SerializeField]
			private int _rewiredPlayerId;

			// Token: 0x040001FF RID: 511
			[Tooltip("Determines how Joy-Cons should be handled.\n\nUnmodified: Joy-Con assignment mode will be left at the system default.\nDual: Joy-Cons pairs are handled as a single controller.\nSingle: Joy-Cons are handled as individual controllers.")]
			[SerializeField]
			private int _joyConAssignmentMode = -1;

			// Token: 0x04000200 RID: 512
			private Dictionary<int, object[]> __delegates;
		}

		// Token: 0x0200001A RID: 26
		[Serializable]
		private sealed class DebugPadSettings_Internal : IKeyedData<int>
		{
			// Token: 0x17000243 RID: 579
			// (get) Token: 0x0600038D RID: 909 RVA: 0x000076E4 File Offset: 0x000058E4
			// (set) Token: 0x0600038E RID: 910 RVA: 0x000076EC File Offset: 0x000058EC
			private int rewiredPlayerId
			{
				get
				{
					return this._rewiredPlayerId;
				}
				set
				{
					this._rewiredPlayerId = value;
				}
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x0600038F RID: 911 RVA: 0x000076F5 File Offset: 0x000058F5
			// (set) Token: 0x06000390 RID: 912 RVA: 0x000076FD File Offset: 0x000058FD
			private bool enabled
			{
				get
				{
					return this._enabled;
				}
				set
				{
					this._enabled = value;
				}
			}

			// Token: 0x06000391 RID: 913 RVA: 0x00007706 File Offset: 0x00005906
			internal DebugPadSettings_Internal(int playerId)
			{
				this._rewiredPlayerId = playerId;
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x06000392 RID: 914 RVA: 0x00007718 File Offset: 0x00005918
			private Dictionary<int, object[]> delegates
			{
				get
				{
					if (this.__delegates != null)
					{
						return this.__delegates;
					}
					return this.__delegates = new Dictionary<int, object[]>
					{
						{
							0,
							new object[]
							{
								new Func<bool>(() => this.enabled),
								new Action<bool>(delegate(bool x)
								{
									this.enabled = x;
								})
							}
						},
						{
							1,
							new object[]
							{
								new Func<int>(() => this.rewiredPlayerId),
								new Action<int>(delegate(int x)
								{
									this.rewiredPlayerId = x;
								})
							}
						}
					};
				}
			}

			// Token: 0x06000393 RID: 915 RVA: 0x0000779C File Offset: 0x0000599C
			bool IKeyedData<int>.TryGetValue<T>(int key, out T value)
			{
				object[] array;
				if (!this.delegates.TryGetValue(key, out array))
				{
					value = default(T);
					return false;
				}
				Func<T> func = array[0] as Func<T>;
				if (func == null)
				{
					value = default(T);
					return false;
				}
				value = func();
				return true;
			}

			// Token: 0x06000394 RID: 916 RVA: 0x000077E4 File Offset: 0x000059E4
			bool IKeyedData<int>.TrySetValue<T>(int key, T value)
			{
				object[] array;
				if (!this.delegates.TryGetValue(key, out array))
				{
					return false;
				}
				Action<T> action = array[1] as Action<T>;
				if (action == null)
				{
					return false;
				}
				action(value);
				return true;
			}

			// Token: 0x04000201 RID: 513
			[Tooltip("Determines whether the Debug Pad will be enabled.")]
			[SerializeField]
			private bool _enabled;

			// Token: 0x04000202 RID: 514
			[Tooltip("The Rewired Player Id to which the Debug Pad will be assigned.")]
			[SerializeField]
			private int _rewiredPlayerId;

			// Token: 0x04000203 RID: 515
			private Dictionary<int, object[]> __delegates;
		}
	}
}
