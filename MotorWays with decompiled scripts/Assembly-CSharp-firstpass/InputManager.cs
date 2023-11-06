using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rewired
{
	// Token: 0x0200000E RID: 14
	[AddComponentMenu("Rewired/Input Manager")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InputManager : InputManager_Base
	{
		// Token: 0x06000205 RID: 517 RVA: 0x00002B14 File Offset: 0x00000D14
		protected override void OnInitialized()
		{
			this.SubscribeEvents();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002B1C File Offset: 0x00000D1C
		protected override void OnDeinitialized()
		{
			this.UnsubscribeEvents();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002B24 File Offset: 0x00000D24
		protected override void DetectPlatform()
		{
			this.scriptingBackend = ScriptingBackend.Mono;
			this.scriptingAPILevel = ScriptingAPILevel.Net20;
			this.editorPlatform = EditorPlatform.None;
			this.platform = Platform.Unknown;
			this.webplayerPlatform = WebplayerPlatform.None;
			this.isEditor = false;
			if (SystemInfo.deviceName == null)
			{
				string empty = string.Empty;
			}
			if (SystemInfo.deviceModel == null)
			{
				string empty2 = string.Empty;
			}
			this.platform = Platform.Windows;
			this.scriptingBackend = ScriptingBackend.Mono;
			this.scriptingAPILevel = ScriptingAPILevel.Net46;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002B8A File Offset: 0x00000D8A
		protected override void CheckRecompile()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002B8C File Offset: 0x00000D8C
		protected override IExternalTools GetExternalTools()
		{
			return new ExternalTools();
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002B93 File Offset: 0x00000D93
		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			return Regex.IsMatch(deviceName, searchPattern, RegexOptions.IgnoreCase) || Regex.IsMatch(deviceModel, searchPattern, RegexOptions.IgnoreCase);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002BA9 File Offset: 0x00000DA9
		private void SubscribeEvents()
		{
			this.UnsubscribeEvents();
			SceneManager.sceneLoaded += this.OnSceneLoaded;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002BC2 File Offset: 0x00000DC2
		private void UnsubscribeEvents()
		{
			SceneManager.sceneLoaded -= this.OnSceneLoaded;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002BD5 File Offset: 0x00000DD5
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			base.OnSceneLoaded();
		}

		// Token: 0x04000197 RID: 407
		private bool ignoreRecompile;
	}
}
