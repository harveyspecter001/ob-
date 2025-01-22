using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount
{
	// Token: 0x0200037B RID: 891
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MountDataEvent : IMessage<MountDataEvent>, IMessage, IEquatable<MountDataEvent>, IDeepCloneable<MountDataEvent>, IBufferMessage
	{
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x001C843C File Offset: 0x001C663C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MountDataEvent> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x001C844C File Offset: 0x001C664C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x001C845C File Offset: 0x001C665C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x001C846C File Offset: 0x001C666C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountDataEvent()
		{
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x001C847C File Offset: 0x001C667C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountDataEvent(MountDataEvent other)
		{
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x001C848C File Offset: 0x001C668C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MountDataEvent Clone()
		{
			return null;
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x001C849C File Offset: 0x001C669C
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x001C84AC File Offset: 0x001C66AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public MountData MountData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x001C84BC File Offset: 0x001C66BC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x001C84CC File Offset: 0x001C66CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MountDataEvent other)
		{
			return true;
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x001C84DC File Offset: 0x001C66DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x001C84EC File Offset: 0x001C66EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x001C84FC File Offset: 0x001C66FC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x001C850C File Offset: 0x001C670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x001C851C File Offset: 0x001C671C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x001C852C File Offset: 0x001C672C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MountDataEvent other)
		{
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x001C853C File Offset: 0x001C673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x001C854C File Offset: 0x001C674C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x001C855C File Offset: 0x001C675C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MountDataEvent()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_e621bd617de146f9855080dd522b3e0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				MountDataEvent._parser = new MessageParser<MountDataEvent>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_954df8e9eca7464ab016741f95fe1be2 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x001C8640 File Offset: 0x001C6840
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool XMiHYDOrjHQxxFGBCrKy()
		{
			return true;
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x001C8648 File Offset: 0x001C6848
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MountDataEvent vwWKuVOrKbtTLoWYgXcl()
		{
			return null;
		}

		// Token: 0x04000ECA RID: 3786
		private static readonly MessageParser<MountDataEvent> _parser;

		// Token: 0x04000ECB RID: 3787
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ECC RID: 3788
		public const int MountDataFieldNumber = 1;

		// Token: 0x04000ECD RID: 3789
		private MountData mountData_;

		// Token: 0x04000ECE RID: 3790
		internal static MountDataEvent qtdrFuOr4Uqv8Z2ynP8h;
	}
}
