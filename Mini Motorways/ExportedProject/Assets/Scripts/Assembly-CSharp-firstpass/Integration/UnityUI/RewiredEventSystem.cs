using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000014 RID: 20
	[AddComponentMenu("Rewired/Rewired Event System")]
	public class RewiredEventSystem : EventSystem
	{
		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000049E4 File Offset: 0x00002BE4
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x000049EC File Offset: 0x00002BEC
		public bool alwaysUpdate
		{
			get
			{
				return this._alwaysUpdate;
			}
			set
			{
				this._alwaysUpdate = value;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000049F8 File Offset: 0x00002BF8
		protected override void Update()
		{
			if (this.alwaysUpdate)
			{
				EventSystem current = EventSystem.current;
				if (current != this)
				{
					EventSystem.current = this;
				}
				try
				{
					base.Update();
					return;
				}
				finally
				{
					if (current != this)
					{
						EventSystem.current = current;
					}
				}
			}
			base.Update();
		}

		// Token: 0x040001B9 RID: 441
		[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
		[SerializeField]
		private bool _alwaysUpdate;
	}
}
