using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	// Token: 0x02000011 RID: 17
	public class UserDataStore_PlayerPrefs : UserDataStore
	{
		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00002E57 File Offset: 0x00001057
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002E5F File Offset: 0x0000105F
		public bool IsEnabled
		{
			get
			{
				return this.isEnabled;
			}
			set
			{
				this.isEnabled = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00002E70 File Offset: 0x00001070
		public bool LoadDataOnStart
		{
			get
			{
				return this.loadDataOnStart;
			}
			set
			{
				this.loadDataOnStart = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00002E79 File Offset: 0x00001079
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002E81 File Offset: 0x00001081
		public bool LoadJoystickAssignments
		{
			get
			{
				return this.loadJoystickAssignments;
			}
			set
			{
				this.loadJoystickAssignments = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002E8A File Offset: 0x0000108A
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002E92 File Offset: 0x00001092
		public bool LoadKeyboardAssignments
		{
			get
			{
				return this.loadKeyboardAssignments;
			}
			set
			{
				this.loadKeyboardAssignments = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00002E9B File Offset: 0x0000109B
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00002EA3 File Offset: 0x000010A3
		public bool LoadMouseAssignments
		{
			get
			{
				return this.loadMouseAssignments;
			}
			set
			{
				this.loadMouseAssignments = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00002EAC File Offset: 0x000010AC
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00002EB4 File Offset: 0x000010B4
		public string PlayerPrefsKeyPrefix
		{
			get
			{
				return this.playerPrefsKeyPrefix;
			}
			set
			{
				this.playerPrefsKeyPrefix = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00002EBD File Offset: 0x000010BD
		private string playerPrefsKey_controllerAssignments
		{
			get
			{
				return string.Format("{0}_{1}", this.playerPrefsKeyPrefix, "ControllerAssignments");
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002ED4 File Offset: 0x000010D4
		private bool loadControllerAssignments
		{
			get
			{
				return this.loadKeyboardAssignments || this.loadMouseAssignments || this.loadJoystickAssignments;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00002EF0 File Offset: 0x000010F0
		private List<int> allActionIds
		{
			get
			{
				if (this.__allActionIds != null)
				{
					return this.__allActionIds;
				}
				List<int> list = new List<int>();
				IList<InputAction> actions = ReInput.mapping.Actions;
				for (int i = 0; i < actions.Count; i++)
				{
					list.Add(actions[i].id);
				}
				this.__allActionIds = list;
				return list;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002F48 File Offset: 0x00001148
		private string allActionIdsString
		{
			get
			{
				if (!string.IsNullOrEmpty(this.__allActionIdsString))
				{
					return this.__allActionIdsString;
				}
				StringBuilder stringBuilder = new StringBuilder();
				List<int> allActionIds = this.allActionIds;
				for (int i = 0; i < allActionIds.Count; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(",");
					}
					stringBuilder.Append(allActionIds[i]);
				}
				this.__allActionIdsString = stringBuilder.ToString();
				return this.__allActionIdsString;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002FB7 File Offset: 0x000011B7
		public override void Save()
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SaveAll();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002FD3 File Offset: 0x000011D3
		public override void SaveControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SaveControllerDataNow(playerId, controllerType, controllerId);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002FF2 File Offset: 0x000011F2
		public override void SaveControllerData(ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SaveControllerDataNow(controllerType, controllerId);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00003010 File Offset: 0x00001210
		public override void SavePlayerData(int playerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SavePlayerDataNow(playerId);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000302D File Offset: 0x0000122D
		public override void SaveInputBehavior(int playerId, int behaviorId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", this);
				return;
			}
			this.SaveInputBehaviorNow(playerId, behaviorId);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000304B File Offset: 0x0000124B
		public override void Load()
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadAll();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00003068 File Offset: 0x00001268
		public override void LoadControllerData(int playerId, ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadControllerDataNow(playerId, controllerType, controllerId);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003088 File Offset: 0x00001288
		public override void LoadControllerData(ControllerType controllerType, int controllerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadControllerDataNow(controllerType, controllerId);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000030A7 File Offset: 0x000012A7
		public override void LoadPlayerData(int playerId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadPlayerDataNow(playerId);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000030C5 File Offset: 0x000012C5
		public override void LoadInputBehavior(int playerId, int behaviorId)
		{
			if (!this.isEnabled)
			{
				Debug.LogWarning("Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", this);
				return;
			}
			this.LoadInputBehaviorNow(playerId, behaviorId);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000030E4 File Offset: 0x000012E4
		protected override void OnInitialize()
		{
			if (this.loadDataOnStart)
			{
				this.Load();
				if (this.loadControllerAssignments && ReInput.controllers.joystickCount > 0)
				{
					this.wasJoystickEverDetected = true;
					this.SaveControllerAssignments();
				}
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00003118 File Offset: 0x00001318
		protected override void OnControllerConnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (args.controllerType == ControllerType.Joystick)
			{
				this.LoadJoystickData(args.controllerId);
				if (this.loadDataOnStart && this.loadJoystickAssignments && !this.wasJoystickEverDetected)
				{
					base.StartCoroutine(this.LoadJoystickAssignmentsDeferred());
				}
				if (this.loadJoystickAssignments && !this.deferredJoystickAssignmentLoadPending)
				{
					this.SaveControllerAssignments();
				}
				this.wasJoystickEverDetected = true;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003187 File Offset: 0x00001387
		protected override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (args.controllerType == ControllerType.Joystick)
			{
				this.SaveJoystickData(args.controllerId);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000031A7 File Offset: 0x000013A7
		protected override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
		{
			if (!this.isEnabled)
			{
				return;
			}
			if (this.loadControllerAssignments)
			{
				this.SaveControllerAssignments();
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000031C4 File Offset: 0x000013C4
		public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
		{
			if (controllerMap == null)
			{
				return;
			}
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return;
			}
			this.SaveControllerMap(player, controllerMap);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000031F0 File Offset: 0x000013F0
		public override ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return null;
			}
			return this.LoadControllerMap(player, controllerIdentifier, categoryId, layoutId);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000321C File Offset: 0x0000141C
		private int LoadAll()
		{
			int num = 0;
			if (this.loadControllerAssignments && this.LoadControllerAssignmentsNow())
			{
				num++;
			}
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				num += this.LoadPlayerDataNow(allPlayers[i]);
			}
			return num + this.LoadAllJoystickCalibrationData();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00003275 File Offset: 0x00001475
		private int LoadPlayerDataNow(int playerId)
		{
			return this.LoadPlayerDataNow(ReInput.players.GetPlayer(playerId));
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00003288 File Offset: 0x00001488
		private int LoadPlayerDataNow(Player player)
		{
			if (player == null)
			{
				return 0;
			}
			int num = 0;
			num += this.LoadInputBehaviors(player.id);
			num += this.LoadControllerMaps(player.id, ControllerType.Keyboard, 0);
			num += this.LoadControllerMaps(player.id, ControllerType.Mouse, 0);
			foreach (Joystick joystick in player.controllers.Joysticks)
			{
				num += this.LoadControllerMaps(player.id, ControllerType.Joystick, joystick.id);
			}
			this.RefreshLayoutManager(player.id);
			return num;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00003330 File Offset: 0x00001530
		private int LoadAllJoystickCalibrationData()
		{
			int num = 0;
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				num += this.LoadJoystickCalibrationData(joysticks[i]);
			}
			return num;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000336C File Offset: 0x0000156C
		private int LoadJoystickCalibrationData(Joystick joystick)
		{
			if (joystick == null)
			{
				return 0;
			}
			if (!joystick.ImportCalibrationMapFromXmlString(this.GetJoystickCalibrationMapXml(joystick)))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00003385 File Offset: 0x00001585
		private int LoadJoystickCalibrationData(int joystickId)
		{
			return this.LoadJoystickCalibrationData(ReInput.controllers.GetJoystick(joystickId));
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00003398 File Offset: 0x00001598
		private int LoadJoystickData(int joystickId)
		{
			int num = 0;
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (player.controllers.ContainsController(ControllerType.Joystick, joystickId))
				{
					num += this.LoadControllerMaps(player.id, ControllerType.Joystick, joystickId);
					this.RefreshLayoutManager(player.id);
				}
			}
			return num + this.LoadJoystickCalibrationData(joystickId);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00003402 File Offset: 0x00001602
		private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			int num = 0 + this.LoadControllerMaps(playerId, controllerType, controllerId);
			this.RefreshLayoutManager(playerId);
			return num + this.LoadControllerDataNow(controllerType, controllerId);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00003420 File Offset: 0x00001620
		private int LoadControllerDataNow(ControllerType controllerType, int controllerId)
		{
			int num = 0;
			if (controllerType == ControllerType.Joystick)
			{
				num += this.LoadJoystickCalibrationData(controllerId);
			}
			return num;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00003440 File Offset: 0x00001640
		private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			int num = 0;
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return num;
			}
			Controller controller = ReInput.controllers.GetController(controllerType, controllerId);
			if (controller == null)
			{
				return num;
			}
			IList<InputMapCategory> mapCategories = ReInput.mapping.MapCategories;
			for (int i = 0; i < mapCategories.Count; i++)
			{
				InputMapCategory inputMapCategory = mapCategories[i];
				if (inputMapCategory.userAssignable)
				{
					IList<InputLayout> list = ReInput.mapping.MapLayouts(controller.type);
					for (int j = 0; j < list.Count; j++)
					{
						InputLayout inputLayout = list[j];
						ControllerMap controllerMap = this.LoadControllerMap(player, controller.identifier, inputMapCategory.id, inputLayout.id);
						if (controllerMap != null)
						{
							player.controllers.maps.AddMap(controller, controllerMap);
							num++;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003518 File Offset: 0x00001718
		private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			if (player == null)
			{
				return null;
			}
			string controllerMapXml = this.GetControllerMapXml(player, controllerIdentifier, categoryId, layoutId);
			if (string.IsNullOrEmpty(controllerMapXml))
			{
				return null;
			}
			ControllerMap controllerMap = ControllerMap.CreateFromXml(controllerIdentifier.controllerType, controllerMapXml);
			if (controllerMap == null)
			{
				return null;
			}
			List<int> controllerMapKnownActionIds = this.GetControllerMapKnownActionIds(player, controllerIdentifier, categoryId, layoutId);
			this.AddDefaultMappingsForNewActions(controllerIdentifier, controllerMap, controllerMapKnownActionIds);
			return controllerMap;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000356C File Offset: 0x0000176C
		private int LoadInputBehaviors(int playerId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return 0;
			}
			int num = 0;
			IList<InputBehavior> inputBehaviors = ReInput.mapping.GetInputBehaviors(player.id);
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				num += this.LoadInputBehaviorNow(player, inputBehaviors[i]);
			}
			return num;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000035C0 File Offset: 0x000017C0
		private int LoadInputBehaviorNow(int playerId, int behaviorId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return 0;
			}
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
			if (inputBehavior == null)
			{
				return 0;
			}
			return this.LoadInputBehaviorNow(player, inputBehavior);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000035F8 File Offset: 0x000017F8
		private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			if (player == null || inputBehavior == null)
			{
				return 0;
			}
			string inputBehaviorXml = this.GetInputBehaviorXml(player, inputBehavior.id);
			if (inputBehaviorXml == null || inputBehaviorXml == string.Empty)
			{
				return 0;
			}
			if (!inputBehavior.ImportXmlString(inputBehaviorXml))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000363C File Offset: 0x0000183C
		private bool LoadControllerAssignmentsNow()
		{
			try
			{
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = this.LoadControllerAssignmentData();
				if (controllerAssignmentSaveInfo == null)
				{
					return false;
				}
				if (this.loadKeyboardAssignments || this.loadMouseAssignments)
				{
					this.LoadKeyboardAndMouseAssignmentsNow(controllerAssignmentSaveInfo);
				}
				if (this.loadJoystickAssignments)
				{
					this.LoadJoystickAssignmentsNow(controllerAssignmentSaveInfo);
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003698 File Offset: 0x00001898
		private bool LoadKeyboardAndMouseAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			try
			{
				if (data == null && (data = this.LoadControllerAssignmentData()) == null)
				{
					return false;
				}
				foreach (Player player in ReInput.players.AllPlayers)
				{
					if (data.ContainsPlayer(player.id))
					{
						UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo = data.players[data.IndexOfPlayer(player.id)];
						if (this.loadKeyboardAssignments)
						{
							player.controllers.hasKeyboard = playerInfo.hasKeyboard;
						}
						if (this.loadMouseAssignments)
						{
							player.controllers.hasMouse = playerInfo.hasMouse;
						}
					}
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003760 File Offset: 0x00001960
		private bool LoadJoystickAssignmentsNow(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
		{
			try
			{
				if (ReInput.controllers.joystickCount == 0)
				{
					return false;
				}
				if (data == null && (data = this.LoadControllerAssignmentData()) == null)
				{
					return false;
				}
				foreach (Player player in ReInput.players.AllPlayers)
				{
					player.controllers.ClearControllersOfType(ControllerType.Joystick);
				}
				List<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo> list = this.loadJoystickAssignments ? new List<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>() : null;
				foreach (Player player2 in ReInput.players.AllPlayers)
				{
					if (data.ContainsPlayer(player2.id))
					{
						UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo = data.players[data.IndexOfPlayer(player2.id)];
						for (int i = 0; i < playerInfo.joystickCount; i++)
						{
							UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo2 = playerInfo.joysticks[i];
							if (joystickInfo2 != null)
							{
								Joystick joystick = this.FindJoystickPrecise(joystickInfo2);
								if (joystick != null)
								{
									if (list.Find((UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) => x.joystick == joystick) == null)
									{
										list.Add(new UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo(joystick, joystickInfo2.id));
									}
									player2.controllers.AddController(joystick, false);
								}
							}
						}
					}
				}
				if (this.allowImpreciseJoystickAssignmentMatching)
				{
					foreach (Player player3 in ReInput.players.AllPlayers)
					{
						if (data.ContainsPlayer(player3.id))
						{
							UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo2 = data.players[data.IndexOfPlayer(player3.id)];
							for (int j = 0; j < playerInfo2.joystickCount; j++)
							{
								UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo = playerInfo2.joysticks[j];
								if (joystickInfo != null)
								{
									Joystick joystick2 = null;
									int num = list.FindIndex((UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) => x.oldJoystickId == joystickInfo.id);
									if (num >= 0)
									{
										joystick2 = list[num].joystick;
									}
									else
									{
										List<Joystick> list2;
										if (!this.TryFindJoysticksImprecise(joystickInfo, out list2))
										{
											goto IL_298;
										}
										using (List<Joystick>.Enumerator enumerator2 = list2.GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												Joystick match = enumerator2.Current;
												if (list.Find((UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo x) => x.joystick == match) == null)
												{
													joystick2 = match;
													break;
												}
											}
										}
										if (joystick2 == null)
										{
											goto IL_298;
										}
										list.Add(new UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo(joystick2, joystickInfo.id));
									}
									player3.controllers.AddController(joystick2, false);
								}
								IL_298:;
							}
						}
					}
				}
			}
			catch
			{
			}
			if (ReInput.configuration.autoAssignJoysticks)
			{
				ReInput.controllers.AutoAssignJoysticks();
			}
			return true;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00003ACC File Offset: 0x00001CCC
		private UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
		{
			UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo result;
			try
			{
				if (!PlayerPrefs.HasKey(this.playerPrefsKey_controllerAssignments))
				{
					result = null;
				}
				else
				{
					string @string = PlayerPrefs.GetString(this.playerPrefsKey_controllerAssignments);
					if (string.IsNullOrEmpty(@string))
					{
						result = null;
					}
					else
					{
						UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = JsonParser.FromJson<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>(@string);
						if (controllerAssignmentSaveInfo == null || controllerAssignmentSaveInfo.playerCount == 0)
						{
							result = null;
						}
						else
						{
							result = controllerAssignmentSaveInfo;
						}
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00003B34 File Offset: 0x00001D34
		private IEnumerator LoadJoystickAssignmentsDeferred()
		{
			this.deferredJoystickAssignmentLoadPending = true;
			yield return new WaitForEndOfFrame();
			if (!ReInput.isReady)
			{
				yield break;
			}
			this.LoadJoystickAssignmentsNow(null);
			this.SaveControllerAssignments();
			this.deferredJoystickAssignmentLoadPending = false;
			yield break;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00003B44 File Offset: 0x00001D44
		private void SaveAll()
		{
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				this.SavePlayerDataNow(allPlayers[i]);
			}
			this.SaveAllJoystickCalibrationData();
			if (this.loadControllerAssignments)
			{
				this.SaveControllerAssignments();
			}
			PlayerPrefs.Save();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003B94 File Offset: 0x00001D94
		private void SavePlayerDataNow(int playerId)
		{
			this.SavePlayerDataNow(ReInput.players.GetPlayer(playerId));
			PlayerPrefs.Save();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00003BAC File Offset: 0x00001DAC
		private void SavePlayerDataNow(Player player)
		{
			if (player == null)
			{
				return;
			}
			PlayerSaveData saveData = player.GetSaveData(true);
			this.SaveInputBehaviors(player, saveData);
			this.SaveControllerMaps(player, saveData);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00003BD8 File Offset: 0x00001DD8
		private void SaveAllJoystickCalibrationData()
		{
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				this.SaveJoystickCalibrationData(joysticks[i]);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00003C0E File Offset: 0x00001E0E
		private void SaveJoystickCalibrationData(int joystickId)
		{
			this.SaveJoystickCalibrationData(ReInput.controllers.GetJoystick(joystickId));
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00003C24 File Offset: 0x00001E24
		private void SaveJoystickCalibrationData(Joystick joystick)
		{
			if (joystick == null)
			{
				return;
			}
			JoystickCalibrationMapSaveData calibrationMapSaveData = joystick.GetCalibrationMapSaveData();
			PlayerPrefs.SetString(this.GetJoystickCalibrationMapPlayerPrefsKey(joystick), calibrationMapSaveData.map.ToXmlString());
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00003C54 File Offset: 0x00001E54
		private void SaveJoystickData(int joystickId)
		{
			IList<Player> allPlayers = ReInput.players.AllPlayers;
			for (int i = 0; i < allPlayers.Count; i++)
			{
				Player player = allPlayers[i];
				if (player.controllers.ContainsController(ControllerType.Joystick, joystickId))
				{
					this.SaveControllerMaps(player.id, ControllerType.Joystick, joystickId);
				}
			}
			this.SaveJoystickCalibrationData(joystickId);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00003CA9 File Offset: 0x00001EA9
		private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
		{
			this.SaveControllerMaps(playerId, controllerType, controllerId);
			this.SaveControllerDataNow(controllerType, controllerId);
			PlayerPrefs.Save();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00003CC1 File Offset: 0x00001EC1
		private void SaveControllerDataNow(ControllerType controllerType, int controllerId)
		{
			if (controllerType == ControllerType.Joystick)
			{
				this.SaveJoystickCalibrationData(controllerId);
			}
			PlayerPrefs.Save();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003CD4 File Offset: 0x00001ED4
		private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
		{
			foreach (ControllerMapSaveData controllerMapSaveData in playerSaveData.AllControllerMapSaveData)
			{
				this.SaveControllerMap(player, controllerMapSaveData.map);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00003D28 File Offset: 0x00001F28
		private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return;
			}
			if (!player.controllers.ContainsController(controllerType, controllerId))
			{
				return;
			}
			ControllerMapSaveData[] mapSaveData = player.controllers.maps.GetMapSaveData(controllerType, controllerId, true);
			if (mapSaveData == null)
			{
				return;
			}
			for (int i = 0; i < mapSaveData.Length; i++)
			{
				this.SaveControllerMap(player, mapSaveData[i].map);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00003D8C File Offset: 0x00001F8C
		private void SaveControllerMap(Player player, ControllerMap controllerMap)
		{
			PlayerPrefs.SetString(this.GetControllerMapPlayerPrefsKey(player, controllerMap.controller.identifier, controllerMap.categoryId, controllerMap.layoutId, 2), controllerMap.ToXmlString());
			PlayerPrefs.SetString(this.GetControllerMapKnownActionIdsPlayerPrefsKey(player, controllerMap.controller.identifier, controllerMap.categoryId, controllerMap.layoutId, 2), this.allActionIdsString);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003DF0 File Offset: 0x00001FF0
		private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
		{
			if (player == null)
			{
				return;
			}
			InputBehavior[] inputBehaviors = playerSaveData.inputBehaviors;
			for (int i = 0; i < inputBehaviors.Length; i++)
			{
				this.SaveInputBehaviorNow(player, inputBehaviors[i]);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00003E24 File Offset: 0x00002024
		private void SaveInputBehaviorNow(int playerId, int behaviorId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return;
			}
			InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
			if (inputBehavior == null)
			{
				return;
			}
			this.SaveInputBehaviorNow(player, inputBehavior);
			PlayerPrefs.Save();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003E5F File Offset: 0x0000205F
		private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
		{
			if (player == null || inputBehavior == null)
			{
				return;
			}
			PlayerPrefs.SetString(this.GetInputBehaviorPlayerPrefsKey(player, inputBehavior.id), inputBehavior.ToXmlString());
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003E80 File Offset: 0x00002080
		private bool SaveControllerAssignments()
		{
			try
			{
				UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo controllerAssignmentSaveInfo = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo(ReInput.players.allPlayerCount);
				for (int i = 0; i < ReInput.players.allPlayerCount; i++)
				{
					Player player = ReInput.players.AllPlayers[i];
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo();
					controllerAssignmentSaveInfo.players[i] = playerInfo;
					playerInfo.id = player.id;
					playerInfo.hasKeyboard = player.controllers.hasKeyboard;
					playerInfo.hasMouse = player.controllers.hasMouse;
					UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] array = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[player.controllers.joystickCount];
					playerInfo.joysticks = array;
					for (int j = 0; j < player.controllers.joystickCount; j++)
					{
						Joystick joystick = player.controllers.Joysticks[j];
						array[j] = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo
						{
							instanceGuid = joystick.deviceInstanceGuid,
							id = joystick.id,
							hardwareIdentifier = joystick.hardwareIdentifier
						};
					}
				}
				PlayerPrefs.SetString(this.playerPrefsKey_controllerAssignments, JsonWriter.ToJson(controllerAssignmentSaveInfo));
				PlayerPrefs.Save();
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003FC0 File Offset: 0x000021C0
		private bool ControllerAssignmentSaveDataExists()
		{
			return PlayerPrefs.HasKey(this.playerPrefsKey_controllerAssignments) && !string.IsNullOrEmpty(PlayerPrefs.GetString(this.playerPrefsKey_controllerAssignments));
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00003FE6 File Offset: 0x000021E6
		private string GetBasePlayerPrefsKey(Player player)
		{
			return this.playerPrefsKeyPrefix + "|playerName=" + player.name;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003FFE File Offset: 0x000021FE
		private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return this.GetBasePlayerPrefsKey(player) + "|dataType=ControllerMap" + UserDataStore_PlayerPrefs.GetControllerMapPlayerPrefsKeyCommonSuffix(player, controllerIdentifier, categoryId, layoutId, ppKeyVersion);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00004022 File Offset: 0x00002222
		private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			return this.GetBasePlayerPrefsKey(player) + "|dataType=ControllerMap_KnownActionIds" + UserDataStore_PlayerPrefs.GetControllerMapPlayerPrefsKeyCommonSuffix(player, controllerIdentifier, categoryId, layoutId, ppKeyVersion);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00004048 File Offset: 0x00002248
		private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion)
		{
			string text = "";
			if (ppKeyVersion >= 2)
			{
				text = text + "|kv=" + ppKeyVersion.ToString();
			}
			text = text + "|controllerMapType=" + UserDataStore_PlayerPrefs.GetControllerMapType(controllerIdentifier.controllerType).Name;
			text = string.Concat(new string[]
			{
				text,
				"|categoryId=",
				categoryId.ToString(),
				"|layoutId=",
				layoutId.ToString()
			});
			if (ppKeyVersion >= 2)
			{
				text = text + "|hardwareGuid=" + controllerIdentifier.hardwareTypeGuid.ToString();
				if (controllerIdentifier.hardwareTypeGuid == Guid.Empty)
				{
					text = text + "|hardwareIdentifier=" + controllerIdentifier.hardwareIdentifier;
				}
				if (controllerIdentifier.controllerType == ControllerType.Joystick)
				{
					text = text + "|duplicate=" + UserDataStore_PlayerPrefs.GetDuplicateIndex(player, controllerIdentifier).ToString();
				}
			}
			else
			{
				text = text + "|hardwareIdentifier=" + controllerIdentifier.hardwareIdentifier;
				if (controllerIdentifier.controllerType == ControllerType.Joystick)
				{
					text = text + "|hardwareGuid=" + controllerIdentifier.hardwareTypeGuid.ToString();
					if (ppKeyVersion >= 1)
					{
						text = text + "|duplicate=" + UserDataStore_PlayerPrefs.GetDuplicateIndex(player, controllerIdentifier).ToString();
					}
				}
			}
			return text;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00004198 File Offset: 0x00002398
		private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
		{
			return this.playerPrefsKeyPrefix + "|dataType=CalibrationMap" + "|controllerType=" + joystick.type.ToString() + "|hardwareIdentifier=" + joystick.hardwareIdentifier + "|hardwareGuid=" + joystick.hardwareTypeGuid.ToString();
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00004201 File Offset: 0x00002401
		private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
		{
			return this.GetBasePlayerPrefsKey(player) + "|dataType=InputBehavior" + "|id=" + inputBehaviorId.ToString();
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00004228 File Offset: 0x00002428
		private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			for (int i = 2; i >= 0; i--)
			{
				string controllerMapPlayerPrefsKey = this.GetControllerMapPlayerPrefsKey(player, controllerIdentifier, categoryId, layoutId, i);
				if (PlayerPrefs.HasKey(controllerMapPlayerPrefsKey))
				{
					return PlayerPrefs.GetString(controllerMapPlayerPrefsKey);
				}
			}
			return null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00004260 File Offset: 0x00002460
		private List<int> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId)
		{
			List<int> list = new List<int>();
			string key = null;
			bool flag = false;
			for (int i = 2; i >= 0; i--)
			{
				key = this.GetControllerMapKnownActionIdsPlayerPrefsKey(player, controllerIdentifier, categoryId, layoutId, i);
				if (PlayerPrefs.HasKey(key))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return list;
			}
			string @string = PlayerPrefs.GetString(key);
			if (string.IsNullOrEmpty(@string))
			{
				return list;
			}
			string[] array = @string.Split(new char[]
			{
				','
			});
			for (int j = 0; j < array.Length; j++)
			{
				int item;
				if (!string.IsNullOrEmpty(array[j]) && int.TryParse(array[j], out item))
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00004300 File Offset: 0x00002500
		private string GetJoystickCalibrationMapXml(Joystick joystick)
		{
			string joystickCalibrationMapPlayerPrefsKey = this.GetJoystickCalibrationMapPlayerPrefsKey(joystick);
			if (!PlayerPrefs.HasKey(joystickCalibrationMapPlayerPrefsKey))
			{
				return string.Empty;
			}
			return PlayerPrefs.GetString(joystickCalibrationMapPlayerPrefsKey);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000432C File Offset: 0x0000252C
		private string GetInputBehaviorXml(Player player, int id)
		{
			string inputBehaviorPlayerPrefsKey = this.GetInputBehaviorPlayerPrefsKey(player, id);
			if (!PlayerPrefs.HasKey(inputBehaviorPlayerPrefsKey))
			{
				return string.Empty;
			}
			return PlayerPrefs.GetString(inputBehaviorPlayerPrefsKey);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00004358 File Offset: 0x00002558
		private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<int> knownActionIds)
		{
			if (controllerMap == null || knownActionIds == null)
			{
				return;
			}
			if (knownActionIds == null || knownActionIds.Count == 0)
			{
				return;
			}
			ControllerMap controllerMapInstance = ReInput.mapping.GetControllerMapInstance(controllerIdentifier, controllerMap.categoryId, controllerMap.layoutId);
			if (controllerMapInstance == null)
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (int item in this.allActionIds)
			{
				if (!knownActionIds.Contains(item))
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			foreach (ActionElementMap actionElementMap in controllerMapInstance.AllMaps)
			{
				if (list.Contains(actionElementMap.actionId) && !controllerMap.DoesElementAssignmentConflict(actionElementMap))
				{
					ElementAssignment elementAssignment = new ElementAssignment(controllerMap.controllerType, actionElementMap.elementType, actionElementMap.elementIdentifierId, actionElementMap.axisRange, actionElementMap.keyCode, actionElementMap.modifierKeyFlags, actionElementMap.actionId, actionElementMap.axisContribution, actionElementMap.invert);
					controllerMap.CreateElementMap(elementAssignment);
				}
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00004494 File Offset: 0x00002694
		private Joystick FindJoystickPrecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
		{
			if (joystickInfo == null)
			{
				return null;
			}
			if (joystickInfo.instanceGuid == Guid.Empty)
			{
				return null;
			}
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (joysticks[i].deviceInstanceGuid == joystickInfo.instanceGuid)
				{
					return joysticks[i];
				}
			}
			return null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000044F8 File Offset: 0x000026F8
		private bool TryFindJoysticksImprecise(UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo, out List<Joystick> matches)
		{
			matches = null;
			if (joystickInfo == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(joystickInfo.hardwareIdentifier))
			{
				return false;
			}
			IList<Joystick> joysticks = ReInput.controllers.Joysticks;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (string.Equals(joysticks[i].hardwareIdentifier, joystickInfo.hardwareIdentifier, StringComparison.OrdinalIgnoreCase))
				{
					if (matches == null)
					{
						matches = new List<Joystick>();
					}
					matches.Add(joysticks[i]);
				}
			}
			return matches != null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00004570 File Offset: 0x00002770
		private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
		{
			Controller controller = ReInput.controllers.GetController(controllerIdentifier);
			if (controller == null)
			{
				return 0;
			}
			int num = 0;
			foreach (Controller controller2 in player.controllers.Controllers)
			{
				if (controller2.type == controller.type)
				{
					bool flag = false;
					if (controller.type == ControllerType.Joystick)
					{
						if ((controller2 as Joystick).hardwareTypeGuid != controller.hardwareTypeGuid)
						{
							continue;
						}
						if (controller.hardwareTypeGuid != Guid.Empty)
						{
							flag = true;
						}
					}
					if (flag || !(controller2.hardwareIdentifier != controller.hardwareIdentifier))
					{
						if (controller2 == controller)
						{
							return num;
						}
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00004640 File Offset: 0x00002840
		private void RefreshLayoutManager(int playerId)
		{
			Player player = ReInput.players.GetPlayer(playerId);
			if (player == null)
			{
				return;
			}
			player.controllers.maps.layoutManager.Apply();
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00004674 File Offset: 0x00002874
		private static Type GetControllerMapType(ControllerType controllerType)
		{
			switch (controllerType)
			{
			case ControllerType.Keyboard:
				return typeof(KeyboardMap);
			case ControllerType.Mouse:
				return typeof(MouseMap);
			case ControllerType.Joystick:
				return typeof(JoystickMap);
			default:
				if (controllerType == ControllerType.Custom)
				{
					return typeof(CustomControllerMap);
				}
				Debug.LogWarning("Rewired: Unknown ControllerType " + controllerType.ToString());
				return null;
			}
		}

		// Token: 0x0400019D RID: 413
		private const string thisScriptName = "UserDataStore_PlayerPrefs";

		// Token: 0x0400019E RID: 414
		private const string logPrefix = "Rewired: ";

		// Token: 0x0400019F RID: 415
		private const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";

		// Token: 0x040001A0 RID: 416
		private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";

		// Token: 0x040001A1 RID: 417
		private const int controllerMapPPKeyVersion_original = 0;

		// Token: 0x040001A2 RID: 418
		private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;

		// Token: 0x040001A3 RID: 419
		private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;

		// Token: 0x040001A4 RID: 420
		private const int controllerMapPPKeyVersion_includeFormatVersion = 2;

		// Token: 0x040001A5 RID: 421
		private const int controllerMapPPKeyVersion = 2;

		// Token: 0x040001A6 RID: 422
		[Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
		[SerializeField]
		private bool isEnabled = true;

		// Token: 0x040001A7 RID: 423
		[Tooltip("Should saved data be loaded on start?")]
		[SerializeField]
		private bool loadDataOnStart = true;

		// Token: 0x040001A8 RID: 424
		[Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
		[SerializeField]
		private bool loadJoystickAssignments = true;

		// Token: 0x040001A9 RID: 425
		[Tooltip("Should Player Keyboard assignments be saved and loaded?")]
		[SerializeField]
		private bool loadKeyboardAssignments = true;

		// Token: 0x040001AA RID: 426
		[Tooltip("Should Player Mouse assignments be saved and loaded?")]
		[SerializeField]
		private bool loadMouseAssignments = true;

		// Token: 0x040001AB RID: 427
		[Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
		[SerializeField]
		private string playerPrefsKeyPrefix = "RewiredSaveData";

		// Token: 0x040001AC RID: 428
		[NonSerialized]
		private bool allowImpreciseJoystickAssignmentMatching = true;

		// Token: 0x040001AD RID: 429
		[NonSerialized]
		private bool deferredJoystickAssignmentLoadPending;

		// Token: 0x040001AE RID: 430
		[NonSerialized]
		private bool wasJoystickEverDetected;

		// Token: 0x040001AF RID: 431
		[NonSerialized]
		private List<int> __allActionIds;

		// Token: 0x040001B0 RID: 432
		[NonSerialized]
		private string __allActionIdsString;

		// Token: 0x0200001B RID: 27
		private class ControllerAssignmentSaveInfo
		{
			// Token: 0x17000246 RID: 582
			// (get) Token: 0x06000399 RID: 921 RVA: 0x0000783B File Offset: 0x00005A3B
			public int playerCount
			{
				get
				{
					if (this.players == null)
					{
						return 0;
					}
					return this.players.Length;
				}
			}

			// Token: 0x0600039A RID: 922 RVA: 0x0000784F File Offset: 0x00005A4F
			public ControllerAssignmentSaveInfo()
			{
			}

			// Token: 0x0600039B RID: 923 RVA: 0x00007858 File Offset: 0x00005A58
			public ControllerAssignmentSaveInfo(int playerCount)
			{
				this.players = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[playerCount];
				for (int i = 0; i < playerCount; i++)
				{
					this.players[i] = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo();
				}
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00007890 File Offset: 0x00005A90
			public int IndexOfPlayer(int playerId)
			{
				for (int i = 0; i < this.playerCount; i++)
				{
					if (this.players[i] != null && this.players[i].id == playerId)
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x0600039D RID: 925 RVA: 0x000078CB File Offset: 0x00005ACB
			public bool ContainsPlayer(int playerId)
			{
				return this.IndexOfPlayer(playerId) >= 0;
			}

			// Token: 0x04000204 RID: 516
			public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players;

			// Token: 0x02000026 RID: 38
			public class PlayerInfo
			{
				// Token: 0x17000255 RID: 597
				// (get) Token: 0x060003CB RID: 971 RVA: 0x00007D18 File Offset: 0x00005F18
				public int joystickCount
				{
					get
					{
						if (this.joysticks == null)
						{
							return 0;
						}
						return this.joysticks.Length;
					}
				}

				// Token: 0x060003CC RID: 972 RVA: 0x00007D2C File Offset: 0x00005F2C
				public int IndexOfJoystick(int joystickId)
				{
					for (int i = 0; i < this.joystickCount; i++)
					{
						if (this.joysticks[i] != null && this.joysticks[i].id == joystickId)
						{
							return i;
						}
					}
					return -1;
				}

				// Token: 0x060003CD RID: 973 RVA: 0x00007D67 File Offset: 0x00005F67
				public bool ContainsJoystick(int joystickId)
				{
					return this.IndexOfJoystick(joystickId) >= 0;
				}

				// Token: 0x04000217 RID: 535
				public int id;

				// Token: 0x04000218 RID: 536
				public bool hasKeyboard;

				// Token: 0x04000219 RID: 537
				public bool hasMouse;

				// Token: 0x0400021A RID: 538
				public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;
			}

			// Token: 0x02000027 RID: 39
			public class JoystickInfo
			{
				// Token: 0x0400021B RID: 539
				public Guid instanceGuid;

				// Token: 0x0400021C RID: 540
				public string hardwareIdentifier;

				// Token: 0x0400021D RID: 541
				public int id;
			}
		}

		// Token: 0x0200001C RID: 28
		private class JoystickAssignmentHistoryInfo
		{
			// Token: 0x0600039E RID: 926 RVA: 0x000078DA File Offset: 0x00005ADA
			public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
			{
				if (joystick == null)
				{
					throw new ArgumentNullException("joystick");
				}
				this.joystick = joystick;
				this.oldJoystickId = oldJoystickId;
			}

			// Token: 0x04000205 RID: 517
			public readonly Joystick joystick;

			// Token: 0x04000206 RID: 518
			public readonly int oldJoystickId;
		}
	}
}
