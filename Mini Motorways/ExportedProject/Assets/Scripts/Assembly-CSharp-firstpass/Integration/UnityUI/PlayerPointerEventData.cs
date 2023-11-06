using System;
using System.Text;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	// Token: 0x02000013 RID: 19
	public class PlayerPointerEventData : PointerEventData
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00004873 File Offset: 0x00002A73
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0000487B File Offset: 0x00002A7B
		public int playerId { get; set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00004884 File Offset: 0x00002A84
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0000488C File Offset: 0x00002A8C
		public int inputSourceIndex { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00004895 File Offset: 0x00002A95
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x0000489D File Offset: 0x00002A9D
		public IMouseInputSource mouseSource { get; set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x000048A6 File Offset: 0x00002AA6
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x000048AE File Offset: 0x00002AAE
		public ITouchInputSource touchSource { get; set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x000048B7 File Offset: 0x00002AB7
		// (set) Token: 0x060002CA RID: 714 RVA: 0x000048BF File Offset: 0x00002ABF
		public PointerEventType sourceType { get; set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060002CB RID: 715 RVA: 0x000048C8 File Offset: 0x00002AC8
		// (set) Token: 0x060002CC RID: 716 RVA: 0x000048D0 File Offset: 0x00002AD0
		public int buttonIndex { get; set; }

		// Token: 0x060002CD RID: 717 RVA: 0x000048D9 File Offset: 0x00002AD9
		public PlayerPointerEventData(EventSystem eventSystem) : base(eventSystem)
		{
			this.playerId = -1;
			this.inputSourceIndex = -1;
			this.buttonIndex = -1;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000048F8 File Offset: 0x00002AF8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<b>Player Id</b>: " + this.playerId.ToString());
			string str = "<b>Mouse Source</b>: ";
			IMouseInputSource mouseSource = this.mouseSource;
			stringBuilder.AppendLine(str + ((mouseSource != null) ? mouseSource.ToString() : null));
			stringBuilder.AppendLine("<b>Input Source Index</b>: " + this.inputSourceIndex.ToString());
			string str2 = "<b>Touch Source/b>: ";
			ITouchInputSource touchSource = this.touchSource;
			stringBuilder.AppendLine(str2 + ((touchSource != null) ? touchSource.ToString() : null));
			stringBuilder.AppendLine("<b>Source Type</b>: " + this.sourceType.ToString());
			stringBuilder.AppendLine("<b>Button Index</b>: " + this.buttonIndex.ToString());
			stringBuilder.Append(base.ToString());
			return stringBuilder.ToString();
		}
	}
}
